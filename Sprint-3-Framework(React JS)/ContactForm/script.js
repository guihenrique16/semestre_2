const urlLocal = "http://localhost:3000/contatos"

async function chamarApi() {
     const cep = document.getElementById("cep").value;
     const url = `https://viacep.com.br/ws/${cep}/json/`;
     try {
          const promise = await fetch(url);
          const endereco = await promise.json();

          console.log(endereco);
          exibirEndereco(endereco);

     } catch (error) {
          alert("CEP invalido");

          limparEndereco()
          document.getElementById("not-found").innerText = "Cep Inválido"
     }

}


async function Cadastrar(e) {
     e.preventDefault();

     const nome = document.getElementById("nome").value
     const sobrenome = document.getElementById("sobrenome").value
     const email = document.getElementById("email").value
     const pais = document.getElementById("pais").value
     const ddd = document.getElementById("ddd").value
     const telefone = document.getElementById("telefone").value
     const cep = document.getElementById("cep").value
     const rua = document.getElementById("rua").value
     const numero = document.getElementById("numero").value
     const complemento = document.getElementById("complemento").value
     const bairro = document.getElementById("bairro").value
     const cidade = document.getElementById("cidade").value
     const UF = document.getElementById("UF").value
     const anotacoes = document.getElementById("anotacoes").value

     const objDados = { nome, sobrenome, email, pais, ddd, telefone, cep, rua, numero, complemento, bairro, cidade, UF, anotacoes }

     try {
          const promise = await fetch(urlLocal, {
               body: JSON.stringify(objDados),
               headers: { "Content-Type": "application/json" },
               method: "post"
          });
          const retorno = await promise.json();
          console.log(retorno);
          limparEndereco();

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