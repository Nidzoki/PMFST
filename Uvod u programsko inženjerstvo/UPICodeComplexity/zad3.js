/*
    Treći zadatak

    Funkcija povrsinaTrokuta() trenutno ima kompleksnost 8.
    Preuredite kod funkcije tako da kompleksnost iznosi 6.

*/

function povrsinaTrokuta(a, b, c) {

    if(a+b < c){
        return "Trokut ne postoji!"
    }
    else if(a+c < b){
        return "Trokut ne postoji!"
    }
    else if(b+c < a){
        return "Trokut ne postoji!"
    } 

    

    let poluopseg = (a+b+c)/2
    let povrsina = Math.sqrt(poluopseg * (poluopseg - a)* (poluopseg - b)* (poluopseg - c)).toFixed(2)

    return povrsina
}

module.exports = povrsinaTrokuta