import logo from './logo.svg';
import './App.css';
import { useState } from 'react';


function App() {
  
  const [text, setText] = useState("");
  return (
    <div className="App">
      <header className="App-header">
        <div>
          <p>
            { text }
          </p>
        </div>
        <Button onClick={GetMessages}>
          Play Movie
        </Button>
      </header>
    </div>
  );

  async function GetMessages(){

    const response = await fetch("http://localhost:5294/Chat/messages");
    const text = await response.json();
    setText(text);
  }
  

}


function Button({ onClick, children }) {
  return (
    <button onClick={onClick}>
      {children}
    </button>
  );
}

export default App;
