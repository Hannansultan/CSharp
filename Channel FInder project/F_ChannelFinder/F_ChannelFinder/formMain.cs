using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;
#region emgu cv libs
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.XFeatures2D;
using System.Linq;

#endregion

namespace F_ChannelFinder
{
    public partial class formMain : Form
    {
        #region variables required
        private string conStr = @"Data Source=Lenovo;Initial Catalog=ChannelFinder;Integrated Security=True";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        UI ui;
        PerfromSurf surf = new PerfromSurf();
        Utilities utlities;
        private DialogResult dr;
        ChannelFinderEntities1 context;
        private static int widht, height;
        string filePath, targetPath;
        int gId;
        bool _lock;
        Image image = null;
        SqlDataAdapter ad;
        List<double> polyAreas = new List<double>();
        double polyArea;
        static List<Image> imageList = new List<Image>();
        static ImageList imgList = new ImageList();
        static List<int> idList = new List<int>();
        List<Image<Bgr, byte>> imagesList = new List<Image<Bgr, byte>>();

        Dictionary<int, double> polyAreaWithImage = new Dictionary<int, double>();

        #endregion

        public formMain()
        {
            Thread thread = new Thread(new ThreadStart(startSplah));
            thread.Start();
            Thread.Sleep(5000);
            thread.Abort(0);

            _lock = false;
            widht = 711;
            height = 432;
            InitializeComponent();
            ui = new UI();
            utlities = new Utilities();

        }
        /// <summary>
        /// To start Splash screen form
        /// </summary>
        /// 
        public void startSplah()
        {
            try
            {
                Application.Run(new formSplashScreen());
            }
            catch (ThreadAbortException ex )
            {
                MessageBox.Show(ex.ToString());
                //Console.WriteLine(ex.ToString());
                // ignore it;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            
        }

        private void pbLoadVideo_MouseEnter(object sender, EventArgs e)
        {
            ui.picBoxBackColor(pbLoadVideo, System.Drawing.SystemColors.ControlDarkDark);
        }

        private void pbLoadVideo_MouseLeave(object sender, EventArgs e)
        {
            ui.picBoxBackColor(pbLoadVideo, Color.Transparent);
        }

        private void pbFindLogo_MouseEnter(object sender, EventArgs e)
        {
            ui.picBoxBackColor(pbFindLogo, System.Drawing.SystemColors.ControlDarkDark);
        }

        private void pbFindLogo_MouseLeave(object sender, EventArgs e)
        {
            ui.picBoxBackColor(pbFindLogo, Color.Transparent);
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            ui.setVisibilty(grpBoxFindLogo, false);
            ui.setVisibilty(grpBoxSelectVideo, false);
            ui.setVisibilty(grpBoxAddImage, false);
            ui.setVisibilty(grpBoxAllLogo, false);
            ui.setVisibilty(grpBoxPic, false);
            
            setFormSize(false, false, true);
            
            ui.setLabelsText(lblProgramName, "Channel Finder");
        }

        /// <summary>
        /// TO confirm closing of form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            dr = new DialogResult();
            dr = MessageBox.Show("Are you sure to Exit ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void pbLoadVideo_Click(object sender, EventArgs e)
        {
            ui.setVisibilty(grpBoxFindLogo, false);
            ui.setVisibilty(grpBoxSelectVideo, true);
            ui.setVisibilty(grpBoxAddImage, false);
            ui.setVisibilty(grpBoxAllLogo, false);
            ui.setVisibilty(grpBoxPic, false);
            setFormSize(true, false,false);
        }

        private 
            void pbFindLogo_Click(object sender, EventArgs e)
        {
            ui.setVisibilty(grpBoxFindLogo, true);
            ui.setVisibilty(grpBoxSelectVideo, false);
            ui.setVisibilty(grpBoxAddImage, false);
            ui.setVisibilty(grpBoxAllLogo, false);
            ui.setVisibilty(grpBoxPic, false);
            setFormSize(false, true, false);
            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofdVideoPath.ShowDialog();
            tbFilePath.Text = ofdVideoPath.FileName.ToString();
            filePath = ofdVideoPath.FileName.ToString(); 
        }

        private void btnFramesPath_Click(object sender, EventArgs e)
        {
            dr =  saveFileDilgFrames.ShowDialog();
            if (dr == DialogResult.OK)
            {
                tbFramesPath.Text = saveFileDilgFrames.SelectedPath.ToString();
                targetPath = tbFramesPath.Text + @"\";
            }
            

        }

        private void btnConvertToFrames_Click(object sender, EventArgs e)
        {
            if (tbFilePath.Text != null && tbFramesPath.Text != null)
            {
                progrsBarFrames.Maximum = 199; //ui.progressBarMaxValue(progrsBarFrames, filePath);
                progrsBarFrames.Minimum = 0;
                lblFramesPathText.Text = targetPath;
                lblVideoPathText.Text = filePath;
                utlities.convertVideoToFrame(filePath, targetPath, progrsBarFrames);
            }
           
        }

        private void tbFramesPath_TextChanged(object sender, EventArgs e)
        {
            btnConvertToFrames.Enabled = true;
            progrsBarFrames.Enabled = true;
        }

       // ------------------------------------- USING OLD SQL SERVER QUERIES---------------------------------------||
       //-------------------------------------- TRying to use Entity Frame work------------------------------------ ||
       //------------------------------------- Fialed to use EF ;(= ----------------------------------------------- ||
        #region Insert logo into DB
        private void btnAddLogo_Click(object sender, EventArgs e)
        {
            insertLogo();
        }

        /// <summary>
        /// To add logo into database
        /// </summary>
        private void insertLogo()
        {
            try
            {
                byte[] imageData = ReadFile(tbLogoPath.Text);

                sqlConnection = new SqlConnection(conStr);
                sqlConnection.Open();
                string qry = @"insert into ChannelLogo (Image,ImageTag,ChannleName) values(@Image,@ImageTag,@ChannleName)";
                sqlCommand = new SqlCommand(qry, sqlConnection);
                sqlCommand.Parameters.AddWithValue("Image", (object) imageData);
                sqlCommand.Parameters.AddWithValue("ImageTag", tbLogoTag.Text.ToString());
                sqlCommand.Parameters.AddWithValue("ChannleName", tbChannelName.Text.ToString());
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Added Successfully","Operation Successfull",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        /// <summary>
        /// To Open file in to a filestream and read data in a byte array.
        /// </summary>
        /// <param name="sPath"></param>
        /// <returns></returns>
        
        byte[] ReadFile(string sPath)
        {
            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to supply number of bytes to read from file.
            //In this case we want to read entire file. So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);
            return data;
        }

        #endregion

        private void dgvImageStore_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                //Get image data from gridview column.
                byte[] imageData = (byte[])dgvImageStore.Rows[e.RowIndex].Cells["Image"].Value;

                //Initialize image variable
                Image newImage;
                //Read image data into a memory stream
                using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                {
                    ms.Write(imageData, 0, imageData.Length);

                    //Set image variable value using memory stream.
                    newImage = Image.FromStream(ms, true);
                }

                //set picture
                pictureBox1.Image = newImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private Image readImagefromDB(DataGridViewCellEventArgs e)
        {
            try
            {
                //Get image data from gridview column.
                byte[] imageData = (byte[])dgvImageStore.Rows[e.RowIndex].Cells["Image"].Value;



                //Initialize image variable
                Image newImage;
                //Read image data into a memory stream
                using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                {
                    ms.Write(imageData, 0, imageData.Length);

                    //Set image variable value using memory stream.
                    newImage = Image.FromStream(ms, true);
                }

                //set picture
                image = newImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            return image;
        }

        private void addLogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ui.setVisibilty(grpBoxFindLogo, false);
            ui.setVisibilty(grpBoxSelectVideo, false);
            ui.setVisibilty(grpBoxAddImage, true);
            ui.setVisibilty(grpBoxAllLogo, false);
            ui.setVisibilty(grpBoxPic, false);
            ui.setGroupBoxLocation(grpBoxAddImage, 81, 404);
            //setFormSize(false, false, true);
        }

        private void viewAllLogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ui.setVisibilty(grpBoxFindLogo, false);
            ui.setVisibilty(grpBoxSelectVideo, false);
            ui.setVisibilty(grpBoxAddImage, false);
            ui.setVisibilty(grpBoxAllLogo, true);
            ui.setVisibilty(grpBoxPic, true);
            ui.setVisibilty(grpBoxSlectOperation, false);
            ui.setGroupBoxLocation(grpBoxAllLogo, 81, 404);
            ui.setGroupBoxLocation(grpBoxPic, 81, 85);
            getImageFromDB();
        }

        private void btnBrosLogo_Click(object sender, EventArgs e)
        {
            
            ofdVideoPath.ShowDialog();
            tbLogoPath.Text = ofdVideoPath.FileName.ToString();

        }

        #region SURF OPERATION FOUND HERE
        /// <summary>
        /// PerformSURF on each images got from DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartSURF_Click(object sender, EventArgs e)
        {
            try
            {
                getImageFromDB();

                // ------------------------------------------- Imported from SURF_TEST project-------------------\\
                //  label9.Text = PerformSURF.goodMatch.ToString();
                //  lblRecSize.Text = PerformSURF.ployArea.ToString();
                //  lblMatches.Text = PerformSURF.count.ToString();
                //  lblPercentage.Text = PerformSURF.percentage.ToString();
                //  lblHomography.Text = PerformSURF.homographySizeHeight.ToString();
                //  lblHomographytwo.Text = PerformSURF.homographySizeWidht.ToString();
                //  lblMatchTime.Text = PerformSURF.time.ToString() + " Seconds";
                //  lblMatchedKayPoints.Text = PerformSURF.matchedPoints.ToString();
                //  lblObservedKeyPoints.Text = PerformSURF.obsrvedPoints.ToString();
                //  lblLineMatched.Text = PerformSURF.matchesNew.ToString();


                progrsBarSURF.Maximum = Utilities.frameList.Count ;
                progrsBarSURF.Minimum = 0;
                imagesList = utlities.getList();
                // ------------------------------------------ For Accuracy MY ALGORITHM ----------------------------\\
                //  ||------------------------------------------- Right now seems no way to implement it -----------||
                // Re quired -- > Poly area , rectangle size , Percentage ;  --- > accurateHigh ( % >= 50, area < 3000 > ) , accurateMid ( % 25 , 49 , area < 3000 >), accurateLow;
                //--------------------------------------------------------------------------------------------------//

                for (int i = 0; i < Utilities.frameList.Count; i++)
                {

                    progrsBarSURF.Value = i;
                    for (int j = 0; j < imageList.Count; j++)
                    {
                        Image<Bgr, byte> fnd = new Image<Bgr, byte>(new Bitmap(imageList[j]));
                        Image<Bgr, byte> src = Utilities.frameList[i];
                        Mat srcImg = new Mat(); //200, 200, DepthType.Cv8U, 1
                        srcImg = src.Mat;
                        Mat fndImg = new Mat();
                        fndImg = fnd.Mat;
                        long a = 1000;

                        imageBoxSURF.Image = PerfromSurf.Draw(fndImg, srcImg, out a);
                        polyArea = PerfromSurf.ployArea;
                        polyAreaWithImage.Add(idList[j], polyArea);
                        //polyAreas.Add(polyArea);
                        break;
                        // --------------------------------------------- FIND A SOLUTION BOY :P ----------------------- \\
                        //-------------------------------- Only FIRST FRAME MATCHED WITH DB IMAGEES ------------------- ||
                        //--------------------------------------------- NO SOLUTION FOUND UNTIL :(---------------------//

                    }
                    gId = polyAreaWithImage.FirstOrDefault(x => x.Value == polyAreaWithImage.Values.Max()).Key;

                    string query = @"Select ChannleName from ChannelLogo Where ID=@id";
                    sqlConnection = new SqlConnection(conStr);
                    sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("id", gId);

                    sqlConnection.Open();
                    string channelName = (string)sqlCommand.ExecuteScalar();
                    sqlConnection.Close();
                    MessageBox.Show("Video channel is  " + channelName);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show( ex.ToString());
            }
           
        }

        private void getImageFromDB()
        {
            try
            { 
                sqlConnection = new SqlConnection(conStr);

                SqlDataAdapter ADAP = new SqlDataAdapter("Select * from ChannelLogo", sqlConnection);

                //Initialize Dataset.
                DataSet DS = new DataSet();

                //Fill dataset with ImagesStore table.
                ADAP.Fill(DS, "ChannelLogo");

                
                //Fill Grid with dataset.
                
                dgvImageStore.DataSource = DS.Tables["ChannelLogo"];

                int size = 0 ;
                foreach (DataGridViewRow item in dgvImageStore.Rows )
                {
                    byte[] imageData = (byte[]) item.Cells[1].Value;
                    int id = Convert.ToInt32( item.Cells[0].Value);
                    //Initialize image variable
                    Image newImage;
                    //Read image data into a memory stream
                    using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                    {
                        ms.Write(imageData, 0, imageData.Length);

                        //Set image variable value using memory stream.
                        newImage = Image.FromStream(ms, true);
                    }
                    if (size == dgvImageStore.RowCount -1 )
                    {
                        break;
                    }
                    size++;
                    //set picture
                    //imgList.Images.Add (newImage);
                    idList.Add(id);
                    imageList.Add(newImage);
                }
                MessageBox.Show("size of list  " + imageList.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        #endregion

        // 717, 432 initail size
        // 717, 607 video click size
        /// <summary>
        /// To change the size of form as required
        /// </summary>
        /// <param name="picBoxVideoPressed"></param>
        /// <param name="picBoxFindLogoPressed"></param>
        public void setFormSize(bool picBoxVideoPressed, bool picBoxFindLogoPressed, bool initial)
        {
            if (picBoxVideoPressed)
            {
                if (this.Size == new Size(widht, height))
                {
                    for (int i = height; i <= height + (607 - height); i++)
                    {
                        this.Size = new Size(widht, i);
                        //Thread.Sleep(2);
                        
                    }
                    ui.setVisibilty(grpBoxFindLogo, false);
                    ui.setGroupBoxLocation(grpBoxSelectVideo, 81, 404);
                    ui.setVisibilty(grpBoxSelectVideo, true);
                    _lock = true;
                }
                else if (this.Size == new Size(widht, height + (607 - height)) && _lock == false)
                {
                    for (int i = height + (607 - height); i >= height; i--)
                    {
                        this.Size = new Size(widht, i);
                        //Thread.Sleep(2);
                        
                    }
                    ui.setVisibilty(grpBoxFindLogo, false);
                    ui.setGroupBoxLocation(grpBoxSelectVideo, 81, 404);
                    ui.setVisibilty(grpBoxSelectVideo, false);
                }
                else if (this.Size == new Size(widht, height + (607 - height)) && _lock == true)
                {
                    ui.setVisibilty(grpBoxFindLogo, false);
                    ui.setGroupBoxLocation(grpBoxSelectVideo, 81, 404);
                    ui.setVisibilty(grpBoxSelectVideo, true);
                }
            }
            else if (picBoxFindLogoPressed)
            {
                if (this.Size == new Size(widht, height))
                {
                    for (int i = height; i <= height + (607 - height); i++)
                    {
                        this.Size = new Size(widht, i);
                        //Thread.Sleep(2);

                    }
                    ui.setVisibilty(grpBoxSelectVideo, false);
                    ui.setGroupBoxLocation(grpBoxFindLogo, 81, 404);
                    ui.setVisibilty(grpBoxFindLogo, true);
                    _lock = true;
                }
                else if (this.Size == new Size(widht, height + (607 - height)) && _lock == false)
                {
                    for (int i = height + (607 - height); i >= height; i--)
                    {
                        this.Size = new Size(widht, i);
                        //Thread.Sleep(2);
                    }
                    ui.setVisibilty(grpBoxSelectVideo, false);
                    ui.setGroupBoxLocation(grpBoxFindLogo, 81, 404);
                    ui.setVisibilty(grpBoxFindLogo, false);
                }
                else if (this.Size == new Size(widht, height + (607 - height)) && _lock == true)
                {

                    ui.setVisibilty(grpBoxSelectVideo, false);
                    ui.setGroupBoxLocation(grpBoxFindLogo, 81, 404);
                    ui.setVisibilty(grpBoxFindLogo, true);
                }
            }
            else if (initial)
            {
                this.Size = new Size(widht, height);
            }
        }
    }
}
