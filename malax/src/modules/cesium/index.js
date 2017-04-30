import React from 'react';

class Cesium extends React.Component {
    render() {
        return (
            <div className="Lightbox">
                <div className="Cesium">
                    <iframe 
                        src="https://space-cowboys-sat-view.glitch.me/" 
                        width="800" 
                        height="600"></iframe>
                </div>
            </div>            
        )
    }
}

export default Cesium;