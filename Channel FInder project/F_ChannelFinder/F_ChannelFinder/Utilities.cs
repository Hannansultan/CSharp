using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using Emgu.CV.Structure;
using Emgu.CV;


namespace F_ChannelFinder
{
    /// <summary>
    /// To perform videp related operation
    /// </summary>
    public class Utilities

    {
        public static List<Image<Bgr, byte>> frameList = new List<Image<Bgr, byte>>();
        /// <summary>
        /// To get specified file duration
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        
        public Double getVideoDuration(String file)
        {
            WindowsMediaPlayer wmp = new WindowsMediaPlayer();
            IWMPMedia mediainfo = wmp.newMedia(file);
            return mediainfo.duration;
        }
        /// <summary>
        /// To get specified file FPS
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public Double getVieoFPS(String file)
        {
            ShellObject obj = ShellObject.FromParsingName(file);
            ShellProperty<uint?> rateProp = obj.Properties.GetProperty<uint?>("System.Video.FrameRate");
            Double fps =  Convert.ToDouble(rateProp.Value / 1000.0);
            return fps;
        }

        /// <summary>
        /// To get frames of selected video frames
        /// </summary>
        /// <param name="file"></param>
        /// <param name="targetPath"></param>
        /// <param name="progressBar"></param>
        public void convertVideoToFrame(String file, String targetPath, ProgressBar progressBar)
        {
            int i = 0;
            try
            {
                Capture video = new Capture(file);
                bool reading;

                int nframes = (int)video.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount);
                nframes++;

                Mat frame;
                Image<Bgr, byte> image;

                

                reading = true;

                while (reading)
                {
                    frame = video.QueryFrame();
                    if (i != 200)
                    {
                        image = frame.ToImage<Bgr, byte>();
                        image.Save(targetPath + frame + i + ".jpg");
                        
                        progressBar.Value = i;
                        
                           
                        
                        image.Dispose();
                        frame.Dispose();
                    }
                    else
                    {
                        reading = false;
                        MessageBox.Show("Task Completed Sucessfully :) Enjoy :P");
                    }
                    i++;
                }
                Image<Bgr, byte> fnd = new Image<Bgr, byte>(targetPath + @"\Emgu.CV.Mat0.jpg");
                frameList.Add(fnd);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        /// <summary>
        /// To check list of images and get it
        /// </summary>
        /// <returns></returns>
        public List<Image<Bgr, byte>> getList()
        {


            return frameList;
        }

    
    }
}
