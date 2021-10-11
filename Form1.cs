using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Globalization;
using System.Data.SqlClient;

namespace Scan {
    public partial class Form1 : MetroFramework.Forms.MetroForm {

        public Form1() {
            InitializeComponent();
        }




        private void label1_Click(object sender, EventArgs e) {

        }

        public void BtnScan_Click(object sender, EventArgs e) {


            //Instancia Variaveis
            string subnet = TxtSubnet.Text;
            PBar.Maximum = 254;
            PBar.Value = 0;
            ListView1.Items.Clear();



            //Laço buscando ip's da SUBNET e retornando no ListView

            for (int i = 1; i <= PBar.Maximum; i++) {
                PBar.Value += 1;
                //Application.DoEvents();
                string ip = $"{subnet}.{i}";
                
                Ping ping = new Ping();
                PingReply reply = ping.Send(ip, 100);

                if (reply.Status == IPStatus.Success) {
                    if (!CkDown.Checked) {
                        if (CkMostraHost.Checked) {
                            try {
                                IPHostEntry host = Dns.GetHostEntry(IPAddress.Parse(ip));
                                ListView1.Items.Add(new ListViewItem(new String[] { ip, host.HostName, "Up", DateTime.Now.ToString() }));
                                Cadastro cad = new Cadastro(ip, host.HostName, "Up", LUp.ToString());
                            }
                            catch {
                                ListView1.Items.Add(new ListViewItem(new String[] { ip, ip.ToString(), "Up", DateTime.Now.ToString() })); //    MessageBox.Show($"Couldn't retrieve hostname from {ip}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Cadastro cad = new Cadastro(ip, ip.ToString(), "Up", DateTime.Now.ToString());
                            }

                        }
                        else {
                            ListView1.Items.Add(new ListViewItem(new String[] { ip, ip.ToString(), "Up", DateTime.Now.ToString() }));
                            Cadastro cad = new Cadastro(ip.ToString(), ip.ToString(), "Up", DateTime.Now.ToString());
                        }


                        LblStatus.ForeColor = Color.Blue;
                        LblStatus.Text = $"Escaneando: {ip}";
                        if (PBar.Value == PBar.Maximum)
                            LblStatus.Text = "Finalizado";

                    }
                }
                else {
                    try {
                        LblStatus.ForeColor = Color.DarkGray;
                        LblStatus.Text = $"Escaneando: {ip}";
                        ListView1.Items.Add(new ListViewItem(new String[] { ip, ip.ToString(), "Down", DateTime.Now.ToString() }));
                        Cadastro cad = new Cadastro(ip.ToString(), ip.ToString(), "Down", DateTime.Now.ToString());
                        if (PBar.Value == PBar.Maximum) {

                            LblStatus.Text = "Finalizado";
                            PBar.Value = 0;
                            TxtSubnet.Clear();
                        }
                    }
                    catch {

                    }





                }
                Application.DoEvents();
                //Comando para o cursor descer junto com os itens do ListView
                // var items = ListView1.Items;
                // var last = items[items.Count];
                //last.EnsureVisible();
            }


            MessageBox.Show("Processo finalizado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // }));
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void btnAgenda_Click(object sender, EventArgs e) {


        }

        private void btnScanIP_Click(object sender, EventArgs e) {
            
            //Instancia Variaveis
            string ips = TxtIP.Text;
            PBar.Maximum = 1;
            PBar.Value = 0;
            ListView1.Items.Clear();






            for (int i = 0; i < 1; i++) {
                string ip = $"{ips}";

                
                Ping ping = new Ping();
                PingReply reply = ping.Send(ip, 100);
                if (reply.Status == IPStatus.Success) {

                    try {
                        IPHostEntry host = Dns.GetHostEntry(IPAddress.Parse(ip));
                        ListView1.Items.Add(new ListViewItem(new String[] { ip, host.HostName, "Up", DateTime.Now.ToString() }));
                        Cadastro cad = new Cadastro(ip.ToString(), host.HostName, "Up", DateTime.Now.ToString());
                    }
                    catch {
                        // MessageBox.Show($"Couldn't retrieve hostname from {ip}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    PBar.Value += 1;
                    LblStatus.ForeColor = Color.Blue;
                    LblStatus.Text = $"Scanning: {ip}";
                    if (PBar.Value == 3)
                        LblStatus.Text = "Finished";

                }
                else {

                    PBar.Value += 1;
                    LblStatus.ForeColor = Color.DarkGray;
                    LblStatus.Text = $"Scanning: {ip}";
                    ListView1.Items.Add(new ListViewItem(new String[] { ip.ToString(), ip.ToString(), "Down", DateTime.Now.ToString() }));
                    Cadastro cad = new Cadastro(ip.ToString(), ip.ToString(), "Down", DateTime.Now.ToString());
                    if (PBar.Value == 3)
                        LblStatus.Text = "Finished";

                }
            }












        }

        private void CkDown_CheckedChanged(object sender, EventArgs e) {
            if (CkDown.Checked) {
                CkMostraHost.Checked = false;
                CkMostraHost.Enabled = false;
            }
            else {
                CkMostraHost.Enabled = true;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {

        }

        private void maskedTextBox1_Click(object sender, EventArgs e) {

        }

        private void maskedTextBox1_Click_1(object sender, EventArgs e) {
            //Comando para iniciar o Focus na esquerda
            TxtSubnet.Select(0, 0);
            TxtSubnet.ValidatingType = typeof(System.Net.IPAddress);
        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e) {

        }

        private void TxtIP_TextChanged(object sender, EventArgs e) {

        }

        private void BtnSalvar_Click(object sender, EventArgs e) {


        }

        private void TxtIP_Click(object sender, EventArgs e) {
            //Comando para iniciar o Focus na esquerda
            TxtIP.Select(0, 0);
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void TxtIP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {

        }

        private void BoxFiltros_Enter(object sender, EventArgs e) {

        }

        private void ListView1_DoubleClick(object sender, EventArgs e) {
            var myHistorico = new Historico();
            Program.ipgrid = ListView1.SelectedItems[0].SubItems[0].Text;


            myHistorico.Show();






        }

        private void CkMostraHost_CheckedChanged(object sender, EventArgs e) {

        }

        private void txtPesquisa_Enter(object sender, EventArgs e) {


        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e) {
            if (txtPesquisa.Text != "")
            {
                for (int i = ListView1.Items.Count - 1; i >= 0; i--)
                {
                    var item = ListView1.Items[i];
                    if (item.Text.ToLower().Contains(txtPesquisa.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                    else
                    {
                        ListView1.Items.Remove(item);
                    }
                }


            
        }
            
           } 

        private void txtPesquisa_Leave(object sender, EventArgs e) {
            

          


        }

        private void objectListView2_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void fastObjectListView1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void Form1_QueryAccessibilityHelp(object sender, QueryAccessibilityHelpEventArgs e)
        {

        }

        private void PBar_Click(object sender, EventArgs e)
        {
           
        }

        private void PBar_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnScan_Click_1(object sender, EventArgs e)
        {

        }
    }
    }
    




