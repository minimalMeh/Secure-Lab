import React from 'react';
import {WelcomePage} from '../src/components/welcome-page/WelcomePage'
import {CreateUserPage} from './components/create-user/CreateUserPage'
import {ManageUser} from './components/manage-users/ManageUser'
import {BrowserRouter, Switch, Route} from 'react-router-dom'
import { OfficeTimePage } from './components/office-time/OfficeTimeComponent';
import { AuthorizedPage } from './components/authorized-page/AutorizedPageComponent';

const App: React.FC = () => {
    return ( 
    <BrowserRouter>
        <div className="container">
          <Switch>
            <Route component={WelcomePage} path="/" exact/>
            <Route component={AuthorizedPage} path="/successlogin"/>
            <Route component={OfficeTimePage} path="/officetime"/>
            <Route component={CreateUserPage} path="/newuser"/>
            <Route component={ManageUser} path="/manage"/>
          </Switch>
        </div>
  </BrowserRouter>
  );
}

export default App;
