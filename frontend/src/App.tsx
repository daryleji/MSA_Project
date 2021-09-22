import React from "react";
import MenuIcon from "@material-ui/icons/Menu";
import { AppBar, IconButton, Toolbar } from "@material-ui/core";
import { Button, Typography } from "@material-ui/core";
import SubmitForm from './SubmitForm';
import MSAHeader from './Components/MSAHeader';
import { gql } from '@apollo/client';

export const PROJECT = gql`
query {
  Projects {
    nodes {
      name
    }
  }
}
`


function App() {
  return (
    <div>
      <div>
        <MSAHeader/>
      </div>
      <div>
      <SubmitForm/>
      </div>
    </div>
  );
}


export default App;