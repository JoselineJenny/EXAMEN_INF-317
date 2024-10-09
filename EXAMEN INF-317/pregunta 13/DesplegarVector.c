#include <stdio.h>
#include <string.h>
#include <mpi.h>
#include <unistd.h> 

#define MAX_STR_LEN 100
#define N 50 

int main(int argc, char **argv) {
    int rank, size;
    char data[N][MAX_STR_LEN];
    
    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &rank);
    MPI_Comm_size(MPI_COMM_WORLD, &size);
    
    if (rank == 0) {
        for (int i = 0; i < N; i++) {
            snprintf(data[i], MAX_STR_LEN, "Cadena %d", i + 1);
        }
    }
  
    MPI_Bcast(data, N * MAX_STR_LEN, MPI_CHAR, 0, MPI_COMM_WORLD);

    
    for (int i = 1; i < N; i += size) {
        if (rank == 1 && i % 2 == 0) { // nnnnnnnnnnnnnnnnnnnnnn
            printf("Proceso 1 (par): %s\n", data[i+1]);
            
        } else if (rank == 2 && i % 2 != 0) { 
            printf("Proceso 2 (impar): %s\n", data[i+1]);
            
        }
    }

    
    MPI_Finalize();
    return 0;
}



