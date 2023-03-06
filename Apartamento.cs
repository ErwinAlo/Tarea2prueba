 namespace Tarea2;

      public class Apartamento : Casa {

        public Apartamento() : base(50){    
        }
      
          public override void MostrarDatos(){
            Console.WriteLine($"Soy un apartamento, mi area es: {Area} m2");
        }
    }
    
    