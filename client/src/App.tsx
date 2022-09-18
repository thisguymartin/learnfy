import {
  Switch,
  Route,
} from "react-router-dom";

import Homepage from './pages/HomePage'
import LoginPage from './pages/Login'
import DetailPage from './pages/DetailPage'


import './sass/main.scss';
import 'antd/dist/antd.css';

import Navigation from "./components/Navigation";

function App() {
  return (
    <>
      <Navigation />
      <Switch>
        <Route exact path="/" component={Homepage} />
        <Route exact path="/login" component={LoginPage} />
        <Route exact path="/detail" component={DetailPage} />
      </Switch>
    </>
  );
}

export default App;
