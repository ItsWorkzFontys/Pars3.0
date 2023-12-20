import React, { ReactNode, ReactElement } from "react";
import "src/Shared/Components/SideBar/SidebarIcon/sidebar-icon.scss";
import { IconProps } from "@mui/material";
import { NavLink } from 'react-router-dom'

type SidebarIconProps = {
    readonly children: ReactNode;
    readonly icon: ReactElement<IconProps>;
    readonly link: string;
    readonly header: boolean;
};

function SidebarIcon({header, link, children, icon}: SidebarIconProps): JSX.Element {
    return(
        <NavLink to={link} className={
            ({isActive}) => {
                let __class = "sidebar-row-icon"
                __class += isActive && !header ? " active" : "";
                __class += header ? " header-icon" : ""
                return __class;
                }
             }
        >
            {icon}
            {children}
        </NavLink>
    );
}

export default SidebarIcon;