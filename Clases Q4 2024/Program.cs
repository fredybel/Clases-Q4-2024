using Clases_Q4_2024;

Ave ave = new Ave();
ave.Nombre = "Loro";
ave.Especie = "Amazona aestiva";
ave.Color = "Verde";
ave.tamano = 30.5 ;
ave.Habitat = "Bosques tropicales";

Console.WriteLine($"Nombre: "+ ave.Nombre);
Console.WriteLine($"Especie: " + ave.Especie);
Console.WriteLine($"Color: " + ave.Color);
Console.WriteLine($"Tamaño: " + ave.tamano);
Console.WriteLine($"Habitat: " + ave.Habitat);



Ave ave1 = new Ave();
ave1.Nombre = "Flamenco";
ave1.Especie = "Phoenicopterus roseus";
ave1.Color = "Rosa";
ave1.tamano = 120;
ave1.Habitat = "lagunas salinas";

Console.WriteLine();
Console.WriteLine($"Nombre: " + ave1.Nombre);
Console.WriteLine($"Especie: " + ave1.Especie);
Console.WriteLine($"Color: " + ave1.Color);
Console.WriteLine($"Tamaño: " + ave1.tamano);
Console.WriteLine($"Habitat: " + ave1.Habitat);