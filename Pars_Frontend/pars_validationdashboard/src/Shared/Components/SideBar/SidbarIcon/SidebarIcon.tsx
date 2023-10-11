import React, { ReactNode, ReactElement } from "react";
import './sidebar-icon.scss';
import { IconProps } from "@mui/material";
import { NavLink } from 'react-router-dom'

type SidebarIconProps = {
    children: ReactNode;
    icon: ReactElement<IconProps>;
    link: string;
    header: boolean;
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