using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CombatClientSocketNaIn.Classes;


namespace CombatClientSocketNaIn
{
    public partial class frmClienSocketNain : Form
    {
        Random m_r;
        Elfe m_elfe;
        Nain m_nain;
        public frmClienSocketNain()
        {
            InitializeComponent();
            m_r = new Random();

            Reset();
            btnReset.Enabled = false;
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        void Reset()
        {
            m_nain = new Nain(m_r.Next(10, 20), m_r.Next(2, 6), m_r.Next(0, 3));
            picNain.Image = m_nain.Avatar;
            lblVieNain.Text = "Vie: " + m_nain.Vie.ToString(); ;
            lblForceNain.Text = "Force: " + m_nain.Force.ToString();
            lblArmeNain.Text = "Arme: " + m_nain.Arme;

            m_elfe = new Elfe(1, 0, 0);
            picElfe.Image = m_elfe.Avatar;
            lblVieElfe.Text = "Vie: " + m_elfe.Vie.ToString();
            lblForceElfe.Text = "Force: " + m_elfe.Force.ToString();
            lblSortElfe.Text = "Sort: " + m_elfe.Sort.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnFrappe.Enabled = true;
            Reset();
        }

        private void btnFrappe_Click(object sender, EventArgs e)
        {
            Socket Client;
            int nbOctetReception;
            byte[] tByteReception = new byte[100];
            ASCIIEncoding textByte = new ASCIIEncoding();

            try
            {

                Client = new Socket(SocketType.Stream, ProtocolType.Tcp);
                Client.Connect(IPAddress.Parse("127.0.0.1"), 8888);
                MessageBox.Show("assurez-vous que le serveur est démarré et en attante d'un client");

                if (Client.Connected)
                {
                    
                    string str = m_nain.Vie + ";" + m_nain.Force + ";" + m_nain.Arme + ";";


                    byte[] tByteEnvoie = textByte.GetBytes(str);

                    //transmission
                    Client.Send(tByteEnvoie);
                    Thread.Sleep(500);

                    //reception

                    nbOctetReception = Client.Receive(tByteReception);

                    string reponse = Encoding.ASCII.GetString(tByteReception);

                    string[] ts = reponse.Split(';','|');
                    m_nain.Vie = Convert.ToInt32(ts[0]);
                    m_nain.Force = Convert.ToInt32(ts[1]);
                    m_nain.Arme = ts[2];
                    m_elfe.Vie = Convert.ToInt32(ts[3]);
                    m_elfe.Force = Convert.ToInt32(ts[4]);
                    m_elfe.Sort = Convert.ToInt32(ts[5]);

                    lblVieNain.Text = "Vie: " + m_nain.Vie.ToString(); ;
                    lblForceNain.Text = "Force: " + m_nain.Force.ToString();
                    lblArmeNain.Text = "Arme: " + m_nain.Arme;

                    lblVieElfe.Text = "Vie: " + m_elfe.Vie.ToString();
                    lblForceElfe.Text = "Force: " + m_elfe.Force.ToString();
                    lblSortElfe.Text = "Sort: " + m_elfe.Sort.ToString();

                    //gagnant

                    if (m_elfe.Vie <= 0 & m_nain.Vie > 0)
                    {
                        PbGagnant.Image = m_nain.Avatar;
                        MessageBox.Show("Le nain a gagné!");
                        btnReset.Enabled = true;
                    }
                    else if (m_nain.Vie <= 0 & m_elfe.Vie > 0)
                    {
                        PbGagnant.Image = m_elfe.Avatar;
                        MessageBox.Show("L'elfe a gagné!");
                        btnReset.Enabled = true;
                    }
                    else if (m_elfe.Vie <= 0 & m_nain.Vie <= 0)
                    {
                        MessageBox.Show("égalité");
                        btnReset.Enabled = true;
                    }

                    Client.Close();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnFrappe.Enabled = true;
        }
    }
}
