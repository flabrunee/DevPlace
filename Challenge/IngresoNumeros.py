'''
Pedir al usuario que ingrese un número repetidamente hasta que ingrese un -1 y en ese
caso se terminará el programa.
Al terminar, mostrará lo siguiente:
a  mayor número introducido
b  menor número introducido
c  suma de todos los números
d  suma de los números PARES (lo agregué yo ya que no decía nada)
'''

mayor = 0
sumatotal = 0
sumapares = 0

print("Ingrese números (-1 termina): ")
num = int(input())
menor = num+1
while (num != -1):
    if num > mayor:  # Actualiza si encuentra uno mayor
        mayor = num
    if num < menor:  # Actualiza si encuentra uno menor
        menor = num
    sumatotal += num  # Lleva la suma total
    if (num % 2) == 0:
        sumapares += num  # Lleva la suma de pares
    num = int(input())
print("El mayor es: " + str(mayor))
print("El menor es: " + str(menor))
print("La suma total es: " + str(sumatotal))
print("La suma de los pares es: " + str(sumapares))
