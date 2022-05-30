/* 
   Determinar si un numero es primo o no, el método usado es dividiéndolo por los 
   primeros n numeros desde el 2 hasta la mitad del numero para probar si tiene
   un divisor que retorne resto 0.
*/
function esPrimo(num) {
  if (num == 2) return true; //Excepcion de primo que no entra al ciclo
  let arrExcp = [0, 1, 4];
  if (arrExcp.includes(Number(num)) || num != Math.abs(num)) return false; //Excepciones de no primos -> si el numero es 0, 1 o 4 (4 pq no entra en el ciclo), o es negativo
  //Demás casos
  for (let div = 2; div < num / 2; div++) {
    //Desde 2 y hasta la mitad del numero
    if (num % div == 0) {
      //Si el resto es 0
      return false; //Encontró un divisor -> no es primo
    }
  }
  return true; //Si no encontró divisor -> es primo
}

function principal() {
  let numero = document.getElementById("num").value;
  if (!isNaN(numero))
    if (esPrimo(numero))
      //Comprobar si es numero
      mensaje = "El numero " + numero + " es primo";
    else mensaje = "El numero " + numero + " no es primo";
  else mensaje = "Ingrese solo numeros.";
  document.querySelector("#Res").innerText = mensaje;
}
