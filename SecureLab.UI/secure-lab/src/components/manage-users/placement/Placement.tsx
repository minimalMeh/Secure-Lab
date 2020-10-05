import React from 'react'
import axios from 'axios'
import { useHistory } from 'react-router-dom'
import { IUserInfo } from '../../../interfaces/userinfo'


export const Placemant: React.FC< { userinfo:IUserInfo } > = (props) => {
    console.log(props.userinfo);
    const history = useHistory();
    const getRoomGroups = async() =>  {
        const roomGroups =
          await axios.get("https://localhost:44329/roomgroup",  
            { headers: 
                { 
                    'Accept': 'application/json',
                    'Content-Type': 'application/json', 
                    'Access-Control-Allow-Origin' : '*' 
                }
            });
        const rooms =  await axios.get("https://localhost:44329/room",  
        { headers: 
            { 
                'Accept': 'application/json',
                'Content-Type': 'application/json', 
                'Access-Control-Allow-Origin' : '*' 
            }
        });
        console.log(rooms);
        history.push('/manage', { rooms: rooms.data, roomGroups: roomGroups.data, userinfo: props.userinfo} );
    };

    return (
    <div>
        <button className="btn waves-effect waves-light" onClick= { () => getRoomGroups()}> change users roles</button>
    </div>
    );
};
