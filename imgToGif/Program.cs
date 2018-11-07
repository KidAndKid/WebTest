using Gif.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static imgToGif.Program;

namespace imgToGif
{
    class Program
    {
        static void Main(string[] args)
        {
            PngsToGif(@"E:\Kid\codeImge\", @"E:\Kid\qq.gif", 3, true);
            //File.Copy(@"E:\Kid\codeImge\1.jpg", @"E:\Kid\1.jpg");

        
        }

        /// <summary>
        /// 把directory文件夹里的png文件生成为gif文件，放在giffile
        /// </summary>
        /// <param name="directory">png文件夹</param>
        /// <param name="giffile">gif保存路径</param>
        /// <param name="time">每帧的时间/ms</param>
        /// <param name="repeat">是否重复</param>
        public static void PngsToGif(string directory, string giffile, int time, bool repeat)
        {
            //一般文件名按顺序排
            //string[] pngfiles = Directory.GetFileSystemEntries(directory, "*.png");
            string[] pngfiles = Directory.GetFileSystemEntries(directory);
            AnimatedGifEncoder e = new AnimatedGifEncoder();
            e.Start(giffile);

            //每帧播放时间
            //e.SetDelay(3000);

            //-1：不重复，0：重复
            e.SetRepeat(repeat ? 0 : -1);
            int inttime = 2000;
            for (int i = 0, count = pngfiles.Length; i < count; i++)
            {
                e.SetDelay(inttime);
                e.AddFrame(Image.FromFile(pngfiles[i]));

                inttime += 4000;
            }
            e.Finish();
        }


        /// <summary>
        /// 把Gif文件转成Png文件，放在directory目录下
        /// </summary>
        /// <param name="file"></param>
        /// <param name="directory"></param>
        /// <returns></returns>
        public static void GifToPngs(string giffile, string directory)
        {
            GifDecoder gifDecoder = new GifDecoder();
            directory += "\\";
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            //读取
            gifDecoder.Read(giffile);
            for (int i = 0, count = gifDecoder.GetFrameCount(); i < count; i++)
            {
                Image frame = gifDecoder.GetFrame(i);  // frame i
                frame.Save(directory + "\\" + i.ToString("d2") + ".png", ImageFormat.Png);
                //转成jpg
                //frame.Save(directory + "\\" + i.ToString("d2") + ".jpg", ImageFormat.Jpeg);
            }
        }

        /// <summary>
        /// 获取路径下所有文件以及子文件夹中文件
        /// </summary>
        /// <param name="path">全路径根目录</param>
        /// <param name="FileList">存放所有文件的全路径</param>
        /// <param name="RelativePath"></param>
        /// <returns></returns>
        public static Dictionary<string, long> GetFile(string path, Dictionary<string, long> FileList, string RelativePath)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] fil = dir.GetFiles();
            DirectoryInfo[] dii = dir.GetDirectories();
            foreach (FileInfo f in fil)
            {
                //int size = Convert.ToInt32(f.Length);
                long size = f.Length;
                FileList.Add(f.FullName, size);//添加文件路径到列表中
            }
            //获取子文件夹内的文件列表，递归遍历
            foreach (DirectoryInfo d in dii)
            {
                GetFile(d.FullName, FileList, RelativePath);
            }
            return FileList;
        }

      
    }


}
