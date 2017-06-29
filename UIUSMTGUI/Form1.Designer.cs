namespace UIUSMTGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.btnTemplate = new System.Windows.Forms.CheckBox();
            this.boxProfiles = new System.Windows.Forms.ComboBox();
            this.txtBackLocal = new System.Windows.Forms.TextBox();
            this.btnBackLocal = new System.Windows.Forms.Button();
            this.overwriteBtn = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateBtn = new System.Windows.Forms.RadioButton();
            this.daysBox = new System.Windows.Forms.TextBox();
            this.selectAllBtn = new System.Windows.Forms.CheckBox();
            this.profilesBox = new System.Windows.Forms.CheckedListBox();
            this.specificProfilesBtn = new System.Windows.Forms.RadioButton();
            this.allprofileBtn = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.encryptBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.encryptBtn = new System.Windows.Forms.CheckBox();
            this.btnMigrate = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxLAE = new System.Windows.Forms.CheckBox();
            this.boxLAC = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnRestoreLocal = new System.Windows.Forms.Button();
            this.txtRestoreLocal = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.restoreNoTechBtn = new System.Windows.Forms.RadioButton();
            this.restoreAllBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.decryptBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.decryptBtn = new System.Windows.Forms.CheckBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnProgress = new System.Windows.Forms.Button();
            this.btnBackLog = new System.Windows.Forms.Button();
            this.btnMIG = new System.Windows.Forms.Button();
            this.btnRestoreLog = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.tabPage1.Controls.Add(this.grpOutput);
            this.tabPage1.Controls.Add(this.overwriteBtn);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.btnMigrate);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.btnTemplate);
            this.grpOutput.Controls.Add(this.boxProfiles);
            this.grpOutput.Controls.Add(this.txtBackLocal);
            this.grpOutput.Controls.Add(this.btnBackLocal);
            resources.ApplyResources(this.grpOutput, "grpOutput");
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.TabStop = false;
            // 
            // btnTemplate
            // 
            resources.ApplyResources(this.btnTemplate, "btnTemplate");
            this.btnTemplate.Name = "btnTemplate";
            this.btnTemplate.UseVisualStyleBackColor = true;
            this.btnTemplate.CheckedChanged += new System.EventHandler(this.btnTemplate_CheckedChanged);
            // 
            // boxProfiles
            // 
            resources.ApplyResources(this.boxProfiles, "boxProfiles");
            this.boxProfiles.FormattingEnabled = true;
            this.boxProfiles.Items.AddRange(new object[] {
            resources.GetString("boxProfiles.Items"),
            resources.GetString("boxProfiles.Items1"),
            resources.GetString("boxProfiles.Items2"),
            resources.GetString("boxProfiles.Items3"),
            resources.GetString("boxProfiles.Items4")});
            this.boxProfiles.Name = "boxProfiles";
            this.boxProfiles.SelectedIndexChanged += new System.EventHandler(this.boxProfiles_SelectedIndexChanged);
            // 
            // txtBackLocal
            // 
            resources.ApplyResources(this.txtBackLocal, "txtBackLocal");
            this.txtBackLocal.Name = "txtBackLocal";
            this.txtBackLocal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBackLocal_MouseClick);
            this.txtBackLocal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBackLocal_KeyPress);
            // 
            // btnBackLocal
            // 
            resources.ApplyResources(this.btnBackLocal, "btnBackLocal");
            this.btnBackLocal.Name = "btnBackLocal";
            this.btnBackLocal.UseVisualStyleBackColor = true;
            this.btnBackLocal.Click += new System.EventHandler(this.btnBackLocal_Click);
            // 
            // overwriteBtn
            // 
            resources.ApplyResources(this.overwriteBtn, "overwriteBtn");
            this.overwriteBtn.Checked = true;
            this.overwriteBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.overwriteBtn.Name = "overwriteBtn";
            this.overwriteBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dateBtn);
            this.groupBox2.Controls.Add(this.daysBox);
            this.groupBox2.Controls.Add(this.selectAllBtn);
            this.groupBox2.Controls.Add(this.profilesBox);
            this.groupBox2.Controls.Add(this.specificProfilesBtn);
            this.groupBox2.Controls.Add(this.allprofileBtn);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // dateBtn
            // 
            resources.ApplyResources(this.dateBtn, "dateBtn");
            this.dateBtn.Name = "dateBtn";
            this.dateBtn.TabStop = true;
            this.dateBtn.UseVisualStyleBackColor = true;
            this.dateBtn.CheckedChanged += new System.EventHandler(this.dateBtn_CheckedChanged);
            // 
            // daysBox
            // 
            resources.ApplyResources(this.daysBox, "daysBox");
            this.daysBox.Name = "daysBox";
            this.daysBox.Tag = "";
            this.daysBox.Enter += new System.EventHandler(this.daysBox_Enter);
            this.daysBox.Leave += new System.EventHandler(this.daysBox_Leave);
            // 
            // selectAllBtn
            // 
            resources.ApplyResources(this.selectAllBtn, "selectAllBtn");
            this.selectAllBtn.Name = "selectAllBtn";
            this.selectAllBtn.UseVisualStyleBackColor = true;
            this.selectAllBtn.CheckedChanged += new System.EventHandler(this.selectAllBtn_CheckedChanged);
            // 
            // profilesBox
            // 
            resources.ApplyResources(this.profilesBox, "profilesBox");
            this.profilesBox.FormattingEnabled = true;
            this.profilesBox.Name = "profilesBox";
            this.profilesBox.Sorted = true;
            // 
            // specificProfilesBtn
            // 
            resources.ApplyResources(this.specificProfilesBtn, "specificProfilesBtn");
            this.specificProfilesBtn.Name = "specificProfilesBtn";
            this.specificProfilesBtn.UseVisualStyleBackColor = true;
            this.specificProfilesBtn.CheckedChanged += new System.EventHandler(this.specificProfilesBtn_CheckedChanged);
            // 
            // allprofileBtn
            // 
            resources.ApplyResources(this.allprofileBtn, "allprofileBtn");
            this.allprofileBtn.Checked = true;
            this.allprofileBtn.Name = "allprofileBtn";
            this.allprofileBtn.TabStop = true;
            this.allprofileBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.encryptBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.encryptBtn);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // encryptBox
            // 
            resources.ApplyResources(this.encryptBox, "encryptBox");
            this.encryptBox.Name = "encryptBox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // encryptBtn
            // 
            resources.ApplyResources(this.encryptBtn, "encryptBtn");
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.CheckedChanged += new System.EventHandler(this.encryptBtn_CheckedChanged);
            // 
            // btnMigrate
            // 
            resources.ApplyResources(this.btnMigrate, "btnMigrate");
            this.btnMigrate.Name = "btnMigrate";
            this.btnMigrate.UseVisualStyleBackColor = true;
            this.btnMigrate.Click += new System.EventHandler(this.btnMigrate_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnRestore);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtPassword);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.boxLAE);
            this.groupBox8.Controls.Add(this.boxLAC);
            resources.ApplyResources(this.groupBox8, "groupBox8");
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.TabStop = false;
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // boxLAE
            // 
            resources.ApplyResources(this.boxLAE, "boxLAE");
            this.boxLAE.Checked = true;
            this.boxLAE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.boxLAE.Name = "boxLAE";
            this.boxLAE.UseVisualStyleBackColor = true;
            // 
            // boxLAC
            // 
            resources.ApplyResources(this.boxLAC, "boxLAC");
            this.boxLAC.Checked = true;
            this.boxLAC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.boxLAC.Name = "boxLAC";
            this.boxLAC.UseVisualStyleBackColor = true;
            this.boxLAC.CheckedChanged += new System.EventHandler(this.boxLAC_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UIUSMTGUI.Properties.Resources.DomeWordLeft_BLACK;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnRestoreLocal);
            this.groupBox7.Controls.Add(this.txtRestoreLocal);
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // btnRestoreLocal
            // 
            resources.ApplyResources(this.btnRestoreLocal, "btnRestoreLocal");
            this.btnRestoreLocal.Name = "btnRestoreLocal";
            this.btnRestoreLocal.UseVisualStyleBackColor = true;
            this.btnRestoreLocal.Click += new System.EventHandler(this.btnRestoreLocal_Click);
            // 
            // txtRestoreLocal
            // 
            resources.ApplyResources(this.txtRestoreLocal, "txtRestoreLocal");
            this.txtRestoreLocal.Name = "txtRestoreLocal";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.restoreNoTechBtn);
            this.groupBox4.Controls.Add(this.restoreAllBtn);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // restoreNoTechBtn
            // 
            resources.ApplyResources(this.restoreNoTechBtn, "restoreNoTechBtn");
            this.restoreNoTechBtn.Name = "restoreNoTechBtn";
            this.restoreNoTechBtn.UseVisualStyleBackColor = true;
            // 
            // restoreAllBtn
            // 
            resources.ApplyResources(this.restoreAllBtn, "restoreAllBtn");
            this.restoreAllBtn.Checked = true;
            this.restoreAllBtn.Name = "restoreAllBtn";
            this.restoreAllBtn.TabStop = true;
            this.restoreAllBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.decryptBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.decryptBtn);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // decryptBox
            // 
            resources.ApplyResources(this.decryptBox, "decryptBox");
            this.decryptBox.Name = "decryptBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // decryptBtn
            // 
            resources.ApplyResources(this.decryptBtn, "decryptBtn");
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.CheckedChanged += new System.EventHandler(this.decryptBtn_CheckedChanged);
            // 
            // btnRestore
            // 
            resources.ApplyResources(this.btnRestore, "btnRestore");
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Controls.Add(this.groupBox6);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnProgress);
            this.groupBox6.Controls.Add(this.btnBackLog);
            this.groupBox6.Controls.Add(this.btnMIG);
            this.groupBox6.Controls.Add(this.btnRestoreLog);
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // btnProgress
            // 
            resources.ApplyResources(this.btnProgress, "btnProgress");
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.UseVisualStyleBackColor = true;
            this.btnProgress.Click += new System.EventHandler(this.btnProgress_Click);
            // 
            // btnBackLog
            // 
            resources.ApplyResources(this.btnBackLog, "btnBackLog");
            this.btnBackLog.Name = "btnBackLog";
            this.btnBackLog.UseVisualStyleBackColor = true;
            this.btnBackLog.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMIG
            // 
            resources.ApplyResources(this.btnMIG, "btnMIG");
            this.btnMIG.Name = "btnMIG";
            this.btnMIG.UseVisualStyleBackColor = true;
            this.btnMIG.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnRestoreLog
            // 
            resources.ApplyResources(this.btnRestoreLog, "btnRestoreLog");
            this.btnRestoreLog.Name = "btnRestoreLog";
            this.btnRestoreLog.UseVisualStyleBackColor = true;
            this.btnRestoreLog.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnMigrate;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox selectAllBtn;
        private System.Windows.Forms.CheckedListBox profilesBox;
        private System.Windows.Forms.RadioButton specificProfilesBtn;
        private System.Windows.Forms.RadioButton allprofileBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox encryptBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox encryptBtn;
        private System.Windows.Forms.Button btnMigrate;
        private System.Windows.Forms.CheckBox overwriteBtn;
        private System.Windows.Forms.TextBox daysBox;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.RadioButton dateBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox decryptBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox decryptBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton restoreNoTechBtn;
        private System.Windows.Forms.RadioButton restoreAllBtn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnBackLog;
        private System.Windows.Forms.Button btnMIG;
        private System.Windows.Forms.Button btnRestoreLog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox txtBackLocal;
        private System.Windows.Forms.Button btnRestoreLocal;
        private System.Windows.Forms.TextBox txtRestoreLocal;
        private System.Windows.Forms.Button btnProgress;
        private System.Windows.Forms.Button btnBackLocal;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox boxProfiles;
        private System.Windows.Forms.CheckBox btnTemplate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox boxLAC;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox boxLAE;
    }
}

