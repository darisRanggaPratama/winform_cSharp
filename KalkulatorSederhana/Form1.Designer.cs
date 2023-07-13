namespace KalkulatorSederhana
{
	partial class Form1
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
			this.txt1 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.btnTambah = new System.Windows.Forms.Button();
			this.btnKurang = new System.Windows.Forms.Button();
			this.btnKali = new System.Windows.Forms.Button();
			this.btnBagi = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(35, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Angka1";
			
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(35, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Angka2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(32, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Angka3";
			// 
			// txt1
			// 
			this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt1.Location = new System.Drawing.Point(112, 24);
			this.txt1.Multiline = true;
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(200, 24);
			this.txt1.TabIndex = 3;
			// 
			// txt2
			// 
			this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt2.Location = new System.Drawing.Point(112, 72);
			this.txt2.Multiline = true;
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(200, 24);
			this.txt2.TabIndex = 4;
			// 
			// txt3
			// 
			this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt3.Location = new System.Drawing.Point(112, 120);
			this.txt3.Multiline = true;
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(200, 24);
			this.txt3.TabIndex = 5;
			// 
			// btnTambah
			// 
			this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTambah.Location = new System.Drawing.Point(16, 168);
			this.btnTambah.Name = "btnTambah";
			this.btnTambah.Size = new System.Drawing.Size(75, 32);
			this.btnTambah.TabIndex = 6;
			this.btnTambah.Text = "Tambah";
			this.btnTambah.UseVisualStyleBackColor = true;
			this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
			// 
			// btnKurang
			// 
			this.btnKurang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKurang.Location = new System.Drawing.Point(104, 168);
			this.btnKurang.Name = "btnKurang";
			this.btnKurang.Size = new System.Drawing.Size(75, 32);
			this.btnKurang.TabIndex = 7;
			this.btnKurang.Text = "Kurang";
			this.btnKurang.UseVisualStyleBackColor = true;
			this.btnKurang.Click += new System.EventHandler(this.btnKurang_Click);
			// 
			// btnKali
			// 
			this.btnKali.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKali.Location = new System.Drawing.Point(192, 168);
			this.btnKali.Name = "btnKali";
			this.btnKali.Size = new System.Drawing.Size(75, 32);
			this.btnKali.TabIndex = 8;
			this.btnKali.Text = "Kali";
			this.btnKali.UseVisualStyleBackColor = true;
			this.btnKali.Click += new System.EventHandler(this.btnKali_Click);
			// 
			// btnBagi
			// 
			this.btnBagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBagi.Location = new System.Drawing.Point(280, 168);
			this.btnBagi.Name = "btnBagi";
			this.btnBagi.Size = new System.Drawing.Size(75, 32);
			this.btnBagi.TabIndex = 9;
			this.btnBagi.Text = "Bagi";
			this.btnBagi.UseVisualStyleBackColor = true;
			this.btnBagi.Click += new System.EventHandler(this.btnBagi_Click);
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.Location = new System.Drawing.Point(408, 168);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 32);
			this.btnReset.TabIndex = 10;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 223);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnBagi);
			this.Controls.Add(this.btnKali);
			this.Controls.Add(this.btnKurang);
			this.Controls.Add(this.btnTambah);
			this.Controls.Add(this.txt3);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SimpleCalculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.Button btnTambah;
		private System.Windows.Forms.Button btnKurang;
		private System.Windows.Forms.Button btnKali;
		private System.Windows.Forms.Button btnBagi;
		private System.Windows.Forms.Button btnReset;
	}
}

