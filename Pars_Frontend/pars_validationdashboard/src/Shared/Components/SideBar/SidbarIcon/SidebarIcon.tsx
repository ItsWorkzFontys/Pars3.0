import React, { ReactNode, ReactElement } from "react";
import './sidebar-icon.scss';
import { IconProps } from "@mui/material";
import { Link } from 'react-router-dom'

type SidebarIconProps = {
    children: ReactNode;
    icon: ReactElement<IconProps>;
    link: string;
    header: boolean;
};

function SidebarIcon({header, link, children, icon}: SidebarIconProps): JSX.Element {
    return(
        <Link to={link} className={header? "sidebar-row-icon header-icon" : "sidebar-row-icon"}
        >
            {icon}
            {children}
        </Link>
    );
}

export default SidebarIcon;