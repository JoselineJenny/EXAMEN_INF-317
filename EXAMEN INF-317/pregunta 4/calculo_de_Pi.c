#include <stdio.h>

void pi_Iterativo(int n, float *a){
	float s = 0;
	for(int i=0; i < n; i++){
		s += (i % 2 == 0 ? 1 : -1) / (2.0 * i + 1.0);
	}
	*a = 4.0 * s;
}

float pi_Recursivo(int n, float *s){
	if(n == 0){
		*s+= 1.0;
		return 4.0 * (*s);
	}else{
		*s += (n % 2 == 0 ? 1.0 : -1.0) / (2.0 * n + 1.0);
		return pi_Recursivo(n - 1, s);
	}
}

int main(){
	int n;
	float PI, PR;
	
	printf("Ingrese un numero: ");
	scanf("%d", &n);
	
	pi_Iterativo(n, &PI);
	printf("Pi Iterativo: %f\n", PI);
	
	float s = 0;
	PR = pi_Recursivo(n, &s);	
	printf("Pi Recursivo: %f\n", PR);
}
