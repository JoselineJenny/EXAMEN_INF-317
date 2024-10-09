#include <stdio.h>

void suma(int a, int b, int *c){
	*c = a + b;
}
void resta(int a, int b, int *c){
	*c = a - b;
}
void multiplicacion(int a, int b, int *c){
	*c = a * b;
}
void division(int a, int b, int *c){
	*c = a / b;
}

int main(){
	int a, b, c;
	
	printf("Ingrese el primer numero: ");
	scanf("%d", &a);
	printf("Ingrese el segundo numero: ");
	scanf("%d", &b);
	
	suma(a, b, &c);
	printf("La suma es: %d\n", c);
	resta(a, b, &c);
	printf("La resta es: %d\n", c);
	multiplicacion(a, b, &c);
	printf("La multiplicacion es: %d\n", c);
	if(b != 0){
		division(a, b, &c);
		printf("La division es: %d\n", c);
	resta(a, b, &c);
	}else{
		printf("Error el denominador no puede ser cero");
	}
}
