import React from "react";
import MSAHeader from './components/MSAHeader/MSAHeader';
import { Footer } from './components/MSAFooter/MSAFooter';
import { HomePage } from "./Pages/HomePage";
import { SubmitPage } from "./Pages/SubmitPage";
import { Route, Switch } from 'react-router';
import ReactDOM from "react-dom";
import { BrowserRouter } from "react-router-dom";


function App() {
  return (
    <div className="App">
      <MSAHeader />
      <Footer />
    </div>
  );
}

export default App;