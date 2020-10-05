import React from 'react'

export const CreateUserPage: React.FC = () => 
{
  return (
  <div>
    <div className="section input-panel">
      <h5>Register User in the system</h5>
      <p>As soon as you add a user here, contact the system administrator to bind the unique key card of the new user to his personal data.</p>
    </div>
  <div className="divider"></div>
    <div className="row input-panel">
    <form className="col s12">
      <div className="row">
        <div className="input-field col s6">
          <i className="material-icons prefix">account_circle</i>
          <input placeholder="Full Name." id="username" type="text" className="validate"/>
        </div>
        <div className="input-field col s6">
          <i className="material-icons prefix">phone</i>
            <input placeholder="Phone number." id="phonenumber" type="text" className="validate"/>
        </div>
      </div>
      <div className="row">
        <div className="input-field col s6">
          <i className="material-icons prefix">send</i>
          <input placeholder="Email." id="email" type="email" className="validate"/>
        </div>
        <div className="input-field col s12">
          <i className="material-icons prefix">mode_edit</i>
          <textarea placeholder="Please enter additional information about person." id="info" data-length="120" className="materialize-textarea"/>
        </div>
      </div>
      <button className="btn waves-effect waves-light input-panel" type="submit" name="action">Submit
        <i className="material-icons right">send</i>
      </button>
    </form>
  </div>
  </div>
);
}