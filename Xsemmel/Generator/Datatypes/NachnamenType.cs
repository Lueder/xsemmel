using System;
using System.IO;
using System.Security;

namespace XSemmel.Generator.Datatypes
{


    /**
     * H�ufige Nachnamen
     * @author Frank Schnitzer
     */
    public class NachnamenType : DataType
    {


        private String[] BASE =
			{
			"M�ller", "Schmidt", "Schneider", "Fischer", "Weber", "Meyer", "Wagner",
			"Becker",
			"Schulz", "Hoffmann", "Sch�fer", "Bauer", "Koch", "Richter", "Klein", "Wolf",
			"Schr�der", "Neumann", "Schwarz", "Braun", "Hofmann", "Zimmermann",
			"Schmitt",
			"Hartmann", "Kr�ger", "Schmid", "Werner", "Lange", "Schmitz", "Meier",
			"Krause",
			"Maier", "Lehmann", "Huber", "Mayer", "Herrmann", "K�hler", "Walter",
			"K�nig",
			"Schulze", "Fuchs", "Kaiser", "Lang", "Wei�", "Peters", "Scholz", "Jung",
			"M�ller",
			"Hahn", "Keller", "Vogel", "Schubert", "Roth", "Frank", "Friedrich", "Beck",
			"G�nther",
			"Berger", "Lorenz", "Baumann", "Schuster", "Kraus", "B�hm", "Simon",
			"Franke",
			"Albrecht", "Winter", "Ludwig", "Martin", "Kr�mer", "Schumacher", "Vogt",
			"J�ger",
			"Stein", "Otto", "Gro�", "Sommer", "Haas", "Graf", "Heinrich", "Seidel",
			"Schreiber",
			"Ziegler", "Brandt", "Kuhn", "Schulte", "Dietrich", "K�hn", "Engel", "Pohl",
			"Horn",
			"Sauer", "Arnold", "Thomas", "Bergmann", "Busch", "Pfeiffer", "Voigt",
			"G�tz",
			"Seifert", "Lindner", "Ernst", "H�bner", "Kramer", "Franz", "Beyer", "Wolff",
			"Peter",
			"Jansen", "Kern", "Barth", "Wenzel", "Hermann", "Ott", "Paul", "Riedel",
			"Wilhelm",
			"Hansen", "Nagel", "Grimm", "Lenz", "Ritter", "Bock", "Langer", "Kaufmann",
			"Mohr",
			"F�rster", "Zimmer", "Haase", "Lutz", "Kruse", "Jahn", "Schumann", "Fiedler",
			"Thiel",
			"Hoppe", "Kraft", "Michel", "Marx", "Fritz", "Arndt", "Eckert", "Sch�tz",
			"Walther",
			"Petersen", "Berg", "Schindler", "Kunz", "Reuter"
			};

        public static DataType constructOf(String s)
        {
            if ("NACHNAMEN".Equals(s))
            {
                return new NachnamenType();
            }
            return null;
        }

        public override void write(TextWriter w)
        {
            String s = Random.oneOf(BASE);
            s = SecurityElement.Escape(s);
            w.Write(s);
        }
    }
}