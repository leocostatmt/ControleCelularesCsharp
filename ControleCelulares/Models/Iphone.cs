namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string iMei, int memoria): base(numero, modelo, iMei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalado {nomeApp}, aguarde. IPhone®");
            
          
        }
        
    }
}