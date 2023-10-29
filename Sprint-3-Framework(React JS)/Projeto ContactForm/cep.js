async function chamarApi() {
     const cep = document.getElementById("cep").value;
     const url = `https://viacep.com.br/ws/${cep}/json/`;
     try {
          const promise = await fetch(url);
          const endereco = await promise.json();

          console.log(endereco);
          exibirEndereco(endereco);
     } catch (error) {
          alert("erro na api");

          limparEndereco()
          document.getElementById("not-found").innerText = "Cep Inválido"
     }

}

const urlLocal = ""
async function cadastrar(e) {
     e.preventDefault();

     let nome = document.getElementById("nome").value
     let sobrenome = document.getElementById("sobrenome").value
     let email= document.getElementById("email").value
     let pais= document.getElementById("pais").value
     let ddd= document.getElementById("ddd").value
     let telefone = document.getElementById("telefone").value
     let cep = document.getElementById("cep").value
     let rua = document.getElementById("rua").value
     let numero = document.getElementById("numero").value
     let complemento = document.getElementById("complemento").value
     let bairro = document.getElementById("bairro").value
     let cidade = document.getElementById("cidade").value
     let UF = document.getElementById("UF").value
     let anotacoes = document.getElementById("anotacoes").value
     
     const objDados = {nome, sobrenome, email, pais, ddd, telefone, cep, rua, numero, complemento, bairro, cidade, UF, anotacoes}

     try {
          const promise = await fetch(urlLocal, {
               body: JSON.stringify(objDados),
               headers: { "Content-Type": "application/json" },
               method: "post"
          });

          const retorno = promise.json();
          console.log(retorno);

     } catch (error) {
          alert("Deu ruim" + error)
     }
}

function exibirEndereco(endereco) {
     document.getElementById("rua").value = endereco.logradouro
     document.getElementById("bairro").value = endereco.bairro
     document.getElementById("cidade").value = endereco.localidade
     document.getElementById("UF").value = endereco.uf
     document.getElementById("ddd").value = endereco.ddd
 }

 function limparEndereco() {
     document.getElementById("cep").value = "";
     document.getElementById("rua").value = "";
     document.getElementById("numero").value = "";
     document.getElementById("complemento").value = "";
     document.getElementById("bairro").value = "";
     document.getElementById("cidade").value = "";
     document.getElementById("UF").value = "";
     document.getElementById("ddd").value = "";
}