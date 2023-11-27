import React from "react";
import { AuthenticatedTemplate, UnauthenticatedTemplate, useMsal } from '@azure/msal-react';
import { loginRequest } from 'src/authConfig';
import { Button } from 'react-bootstrap';
import "src/Shared/Components/SideBar/sideBar.scss"
import SidebarHeader from "src/Shared/Components/SideBar/SidebarHeader/SidebarHeader";
import SidebarContent from "src/Shared/Components/SideBar/SidebarContent/SidebarContent";

function Sidebar(props: any): JSX.Element {
    
    const { instance } = useMsal();

    const handleLoginRedirect = () => {
        instance.loginRedirect(loginRequest).catch((error) => console.log(error));
    };

    const handleLogoutRedirect = () => {
        instance.logoutRedirect().catch((error) => console.log(error));
    };

    return(
        <div className="sideBar">
           <SidebarHeader>

           </SidebarHeader>
           <SidebarContent>

            </SidebarContent>
            <div className="bottom">
            <AuthenticatedTemplate>
                    <div>
                        <Button variant="warning" onClick={handleLogoutRedirect}>
                            Sign out
                        </Button>
                    </div>
                </AuthenticatedTemplate>
                <UnauthenticatedTemplate>
                    <div>
                        <Button onClick={handleLoginRedirect}>Sign in</Button>
                    </div>
                </UnauthenticatedTemplate>
            </div>
        </div>
    );

}

export default Sidebar;