let eduardo = {
    nome: 'Eduardo',
    idade: 41,
    altura: 1.67
};
eduardo.peso= 89

let carlos = new Object();
carlos.nome='Carlos';
carlos.sobrenome='Roque';
carlos.idade=36;

let pessoas = [];
pessoas.push(eduardo);
pessoas.push(carlos);

//console.log(pessoas);

pessoas.forEach((p, n) =>{
    console.log(`Pessoa ${n +1}: ${p.nome}`);
});