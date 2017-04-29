import React from 'react';
import ReactDOM from 'react-dom';
import App from './App';
import './index.css';

const CESIUM_BASE_URL = '/static/'

ReactDOM.render(
  <App />,
  document.getElementById('root')
);

export {CESIUM_BASE_URL};
