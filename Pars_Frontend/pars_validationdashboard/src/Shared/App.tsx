import React from 'react';
import Header from './Components/Header/Header'
import SideBar from './Components/SideBar/SideBar';
import Content from './Components/Content/Content';
import './Styling/App.scss';

function App(): JSX.Element {
  return (
    <div className="App">
      <div className='left'>
        <SideBar></SideBar>
      </div>
      <div className='right'>
        <Header></Header>
        
        <Content></Content>
      </div>
    </div>
  );
}

export default App;
