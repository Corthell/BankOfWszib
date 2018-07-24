namespace BankOfWszib
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.login = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.haslo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btZaloguj = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btRejestracja = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.errorMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 57);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(283, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(100, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MTM Bank";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
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
            this.login.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.login.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.login.LineMouseHoverColor = System.Drawing.SystemColors.ControlDarkDark;
            this.login.LineThickness = 3;
            this.login.Location = new System.Drawing.Point(61, 210);
            this.login.Margin = new System.Windows.Forms.Padding(4);
            this.login.MaxLength = 32767;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(202, 33);
            this.login.TabIndex = 4;
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.haslo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.haslo.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.haslo.LineMouseHoverColor = System.Drawing.SystemColors.ControlDarkDark;
            this.haslo.LineThickness = 3;
            this.haslo.Location = new System.Drawing.Point(61, 264);
            this.haslo.Margin = new System.Windows.Forms.Padding(4);
            this.haslo.MaxLength = 32767;
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(202, 33);
            this.haslo.TabIndex = 5;
            this.haslo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btZaloguj
            // 
            this.btZaloguj.Active = false;
            this.btZaloguj.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.btZaloguj.BackColor = System.Drawing.Color.Gainsboro;
            this.btZaloguj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btZaloguj.BorderRadius = 0;
            this.btZaloguj.ButtonText = "Zaloguj";
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
            this.btZaloguj.Location = new System.Drawing.Point(42, 326);
            this.btZaloguj.Name = "btZaloguj";
            this.btZaloguj.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btZaloguj.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.btZaloguj.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btZaloguj.selected = false;
            this.btZaloguj.Size = new System.Drawing.Size(241, 48);
            this.btZaloguj.TabIndex = 6;
            this.btZaloguj.Text = "Zaloguj";
            this.btZaloguj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btZaloguj.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.btZaloguj.TextFont = new System.Drawing.Font("Segoe UI", 16F);
            this.btZaloguj.Click += new System.EventHandler(this.btZaloguj_Click);
            // 
            // btRejestracja
            // 
            this.btRejestracja.FlatAppearance.BorderSize = 0;
            this.btRejestracja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRejestracja.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btRejestracja.ForeColor = System.Drawing.Color.Green;
            this.btRejestracja.Location = new System.Drawing.Point(125, 380);
            this.btRejestracja.Name = "btRejestracja";
            this.btRejestracja.Size = new System.Drawing.Size(75, 26);
            this.btRejestracja.TabIndex = 7;
            this.btRejestracja.Text = "Rejestracja";
            this.btRejestracja.UseVisualStyleBackColor = true;
            this.btRejestracja.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(88, 55);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 124);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Location = new System.Drawing.Point(0, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(322, 386);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(142, 193);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(36, 13);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Login";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(142, 247);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(36, 13);
            this.bunifuCustomLabel2.TabIndex = 9;
            this.bunifuCustomLabel2.Text = "Hasło";
            // 
            // errorMessage
            // 
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(42, 301);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(241, 23);
            this.errorMessage.TabIndex = 10;
            this.errorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(325, 418);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btRejestracja);
            this.Controls.Add(this.btZaloguj);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.login);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox login;
        private Bunifu.Framework.UI.BunifuFlatButton btZaloguj;
        private Bunifu.Framework.UI.BunifuMaterialTextbox haslo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRejestracja;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label errorMessage;
    }
}