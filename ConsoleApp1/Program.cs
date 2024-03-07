/*MENOR QUE 18,5	MAGREZA	0
ENTRE 18,5 E 24,9	NORMAL	0
ENTRE 25,0 E 29,9	SOBREPESO	I
ENTRE 30,0 E 39,9	OBESIDADE	II
MAIOR QUE 40,0	OBESIDADE GRAVE	III

divide-se o peso do paciente pela sua altura elevada ao quadrado.
*/


using System.ComponentModel.Design;

double peso = Convert.ToDouble(Console.ReadLine());
double altura = Convert.ToDouble(Console.ReadLine());
double imc = peso / Math.Pow(altura,2);

if (imc >= 40){
    Console.WriteLine("obesidade grave 3");
} 
else if (imc >= 30){
    Console.WriteLine("obesidade 2");
}
else if (imc >= 25){
    Console.WriteLine("sobrepeso 1");
}
else if (imc >= 18.5){
    Console.WriteLine("normal 0");
}
else{
    Console.WriteLine("magreza 0");
}
Console.WriteLine("imc: " + Math.Round(imc, 2));