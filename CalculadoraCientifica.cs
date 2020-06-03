namespace Aula9Calculadora
{
    public class CalculadoraCientifica : Calculadora
    {
        private string[] valores { get; set; }
        private float val { get; set; }
        private float soma;

        public void CalcularMedia(string txtConsole){
            
            valores =txtConsole.Split(",");

            for (int i = 0; i <valores.Length; i++)
            {
                val = float.Parse(valores[i]);
                soma += val;
            }

            resultado = soma / valores.Length;
        }
        public void ManipularCalcular(string entradaUsuario){

            string[] entrada = entradaUsuario.Split(' ');

            num1 = float.Parse(entrada[0]);
            operador = entrada[1];
            num2 = float.Parse(entrada[2]);

            if(entrada[1] == null){
                entrada = entradaUsuario.Split('+');
                if(entrada[1] != null){
                    operador = "+";
                }
            }
            switch (operador)
            {
                case "+":
                somar();
                break;

                case "-":
                subtrair();
                break;

                case "*":
                multiplicar();
                break;

                case "/":
                dividir();
                break;

                default:
                somar();
                break;
            }


        }
    }
}