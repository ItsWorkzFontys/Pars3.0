import React, { ReactNode, ReactElement } from "react";
import './sidebar-icon.scss';
import { IconProps } from "@mui/material";

type SidebarIconProps = {
    children: ReactNode;
    icon: ReactElement<IconProps>;
    link: string;
    header: boolean;
};

function SidebarIcon({header, link, children, icon}: SidebarIconProps): JSX.Element {
    return(
        <div className={header? "sidebar-row-icon header-icon" : "sidebar-row-icon"}
        >
            {icon}
            {children}
        </div>
    );
}

export default SidebarIcon;