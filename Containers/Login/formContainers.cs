using BL.Containers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class formContainers : Form
    {
        ContainersBL _containers;

        public formContainers()
        {
            InitializeComponent();

            _containers = new ContainersBL();
            listaContainersBindingSource.DataSource = _containers.ObtenerContainers();
        }
    }
}
