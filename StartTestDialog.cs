using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DotDotApp
{
	public partial class StartTestDialog : Form
	{
		public TestInfo TestInfo { get; set; }
		public StartTestDialog()
		{
			TestInfo = null;
			InitializeComponent();
		}

		private void useTimeLimitCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			minutesUpDown.Enabled = label2.Enabled = secondsUpDown.Enabled = 
				label3.Enabled = useTimeLimitCheckBox.Checked;

		}

		private void startButton_Click(object sender, EventArgs e)
		{
			TestInfo = new TestInfo((int)questionsUpDown.Value, useTimeLimitCheckBox.Checked);
			if (useTimeLimitCheckBox.Checked)
				TestInfo.totalTime = new TimeSpan(0, (int)minutesUpDown.Value, (int)secondsUpDown.Value);
			this.DialogResult = DialogResult.OK;
			this.Dispose();
		}
	}
}
