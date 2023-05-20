//Meu Primeiro Programa

//nome da classe
class MeuPrimeiroProgramaJava
{
    //módulo principal com a entrada pela linha de comando
    public static void main(String entrada[]) 
    {
        //declaração de variáveis
        int inteiro = 31;
        char caracter = 'F';
        double real  = 1.70;
        String frase = "Pamela Rondina";
        boolean VF=true;

        if (VF == true)
        {
            System.out.println("Eu sou a " + frase + ", tenho " + inteiro + " anos e " + real + "m de altura");
        }

        System.exit(0);

    }
}
