import React from "react";
import "src/Shared/Components/SideBar/SidebarContent/sidebar-content.scss"
import SidebarRow from "src/Shared/Components/SideBar/SidebarRow/SidebarRow";
import DashboardIcon from '@mui/icons-material/Dashboard';
import LiveHelpIcon from '@mui/icons-material/LiveHelp';
import SettingsIcon from '@mui/icons-material/Settings';

function SidebarContent(props:any): JSX.Element {
    return(
        <div>
            <SidebarRow header={false} link="/" rowText="Dashboard" icon={<DashboardIcon inheritViewBox={true} className="icon"/>}/>
            <SidebarRow header={false} link="/example" rowText="Example" icon={<LiveHelpIcon  className="icon"/>}/>
            <SidebarRow header={false} link="/settings" rowText="Settings" icon={<SettingsIcon  className="icon"/>}/>
        </div>
    );

}

export default SidebarContent;