 namespace Tarea2;
     public class Puerta{
        public string Color;
        public Puerta(){
           
            Color = "cafe";
        }
        public void SetColor(string Color){

               this.Color = Color; 
        }
        public void MostrarDatos(){

               Console.WriteLine($"Soy una puerta mi color es: {Color }");
        }
     }
     