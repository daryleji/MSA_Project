import React from "react";
import MenuIcon from "@material-ui/icons/Menu";
import { AppBar, IconButton, Toolbar } from "@material-ui/core";
import { Button, Typography } from "@material-ui/core";
import { SubmitForm } from './components/SubmitForm/SubmitForm';
import MSAHeader from './components/MSAHeader/MSAHeader';
import { Footer } from './components/MSAFooter/MSAFooter';
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
      <div>
        <Footer/>
      </div>
    </div>
  );
}

export default App;