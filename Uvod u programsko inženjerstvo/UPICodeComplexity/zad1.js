/*
    Prvi zadatak

    Smanjite ciklomatsku kompleksnost funkcije guessValue() na <= 10

    Hint: ako i samo ako
    
*/
function guessValue(value) {
    switch (value){
        case 1: return "one";
        case 2: return "two";
        case 3: return "three";
        case 4: return "four";
        default: return "Mission failed, we'll get them next time!";
    }
}

module.exports = guessValue;