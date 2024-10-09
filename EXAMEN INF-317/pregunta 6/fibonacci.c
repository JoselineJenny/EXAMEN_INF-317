#include <stdio.h>

void fibo(int n){
	int a = 0, b = 1;
	int c;
	
	for(int i; i < n; i++){
		printf("%d\n", a);
		
		c = a + b;
		a = b;
		b = c;
	}
}

int main(){
	int n;
	
	printf("Ingrese un numero: ");
	scanf("%d", &n);
	
	fibo(n);
	
	return 0;
}
