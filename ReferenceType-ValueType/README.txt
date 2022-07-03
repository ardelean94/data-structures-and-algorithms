/*  CLASS   */
var peterParker = new Person();
var spiderMan = peterParker;

// when HairColor is changed for one variable the other one is also update because these values have a pointer that reference a memory address where the actual data is located
spiderMan.HairColor = HairColor.Pink;

Console.WriteLine("Hair color of Peter Parker: " + peterParker.HairColor);
Console.WriteLine("Hair color of Spiderman: " + spiderMan.HairColor);

/* OUTPUT:
    Hair color of Peter Parker: Pink
    Hair color of Spiderman: Pink
*/


/*  STRUCT  */
var parkerPeter = new Individ();
var manSpider = peterParker;

// when HairColor is changed for one variable the other one is NOT update b/c of struct if Value Type - holds the value inside that variable
spiderMan.HairColor = HairColor.Orange;

Console.WriteLine("Hair color of Peter Parker: " + parkerPeter.HairColor);
Console.WriteLine("Hair color of Spiderman: " + manSpider.HairColor);

/* OUTPUT:
    Hair color of Peter Parker: Black
    Hair color of Spiderman: Orange
*/