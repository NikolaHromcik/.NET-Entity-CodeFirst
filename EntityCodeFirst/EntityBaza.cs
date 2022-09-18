using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;

namespace EntityCodeFirst
{
    public class EntityBaza : DbContext
    {

        public EntityBaza()
            : base("name=EntityBaza")
        {

        }

        public DbSet<Klijent> Klijents { get; set; }
        public DbSet<Service> Services { get; set; }


    }
    //------------------------------------------------------------------------------------------
    [Table("Klijent", Schema = "dbo")]
    public class Klijent
    {
        public Klijent()
        {
            Servisi = new List<Service>();
        }
        [Key]
        [Required]
        public int KlijentID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Naziv Klijenta je obavezan za unos"), MaxLength(40)]
        public string ImeKlijenta { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Registarski Broj je obavezan za unos"), MaxLength(20)]
        public string RegistarskiBroj { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Kontakt je obavezan za unos"), MaxLength(40)]
        public string Kontakt { get; set; }

        [MaxLength(200)]

        public string DodatniKomentar { get; set; }

        public virtual ICollection<Service> Servisi { get; set; }


    }
    //------------------------------------------------------------------------------------
    [Table("Service", Schema = "dbo")]

    public class Service
    {

        [Key]
        [Required]
        public int ServisID { get; set; }

        [Required]
        [ForeignKey("Klijent")]
        public int KlijentID { get; set; }

        public Service Servisi { get; set; }

        [Required(ErrorMessage = "Datum je Obavezan za unos")]
        [Index(IsUnique = true)]

        public DateTime DatumServisa { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Opis je obavezan za unos"), MaxLength(400)]

        public string OpisUsluge { get; set; }

        public Klijent Klijent { get; set; }
        //public virtual ICollection<Klijent> Klijenti { get; set; }
    }
    //----------------------------------------------------------------------
}