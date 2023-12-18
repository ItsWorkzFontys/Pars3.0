import React from 'react';
import Sidebar from 'src/Shared/Components/SideBar/SideBar';
import Content from 'src/Shared/Components/Content/Content';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import 'src/Shared/Styling/App.scss';
import Example from 'src/Shared/Components/Content/Pages/Example/Example';
import Dashboard from 'src/Shared/Components/Content/Pages/Dashboard/Dashboard';
import Settings from 'src/Shared/Components/Content/Pages/Settings/Settings';

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
              <Route path='/settings' element={<Settings />} />
            </Routes>
          </Content>
        </div>
      </BrowserRouter>
    </div>
  );
}

export default App;
