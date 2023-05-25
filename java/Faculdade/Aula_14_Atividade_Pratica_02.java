import javax.swing.*;

class Aula_14_Atividade_Pratica_02 
{
    public static void main(String entrada[]) 
    {
        //declaração de variáveis
        int n1, n2, div;
        double pot;
        String msg = "";

        //entrada de dados
        n1 = Integer.parseInt(JOptionPane.showInputDialog("Digite o 1º número inteiro:"));
        n2 = Integer.parseInt(JOptionPane.showInputDialog("Digite o 2º número inteiro:"));

        //processamento
        div = (int)n1 / (int)n2; //calcula o quociente da divisão
        pot = Math.pow(n1, n2); //calcula a pototência do 1º pelo 2º

        //saida de resultados
        msg = msg + "**1º número: " + n1 + "**  **2º número: " + n2 +"**" + "\n";
        msg = msg + "Quociente da divisão do 1º número pelo 2º: " + div + "\n";
        msg = msg + "Potência do 1º número pelo 2º: " + pot + "\n";
        JOptionPane.showMessageDialog(null, msg);

        System.exit(0);
    }
}
