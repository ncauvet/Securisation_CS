using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExemplePoso
{
    public partial class RecosForm : Form
    {
        private IVidalHelper helper;
        public RecosForm()
        {
            InitializeComponent();
        }
        public RecosForm(List<string> prescription, String patient,IVidalHelper helper)
        {
            InitializeComponent();
            this.helper = helper;
            ServiceAnalysis.ArrayOfCodedReco recos  = helper.recos(prescription, patient);
            foreach (ServiceAnalysis.codedReco reco in recos)
            {
                if (reco != null && reco.recommendation != null)
                {
                    recoslistBox.Items.Add(reco.recommendation);
                }
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
