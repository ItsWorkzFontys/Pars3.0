import React from "react";
import './sidebar-content.scss'
import SidebarRow from "../SidebarRow/SidebarRow";
import DashboardIcon from '@mui/icons-material/Dashboard';
import LiveHelpIcon from '@mui/icons-material/LiveHelp';

function SidebarContent(props:any): JSX.Element {
    return(
        <div>
            <SidebarRow header={false} link="/" rowText="Dashboard" icon={<DashboardIcon inheritViewBox={true} className="icon"/>}/>
            <SidebarRow header={false} link="/example" rowText="Example" icon={<LiveHelpIcon  className="icon"/>}/>
        </div>
    );

}

export default SidebarContent;