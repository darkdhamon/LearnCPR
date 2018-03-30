using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text.RegularExpressions;

namespace LearnCPR.DataModel.Entities
{
    public class Profile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Url]
        public string PhotoUrl { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("About Me")]
        public string Bio { get; set; }
        [DisplayName("Street Address")]
        public Address StreetAddress { get; set; }

        [DisplayName("Mailing Address")]
        public Address MailingAddress { get; set; }

        [DisplayName("Phone Numbers")]
        public List<PhoneNumber> PhoneNumbers { get; set; }
    }

    public class PhoneNumber
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [Phone]
        public string Number { get; set; }
        [Required]
        public PhoneType PhoneType { get; set; }
    }

    public class PhoneType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string StreetAddr1 { get; set; }
        public string StreetAddr2 { get; set; }
        public string StreetAddr3 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        [RegularExpression("^\\d{5}(?:[-\\s]\\d{4})?$")]
        public string Zip { get; set; }
    }
}
