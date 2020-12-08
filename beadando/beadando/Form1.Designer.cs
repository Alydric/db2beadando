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
            this.BtInsert = new System.Windows.Forms.Button();
            this.TbRendszam = new System.Windows.Forms.TextBox();
            this.TbMarka = new System.Windows.Forms.TextBox();
            this.TbTipus = new System.Windows.Forms.TextBox();
            this.TbEvjarat = new System.Windows.Forms.TextBox();
            this.TbHp = new System.Windows.Forms.TextBox();
            this.TbCcm = new System.Windows.Forms.TextBox();
            this.TbId = new System.Windows.Forms.TextBox();
            this.CbTulajdonos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtTorles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CbCars = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.BtInsert);
            this.tabPage1.Controls.Add(this.TbRendszam);
            this.tabPage1.Controls.Add(this.TbMarka);
            this.tabPage1.Controls.Add(this.TbTipus);
            this.tabPage1.Controls.Add(this.TbEvjarat);
            this.tabPage1.Controls.Add(this.TbHp);
            this.tabPage1.Controls.Add(this.TbCcm);
            this.tabPage1.Controls.Add(this.TbId);
            this.tabPage1.Controls.Add(this.CbTulajdonos);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.BtTorles);
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
            // BtInsert
            // 
            this.BtInsert.Location = new System.Drawing.Point(431, 430);
            this.BtInsert.Name = "BtInsert";
            this.BtInsert.Size = new System.Drawing.Size(243, 52);
            this.BtInsert.TabIndex = 12;
            this.BtInsert.Text = "Insert";
            this.BtInsert.UseVisualStyleBackColor = true;
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
            // TbId
            // 
            this.TbId.Location = new System.Drawing.Point(402, 122);
            this.TbId.Name = "TbId";
            this.TbId.Size = new System.Drawing.Size(294, 22);
            this.TbId.TabIndex = 5;
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
            // BtTorles
            // 
            this.BtTorles.Location = new System.Drawing.Point(14, 135);
            this.BtTorles.Name = "BtTorles";
            this.BtTorles.Size = new System.Drawing.Size(171, 85);
            this.BtTorles.TabIndex = 2;
            this.BtTorles.Text = "Törlés";
            this.BtTorles.UseVisualStyleBackColor = true;
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
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(711, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tulajdonosok";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox CbTulajdonos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtTorles;
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
        private System.Windows.Forms.TextBox TbId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtInsert;
    }
}

