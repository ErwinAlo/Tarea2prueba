 namespace Tarea2;

     public class Persona{
        public string Nombre;
        public Casa casa;

        public Persona(){
            
            Nombre = "Erwin";
            this.casa = new Casa(150);
        }

        public void SetNombre(string Nombre){
            this.Nombre = Nombre;
        }
        public void SetCasa(Casa casa){
            this.casa = casa;
        }
        
         public void MostrarDatos(){
            Console.WriteLine($"Mi nombre es {Nombre} ");
            casa.MostrarDatos();
            casa.puerta.MostrarDatos();
            

        }
    }