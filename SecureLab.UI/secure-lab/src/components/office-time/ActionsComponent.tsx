import React from 'react'
import axios from 'axios'
import { IUserInfo } from '../../interfaces/userinfo';

const actions: any[] = [
  {
    room : 'Главный корпус (Вход, Выход, Коридор)',
    number: '1',
    timestamp : '2020-06-12 14:45:00'
  },
  {
    room : 'Столовая',
    number: '134',
    timestamp : '2020-06-12 14:48:32'
  },
  {
    room : 'Главный корпус (Вход, Выход, Коридор)',
    number : '1',
    timestamp : '2020-06-12 14:55:40'
  },
  {
    room : 'Аудитория для практических занятий',
    number : '138',
    timestamp : '2020-06-12 15:00:18'
  },
  {
    room : 'Главный корпус (Вход, Выход, Коридор)',
    number : '1',
    timestamp : '2020-06-12 16:35:02'
  },
];

export const Actions: React.FC< {userInfo:IUserInfo} > = (props) => {

  const msToTime = (s:any): string => {
    let ms = s % 1000;
    s = (s - ms) / 1000;
    let secs = s % 60;
    s = (s - secs) / 60;
    let mins = s % 60;
    let hrs = (s - mins) / 60;
  
    return hrs + ':' + mins + ':' + secs + '.' + ms;
  }

  return (
    <div className="attendence-table z-depth-1">
      <table className="highlight centered">
          <thead className="teal lighten-2">
            <tr className="white-text">
                <th>Action</th>
                <th>Duration</th>
            </tr>
          </thead>

          <tbody>
          { 
            actions.map((item, index) => (
            <tr>
              <td>
                 <span style={{fontWeight: "bold"}}>{item.number}</span> - {item.room}  —  <span style={{fontWeight: "bold"}}>{actions[index + 1]?.number}</span> - {actions[index + 1]?.room}
              </td>
            <td>
              { msToTime( Math.abs( Date.parse(actions[index + 1]?.timestamp)  - Date.parse(item.timestamp)))
            }</td>
            </tr>))
          }
          </tbody>
      </table>
    </div>);
}

// const getUserActions = async() =>  {
//   const actions =
//     await axios.get("https://localhost:44329/actions",  
//       { headers: 
//           { 
//               'Accept': 'application/json',
//               'Content-Type': 'application/json', 
//               'Access-Control-Allow-Origin' : '*' 
//           },
//           data: {'id}
//       });
// };