#include <stdio.h>
#include <stdlib.h>

void main()
{
    float valorhora;
    printf("\tIngrese valor hora: ");
    scanf("%f", &valorhora);

    char nombreemp[20];
    printf("\tIngrese nombre del empleado: ");
    scanf("%s", nombreemp);

    float antiguedad;
    printf("\tIngrese antigüedad en el trabajo: ");
    scanf("%f", &antiguedad);

    int hsTrabxMes;
    printf("\tIngrese horas trabajadas por mes: ");
    scanf("%d", &hsTrabxMes);

    float importe = valorhora * hsTrabxMes;
    if (antiguedad > 10)
        importe += antiguedad * 30;

    printf("\nEmpleado: %s \n Antigüedad: %f \n Importe Total mes %f \n\n", nombreemp, antiguedad, importe);

    system("pause");
}
