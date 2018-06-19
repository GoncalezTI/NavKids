using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;
using CefSharp;
using CefSharp.WinForms.Internals;

namespace NavKids
{
    public partial class NavControl : UserControl
    {
        ChromiumWebBrowser chromium;
        string ultimoSite = "";

        public NavControl()
        {
            InitializeComponent();
            InitializeChromium();
            ChromiumPanel.Controls.Add(chromium);
        }

        private void InitializeChromium()
        {
            chromium = new ChromiumWebBrowser("http://google.com")
            {
                Dock = DockStyle.Fill
            };

            chromium.LoadingStateChanged += Chromium_LoadingStateChanged;
        }

        private void Chromium_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            this.InvokeOnUiThreadIfRequired(SetTbEndereco);
        }

        public void SetTbEndereco() {
            bool aux = false;
            Uri uriaux = new Uri(chromium.Address);

            if (chromium.IsLoading) {
                //tbEndereco.Text = uriaux.ToString();

                tbEndereco.Text = uriaux.ToString();

                if (!CGlobalStatica.usuarioGlobal.Administrador) {
                    foreach (CSitePermitido item in CGlobalStatica.usuarioGlobal.SitesPermitidos) {

                        //MessageBox.Show(chromium.Address + ":: Chrome Address");
                        //MessageBox.Show(uriaux.Host.ToString() + ":: Uri Host");
                        if (uriaux.Host.ToString().Contains(item.site)) {
                            aux = true;
                        }
                    }
                    if (!aux && uriaux.ToString() != "www.google.com/erro") {
                        chromium.Load("www.google.com/erro");
                        chromium.Stop();
                    }
                }
                if (ultimoSite != uriaux.ToString()) {
                    DbClass.SetHist(CGlobalStatica.usuarioGlobal.Id, uriaux.ToString(), DateTime.Now);
                    ultimoSite = uriaux.ToString();
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (chromium.CanGoBack)
            {
                chromium.Back();
            }
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (chromium.CanGoForward)
            {
                chromium.Forward();
            }
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            chromium.Load(tbEndereco.Text);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            chromium.Load("google.com");
        }

        private void tbEndereco_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Return) {
                //MessageBox.Show("Enter pressed");
                chromium.Load(tbEndereco.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }

    
}
