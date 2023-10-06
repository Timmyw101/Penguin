import './App.css';
import { MouseEventHandler, useState } from 'react';
import React from 'react';
import { ReactEventHandler } from 'react';


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
        
        <button onClick={GetMessages}>
          Play Movie
        </button>
      </header>
    </div>
  );

  async function GetMessages(){

    const response = await fetch("http://localhost:5294/Chat/messages");
    const text = await response.json();
    setText(text);
  }

}

export default App;
