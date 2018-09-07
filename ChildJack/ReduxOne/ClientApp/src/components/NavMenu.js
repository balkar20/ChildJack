import React from 'react';
import { Link } from 'react-router-dom';
import { Glyphicon, Nav, Navbar, NavItem } from 'react-bootstrap';
import { LinkContainer } from 'react-router-bootstrap';
import './NavMenu.css';
import {css} from "aphrodite";
import styles from "../styles/NavStyle";





export default class NavMenu extends React.Component{
    render(){
        return(
        <Navbar className={css(styles.navbarCollapse)} inverse collapseOnSelect>
        <Navbar.Collapse className={css(styles.container)}>
            <Nav >
                <LinkContainer to={'/'} exact>
                    <NavItem className={css(styles.li)}>
                        <Glyphicon glyph='home' /> Home
          </NavItem>
                </LinkContainer>
                <LinkContainer to={'/counter'}>
                    <NavItem className={css(styles.li)}>
                        <Glyphicon glyph='education' /> Counter
          </NavItem>
                </LinkContainer>
                <LinkContainer to={'/fetchdata'}>
                    <NavItem className={css(styles.li)}>
                        <Glyphicon glyph='th-list' /> Fetch data
          </NavItem>
                </LinkContainer>
                <LinkContainer to={'/fetchuserdata'}>
                    <NavItem className={css(styles.li)}>
                        <Glyphicon glyph='th-list' /> User data
                    </NavItem>
                </LinkContainer>
            </Nav>
        </Navbar.Collapse>
        <Navbar.Toggle />
    </Navbar>)
        
    }
}
