namespace demo{

    class Carro{
        private int _cantidadGAS;

        public Carro(int cantidad)
        {
            this._cantidadGAS = cantidad;
        }

        public void Encender(){
            if  (this._cantidadGAS >0 ){
                System.Console.WriteLine("Ruuuummmm");
                this._cantidadGAS   -= 1;
            }else 
                System.Console.WriteLine("Shishishishishishiiiiiii");

        }
    }
}