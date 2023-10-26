const listaPessoas = [];

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
    
    const pessoa = {nome, altura, peso, imc : imc.toFixed(2), situacao}

    listaPessoas.push(pessoa);
    exibirPessoas();
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

function exibirPessoas() {
    let linhas = '';
    listaPessoas.forEach( function(p){

        linhas +=`
            <tr>
                <td data-cell="nome">${p.nome}</td>
                <td data-cell="altura">${p.altura}</td>
                <td data-cell="peso">${p.peso}</td>
                <td data-cell="valor do IMC">${p.imc}</td>
                <td data-cell="classificação do IMC">${p.situacao}</td>
                <td data-cell="data de cadastro">19/06/2023 21:27</td>
            </tr> 
        `;
    });

    // inserir as linhas na tabela html
    document.getElementById('corpo-tabela').innerHTML = linhas;
}