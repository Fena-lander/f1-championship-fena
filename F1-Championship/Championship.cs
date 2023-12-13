using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace F1_Championship
{
    public class Championship
    {
        public string ChampionshipName{ get; set; }
        public List<Pilot> Pilots { get; set; }

        public Championship()
        {
            Pilots = new List<Pilot>();
        }

        public string JsonSerialize(Championship championship)
        {
            return JsonConvert.SerializeObject(championship);
        }

        public static Championship Deserialize(string json) 
        { 
            return JsonConvert.DeserializeObject<Championship>(json);
        }
    }
}
