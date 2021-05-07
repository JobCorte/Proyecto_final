using System.ComponentModel.DataAnnotations;

namespace Proyecto_final.Entidades
{
    public class Contact
    {
        #region Propiedades Auto Impplementadas
        [Key]
        public int IdContact { get; set; }
        [Required]
        [StringLength(30)]
        public string FirstNameContact { get; set; }
        [Required]
        [StringLength(30)]
        public string LastNameContact { get; set; }
        [Required]
        [StringLength(30)]
        public string PhoneNumberContact { get; set; }
        [Required]
        [StringLength(30)]
        public string CellphoneContact { get; set; }
        [Required]
        [StringLength(300)]
        public string PhotoContact { get; set; }
        [Required]
        [StringLength(30)]
        public string EmailContact { get; set; }
        [StringLength(30)]
        public string DepartmentContact { get; set; }
        public string FullnameContact { get { return $"{FirstNameContact} {LastNameContact}"; } }
        #endregion
    }
}
