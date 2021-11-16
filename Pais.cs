using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Agencia_de_viajes
{
    public class Pais
    {
        public int Paises { get; set; }
        public DataTable ListaPaises = new DataTable();

        public Pais()
        {
            ListaPaises.TableName = "Paises";
            ListaPaises.Columns.Add("Destinos", typeof(string));
            
            if (!System.IO.File.Exists("Lista.xml"))
            {
                ListaPaises.WriteXml("Lista.xml");
            }
            ListaPaises.ReadXml("Lista.xml");
        }

        public void GuardarPais(string Pais)
        {
            ListaPaises.Rows.Add();
            ListaPaises.Rows[ListaPaises.Rows.Count - 1]["Destinos"] = Pais;
            ListaPaises.WriteXml("Lista.xml");
        }
    }
}
