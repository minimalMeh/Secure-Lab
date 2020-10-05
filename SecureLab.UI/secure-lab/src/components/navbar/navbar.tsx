import React from 'react'
import GoogleLogin, { GoogleLoginResponse, GoogleLoginResponseOffline } from 'react-google-login'
import { useHistory } from 'react-router-dom';

export const Navbar: React.FC = () => {
  const history = useHistory();
  
  const responseGoogleSuccess = (response: GoogleLoginResponse|GoogleLoginResponseOffline) => {
    console.log(response);
    history.push('/successlogin', { response: (response as GoogleLoginResponse).profileObj });
  }
  const responseGoogleFailure = (response:GoogleLoginResponse|GoogleLoginResponseOffline) => {
    console.log(response);
    /*TODO:  Add failure page*/ 
  }


  return (
    <nav>
    <div className="nav-wrapper teal lighten-5">
      <div className="sl-margin-left left grey-text text-darken-4">Secure Lab: nure</div>
      <ul className="sl-margin-right right hide-on-med-and-down">
        <li>
        <GoogleLogin clientId="425217572847-ufnatnn3lh8n8ccgedj9r0e1gvoqckc4.apps.googleusercontent.com"
                buttonText="Login"
                onSuccess={responseGoogleSuccess}
                onFailure={responseGoogleFailure}
                cookiePolicy={'single_host_origin'} />
        </li>
      </ul>
    </div>
  </nav>
);
}