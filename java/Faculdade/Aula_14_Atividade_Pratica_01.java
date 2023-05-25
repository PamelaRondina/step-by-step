import javax.swing.*;

class Aula_14_Atividade_Pratica_01 
{
    public static void main(String entrada[]) 
    {
        //declaração de variáveis
        int n1, n2, mod;
        double raiz1, raiz2;
        String msg = "";

        //entrada de dados
        n1 = Integer.parseInt(JOptionPane.showInputDialog
        ("Digite um número inteiro"));
        n2 = Integer.parseInt(JOptionPane.showInputDialog("Digite outro número inteiro"));

        //processamento
        mod = n1 % n2;
        raiz1 = Math.sqrt(n1);
        raiz2 = Math.sqrt(n2);

        //saida de resultados
        msg = msg + "resto da divisão de " + n1 + " por " + n2 + " = " + mod + "\n";
        msg = msg + "raiz quadrada de " + n1 + " = " + raiz1 + "\n";
        msg = msg + "raiz quadrada de " + n2 + " = " + raiz2 + "\n";
        JOptionPane.showMessageDialog(null, msg);

        System.exit(0);
    }
}
