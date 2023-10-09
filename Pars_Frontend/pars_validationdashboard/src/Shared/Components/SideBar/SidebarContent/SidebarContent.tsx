import React from "react";
import './sidebar-content.scss'
import SidebarRow from "../SidebarRow/SidebarRow";
import WifiRoundedIcon from '@mui/icons-material/WifiRounded';
import HomeWorkRoundedIcon from '@mui/icons-material/HomeWorkRounded';

function SidebarContent(props:any): JSX.Element {
    return(
        <div>
            <SidebarRow header={false} link="/" rowText="Klassenlijst" icon={<HomeWorkRoundedIcon inheritViewBox={true} className="icon"/>}/>
            <SidebarRow header={false} link="/wifi" rowText="Wifi" icon={<WifiRoundedIcon  className="icon"/>}/>
        </div>
    );

}

export default SidebarContent;