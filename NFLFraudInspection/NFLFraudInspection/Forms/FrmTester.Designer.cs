
namespace NFLFraudInspection.Forms
{
    partial class FrmTester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTester));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RadPSUPass = new System.Windows.Forms.RadioButton();
            this.RadPSUFail = new System.Windows.Forms.RadioButton();
            this.RadMagnetPass = new System.Windows.Forms.RadioButton();
            this.RadMagnetFail = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.RadBScreenPass = new System.Windows.Forms.RadioButton();
            this.RadBScreenFail = new System.Windows.Forms.RadioButton();
            this.LblSerialNumber = new System.Windows.Forms.Label();
            this.prompt = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.textBoxSN = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_loggedResult_BlueScreen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_loggedResult_MagnetTest = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_loggedResult_PSUTest = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.RadXrayPass = new System.Windows.Forms.RadioButton();
            this.RadXrayFail = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 66);
            this.label1.TabIndex = 5;
            this.label1.Text = "PSU Test";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(620, 66);
            this.label2.TabIndex = 6;
            this.label2.Text = "Manget Test";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RadPSUPass
            // 
            this.RadPSUPass.AutoSize = true;
            this.RadPSUPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadPSUPass.Location = new System.Drawing.Point(73, 16);
            this.RadPSUPass.Name = "RadPSUPass";
            this.RadPSUPass.Size = new System.Drawing.Size(153, 50);
            this.RadPSUPass.TabIndex = 7;
            this.RadPSUPass.Text = "PASS";
            this.RadPSUPass.UseVisualStyleBackColor = true;
            this.RadPSUPass.CheckedChanged += new System.EventHandler(this.RadPSUPass_CheckedChanged);
            // 
            // RadPSUFail
            // 
            this.RadPSUFail.AutoSize = true;
            this.RadPSUFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadPSUFail.Location = new System.Drawing.Point(341, 16);
            this.RadPSUFail.Name = "RadPSUFail";
            this.RadPSUFail.Size = new System.Drawing.Size(128, 50);
            this.RadPSUFail.TabIndex = 8;
            this.RadPSUFail.Text = "FAIL";
            this.RadPSUFail.UseVisualStyleBackColor = true;
            this.RadPSUFail.CheckedChanged += new System.EventHandler(this.RadPSUFail_CheckedChanged);
            // 
            // RadMagnetPass
            // 
            this.RadMagnetPass.AutoSize = true;
            this.RadMagnetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadMagnetPass.Location = new System.Drawing.Point(70, 14);
            this.RadMagnetPass.Name = "RadMagnetPass";
            this.RadMagnetPass.Size = new System.Drawing.Size(153, 50);
            this.RadMagnetPass.TabIndex = 7;
            this.RadMagnetPass.Text = "PASS";
            this.RadMagnetPass.UseVisualStyleBackColor = true;
            this.RadMagnetPass.CheckedChanged += new System.EventHandler(this.RadMagnetPass_CheckedChanged);
            // 
            // RadMagnetFail
            // 
            this.RadMagnetFail.AutoSize = true;
            this.RadMagnetFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadMagnetFail.Location = new System.Drawing.Point(338, 12);
            this.RadMagnetFail.Name = "RadMagnetFail";
            this.RadMagnetFail.Size = new System.Drawing.Size(128, 50);
            this.RadMagnetFail.TabIndex = 8;
            this.RadMagnetFail.Text = "FAIL";
            this.RadMagnetFail.UseVisualStyleBackColor = true;
            this.RadMagnetFail.CheckedChanged += new System.EventHandler(this.RadMagnetFail_CheckedChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(620, 66);
            this.label3.TabIndex = 9;
            this.label3.Text = "BlueScreen Inspection";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RadBScreenPass
            // 
            this.RadBScreenPass.AutoSize = true;
            this.RadBScreenPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadBScreenPass.Location = new System.Drawing.Point(70, 16);
            this.RadBScreenPass.Name = "RadBScreenPass";
            this.RadBScreenPass.Size = new System.Drawing.Size(153, 50);
            this.RadBScreenPass.TabIndex = 7;
            this.RadBScreenPass.Text = "PASS";
            this.RadBScreenPass.UseVisualStyleBackColor = true;
            this.RadBScreenPass.CheckedChanged += new System.EventHandler(this.RadBScreenPass_CheckedChanged);
            // 
            // RadBScreenFail
            // 
            this.RadBScreenFail.AutoSize = true;
            this.RadBScreenFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadBScreenFail.Location = new System.Drawing.Point(338, 16);
            this.RadBScreenFail.Name = "RadBScreenFail";
            this.RadBScreenFail.Size = new System.Drawing.Size(128, 50);
            this.RadBScreenFail.TabIndex = 8;
            this.RadBScreenFail.Text = "FAIL";
            this.RadBScreenFail.UseVisualStyleBackColor = true;
            this.RadBScreenFail.CheckedChanged += new System.EventHandler(this.RadBScreenFail_CheckedChanged);
            // 
            // LblSerialNumber
            // 
            this.LblSerialNumber.AutoSize = true;
            this.LblSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSerialNumber.Location = new System.Drawing.Point(21, 54);
            this.LblSerialNumber.Name = "LblSerialNumber";
            this.LblSerialNumber.Size = new System.Drawing.Size(90, 46);
            this.LblSerialNumber.TabIndex = 10;
            this.LblSerialNumber.Text = "SN:";
            // 
            // prompt
            // 
            this.prompt.BackColor = System.Drawing.Color.Black;
            this.prompt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prompt.ForeColor = System.Drawing.Color.Lime;
            this.prompt.Location = new System.Drawing.Point(4, 801);
            this.prompt.Name = "prompt";
            this.prompt.Size = new System.Drawing.Size(623, 43);
            this.prompt.TabIndex = 11;
            this.prompt.Text = "";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(620, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fraud Inspection Testing";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NFLFraudInspection.Properties.Resources.delete_48;
            this.pictureBox2.Location = new System.Drawing.Point(262, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NFLFraudInspection.Properties.Resources.check_48;
            this.pictureBox1.Location = new System.Drawing.Point(5, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::NFLFraudInspection.Properties.Resources.delete_48;
            this.pictureBox3.Location = new System.Drawing.Point(259, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::NFLFraudInspection.Properties.Resources.check_48;
            this.pictureBox4.Location = new System.Drawing.Point(2, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::NFLFraudInspection.Properties.Resources.delete_48;
            this.pictureBox5.Location = new System.Drawing.Point(259, 16);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::NFLFraudInspection.Properties.Resources.check_48;
            this.pictureBox6.Location = new System.Drawing.Point(2, 16);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // textBoxSN
            // 
            this.textBoxSN.BackColor = System.Drawing.Color.Black;
            this.textBoxSN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSN.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxSN.Location = new System.Drawing.Point(117, 55);
            this.textBoxSN.Name = "textBoxSN";
            this.textBoxSN.Size = new System.Drawing.Size(471, 42);
            this.textBoxSN.TabIndex = 19;
            this.textBoxSN.TextChanged += new System.EventHandler(this.textBoxSN_TextChanged);
            this.textBoxSN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSN_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_loggedResult_BlueScreen);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.RadBScreenPass);
            this.panel1.Controls.Add(this.RadBScreenFail);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Location = new System.Drawing.Point(12, 488);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 86);
            this.panel1.TabIndex = 20;
            // 
            // label_loggedResult_BlueScreen
            // 
            this.label_loggedResult_BlueScreen.AutoSize = true;
            this.label_loggedResult_BlueScreen.Location = new System.Drawing.Point(501, 44);
            this.label_loggedResult_BlueScreen.Name = "label_loggedResult_BlueScreen";
            this.label_loggedResult_BlueScreen.Size = new System.Drawing.Size(44, 17);
            this.label_loggedResult_BlueScreen.TabIndex = 1;
            this.label_loggedResult_BlueScreen.Text = "PASS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lastest result:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_loggedResult_MagnetTest);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.RadMagnetPass);
            this.panel2.Controls.Add(this.RadMagnetFail);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(12, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 77);
            this.panel2.TabIndex = 20;
            // 
            // label_loggedResult_MagnetTest
            // 
            this.label_loggedResult_MagnetTest.AutoSize = true;
            this.label_loggedResult_MagnetTest.Location = new System.Drawing.Point(507, 49);
            this.label_loggedResult_MagnetTest.Name = "label_loggedResult_MagnetTest";
            this.label_loggedResult_MagnetTest.Size = new System.Drawing.Size(44, 17);
            this.label_loggedResult_MagnetTest.TabIndex = 1;
            this.label_loggedResult_MagnetTest.Text = "PASS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(485, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lastest result:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label_loggedResult_PSUTest);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.RadPSUPass);
            this.panel3.Controls.Add(this.RadPSUFail);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(9, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(602, 77);
            this.panel3.TabIndex = 20;
            // 
            // label_loggedResult_PSUTest
            // 
            this.label_loggedResult_PSUTest.AutoSize = true;
            this.label_loggedResult_PSUTest.Location = new System.Drawing.Point(512, 37);
            this.label_loggedResult_PSUTest.Name = "label_loggedResult_PSUTest";
            this.label_loggedResult_PSUTest.Size = new System.Drawing.Size(44, 17);
            this.label_loggedResult_PSUTest.TabIndex = 1;
            this.label_loggedResult_PSUTest.Text = "PASS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(488, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Lastest result:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.pictureBox7);
            this.panel4.Controls.Add(this.pictureBox8);
            this.panel4.Controls.Add(this.RadXrayPass);
            this.panel4.Controls.Add(this.RadXrayFail);
            this.panel4.Location = new System.Drawing.Point(7, 646);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(604, 87);
            this.panel4.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "PASS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(490, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Lastest result:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::NFLFraudInspection.Properties.Resources.delete_48;
            this.pictureBox7.Location = new System.Drawing.Point(264, 15);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(48, 48);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::NFLFraudInspection.Properties.Resources.check_48;
            this.pictureBox8.Location = new System.Drawing.Point(7, 15);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(48, 48);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 24;
            this.pictureBox8.TabStop = false;
            // 
            // RadXrayPass
            // 
            this.RadXrayPass.AutoSize = true;
            this.RadXrayPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadXrayPass.Location = new System.Drawing.Point(75, 15);
            this.RadXrayPass.Name = "RadXrayPass";
            this.RadXrayPass.Size = new System.Drawing.Size(153, 50);
            this.RadXrayPass.TabIndex = 21;
            this.RadXrayPass.Text = "PASS";
            this.RadXrayPass.UseVisualStyleBackColor = true;
            this.RadXrayPass.CheckedChanged += new System.EventHandler(this.RadXrayPass_CheckedChanged);
            // 
            // RadXrayFail
            // 
            this.RadXrayFail.AutoSize = true;
            this.RadXrayFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadXrayFail.Location = new System.Drawing.Point(343, 15);
            this.RadXrayFail.Name = "RadXrayFail";
            this.RadXrayFail.Size = new System.Drawing.Size(128, 50);
            this.RadXrayFail.TabIndex = 22;
            this.RadXrayFail.Text = "FAIL";
            this.RadXrayFail.UseVisualStyleBackColor = true;
            this.RadXrayFail.CheckedChanged += new System.EventHandler(this.RadXrayFail_CheckedChanged);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.DimGray;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1, 577);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(620, 66);
            this.label10.TabIndex = 23;
            this.label10.Text = "Xray Inspection";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Enabled = false;
            this.BtnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirm.Location = new System.Drawing.Point(-2, 739);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(629, 56);
            this.BtnConfirm.TabIndex = 27;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // FrmTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 888);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxSN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prompt);
            this.Controls.Add(this.LblSerialNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTester";
            this.Text = "Fraud Inspection Tests";
            this.Load += new System.EventHandler(this.FrmTester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RadPSUPass;
        private System.Windows.Forms.RadioButton RadPSUFail;
        private System.Windows.Forms.RadioButton RadMagnetPass;
        private System.Windows.Forms.RadioButton RadMagnetFail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RadBScreenPass;
        private System.Windows.Forms.RadioButton RadBScreenFail;
        private System.Windows.Forms.Label LblSerialNumber;
        private System.Windows.Forms.RichTextBox prompt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox textBoxSN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_loggedResult_BlueScreen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_loggedResult_MagnetTest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_loggedResult_PSUTest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton RadXrayFail;
        private System.Windows.Forms.RadioButton RadXrayPass;
        private System.Windows.Forms.Button BtnConfirm;
    }
}