﻿namespace QuanLyGD
{
    partial class LichHoc
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
            this.lstLichHoc = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstLichHoc
            // 
            this.lstLichHoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstLichHoc.FullRowSelect = true;
            this.lstLichHoc.GridLines = true;
            this.lstLichHoc.HideSelection = false;
            this.lstLichHoc.Location = new System.Drawing.Point(12, 12);
            this.lstLichHoc.Name = "lstLichHoc";
            this.lstLichHoc.Size = new System.Drawing.Size(663, 550);
            this.lstLichHoc.TabIndex = 0;
            this.lstLichHoc.UseCompatibleStateImageBehavior = false;
            this.lstLichHoc.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Giảng Dạy";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Thời Gian";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phòng Học";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Lớp";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giảng Viên";
            this.columnHeader5.Width = 120;
            // 
            // LichHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 596);
            this.Controls.Add(this.lstLichHoc);
            this.Name = "LichHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch Học";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LichHoc_FormClosing);
            this.Load += new System.EventHandler(this.lichHoc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstLichHoc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}