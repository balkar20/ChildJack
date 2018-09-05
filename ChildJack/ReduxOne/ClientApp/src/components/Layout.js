import React from 'react';
import { Col, Grid, Row, Label } from 'react-bootstrap';
import NavMenu from './NavMenu';
import "./Layout.css";

export default props => (
    <Grid fluid sm={10} lg={10} lgOffset={1} smOffset={1} >

        
        <Row className="headRow">
            <Col sm={4} lg={4} lgOffset={1} smOffset={1}>
              <h1><Label bsClass=''>ChildJack</Label></h1>
            </Col>
            <Col sm={6} lg={6} >OPIiiiiiiiiii</Col>
        </Row>
        <Row >
            <Col className="navCol" sm={10} lg={10} lgOffset={1} smOffset={1} >
                <NavMenu />
            </Col>
        </Row>
        <Row>
            <Col sm={10} lg={10} lgOffset={1} smOffset={1} >
                {props.children}
            </Col>
        </Row>
    </Grid>
);
