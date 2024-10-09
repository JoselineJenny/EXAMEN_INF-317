#include <mpi.h>
#include <stdio.h>
#include <stdlib.h>

#define t 10

int main(int argc, char **argv) {
    int r, s;
    int vector1[t], vector2[t];
    int result[t];
    int resultFin[t]; 

    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &r);
    MPI_Comm_size(MPI_COMM_WORLD, &s);

    if (r == 0) {
        
        for (int i = 0; i < t; i++) {
            vector1[i] = i + 1;  
            vector2[i] = (i + 1) * 2; 
        }
    }

    
    MPI_Bcast(vector1, t, MPI_INT, 0, MPI_COMM_WORLD);
    MPI_Bcast(vector2, t, MPI_INT, 0, MPI_COMM_WORLD);

    for (int i = 0; i < t; i++) {
        result[i] = 0; 
    }

    for (int i = r; i < t; i += s) {
        result[i] = vector1[i] + vector2[i];
    }

    MPI_Gather(result, t, MPI_INT, resultFin, t, MPI_INT, 0, MPI_COMM_WORLD);
    
    
    	printf("vector 1:\n");
    for (int i = 0; i < t; i++) {
            printf("%d ", vector1[i]);
        }
        printf("\n");
        
        printf("vector 2:\n");
    for (int i = 0; i < t; i++) {
            printf("%d ", vector2[i]);
        }
        printf("\n");

    if (r == 0) {
        printf("Suma:\n");
        for (int i = 0; i < t; i++) {
            printf("%d ", resultFin[i]);
        }
        printf("\n");
    }

    MPI_Finalize();
    return 0;
}
