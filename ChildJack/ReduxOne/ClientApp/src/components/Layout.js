import React from 'react';
import { Col, Grid, Row, Label } from 'react-bootstrap';
import NavMenu from './NavMenu';
import "./Layout.css";
import UserCard from "./UserCard"; 

export default props => (
    <Grid fluid sm={10} lg={10} lgOffset={1} smOffset={1} >
        <Row className="headRow">
            <Col sm={4} lg={4} lgOffset={1} smOffset={1}>
              <h1><Label bsClass=''>ChildJack</Label></h1>
            </Col>
            <Col lgOffset={2} smOffset={2}  sm={2} lg={2} >
              <UserCard/>
            </Col>
        </Row>
        <Row >
            <Col className="navCol" sm={10} lg={10} lgOffset={1} smOffset={1} >
                <NavMenu/>
            </Col>
        </Row>
        <Row>
            <Col sm={10} lg={10} lgOffset={1} smOffset={1} >
                {props.children}
            </Col>
            <Col sm={10} lg={10} lgOffset={1} smOffset={1} >
            
            </Col>
        </Row>
    </Grid>
);
