using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace F_ChannelFinder
{

    
    /// ------------------------ Handle UI events --------------------- \\
    

    
    public class UI
    {
        Utilities utilities = new Utilities();
        //formMain form_main = new formMain();
        
        
        
        /// <summary>
        /// To change Backcolor of pictureBox
        /// </summary>
        /// <param name="pictureBox"></param>
        /// <param name="backColor"></param>
        public void picBoxBackColor(PictureBox pictureBox, Color backColor)
        {
            pictureBox.BackColor = backColor;
        }
        /// <summary>
        /// To set Labels Text
        /// </summary>
        /// <param name="label"></param>
        /// <param name="labelText"></param>
        public void setLabelsText(Label label, string labelText)
        {
            label.Text = labelText;
        }
        
        /// <summary>
        /// To get & set Progress Bar maximum value
        /// </summary>
        /// <param name="progressBar"></param>
        /// <param name="file"></param>
        /// <returns></returns>
        public int progressBarMaxValue(ProgressBar progressBar, String file)
        {
            progressBar.Maximum = Convert.ToInt32(utilities.getVideoDuration(file)) * Convert.ToInt32(utilities.getVieoFPS(file)) + 3;

            return progressBar.Maximum;
        }
        public int progressBarMaxValue(ProgressBar progressBar, int noOfImagesInDB)
        {
            progressBar.Maximum = noOfImagesInDB;

            return progressBar.Maximum;
        }

       

        // 81, 404 grpbox video slection location
        /// <summary>
        /// To set location of groupBox
        /// </summary>
        /// <param name="groupBox"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void setGroupBoxLocation(GroupBox groupBox , int x , int y)
        {
            groupBox.Location = new Point(x, y);
        }
        /// <summary>
        /// To set the visibility of groupBox
        /// </summary>
        /// <param name="groubox"></param>
        /// <param name="visibility"></param>
        public void setVisibilty(GroupBox groubox, bool visibility)
        {
            groubox.Visible = visibility;
        }

    }
}
