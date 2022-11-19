// See https://aka.ms/new-console-template for more information
using Entidades;

Lapiz? lapiz1 = new("Faber", 100, Color.Verde);
SacaPuntas? sacaPuntas = new("Pepito", 200, "Metal");
Goma? goma = new("Fz", 300);
List<Utiles>? utiles = new List<Utiles>
            {
                lapiz1,
                sacaPuntas,
                goma
            };
Cartuchera<Utiles>? cartucheraUtiles = new Cartuchera<Utiles>(4, utiles);

Console.WriteLine(cartucheraUtiles.ToString());
