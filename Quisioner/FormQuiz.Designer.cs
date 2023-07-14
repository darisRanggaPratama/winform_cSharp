namespace Quisioner
{
	partial class MyQuiz
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnSend = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.gboxGender = new System.Windows.Forms.GroupBox();
			this.rbtnMale = new System.Windows.Forms.RadioButton();
			this.rbtnFemale = new System.Windows.Forms.RadioButton();
			this.cmboxOccupation = new System.Windows.Forms.ComboBox();
			this.ckboxCsharp = new System.Windows.Forms.CheckBox();
			this.ckboxCplus = new System.Windows.Forms.CheckBox();
			this.ckboxJava = new System.Windows.Forms.CheckBox();
			this.ckboxPython = new System.Windows.Forms.CheckBox();
			this.lblResult = new System.Windows.Forms.Label();
			this.gboxGender.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(64, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(64, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Gender";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(64, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Occupation";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(64, 168);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(152, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Programming Skill";
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.ForeColor = System.Drawing.SystemColors.Highlight;
			this.btnReset.Location = new System.Drawing.Point(288, 216);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 32);
			this.btnReset.TabIndex = 4;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnSend
			// 
			this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSend.ForeColor = System.Drawing.SystemColors.Highlight;
			this.btnSend.Location = new System.Drawing.Point(424, 216);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 32);
			this.btnSend.TabIndex = 5;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(240, 48);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(344, 24);
			this.txtName.TabIndex = 6;
			// 
			// gboxGender
			// 
			this.gboxGender.Controls.Add(this.rbtnFemale);
			this.gboxGender.Controls.Add(this.rbtnMale);
			this.gboxGender.Location = new System.Drawing.Point(240, 80);
			this.gboxGender.Name = "gboxGender";
			this.gboxGender.Size = new System.Drawing.Size(344, 48);
			this.gboxGender.TabIndex = 7;
			this.gboxGender.TabStop = false;
			this.gboxGender.Text = "Gender";
			// 
			// rbtnMale
			// 
			this.rbtnMale.AutoSize = true;
			this.rbtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtnMale.Location = new System.Drawing.Point(8, 16);
			this.rbtnMale.Name = "rbtnMale";
			this.rbtnMale.Size = new System.Drawing.Size(58, 22);
			this.rbtnMale.TabIndex = 0;
			this.rbtnMale.TabStop = true;
			this.rbtnMale.Text = "Male";
			this.rbtnMale.UseVisualStyleBackColor = true;
			// 
			// rbtnFemale
			// 
			this.rbtnFemale.AutoSize = true;
			this.rbtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtnFemale.Location = new System.Drawing.Point(144, 16);
			this.rbtnFemale.Name = "rbtnFemale";
			this.rbtnFemale.Size = new System.Drawing.Size(75, 22);
			this.rbtnFemale.TabIndex = 1;
			this.rbtnFemale.TabStop = true;
			this.rbtnFemale.Text = "Female";
			this.rbtnFemale.UseVisualStyleBackColor = true;
			// 
			// cmboxOccupation
			// 
			this.cmboxOccupation.FormattingEnabled = true;
			this.cmboxOccupation.Items.AddRange(new object[] {
            "Government Employee",
            "Non Govenment Employee"});
			this.cmboxOccupation.Location = new System.Drawing.Point(240, 128);
			this.cmboxOccupation.Name = "cmboxOccupation";
			this.cmboxOccupation.Size = new System.Drawing.Size(344, 21);
			this.cmboxOccupation.TabIndex = 8;
			// 
			// ckboxCsharp
			// 
			this.ckboxCsharp.AutoSize = true;
			this.ckboxCsharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckboxCsharp.Location = new System.Drawing.Point(248, 168);
			this.ckboxCsharp.Name = "ckboxCsharp";
			this.ckboxCsharp.Size = new System.Drawing.Size(46, 22);
			this.ckboxCsharp.TabIndex = 9;
			this.ckboxCsharp.Text = "C#";
			this.ckboxCsharp.UseVisualStyleBackColor = true;
			// 
			// ckboxCplus
			// 
			this.ckboxCplus.AutoSize = true;
			this.ckboxCplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckboxCplus.Location = new System.Drawing.Point(312, 168);
			this.ckboxCplus.Name = "ckboxCplus";
			this.ckboxCplus.Size = new System.Drawing.Size(56, 22);
			this.ckboxCplus.TabIndex = 10;
			this.ckboxCplus.Text = "C++";
			this.ckboxCplus.UseVisualStyleBackColor = true;
			// 
			// ckboxJava
			// 
			this.ckboxJava.AutoSize = true;
			this.ckboxJava.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckboxJava.Location = new System.Drawing.Point(384, 168);
			this.ckboxJava.Name = "ckboxJava";
			this.ckboxJava.Size = new System.Drawing.Size(58, 22);
			this.ckboxJava.TabIndex = 11;
			this.ckboxJava.Text = "Java";
			this.ckboxJava.UseVisualStyleBackColor = true;
			// 
			// ckboxPython
			// 
			this.ckboxPython.AutoSize = true;
			this.ckboxPython.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckboxPython.Location = new System.Drawing.Point(464, 168);
			this.ckboxPython.Name = "ckboxPython";
			this.ckboxPython.Size = new System.Drawing.Size(73, 22);
			this.ckboxPython.TabIndex = 12;
			this.ckboxPython.Text = "Python";
			this.ckboxPython.UseVisualStyleBackColor = true;
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResult.Location = new System.Drawing.Point(24, 272);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(50, 18);
			this.lblResult.TabIndex = 13;
			this.lblResult.Text = "Result";
			// 
			// MyQuiz
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(659, 408);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.ckboxPython);
			this.Controls.Add(this.ckboxJava);
			this.Controls.Add(this.ckboxCplus);
			this.Controls.Add(this.ckboxCsharp);
			this.Controls.Add(this.cmboxOccupation);
			this.Controls.Add(this.gboxGender);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MyQuiz";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SimpleQuiz";
			this.gboxGender.ResumeLayout(false);
			this.gboxGender.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.GroupBox gboxGender;
		private System.Windows.Forms.RadioButton rbtnMale;
		private System.Windows.Forms.RadioButton rbtnFemale;
		private System.Windows.Forms.ComboBox cmboxOccupation;
		private System.Windows.Forms.CheckBox ckboxCsharp;
		private System.Windows.Forms.CheckBox ckboxCplus;
		private System.Windows.Forms.CheckBox ckboxJava;
		private System.Windows.Forms.CheckBox ckboxPython;
		private System.Windows.Forms.Label lblResult;
	}
}

