import React from 'react';
import { useHistory } from 'react-router-dom';
import { IUserInfo } from '../../interfaces/userinfo';

export const CreateUser: React.FC<{response:IUserInfo}> = (props) => {
    const history = useHistory();
    const navigateToCreateUserPage = () => {
        history.push('/newuser', {response: props.response} );
    }
    return(
    <div>
        <button className="btn waves-effect waves-light" onClick= { () => navigateToCreateUserPage()}> create new user</button>
    </div>)};