
namespace FormUI
{
    partial class FormSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUp));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabCustomerSignIn = new System.Windows.Forms.TabPage();
            this.btnCustomerClear = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCustomerAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtCustomerPassword = new System.Windows.Forms.TextBox();
            this.txtCustomerAgainPassword = new System.Windows.Forms.TextBox();
            this.txtCustomerCity = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.materialLabelCustomerPassword2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelCustomerCity = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelCustomerPassword = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelCustomerSurname = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelCustomerEmail = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelCustomerName = new MaterialSkin.Controls.MaterialLabel();
            this.tabControlManagerSıgnIn = new System.Windows.Forms.TabPage();
            this.btnManagerAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnManagerClear = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtManagerAgainPassword = new System.Windows.Forms.TextBox();
            this.txtManagerCity = new System.Windows.Forms.TextBox();
            this.txtManagerPassword = new System.Windows.Forms.TextBox();
            this.txtManagerCode = new System.Windows.Forms.TextBox();
            this.txtManagerName = new System.Windows.Forms.TextBox();
            this.txtManagerEmail = new System.Windows.Forms.TextBox();
            this.txtManagerSurname = new System.Windows.Forms.TextBox();
            this.materialLabelManaegrCode = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelManagerPassword2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelManagerCity = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelManaegrPassword = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelManagerSurname = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelManagerEmail = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelManagerName = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.tabCustomerSignIn.SuspendLayout();
            this.tabControlManagerSıgnIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(170, 84);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(456, 36);
            this.materialTabSelector1.TabIndex = 15;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabCustomerSignIn);
            this.materialTabControl1.Controls.Add(this.tabControlManagerSıgnIn);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(170, 126);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(456, 354);
            this.materialTabControl1.TabIndex = 16;
            // 
            // tabCustomerSignIn
            // 
            this.tabCustomerSignIn.Controls.Add(this.btnCustomerClear);
            this.tabCustomerSignIn.Controls.Add(this.btnCustomerAdd);
            this.tabCustomerSignIn.Controls.Add(this.txtCustomerPassword);
            this.tabCustomerSignIn.Controls.Add(this.txtCustomerAgainPassword);
            this.tabCustomerSignIn.Controls.Add(this.txtCustomerCity);
            this.tabCustomerSignIn.Controls.Add(this.txtCustomerEmail);
            this.tabCustomerSignIn.Controls.Add(this.txtCustomerSurname);
            this.tabCustomerSignIn.Controls.Add(this.txtCustomerName);
            this.tabCustomerSignIn.Controls.Add(this.materialLabelCustomerPassword2);
            this.tabCustomerSignIn.Controls.Add(this.materialLabelCustomerCity);
            this.tabCustomerSignIn.Controls.Add(this.materialLabelCustomerPassword);
            this.tabCustomerSignIn.Controls.Add(this.materialLabelCustomerSurname);
            this.tabCustomerSignIn.Controls.Add(this.materialLabelCustomerEmail);
            this.tabCustomerSignIn.Controls.Add(this.materialLabelCustomerName);
            this.tabCustomerSignIn.Location = new System.Drawing.Point(4, 22);
            this.tabCustomerSignIn.Name = "tabCustomerSignIn";
            this.tabCustomerSignIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomerSignIn.Size = new System.Drawing.Size(448, 328);
            this.tabCustomerSignIn.TabIndex = 0;
            this.tabCustomerSignIn.Text = "Customer";
            this.tabCustomerSignIn.UseVisualStyleBackColor = true;
            // 
            // btnCustomerClear
            // 
            this.btnCustomerClear.AutoSize = true;
            this.btnCustomerClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCustomerClear.Depth = 0;
            this.btnCustomerClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCustomerClear.Location = new System.Drawing.Point(201, 271);
            this.btnCustomerClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCustomerClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCustomerClear.Name = "btnCustomerClear";
            this.btnCustomerClear.Primary = false;
            this.btnCustomerClear.Size = new System.Drawing.Size(54, 36);
            this.btnCustomerClear.TabIndex = 16;
            this.btnCustomerClear.Text = "CLEAR";
            this.btnCustomerClear.UseVisualStyleBackColor = true;
            this.btnCustomerClear.Click += new System.EventHandler(this.btnCustomerClear_Click);
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.AutoSize = true;
            this.btnCustomerAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCustomerAdd.Depth = 0;
            this.btnCustomerAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCustomerAdd.Location = new System.Drawing.Point(154, 271);
            this.btnCustomerAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCustomerAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Primary = false;
            this.btnCustomerAdd.Size = new System.Drawing.Size(39, 36);
            this.btnCustomerAdd.TabIndex = 15;
            this.btnCustomerAdd.Text = "ADD";
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // txtCustomerPassword
            // 
            this.txtCustomerPassword.Location = new System.Drawing.Point(155, 196);
            this.txtCustomerPassword.Name = "txtCustomerPassword";
            this.txtCustomerPassword.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerPassword.TabIndex = 14;
            // 
            // txtCustomerAgainPassword
            // 
            this.txtCustomerAgainPassword.Location = new System.Drawing.Point(155, 231);
            this.txtCustomerAgainPassword.Name = "txtCustomerAgainPassword";
            this.txtCustomerAgainPassword.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerAgainPassword.TabIndex = 13;
            // 
            // txtCustomerCity
            // 
            this.txtCustomerCity.Location = new System.Drawing.Point(155, 154);
            this.txtCustomerCity.Name = "txtCustomerCity";
            this.txtCustomerCity.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerCity.TabIndex = 12;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(155, 115);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerEmail.TabIndex = 11;
            this.txtCustomerEmail.TextChanged += new System.EventHandler(this.txtCustomerEmail_TextChanged);
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.Location = new System.Drawing.Point(155, 70);
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerSurname.TabIndex = 9;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(155, 33);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 8;
            // 
            // materialLabelCustomerPassword2
            // 
            this.materialLabelCustomerPassword2.AutoSize = true;
            this.materialLabelCustomerPassword2.Depth = 0;
            this.materialLabelCustomerPassword2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelCustomerPassword2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelCustomerPassword2.Location = new System.Drawing.Point(24, 231);
            this.materialLabelCustomerPassword2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelCustomerPassword2.Name = "materialLabelCustomerPassword2";
            this.materialLabelCustomerPassword2.Size = new System.Drawing.Size(117, 19);
            this.materialLabelCustomerPassword2.TabIndex = 7;
            this.materialLabelCustomerPassword2.Text = "Again Password";
            // 
            // materialLabelCustomerCity
            // 
            this.materialLabelCustomerCity.AutoSize = true;
            this.materialLabelCustomerCity.Depth = 0;
            this.materialLabelCustomerCity.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelCustomerCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelCustomerCity.Location = new System.Drawing.Point(24, 156);
            this.materialLabelCustomerCity.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelCustomerCity.Name = "materialLabelCustomerCity";
            this.materialLabelCustomerCity.Size = new System.Drawing.Size(35, 19);
            this.materialLabelCustomerCity.TabIndex = 5;
            this.materialLabelCustomerCity.Text = "City";
            // 
            // materialLabelCustomerPassword
            // 
            this.materialLabelCustomerPassword.AutoSize = true;
            this.materialLabelCustomerPassword.Depth = 0;
            this.materialLabelCustomerPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelCustomerPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelCustomerPassword.Location = new System.Drawing.Point(24, 195);
            this.materialLabelCustomerPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelCustomerPassword.Name = "materialLabelCustomerPassword";
            this.materialLabelCustomerPassword.Size = new System.Drawing.Size(75, 19);
            this.materialLabelCustomerPassword.TabIndex = 4;
            this.materialLabelCustomerPassword.Text = "Password";
            // 
            // materialLabelCustomerSurname
            // 
            this.materialLabelCustomerSurname.AutoSize = true;
            this.materialLabelCustomerSurname.Depth = 0;
            this.materialLabelCustomerSurname.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelCustomerSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelCustomerSurname.Location = new System.Drawing.Point(24, 69);
            this.materialLabelCustomerSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelCustomerSurname.Name = "materialLabelCustomerSurname";
            this.materialLabelCustomerSurname.Size = new System.Drawing.Size(68, 19);
            this.materialLabelCustomerSurname.TabIndex = 3;
            this.materialLabelCustomerSurname.Text = "Surname";
            // 
            // materialLabelCustomerEmail
            // 
            this.materialLabelCustomerEmail.AutoSize = true;
            this.materialLabelCustomerEmail.Depth = 0;
            this.materialLabelCustomerEmail.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelCustomerEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelCustomerEmail.Location = new System.Drawing.Point(24, 114);
            this.materialLabelCustomerEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelCustomerEmail.Name = "materialLabelCustomerEmail";
            this.materialLabelCustomerEmail.Size = new System.Drawing.Size(47, 19);
            this.materialLabelCustomerEmail.TabIndex = 2;
            this.materialLabelCustomerEmail.Text = "Email";
            // 
            // materialLabelCustomerName
            // 
            this.materialLabelCustomerName.AutoSize = true;
            this.materialLabelCustomerName.Depth = 0;
            this.materialLabelCustomerName.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelCustomerName.Location = new System.Drawing.Point(24, 33);
            this.materialLabelCustomerName.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelCustomerName.Name = "materialLabelCustomerName";
            this.materialLabelCustomerName.Size = new System.Drawing.Size(49, 19);
            this.materialLabelCustomerName.TabIndex = 1;
            this.materialLabelCustomerName.Text = "Name";
            // 
            // tabControlManagerSıgnIn
            // 
            this.tabControlManagerSıgnIn.Controls.Add(this.btnManagerAdd);
            this.tabControlManagerSıgnIn.Controls.Add(this.btnManagerClear);
            this.tabControlManagerSıgnIn.Controls.Add(this.txtManagerAgainPassword);
            this.tabControlManagerSıgnIn.Controls.Add(this.txtManagerCity);
            this.tabControlManagerSıgnIn.Controls.Add(this.txtManagerPassword);
            this.tabControlManagerSıgnIn.Controls.Add(this.txtManagerCode);
            this.tabControlManagerSıgnIn.Controls.Add(this.txtManagerName);
            this.tabControlManagerSıgnIn.Controls.Add(this.txtManagerEmail);
            this.tabControlManagerSıgnIn.Controls.Add(this.txtManagerSurname);
            this.tabControlManagerSıgnIn.Controls.Add(this.materialLabelManaegrCode);
            this.tabControlManagerSıgnIn.Controls.Add(this.materialLabelManagerPassword2);
            this.tabControlManagerSıgnIn.Controls.Add(this.materialLabelManagerCity);
            this.tabControlManagerSıgnIn.Controls.Add(this.materialLabelManaegrPassword);
            this.tabControlManagerSıgnIn.Controls.Add(this.materialLabelManagerSurname);
            this.tabControlManagerSıgnIn.Controls.Add(this.materialLabelManagerEmail);
            this.tabControlManagerSıgnIn.Controls.Add(this.materialLabelManagerName);
            this.tabControlManagerSıgnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControlManagerSıgnIn.Location = new System.Drawing.Point(4, 22);
            this.tabControlManagerSıgnIn.Name = "tabControlManagerSıgnIn";
            this.tabControlManagerSıgnIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabControlManagerSıgnIn.Size = new System.Drawing.Size(448, 328);
            this.tabControlManagerSıgnIn.TabIndex = 1;
            this.tabControlManagerSıgnIn.Text = "Manager";
            this.tabControlManagerSıgnIn.UseVisualStyleBackColor = true;
            this.tabControlManagerSıgnIn.Click += new System.EventHandler(this.tabControlManagerSıgnIn_Click);
            // 
            // btnManagerAdd
            // 
            this.btnManagerAdd.AutoSize = true;
            this.btnManagerAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnManagerAdd.Depth = 0;
            this.btnManagerAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnManagerAdd.Location = new System.Drawing.Point(149, 286);
            this.btnManagerAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnManagerAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnManagerAdd.Name = "btnManagerAdd";
            this.btnManagerAdd.Primary = false;
            this.btnManagerAdd.Size = new System.Drawing.Size(39, 36);
            this.btnManagerAdd.TabIndex = 23;
            this.btnManagerAdd.Text = "ADD";
            this.btnManagerAdd.UseVisualStyleBackColor = true;
            this.btnManagerAdd.Click += new System.EventHandler(this.btnManagerAdd_Click);
            // 
            // btnManagerClear
            // 
            this.btnManagerClear.AutoSize = true;
            this.btnManagerClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnManagerClear.Depth = 0;
            this.btnManagerClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnManagerClear.Location = new System.Drawing.Point(210, 286);
            this.btnManagerClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnManagerClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnManagerClear.Name = "btnManagerClear";
            this.btnManagerClear.Primary = false;
            this.btnManagerClear.Size = new System.Drawing.Size(54, 36);
            this.btnManagerClear.TabIndex = 22;
            this.btnManagerClear.Text = "CLEAR";
            this.btnManagerClear.UseVisualStyleBackColor = true;
            this.btnManagerClear.Click += new System.EventHandler(this.btnManagerClear_Click);
            // 
            // txtManagerAgainPassword
            // 
            this.txtManagerAgainPassword.Location = new System.Drawing.Point(149, 217);
            this.txtManagerAgainPassword.Name = "txtManagerAgainPassword";
            this.txtManagerAgainPassword.Size = new System.Drawing.Size(100, 22);
            this.txtManagerAgainPassword.TabIndex = 21;
            // 
            // txtManagerCity
            // 
            this.txtManagerCity.Location = new System.Drawing.Point(149, 142);
            this.txtManagerCity.Name = "txtManagerCity";
            this.txtManagerCity.Size = new System.Drawing.Size(100, 22);
            this.txtManagerCity.TabIndex = 20;
            // 
            // txtManagerPassword
            // 
            this.txtManagerPassword.Location = new System.Drawing.Point(149, 180);
            this.txtManagerPassword.Name = "txtManagerPassword";
            this.txtManagerPassword.Size = new System.Drawing.Size(100, 22);
            this.txtManagerPassword.TabIndex = 19;
            // 
            // txtManagerCode
            // 
            this.txtManagerCode.Location = new System.Drawing.Point(149, 255);
            this.txtManagerCode.Name = "txtManagerCode";
            this.txtManagerCode.Size = new System.Drawing.Size(100, 22);
            this.txtManagerCode.TabIndex = 18;
            // 
            // txtManagerName
            // 
            this.txtManagerName.Location = new System.Drawing.Point(149, 18);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.Size = new System.Drawing.Size(100, 22);
            this.txtManagerName.TabIndex = 17;
            // 
            // txtManagerEmail
            // 
            this.txtManagerEmail.Location = new System.Drawing.Point(149, 99);
            this.txtManagerEmail.Name = "txtManagerEmail";
            this.txtManagerEmail.Size = new System.Drawing.Size(100, 22);
            this.txtManagerEmail.TabIndex = 16;
            this.txtManagerEmail.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtManagerSurname
            // 
            this.txtManagerSurname.Location = new System.Drawing.Point(149, 54);
            this.txtManagerSurname.Name = "txtManagerSurname";
            this.txtManagerSurname.Size = new System.Drawing.Size(100, 22);
            this.txtManagerSurname.TabIndex = 15;
            // 
            // materialLabelManaegrCode
            // 
            this.materialLabelManaegrCode.AutoSize = true;
            this.materialLabelManaegrCode.Depth = 0;
            this.materialLabelManaegrCode.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelManaegrCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelManaegrCode.Location = new System.Drawing.Point(20, 255);
            this.materialLabelManaegrCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelManaegrCode.Name = "materialLabelManaegrCode";
            this.materialLabelManaegrCode.Size = new System.Drawing.Size(44, 19);
            this.materialLabelManaegrCode.TabIndex = 14;
            this.materialLabelManaegrCode.Text = "Code";
            // 
            // materialLabelManagerPassword2
            // 
            this.materialLabelManagerPassword2.AutoSize = true;
            this.materialLabelManagerPassword2.Depth = 0;
            this.materialLabelManagerPassword2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelManagerPassword2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelManagerPassword2.Location = new System.Drawing.Point(20, 217);
            this.materialLabelManagerPassword2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelManagerPassword2.Name = "materialLabelManagerPassword2";
            this.materialLabelManagerPassword2.Size = new System.Drawing.Size(117, 19);
            this.materialLabelManagerPassword2.TabIndex = 13;
            this.materialLabelManagerPassword2.Text = "Again Password";
            // 
            // materialLabelManagerCity
            // 
            this.materialLabelManagerCity.AutoSize = true;
            this.materialLabelManagerCity.Depth = 0;
            this.materialLabelManagerCity.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelManagerCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelManagerCity.Location = new System.Drawing.Point(20, 142);
            this.materialLabelManagerCity.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelManagerCity.Name = "materialLabelManagerCity";
            this.materialLabelManagerCity.Size = new System.Drawing.Size(35, 19);
            this.materialLabelManagerCity.TabIndex = 12;
            this.materialLabelManagerCity.Text = "City";
            // 
            // materialLabelManaegrPassword
            // 
            this.materialLabelManaegrPassword.AutoSize = true;
            this.materialLabelManaegrPassword.Depth = 0;
            this.materialLabelManaegrPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelManaegrPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelManaegrPassword.Location = new System.Drawing.Point(20, 181);
            this.materialLabelManaegrPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelManaegrPassword.Name = "materialLabelManaegrPassword";
            this.materialLabelManaegrPassword.Size = new System.Drawing.Size(75, 19);
            this.materialLabelManaegrPassword.TabIndex = 11;
            this.materialLabelManaegrPassword.Text = "Password";
            // 
            // materialLabelManagerSurname
            // 
            this.materialLabelManagerSurname.AutoSize = true;
            this.materialLabelManagerSurname.Depth = 0;
            this.materialLabelManagerSurname.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelManagerSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelManagerSurname.Location = new System.Drawing.Point(20, 55);
            this.materialLabelManagerSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelManagerSurname.Name = "materialLabelManagerSurname";
            this.materialLabelManagerSurname.Size = new System.Drawing.Size(68, 19);
            this.materialLabelManagerSurname.TabIndex = 10;
            this.materialLabelManagerSurname.Text = "Surname";
            // 
            // materialLabelManagerEmail
            // 
            this.materialLabelManagerEmail.AutoSize = true;
            this.materialLabelManagerEmail.Depth = 0;
            this.materialLabelManagerEmail.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelManagerEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelManagerEmail.Location = new System.Drawing.Point(20, 100);
            this.materialLabelManagerEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelManagerEmail.Name = "materialLabelManagerEmail";
            this.materialLabelManagerEmail.Size = new System.Drawing.Size(47, 19);
            this.materialLabelManagerEmail.TabIndex = 9;
            this.materialLabelManagerEmail.Text = "Email";
            // 
            // materialLabelManagerName
            // 
            this.materialLabelManagerName.AutoSize = true;
            this.materialLabelManagerName.Depth = 0;
            this.materialLabelManagerName.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelManagerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelManagerName.Location = new System.Drawing.Point(20, 19);
            this.materialLabelManagerName.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelManagerName.Name = "materialLabelManagerName";
            this.materialLabelManagerName.Size = new System.Drawing.Size(49, 19);
            this.materialLabelManagerName.TabIndex = 8;
            this.materialLabelManagerName.Text = "Name";
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(638, 485);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormSignUp";
            this.Text = "Sign Up Screen";
            this.Load += new System.EventHandler(this.FormSignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.tabCustomerSignIn.ResumeLayout(false);
            this.tabCustomerSignIn.PerformLayout();
            this.tabControlManagerSıgnIn.ResumeLayout(false);
            this.tabControlManagerSıgnIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabCustomerSignIn;
        private System.Windows.Forms.TabPage tabControlManagerSıgnIn;
        private MaterialSkin.Controls.MaterialLabel materialLabelCustomerPassword2;
        private MaterialSkin.Controls.MaterialLabel materialLabelCustomerCity;
        private MaterialSkin.Controls.MaterialLabel materialLabelCustomerPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabelCustomerSurname;
        private MaterialSkin.Controls.MaterialLabel materialLabelCustomerEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabelCustomerName;
        private MaterialSkin.Controls.MaterialLabel materialLabelManaegrCode;
        private MaterialSkin.Controls.MaterialLabel materialLabelManagerCity;
        private MaterialSkin.Controls.MaterialLabel materialLabelManaegrPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabelManagerSurname;
        private MaterialSkin.Controls.MaterialLabel materialLabelManagerEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabelManagerName;
        private MaterialSkin.Controls.MaterialLabel materialLabelManagerPassword2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerPassword;
        private System.Windows.Forms.TextBox txtCustomerAgainPassword;
        private System.Windows.Forms.TextBox txtCustomerCity;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerSurname;
        private System.Windows.Forms.TextBox txtManagerAgainPassword;
        private System.Windows.Forms.TextBox txtManagerCity;
        private System.Windows.Forms.TextBox txtManagerPassword;
        private System.Windows.Forms.TextBox txtManagerCode;
        private System.Windows.Forms.TextBox txtManagerName;
        private System.Windows.Forms.TextBox txtManagerEmail;
        private System.Windows.Forms.TextBox txtManagerSurname;
        private MaterialSkin.Controls.MaterialFlatButton btnCustomerAdd;
        private MaterialSkin.Controls.MaterialFlatButton btnCustomerClear;
        private MaterialSkin.Controls.MaterialFlatButton btnManagerAdd;
        private MaterialSkin.Controls.MaterialFlatButton btnManagerClear;
    }
}