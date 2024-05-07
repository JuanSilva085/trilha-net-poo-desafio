namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public abstract string Modelo { get; set; }
        public abstract string Imei { get; set; }
        public abstract int Memoria { get; set; }
        //Implementado!
        

        public Smartphone(string numero)
        {
            Numero = numero;
            Modelo = Modelo;
            Imei = Imei;
            Memoria = Memoria;
            
            //Implementado!
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}