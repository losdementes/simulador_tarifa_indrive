public class simulador_tarifa
{
    public static void Main(string[] args)
    {
        string nombre, nombreVehiculo;
        double distancia, tarfibase, costokm, subtotal, tarifafinal, descuento = 0.0;
        int hora, tipoVehiculo;
        bool esHoraPico = false;
        Console.WriteLine("-------------------");
        Console.WriteLine("Simulador de Tarifa");
        Console.WriteLine("-------------------");
        //entrado de datos

        Console.WriteLine("nombre del pasajero: ");
        nombre = Console.ReadLine();
        Console.WriteLine("ingrese distancia del viaje (km): ");
         distancia = double.Parse(Console.ReadLine());
        Console.WriteLine("hora de salida(0 hrs-23hrs): ");
         hora = int.Parse(Console.ReadLine());
    Console.WriteLine("\nTipo de vehículo:");
    Console.WriteLine("1. economico");
    Console.WriteLine("2. confort");
    Console.WriteLine("3. premium");
    Console.WriteLine("4. moto");
    Console.Write("ingrese la opcion: ");
    tipoVehiculo = int.Parse(Console.ReadLine());

        //proceso
        switch (tipoVehiculo)
        {
            case 1: // economico
                nombreVehiculo = "Económico";
                tarfibase = 3.0;
                costokm = 2.0;
                break;
            case 2:// confort
                nombreVehiculo = "Confort";
                tarfibase = 3.0;
                costokm = 2.0;
                break;
            case 3:// premiun
                    nombreVehiculo = "Premium";
                tarfibase = 5.0;
                costokm = 3.0;
                break;
            case 4://moto
                    nombreVehiculo = "Moto";
                tarfibase = 1.5;
                costokm = 1.0;
                break;
            default:
                Console.WriteLine("Opción no válida, se asignará tarifa económica por defecto.");
                 nombreVehiculo = "Económico";
                tarfibase = 2.0;
                costokm = 1.5;
    
                break;
        }
        //calculo del subtotal base
        subtotal = tarfibase + (costokm * distancia);
        //condicional de recargo por hora pico
        if (hora >= 7 && hora <= 9 || hora >= 17 && hora <= 20)
        {
            esHoraPico = true;
            subtotal *= 1.30; // incremento del 30% en hora pico
        }
        //descuento por distancia larga(%5)
        if (distancia > 15)
        {
            descuento = subtotal * 0.05;
            subtotal -= descuento;
        }
        // tarfia minima y redondeo
        tarifafinal = Math.Max(subtotal, 5.0);
        tarifafinal = Math.Round(tarifafinal, 2);
        //salida
        Console.WriteLine("-------------------");
        Console.WriteLine("SIMULADOR DE TARIFA");
        Console.WriteLine("-------------------");
        Console.WriteLine($"Pasajero: " + nombre);
        Console.WriteLine($"Tipo de vehículo: " + nombreVehiculo);
        Console.WriteLine($"Distancia: " + distancia + " km");
        Console.WriteLine("hora pico: " + (esHoraPico ? "Sí" : "No"));// inline if -> condicionales verdad o falso
        if (descuento > 0)
        {
            Console.WriteLine($"Descuento:s/ " + Math.Round(descuento, 2));

        }
        else
        {
            Console.WriteLine("Descuento: No aplica");
        }
        Console.WriteLine("######################################3");
        Console.WriteLine("TARIFA FIANL: s/ " + tarifafinal);
        Console.WriteLine("#######################################");
    }
        


}
       

    
