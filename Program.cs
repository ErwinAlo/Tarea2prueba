namespace Tarea2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------------------------------------");
        Persona persona = new Persona();
        persona.MostrarDatos();
        persona.Nombre = "Carlos";
        Apartamento nuevoApartamento = new Apartamento();
        Puerta nuevaPuerta = new Puerta();
        nuevaPuerta.SetColor("Azul");
        nuevoApartamento.setPuerta(nuevaPuerta);
        persona.SetCasa(nuevoApartamento);
        persona.MostrarDatos();
        Console.WriteLine("-------------------------------------");
        Console.WriteLine(" ");
    }
}
