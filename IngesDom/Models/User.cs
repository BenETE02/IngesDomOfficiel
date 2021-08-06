using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IngesDom.Models
{
    public enum SexeEmum { Masculin, Feminin}
    public class User
    {
        public int UserID { get; set; }

        [MaxLength(30), Required]
        public string Name { get; set; }

        [MaxLength(60)]
        public string Firstname { get; set; }

        [MaxLength(50), Required]
        public string Email { get; set; }

        public SexeEmum Sexe { get; set; }

    }
}
