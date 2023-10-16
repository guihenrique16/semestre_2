function calcular(e) {
    e.preventDefault();
    let nome = document.getElementById("nome").value.trim();
    let altura = parseFloat(document.getElementById("altura").value);
    let peso = parseFloat(document.getElementById("peso").value);

    if (isNaN(altura) || isNaN(peso) || nome.lenght < 2) {
        alert("preencha todos os campos");
        return;
    }

    const imc = calcularImc(peso, altura);
    const situacao = gerarSituacao(imc);
   
    // console.log(nome);
    // console.log(altura);
    // console.log(peso);
    // console.log(imc);
    // console.log(situacao);
    
    const pessoa = {
        nome : nome,
        altura : altura,
        peso : peso,
        Imc : imc,
        situacao : situacao
    }
    console.log(pessoa);
}

function calcularImc(peso, altura) {
    //return peso / (altura * altura);
    return peso / Math.pow(altura,2);
}

function gerarSituacao(imc) {
    if (imc < 18.5) {
        return "Magreza severa";
    }
    else if (imc <= 24.99) {
        return "Peso Normal";
    } 
    else if (imc <= 29.99) {
        return "Acima do peso";
    } 
    else if (imc <= 34.99) {
        return "Obesidade I";
    } 
    else if (imc <= 39.99) {
        return "Obesidade II";
    } 
    else {
        return "Cuidado!!"
    }
}