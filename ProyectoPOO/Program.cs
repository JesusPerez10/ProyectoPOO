using ProyectoPOO.Clases;
using ProyectoPOO.Claseshijas;

class Program
{
    static void Main(string[] args)
    {
        // Abstracción y Herencia 
        FiguraGeometrica rectangulo = new Rectangulo(5, 3);
        Console.WriteLine("Área del rectángulo: " + rectangulo.CalcularArea());
        Console.WriteLine("Perímetro del rectángulo: " + rectangulo.CalcularPerimetro());
        
        // Polimorfismo 
        Animal animal1 = new Perro();
        Animal animal2 = new Gato();
        animal1.Sonido();
        animal2.Sonido();

        // Encapsulación
        Persona persona = new Persona();
        persona.Nombre = "Jesus";
        persona.Edad = 25;
        Console.WriteLine("Nombre: " + persona.Nombre);
        Console.WriteLine("Edad: " + persona.Edad);

        // Interfaces
        IVehiculo coche = new Carro();
        coche.Arrancar();

        // Delegados
        Calculadora calc = new Calculadora();
        OperacionMatematica operacion = calc.Suma;
        operacion += calc.Resta;
        operacion(5, 3);
      

        // Eventos
        Boton boton = new Boton();
        boton.Click += () => Console.WriteLine("El botón fue clickeado.");
        boton.OnClick();

        // Indexadores
        Coleccion coleccion = new Coleccion();
        coleccion[0] = "Elemento 1";
        coleccion[1] = "Elemento 2";
        Console.WriteLine("Elemento 1: " + coleccion[0]);
        Console.WriteLine("Elemento 2: " + coleccion[1]);

        // Propiedades
        CuentaBancaria cuenta = new CuentaBancaria();
        cuenta.Saldo = 1000;
        Console.WriteLine("Saldo actual: " + cuenta.Saldo);
        // Intentar establecer un saldo negativo (provocará un mensaje de advertencia)
        cuenta.Saldo = -500;
    }
}