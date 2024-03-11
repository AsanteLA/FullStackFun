import React from 'react';
import './App.css';
import Header from './Header';
import FoodList from './Food/FoodList';

function App() {
  return (
    <div className="App">
      <Header title="Full stack Ract & ASP.NET" />
      <FoodList />
    </div>
  );
}

export default App;
