using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project
{
    public partial class frmCabinsCheck : Form
    {
        public frmCabinsCheck()
        {
            InitializeComponent();
        }

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

        private string getNights()
        {
            string nights;
            string[] dateIn;
            string[] dateOut;
            dateIn = txtCheckIn.Text.Split('-');
            dateOut = txtCheckOut.Text.Split('-');
            int i = Convert.ToInt32(dateIn[0]);
            int j = Convert.ToInt32(dateOut[0]);
            nights = (j - i).ToString();
            return nights;
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.Show();
            this.Close();
        }

        private void aFooter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://developit.co.nz");
        }

        private void btnShowInv_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames =true, Multiselect =false, Filter = "Word Document|*.docx|Word 97-2003|*.doc" })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    object readOnly = false;
                    object visible = true;
                    object save = false;
                    object filename = ofd.FileName;
                    object newTemplate = false;
                    object docType = 0;
                    object missing = Type.Missing;
                    Microsoft.Office.Interop.Word._Document document;
                    Microsoft.Office.Interop.Word._Application application = new Microsoft.Office.Interop.Word.Application() { Visible = false };
                    document = application.Documents.Open(ref filename, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
                    document.Activate();
                    this.FindAndReplace(application, "<Name>", txtName.Text);
                    this.FindAndReplace(application, "<Surname>", txtSurname.Text);
                    this.FindAndReplace(application, "<Phone>", txtPhone.Text);
                    this.FindAndReplace(application, "<room>", txtCabinType.Text);
                    this.FindAndReplace(application, "<nights>", txtNights.Text);
                    this.FindAndReplace(application, "<rate>", getRate());
                    this.FindAndReplace(application, "<total>", getTotal());
                    this.FindAndReplace(application, "<sub>", getTotal());
                    this.FindAndReplace(application, "<gst>", getGst());
                    this.FindAndReplace(application, "<due>", (Convert.ToInt32(total)+Convert.ToInt32(gst)).ToString());
                    //document.Save();
                    document.ActiveWindow.Selection.WholeStory();
                    document.ActiveWindow.Selection.Copy();               
                    IDataObject dataObject = Clipboard.GetDataObject();
                    richTextBox.Rtf = dataObject.GetData(DataFormats.Rtf).ToString();
                    application.Quit(ref missing, ref missing, ref missing);
                    
                    
                }
            }        
        }
        public string rate;
        public string gst;
        public string total;
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
        private string getTotal()
        {
            total = (int.Parse(rate) * Convert.ToInt32(txtNights.Text)).ToString();
            return total;
        }

        private string getGst()
        {
            gst = (Convert.ToInt32(total)* 0.15).ToString();
            return gst;
        }

        private void FindAndReplace(Microsoft.Office.Interop.Word._Application application,
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

 
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
         
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            
        }

    }
}
