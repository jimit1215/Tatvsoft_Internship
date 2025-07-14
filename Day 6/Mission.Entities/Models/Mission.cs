//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Diagnostics.Metrics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Mission.Entities.Models
//{     
//        public class Mission
//        {
//            [Key]
//            public long MissionId { get; set; }

//            [Required]
//            public string Title { get; set; }

//            [Required]
//            public string Description { get; set; }

//            public int TotalSeats { get; set; }

//            [Required]
//            public DateTime StartDate { get; set; }

//            public DateTime? EndDate { get; set; }

//            // Foreign Keys
//            [ForeignKey("Country")]
//            public int CountryId { get; set; }

//            //public Country Country { get; set; }

//            //[ForeignKey("City")]
//            //public int CityId { get; set; }

//            //public City City { get; set; }

//            //[ForeignKey("Theme")]
//            //public int ThemeId { get; set; }

//            //public MissionTheme Theme { get; set; }

//            //// Images
//            //public ICollection<MissionMedia> MissionMedia { get; set; }

//            //// Skills (Many-to-Many)
//            //public ICollection<MissionSkill> MissionSkills { get; set; }
//        }
//    }


