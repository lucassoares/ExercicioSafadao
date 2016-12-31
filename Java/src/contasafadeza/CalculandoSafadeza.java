package contasafadeza;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class CalculandoSafadeza 
{
	public static void main(String[] args) throws IOException 
	{
		System.out.println("Hello World");
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int dia = Integer.parseInt(br.readLine());
		int mes = Integer.parseInt(br.readLine());
		int ano = Integer.parseInt(br.readLine());	
		wesley_safadao(dia,mes,ano);
	}
	
	private static void wesley_safadao(int dia, int mes, int ano)
	{
		double safadeza = somatorio(mes) + (ano/100) * (50-dia);
		double anjo = 100 - safadeza;
		System.out.println(String.format("%.2f",safadeza) + "% safado e " + String.format("%.2f", anjo) + "% anjo");
	}
	
	private static int somatorio(int n)
	{
		int resultado = 0;
		for(int i = 1; i <= n; i++)
		{
			resultado += i;
		}
		return resultado;
	}
}
