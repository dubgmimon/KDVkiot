
namespace KDVkiot
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
            this.components = new System.ComponentModel.Container();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnThietLap = new FontAwesome.Sharp.IconButton();
            this.btnBaoCao = new FontAwesome.Sharp.IconButton();
            this.btnSoQuy = new FontAwesome.Sharp.IconButton();
            this.btnNhanLuc = new FontAwesome.Sharp.IconButton();
            this.btnDoiTac = new FontAwesome.Sharp.IconButton();
            this.btnGiaoDich = new FontAwesome.Sharp.IconButton();
            this.btnHangHoa = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.mnHangHoa = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.mnItemDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemThietLapGia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemKiemKho = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mnHangHoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelSideMenu.Controls.Add(this.btnThietLap);
            this.panelSideMenu.Controls.Add(this.btnBaoCao);
            this.panelSideMenu.Controls.Add(this.btnSoQuy);
            this.panelSideMenu.Controls.Add(this.btnNhanLuc);
            this.panelSideMenu.Controls.Add(this.btnDoiTac);
            this.panelSideMenu.Controls.Add(this.btnGiaoDich);
            this.panelSideMenu.Controls.Add(this.btnHangHoa);
            this.panelSideMenu.Controls.Add(this.btnHome);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(230, 616);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnThietLap
            // 
            this.btnThietLap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThietLap.FlatAppearance.BorderSize = 0;
            this.btnThietLap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThietLap.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThietLap.ForeColor = System.Drawing.Color.White;
            this.btnThietLap.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.btnThietLap.IconColor = System.Drawing.Color.White;
            this.btnThietLap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThietLap.IconSize = 30;
            this.btnThietLap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThietLap.Location = new System.Drawing.Point(0, 556);
            this.btnThietLap.Name = "btnThietLap";
            this.btnThietLap.Padding = new System.Windows.Forms.Padding(10, 0, 0, 15);
            this.btnThietLap.Size = new System.Drawing.Size(230, 60);
            this.btnThietLap.TabIndex = 9;
            this.btnThietLap.Tag = "Thiết lập";
            this.btnThietLap.Text = "   Thiết lập";
            this.btnThietLap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThietLap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThietLap.UseVisualStyleBackColor = true;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnBaoCao.IconColor = System.Drawing.Color.White;
            this.btnBaoCao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBaoCao.IconSize = 30;
            this.btnBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.Location = new System.Drawing.Point(0, 340);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBaoCao.Size = new System.Drawing.Size(230, 40);
            this.btnBaoCao.TabIndex = 7;
            this.btnBaoCao.Tag = "Báo cáo";
            this.btnBaoCao.Text = "    Báo cáo";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            // 
            // btnSoQuy
            // 
            this.btnSoQuy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSoQuy.FlatAppearance.BorderSize = 0;
            this.btnSoQuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoQuy.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoQuy.ForeColor = System.Drawing.Color.White;
            this.btnSoQuy.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.btnSoQuy.IconColor = System.Drawing.Color.White;
            this.btnSoQuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSoQuy.IconSize = 30;
            this.btnSoQuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoQuy.Location = new System.Drawing.Point(0, 300);
            this.btnSoQuy.Name = "btnSoQuy";
            this.btnSoQuy.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSoQuy.Size = new System.Drawing.Size(230, 40);
            this.btnSoQuy.TabIndex = 6;
            this.btnSoQuy.Tag = "Sổ quỹ";
            this.btnSoQuy.Text = "    Sổ quỹ";
            this.btnSoQuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoQuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSoQuy.UseVisualStyleBackColor = true;
            // 
            // btnNhanLuc
            // 
            this.btnNhanLuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanLuc.FlatAppearance.BorderSize = 0;
            this.btnNhanLuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanLuc.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanLuc.ForeColor = System.Drawing.Color.White;
            this.btnNhanLuc.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnNhanLuc.IconColor = System.Drawing.Color.White;
            this.btnNhanLuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhanLuc.IconSize = 30;
            this.btnNhanLuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanLuc.Location = new System.Drawing.Point(0, 260);
            this.btnNhanLuc.Name = "btnNhanLuc";
            this.btnNhanLuc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNhanLuc.Size = new System.Drawing.Size(230, 40);
            this.btnNhanLuc.TabIndex = 5;
            this.btnNhanLuc.Tag = "Nhân lực";
            this.btnNhanLuc.Text = "    Nhân lực";
            this.btnNhanLuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanLuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanLuc.UseVisualStyleBackColor = true;
            // 
            // btnDoiTac
            // 
            this.btnDoiTac.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoiTac.FlatAppearance.BorderSize = 0;
            this.btnDoiTac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiTac.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiTac.ForeColor = System.Drawing.Color.White;
            this.btnDoiTac.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnDoiTac.IconColor = System.Drawing.Color.White;
            this.btnDoiTac.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDoiTac.IconSize = 30;
            this.btnDoiTac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiTac.Location = new System.Drawing.Point(0, 220);
            this.btnDoiTac.Name = "btnDoiTac";
            this.btnDoiTac.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDoiTac.Size = new System.Drawing.Size(230, 40);
            this.btnDoiTac.TabIndex = 4;
            this.btnDoiTac.Tag = "Đối tác";
            this.btnDoiTac.Text = "    Đối tác";
            this.btnDoiTac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiTac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoiTac.UseVisualStyleBackColor = true;
            // 
            // btnGiaoDich
            // 
            this.btnGiaoDich.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGiaoDich.FlatAppearance.BorderSize = 0;
            this.btnGiaoDich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaoDich.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaoDich.ForeColor = System.Drawing.Color.White;
            this.btnGiaoDich.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.btnGiaoDich.IconColor = System.Drawing.Color.White;
            this.btnGiaoDich.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGiaoDich.IconSize = 30;
            this.btnGiaoDich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaoDich.Location = new System.Drawing.Point(0, 180);
            this.btnGiaoDich.Name = "btnGiaoDich";
            this.btnGiaoDich.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGiaoDich.Size = new System.Drawing.Size(230, 40);
            this.btnGiaoDich.TabIndex = 3;
            this.btnGiaoDich.Tag = "Giao dịch";
            this.btnGiaoDich.Text = "    Giao dịch";
            this.btnGiaoDich.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaoDich.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGiaoDich.UseVisualStyleBackColor = true;
            this.btnGiaoDich.Click += new System.EventHandler(this.btnGiaoDich_Click);
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHangHoa.FlatAppearance.BorderSize = 0;
            this.btnHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHangHoa.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHangHoa.ForeColor = System.Drawing.Color.White;
            this.btnHangHoa.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.btnHangHoa.IconColor = System.Drawing.Color.White;
            this.btnHangHoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHangHoa.IconSize = 30;
            this.btnHangHoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHangHoa.Location = new System.Drawing.Point(0, 140);
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHangHoa.Size = new System.Drawing.Size(230, 40);
            this.btnHangHoa.TabIndex = 2;
            this.btnHangHoa.Tag = "Hàng hóa";
            this.btnHangHoa.Text = "    Hàng hóa";
            this.btnHangHoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHangHoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHangHoa.UseVisualStyleBackColor = true;
            this.btnHangHoa.Click += new System.EventHandler(this.btnHangHoa_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 30;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 100);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(230, 40);
            this.btnHome.TabIndex = 1;
            this.btnHome.Tag = "Tổng quan";
            this.btnHome.Text = "    Tổng quan";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(121, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(79, 44);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Controls.Add(this.panel2);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(230, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(832, 60);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnMaximize);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(691, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 60);
            this.panel2.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(8, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 31);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.ExpandAlt;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(53, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(45, 31);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Tomato;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(96, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(230, 60);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(832, 556);
            this.panelDesktop.TabIndex = 2;
            // 
            // mnHangHoa
            // 
            this.mnHangHoa.IsMainMenu = false;
            this.mnHangHoa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnItemDanhMuc,
            this.mnItemThietLapGia,
            this.mnItemKiemKho});
            this.mnHangHoa.MenuItemHeight = 50;
            this.mnHangHoa.MenuItemTextColor = System.Drawing.Color.Empty;
            this.mnHangHoa.Name = "mnHangHoa";
            this.mnHangHoa.PrimaryColor = System.Drawing.Color.DodgerBlue;
            this.mnHangHoa.Size = new System.Drawing.Size(181, 92);
            // 
            // mnItemDanhMuc
            // 
            this.mnItemDanhMuc.Name = "mnItemDanhMuc";
            this.mnItemDanhMuc.Size = new System.Drawing.Size(180, 22);
            this.mnItemDanhMuc.Text = "Danh mục";
            this.mnItemDanhMuc.Click += new System.EventHandler(this.mnItemDanhMuc_Click);
            // 
            // mnItemThietLapGia
            // 
            this.mnItemThietLapGia.Name = "mnItemThietLapGia";
            this.mnItemThietLapGia.Size = new System.Drawing.Size(180, 22);
            this.mnItemThietLapGia.Text = "Thiết lập giá";
            // 
            // mnItemKiemKho
            // 
            this.mnItemKiemKho.Name = "mnItemKiemKho";
            this.mnItemKiemKho.Size = new System.Drawing.Size(180, 22);
            this.mnItemKiemKho.Text = "Kiểm kho";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 616);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelSideMenu);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelSideMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.mnHangHoa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnBaoCao;
        private FontAwesome.Sharp.IconButton btnSoQuy;
        private FontAwesome.Sharp.IconButton btnNhanLuc;
        private FontAwesome.Sharp.IconButton btnDoiTac;
        private FontAwesome.Sharp.IconButton btnGiaoDich;
        private FontAwesome.Sharp.IconButton btnHangHoa;
        private FontAwesome.Sharp.IconButton btnThietLap;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private RJCodeAdvance.RJControls.RJDropdownMenu mnHangHoa;
        private System.Windows.Forms.ToolStripMenuItem mnItemDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnItemThietLapGia;
        private System.Windows.Forms.ToolStripMenuItem mnItemKiemKho;
    }
}

