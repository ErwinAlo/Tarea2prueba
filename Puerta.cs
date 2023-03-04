 namespace Tarea2;

     class Puerta{
        public string Color;
        Puerta(){
           
            Color = "cafe";
        }
        public void SetColor(string Color){

               this.Color = Color; 
        }
        public void MostrarDatos(){

               Console.WriteLine($"Soy una puerta mi color es: {Color}");
        }
     }
     