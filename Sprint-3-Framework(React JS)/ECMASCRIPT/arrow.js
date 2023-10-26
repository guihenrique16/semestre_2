// const somar = (x, y) => {
//     return x+y
// }
// console.log(somar(50,10));

// const dobro = (numero) => {
//     return numero * 2
// }
// console.log(dobro(10));

// const dobro2 = numero => numero * 2;
// console.log(dobro2(20));

const boaTarde = () => {console.log("Boa tarde!!");}
boaTarde();

const convidados = [
    {nome:"MuMu",idade: 19},
    {nome:"Gelipe Fois", idade: 45},
    {nome:"Felix", idade: 19},
    {nome:"Guilherme", idade: 18},
    {nome:"Peidim", idade: 16},
    {nome:"Mini-Craque", idade: 17}
];

convidados.forEach(c =>{
    console.log(`Convidado : ${c.nome}`);
})