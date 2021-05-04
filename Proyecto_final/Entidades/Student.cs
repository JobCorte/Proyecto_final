using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final.Entidades
{
    public class Student
    {
        #region Propiedades Auto Implementadas 
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        [Required]
        [StringLength(30)]
        public string birthdate { get; set; }
        [Required]
        [StringLength(30)]
        public string phonenumber { get; set; }
        [Required]
        [StringLength(30)]
        public string cellphonenumber { get; set; }
        [Required]
        [StringLength(30)]
        public string email { get; set; }
        [StringLength(300)]
        public string Photo { get; set; }
        public string Fullname { get; }
        #endregion


    }
}
