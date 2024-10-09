#include <stdio.h>
#include <omp.h>

int main() {
    int n;

    printf("Ingrese un numero: ");
    scanf("%d", &n);
   
    int a = 0, b = 1, c;

    if (n >= 1) {
        printf("%d ", a);
    }
    
    if (n >= 2) {
        printf("%d ", b);
    }
    
    #pragma omp parallel private(c) shared(a, b, n) 
    {
        #pragma omp for
        for (int i = 2; i < n; i++) {
           
            #pragma omp critical
            {
                c = a + b; 
                printf("%d ", c); 
                a = b;
                b = c; 
            }
        }
    }

    printf("\n");
    return 0;
}



