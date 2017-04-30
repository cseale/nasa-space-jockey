import React from 'react';
import logo from './logo.svg';

class Navbar extends React.Component {
    render() {
        return (
        <div className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          <button className="NavbarButton">Malax</button>
          {/*<button className="NavbarButton">Sign Up</button>
          <button className="NavbarButton">Login</button>*/}
          <div className="NavbarLine"></div>
        </div>
        )
    }
}

export default Navbar;
