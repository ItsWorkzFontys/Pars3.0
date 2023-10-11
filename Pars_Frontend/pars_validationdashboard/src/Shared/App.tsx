import React from 'react';
import Sidebar from './Components/SideBar/Sidebar'
import Content from './Components/Content/Content';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import './Styling/App.scss';
import Example from './Components/Content/Pages/Example/Example';
import Dashboard from './Components/Content/Pages/Dashboard/Dashboard';

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
              <Route path='/' element={<Dashboard />} />
              <Route path='/example' element={<Example />} />
            </Routes>
          </Content>
        </div>
      </BrowserRouter>
    </div>
  );
}

export default App;
