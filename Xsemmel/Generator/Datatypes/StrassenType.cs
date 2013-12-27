using System;
using System.IO;
using System.Security;

namespace XSemmel.Generator.Datatypes
{

    /**
     * H�ufige Stra�ennamen
     * @author Frank Schnitzer
     */
    public class StrassenType : DataType {


	    private String[] BASE =
			    {
			    "Hauptstra�e", "Dorfstra�e", "Schulstra�e", "Bahnhofstra�e", "Gartenstra�e",
			    "Bergstra�e", "Lindenstra�e", "Birkenweg", "Waldstra�e", "Kirchstra�e",
			    "Ringstra�e",
			    "Wiesenweg", "Schillerstra�e", "Goethestra�e", "M�hlenweg", "Amselweg",
			    "Feldstra�e",
			    "Wiesenstra�e", "Jahnstra�e", "Am Aportplatz", "Buchenweg", "Friedhofstra�e",
			    "Eichenweg", "Finkenweg", "Ahornweg", "M�hlenstra�e", "Rosenstra�e",
			    "Talstra�e",
			    "Erlenweg", "Blumenstra�e", "Brunnenstra�e", "Kirchweg", "Lindenweg",
			    "Raiffeisenstra�e", "Bachstra�e", "Industriestra�e", "Tannenweg",
			    "Mittelstra�e",
			    "Gartenweg", "Rosenweg", "Nozartstra�e", "Am Bahnhof", "Lerchenweg",
			    "Waldweg",
			    "Drosselweg", "Poststra�e", "Schlossstra�e", "Neue Stra�e", "M�hlweg",
			    "Kirchplatz",
			    "Beethovenstra�e", "Kirchgasse", "Burgstra�e", "Schulweg",
			    "Breslauer Stra�e",
			    "Im Winkel", "Birkenstra�e", "Meisenweg", "Lessingstra�e", "Fliederweg",
			    "Kiefernweg",
			    "Gr�ner Weg", "K�nigsberger Stra�e", "Berliner Stra�e", "Fasanenweg",
			    "Parkstra�e",
			    "Uhlandstra�e", "Sch�tzenstra�e", "R�merstra�e", "Kapellenweg",
			    "Kastanienweg",
			    "Narktplatz", "Danziger stra�e", "Tulpenweg", "Heideweg", "Mittelweg"
			    };

	    public static DataType constructOf(String s) {
		    if ("STRASSEN".Equals(s)) {
			    return new StrassenType();
		    }
		    return null;
	    }

	    public override void write(TextWriter w) {
		    String s = Random.oneOf(BASE);
		    s = SecurityElement.Escape(s);
		    w.Write(s);
	    }
    }
}