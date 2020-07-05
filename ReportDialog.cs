using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DotDotApp
{
	public partial class ReportDialog : Form
	{
		public ReportDialog(TestInfo TestInfo)
		{
			//init comps
			InitializeComponent();
			//fill comps
			CalculateGreetMessage(TestInfo);
			CalculateAwardMessage(TestInfo);
			correctAnswersTextBox.Text = TestInfo.correctAnswers.ToString();
			totalQuestionsTextBox.Text = TestInfo.totalQuestions.ToString();
			scoreInGrade10TextBox.Text = TestInfo.scoreInGrade10.ToString();
			if (TestInfo.hasTimeLimit)
			{
				totalMinutesTextBox.Text = TestInfo.totalTime.Value.Minutes.ToString();
				totalSecondsTextBox.Text = TestInfo.totalTime.Value.Seconds.ToString();
				averageMinutesTextBox.Text = TestInfo.averageTimePerQuestion.Value.Minutes.ToString();
				averageSecondsTextBox.Text = TestInfo.averageTimePerQuestion.Value.Seconds.ToString();
			}
			else
			{
				totalMinutesTextBox.Enabled = false;
				totalSecondsTextBox.Enabled = false;
				averageMinutesTextBox.Enabled = false;
				averageSecondsTextBox.Enabled = false;

			}
				elapsedMinutesTextBox.Text = TestInfo.elapsedTime.Value.Minutes.ToString();
				elapsedSecondsTextBox.Text = TestInfo.elapsedTime.Value.Seconds.ToString();
				averageMinutesScoredTextBox.Text = TestInfo.averageTimePerQuestionScored.Value.Minutes.ToString();
				averageSecondsScoredTextBox.Text = TestInfo.averageTimePerQuestionScored.Value.Seconds.ToString();
			}
		private void CalculateGreetMessage(TestInfo testInfo)
		{
			Color color;
			string greetMessage = null;
			double score = testInfo.scoreInGrade10.Value;
			if(score == 0)
			{
				color = Color.Crimson;
				greetMessage = "Lowest score";
			}
			else if (score < 5)
			{
				color = Color.Chocolate;
				greetMessage = "Too Bad";
			}
			else if (score < 10)
			{
				color = Color.Silver;
				greetMessage = "Congratulation!";
			}
			else
			{
				color = Color.Orange;
				greetMessage = "Brilliance";
			}
			greetTextBox.ForeColor = color;
			greetTextBox.Text = greetMessage;
		}
		private void CalculateAwardMessage(TestInfo testInfo)
		{
			Color color;
			string award = null;
			if (testInfo.hasTimeLimit)
			{
				if(testInfo.averageTimePerQuestionScored.Value < testInfo.averageTimePerQuestion.Value)
				{
					color = Color.LightCoral;
					award = "The speedy rabit";
				}
				else
				{
					color = Color.Brown;
					award = "The careful bird";
				}
			}
			else
			{
				color = Color.SpringGreen;
					award = "The free explorer";
			}
			awardTextBox.ForeColor = color;
			awardTextBox.Text = award;
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			this.Visible = false;
		}
	}
}
