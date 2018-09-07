import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import { Glyphicon, Nav, Navbar, NavItem } from 'react-bootstrap';
import { LinkContainer } from 'react-router-bootstrap';
import { actionCreators } from '../store/User';
import { bindActionCreators } from 'redux';
import { css } from "aphrodite";
import connect from 'react-redux/lib/connect/connect';
import styles from "../styles/UserCartStyle";

class UserCard extends React.Component {

    componentDidMount() {
        // This method runs when the component is first added to the page
        const id = 2;
        this.props.requestUser(id);
    }

    render() {
        return (<div className={css(styles.frame)}>
            <span className={css(styles.text)} color='blue'>{this.props.user.name}</span>
        </div>)
    }
}


export default connect(
    state => state.user,
    dispatch => bindActionCreators(actionCreators, dispatch)
)(UserCard)