import React from "react";
import "./App.css";
import MSAHeader from './components/MSAHeader/MSAHeader';
import { Footer } from './components/MSAFooter/MSAFooter';
import { gql } from '@apollo/client';
import { HomePage } from "./Pages/HomePage";
import { SubmitPage } from "./Pages/SubmitPage";
import { Route, Switch } from 'react-router';


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