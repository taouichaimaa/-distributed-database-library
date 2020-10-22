namespace Biblio
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginBTN = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 57);
            this.panel1.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SkyBlue;
            this.bunifuImageButton1.Image = global::Biblio.Properties.Resources.multiply;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(370, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(28, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // username
            // 
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.HintForeColor = System.Drawing.Color.Silver;
            this.username.HintText = "Username";
            this.username.isPassword = false;
            this.username.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.username.LineIdleColor = System.Drawing.Color.Gray;
            this.username.LineMouseHoverColor = System.Drawing.Color.LightBlue;
            this.username.LineThickness = 3;
            this.username.Location = new System.Drawing.Point(99, 306);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(202, 39);
            this.username.TabIndex = 3;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.HintForeColor = System.Drawing.Color.Gray;
            this.password.HintText = "Password";
            this.password.isPassword = true;
            this.password.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.password.LineIdleColor = System.Drawing.Color.Gray;
            this.password.LineMouseHoverColor = System.Drawing.Color.LightBlue;
            this.password.LineThickness = 3;
            this.password.Location = new System.Drawing.Point(99, 369);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(202, 47);
            this.password.TabIndex = 4;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // loginBTN
            // 
            this.loginBTN.Activecolor = System.Drawing.Color.PeachPuff;
            this.loginBTN.BackColor = System.Drawing.Color.LightBlue;
            this.loginBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginBTN.BorderRadius = 0;
            this.loginBTN.ButtonText = "LOGIN";
            this.loginBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBTN.DisabledColor = System.Drawing.Color.Gray;
            this.loginBTN.Iconcolor = System.Drawing.Color.Transparent;
            this.loginBTN.Iconimage = null;
            this.loginBTN.Iconimage_right = null;
            this.loginBTN.Iconimage_right_Selected = null;
            this.loginBTN.Iconimage_Selected = null;
            this.loginBTN.IconMarginLeft = 0;
            this.loginBTN.IconMarginRight = 0;
            this.loginBTN.IconRightVisible = true;
            this.loginBTN.IconRightZoom = 0D;
            this.loginBTN.IconVisible = true;
            this.loginBTN.IconZoom = 90D;
            this.loginBTN.IsTab = false;
            this.loginBTN.Location = new System.Drawing.Point(109, 435);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Normalcolor = System.Drawing.Color.LightBlue;
            this.loginBTN.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.loginBTN.OnHoverTextColor = System.Drawing.Color.White;
            this.loginBTN.selected = false;
            this.loginBTN.Size = new System.Drawing.Size(177, 38);
            this.loginBTN.TabIndex = 6;
            this.loginBTN.Text = "LOGIN";
            this.loginBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginBTN.Textcolor = System.Drawing.Color.White;
            this.loginBTN.TextFont = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(132, 492);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(122, 13);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Don\'t have an account?";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(117, 517);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(149, 13);
            this.bunifuCustomLabel2.TabIndex = 8;
            this.bunifuCustomLabel2.Text = "Contact your school here";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuImageButton2.Image = global::Biblio.Properties.Resources.final2;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(99, 100);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(196, 155);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 558);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox username;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private Bunifu.Framework.UI.BunifuFlatButton loginBTN;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Timer timer1;
    }
}

