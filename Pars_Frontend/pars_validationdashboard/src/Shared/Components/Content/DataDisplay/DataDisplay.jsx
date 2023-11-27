import { Table } from 'react-bootstrap';
import { createClaimsTable } from 'src/Shared/Components/Content/utils/claimUtils';

import 'src/Shared/Components/Content/DataDisplay/data-display.scss';

export const IdTokenData = (props) => {
    const tokenClaims = createClaimsTable(props.idTokenClaims);

    const tableRow = Object.keys(tokenClaims).map((key, index) => {
        return (
            <tr key={key}>
                {tokenClaims[key].map((claimItem) => (
                    <td key={claimItem}>{claimItem}</td>
                ))}
            </tr>
        );
    });
    return (
        
        <div className="data-area-div">
            <div className="data-area-div">
                <Table responsive striped bordered hover>
                <thead>
                        <tr>
                            <th>Claim</th>
                            <th>Value</th>
                            <th>Description</th>
                        </tr>
                    </thead>
                    <tbody>{tableRow}</tbody>
                </Table>
            </div>
        </div>
        
    );
};