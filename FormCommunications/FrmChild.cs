using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FormCommunications.FrmParent;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace FormCommunications
{
    public partial class FrmChild : Form
    {
        //Constructer used to get child Image without showinf the child
        public FrmChild()
        {
            InitializeComponent();
            TheChildImage = picSentToParent.Image;
        }

        //The event used to send image to parent form
        //Have to add using statement above to reflect parent form
        //eg using static FormCommunications.FrmParent;
        public event SaveImage SendChildImage;

        //Create a constructor with Image that is passed from part
        //This image will be displayed in child picturebox
        public FrmChild(Image img)
        {
            InitializeComponent();
            picReceivedFromParent.Image = img;
        }

        private void btnSendImageToParentFForm_Click(object sender, EventArgs e)
        {
           SendChildImage(picSentToParent.Image);
        }

        //Code to send child image to mdi parent form

        public delegate void GetChildImage(Image ChildImage);

        //Sets TheChildImage when new constructor is called
        public static Image TheChildImage { get; set; }

        private void btnChangeChildImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Images Files (*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif)|*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif" +
            "|PNG Portable Network Graphics (*.png)|*.png" +
            "|JPEG File Interchange Format (*.jpg *.jpeg *jfif)|*.jpg;*.jpeg;*.jfif" +
            "|BMP Windows Bitmap (*.bmp)|*.bmp" +
            "|TIF Tagged Imaged File Format (*.tif *.tiff)|*.tif;*.tiff" +
            "|GIF Graphics Interchange Format (*.gif)|*.gif";

            ofd.Multiselect = false;
            ofd.CheckFileExists = true;
            ofd.ShowDialog();
            if (ofd.FileName != string.Empty)
            {
                picSentToParent.Image = Image.FromFile(ofd.FileName);

                //SET THE IMAGE to the image we are passing
                TheChildImage = picSentToParent.Image;
            }
        }
    }
}
