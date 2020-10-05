import React from 'react';
import { Placemant } from '../manage-users/placement/Placement';
import { CreateUser } from '../create-user/CreateUser';
import { OfficeTimePage } from '../office-time/OfficeTimeComponent';
import { Actions } from '../office-time/ActionsComponent';


import { IUserInfo } from '../../interfaces/userinfo';

export const AuthorizedPage: React.FC = (props: any) => {
    const response = props.location.state.response as IUserInfo;
  
    return(
    <div>
        <div className="header-create-form teal lighten-5">
            <div className="row s1">
                <img src={response.imageUrl} alt="" className="circle responsive-img col s1 user-icon" />
                <p className="col s10">Signed in as: <span className="user-info blue-text text-darken-4">{response.email}</span></p>
                <div  className="col s10 auth-header">
                    {/* <Placemant userinfo={response}/>
                    <CreateUser response={response}/> */}
                </div>
            </div>
            <div className="attendence">
                <OfficeTimePage />
                <Actions userInfo={response}/>
            </div>
        </div>
    </div>)};