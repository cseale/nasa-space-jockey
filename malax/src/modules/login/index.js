import React from 'react';
import logo from './pnglogo.png';
import {Link} from 'react-router-dom'


class Login extends React.Component {
    render() {
        return (
            <div className="Login">
                <img src={logo} width={469} height={469} className="LoginLogo"/>
                <Link to="/">
                    <button className="LoginButton">Login</button>
                </Link>
            </div>
        )
    }
}

export default Login;