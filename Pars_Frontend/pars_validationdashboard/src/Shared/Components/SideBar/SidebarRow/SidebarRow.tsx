import React, { ReactElement } from "react";
import "src/Shared/Components/SideBar/SidebarRow/sidebar-row.scss"
import SidebarIcon from "src/Shared/Components/SideBar/SidebarIcon/SidebarIcon";
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