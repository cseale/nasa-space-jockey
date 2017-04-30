import React, { Component } from 'react';
import Augmented from './modules/augmented';
import Background from './modules/background';
import MainPage from './modules/main';
import Cesium from './modules/cesium';
import Login from './modules/login';
import {
  BrowserRouter as Router,
  Route
} from 'react-router-dom'
import './App.css';

class Home extends Component {
  render() {
    return (
      <div>
        <Background />
        {this.props.children}
      </div>
    )
  }
}

class App extends Component {
  componentDidMount() {
    if (window.location.href.indexOf("/login") === -1) window.location.href = "/login";
  }

  render() {
    return (
      <Router>
        <div className="App">
          <Route path="/login" component={Login}/>
          <Home>        
            <Route exact path="/" component={MainPage}/>
            <Route path="/cesium" component={Cesium}/>
            <Route path="/augmented" component={Augmented}/>
          </Home>          
        </div>
      </Router>
    );
  }
}

export default App;
