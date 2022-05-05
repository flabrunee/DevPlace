#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

void main()
{
    srand(time(NULL));           // Generador de semilla aleatoria
    int numRand = rand() % 1001; // Elegir numero aleatorio del 0 al 1000

    int num;
    bool encuentra = false;
    while (!encuentra)
    {
        printf("\t\nIngrese un numero: ");
        scanf("%d", &num);
        if (num > numRand)
        {
            printf("\t Es menor");
        }
        else if (num < numRand)
        {
            printf("\t Es mayor");
        }
        else
        {
            printf("\t Numero encontrado\n");
            encuentra = true;
        }
    }
    system("pause");
}