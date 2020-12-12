namespace beadando
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
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtCarInsert = new System.Windows.Forms.Button();
            this.TbRendszam = new System.Windows.Forms.TextBox();
            this.TbMarka = new System.Windows.Forms.TextBox();
            this.TbTipus = new System.Windows.Forms.TextBox();
            this.TbEvjarat = new System.Windows.Forms.TextBox();
            this.TbHp = new System.Windows.Forms.TextBox();
            this.TbCcm = new System.Windows.Forms.TextBox();
            this.TbCarId = new System.Windows.Forms.TextBox();
            this.CbTulajdonos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtCarTorles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CbCars = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BtTulajTorles = new System.Windows.Forms.Button();
            this.CbTulajok = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.TbDateOfBirth = new System.Windows.Forms.TextBox();
            this.TbTulajId = new System.Windows.Forms.TextBox();
            this.BtTulajInsert = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Transaction = null;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(719, 519);
            this.tabControl.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.BtCarInsert);
            this.tabPage1.Controls.Add(this.TbRendszam);
            this.tabPage1.Controls.Add(this.TbMarka);
            this.tabPage1.Controls.Add(this.TbTipus);
            this.tabPage1.Controls.Add(this.TbEvjarat);
            this.tabPage1.Controls.Add(this.TbHp);
            this.tabPage1.Controls.Add(this.TbCcm);
            this.tabPage1.Controls.Add(this.TbCarId);
            this.tabPage1.Controls.Add(this.CbTulajdonos);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.BtCarTorles);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.CbCars);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(711, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Autók";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Motor térfogata";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Teljesítmény(Le)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Évjárat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Típus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Márka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Rendszám";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tulajdonos";
            // 
            // BtCarInsert
            // 
            this.BtCarInsert.Location = new System.Drawing.Point(431, 430);
            this.BtCarInsert.Name = "BtCarInsert";
            this.BtCarInsert.Size = new System.Drawing.Size(243, 52);
            this.BtCarInsert.TabIndex = 12;
            this.BtCarInsert.Text = "Insert";
            this.BtCarInsert.UseVisualStyleBackColor = true;
            this.BtCarInsert.Click += new System.EventHandler(this.BtCarInsert_Click);
            // 
            // TbRendszam
            // 
            this.TbRendszam.Location = new System.Drawing.Point(402, 166);
            this.TbRendszam.Name = "TbRendszam";
            this.TbRendszam.Size = new System.Drawing.Size(294, 22);
            this.TbRendszam.TabIndex = 11;
            // 
            // TbMarka
            // 
            this.TbMarka.Location = new System.Drawing.Point(402, 208);
            this.TbMarka.Name = "TbMarka";
            this.TbMarka.Size = new System.Drawing.Size(294, 22);
            this.TbMarka.TabIndex = 10;
            // 
            // TbTipus
            // 
            this.TbTipus.Location = new System.Drawing.Point(402, 250);
            this.TbTipus.Name = "TbTipus";
            this.TbTipus.Size = new System.Drawing.Size(294, 22);
            this.TbTipus.TabIndex = 9;
            // 
            // TbEvjarat
            // 
            this.TbEvjarat.Location = new System.Drawing.Point(402, 294);
            this.TbEvjarat.Name = "TbEvjarat";
            this.TbEvjarat.Size = new System.Drawing.Size(294, 22);
            this.TbEvjarat.TabIndex = 8;
            // 
            // TbHp
            // 
            this.TbHp.Location = new System.Drawing.Point(402, 338);
            this.TbHp.Name = "TbHp";
            this.TbHp.Size = new System.Drawing.Size(294, 22);
            this.TbHp.TabIndex = 7;
            // 
            // TbCcm
            // 
            this.TbCcm.Location = new System.Drawing.Point(402, 384);
            this.TbCcm.Name = "TbCcm";
            this.TbCcm.Size = new System.Drawing.Size(294, 22);
            this.TbCcm.TabIndex = 6;
            // 
            // TbCarId
            // 
            this.TbCarId.Location = new System.Drawing.Point(402, 122);
            this.TbCarId.Name = "TbCarId";
            this.TbCarId.Size = new System.Drawing.Size(294, 22);
            this.TbCarId.TabIndex = 5;
            // 
            // CbTulajdonos
            // 
            this.CbTulajdonos.FormattingEnabled = true;
            this.CbTulajdonos.Location = new System.Drawing.Point(402, 78);
            this.CbTulajdonos.Name = "CbTulajdonos";
            this.CbTulajdonos.Size = new System.Drawing.Size(294, 24);
            this.CbTulajdonos.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insert";
            // 
            // BtCarTorles
            // 
            this.BtCarTorles.Location = new System.Drawing.Point(14, 135);
            this.BtCarTorles.Name = "BtCarTorles";
            this.BtCarTorles.Size = new System.Drawing.Size(171, 85);
            this.BtCarTorles.TabIndex = 2;
            this.BtCarTorles.Text = "Törlés";
            this.BtCarTorles.UseVisualStyleBackColor = true;
            this.BtCarTorles.Click += new System.EventHandler(this.BtCarTorles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Autó";
            // 
            // CbCars
            // 
            this.CbCars.FormattingEnabled = true;
            this.CbCars.Location = new System.Drawing.Point(14, 78);
            this.CbCars.Name = "CbCars";
            this.CbCars.Size = new System.Drawing.Size(203, 24);
            this.CbCars.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtTulajInsert);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.TbName);
            this.tabPage2.Controls.Add(this.TbDateOfBirth);
            this.tabPage2.Controls.Add(this.TbTulajId);
            this.tabPage2.Controls.Add(this.BtTulajTorles);
            this.tabPage2.Controls.Add(this.CbTulajok);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(711, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tulajdonosok";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 36);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tulajdonos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(372, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 36);
            this.label12.TabIndex = 4;
            this.label12.Text = "Insert";
            // 
            // BtTulajTorles
            // 
            this.BtTulajTorles.Location = new System.Drawing.Point(37, 151);
            this.BtTulajTorles.Name = "BtTulajTorles";
            this.BtTulajTorles.Size = new System.Drawing.Size(171, 85);
            this.BtTulajTorles.TabIndex = 6;
            this.BtTulajTorles.Text = "Törlés";
            this.BtTulajTorles.UseVisualStyleBackColor = true;
            this.BtTulajTorles.Click += new System.EventHandler(this.BtTulajTorles_Click);
            // 
            // CbTulajok
            // 
            this.CbTulajok.FormattingEnabled = true;
            this.CbTulajok.Location = new System.Drawing.Point(37, 97);
            this.CbTulajok.Name = "CbTulajok";
            this.CbTulajok.Size = new System.Drawing.Size(203, 24);
            this.CbTulajok.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(262, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Születési Dátum";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(339, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "Név";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(351, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 17);
            this.label15.TabIndex = 20;
            this.label15.Text = "ID";
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(378, 151);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(294, 22);
            this.TbName.TabIndex = 19;
            // 
            // TbDateOfBirth
            // 
            this.TbDateOfBirth.Location = new System.Drawing.Point(378, 214);
            this.TbDateOfBirth.Name = "TbDateOfBirth";
            this.TbDateOfBirth.Size = new System.Drawing.Size(294, 22);
            this.TbDateOfBirth.TabIndex = 18;
            // 
            // TbTulajId
            // 
            this.TbTulajId.Location = new System.Drawing.Point(378, 99);
            this.TbTulajId.Name = "TbTulajId";
            this.TbTulajId.Size = new System.Drawing.Size(294, 22);
            this.TbTulajId.TabIndex = 17;
            // 
            // BtTulajInsert
            // 
            this.BtTulajInsert.Location = new System.Drawing.Point(396, 285);
            this.BtTulajInsert.Name = "BtTulajInsert";
            this.BtTulajInsert.Size = new System.Drawing.Size(243, 52);
            this.BtTulajInsert.TabIndex = 23;
            this.BtTulajInsert.Text = "Insert";
            this.BtTulajInsert.UseVisualStyleBackColor = true;
            this.BtTulajInsert.Click += new System.EventHandler(this.BtTulajInsert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 519);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox CbTulajdonos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtCarTorles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbCars;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox TbRendszam;
        private System.Windows.Forms.TextBox TbMarka;
        private System.Windows.Forms.TextBox TbTipus;
        private System.Windows.Forms.TextBox TbEvjarat;
        private System.Windows.Forms.TextBox TbHp;
        private System.Windows.Forms.TextBox TbCcm;
        private System.Windows.Forms.TextBox TbCarId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtCarInsert;
        private System.Windows.Forms.Button BtTulajTorles;
        private System.Windows.Forms.ComboBox CbTulajok;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtTulajInsert;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.TextBox TbDateOfBirth;
        private System.Windows.Forms.TextBox TbTulajId;
    }
}

