// author, content
import React, { Component } from 'react';
import { CardTitle, CardText } from 'reactstrap';

export default class Review extends Component {
    render() {
        const review = this.props.review;
        return (
            <>
                <CardTitle tag="h5">Author: {review.author}</CardTitle>
                <CardText style={{whiteSpace: "pre-wrap"}}>Review: {review.content}</CardText>
            </>
        )
    }
}
