import React from 'react';
import Sidebar from './Components/SideBar/Sidebar'
import Content from './Components/Content/Content';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import './Styling/App.scss';

function App(): JSX.Element {
  return (
    <div className="App">
      <BrowserRouter>
        <div className='left'>
          <Sidebar></Sidebar>
        </div>
        <div className='right'>
          <Content>
            <Routes>
              <Route path='/' />
            </Routes>
          </Content>
        </div>
      </BrowserRouter>
    </div>
  );
}

export default App;
