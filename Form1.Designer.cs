using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Design;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Drawing;
using MetroFramework.Forms;
using MetroFramework;
using MetroFramework.Controls;

namespace Scan
{
    partial class Form1 : MetroFramework.Forms.MetroForm {

      

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ip = new System.Windows.Forms.ColumnHeader();
            this.host = new System.Windows.Forms.ColumnHeader();
            this.stat = new System.Windows.Forms.ColumnHeader();
            this.LUp = new System.Windows.Forms.ColumnHeader();
            this.CkMostraHost = new System.Windows.Forms.CheckBox();
            this.CkDown = new System.Windows.Forms.CheckBox();
            this.TxtSubnet = new System.Windows.Forms.MaskedTextBox();
            this.TxtIP = new System.Windows.Forms.MaskedTextBox();
            this.BoxFiltros = new System.Windows.Forms.GroupBox();
            this.BtnScanIP = new MetroFramework.Controls.MetroButton();
            this.BtnScan = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.PBar = new MetroFramework.Controls.MetroProgressBar();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.BtnStop = new MetroFramework.Controls.MetroButton();
            this.BoxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subnet:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelStatus.Location = new System.Drawing.Point(10, 208);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(47, 16);
            this.LabelStatus.TabIndex = 3;
            this.LabelStatus.Text = "Status:";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblStatus.Location = new System.Drawing.Point(83, 208);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(0, 21);
            this.LblStatus.TabIndex = 6;
            // 
            // ListView1
            // 
            this.ListView1.AllowDrop = true;
            this.ListView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ip,
            this.host,
            this.stat,
            this.LUp});
            this.ListView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListView1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ListView1.FullRowSelect = true;
            this.ListView1.GridLines = true;
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(2, 63);
            this.ListView1.Name = "ListView1";
            this.ListView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListView1.Size = new System.Drawing.Size(696, 564);
            this.ListView1.TabIndex = 1;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.ListView1.DoubleClick += new System.EventHandler(this.ListView1_DoubleClick);
            // 
            // ip
            // 
            this.ip.Text = "IP Address";
            this.ip.Width = 150;
            // 
            // host
            // 
            this.host.Text = "Host Name";
            this.host.Width = 220;
            // 
            // stat
            // 
            this.stat.Text = "Status";
            this.stat.Width = 150;
            // 
            // LUp
            // 
            this.LUp.Text = "Last Up";
            this.LUp.Width = 140;
            // 
            // CkMostraHost
            // 
            this.CkMostraHost.AutoSize = true;
            this.CkMostraHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CkMostraHost.Location = new System.Drawing.Point(6, 62);
            this.CkMostraHost.Name = "CkMostraHost";
            this.CkMostraHost.Size = new System.Drawing.Size(102, 19);
            this.CkMostraHost.TabIndex = 10;
            this.CkMostraHost.Text = "Mostrar Hosts";
            this.CkMostraHost.UseVisualStyleBackColor = true;
            this.CkMostraHost.CheckedChanged += new System.EventHandler(this.CkMostraHost_CheckedChanged);
            // 
            // CkDown
            // 
            this.CkDown.AutoSize = true;
            this.CkDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CkDown.Location = new System.Drawing.Point(6, 37);
            this.CkDown.Name = "CkDown";
            this.CkDown.Size = new System.Drawing.Size(207, 19);
            this.CkDown.TabIndex = 11;
            this.CkDown.Text = "Mostrar Somente Ip\'s disponíveis";
            this.CkDown.UseVisualStyleBackColor = true;
            this.CkDown.CheckedChanged += new System.EventHandler(this.CkDown_CheckedChanged);
            // 
            // TxtSubnet
            // 
            this.TxtSubnet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSubnet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSubnet.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TxtSubnet.HideSelection = false;
            this.TxtSubnet.Location = new System.Drawing.Point(123, 98);
            this.TxtSubnet.Mask = "##0\\.##0\\.##0\\";
            this.TxtSubnet.Name = "TxtSubnet";
            this.TxtSubnet.RejectInputOnFirstFailure = true;
            this.TxtSubnet.Size = new System.Drawing.Size(164, 29);
            this.TxtSubnet.TabIndex = 12;
            this.TxtSubnet.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected_1);
            this.TxtSubnet.Click += new System.EventHandler(this.maskedTextBox1_Click_1);
            // 
            // TxtIP
            // 
            this.TxtIP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIP.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TxtIP.Location = new System.Drawing.Point(123, 151);
            this.TxtIP.Mask = "##0\\.##0\\.##0\\.##0\\";
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(164, 29);
            this.TxtIP.TabIndex = 13;
            this.TxtIP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TxtIP_MaskInputRejected);
            this.TxtIP.Click += new System.EventHandler(this.TxtIP_Click);
            // 
            // BoxFiltros
            // 
            this.BoxFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxFiltros.Controls.Add(this.BtnStop);
            this.BoxFiltros.Controls.Add(this.BtnScanIP);
            this.BoxFiltros.Controls.Add(this.BtnScan);
            this.BoxFiltros.Controls.Add(this.label2);
            this.BoxFiltros.Controls.Add(this.txtPesquisa);
            this.BoxFiltros.Controls.Add(this.CkDown);
            this.BoxFiltros.Controls.Add(this.TxtIP);
            this.BoxFiltros.Controls.Add(this.LblStatus);
            this.BoxFiltros.Controls.Add(this.TxtSubnet);
            this.BoxFiltros.Controls.Add(this.LabelStatus);
            this.BoxFiltros.Controls.Add(this.CkMostraHost);
            this.BoxFiltros.Controls.Add(this.label1);
            this.BoxFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoxFiltros.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BoxFiltros.Location = new System.Drawing.Point(704, 57);
            this.BoxFiltros.Name = "BoxFiltros";
            this.BoxFiltros.Size = new System.Drawing.Size(421, 570);
            this.BoxFiltros.TabIndex = 15;
            this.BoxFiltros.TabStop = false;
            this.BoxFiltros.Text = "Filtros";
            this.BoxFiltros.Enter += new System.EventHandler(this.BoxFiltros_Enter);
            // 
            // BtnScanIP
            // 
            this.BtnScanIP.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnScanIP.BackgroundImage = global::Scan.Properties.Resources._1486348532_music_play_pause_control_go_arrow_80458;
            this.BtnScanIP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnScanIP.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnScanIP.Highlight = true;
            this.BtnScanIP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnScanIP.Location = new System.Drawing.Point(6, 145);
            this.BtnScanIP.Name = "BtnScanIP";
            this.BtnScanIP.Size = new System.Drawing.Size(95, 35);
            this.BtnScanIP.Style = MetroFramework.MetroColorStyle.Blue;
            this.BtnScanIP.TabIndex = 17;
            this.BtnScanIP.Text = "IP ADDRESS";
            this.BtnScanIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnScanIP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnScanIP.UseCustomBackColor = true;
            this.BtnScanIP.UseCustomForeColor = true;
            this.BtnScanIP.UseSelectable = true;
            this.BtnScanIP.UseStyleColors = true;
            this.BtnScanIP.UseVisualStyleBackColor = false;
            this.BtnScanIP.Click += new System.EventHandler(this.btnScanIP_Click);
            // 
            // BtnScan
            // 
            this.BtnScan.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnScan.BackgroundImage = global::Scan.Properties.Resources._1486348532_music_play_pause_control_go_arrow_80458;
            this.BtnScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnScan.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnScan.Highlight = true;
            this.BtnScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnScan.Location = new System.Drawing.Point(6, 98);
            this.BtnScan.Name = "BtnScan";
            this.BtnScan.Size = new System.Drawing.Size(95, 35);
            this.BtnScan.Style = MetroFramework.MetroColorStyle.Blue;
            this.BtnScan.TabIndex = 16;
            this.BtnScan.Text = "SUBNET";
            this.BtnScan.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnScan.UseCustomBackColor = true;
            this.BtnScan.UseCustomForeColor = true;
            this.BtnScan.UseSelectable = true;
            this.BtnScan.UseStyleColors = true;
            this.BtnScan.UseVisualStyleBackColor = false;
            this.BtnScan.Click += new System.EventHandler(this.BtnScan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Pesquisa";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPesquisa.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPesquisa.Location = new System.Drawing.Point(84, 267);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(203, 29);
            this.txtPesquisa.TabIndex = 14;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            this.txtPesquisa.Enter += new System.EventHandler(this.txtPesquisa_Enter);
            this.txtPesquisa.Leave += new System.EventHandler(this.txtPesquisa_Leave);
            // 
            // PBar
            // 
            this.PBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PBar.Location = new System.Drawing.Point(2, 633);
            this.PBar.Name = "PBar";
            this.PBar.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.PBar.Size = new System.Drawing.Size(1123, 63);
            this.PBar.Style = MetroFramework.MetroColorStyle.Green;
            this.PBar.TabIndex = 16;
            this.PBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PBar.UseCustomBackColor = true;
            this.PBar.Click += new System.EventHandler(this.PBar_Click_1);
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandTimeout = 30;
            // 
            // BtnStop
            // 
            this.BtnStop.BackColor = System.Drawing.Color.AliceBlue;
            this.BtnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnStop.BackgroundImage")));
            this.BtnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnStop.Highlight = true;
            this.BtnStop.Location = new System.Drawing.Point(303, 98);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(42, 29);
            this.BtnStop.Style = MetroFramework.MetroColorStyle.Blue;
            this.BtnStop.TabIndex = 18;
            this.BtnStop.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnStop.UseCustomBackColor = true;
            this.BtnStop.UseCustomForeColor = true;
            this.BtnStop.UseSelectable = true;
            this.BtnStop.UseStyleColors = true;
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1131, 697);
            this.Controls.Add(this.PBar);
            this.Controls.Add(this.BoxFiltros);
            this.Controls.Add(this.ListView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "GERENCIAMENTO DE IP\'S";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.QueryAccessibilityHelp += new System.Windows.Forms.QueryAccessibilityHelpEventHandler(this.Form1_QueryAccessibilityHelp);
            this.BoxFiltros.ResumeLayout(false);
            this.BoxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e) {
            Show();
            


        }



        #endregion
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.ListView ListView1;
        private CheckBox CkMostraHost;
        private CheckBox CkDown;
        private MaskedTextBox TxtSubnet;
        private MaskedTextBox TxtIP;
        private GroupBox BoxFiltros;
        public ColumnHeader ip;
        public ColumnHeader host;
        public ColumnHeader stat;
        public ColumnHeader LUp;
        private Label label2;
        private TextBox txtPesquisa;
        private MetroFramework.Controls.MetroProgressBar PBar;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private MetroFramework.Controls.MetroButton BtnScanIP;
        private MetroFramework.Controls.MetroButton BtnScan;
        private MetroButton BtnStop;
    }
}

