// author, content
import React, { Component } from 'react';
import { Col } from 'reactstrap'

export default class Review extends Component {
    render() {
        const review = this.props.review;
        return (
            <Col xs={12}>
                <h2>{review.author}</h2>
                <p>{review.content}</p>
            </Col>
        )
    }
}
