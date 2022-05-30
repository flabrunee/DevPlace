'''
Ejercicio de memoria: pide al usuario el ingreso de una contraseña y verifica que
la ingrese correctamente 3 veces seguidas, si falla en alguno de los intentos 
aparece un mensaje de falla y si acierta las 3 aparece uno de Felicitaciones.
'''
cnt = 0
pwd = input('Ingrese la contraseña:')
pwd_original = pwd
acierta = True
while (acierta) & (cnt < 3):
    pwd = input('Repita la contraseña ' + str(cnt+1) + 'ª vez:')
    acierta = pwd_original == pwd
    cnt += 1
if acierta:
    print('Felicitaciones, recordás tu contraseña')
else:
    print('Incorrecto, tenes que ejercitar la memoria')
input()
