// const camisaLacoste = {
//     descricao : "Camisa lacoste",
//     marca : "Lacoste",
//     preco : 399.98,
//     tamanho : "G",
//     cor : "Azul",
//     promocao : true
// }

// const descricao = camisaLacoste.descricao;
// const preco = camisaLacoste.preco;

// const {descricao, preco, promocao} = camisaLacoste;

// console.log(`
//     Produto: ${descricao}
//     Preço: ${preco}
//     Promocao: ${promocao? "sim" : "Nao"}
// `);

const evento = {
    dataEvento : new Date(),
    descricao: "Evento de js",
    titulo: "JavaScript event",
    comentario: "Otimo evento!!",
    presenca: true
}

//const {dataEvento, descricao, titulo, comentario, presenca} = evento;
const {dataEvento, descricao, titulo, ...resto} = evento;

console.log(dataEvento);
console.log(titulo);
console.log(descricao);
console.log(resto);

// console.log(`
//     Data ${dataEvento}
//     titulo: ${titulo}
//     decricao: ${descricao}
//     comentario: ${comentario}
//     presenca: ${presenca? "confirmado" : " Nao confirmado"}
// `);