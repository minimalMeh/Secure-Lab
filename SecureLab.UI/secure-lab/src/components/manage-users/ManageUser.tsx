import React from 'react' 
import TextField from '@material-ui/core/TextField';
import Autocomplete from '@material-ui/lab/Autocomplete';


const friendOptions = [
    {
      key: 'Jenny Hess',
      text: 'Олександра Носова (olexandra.nosova@nure.ua)',
      value: 'Jenny Hess',
    },
    {
      key: 'Elliot Fu',
      text: 'Elliot Fu',
      value: 'Elliot Fu',
    },
    {
      key: 'Stevie Feliciano',
      text: 'Stevie Feliciano',
      value: 'Stevie Feliciano',
    },
    {
      key: 'Christian',
      text: 'Christian',
      value: 'Christian',
    },
    {
      key: 'Matt',
      text: 'Matt',
      value: 'Matt',
    },
    {
      key: 'Justen Kitsune',
      text: 'Justen Kitsune',
      value: 'Justen Kitsune',
    },
  ]

  


export const ManageUser: React.FC = (props: any) => {
    const roomGroups : any[] = props.location.state.roomGroups;
    const rooms : any[] = props.location.state.rooms;
    const arooms : any[] = 
    [
        {
            "number" : "101и",
            "roomType" : "Лекционная"
        },
        {
            "number" : "102и",
            "roomType" : "Лекционная"
        },
        {
            "number" : "103и",
            "roomType" : "Лекционная"
        },
        {
            "number" : "104и",
            "roomType" : "Лекционная"
        },
        {
            "number" : "105и",
            "roomType" : "Лекционная"
        },
        {
            "number" : "106и",
            "roomType" : "Лекционная"
        },
        {
            "number" : "100и",
            "roomType" : "Столовая"
        }
    ];
    const aroomGroups :any[] = [{"title" : "Лекционные Корпуса І"}];

    const userInfo:any = props.location.state.userinfo;

    return (
        <div className="main">
            <div className="manage-user_header ">
                <button className="btn waves-effect waves-light">browse attendance</button>
                <button className="btn waves-effect waves-light">change users roles</button>
                <button className="btn waves-effect waves-light">log out</button>
            </div>
            <div className="manage-user_header_userinfo card-panel teal lighten-2">
                Signed in as:  <span>{userInfo.name}</span> ({userInfo.email})
            </div>

            <Autocomplete
            id="combo-box-demo"
            options={friendOptions}
            style={{fontWeight: "bold"}}
            getOptionLabel={(option) => option.text}
            renderInput={(params) => <TextField {...params} label="Select user" variant="outlined" />}
            />

            <div className="tables">
                <div className="table card-panel">
                    <div>available</div>

                    <div style={{display: "flex", listStyleType: "none"}}>
                        
                        <div className="collection with-header ">
                        <li className="collection-header table-header teal">
                            <div>Room Groups</div>
                        </li>

                            {aroomGroups.map( item => (
                                <li key={item.id} className="collection-item">
                                        {item.title}
                                    </li>
                                ))}
                        
                        </div>
                        <div className="collection with-header ">
                        
                        <li className="collection-header table-header teal">
                            <div>Rooms</div>
                        </li>
                        
                            {arooms.map( item => (
                                <li key={item.id} className="collection-item">
                                        <span style={{fontWeight: "bold"}}>{item.number}</span> ( {item.roomType} )
                                </li>
                                ))}
                        
                        </div>
                    </div>
                </div>
                <div className="table card-panel">
                    <div>forbidden</div>

                    <div style={{display: "flex", listStyleType: "none"}}>

                        <div className="collection with-header ">
                        <li className="collection-header table-header teal">
                            <div>Room Groups</div>
                        </li>
                        
                            {roomGroups.map( item => (
                                <li key={item.id} className="collection-item">
                                        {item.title}
                                    </li>
                                ))}
                        
                        </div>
                        <div className="collection with-header ">
                        
                        <li className="collection-header table-header teal">
                            <div>Rooms</div>
                        </li>
                        
                            {rooms.map( item => (
                                <li key={item.id} className="collection-item">
                                    <span style={{fontWeight: "bold"}}>{item.number}</span> ( {item.roomType} )
                                </li>
                                ))}
                        
                        </div>
                    </div>
                </div>        
            </div>
        </div>
    );



    
}