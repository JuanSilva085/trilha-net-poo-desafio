namespace DesafioPOO.Models
{
    //Implementado!
    public class Iphone : Smartphone
    {
        public override string Modelo { get; set; }
        public override string Imei { get; set; }
        public override int Memoria { get; set; }
        
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero)
        {
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        } 

        //Implementado!


         public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no iPhone");
        }
    }
}