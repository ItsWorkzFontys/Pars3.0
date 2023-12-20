import React from 'react';
 import { MsalProvider, AuthenticatedTemplate, UnauthenticatedTemplate } from '@azure/msal-react';
import Sidebar from 'src/Shared/Components/SideBar/SideBar';
import Content from 'src/Shared/Components/Content/Content';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import 'src/Shared/Styling/App.scss';
import Example from 'src/Shared/Components/Content/Pages/Example/Example';
import Dashboard from 'src/Shared/Components/Content/Pages/Dashboard/Dashboard';

const App = ({ instance })  => {
  return (
    <MsalProvider instance={instance}>
      <div className="App">
        <BrowserRouter>
        
          <div className='left'>
                <Sidebar></Sidebar>
            </div>
          
          <div className='right'>
            <AuthenticatedTemplate>
              <Content>
                <Routes>
                  <Route path='/' element={<Dashboard />} />
                  <Route path='/example' element={<Example />} />
                </Routes>
                </Content>
            </AuthenticatedTemplate>
            <UnauthenticatedTemplate>
              Login first
            </UnauthenticatedTemplate>
          </div>
        </BrowserRouter>
      </div>
    </MsalProvider>
 
  );
}

export default App;
