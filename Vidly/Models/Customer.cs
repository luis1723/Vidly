using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage ="Por Favor Ingresa Un Nombre")]
        [StringLength(255)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        
        public bool IsSubscribedToNewsletter { get; set; }

        
        public MembershipType MembershipType { get; set; }

        [Display(Name = "Tipo De Membresia")]
        public byte MembershipTypeId { get; set; }
        
        [Display(Name="Fecha De Nacimiento")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

    }
}