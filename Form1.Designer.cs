﻿using FirebirdSql.Data.FirebirdClient;
using System;
using System.Configuration;
using System.Windows.Forms;
using System.Globalization;
namespace Scan {
    partial class Form1 {
           


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
            this.label1 = new System.Windows.Forms.Label();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.BtnScan = new System.Windows.Forms.Button();
            this.PBar = new System.Windows.Forms.ProgressBar();
            this.LblStatus = new System.Windows.Forms.Label();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ip = new System.Windows.Forms.ColumnHeader();
            this.host = new System.Windows.Forms.ColumnHeader();
            this.stat = new System.Windows.Forms.ColumnHeader();
            this.LUp = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxAgendamento = new System.Windows.Forms.GroupBox();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.rbdiario = new System.Windows.Forms.RadioButton();
            this.rbMes = new System.Windows.Forms.RadioButton();
            this.rbSemana = new System.Windows.Forms.RadioButton();
            this.CkMostraHost = new System.Windows.Forms.CheckBox();
            this.CkDown = new System.Windows.Forms.CheckBox();
            this.BtnScanIP = new System.Windows.Forms.Button();
            this.TxtSubnet = new System.Windows.Forms.MaskedTextBox();
            this.TxtIP = new System.Windows.Forms.MaskedTextBox();
            this.BoxFiltros = new System.Windows.Forms.GroupBox();
            this.BoxAgendamento.SuspendLayout();
            this.BoxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subnet:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelStatus
            // 
            this.LabelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelStatus.Location = new System.Drawing.Point(6, 197);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(55, 16);
            this.LabelStatus.TabIndex = 3;
            this.LabelStatus.Text = "Status:";
            // 
            // BtnScan
            // 
            this.BtnScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnScan.AutoSize = true;
            this.BtnScan.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnScan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnScan.Image = global::Scan.Properties.Resources._1486348532_music_play_pause_control_go_arrow_80458;
            this.BtnScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnScan.Location = new System.Drawing.Point(188, 77);
            this.BtnScan.Name = "BtnScan";
            this.BtnScan.Size = new System.Drawing.Size(133, 52);
            this.BtnScan.TabIndex = 4;
            this.BtnScan.Text = "SCAN SUBNET";
            this.BtnScan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnScan.UseVisualStyleBackColor = true;
            this.BtnScan.Click += new System.EventHandler(this.BtnScan_Click);
            // 
            // PBar
            // 
            this.PBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBar.Location = new System.Drawing.Point(0, 640);
            this.PBar.Name = "PBar";
            this.PBar.Size = new System.Drawing.Size(1119, 51);
            this.PBar.TabIndex = 5;
            // 
            // LblStatus
            // 
            this.LblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblStatus.Location = new System.Drawing.Point(79, 197);
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
            this.ListView1.Location = new System.Drawing.Point(0, 1);
            this.ListView1.Name = "ListView1";
            this.ListView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListView1.Size = new System.Drawing.Size(734, 633);
            this.ListView1.TabIndex = 1;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.ListView1.DoubleClick += new System.EventHandler(this.ListView1_DoubleClick);
            // 
            // ip
            // 
            this.ip.Text = "IP Address";
            this.ip.Width = 180;
            // 
            // host
            // 
            this.host.Text = "Host Name";
            this.host.Width = 250;
            // 
            // stat
            // 
            this.stat.Text = "Status";
            this.stat.Width = 150;
            // 
            // LUp
            // 
            this.LUp.Text = "Last Up";
            this.LUp.Width = 160;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "IP:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BoxAgendamento
            // 
            this.BoxAgendamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxAgendamento.Controls.Add(this.btnAgenda);
            this.BoxAgendamento.Controls.Add(this.rbdiario);
            this.BoxAgendamento.Controls.Add(this.rbMes);
            this.BoxAgendamento.Controls.Add(this.rbSemana);
            this.BoxAgendamento.Font = new System.Drawing.Font("Russo One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoxAgendamento.Location = new System.Drawing.Point(740, 1);
            this.BoxAgendamento.Name = "BoxAgendamento";
            this.BoxAgendamento.Size = new System.Drawing.Size(379, 158);
            this.BoxAgendamento.TabIndex = 0;
            this.BoxAgendamento.TabStop = false;
            this.BoxAgendamento.Text = "Agendamento";
            // 
            // btnAgenda
            // 
            this.btnAgenda.Font = new System.Drawing.Font("Russo One", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgenda.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAgenda.Image = global::Scan.Properties.Resources._1486348532_music_play_pause_control_go_arrow_80458;
            this.btnAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgenda.Location = new System.Drawing.Point(6, 95);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(303, 45);
            this.btnAgenda.TabIndex = 3;
            this.btnAgenda.Text = "Agendar Scan";
            this.btnAgenda.UseVisualStyleBackColor = true;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // rbdiario
            // 
            this.rbdiario.AutoSize = true;
            this.rbdiario.Location = new System.Drawing.Point(6, 20);
            this.rbdiario.Name = "rbdiario";
            this.rbdiario.Size = new System.Drawing.Size(100, 18);
            this.rbdiario.TabIndex = 2;
            this.rbdiario.TabStop = true;
            this.rbdiario.Text = "Diariamente";
            this.rbdiario.UseVisualStyleBackColor = true;
            // 
            // rbMes
            // 
            this.rbMes.AutoSize = true;
            this.rbMes.Location = new System.Drawing.Point(6, 70);
            this.rbMes.Name = "rbMes";
            this.rbMes.Size = new System.Drawing.Size(69, 18);
            this.rbMes.TabIndex = 1;
            this.rbMes.TabStop = true;
            this.rbMes.Text = "Mensal";
            this.rbMes.UseVisualStyleBackColor = true;
            // 
            // rbSemana
            // 
            this.rbSemana.AutoSize = true;
            this.rbSemana.Location = new System.Drawing.Point(6, 45);
            this.rbSemana.Name = "rbSemana";
            this.rbSemana.Size = new System.Drawing.Size(115, 18);
            this.rbSemana.TabIndex = 0;
            this.rbSemana.TabStop = true;
            this.rbSemana.Text = "Semanalmente";
            this.rbSemana.UseVisualStyleBackColor = true;
            // 
            // CkMostraHost
            // 
            this.CkMostraHost.AutoSize = true;
            this.CkMostraHost.Font = new System.Drawing.Font("Russo One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CkMostraHost.Location = new System.Drawing.Point(6, 62);
            this.CkMostraHost.Name = "CkMostraHost";
            this.CkMostraHost.Size = new System.Drawing.Size(116, 18);
            this.CkMostraHost.TabIndex = 10;
            this.CkMostraHost.Text = "Mostrar Hosts";
            this.CkMostraHost.UseVisualStyleBackColor = true;
            this.CkMostraHost.CheckedChanged += new System.EventHandler(this.CkMostraHost_CheckedChanged);
            // 
            // CkDown
            // 
            this.CkDown.AutoSize = true;
            this.CkDown.Font = new System.Drawing.Font("Russo One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CkDown.Location = new System.Drawing.Point(6, 37);
            this.CkDown.Name = "CkDown";
            this.CkDown.Size = new System.Drawing.Size(237, 18);
            this.CkDown.TabIndex = 11;
            this.CkDown.Text = "Mostrar Somente Ip\'s disponíveis";
            this.CkDown.UseVisualStyleBackColor = true;
            this.CkDown.CheckedChanged += new System.EventHandler(this.CkDown_CheckedChanged);
            // 
            // BtnScanIP
            // 
            this.BtnScanIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnScanIP.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnScanIP.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnScanIP.Image = global::Scan.Properties.Resources._1486348532_music_play_pause_control_go_arrow_80458;
            this.BtnScanIP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnScanIP.Location = new System.Drawing.Point(188, 131);
            this.BtnScanIP.Name = "BtnScanIP";
            this.BtnScanIP.Size = new System.Drawing.Size(95, 52);
            this.BtnScanIP.TabIndex = 9;
            this.BtnScanIP.Text = "SCAN IP";
            this.BtnScanIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnScanIP.UseVisualStyleBackColor = true;
            this.BtnScanIP.Click += new System.EventHandler(this.btnScanIP_Click);
            // 
            // TxtSubnet
            // 
            this.TxtSubnet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtSubnet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSubnet.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TxtSubnet.HideSelection = false;
            this.TxtSubnet.Location = new System.Drawing.Point(69, 87);
            this.TxtSubnet.Mask = "##0\\.##0\\.##0\\";
            this.TxtSubnet.Name = "TxtSubnet";
            this.TxtSubnet.RejectInputOnFirstFailure = true;
            this.TxtSubnet.Size = new System.Drawing.Size(103, 29);
            this.TxtSubnet.TabIndex = 12;
            this.TxtSubnet.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected_1);
            this.TxtSubnet.Click += new System.EventHandler(this.maskedTextBox1_Click_1);
            // 
            // TxtIP
            // 
            this.TxtIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtIP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtIP.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TxtIP.Location = new System.Drawing.Point(42, 141);
            this.TxtIP.Mask = "##0\\.##0\\.##0\\.##0\\";
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(140, 29);
            this.TxtIP.TabIndex = 13;
            this.TxtIP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TxtIP_MaskInputRejected);
            this.TxtIP.Click += new System.EventHandler(this.TxtIP_Click);
            // 
            // BoxFiltros
            // 
            this.BoxFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxFiltros.Controls.Add(this.CkDown);
            this.BoxFiltros.Controls.Add(this.BtnScanIP);
            this.BoxFiltros.Controls.Add(this.TxtIP);
            this.BoxFiltros.Controls.Add(this.LblStatus);
            this.BoxFiltros.Controls.Add(this.TxtSubnet);
            this.BoxFiltros.Controls.Add(this.LabelStatus);
            this.BoxFiltros.Controls.Add(this.CkMostraHost);
            this.BoxFiltros.Controls.Add(this.label3);
            this.BoxFiltros.Controls.Add(this.BtnScan);
            this.BoxFiltros.Controls.Add(this.label1);
            this.BoxFiltros.Font = new System.Drawing.Font("Russo One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoxFiltros.Location = new System.Drawing.Point(740, 165);
            this.BoxFiltros.Name = "BoxFiltros";
            this.BoxFiltros.Size = new System.Drawing.Size(379, 469);
            this.BoxFiltros.TabIndex = 15;
            this.BoxFiltros.TabStop = false;
            this.BoxFiltros.Text = "Filtros";
            this.BoxFiltros.Enter += new System.EventHandler(this.BoxFiltros_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1119, 691);
            this.Controls.Add(this.BoxFiltros);
            this.Controls.Add(this.BoxAgendamento);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.PBar);
            this.Name = "Form1";
            this.Text = "Tela Principal de Escaneamento de Subnet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BoxAgendamento.ResumeLayout(false);
            this.BoxAgendamento.PerformLayout();
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
        private System.Windows.Forms.Button BtnScan;
        private System.Windows.Forms.ProgressBar PBar;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox BoxAgendamento;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.RadioButton rbdiario;
        private System.Windows.Forms.RadioButton rbMes;
        private System.Windows.Forms.RadioButton rbSemana;
        private Button BtnScanIP;
        private CheckBox CkMostraHost;
        private CheckBox CkDown;
        private MaskedTextBox TxtSubnet;
        private MaskedTextBox TxtIP;
        private GroupBox BoxFiltros;
        public ColumnHeader ip;
        public ColumnHeader host;
        public ColumnHeader stat;
        public ColumnHeader LUp;
    }
}
