import React from "react";
import 'src/Shared/Components/Content/Pages/Example/example.scss';
import first from 'src/Shared/Components/Content/Pages/Example/first.png'
//To create a new page create a new tsx file, and link it in both App.tsx, and SidebarContent.tsx
function Example(): JSX.Element {
    return(
        <div className='example'>
            <h1>Example</h1>
            <img src= {first} alt="example"/>
        </div>
    );
}

export default Example;