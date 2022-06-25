using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoErr.Models
{
    public class Evento
    {
        public int Id { get; set; }        
        public int IdVeiculo { get; set; }
        public int IdUsuario { get; set; }
        public string Descricao { get; set; }
        public string Latitude { get; set; }
        public string Longitute { get; set; }
        public string Endereco { get; set; }

        //Aqui será o lugar que será guardado eventos do USUARIO e VEICULOS.        

        //Descricao - string
        //Latitude - string
        //Longitute - string
        //Endereço - string

        
        
    }
}