using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IPCamera
{
    class GetPicture
    {
        string url;
        string user;
        string pass;
        int delay = 0;
        private static ImageConverter imgconv = new ImageConverter();
        private CancellationTokenSource tokenSource = null;
        //\\\\\\\\\\\\\\\\\\\\\\\\\\\ここまで\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        //イベントハンドラ作成中取り合ずChromeのイベント入門を見た
        public delegate void ViewPic(object sender,IpCamEventArgs e);

        public class IpCamEventArgs : EventArgs
        {
            public Bitmap img;
            public int CountInt;
        }
        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private GetPicture()
        {

        }
        public GetPicture(string txtUrl, string txtUser, string txtPass)
        {
            this.url = txtUrl;
            this.user = txtUser;
            this.pass = txtPass;
        }

        public async Task CatchImgLoop()
        {
            int Count = 0;
            while (true)
            {
                using(tokenSource = new CancellationTokenSource())
                {
                    ++Count;
                    CancellationToken token = tokenSource.Token;
                    var bitmap = CatchImg();

                    await Task.Delay(delay);
                }
            }
        }

        public Bitmap CatchImg()
        {
            Bitmap ret = null;
            byte[] jpgByte = null;
            using (var client = new WebClient())
            {
                var namePass = string.Format("{0}:{1}", this.user, this.pass);
                var chars = System.Text.Encoding.ASCII.GetBytes(namePass);
                var base64 = Convert.ToBase64String(chars);
                client.Headers[HttpRequestHeader.Authorization] = "Basic " + base64;
                jpgByte = client.DownloadData(this.url);
            }
            Image img = (Image)imgconv.ConvertFrom(jpgByte);
            ret = new Bitmap(img);
            img.Dispose();
            return ret;
        }

        

    }
}
