
namespace Scan {
    partial class Historico {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.ListViewHistorico = new System.Windows.Forms.ListView();
            this.IpAddress = new System.Windows.Forms.ColumnHeader();
            this.Hosts = new System.Windows.Forms.ColumnHeader();
            this.Status = new System.Windows.Forms.ColumnHeader();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListViewHistorico
            // 
            this.ListViewHistorico.AllowDrop = true;
            this.ListViewHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListViewHistorico.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IpAddress,
            this.Hosts,
            this.Status,
            this.Date});
            this.ListViewHistorico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListViewHistorico.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ListViewHistorico.FullRowSelect = true;
            this.ListViewHistorico.GridLines = true;
            this.ListViewHistorico.HideSelection = false;
            this.ListViewHistorico.Location = new System.Drawing.Point(1, 63);
            this.ListViewHistorico.Name = "ListViewHistorico";
            this.ListViewHistorico.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListViewHistorico.Size = new System.Drawing.Size(788, 503);
            this.ListViewHistorico.TabIndex = 2;
            this.ListViewHistorico.UseCompatibleStateImageBehavior = false;
            this.ListViewHistorico.View = System.Windows.Forms.View.Details;
            this.ListViewHistorico.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewHistorico_ColumnClick);
            this.ListViewHistorico.SelectedIndexChanged += new System.EventHandler(this.ListViewHistorico_SelectedIndexChanged);
            this.ListViewHistorico.Enter += new System.EventHandler(this.Historico_Load);
            // 
            // IpAddress
            // 
            this.IpAddress.Text = "IP Address";
            this.IpAddress.Width = 200;
            // 
            // Hosts
            // 
            this.Hosts.Text = "Host";
            this.Hosts.Width = 200;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 120;
            // 
            // Date
            // 
            this.Date.Text = "Data";
            this.Date.Width = 250;
            // 
            // Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 574);
            this.Controls.Add(this.ListViewHistorico);
            this.Name = "Historico";
            this.Text = "HISTORICO DE IP\'S";
            this.Load += new System.EventHandler(this.Historico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListViewHistorico;
        private System.Windows.Forms.BindingSource bindingSource1;
        public System.Windows.Forms.ColumnHeader IpAddress;
        public System.Windows.Forms.ColumnHeader Hosts;
        public System.Windows.Forms.ColumnHeader Status;
        public System.Windows.Forms.ColumnHeader Date;
    }
}