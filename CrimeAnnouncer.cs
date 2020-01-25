using System;

namespace GobiernoCorrupto {
    public class CrimeAnnouncer{
        public static void Main(string[] args){

            // El gobierno corrupto de Puerto Rico
            CorruptGovernment corruptGovernment = new CorruptGovernment();

            // Someone add here the names and the crimes of corrupt politicians.
            // Añadan aquí los a los politicos corruptos con sus respectivos crimenes.
            // Ejemplo:
            corruptGovernment.AddCorruptPolitician("Thomas Rivera Schatz");
            corruptGovernment.AddCrimes("Insultar y tildar de brutos a los que ayudaron en el sur.");

            // Repeat for the remaining corrupt politicians.
            // Repetir para otros politicos corruptos.
            corruptGovernment.AddCorruptPolitician("Wanda Vázquez");
            corruptGovernment.AddCrimes("Mentir acerca del conocimiento de los almacenes con ayudas aguantadas desde el huracán María.");
            corruptGovernment.AddCrimes("No investigar a Ricardo Roselló.");
            // etc, etc.

            // Sigan el patrón!

            // Al final, vemos el resultado aqui...
            // Si escribieron los crimenes en ingles, entonces dentro del ToString() escriban Language.English
            Console.WriteLine(corruptGovernment.ToString(Language.Spanish));

        }
    }
}