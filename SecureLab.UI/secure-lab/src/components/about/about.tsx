import React from 'react'

export const About: React.FC = () => (
  <div className="row">
    <div className="card big-card">
    <div className="card-image waves-effect waves-block waves-light">
      <img alt=" fff" className="activator image-logo" src={require('../../welcomepage.png')} />
    </div>
    <div className="card-content">
      <span className="card-title activator grey-text text-darken-4">Secure Lab application<i className="material-icons right">more_vert</i></span>
      <p>Software is an element of the system that converts a set of controllers, readers, sensors and other devices into a functioning network ACS. It depends on the ACS software to a large extent how synchronously and efficiently the system will function. The software is installed on a personal computer and is used to configure the system.
Basic software functions:
- ACS equipment settings;
- setting the rights of system administrators;
- task list of staff;
- definition of access rights for staff;
- reports on the work of the ACS and reports on the movement of personnel through access points;
</p>
<br/>
<p>
Access Control is a system designed to allow companies to stay in charge of their security. With selective access, building access systems allow your premises to appear welcoming while offering maximum protection outside threats and from internal challenges such as shrinkage.

An access control system proactively monitors, manages access and secures multiple of points of entry and exit in real-time, for individuals, vehicles and materials, all from a single location. Door control links to many supporting systems including video and offers full documentation.
</p>

    </div>
    <div className="card-reveal">
      <span className="card-title grey-text text-darken-4">Secure Lab application<i className="material-icons right">close</i></span>
      <p>Software is an element of the system that converts a set of controllers, readers, sensors and other devices into a functioning network ACS. It depends on the ACS software to a large extent how synchronously and efficiently the system will function. The software is installed on a personal computer and is used to configure the system.
Basic software functions:
- ACS equipment settings;
- setting the rights of system administrators;
- task list of staff;
- definition of access rights for staff;
- reports on the work of the ACS and reports on the movement of personnel through access points;</p>
        <img alt=" fff" className="activator" src={require('../../nure.jpg')}/>
    </div>
  </div>
  </div>
            
);