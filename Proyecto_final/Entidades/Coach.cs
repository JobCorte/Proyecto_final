using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final.Entidades
{
    public class Coach
    {
        #region propiedades autoimplementadas
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        [StringLength(250)]
        public string Photo { get; set; }
        public string CellphoneNumber { get; set; }
        public string Email { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        #endregion
    }
}
