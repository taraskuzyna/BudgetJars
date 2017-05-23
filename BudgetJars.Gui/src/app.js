import React, { Component } from 'react';
import IncomeOverview from './income/incomeOverview';

class App extends Component {
  render() {
    return (
      <div className="App">
        <div className="App-header">
          <h2>Welcome to React</h2>
        </div>
        <IncomeOverview />
      </div >
    );
  }
}

export default App;
