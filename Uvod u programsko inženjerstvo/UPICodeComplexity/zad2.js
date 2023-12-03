/*
    Drugi zadatak

    Kompleksnost funkcije faktorijel trenutno je na 7.
    Pokušaj preurediti kod funkcije tako da kompleksnost bude <= 5.

*/


function faktorijel(n) {
  if(n < 0)throw new Error("n mora biti veće od 0");

  if(n === 0){
    return 1
  }
  else if(n !== 0)
  return n * (faktorijel(n-1)); 
}

module.exports = faktorijel;