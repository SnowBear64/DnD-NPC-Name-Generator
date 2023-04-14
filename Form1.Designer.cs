namespace NpcNameGenerator
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
			this.btnRandomize = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.boxName = new System.Windows.Forms.CheckBox();
			this.lblName = new System.Windows.Forms.Label();
			this.txtLname = new System.Windows.Forms.TextBox();
			this.txtFname = new System.Windows.Forms.TextBox();
			this.boxRace = new System.Windows.Forms.CheckBox();
			this.lblRace = new System.Windows.Forms.Label();
			this.comboRace = new System.Windows.Forms.ComboBox();
			this.comboHumanName = new System.Windows.Forms.ComboBox();
			this.boxGender = new System.Windows.Forms.CheckBox();
			this.lblGender = new System.Windows.Forms.Label();
			this.txtGender = new System.Windows.Forms.TextBox();
			this.boxPhysicalQuality = new System.Windows.Forms.CheckBox();
			this.lblPhysicalQuality = new System.Windows.Forms.Label();
			this.txtPhysicalQuality = new System.Windows.Forms.TextBox();
			this.boxPersonalityQuirk = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPersonalityQuirk = new System.Windows.Forms.TextBox();
			this.boxIdeal = new System.Windows.Forms.CheckBox();
			this.lblIdeal = new System.Windows.Forms.Label();
			this.txtIdeal = new System.Windows.Forms.TextBox();
			this.boxBond = new System.Windows.Forms.CheckBox();
			this.lblBond = new System.Windows.Forms.Label();
			this.txtBond = new System.Windows.Forms.TextBox();
			this.boxFlawSecret = new System.Windows.Forms.CheckBox();
			this.lblFlawSecret = new System.Windows.Forms.Label();
			this.txtFlawSecret = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnRandomize
			// 
			this.btnRandomize.Location = new System.Drawing.Point(33, 311);
			this.btnRandomize.Name = "btnRandomize";
			this.btnRandomize.Size = new System.Drawing.Size(75, 23);
			this.btnRandomize.TabIndex = 0;
			this.btnRandomize.Text = "Randomize";
			this.btnRandomize.UseVisualStyleBackColor = true;
			this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(114, 311);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 1;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(195, 311);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// boxName
			// 
			this.boxName.AutoSize = true;
			this.boxName.Location = new System.Drawing.Point(28, 30);
			this.boxName.Name = "boxName";
			this.boxName.Size = new System.Drawing.Size(15, 14);
			this.boxName.TabIndex = 3;
			this.boxName.UseVisualStyleBackColor = true;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(49, 30);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(38, 13);
			this.lblName.TabIndex = 4;
			this.lblName.Text = "Name:";
			// 
			// txtLname
			// 
			this.txtLname.Location = new System.Drawing.Point(295, 27);
			this.txtLname.Name = "txtLname";
			this.txtLname.ReadOnly = true;
			this.txtLname.Size = new System.Drawing.Size(121, 20);
			this.txtLname.TabIndex = 5;
			// 
			// txtFname
			// 
			this.txtFname.Location = new System.Drawing.Point(168, 27);
			this.txtFname.Name = "txtFname";
			this.txtFname.ReadOnly = true;
			this.txtFname.Size = new System.Drawing.Size(121, 20);
			this.txtFname.TabIndex = 6;
			// 
			// boxRace
			// 
			this.boxRace.AutoSize = true;
			this.boxRace.Location = new System.Drawing.Point(28, 56);
			this.boxRace.Name = "boxRace";
			this.boxRace.Size = new System.Drawing.Size(15, 14);
			this.boxRace.TabIndex = 7;
			this.boxRace.UseVisualStyleBackColor = true;
			// 
			// lblRace
			// 
			this.lblRace.AutoSize = true;
			this.lblRace.Location = new System.Drawing.Point(49, 56);
			this.lblRace.Name = "lblRace";
			this.lblRace.Size = new System.Drawing.Size(36, 13);
			this.lblRace.TabIndex = 8;
			this.lblRace.Text = "Race:";
			// 
			// comboRace
			// 
			this.comboRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboRace.FormattingEnabled = true;
			this.comboRace.Items.AddRange(new object[] {
            "Dragonborn",
            "Dwarf",
            "Elf",
            "Gnome",
            "Half-Orc",
            "Halfling",
            "Human",
            "Tiefling"});
			this.comboRace.Location = new System.Drawing.Point(168, 53);
			this.comboRace.Name = "comboRace";
			this.comboRace.Size = new System.Drawing.Size(121, 21);
			this.comboRace.Sorted = true;
			this.comboRace.TabIndex = 9;
			this.comboRace.SelectedIndexChanged += new System.EventHandler(this.comboRace_SelectedIndexChanged);
			// 
			// comboHumanName
			// 
			this.comboHumanName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboHumanName.FormattingEnabled = true;
			this.comboHumanName.Items.AddRange(new object[] {
            "African",
            "Arabic",
            "Celtic",
            "Chinese",
            "Egyptian",
            "English",
            "French",
            "German",
            "Greek",
            "Indian",
            "Japanese",
            "Mesoamerican",
            "Norse",
            "Polynesian",
            "Roman",
            "Slavic",
            "Spanish"});
			this.comboHumanName.Location = new System.Drawing.Point(295, 53);
			this.comboHumanName.Name = "comboHumanName";
			this.comboHumanName.Size = new System.Drawing.Size(121, 21);
			this.comboHumanName.TabIndex = 10;
			this.comboHumanName.Visible = false;
			// 
			// boxGender
			// 
			this.boxGender.AutoSize = true;
			this.boxGender.Location = new System.Drawing.Point(28, 82);
			this.boxGender.Name = "boxGender";
			this.boxGender.Size = new System.Drawing.Size(15, 14);
			this.boxGender.TabIndex = 11;
			this.boxGender.UseVisualStyleBackColor = true;
			// 
			// lblGender
			// 
			this.lblGender.AutoSize = true;
			this.lblGender.Location = new System.Drawing.Point(49, 83);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(45, 13);
			this.lblGender.TabIndex = 12;
			this.lblGender.Text = "Gender:";
			// 
			// txtGender
			// 
			this.txtGender.Location = new System.Drawing.Point(168, 80);
			this.txtGender.Name = "txtGender";
			this.txtGender.ReadOnly = true;
			this.txtGender.Size = new System.Drawing.Size(121, 20);
			this.txtGender.TabIndex = 13;
			// 
			// boxPhysicalQuality
			// 
			this.boxPhysicalQuality.AutoSize = true;
			this.boxPhysicalQuality.Location = new System.Drawing.Point(28, 108);
			this.boxPhysicalQuality.Name = "boxPhysicalQuality";
			this.boxPhysicalQuality.Size = new System.Drawing.Size(15, 14);
			this.boxPhysicalQuality.TabIndex = 14;
			this.boxPhysicalQuality.UseVisualStyleBackColor = true;
			// 
			// lblPhysicalQuality
			// 
			this.lblPhysicalQuality.AutoSize = true;
			this.lblPhysicalQuality.Location = new System.Drawing.Point(49, 109);
			this.lblPhysicalQuality.Name = "lblPhysicalQuality";
			this.lblPhysicalQuality.Size = new System.Drawing.Size(84, 13);
			this.lblPhysicalQuality.TabIndex = 15;
			this.lblPhysicalQuality.Text = "Physical Quality:";
			// 
			// txtPhysicalQuality
			// 
			this.txtPhysicalQuality.Location = new System.Drawing.Point(168, 106);
			this.txtPhysicalQuality.Name = "txtPhysicalQuality";
			this.txtPhysicalQuality.ReadOnly = true;
			this.txtPhysicalQuality.Size = new System.Drawing.Size(298, 20);
			this.txtPhysicalQuality.TabIndex = 16;
			// 
			// boxPersonalityQuirk
			// 
			this.boxPersonalityQuirk.AutoSize = true;
			this.boxPersonalityQuirk.Location = new System.Drawing.Point(28, 134);
			this.boxPersonalityQuirk.Name = "boxPersonalityQuirk";
			this.boxPersonalityQuirk.Size = new System.Drawing.Size(15, 14);
			this.boxPersonalityQuirk.TabIndex = 17;
			this.boxPersonalityQuirk.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(49, 135);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 13);
			this.label1.TabIndex = 18;
			this.label1.Text = "Personality Quirk:";
			// 
			// txtPersonalityQuirk
			// 
			this.txtPersonalityQuirk.Location = new System.Drawing.Point(168, 132);
			this.txtPersonalityQuirk.Name = "txtPersonalityQuirk";
			this.txtPersonalityQuirk.ReadOnly = true;
			this.txtPersonalityQuirk.Size = new System.Drawing.Size(298, 20);
			this.txtPersonalityQuirk.TabIndex = 19;
			// 
			// boxIdeal
			// 
			this.boxIdeal.AutoSize = true;
			this.boxIdeal.Location = new System.Drawing.Point(28, 160);
			this.boxIdeal.Name = "boxIdeal";
			this.boxIdeal.Size = new System.Drawing.Size(15, 14);
			this.boxIdeal.TabIndex = 20;
			this.boxIdeal.UseVisualStyleBackColor = true;
			// 
			// lblIdeal
			// 
			this.lblIdeal.AutoSize = true;
			this.lblIdeal.Location = new System.Drawing.Point(52, 161);
			this.lblIdeal.Name = "lblIdeal";
			this.lblIdeal.Size = new System.Drawing.Size(33, 13);
			this.lblIdeal.TabIndex = 21;
			this.lblIdeal.Text = "Ideal:";
			// 
			// txtIdeal
			// 
			this.txtIdeal.Location = new System.Drawing.Point(168, 158);
			this.txtIdeal.Name = "txtIdeal";
			this.txtIdeal.ReadOnly = true;
			this.txtIdeal.Size = new System.Drawing.Size(298, 20);
			this.txtIdeal.TabIndex = 22;
			// 
			// boxBond
			// 
			this.boxBond.AutoSize = true;
			this.boxBond.Location = new System.Drawing.Point(28, 186);
			this.boxBond.Name = "boxBond";
			this.boxBond.Size = new System.Drawing.Size(15, 14);
			this.boxBond.TabIndex = 23;
			this.boxBond.UseVisualStyleBackColor = true;
			// 
			// lblBond
			// 
			this.lblBond.AutoSize = true;
			this.lblBond.Location = new System.Drawing.Point(52, 187);
			this.lblBond.Name = "lblBond";
			this.lblBond.Size = new System.Drawing.Size(35, 13);
			this.lblBond.TabIndex = 24;
			this.lblBond.Text = "Bond:";
			// 
			// txtBond
			// 
			this.txtBond.Location = new System.Drawing.Point(168, 184);
			this.txtBond.Name = "txtBond";
			this.txtBond.ReadOnly = true;
			this.txtBond.Size = new System.Drawing.Size(298, 20);
			this.txtBond.TabIndex = 25;
			// 
			// boxFlawSecret
			// 
			this.boxFlawSecret.AutoSize = true;
			this.boxFlawSecret.Location = new System.Drawing.Point(28, 212);
			this.boxFlawSecret.Name = "boxFlawSecret";
			this.boxFlawSecret.Size = new System.Drawing.Size(15, 14);
			this.boxFlawSecret.TabIndex = 26;
			this.boxFlawSecret.UseVisualStyleBackColor = true;
			// 
			// lblFlawSecret
			// 
			this.lblFlawSecret.AutoSize = true;
			this.lblFlawSecret.Location = new System.Drawing.Point(52, 213);
			this.lblFlawSecret.Name = "lblFlawSecret";
			this.lblFlawSecret.Size = new System.Drawing.Size(68, 13);
			this.lblFlawSecret.TabIndex = 27;
			this.lblFlawSecret.Text = "Flaw/Secret:";
			// 
			// txtFlawSecret
			// 
			this.txtFlawSecret.Location = new System.Drawing.Point(168, 210);
			this.txtFlawSecret.Name = "txtFlawSecret";
			this.txtFlawSecret.ReadOnly = true;
			this.txtFlawSecret.Size = new System.Drawing.Size(298, 20);
			this.txtFlawSecret.TabIndex = 28;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 373);
			this.Controls.Add(this.txtFlawSecret);
			this.Controls.Add(this.lblFlawSecret);
			this.Controls.Add(this.boxFlawSecret);
			this.Controls.Add(this.txtBond);
			this.Controls.Add(this.lblBond);
			this.Controls.Add(this.boxBond);
			this.Controls.Add(this.txtIdeal);
			this.Controls.Add(this.lblIdeal);
			this.Controls.Add(this.boxIdeal);
			this.Controls.Add(this.txtPersonalityQuirk);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.boxPersonalityQuirk);
			this.Controls.Add(this.txtPhysicalQuality);
			this.Controls.Add(this.lblPhysicalQuality);
			this.Controls.Add(this.boxPhysicalQuality);
			this.Controls.Add(this.txtGender);
			this.Controls.Add(this.lblGender);
			this.Controls.Add(this.boxGender);
			this.Controls.Add(this.comboHumanName);
			this.Controls.Add(this.comboRace);
			this.Controls.Add(this.lblRace);
			this.Controls.Add(this.boxRace);
			this.Controls.Add(this.txtFname);
			this.Controls.Add(this.txtLname);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.boxName);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnRandomize);
			this.Name = "Form1";
			this.Text = "NPC Random Generator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRandomize;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.CheckBox boxName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtLname;
		private System.Windows.Forms.TextBox txtFname;
		private System.Windows.Forms.CheckBox boxRace;
		private System.Windows.Forms.Label lblRace;
		private System.Windows.Forms.ComboBox comboRace;
		private System.Windows.Forms.ComboBox comboHumanName;
		private System.Windows.Forms.CheckBox boxGender;
		private System.Windows.Forms.Label lblGender;
		private System.Windows.Forms.TextBox txtGender;
		private System.Windows.Forms.CheckBox boxPhysicalQuality;
		private System.Windows.Forms.Label lblPhysicalQuality;
		private System.Windows.Forms.TextBox txtPhysicalQuality;
		private System.Windows.Forms.CheckBox boxPersonalityQuirk;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPersonalityQuirk;
		private System.Windows.Forms.CheckBox boxIdeal;
		private System.Windows.Forms.Label lblIdeal;
		private System.Windows.Forms.TextBox txtIdeal;
		private System.Windows.Forms.CheckBox boxBond;
		private System.Windows.Forms.Label lblBond;
		private System.Windows.Forms.TextBox txtBond;
		private System.Windows.Forms.CheckBox boxFlawSecret;
		private System.Windows.Forms.Label lblFlawSecret;
		private System.Windows.Forms.TextBox txtFlawSecret;
	}
}

