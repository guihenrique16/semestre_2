function calcular() {
    event.preventDefault();//Imterrompe o submite do formulario
    let n1 = parseFloat(document.getElementById("numero1").value);
    let n2 = parseFloat(document.getElementById("numero2").value);
    let res; // undefined
    let op = document.getElementById("operacao").value;

    if(isNaN(n1) || isNaN(n2)){
        alert('preencha todos os campos')
        return;
    }

    if (op == '+') {
        res = somar(n1, n2);
    }
    else if (op == '-') {
        res = subtrair(n1, n2);
    }
    else if (op == '/') {
        res = dividir(n1, n2);
    }
    else if (op == '*') {
        res = multiplicar(n1, n2);
    }
    else {
        alert('operacao invalida')
    }

    //alert(`resultado: ${res}`)
    console.log(`Resultado: ${res}`);
    document.getElementById('resultado').innerText = res; 

}    

function somar(x, y) {
    return (x + y).toFixed(3);
}
function subtrair(x, y) {
    return (x - y).toFixed(3);
}
function multiplicar(x, y) {
    return (x * y).toFixed(3);
}
function dividir(x, y) {
    if (y == 0) {
        return 'impossivel dividir por zero';
    } else {
      return (x / y).toFixed(3);  
    }
    
}