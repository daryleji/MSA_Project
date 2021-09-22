import React from "react";
import MenuIcon from "@material-ui/icons/Menu";
import { AppBar, IconButton, Toolbar } from "@material-ui/core";
import { Button, Typography } from "@material-ui/core";
import { SubmitForm } from './components/SubmitForm/SubmitForm';
import MSAHeader from './components/MSAHeader/MSAHeader';
import { Footer } from './components/MSAFooter/MSAFooter';
import { gql } from '@apollo/client';
import { HomePage } from "./Pages/HomePage";
import { SubmitPage } from "./Pages/SubmitPage";
import { Route, Switch } from 'react-router';
import ReactDOM from "react-dom";
import { BrowserRouter } from "react-router-dom";


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
    <div className="App">
      <MSAHeader />
      <Switch>
        <Route path="/home" component={HomePage} />
        <Route path="/submit" component={SubmitPage} />
      </Switch>
      <Footer />
    </div>
  );
}

export default App;