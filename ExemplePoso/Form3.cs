using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using VidalAPI;


namespace ExemplePoso
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
             vxpPath.Text = getVxpPath();
             labelVersion.Text = getVxpVersion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Form1 f = new Form1();
            FormEPPWS f = new FormEPPWS(new VidalHelperNative());
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEPPWS f2 =  new FormEPPWS(new VidalHelperWS( textBox1.Text));
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
         //   lancer VXP
            System.Diagnostics.ProcessStartInfo vxp = new System.Diagnostics.ProcessStartInfo();
            vxp.FileName = getVxpPath();
            System.Diagnostics.Process.Start(vxp);
           
            
        }
        public string getVxpPath(){
            
         StringBuilder path = new StringBuilder(256);
         //ProductLine vidalProduct = new ProductLine(productId);
         VidalHelper_getVidalAppPath(ProductLineID.VIDALEXPERT_PRODUCTID, path, 256);
         return path.ToString();
        }
        public string getVxpVersion()
        {

            StringBuilder path = new StringBuilder(256);
            //ProductLine vidalProduct = new ProductLine(productId);
            VidalHelper_getVidalAppVersion(ProductLineID.VIDALEXPERT_PRODUCTID, path, 256);
            return path.ToString();
        }

        [DllImportAttribute("vidalhelper.dll", CharSet = CharSet.None)]
        internal static extern int VidalHelper_getVidalAppPath(
            ProductLineID productID,
            [MarshalAs(UnmanagedType.LPStr)] StringBuilder path,
            int maxsize);   

        [DllImportAttribute("vidalhelper.dll", CharSet = CharSet.None)]
        internal static extern int VidalHelper_getVidalAppVersion(
            ProductLineID productID,
            [MarshalAs(UnmanagedType.LPStr)] StringBuilder version,
            int maxsize);   
    }
}
