using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final.Entidades
{
    public class Major
    {
        #region Propiedades Auto Impplementadas
        [Key]
        public int IdMajor { get; set; }
        [Required]
        [StringLength(30)]
        public string NameMajor { get; set; }
        [Required]
        [StringLength(30)]
        public string PhoneNumberMajor { get; set; }
        [Required]
        [StringLength(30)]
        public string CellphoneNumberMajor { get; set; }
        [Required]
        [StringLength(300)]
        public string PhotoMajor { get; set; }
        [Required]
        [StringLength(30)]
        public string EmailMajor { get; set; }
        [StringLength(30)]
        public string DescriptionMajor { get; set; }
        #endregion
    }
}
