using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavKids
{
    public partial class HistControl : UserControl
    {
        public int id_usuario, id_hist;
        public string site, hora;
        public DateTime data;

        public CHistorico historico { get; private set; }

        public HistControl()
        {
            InitializeComponent();

            lblData.MouseHover += HistControl_MouseHover;
            lblDataHeader.MouseHover += HistControl_MouseHover;
            lblHora.MouseHover += HistControl_MouseHover;
            lblHoraHeader.MouseHover += HistControl_MouseHover;
            lblSite.MouseHover += HistControl_MouseHover;
            lblSiteHeader.MouseHover += HistControl_MouseHover;

        }

        public HistControl(CHistorico historico) {
            InitializeComponent();

            this.historico = historico;

            lblSite.Text = historico.Site;
            lblHora.Text = historico.Hora;
            lblData.Text = historico.Data;
            btnDelHist.Tag = historico.Id_Site;

            lblData.MouseHover += HistControl_MouseHover;
            lblDataHeader.MouseHover += HistControl_MouseHover;
            lblHora.MouseHover += HistControl_MouseHover;
            lblHoraHeader.MouseHover += HistControl_MouseHover;
            lblSite.MouseHover += HistControl_MouseHover;
            lblSiteHeader.MouseHover += HistControl_MouseHover;

        }

        public HistControl(int id_usuario,int id_hist ,string site, string hora, DateTime data)
        {
            InitializeComponent();

            this.id_usuario = id_usuario;
            this.id_hist = id_hist;
            this.site = site;
            this.hora = hora;
            this.data = data;

            lblSite.Text = site;
            lblHora.Text = hora;
            lblData.Text = data.ToShortDateString();
            btnDelHist.Tag = id_hist;
        }

        private void HistControl_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.WhiteSmoke;
        }

        private void HistControl_SizeChanged(object sender, EventArgs e) {
            if (this.Size.Width > 603) {
                panel3.Controls.Add(panel1);
                panel3.Controls.Add(panel2);
                panel3.Controls.Add(btnDelHist);
                panel4.Height = 0;
                //this.Height = 38;
            }
            else {
                panel4.Controls.Add(panel1);
                panel4.Controls.Add(panel2);
                panel4.Controls.Add(btnDelHist);
                panel4.Height = 40;
            }
        }

        private void HistControl_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void btnDelHist_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(((Button)sender).Tag.ToString());
            if (historico.DeletarHistorico()) {
                btnDelHist.Tag = true;
                MessageBox.Show("Entrada de historico excluida com sucesso!");
            }
        }
    }
}
