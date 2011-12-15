using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace Armor.Web.Models
{
    [Serializable]
    [JsonObject(MemberSerialization.OptOut)]
    public class OEMedicationMatrix
    {
        public string Acetaminophen { get; set; }
        public string Aspirin { get; set; }
        public string Diclofenac { get; set; }
        public string DiclofenacMisoprostol { get; set; }
        public string Ibuprofen { get; set; }
        public string Indomethacin { get; set; }
        public string Meloxicam { get; set; }
        public string Naproxen { get; set; }
        public string NaproxenEsomeprazole { get; set; }
        public string Celecoxib { get; set; }
        public string AcetaminophenTramadol { get; set; }
        public string Codeine { get; set; }
        public string Tramadol { get; set; }
        public string Other { get; set; }
    }
}