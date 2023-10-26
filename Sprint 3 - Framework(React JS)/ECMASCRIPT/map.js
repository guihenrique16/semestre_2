//foreach - void

//--------------------- map -------------------------------------
//map - novo array modificado
const numeros =[1, 2, 5, 10, 300];
const dobro = numeros.map((n) => {
    return n * 2
});
console.log(numeros);
console.log(dobro);

//--------------------- filter ---------------------------------
//filter - novo array apenas com elementos que
//atendem a uma deteterminada condicao
const comentarios = [
    {comentario: "bla bla bla", exibe: true},+-

    {comentario: "Evento foi uma merda", exibe: false},
    {comentario: "Otimo evento", exibe: true}
];

const comentariosOk = comentarios.filter((c) => {
    //return c.exibe == true;
    return c.exibe;
})
comentariosOk.forEach(c => {
    console.log(`${c.comentario}`);
})

//--------------------- reduce ----------------------------------
//reduce -
const numeros2 =[1, 2, 5, 10, 100, 200, 300];
const soma = numeros2.reduce((VlInicial, n) => {
    return VlInicial - n
},200)
console.log(soma);
