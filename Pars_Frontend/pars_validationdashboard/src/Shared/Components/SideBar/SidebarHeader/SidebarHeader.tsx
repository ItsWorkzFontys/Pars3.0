import React from "react";
import './sidebar-header.scss'
import SidebarRow from "src/Shared/Components/SideBar/SidebarRow/SidebarRow";
import HistoryEduRoundedIcon from '@mui/icons-material/HistoryEduRounded';

function SidebarHeader(props:any): JSX.Element {
    return(
        <header>
            <SidebarRow header={true} link="/" rowText="PARS3.0" icon={<HistoryEduRoundedIcon className="icon-background"/>}/>
        </header>
    );
}

export default SidebarHeader;