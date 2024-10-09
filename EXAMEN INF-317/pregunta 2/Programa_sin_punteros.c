#include <stdio.h>

int suma(int a, int b){
	return a + b;
}

int resta(int a, int b){
	return a - b;
}

int multiplicacion(int a, int b){
	return a * b;
}

int division(int a, int b){
	return a / b;
}

int main(){
	int a, b;
	
	printf("Ingrese el primer numero: ");
	scanf("%d", &a);
	printf("Ingrese el segundo numero: ");
	scanf("%d", &b);
	
	printf("La suma es: %d\n", suma(a, b));
	printf("La resta es: %d\n", resta(a, b));
	printf("La multiplicacion es: %d\n", multiplicacion(a, b));
	
	if(b != 0){
		printf("La division es: %d\n", division(a, b));
	}else{
		printf("Error el denominador no debe ser cero");
	}
	
	return 0;
	
}
