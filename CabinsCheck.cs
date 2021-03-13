using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Windows.Forms;



namespace Project
{
    public partial class frmCabinsCheck : Form
    {
        /* Student Id: 92060016
         * Name: Dan Hayworth
         * Date: 15-03-2021
         */
        public frmCabinsCheck()
        {
            InitializeComponent();
        }
        //load all details from dashboard specific to the cabin button clicked
        private void frmCabinsCheck_Load(object sender, EventArgs e)
        {
            txtName.Text = frmMain.NameClient;
            txtSurname.Text = frmMain.Surname;
            txtPhone.Text = frmMain.PhoneNumber.ToString();
            txtCheckIn.Text = frmMain.CheckIn;
            txtCheckOut.Text = frmMain.CheckOut;
            txtNights.Text = getNights();
            txtCabinNumber.Text = frmMain.CabinNumber.ToString();
            txtCabinType.Text = frmMain.CabinType;
        }
        //calculate how many nights the guest will stay
        private string getNights()
        {         
            DateTime startDate = Convert.ToDateTime(txtCheckIn.Text);
            DateTime endDate = Convert.ToDateTime(txtCheckOut.Text);
            var daysTotal = (endDate - startDate).TotalDays;
            string nights = daysTotal.ToString();
            return nights;
        }
        //close form and return to dashboard
        private void imgClose_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.Show();
            this.Close();
        }
        //link label button
        private void aFooter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://developit.co.nz");
        }
        //generate invoice using openfiledialog and a word template
        private void btnShowInv_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please use CabinInvoice.docx provided along with this software.", "Important!");
            //set up openfiledialog 
            using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames =true, Multiselect =false, Filter = "Word Document|*.docx|Word 97-2003|*.doc|Word Document|*.rtf" })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    //using Microsoft Office Interop as refference will open a word document
                    object readOnly = false;
                    object visible = true;    
                    object filename = ofd.FileName;
                    object missing = Type.Missing;
                    object saveChanges = 0;
                    Microsoft.Office.Interop.Word._Document document;
                    Microsoft.Office.Interop.Word._Application application = new Microsoft.Office.Interop.Word.Application() { Visible = false };
                    document = application.Documents.Open(ref filename, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
                    //gets document and edit the fields according to the client in the background
                    document.Activate();
                    this.findAndReplace(application, "<Name>", txtName.Text);
                    this.findAndReplace(application, "<Surname>", txtSurname.Text);
                    this.findAndReplace(application, "<Phone>", txtPhone.Text);
                    this.findAndReplace(application, "<room>", txtCabinType.Text);
                    this.findAndReplace(application, "<nights>", txtNights.Text);
                    this.findAndReplace(application, "<rate>", getRate());
                    this.findAndReplace(application, "<total>", getTotal());
                    this.findAndReplace(application, "<sub>", getTotal());
                    this.findAndReplace(application, "<gst>", getGst());
                    this.findAndReplace(application, "<due>", (Convert.ToInt32(total)+Convert.ToInt32(gst)).ToString());   
                    //select the entire document
                    document.ActiveWindow.Selection.WholeStory();
                    //copy the selection
                    document.ActiveWindow.Selection.Copy();         
                    //create a new clipboard
                    IDataObject dataObject = Clipboard.GetDataObject();
                    //add copied selection to the rich text box
                    richTextBox.Rtf = dataObject.GetData(DataFormats.Rtf).ToString();
                    //quit application without saving the template with the new details
                    application.Quit(ref saveChanges, ref missing, ref missing);                  
                }
            }        
        }
        //set up new strings for rate gst and total for calculations
        public string rate;
        public string gst;
        public string total;
        //perform calculation for the rate
        private string getRate()
        {
            string suiteC = "300";
            string doubleC = "200";
            string singleC = "100";
            
            if(txtCabinType.Text == "Suite")
            {
                rate = suiteC;
            }
            if(txtCabinType.Text == "Double")
            {
                rate = doubleC;
            }
            else
            {
                rate = singleC;
            }

            return rate;
        }
        //calculate toatl invoice
        private string getTotal()
        {
            total = (int.Parse(rate) * Convert.ToInt32(txtNights.Text)).ToString();
            return total;
        }
        //calculate gst
        private string getGst()
        {
            gst = (Convert.ToInt32(total)* 0.15).ToString();
            return gst;
        }
        //method for using find a nd replace  
        private void findAndReplace(Microsoft.Office.Interop.Word._Application application,
            object findText, object replaceText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object replace = 2;
            object wrap = 1;
            application.Selection.Find.Execute(ref findText, ref matchCase,
                ref matchWholeWord, ref matchWildCards, ref matchSoundsLike,
                ref matchAllWordForms, ref forward, ref wrap, ref format,
                ref replaceText, ref replace, ref matchKashida,
                        ref matchDiacritics,
                ref matchAlefHamza, ref matchControl);
        }
        //set up  a bitmap 
        Bitmap bitmap;
        //print page created from bitmap
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        //event for printing invoice
        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            //redeclare the bitmap with details from richtextbox only
            bitmap = new Bitmap(this.richTextBox.Width, this.richTextBox.Height);
            richTextBox.DrawToBitmap(bitmap, new Rectangle(100, 0, this.richTextBox.Width, this.richTextBox.Height));
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.PrintPreviewControl.Zoom = 1.2;
            printPreviewDialog.ShowDialog();
        }
        //print invoice as jpeg using save file dialog
        private void btnSavePdf_Click(object sender, EventArgs e)
        {
            //create new save file dialog
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Jpeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            dialog.Title = "InvoiceGuest";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //set up the codec and parameters for the image
                ImageCodecInfo myImageCodecInfo;
                Encoder myEncoder;
                EncoderParameter myEncoderParameter;
                EncoderParameters myEncoderParameters;
                // Get an ImageCodecInfo object that represents the JPEG codec.
                myImageCodecInfo = GetEncoderInfo("image/jpeg");
                // for the Quality parameter category.
                myEncoder = Encoder.Quality;
                // EncoderParameter object in the array.
                myEncoderParameters = new EncoderParameters(1);
                bitmap = new Bitmap(this.richTextBox.Width, this.richTextBox.Height);
                richTextBox.DrawToBitmap(bitmap, new Rectangle(0, 0, this.richTextBox.Width, this.richTextBox.Height));
                // Save the bitmap as a JPEG file with quality level 75.
                myEncoderParameter = new EncoderParameter(myEncoder, 75L);
                myEncoderParameters.Param[0] = myEncoderParameter;
                //save as jpeg
                bitmap.Save(dialog.FileName, myImageCodecInfo, myEncoderParameters);
            }
        }
        //get encoders info for the image 
        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }
        //print messages for emailing invoice
        //smtp client not set up so is just and event 
        private void btnEmailInvoice_Click(object sender, EventArgs e)
        {
            string email = Interaction.InputBox("Enter your email address", "Add email", " ");
            MessageBox.Show("An email has been sent to " + email, "Confirmation");
        }
        //checkout button
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            bool stillIn = true;
            //loop through the list to find the curent client
            foreach(CheckingIn c in frmMain.inCabin)
            {
                if(txtName.Text == c.Name && txtSurname.Text == c.Surname && txtCabinNumber.Text == c.CabinNumber.ToString())
                {
                    //if match then remove the client
                    frmMain.inCabin.Remove(c);
                    stillIn = false;
                    break;
                }
            }
            //if removed then return to main
            if (!stillIn)
            {
                frmMain f = new frmMain();
                f.Show();
                this.Close();
            }
        }
    }
}
