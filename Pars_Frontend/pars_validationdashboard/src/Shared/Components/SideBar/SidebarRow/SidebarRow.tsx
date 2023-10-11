import React, { ReactElement } from "react";
import './sidebar-row.scss'
import SidebarIcon from "../SidbarIcon/SidebarIcon";
import { IconProps } from "@mui/material";

type SidebarRowPros = {
    readonly rowText: string;
    readonly icon: ReactElement<IconProps>;
    readonly link: string;
    readonly header: boolean
};

function SidebarRow({header = false, link, rowText, icon}: SidebarRowPros): JSX.Element {
    return(
        <div>
            <SidebarIcon header={header} link={link} icon={icon}>
                <h3>
                    {rowText}
                </h3>
            </SidebarIcon>
        </div>
    );
}

export default SidebarRow;