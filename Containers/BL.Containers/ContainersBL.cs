using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Containers
{
    public class ContainersBL
    {
        public BindingList<Container> ListaContainers { get; set; }

        public ContainersBL()
        {
            ListaContainers = new BindingList<Container>();

            var container1 = new Container();
            container1.Id = 1;
            container1.NumeroSerie = "123QRS";
            container1.MasaBrutaMaxima = "15000 Kilogramos";
            container1.PesoNeto = "20000 Kilogramo";
            container1.AvisoAltura = "5 Metros";
            container1.VolumenInterno = "4 metros";
            container1.Activo = true;

            var container2 = new Container();
            container2.Id = 2;
            container2.NumeroSerie = "125RJY";
            container2.MasaBrutaMaxima = "16000 Kilogramos";
            container2.PesoNeto = "21000 Kilogramo";
            container2.AvisoAltura = "5 Metros";
            container2.VolumenInterno = "4 metros";
            container2.Activo = true;

            ListaContainers.Add(container1);
            ListaContainers.Add(container2);

        }

        public BindingList<Container> ObtenerContainers()
        {
            return ListaContainers;
        }
    }

    public class Container
    {
        public int Id { get; set; }
        public string NumeroSerie { get; set; }
        public string MasaBrutaMaxima { get; set; }
        public string PesoNeto{ get; set; }
        public string AvisoAltura { get; set; }
        public string VolumenInterno { get; set; }
        public bool Activo { get; set; }
    }
}
