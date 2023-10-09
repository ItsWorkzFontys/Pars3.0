import React from 'react';
import * as ReactDOM from "react-dom/client";
import './Shared/Styling/index.scss';
import App from './Shared/App';
import reportWebVitals from './reportWebVitals';


const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement

);
root.render(
  <React.StrictMode>
    <App />
  </React.StrictMode>
);

reportWebVitals();
