import React from 'react';
import './content.scss';
import {
  createBrowserRouter,
  RouterProvider,
} from "react-router-dom";

const router = createBrowserRouter([
    {
      path: "/",
      element: <div>Hello world!</div>,
    },
    {
        path: "/wifi",
        element: <div>Hello wifi!</div>,
      },
  ]);

function Content(): JSX.Element {
    return(
        <div className='content'>
            <RouterProvider router={router} />
        </div>
    );
}

export default Content;