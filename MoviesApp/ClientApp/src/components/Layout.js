import React, { Component } from 'react';
import { Container, Row } from 'reactstrap';
import { NavMenu } from './NavMenu';

export class Layout extends Component {
  static displayName = Layout.name;

  render () {
    return (
      <div>
        <NavMenu />
        <Container>
          <Row>
            {this.props.children}
          </Row>
        </Container>
      </div>
    );
  }
}
