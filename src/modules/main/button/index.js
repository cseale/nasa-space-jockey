import React from 'react';

class Button extends React.Component {
    render() {
        return (
            <div className="ButtonWrapper">
                <img className="Button" src={this.props.src}></img>
                <a className="Label">{this.props.text}</a>
            </div>
        )
    }
}

export default Button;