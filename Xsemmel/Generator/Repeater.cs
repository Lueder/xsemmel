using System;
using Random = XSemmel.Generator.Random;

namespace XSemmel.Generator {
    /**
     * Diese Klasse ist in der Lage, ein Element zu wiederholen.
     * @author Frank Schnitzer
     */
    public class Repeater {

	    private const int MAX = 20; //TODO Diese Gr��e per Kommandozeilenparameter einstellbar machen (Ma� f�r die Gr��e der Zeildatei)

	    private readonly int min;
	    private readonly int max;

	    //    private float prob;

	    public Repeater(string cardinality/*, float propability*/) {
		    if ("*".Equals(cardinality)) {
			    min = 0;
			    max = MAX;
		    } else if ("?".Equals(cardinality)) {
			    min = 0;
			    max = 1;
		    } else if ("+".Equals(cardinality)) {
			    min = 1;
			    max = MAX;
		    } else {
			    min = Int32.Parse(cardinality);
			    max = min;
		    }

		    //        prob = propability;
	    }

	    /**
	     * F�hrt den angegebenen Runner gem�� des im Konstruktor angegebenen Kardinalit�t 
	     * aus.
	     * @param r
	     * @throws Exception
	     */
	    public void run(Action<int> r)  {
		    int runs = Random.oneBetween(min, max);
		    if (runs == 0) {
			    return;
		    }
		    for (int i = 1; i <= runs; i++) {
			    r(i);
		    }
	    }



    }
}