using system;
namespace Calculadora
{
    class program
{
   static void main (string[]args)
{

console.writeline("calculadora");

console.writeline("Ingresa el primero número ->  ");
double num1 = convert.todouble(cosole.readline());

console.writeline("Ingrese el segundo número ->  ");
double num2 = convert.todouble(console.readline());

console.writeline("Elige una operacion.");
console.writeline("1 -> Suma");
console.writeline("2 -> Resta");
console.writeline("1 -> Multiplicación");
console.writeline("1 -> División");

int operacion = convert.toint32(console.readline());

double resultado = 0;

switch (opcion)
{
case 1:
      resultado = num1 + num2;
      break;
case 2:
      resultado = num1 - num2;
      break;
case 3:
      resultado = num1 * num2;
      break;
case 4:
      if (num2 !=0)
{
      resultado = num1 / num2;
}
console.writeline("No se puede dividir por cero");
return;
}
break;

default: console.writeline("Opción inválida.");
return;
} 
 console.writline ("El resultado es ->  ");
}
}