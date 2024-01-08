import React from "react";
import 'src/Shared/Components/Content/Pages/Dashboard/dashboard.scss';
import { IdTokenData } from "src/Shared/Components/Content/DataDisplay/DataDisplay";
import { Container, Button } from 'react-bootstrap';
import { useMsal } from '@azure/msal-react';

function Dashboard(): JSX.Element {

    const { instance } = useMsal();
    const activeAccount = instance.getActiveAccount();

    return(
        <div className='dashboard'>
            <h1>Dashboard</h1>
             {activeAccount ? (
                     <Container>
                         <IdTokenData idTokenClaims={activeAccount.idTokenClaims} />
                     </Container>
                 ) : null}
            
        </div>
    );
}

export default Dashboard;