using System;
using System.IO;
using System.Security;

namespace XSemmel.Generator.Datatypes
{


    /**
     * Die Staaten der Welt
     * @author Frank Schnitzer
     */
    public class StaatenType : DataType
    {


        private String[] BASE =
			{
			"Abchasien", "Afghanistan", "Agypten �gypten", "Albanien", "Algerien",
			"Andorra",
			"Angola", "Antigua und Barbuda", "Aquatorialguinea �quatorialguinea",
			"Argentinien",
			"Armenien", "Aserbaidschan", "Athiopien �thiopien", "Australien", "Bahamas",
			"Bahrain",
			"Bangladesch", "Barbados", "Belgien", "Belize", "Benin", "Bergkarabach",
			"Bhutan",
			"Bolivien", "Bosnien und Herzegowina", "Botsuana", "Brasilien", "Brunei",
			"Bulgarien",
			"Burkina Faso", "Burundi", "Chile", "China", "Cookinseln", "Costa Rica",
			"Danemark D�nemark", "Deutschland", "Dominica", "Dominikanische Republik",
			"Dschibuti",
			"Ecuador", "El Salvador", "Elfenbeink�ste", "Eritrea", "Estland", "Fidschi",
			"Finnland", "Frankreich", "Gabun", "Gambia", "Georgien", "Ghana", "Grenada",
			"Griechenland", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti",
			"Honduras",
			"Indien", "Indonesien", "Irak", "Iran", "Irland", "Island", "Israel",
			"Italien",
			"Jamaika", "Japan", "Jemen", "Jordanien", "Kambodscha", "Kamerun", "Kanada",
			"Kap Verde", "Kasachstan", "Katar", "Kenia", "Kirgisistan", "Kiribati",
			"Kolumbien",
			"Komoren", "Kongo", "Nord Korea", "S�d Korea", "Kosovo", "Kroatien", "Kuba",
			"Kuwait",
			"Laos", "Lesotho", "Lettland", "Libanon", "Liberia", "Libyen",
			"Liechtenstein",
			"Litauen", "Luxemburg", "Madagaskar", "Malawi", "Malaysia", "Malediven",
			"Mali",
			"Malta", "Marokko", "Marshallinseln", "Mauretanien", "Mauritius",
			"Mazedonien",
			"Mexiko", "Mikronesien", "Moldawien", "Monaco", "Mongolei", "Montenegro",
			"Mosambik",
			"Myanmar", "Namibia", "Nauru", "Nepal", "Neuseeland", "Nicaragua",
			"Niederlande",
			"Niger", "Nigeria", "Niue", "Nordzypern Nordzypern", "Norwegen", "Oman",
			"Osterreich �sterreich", "Osttimor", "Pakistan", "Palastina Pal�stina",
			"Palau",
			"Panama", "Papua-Neuguinea", "Paraguay", "Peru", "Philippinen", "Polen",
			"Portugal",
			"Ruanda", "Rumanien Rum�nien", "Russland", "Salomonen", "Sambia", "Samoa",
			"San Marino", "Sao Tome und Principe", "Saudi-Arabien", "Schweden",
			"Schweiz",
			"Senegal", "Serbien", "Seychellen", "Sierra Leone", "Simbabwe", "Singapur",
			"Slowakei",
			"Slowenien", "Somalia", "iland)", "Somaliland", "Spanien", "Sri Lanka",
			"St. Kitts und Nevis", "St. Lucia", "St. Vincent und die Grenadinen",
			"Sudafrika S�dafrika", "Sudan", "Sudossetien S�dossetien", "Suriname",
			"Swasiland",
			"Syrien", "Tadschikistan", "Tansania", "Thailand", "Togo", "Tonga",
			"Transnistrien",
			"Trinidad und Tobago", "Tschad", "Tschechien", "Tunesien", "Turkei T�rkei",
			"Turkmenistan Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "Ungarn",
			"Uruguay",
			"Usbekistan", "Vanuatu", "Vatikanstadt", "Venezuela",
			"Vereinigte Arabische Emirate",
			"Vereinigte Staaten", "Vereinigtes K�nigreich", "Vietnam", "Wei�russland",
			"Westsahara", "Zentralafrikanische Republik", "Zypern"
			};

        public static DataType constructOf(String s)
        {
            if ("STAATEN".Equals(s))
            {
                return new StaatenType();
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