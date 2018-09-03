import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { Link } from 'react-router-dom';
import { actionCreators } from '../store/UserStore';

class FetchUserData extends Component {
    componentWillMount() {
        this.props.requestUsers();
    }

    componentWillReceiveProps(nextProps) {
        //this.props.requestUsers();
    }

    render() {
        return (
            <div>
            { renderUsersTable(this.props)}
            </div>
            )
    }
}

function renderUsersTable(props) {
    return (
        <table className='table'>
            <thead>
                <tr>
                    <th>Date</th>
                    <th>Temp. (C)</th>

                </tr>
            </thead>
            <tbody>
                {props.users.map(user =>
                    <tr key={user.id}>
                        <td>{user.name}</td>
                        <td>{user.email}</td>
                    </tr>
                )}
            </tbody>
        </table>
    );
}

export default connect(
    state => state.users,
    dispatch => bindActionCreators(actionCreators, dispatch)
)(FetchUserData);