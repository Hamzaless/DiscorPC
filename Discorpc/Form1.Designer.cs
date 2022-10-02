namespace Discorpc
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.start_stop_button = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton3 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.state = new Guna.UI.WinForms.GunaLineTextBox();
            this.details = new Guna.UI.WinForms.GunaLineTextBox();
            this.minimum = new Guna.UI.WinForms.GunaLineTextBox();
            this.small_image_text = new Guna.UI.WinForms.GunaLineTextBox();
            this.maximum = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse5 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse6 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.big_image_text = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.id = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipse7 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse8 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse9 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTransfarantPictureBox2 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaTransfarantPictureBox3 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaTransfarantPictureBox4 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_details = new Guna.UI.WinForms.GunaLabel();
            this.lbl_state_player = new Guna.UI.WinForms.GunaLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new Guna.UI.WinForms.GunaLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaElipsePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 24;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.gunaPanel1.Controls.Add(this.gunaControlBox1);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.gunaTransfarantPictureBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(-1, -2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1198, 87);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 30F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1104, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(94, 87);
            this.gunaControlBox1.TabIndex = 1;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel1.Location = new System.Drawing.Point(572, 23);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(190, 41);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Discord RPC";
            // 
            // gunaTransfarantPictureBox1
            // 
            this.gunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox1.Image = global::Discorpc.Properties.Resources.DiscorPC;
            this.gunaTransfarantPictureBox1.Location = new System.Drawing.Point(437, 11);
            this.gunaTransfarantPictureBox1.Name = "gunaTransfarantPictureBox1";
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(128, 64);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox1.TabIndex = 1;
            this.gunaTransfarantPictureBox1.TabStop = false;
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.Green;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = null;
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = null;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(126, 506);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.DarkGreen;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 10;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(94, 57);
            this.gunaAdvenceButton1.TabIndex = 2;
            this.gunaAdvenceButton1.Text = "Reload";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click_1);
            // 
            // start_stop_button
            // 
            this.start_stop_button.AnimationHoverSpeed = 0.07F;
            this.start_stop_button.AnimationSpeed = 0.03F;
            this.start_stop_button.BackColor = System.Drawing.Color.Transparent;
            this.start_stop_button.BaseColor = System.Drawing.Color.Green;
            this.start_stop_button.BorderColor = System.Drawing.Color.Black;
            this.start_stop_button.CheckedBaseColor = System.Drawing.Color.Gray;
            this.start_stop_button.CheckedBorderColor = System.Drawing.Color.Black;
            this.start_stop_button.CheckedForeColor = System.Drawing.Color.White;
            this.start_stop_button.CheckedImage = null;
            this.start_stop_button.CheckedLineColor = System.Drawing.Color.DimGray;
            this.start_stop_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.start_stop_button.FocusedColor = System.Drawing.Color.Empty;
            this.start_stop_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.start_stop_button.ForeColor = System.Drawing.Color.White;
            this.start_stop_button.Image = null;
            this.start_stop_button.ImageSize = new System.Drawing.Size(20, 20);
            this.start_stop_button.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.start_stop_button.Location = new System.Drawing.Point(414, 506);
            this.start_stop_button.Name = "start_stop_button";
            this.start_stop_button.OnHoverBaseColor = System.Drawing.Color.DarkGreen;
            this.start_stop_button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.start_stop_button.OnHoverForeColor = System.Drawing.Color.White;
            this.start_stop_button.OnHoverImage = null;
            this.start_stop_button.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.start_stop_button.OnPressedColor = System.Drawing.Color.Black;
            this.start_stop_button.Radius = 10;
            this.start_stop_button.Size = new System.Drawing.Size(94, 57);
            this.start_stop_button.TabIndex = 1;
            this.start_stop_button.Text = "Start";
            this.start_stop_button.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.start_stop_button.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // gunaAdvenceButton3
            // 
            this.gunaAdvenceButton3.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton3.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton3.BaseColor = System.Drawing.Color.Green;
            this.gunaAdvenceButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.CheckedImage = null;
            this.gunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DeepSkyBlue;
            this.gunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton3.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.Image = null;
            this.gunaAdvenceButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton3.Location = new System.Drawing.Point(244, 506);
            this.gunaAdvenceButton3.Name = "gunaAdvenceButton3";
            this.gunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.gunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.DarkGreen;
            this.gunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.OnHoverImage = null;
            this.gunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.Radius = 10;
            this.gunaAdvenceButton3.Size = new System.Drawing.Size(138, 57);
            this.gunaAdvenceButton3.TabIndex = 3;
            this.gunaAdvenceButton3.Text = "Save This Layout";
            this.gunaAdvenceButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton3.Click += new System.EventHandler(this.gunaAdvenceButton3_Click);
            // 
            // state
            // 
            this.state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.state.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.state.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.state.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.state.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.state.Location = new System.Drawing.Point(181, 206);
            this.state.MaxLength = 38;
            this.state.Name = "state";
            this.state.PasswordChar = '\0';
            this.state.SelectedText = "";
            this.state.Size = new System.Drawing.Size(309, 62);
            this.state.TabIndex = 4;
            this.state.Text = "DiscorPC";
            // 
            // details
            // 
            this.details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.details.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.details.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.details.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.details.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.details.Location = new System.Drawing.Point(181, 285);
            this.details.MaxLength = 38;
            this.details.Name = "details";
            this.details.PasswordChar = '\0';
            this.details.SelectedText = "";
            this.details.Size = new System.Drawing.Size(309, 62);
            this.details.TabIndex = 5;
            this.details.Text = "By Hamzaless";
            // 
            // minimum
            // 
            this.minimum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.minimum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.minimum.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.minimum.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.minimum.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.minimum.Location = new System.Drawing.Point(181, 364);
            this.minimum.MaxLength = 38;
            this.minimum.Name = "minimum";
            this.minimum.PasswordChar = '\0';
            this.minimum.SelectedText = "";
            this.minimum.Size = new System.Drawing.Size(120, 40);
            this.minimum.TabIndex = 6;
            this.minimum.Text = "1";
            this.minimum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // small_image_text
            // 
            this.small_image_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.small_image_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.small_image_text.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.small_image_text.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.small_image_text.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.small_image_text.Location = new System.Drawing.Point(364, 434);
            this.small_image_text.MaxLength = 38;
            this.small_image_text.Name = "small_image_text";
            this.small_image_text.PasswordChar = '\0';
            this.small_image_text.SelectedText = "";
            this.small_image_text.Size = new System.Drawing.Size(120, 40);
            this.small_image_text.TabIndex = 7;
            this.small_image_text.Text = "hamzaless_rpc2";
            // 
            // maximum
            // 
            this.maximum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.maximum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maximum.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.maximum.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maximum.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.maximum.Location = new System.Drawing.Point(364, 364);
            this.maximum.MaxLength = 38;
            this.maximum.Name = "maximum";
            this.maximum.PasswordChar = '\0';
            this.maximum.SelectedText = "";
            this.maximum.Size = new System.Drawing.Size(120, 40);
            this.maximum.TabIndex = 8;
            this.maximum.Text = "1";
            this.maximum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel2.Location = new System.Drawing.Point(318, 361);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(31, 41);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "/";
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 12;
            this.gunaElipse2.TargetControl = this.state;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.Radius = 12;
            this.gunaElipse3.TargetControl = this.details;
            // 
            // gunaElipse4
            // 
            this.gunaElipse4.Radius = 12;
            this.gunaElipse4.TargetControl = this.minimum;
            // 
            // gunaElipse5
            // 
            this.gunaElipse5.Radius = 12;
            this.gunaElipse5.TargetControl = this.small_image_text;
            // 
            // gunaElipse6
            // 
            this.gunaElipse6.Radius = 12;
            this.gunaElipse6.TargetControl = this.maximum;
            // 
            // big_image_text
            // 
            this.big_image_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.big_image_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.big_image_text.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.big_image_text.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.big_image_text.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.big_image_text.Location = new System.Drawing.Point(181, 434);
            this.big_image_text.MaxLength = 38;
            this.big_image_text.Name = "big_image_text";
            this.big_image_text.PasswordChar = '\0';
            this.big_image_text.SelectedText = "";
            this.big_image_text.Size = new System.Drawing.Size(120, 40);
            this.big_image_text.TabIndex = 9;
            this.big_image_text.Text = "hamzaless_rpc";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel3.Location = new System.Drawing.Point(318, 432);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(31, 41);
            this.gunaLabel3.TabIndex = 10;
            this.gunaLabel3.Text = "/";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel4.Location = new System.Drawing.Point(74, 215);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(98, 41);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "State;";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel5.Location = new System.Drawing.Point(52, 285);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(123, 41);
            this.gunaLabel5.TabIndex = 11;
            this.gunaLabel5.Text = "Details;";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.gunaLabel6.Location = new System.Drawing.Point(46, 361);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(126, 41);
            this.gunaLabel6.TabIndex = 12;
            this.gunaLabel6.Text = "Players;";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.gunaLabel7.Location = new System.Drawing.Point(8, 433);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(164, 41);
            this.gunaLabel7.TabIndex = 13;
            this.gunaLabel7.Text = "Big/Small;";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel8.Location = new System.Drawing.Point(490, 371);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(153, 28);
            this.gunaLabel8.TabIndex = 14;
            this.gunaLabel8.Text = "Minimum/Max";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.id.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.id.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.id.Location = new System.Drawing.Point(181, 121);
            this.id.MaxLength = 38;
            this.id.Name = "id";
            this.id.PasswordChar = '\0';
            this.id.SelectedText = "";
            this.id.Size = new System.Drawing.Size(309, 62);
            this.id.TabIndex = 15;
            this.id.Text = "1020722349152157766";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel9.Location = new System.Drawing.Point(57, 121);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(115, 41);
            this.gunaLabel9.TabIndex = 16;
            this.gunaLabel9.Text = "Bot ID;";
            // 
            // gunaElipse7
            // 
            this.gunaElipse7.Radius = 12;
            this.gunaElipse7.TargetControl = this.maximum;
            // 
            // gunaElipse8
            // 
            this.gunaElipse8.Radius = 12;
            this.gunaElipse8.TargetControl = this.big_image_text;
            // 
            // gunaElipse9
            // 
            this.gunaElipse9.Radius = 12;
            this.gunaElipse9.TargetControl = this.id;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel10.Location = new System.Drawing.Point(490, 440);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(79, 28);
            this.gunaLabel10.TabIndex = 17;
            this.gunaLabel10.Text = "images";
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.gunaPanel1;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.gunaElipsePanel1.Controls.Add(this.gunaElipsePanel2);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel11);
            this.gunaElipsePanel1.Controls.Add(this.gunaTransfarantPictureBox2);
            this.gunaElipsePanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(683, 130);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 25;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(470, 404);
            this.gunaElipsePanel1.TabIndex = 18;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel11.Location = new System.Drawing.Point(151, 136);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(236, 31);
            this.gunaLabel11.TabIndex = 3;
            this.gunaLabel11.Text = "HamzalessRPC#0001";
            // 
            // gunaTransfarantPictureBox2
            // 
            this.gunaTransfarantPictureBox2.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox2.Image = global::Discorpc.Properties.Resources.hamzaless_rpcpsd;
            this.gunaTransfarantPictureBox2.Location = new System.Drawing.Point(25, 56);
            this.gunaTransfarantPictureBox2.Name = "gunaTransfarantPictureBox2";
            this.gunaTransfarantPictureBox2.Size = new System.Drawing.Size(120, 120);
            this.gunaTransfarantPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox2.TabIndex = 2;
            this.gunaTransfarantPictureBox2.TabStop = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::Discorpc.Properties.Resources.DiscorPC2;
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, -9);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(493, 133);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.gunaElipsePanel2.Controls.Add(this.time);
            this.gunaElipsePanel2.Controls.Add(this.lbl_state_player);
            this.gunaElipsePanel2.Controls.Add(this.lbl_details);
            this.gunaElipsePanel2.Controls.Add(this.gunaLabel12);
            this.gunaElipsePanel2.Controls.Add(this.gunaTransfarantPictureBox4);
            this.gunaElipsePanel2.Controls.Add(this.gunaTransfarantPictureBox3);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(26, 193);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Radius = 20;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(419, 195);
            this.gunaElipsePanel2.TabIndex = 4;
            // 
            // gunaTransfarantPictureBox3
            // 
            this.gunaTransfarantPictureBox3.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox3.Image = global::Discorpc.Properties.Resources.hamzablgn;
            this.gunaTransfarantPictureBox3.Location = new System.Drawing.Point(3, 0);
            this.gunaTransfarantPictureBox3.Name = "gunaTransfarantPictureBox3";
            this.gunaTransfarantPictureBox3.Size = new System.Drawing.Size(90, 90);
            this.gunaTransfarantPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox3.TabIndex = 5;
            this.gunaTransfarantPictureBox3.TabStop = false;
            // 
            // gunaTransfarantPictureBox4
            // 
            this.gunaTransfarantPictureBox4.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox4.Image = global::Discorpc.Properties.Resources.hamzaless_rpcpsd;
            this.gunaTransfarantPictureBox4.Location = new System.Drawing.Point(57, 63);
            this.gunaTransfarantPictureBox4.Name = "gunaTransfarantPictureBox4";
            this.gunaTransfarantPictureBox4.Size = new System.Drawing.Size(45, 45);
            this.gunaTransfarantPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox4.TabIndex = 6;
            this.gunaTransfarantPictureBox4.TabStop = false;
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel12.Location = new System.Drawing.Point(114, 12);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(137, 31);
            this.gunaLabel12.TabIndex = 5;
            this.gunaLabel12.Text = "Bot\'s Name";
            // 
            // lbl_details
            // 
            this.lbl_details.AutoSize = true;
            this.lbl_details.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_details.Location = new System.Drawing.Point(114, 55);
            this.lbl_details.Name = "lbl_details";
            this.lbl_details.Size = new System.Drawing.Size(78, 28);
            this.lbl_details.TabIndex = 7;
            this.lbl_details.Text = "Details";
            // 
            // lbl_state_player
            // 
            this.lbl_state_player.AutoEllipsis = true;
            this.lbl_state_player.AutoSize = true;
            this.lbl_state_player.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_state_player.Location = new System.Drawing.Point(114, 97);
            this.lbl_state_player.Name = "lbl_state_player";
            this.lbl_state_player.Size = new System.Drawing.Size(174, 25);
            this.lbl_state_player.TabIndex = 8;
            this.lbl_state_player.Text = "State +(0/0Player)";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.time.Location = new System.Drawing.Point(115, 144);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(126, 25);
            this.time.TabIndex = 9;
            this.time.Text = "00:00 Passed";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1188, 577);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.start_stop_button);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.gunaLabel10);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.id);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.big_image_text);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.maximum);
            this.Controls.Add(this.small_image_text);
            this.Controls.Add(this.minimum);
            this.Controls.Add(this.details);
            this.Controls.Add(this.state);
            this.Controls.Add(this.gunaAdvenceButton3);
            this.Controls.Add(this.gunaPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaAdvenceButton start_stop_button;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton3;
        private Guna.UI.WinForms.GunaLineTextBox state;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLineTextBox big_image_text;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLineTextBox maximum;
        private Guna.UI.WinForms.GunaLineTextBox small_image_text;
        private Guna.UI.WinForms.GunaLineTextBox minimum;
        private Guna.UI.WinForms.GunaLineTextBox details;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private Guna.UI.WinForms.GunaElipse gunaElipse4;
        private Guna.UI.WinForms.GunaElipse gunaElipse5;
        private Guna.UI.WinForms.GunaElipse gunaElipse6;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLineTextBox id;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaElipse gunaElipse7;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaElipse gunaElipse8;
        private Guna.UI.WinForms.GunaElipse gunaElipse9;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox4;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox3;
        private Guna.UI.WinForms.GunaLabel lbl_state_player;
        private Guna.UI.WinForms.GunaLabel lbl_details;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaLabel time;
        private System.Windows.Forms.Timer timer2;
    }
}

