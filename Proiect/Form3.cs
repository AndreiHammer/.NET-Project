using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form3 : Form
    {
        public Form3(List<Inchiriere> listaInchirieri)
        {
            InitializeComponent();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = listaInchirieri;
            bindingNavigator1.BindingSource = bindingSource;
            tbId.DataBindings.Add(new Binding("Text", bindingSource, "Id", true));
            tbClient.DataBindings.Add(new Binding("Text", bindingSource, "ClientInfo", true));
            tbFilme.DataBindings.Add(new Binding("Text", bindingSource, "FilmeInfo", true));
            tbTotalPlata.DataBindings.Add(new Binding("Text", bindingSource, "TotalPlata", true, DataSourceUpdateMode.OnPropertyChanged, 0, "C2") { FormattingEnabled = true });
        }

    }
}
