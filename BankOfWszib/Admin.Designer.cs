namespace BankOfWszib
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btZaloguj = new Bunifu.Framework.UI.BunifuFlatButton();
            this.haslo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.login = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.infoAdminLb = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSwitch1 = new Bunifu.Framework.UI.BunifuSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(277, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(78, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Admin Panel";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(100, 276);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(114, 13);
            this.bunifuCustomLabel2.TabIndex = 22;
            this.bunifuCustomLabel2.Text = "Hasło administratora";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(105, 222);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(104, 13);
            this.bunifuCustomLabel1.TabIndex = 21;
            this.bunifuCustomLabel1.Text = "Login użytkownika";
            // 
            // btZaloguj
            // 
            this.btZaloguj.Active = false;
            this.btZaloguj.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.btZaloguj.BackColor = System.Drawing.Color.Gainsboro;
            this.btZaloguj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btZaloguj.BorderRadius = 0;
            this.btZaloguj.ButtonText = "Wykonaj";
            this.btZaloguj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btZaloguj.DisabledColor = System.Drawing.Color.Gray;
            this.btZaloguj.Iconcolor = System.Drawing.Color.Transparent;
            this.btZaloguj.Iconimage = null;
            this.btZaloguj.Iconimage_right = null;
            this.btZaloguj.Iconimage_right_Selected = null;
            this.btZaloguj.Iconimage_Selected = null;
            this.btZaloguj.IconMarginLeft = 0;
            this.btZaloguj.IconMarginRight = 0;
            this.btZaloguj.IconRightVisible = true;
            this.btZaloguj.IconRightZoom = 0D;
            this.btZaloguj.IconVisible = true;
            this.btZaloguj.IconZoom = 90D;
            this.btZaloguj.IsTab = false;
            this.btZaloguj.Location = new System.Drawing.Point(33, 386);
            this.btZaloguj.Name = "btZaloguj";
            this.btZaloguj.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btZaloguj.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.btZaloguj.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btZaloguj.selected = false;
            this.btZaloguj.Size = new System.Drawing.Size(249, 48);
            this.btZaloguj.TabIndex = 20;
            this.btZaloguj.Text = "Wykonaj";
            this.btZaloguj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btZaloguj.Textcolor = System.Drawing.Color.Red;
            this.btZaloguj.TextFont = new System.Drawing.Font("Segoe UI", 16F);
            this.btZaloguj.Click += new System.EventHandler(this.btZaloguj_Click);
            // 
            // haslo
            // 
            this.haslo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.haslo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.haslo.BackColor = System.Drawing.Color.Snow;
            this.haslo.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.haslo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.haslo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.haslo.HintForeColor = System.Drawing.Color.Empty;
            this.haslo.HintText = "";
            this.haslo.isPassword = true;
            this.haslo.LineFocusedColor = System.Drawing.Color.Red;
            this.haslo.LineIdleColor = System.Drawing.Color.Red;
            this.haslo.LineMouseHoverColor = System.Drawing.SystemColors.ControlDarkDark;
            this.haslo.LineThickness = 3;
            this.haslo.Location = new System.Drawing.Point(42, 293);
            this.haslo.Margin = new System.Windows.Forms.Padding(4);
            this.haslo.MaxLength = 32767;
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(230, 33);
            this.haslo.TabIndex = 19;
            this.haslo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login
            // 
            this.login.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.login.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.login.BackColor = System.Drawing.Color.Snow;
            this.login.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login.HintForeColor = System.Drawing.Color.Empty;
            this.login.HintText = "";
            this.login.isPassword = false;
            this.login.LineFocusedColor = System.Drawing.Color.Red;
            this.login.LineIdleColor = System.Drawing.Color.Red;
            this.login.LineMouseHoverColor = System.Drawing.SystemColors.ControlDarkDark;
            this.login.LineThickness = 3;
            this.login.Location = new System.Drawing.Point(42, 239);
            this.login.Margin = new System.Windows.Forms.Padding(4);
            this.login.MaxLength = 32767;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(230, 33);
            this.login.TabIndex = 18;
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(81, 84);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 124);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 45);
            this.panel1.TabIndex = 24;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // infoAdminLb
            // 
            this.infoAdminLb.BackColor = System.Drawing.Color.Transparent;
            this.infoAdminLb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoAdminLb.ForeColor = System.Drawing.Color.Red;
            this.infoAdminLb.Location = new System.Drawing.Point(37, 360);
            this.infoAdminLb.Name = "infoAdminLb";
            this.infoAdminLb.Size = new System.Drawing.Size(241, 22);
            this.infoAdminLb.TabIndex = 25;
            this.infoAdminLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSwitch1
            // 
            this.bunifuSwitch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSwitch1.BorderRadius = 0;
            this.bunifuSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuSwitch1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch1.Location = new System.Drawing.Point(132, 338);
            this.bunifuSwitch1.Name = "bunifuSwitch1";
            this.bunifuSwitch1.Oncolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.bunifuSwitch1.Onoffcolor = System.Drawing.Color.Red;
            this.bunifuSwitch1.Size = new System.Drawing.Size(51, 19);
            this.bunifuSwitch1.TabIndex = 26;
            this.bunifuSwitch1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch1.Value = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 451);
            this.Controls.Add(this.bunifuSwitch1);
            this.Controls.Add(this.infoAdminLb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btZaloguj);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btZaloguj;
        private Bunifu.Framework.UI.BunifuMaterialTextbox haslo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox login;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel infoAdminLb;
        private Bunifu.Framework.UI.BunifuSwitch bunifuSwitch1;
    }
}