using System.Linq;
using System.Collections.Generic;

namespace GobiernoCorrupto {
    public class CorruptPolitician{

        public string Name {get; set;}
        public List<Crime> Crimes {get; set;}

        public CorruptPolitician(string Name){
            this.Name = Name;
            this.Crimes = new List<Crime>();
        }

        public void AddCrime(Crime crime){
            this.Crimes.Add(crime);
        }

        public string ToString(Language lang){

            //this.Crimes.Sort(new SeverityComparer());
            string output;

            if (lang.Equals(Language.English)){
                output = string.Concat(Name, ", you are a corrupt politician!\nThese are your crimes against the people of Puerto Rico:");
            } else {
                output = string.Concat(Name, ", ¡usted es un políticx corruptx!\nEstos son tus crimenes en contra del pueblo de Puerto Rico:");
            }
            int counter = 1;
            foreach(Crime crime in Crimes){
                output = string.Concat(output, "\n\t", counter, ") ", crime.ToString());
                counter++;
            }

            return string.Concat(output, "\n\n");
        }
    }
}