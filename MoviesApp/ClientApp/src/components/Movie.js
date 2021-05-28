import React, { Component } from 'react'
import { Col } from 'reactstrap'

export default class Movie extends Component {
    static displayName = Movie.name;

    render() {
        const movie = this.props.movie;
        return (
            <Col xs="4">
                <h2>{movie.name}</h2>
                <img src={movie.coverURL} alt="movie cover"></img>
                <h3>{movie.rating}</h3>
            </Col>
        )
    }
}
