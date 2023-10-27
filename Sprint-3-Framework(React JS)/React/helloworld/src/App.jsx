import './App.css';
import Titulo from './components/Titulo/Titulo';
import Card from './components/CardEvento/Card'

function App() {
  return (
    <div className="App">
      <h1>Hello React</h1>
      <Titulo text ="Guilherme" />
      <Titulo text ="Gelipe" />
      <Titulo text ="GodMu" />

      <Card 
      titulo ="React(JS)" 
      descricao = "evento sobre react(javaScript)" link  ="conectar"
      />
    </div>
  );
}

export default App;
