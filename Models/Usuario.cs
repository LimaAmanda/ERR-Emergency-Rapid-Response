using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProjetoErr.Models
{
    public class Usuario
    {      
        
        //Atalho para propridade (PROP + TAB)
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        
        public byte[] Foto { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime? DataAcesso { get; set; } //using System;

        [NotMapped] // using System.ComponentModel.DataAnnotations.Schema
        public string PasswordString { get; set; }
        
       /* [NotMapped]
        public List<Veiculo> veiculos { get; set; }*///using System.Collections.Generic;

        
    }
}