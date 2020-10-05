import React, { useState } from 'react';
import { SingleDatePicker} from 'react-dates';
import moment, { Moment } from 'moment';
import 'react-dates/initialize';
import 'react-dates/lib/css/_datepicker.css';

interface IDate {
    focused: boolean, 
    date: Moment
}

export const OfficeTimePage: React.FC = () => {

    const momen: Moment = moment(new Date());
    const [date, setDate] = useState<IDate>({focused: false, 
        date: momen});
    const isBlocked = (day: Moment) => {
        return day.date() > new Date().getDate();        
    }

    return(
    <div className="attendence-calendar">
        <SingleDatePicker
            showDefaultInputIcon={true}
            orientation="vertical"
            daySize={40}
            isDayBlocked={isBlocked}
            verticalHeight={420}
            isOutsideRange={() => false}
            date={date.date} // momentPropTypes.momentObj or null
            onDateChange={dat => setDate( {date: dat as Moment, focused: date.focused} )} // PropTypes.func.isRequired
            focused={date.focused} // PropTypes.bool
            onFocusChange={({ focused }) => setDate({date: date.date, focused: focused as boolean})} // PropTypes.func.isRequired
            id="your_unique_id" // PropTypes.string.isRequired,
            />
    </div>)};