namespace DotDotApp
{
	partial class StartTestDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.startButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.minutesUpDown = new System.Windows.Forms.NumericUpDown();
			this.useTimeLimitCheckBox = new System.Windows.Forms.CheckBox();
			this.questionsUpDown = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.secondsUpDown = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.minutesUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.questionsUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.secondsUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(96, 132);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(75, 23);
			this.startButton.TabIndex = 0;
			this.startButton.Text = "Start Test";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(189, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Enter number of question(s):";
			// 
			// minutesUpDown
			// 
			this.minutesUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minutesUpDown.Location = new System.Drawing.Point(130, 52);
			this.minutesUpDown.Maximum = new decimal(new int[] {
            144,
            0,
            0,
            0});
			this.minutesUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.minutesUpDown.Name = "minutesUpDown";
			this.minutesUpDown.Size = new System.Drawing.Size(73, 23);
			this.minutesUpDown.TabIndex = 3;
			this.minutesUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// useTimeLimitCheckBox
			// 
			this.useTimeLimitCheckBox.AutoSize = true;
			this.useTimeLimitCheckBox.Checked = true;
			this.useTimeLimitCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.useTimeLimitCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.useTimeLimitCheckBox.Location = new System.Drawing.Point(11, 55);
			this.useTimeLimitCheckBox.Name = "useTimeLimitCheckBox";
			this.useTimeLimitCheckBox.Size = new System.Drawing.Size(114, 21);
			this.useTimeLimitCheckBox.TabIndex = 4;
			this.useTimeLimitCheckBox.Text = "Use time limit:";
			this.useTimeLimitCheckBox.UseVisualStyleBackColor = true;
			this.useTimeLimitCheckBox.CheckedChanged += new System.EventHandler(this.useTimeLimitCheckBox_CheckedChanged);
			// 
			// questionsUpDown
			// 
			this.questionsUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.questionsUpDown.Location = new System.Drawing.Point(207, 9);
			this.questionsUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.questionsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.questionsUpDown.Name = "questionsUpDown";
			this.questionsUpDown.Size = new System.Drawing.Size(73, 23);
			this.questionsUpDown.TabIndex = 5;
			this.questionsUpDown.ThousandsSeparator = true;
			this.questionsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(209, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "minute(s)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(209, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "second(s)";
			// 
			// secondsUpDown
			// 
			this.secondsUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.secondsUpDown.Location = new System.Drawing.Point(130, 83);
			this.secondsUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.secondsUpDown.Name = "secondsUpDown";
			this.secondsUpDown.Size = new System.Drawing.Size(73, 23);
			this.secondsUpDown.TabIndex = 7;
			// 
			// StartTestDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(289, 163);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.secondsUpDown);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.questionsUpDown);
			this.Controls.Add(this.useTimeLimitCheckBox);
			this.Controls.Add(this.minutesUpDown);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.startButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "StartTestDialog";
			this.Text = "Start A Test";
			((System.ComponentModel.ISupportInitialize)(this.minutesUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.questionsUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.secondsUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown minutesUpDown;
		private System.Windows.Forms.CheckBox useTimeLimitCheckBox;
		private System.Windows.Forms.NumericUpDown questionsUpDown;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown secondsUpDown;
	}
}