﻿namespace QuanLyNhanSu
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNghiepVu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemQuanLyNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemQuanLyPhongBan = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemQuanLyNangLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemQuanLyTĐHV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemQTCT = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.ThanhCongCu = new System.Windows.Forms.ToolStrip();
            this.ttNhanVientoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPhongBan = new System.Windows.Forms.ToolStripButton();
            this.btnNangLuong = new System.Windows.Forms.ToolStripButton();
            this.btnTĐHV = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.btnQuaTrinhCongTac = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.ThanhCongCu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHeThong,
            this.MenuNghiepVu,
            this.MenuTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuHeThong
            // 
            this.MenuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDangXuat,
            this.toolStripSeparator1,
            this.ToolStripMenuItemThoat});
            this.MenuHeThong.Name = "MenuHeThong";
            this.MenuHeThong.Size = new System.Drawing.Size(69, 31);
            this.MenuHeThong.Text = "Hệ thống";
            // 
            // ToolStripMenuItemDangXuat
            // 
            this.ToolStripMenuItemDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemDangXuat.Image")));
            this.ToolStripMenuItemDangXuat.Name = "ToolStripMenuItemDangXuat";
            this.ToolStripMenuItemDangXuat.Size = new System.Drawing.Size(127, 22);
            this.ToolStripMenuItemDangXuat.Text = "Đăng xuất";
            this.ToolStripMenuItemDangXuat.Click += new System.EventHandler(this.ToolStripMenuItemDangXuat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(124, 6);
            // 
            // ToolStripMenuItemThoat
            // 
            this.ToolStripMenuItemThoat.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemThoat.Image")));
            this.ToolStripMenuItemThoat.Name = "ToolStripMenuItemThoat";
            this.ToolStripMenuItemThoat.Size = new System.Drawing.Size(127, 22);
            this.ToolStripMenuItemThoat.Text = "Thoát";
            this.ToolStripMenuItemThoat.Click += new System.EventHandler(this.ToolStripMenuItemThoat_Click);
            // 
            // MenuNghiepVu
            // 
            this.MenuNghiepVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemQuanLyNhanVien,
            this.toolStripSeparator5,
            this.toolStripMenuItemQuanLyPhongBan,
            this.ToolStripMenuItemQuanLyNangLuong,
            this.ToolStripMenuItemQuanLyTĐHV,
            this.toolStripMenuItemQTCT});
            this.MenuNghiepVu.Name = "MenuNghiepVu";
            this.MenuNghiepVu.Size = new System.Drawing.Size(74, 31);
            this.MenuNghiepVu.Text = "Nghiệp vụ";
            // 
            // toolStripMenuItemQuanLyNhanVien
            // 
            this.toolStripMenuItemQuanLyNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemQuanLyNhanVien.Image")));
            this.toolStripMenuItemQuanLyNhanVien.Name = "toolStripMenuItemQuanLyNhanVien";
            this.toolStripMenuItemQuanLyNhanVien.Size = new System.Drawing.Size(222, 22);
            this.toolStripMenuItemQuanLyNhanVien.Text = "Quản lý thông tin nhân viên";
            this.toolStripMenuItemQuanLyNhanVien.Click += new System.EventHandler(this.toolStripMenuItemQuanLyNhanVien_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(219, 6);
            // 
            // toolStripMenuItemQuanLyPhongBan
            // 
            this.toolStripMenuItemQuanLyPhongBan.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemQuanLyPhongBan.Image")));
            this.toolStripMenuItemQuanLyPhongBan.Name = "toolStripMenuItemQuanLyPhongBan";
            this.toolStripMenuItemQuanLyPhongBan.Size = new System.Drawing.Size(222, 22);
            this.toolStripMenuItemQuanLyPhongBan.Text = "Quản lý phòng ban";
            this.toolStripMenuItemQuanLyPhongBan.Click += new System.EventHandler(this.toolStripMenuItemQuanLyPhongBan_Click);
            // 
            // ToolStripMenuItemQuanLyNangLuong
            // 
            this.ToolStripMenuItemQuanLyNangLuong.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemQuanLyNangLuong.Image")));
            this.ToolStripMenuItemQuanLyNangLuong.Name = "ToolStripMenuItemQuanLyNangLuong";
            this.ToolStripMenuItemQuanLyNangLuong.Size = new System.Drawing.Size(222, 22);
            this.ToolStripMenuItemQuanLyNangLuong.Text = "Quản lý nâng lương";
            this.ToolStripMenuItemQuanLyNangLuong.Click += new System.EventHandler(this.ToolStripMenuItemQuanLyNangLuong_Click);
            // 
            // ToolStripMenuItemQuanLyTĐHV
            // 
            this.ToolStripMenuItemQuanLyTĐHV.Image = global::QuanLyNhanSu.Properties.Resources.book_open;
            this.ToolStripMenuItemQuanLyTĐHV.Name = "ToolStripMenuItemQuanLyTĐHV";
            this.ToolStripMenuItemQuanLyTĐHV.Size = new System.Drawing.Size(222, 22);
            this.ToolStripMenuItemQuanLyTĐHV.Text = "Quản lý trình độ học vấn";
            this.ToolStripMenuItemQuanLyTĐHV.Click += new System.EventHandler(this.ToolStripMenuItemQuanLyTĐHV_Click);
            // 
            // toolStripMenuItemQTCT
            // 
            this.toolStripMenuItemQTCT.Image = global::QuanLyNhanSu.Properties.Resources.chart;
            this.toolStripMenuItemQTCT.Name = "toolStripMenuItemQTCT";
            this.toolStripMenuItemQTCT.Size = new System.Drawing.Size(222, 22);
            this.toolStripMenuItemQTCT.Text = "Quá trình công tác";
            this.toolStripMenuItemQTCT.Click += new System.EventHandler(this.toolStripMenuItemQTCT_Click);
            // 
            // MenuTroGiup
            // 
            this.MenuTroGiup.Name = "MenuTroGiup";
            this.MenuTroGiup.Size = new System.Drawing.Size(79, 31);
            this.MenuTroGiup.Text = "Hướng dẫn";
            this.MenuTroGiup.Click += new System.EventHandler(this.MenuTroGiup_Click);
            // 
            // ThanhCongCu
            // 
            this.ThanhCongCu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ThanhCongCu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttNhanVientoolStripButton,
            this.toolStripSeparator7,
            this.btnPhongBan,
            this.btnNangLuong,
            this.btnTĐHV,
            this.toolStripSeparator12,
            this.btnQuaTrinhCongTac,
            this.toolStripButton1});
            this.ThanhCongCu.Location = new System.Drawing.Point(0, 35);
            this.ThanhCongCu.Name = "ThanhCongCu";
            this.ThanhCongCu.Size = new System.Drawing.Size(684, 70);
            this.ThanhCongCu.TabIndex = 2;
            this.ThanhCongCu.Text = "toolStrip1";
            // 
            // ttNhanVientoolStripButton
            // 
            this.ttNhanVientoolStripButton.Image = global::QuanLyNhanSu.Properties.Resources.businessman;
            this.ttNhanVientoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ttNhanVientoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ttNhanVientoolStripButton.Name = "ttNhanVientoolStripButton";
            this.ttNhanVientoolStripButton.Size = new System.Drawing.Size(107, 67);
            this.ttNhanVientoolStripButton.Tag = "1";
            this.ttNhanVientoolStripButton.Text = "Quản lý nhân viên";
            this.ttNhanVientoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ttNhanVientoolStripButton.Click += new System.EventHandler(this.ttNhanVientoolStripButton_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 70);
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.Image = global::QuanLyNhanSu.Properties.Resources.houses;
            this.btnPhongBan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPhongBan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.Size = new System.Drawing.Size(113, 67);
            this.btnPhongBan.Tag = "2";
            this.btnPhongBan.Text = "Quản lý phòng ban";
            this.btnPhongBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPhongBan.Click += new System.EventHandler(this.btnPhongBan_Click);
            // 
            // btnNangLuong
            // 
            this.btnNangLuong.Image = global::QuanLyNhanSu.Properties.Resources.currency_dollar;
            this.btnNangLuong.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNangLuong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNangLuong.Name = "btnNangLuong";
            this.btnNangLuong.Size = new System.Drawing.Size(89, 67);
            this.btnNangLuong.Tag = "3";
            this.btnNangLuong.Text = "Quản lý Lương";
            this.btnNangLuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNangLuong.Click += new System.EventHandler(this.btnNangLuong_Click);
            // 
            // btnTĐHV
            // 
            this.btnTĐHV.Image = global::QuanLyNhanSu.Properties.Resources.book_open;
            this.btnTĐHV.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTĐHV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTĐHV.Name = "btnTĐHV";
            this.btnTĐHV.Size = new System.Drawing.Size(97, 67);
            this.btnTĐHV.Text = "Quản lý học vấn";
            this.btnTĐHV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTĐHV.Click += new System.EventHandler(this.btnTĐHV_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 70);
            // 
            // btnQuaTrinhCongTac
            // 
            this.btnQuaTrinhCongTac.Image = global::QuanLyNhanSu.Properties.Resources.chart;
            this.btnQuaTrinhCongTac.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnQuaTrinhCongTac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuaTrinhCongTac.Name = "btnQuaTrinhCongTac";
            this.btnQuaTrinhCongTac.Size = new System.Drawing.Size(110, 67);
            this.btnQuaTrinhCongTac.Text = "Quá trình công tác";
            this.btnQuaTrinhCongTac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQuaTrinhCongTac.Click += new System.EventHandler(this.btnQuaTrinhCongTac_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::QuanLyNhanSu.Properties.Resources.exit;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 67);
            this.toolStripButton1.Text = "Thoát";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // timer1
            // 
           
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QuanLyNhanSu.Properties.Resources.LogoHV;
            this.pictureBox1.Location = new System.Drawing.Point(0, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 349);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 454);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ThanhCongCu);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý nhân sự";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ThanhCongCu.ResumeLayout(false);
            this.ThanhCongCu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuHeThong;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemThoat;
        private System.Windows.Forms.ToolStripMenuItem MenuNghiepVu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQuanLyNhanVien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQuanLyPhongBan;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemQuanLyNangLuong;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemQuanLyTĐHV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQTCT;
        private System.Windows.Forms.ToolStripMenuItem MenuTroGiup;
        private System.Windows.Forms.ToolStrip ThanhCongCu;
        private System.Windows.Forms.ToolStripButton ttNhanVientoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btnPhongBan;
        private System.Windows.Forms.ToolStripButton btnNangLuong;
        private System.Windows.Forms.ToolStripButton btnTĐHV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton btnQuaTrinhCongTac;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}