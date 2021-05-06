using System.ComponentModel.DataAnnotations;

namespace Proyecto_final.Entidades
{
    public class Company
    {
        #region Propiedades Auto Impplementadas
        [Key]
        public int IdCompany { get; set; }
        [Required]
        [StringLength(30)]
        public string NameCompany { get; set; }
        [Required]
        [StringLength(30)]
        public string AdressCompany { get; set; }
        [Required]
        [StringLength(30)]
        public string PostalCodeCompany { get; set; }
        [Required]
        [StringLength(30)]
        public string PhoneNumberCompany { get; set; }
        [Required]
        [StringLength(30)]
        public string WebSiteCompany { get; set; }
        [Required]
        [StringLength(30)]
        public string EmailCompany { get; set; }
        [StringLength(300)]
        public string PhotoCompany { get; set; }
        #endregion

    }
}
