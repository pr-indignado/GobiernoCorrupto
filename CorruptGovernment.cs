using System.Linq;
using System.Collections.Generic;

namespace GobiernoCorrupto {
    public class CorruptGovernment{

        List<CorruptPolitician> CorruptPoliticians {get;}

        public CorruptGovernment(){
            this.CorruptPoliticians = new List<CorruptPolitician>();
        }

        public void AddCorruptPolitician(string Name){
            this.CorruptPoliticians.Add(new CorruptPolitician(Name));
        }

        public void AddCrimes(string crime){
            this.CorruptPoliticians.ElementAt(this.CorruptPoliticians.Count - 1).AddCrime(new Crime(crime));
        }

        public string ToString(Language lang){
            string output = "";
            int counter = 1;
            foreach(CorruptPolitician corruptPolitician in CorruptPoliticians){
                output = string.Concat(output, corruptPolitician.ToString(lang));
                counter++;
            }
            return output;
        }
    }
}