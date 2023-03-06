 namespace Tarea2;

     public class Casa{

        public int Area;
        public Puerta puerta = new Puerta();

        public Casa(int Area){
               this.Area = Area;
                this.puerta = new Puerta();
        }

        public void setArea(int Area){
               this.Area = Area;
        }
        public void setPuerta(Puerta puerta){
            this.puerta = puerta;
        }
        public virtual void MostrarDatos(){
            Console.WriteLine($"Soy una casa, mi area es: {Area} m2");
        }
        
     }