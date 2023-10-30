import React from "react";
import Second from 'src/Shared/Components/Content/Pages/Dashboard/Second.png';
import 'src/Shared/Components/Content/Pages/Dashboard/dashboard.scss';

function Dashboard(): JSX.Element {
    return(
        <div className='dashboard'>
            <h1>Dashboard</h1>
            <img src= {Second} alt="example"/>
        </div>
    );
}

export default Dashboard;