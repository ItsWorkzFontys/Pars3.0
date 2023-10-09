import React from "react";
import './sidebar.scss'
import SidebarHeader from "./SidebarHeader/SidebarHeader";
import SidebarContent from "./SidebarContent/SidebarContent";

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