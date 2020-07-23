using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DotDotApp
{
	public enum AppState
	{
		Start, EnterAnswer, EnterAnswerKey, DisplayTestReport
	}

	public partial class Main : Form
	{
		private TestInfo testInfo;
		private AppState state;
		private AppState State {
			get { return state; }
			set
			{
				state = value;
				OnStateChange.Invoke(this, new EventArgs());
			}
		}
		private Timer timer;
		private TimeSpan remainingTime;
		private int focusIndex;
		private ReportDialog reportDialog;
		private StartTestDialog testDialog;
		private delegate void ChangeCurrentCell(int Rindex, int Cindex);
		private event EventHandler OnStateChange;

		public Main()
		{
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = false;
			timer = new Timer();
			timer.Interval = 1000;
			timer.Tick += timer_Tick;
			OnStateChange += OnEnterAnswerState;
			OnStateChange += OnEnterAnswerKeyState;
			OnStateChange += OnDisplayTestResultState;
			OnStateChange += OnStartState;
			state = AppState.Start;
		}


		private void OnStartState(object sender, EventArgs args)
		{
			startTestButton.Focus();
		}



		private void OnEnterAnswerState(object sender, EventArgs args) {
			if (state != AppState.EnterAnswer)
				return;
			statusTextBox.Text = "Answering";
			submitAnswerButton.Enabled = true;
			submitAnswerKeyButton.Enabled = false;
			pauseButton.Enabled = true;
			dataGridView1.ReadOnly = false;

			dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
			{
				HeaderText = "ID",
				Name = "ID",
				ValueType = typeof(int)
			});
			dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
			{
				HeaderText = "Your Answer",
				Name = "YourAnswer",
				ValueType = typeof(string)
			});

			dataGridView1.Rows.Add(testInfo.totalQuestions);
			for (int i = 0; i < dataGridView1.RowCount; ++i)
			{
				dataGridView1.Rows[i].Cells[0].Value = i + 1;
				//dataGridView1.Rows[i].Cells[1].Value = "";

			}
			dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[1];
			if (testInfo.hasTimeLimit)
			{
				totalTimeTextBox.Text = ToDigitalString(testInfo.totalTime.Value);
				remainingTime = testInfo.totalTime.Value;
				remainingTimeTextBox.Text = ToDigitalString(remainingTime);
			}
			testInfo.elapsedTime = new TimeSpan(0, 0, 0);
			elapsedTimeTextBox.Text = ToDigitalString(testInfo.elapsedTime.Value);
			timer.Start();
		}
		private void timer_Tick(object sender, EventArgs args)
		{
			if (testInfo.hasTimeLimit)
			{
				if (remainingTime.TotalSeconds <= 0)
				{
					(sender as Timer).Stop();
					MessageBox.Show(this, "The time limit of " + ToDigitalString(testInfo.totalTime.Value) + " has passed.", "Time limit ended", MessageBoxButtons.OK);
					State = AppState.EnterAnswerKey;

				}
				else
				{
					TimeSpan sec = new TimeSpan(0, 0, 1);
					testInfo.elapsedTime = testInfo.elapsedTime.Value.Add(sec);
					remainingTime = remainingTime.Subtract(sec);
					elapsedTimeTextBox.Text = ToDigitalString(testInfo.elapsedTime.Value);
					remainingTimeTextBox.Text = ToDigitalString(this.remainingTime);
				}
			}
			else
			{
				TimeSpan sec = new TimeSpan(0, 0, 1);
				testInfo.elapsedTime = testInfo.elapsedTime.Value.Add(sec);
				elapsedTimeTextBox.Text = ToDigitalString(testInfo.elapsedTime.Value);

			}
			
		}


		private void OnEnterAnswerKeyState(object sender, EventArgs args) {
			if (state != AppState.EnterAnswerKey)
				return;
			if (testInfo.hasTimeLimit && timer.Enabled)
				timer.Stop();
			statusTextBox.Text = "Finished. Entering Answer Key";
			submitAnswerButton.Enabled = false;
			pauseButton.Enabled = false;
			submitAnswerKeyButton.Enabled = true;
			dataGridView1.ReadOnly = false;
			if (testInfo.hasTimeLimit)
			{
				testInfo.CalculateAverageTimePerQuestion();
			}
			testInfo.CalculateAverageTimePerQuestionScored();
			dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
			{
				HeaderText = "Answer Key",
				Name = "AnswerKey",
				ValueType = typeof(string)
			});
			dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[2];
			dataGridView1.Focus();
		}
		private void OnDisplayTestResultState(object sender, EventArgs args) {
			if (state != AppState.DisplayTestReport)
				return;
			dataGridView1.ReadOnly = true;
			seeTestResultButton.Enabled = true;
			submitAnswerKeyButton.Enabled = false;
			statusTextBox.Text = "Report test result";
			dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
			{
				HeaderText = "Result",
				Name = "Result",
				ValueType = typeof(string)
			});
			int count = 0;
			for (int i = 0; i < dataGridView1.RowCount; ++i)
			{
				if (dataGridView1.Rows[i].Cells[1].Value != null && TrimCellValue(dataGridView1.Rows[i].Cells[1].Value.ToString()) == TrimCellValue(dataGridView1.Rows[i].Cells[2].Value.ToString()))
				{
					dataGridView1.Rows[i].Cells[3].Value = "Correct";
					++count;
				}
				else
					dataGridView1.Rows[i].Cells[3].Value = "Incorrect";
			}
			testInfo.correctAnswers = count;
			testInfo.CalculateScoreInGrade10();
			reportDialog = new ReportDialog(testInfo);
			seeTestResultButton.Focus();
		}
		
		private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			focusIndex = state == AppState.EnterAnswerKey ? 2 : 1;
			if (e.ColumnIndex != focusIndex)
			{
				dataGridView1.BeginInvoke(new ChangeCurrentCell((row, col) =>
				{
					dataGridView1.CurrentCell = dataGridView1.Rows[row].Cells[col];
				}), e.RowIndex, focusIndex);
			}
		}

		private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			focusIndex = state == AppState.EnterAnswerKey ? 2 : 1;
			if (e.RowIndex < (dataGridView1.Rows.Count - 1))
			{
				dataGridView1.BeginInvoke(new ChangeCurrentCell((row, col) =>
				{
					dataGridView1.CurrentCell = dataGridView1.Rows[row].Cells[col];
				}), e.RowIndex + 1, focusIndex);
			}
		}
		public static string ToDigitalString(TimeSpan time)
		{ 
			if (time.Hours > 0)
				return $"{time.Hours}:{time.Minutes}:{time.Seconds}";
			else 
				return $"{time.Minutes}:{time.Seconds}";
		}

		private void startTestButton_Click(object sender, EventArgs e)
		{
			string status = statusTextBox.Text;
			statusTextBox.Text = "Starting new test";
			testDialog = new StartTestDialog();
			if(testDialog.ShowDialog(this) == DialogResult.OK)
			{
				testInfo = testDialog.TestInfo;
				//dataGridView1 = new DataGridView();
				//InitDataGridView1();
				dataGridView1.Rows.Clear();
				dataGridView1.Columns.Clear();
				State = AppState.EnterAnswer;
			}
			else
			{
				statusTextBox.Text = status;
			}
		}

		//private void InitDataGridView1()
		//{
		//	this.dataGridView1.AllowUserToAddRows = false;
		//	this.dataGridView1.AllowUserToDeleteRows = false;
		//	this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		//	this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		//	this.dataGridView1.Location = new System.Drawing.Point(12, 29);
		//	this.dataGridView1.MultiSelect = false;
		//	this.dataGridView1.Name = "dataGridView1";
		//	this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
		//	this.dataGridView1.ShowEditingIcon = false;
		//	this.dataGridView1.Size = new System.Drawing.Size(443, 321);
		//	this.dataGridView1.TabIndex = 0;
		//	this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
		//	this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
		//}

		private void pauseButton_Click(object sender, EventArgs e)
		{
			bool val = !timer.Enabled;
			timer.Enabled = val;
			dataGridView1.ReadOnly = !val;
		}

		private void submitAnswerButton_Click(object sender, EventArgs e)
		{
			timer.Enabled = false;
			if (MessageBox.Show(this, "Do you want to submit your answer(s)?", "Submit your answer(s) confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				State = AppState.EnterAnswerKey;
			}
			else
				timer.Enabled = true;
		}

		private void submitAnswerKeyButton_Click(object sender, EventArgs e)
		{
			foreach(DataGridViewRow row in dataGridView1.Rows)
				if(row.Cells[2].Value == null || TrimCellValue(row.Cells[2].Value.ToString()) == "")
				{
					MessageBox.Show(this, "All answer key(s) must be typed in before proceed", "All answer key(s) must be typed", MessageBoxButtons.OK);
					return;
				}
			if (MessageBox.Show(this, "Test report will be made based on your answer key(s). Do you want to proceed?", "Submit your answer key(s) confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				State = AppState.DisplayTestReport;
			}
		}
		private string TrimCellValue(string value)
		{
			return value.ToUpper().Trim();
		}

		private void seeTestResultButton_Click(object sender, EventArgs e)
		{
			reportDialog.Show(this);
		}
	}
}
