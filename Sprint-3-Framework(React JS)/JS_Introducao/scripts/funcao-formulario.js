function ola(){
    event.preventDefault();
    let nome = document.getElementById("Nome").value;
    let nickname = document.getElementById("Nickname").value;

    //Insere um texto no html
    //document.getElementById("saudacao").innerText = `ola, ${nome.replace(nome, nickname)}`;
    
    let saudacao = nome.replace(nome, nickname);
    document.getElementById("saudacao").innerText = `Ola, ${saudacao}`;
}