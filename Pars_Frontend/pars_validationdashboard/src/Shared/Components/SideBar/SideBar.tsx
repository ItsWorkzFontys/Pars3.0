import React from "react";
import './sidebar.scss'
import SidebarHeader from "src/Shared/Components/SideBar/SidebarHeader/SidebarHeader";
import SidebarContent from "src/Shared/Components/SideBar/SidebarContent/SidebarContent";

function Sidebar(props:any): JSX.Element {
    return(
        <div className="sideBar">
           <SidebarHeader>

           </SidebarHeader>
           <SidebarContent>

           </SidebarContent>
        </div>
    );

}

export default Sidebar;