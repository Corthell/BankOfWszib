namespace BankOfWszib
{
    partial class RegistrationScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationScreen));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.imie = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nazwisko = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.telefon = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nrLokalu = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ulica = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.miasto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btZarejestruj = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pesel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.haslo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.login = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.infoRejestracjaLb = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(99, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rejestracja";
            // 
            // imie
            // 
            this.imie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.imie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.imie.BackColor = System.Drawing.Color.White;
            this.imie.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.imie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.imie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.imie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.imie.HintForeColor = System.Drawing.Color.Empty;
            this.imie.HintText = "";
            this.imie.isPassword = false;
            this.imie.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.imie.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.imie.LineMouseHoverColor = System.Drawing.SystemColors.ControlDarkDark;
            this.imie.LineThickness = 3;
            this.imie.Location = new System.Drawing.Point(51, 250);
            this.imie.Margin = new System.Windows.Forms.Padding(4);
            this.imie.MaxLength = 32767;
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(241, 31);
            this.imie.TabIndex = 5;
            this.imie.Text = "Imię";
            this.imie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nazwisko
            // 
            this.nazwisko.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nazwisko.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nazwisko.BackColor = System.Drawing.Color.White;
            this.nazwisko.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nazwisko.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.nazwisko.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nazwisko.HintForeColor = System.Drawing.Color.Empty;
            this.nazwisko.HintText = "";
            this.nazwisko.isPassword = false;
            this.nazwisko.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.nazwisko.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.nazwisko.LineMouseHoverColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nazwisko.LineThickness = 3;
            this.nazwisko.Location = new System.Drawing.Point(51, 289);
            this.nazwisko.Margin = new System.Windows.Forms.Padding(4);
            this.nazwisko.MaxLength = 32767;
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(241, 31);
            this.nazwisko.TabIndex = 6;
            this.nazwisko.Text = "Nazwisko";
            this.nazwisko.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // email
            // 
            this.email.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.email.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.email.BackColor = System.Drawing.Color.White;
            this.email.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email.HintForeColor = System.Drawing.Color.Empty;
            this.email.HintText = "";
            this.email.isPassword = false;
            this.email.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.email.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.email.LineMouseHoverColor = System.Drawing.SystemColors.ControlDarkDark;
            this.email.LineThickness = 3;
            this.email.Location = new System.Drawing.Point(51, 480);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.MaxLength = 32767;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(241, 31);
            this.email.TabIndex = 7;
            this.email.Text = "E-mail";
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // telefon
            // 
            this.telefon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.telefon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.telefon.BackColor = System.Drawing.Color.White;
            this.telefon.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.telefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.telefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.telefon.HintForeColor = System.Drawing.Color.Empty;
            this.telefon.HintText = "";
            this.telefon.isPassword = false;
            this.telefon.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.telefon.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.telefon.LineMouseHoverColor = System.Drawing.SystemColors.ControlDarkDark;
            this.telefon.LineThickness = 3;
            this.telefon.Location = new System.Drawing.Point(51, 445);
            this.telefon.Margin = new System.Windows.Forms.Padding(4);
            this.telefon.MaxLength = 32767;
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(241, 31);
            this.telefon.TabIndex = 8;
            this.telefon.Text = "Telefon";
            this.telefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nrLokalu
            // 
            this.nrLokalu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nrLokalu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nrLokalu.BackColor = System.Drawing.Color.White;
            this.nrLokalu.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nrLokalu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nrLokalu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.nrLokalu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nrLokalu.HintForeColor = System.Drawing.Color.Empty;
            this.nrLokalu.HintText = "";
            this.nrLokalu.isPassword = false;
            this.nrLokalu.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.nrLokalu.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.nrLokalu.LineMouseHoverColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nrLokalu.LineThickness = 3;
            this.nrLokalu.Location = new System.Drawing.Point(51, 406);
            this.nrLokalu.Margin = new System.Windows.Forms.Padding(4);
            this.nrLokalu.MaxLength = 32767;
            this.nrLokalu.Name = "nrLokalu";
            this.nrLokalu.Size = new System.Drawing.Size(241, 31);
            this.nrLokalu.TabIndex = 9;
            this.nrLokalu.Text = "Numer lokalu";
            this.nrLokalu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ulica
            // 
            this.ulica.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ulica.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ulica.BackColor = System.Drawing.Color.White;
            this.ulica.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ulica.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ulica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ulica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ulica.HintForeColor = System.Drawing.Color.Empty;
            this.ulica.HintText = "";
            this.ulica.isPassword = false;
            this.ulica.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.ulica.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.ulica.LineMouseHoverColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ulica.LineThickness = 3;
            this.ulica.Location = new System.Drawing.Point(51, 367);
            this.ulica.Margin = new System.Windows.Forms.Padding(4);
            this.ulica.MaxLength = 32767;
            this.ulica.Name = "ulica";
            this.ulica.Size = new System.Drawing.Size(241, 31);
            this.ulica.TabIndex = 10;
            this.ulica.Text = "Ulica";
            this.ulica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // miasto
            // 
            this.miasto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.miasto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.miasto.BackColor = System.Drawing.Color.White;
            this.miasto.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.miasto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.miasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.miasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.miasto.HintForeColor = System.Drawing.Color.Empty;
            this.miasto.HintText = "";
            this.miasto.isPassword = false;
            this.miasto.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.miasto.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.miasto.LineMouseHoverColor = System.Drawing.SystemColors.ControlDarkDark;
            this.miasto.LineThickness = 3;
            this.miasto.Location = new System.Drawing.Point(51, 328);
            this.miasto.Margin = new System.Windows.Forms.Padding(4);
            this.miasto.MaxLength = 32767;
            this.miasto.Name = "miasto";
            this.miasto.Size = new System.Drawing.Size(241, 31);
            this.miasto.TabIndex = 11;
            this.miasto.Text = "Miasto";
            this.miasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btZarejestruj
            // 
            this.btZarejestruj.Active = false;
            this.btZarejestruj.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.btZarejestruj.BackColor = System.Drawing.Color.Gainsboro;
            this.btZarejestruj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btZarejestruj.BorderRadius = 0;
            this.btZarejestruj.ButtonText = "Zarejestruj";
            this.btZarejestruj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btZarejestruj.DisabledColor = System.Drawing.Color.Gray;
            this.btZarejestruj.Iconcolor = System.Drawing.Color.Transparent;
            this.btZarejestruj.Iconimage = null;
            this.btZarejestruj.Iconimage_right = null;
            this.btZarejestruj.Iconimage_right_Selected = null;
            this.btZarejestruj.Iconimage_Selected = null;
            this.btZarejestruj.IconMarginLeft = 0;
            this.btZarejestruj.IconMarginRight = 0;
            this.btZarejestruj.IconRightVisible = true;
            this.btZarejestruj.IconRightZoom = 0D;
            this.btZarejestruj.IconVisible = true;
            this.btZarejestruj.IconZoom = 90D;
            this.btZarejestruj.IsTab = false;
            this.btZarejestruj.Location = new System.Drawing.Point(51, 597);
            this.btZarejestruj.Name = "btZarejestruj";
            this.btZarejestruj.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btZarejestruj.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.btZarejestruj.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btZarejestruj.selected = false;
            this.btZarejestruj.Size = new System.Drawing.Size(241, 43);
            this.btZarejestruj.TabIndex = 12;
            this.btZarejestruj.Text = "Zarejestruj";
            this.btZarejestruj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btZarejestruj.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.btZarejestruj.TextFont = new System.Drawing.Font("Segoe UI", 15F);
            this.btZarejestruj.Click += new System.EventHandler(this.btZarejestruj_Click);
            // 
            // pesel
            // 
            this.pesel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.pesel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.pesel.BackColor = System.Drawing.Color.White;
            this.pesel.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pesel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.pesel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pesel.HintForeColor = System.Drawing.Color.Empty;
            this.pesel.HintText = "";
            this.pesel.isPassword = false;
            this.pesel.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.pesel.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.pesel.LineMouseHoverColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pesel.LineThickness = 3;
            this.pesel.Location = new System.Drawing.Point(51, 519);
            this.pesel.Margin = new System.Windows.Forms.Padding(4);
            this.pesel.MaxLength = 32767;
            this.pesel.Name = "pesel";
            this.pesel.Size = new System.Drawing.Size(241, 31);
            this.pesel.TabIndex = 13;
            this.pesel.Text = "PESEL";
            this.pesel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(300, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(125, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // haslo
            // 
            this.haslo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.haslo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.haslo.BackColor = System.Drawing.Color.White;
            this.haslo.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.haslo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.haslo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.haslo.HintForeColor = System.Drawing.Color.Empty;
            this.haslo.HintText = "";
            this.haslo.isPassword = false;
            this.haslo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.haslo.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(129)))));
            this.haslo.LineMouseHoverColor = System.Drawing.SystemColors.ControlDarkDark;
            this.haslo.LineThickness = 3;
            this.haslo.Location = new System.Drawing.Point(51, 210);
            this.haslo.Margin = new System.Windows.Forms.Padding(4);
            this.haslo.MaxLength = 32767;
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(241, 31);
            this.haslo.TabIndex = 15;
            this.haslo.Text = "Hasło";
            this.haslo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login
            // 
            this.login.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.login.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.login.BackColor = System.Drawing.Color.White;
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
            this.login.Location = new System.Drawing.Point(51, 171);
            this.login.Margin = new System.Windows.Forms.Padding(4);
            this.login.MaxLength = 32767;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(241, 31);
            this.login.TabIndex = 16;
            this.login.Text = "Login";
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // infoRejestracjaLb
            // 
            this.infoRejestracjaLb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoRejestracjaLb.ForeColor = System.Drawing.Color.Red;
            this.infoRejestracjaLb.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.infoRejestracjaLb.Location = new System.Drawing.Point(51, 558);
            this.infoRejestracjaLb.Name = "infoRejestracjaLb";
            this.infoRejestracjaLb.Size = new System.Drawing.Size(241, 22);
            this.infoRejestracjaLb.TabIndex = 17;
            this.infoRejestracjaLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(12, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(107, 50);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // RegistrationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 652);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.infoRejestracjaLb);
            this.Controls.Add(this.login);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pesel);
            this.Controls.Add(this.btZarejestruj);
            this.Controls.Add(this.miasto);
            this.Controls.Add(this.ulica);
            this.Controls.Add(this.nrLokalu);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.email);
            this.Controls.Add(this.nazwisko);
            this.Controls.Add(this.imie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox imie;
        private Bunifu.Framework.UI.BunifuMaterialTextbox miasto;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ulica;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nrLokalu;
        private Bunifu.Framework.UI.BunifuMaterialTextbox telefon;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nazwisko;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pesel;
        private Bunifu.Framework.UI.BunifuFlatButton btZarejestruj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox haslo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox login;
        private System.Windows.Forms.Label infoRejestracjaLb;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}