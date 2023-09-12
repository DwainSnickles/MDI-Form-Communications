using System;
using System.Drawing;
using System.Windows.Forms;
using static FormCommunications.FrmChild;

namespace FormCommunications
{
    public partial class FrmParent : Form
    {
        //Delegate Sub to pass Image from child to parent when button is clicked on child
        public delegate void SaveImage(Image SurfaceImage);

        public FrmParent()
        {
            InitializeComponent();
        }

        private void btnSendImageToChildForm_Click(object sender, EventArgs e)
        {
            // clear the picture box incase it already has the image
            //only needed if image is aquired by using the btnGetImageFromChild
            //before show the actual child form
            picReceivedFromChild.Image = null;

            //Create a new instance of child using exteneded construtor wich passes the image to child
            FrmChild newMDIChild = new FrmChild(picToSendToChild.Image);

            //Set the Mdi Parent if is Mdi 
            newMDIChild.MdiParent = this;

            //Add MDI Child event handler to receive image from child
            newMDIChild.SendChildImage += new SaveImage(SaveSurfaceImage);

            //Display the child form
            newMDIChild.Show();
        }

        public void SaveSurfaceImage(Image SurfaceImage)
        {
            picReceivedFromChild.Image = SurfaceImage;
        }

        private void btnGetImageFromChild_Click(object sender, EventArgs e)
        {
            //the child constructer must set TheChildImage or null error will occur 
            //Create a new instance of child to set thechild image
            FrmChild newMDIChild = new FrmChild();
            newMDIChild.MdiParent = this;
            picReceivedFromChild.Image = FrmChild.TheChildImage;
        }

        ////Used for testing multiple Child formm
        //private void btnRemoveChildImage_Click(object sender, EventArgs e)
        //{
        //    picToSendToChild.Image = null;
        //}
    }
}
