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
        this.props.requestUsers();
    }

    render() {
        return (
            <div>
                <h1>Weather forecast</h1>
                <p>This component demonstrates fetching data from the server and working with URL parameters.</p>
                {renderUsersTable(this.props)}
            </div>
        );
    }
}

function renderUsersTable(props) {
    return (
        <div>props.users.name</div>
    );
}

export default connect(
    state => state.users,
    dispatch => bindActionCreators(actionCreators, dispatch)
    )(FetchUserData);