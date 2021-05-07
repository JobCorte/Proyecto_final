using System.ComponentModel.DataAnnotations;

namespace Proyecto_final.Entidades
{
    public class Coordinator
    {
        #region Propiedades Auto Impplementadas
        [Key]
        public int IdCoordinator { get; set; }
        [Required]
        [StringLength(30)]
        public string FirstNameCoordinator { get; set; }
        [Required]
        [StringLength(30)]
        public string LastNameCoordinator { get; set; }
        [StringLength(20)]
        public string CellPhoneNumberCoordinator { get; set; }
        [StringLength(30)]
        public string EmailCoordinator { get; set; }
        [StringLength(300)]
        public string PhotoCoordinator { get; set; }
        [StringLength(30)]
        public string DescriptionCoordinator { get; set; }
        #endregion
    }
}
