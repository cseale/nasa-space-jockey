import React from 'react';
import Navbar from '../navbar';
import Button from './button';
import satelitebutton from './satelitebutton.svg'
import vrbutton from './vrbutton.svg'
import telescopebutton from './telescope.svg'
import {Link} from 'react-router-dom'

class Main extends React.Component {
    render() {
        return (
            <div>
                <Navbar />  
                <div className="Main">
                    <Link to="/cesium">  
                        <Button text="Augmented Reality" src={telescopebutton}></Button>
                    </Link>
                    <Link to="/cesium">
                        <Button text="Virtual Reality" src={vrbutton}></Button>
                    </Link>
                </div>
            </div>
        )
    }
}

export default Main;