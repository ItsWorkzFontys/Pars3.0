import React from "react";
import './example.scss';

//To create a new page create a new tsx file, and link it in both App.tsx, and SidebarContent.tsx
function Example(): JSX.Element {
    return(
        <div className='example'>
            this an example
        </div>
    );
}

export default Example;