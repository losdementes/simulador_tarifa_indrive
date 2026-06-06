public class simulador_tarifa
{
    public static void Main(string[] args)
    {
        Console.WriteLine("-------------------");
        Console.WriteLine("Simulador de Tarifa");
        Console.WriteLine("-------------------");
        //entrado de datos

        Console.Write("nombre del pasajero: ");
        string nombre = Console.ReadLine();
        Console.Write("ingrese distancia del viaje (km): ");
        double distancia = double.Parse(Console.ReadLine());
        Console.WriteLine("hora de salida(0 hrs-23hrs): ");
        int hora = int.Parse(Console.ReadLine());
    Console.WriteLine("\nTipo de vehículo:");
    Console.WriteLine("1. economico");
    Console.WriteLine("2. confort");
    Console.WriteLine("3. premium");
    Console.WriteLine("4. moto");
    Console.Write("ingrese la opcion: ");
    int tipoVehiculo = int.Parse(Console.ReadLine());
        //proceso


        double tarifa = CalcularTarifa(consumo);
        Console.WriteLine($"La tarifa para un consumo de {consumo} kWh es: {tarifa:C}");
    }
}
   