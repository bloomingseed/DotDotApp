namespace DotDotApp
{
	partial class Main
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.submitAnswerButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.totalTimeTextBox = new System.Windows.Forms.TextBox();
			this.remainingTimeTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.elapsedTimeTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.submitAnswerKeyButton = new System.Windows.Forms.Button();
			this.startTestButton = new System.Windows.Forms.Button();
			this.statusTextBox = new System.Windows.Forms.TextBox();
			this.seeTestResultButton = new System.Windows.Forms.Button();
			this.pauseButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 29);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridView1.ShowEditingIcon = false;
			this.dataGridView1.Size = new System.Drawing.Size(443, 321);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
			this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Data:";
			// 
			// submitAnswerButton
			// 
			this.submitAnswerButton.Enabled = false;
			this.submitAnswerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.submitAnswerButton.Location = new System.Drawing.Point(231, 435);
			this.submitAnswerButton.Name = "submitAnswerButton";
			this.submitAnswerButton.Size = new System.Drawing.Size(109, 23);
			this.submitAnswerButton.TabIndex = 2;
			this.submitAnswerButton.Text = "Submit Answer";
			this.submitAnswerButton.UseVisualStyleBackColor = true;
			this.submitAnswerButton.Click += new System.EventHandler(this.submitAnswerButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 356);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Status:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(27, 391);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Total Time:";
			// 
			// totalTimeTextBox
			// 
			this.totalTimeTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.totalTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.totalTimeTextBox.Location = new System.Drawing.Point(147, 388);
			this.totalTimeTextBox.Name = "totalTimeTextBox";
			this.totalTimeTextBox.ReadOnly = true;
			this.totalTimeTextBox.Size = new System.Drawing.Size(76, 23);
			this.totalTimeTextBox.TabIndex = 5;
			this.totalTimeTextBox.TabStop = false;
			// 
			// remainingTimeTextBox
			// 
			this.remainingTimeTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.remainingTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.remainingTimeTextBox.Location = new System.Drawing.Point(147, 484);
			this.remainingTimeTextBox.Name = "remainingTimeTextBox";
			this.remainingTimeTextBox.ReadOnly = true;
			this.remainingTimeTextBox.Size = new System.Drawing.Size(76, 23);
			this.remainingTimeTextBox.TabIndex = 7;
			this.remainingTimeTextBox.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(27, 487);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "Remaining Time:";
			// 
			// elapsedTimeTextBox
			// 
			this.elapsedTimeTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.elapsedTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.elapsedTimeTextBox.Location = new System.Drawing.Point(147, 434);
			this.elapsedTimeTextBox.Name = "elapsedTimeTextBox";
			this.elapsedTimeTextBox.ReadOnly = true;
			this.elapsedTimeTextBox.Size = new System.Drawing.Size(76, 23);
			this.elapsedTimeTextBox.TabIndex = 9;
			this.elapsedTimeTextBox.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(27, 437);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 17);
			this.label5.TabIndex = 8;
			this.label5.Text = "Elapsed Time:";
			// 
			// submitAnswerKeyButton
			// 
			this.submitAnswerKeyButton.Enabled = false;
			this.submitAnswerKeyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.submitAnswerKeyButton.Location = new System.Drawing.Point(231, 464);
			this.submitAnswerKeyButton.Name = "submitAnswerKeyButton";
			this.submitAnswerKeyButton.Size = new System.Drawing.Size(109, 43);
			this.submitAnswerKeyButton.TabIndex = 3;
			this.submitAnswerKeyButton.Text = "Submit Answer Key";
			this.submitAnswerKeyButton.UseVisualStyleBackColor = true;
			this.submitAnswerKeyButton.Click += new System.EventHandler(this.submitAnswerKeyButton_Click);
			// 
			// startTestButton
			// 
			this.startTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startTestButton.Location = new System.Drawing.Point(346, 385);
			this.startTestButton.Name = "startTestButton";
			this.startTestButton.Size = new System.Drawing.Size(109, 44);
			this.startTestButton.TabIndex = 4;
			this.startTestButton.Text = "Start New Test";
			this.startTestButton.UseVisualStyleBackColor = true;
			this.startTestButton.Click += new System.EventHandler(this.startTestButton_Click);
			// 
			// statusTextBox
			// 
			this.statusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusTextBox.Location = new System.Drawing.Point(70, 356);
			this.statusTextBox.Name = "statusTextBox";
			this.statusTextBox.ReadOnly = true;
			this.statusTextBox.Size = new System.Drawing.Size(385, 23);
			this.statusTextBox.TabIndex = 12;
			this.statusTextBox.Text = "Free";
			// 
			// seeTestResultButton
			// 
			this.seeTestResultButton.Enabled = false;
			this.seeTestResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.seeTestResultButton.Location = new System.Drawing.Point(346, 464);
			this.seeTestResultButton.Name = "seeTestResultButton";
			this.seeTestResultButton.Size = new System.Drawing.Size(109, 43);
			this.seeTestResultButton.TabIndex = 5;
			this.seeTestResultButton.Text = "See Test Result";
			this.seeTestResultButton.UseVisualStyleBackColor = true;
			this.seeTestResultButton.Click += new System.EventHandler(this.seeTestResultButton_Click);
			// 
			// pauseButton
			// 
			this.pauseButton.Enabled = false;
			this.pauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pauseButton.Location = new System.Drawing.Point(231, 385);
			this.pauseButton.Name = "pauseButton";
			this.pauseButton.Size = new System.Drawing.Size(109, 44);
			this.pauseButton.TabIndex = 1;
			this.pauseButton.Text = "Pause Test";
			this.pauseButton.UseVisualStyleBackColor = true;
			this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(467, 519);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ResumeLayout(false);
			this.Controls.Add(this.pauseButton);
			this.Controls.Add(this.seeTestResultButton);
			this.Controls.Add(this.statusTextBox);
			this.Controls.Add(this.startTestButton);
			this.Controls.Add(this.submitAnswerKeyButton);
			this.Controls.Add(this.elapsedTimeTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.remainingTimeTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.totalTimeTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.submitAnswerButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Main";
			this.Text = "Dot Dot";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button submitAnswerButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox totalTimeTextBox;
		private System.Windows.Forms.TextBox remainingTimeTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox elapsedTimeTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button submitAnswerKeyButton;
		private System.Windows.Forms.Button startTestButton;
		private System.Windows.Forms.TextBox statusTextBox;
		private System.Windows.Forms.Button seeTestResultButton;
		private System.Windows.Forms.Button pauseButton;
	}
}

