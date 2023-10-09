import React from 'react';
import Sidebar from './Components/SideBar/Sidebar'
import Content from './Components/Content/Content';
import './Styling/App.scss';

function App(): JSX.Element {
  return (
    <div className="App">
      <div className='left'>
        <Sidebar></Sidebar>
      </div>
      <div className='right'>
        <Content></Content>
      </div>
    </div>
  );
}

export default App;
