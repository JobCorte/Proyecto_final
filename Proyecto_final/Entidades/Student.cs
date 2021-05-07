using System;
using System.ComponentModel.DataAnnotations;

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
        public string Fullname { get { return $"{FirstName} {LastName}"; } }

        public static implicit operator Student(Coordinator v)
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}
