using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;
using System.IO;
using System.Reflection;
namespace FallasI.Src
{
    public partial class VideoSample : Form
    {
        public VideoSample()
        {
            InitializeComponent();
        }
           //create the video

        public static String SaquePlano = "Resources/SaquePlano.avi";
        public static String SaqueConEfecto = "Resources/SaqueConEfecto.avi";
        
        public void PlayVideo(String nombrevideo){
            if (nombrevideo == SaquePlano || nombrevideo == SaqueConEfecto)
            {
               
                try
                {
                    Microsoft.DirectX.AudioVideoPlayback.Video video = new Microsoft.DirectX.AudioVideoPlayback.Video(nombrevideo);
                    //set the System.Windows.Forms.Control to play it in (e.g a panel)
                    video.Owner = this;
                    //Play the video (put this in a buttons click event)
                    video.Audio.Volume = 0;
                    video.Play();
                }
                catch
                {
                    //nothing
                }
            }
        }
        
        
    }
}
