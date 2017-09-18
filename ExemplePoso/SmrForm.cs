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
	public partial class SmrForm : Form
	{
		public SmrForm(String html)
		{
			InitializeComponent();
			webBrowser1.DocumentText = html;
		}
	}
}
