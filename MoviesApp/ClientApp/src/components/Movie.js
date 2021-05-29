import React, { Component } from 'react'
import { Col, Card, CardImg, CardBody, CardTitle, CardText, Button } from 'reactstrap';
import { Redirect } from "react-router-dom";

export default class Movie extends Component {
    static displayName = Movie.name;

    constructor(props) {
        super(props);
        this.state = { redirect: false };
    }

    render() {
        const movie = this.props.movie;

        if(this.state.redirect) {
            return <Redirect to = {{ pathname: "/Reviews", state: { movie: movie } }} />;
        }

        return (
            <Col xs="4" className="mt-5 text-center">
                <Card>
                    <CardImg top width="100%" src={movie.coverURL} alt="Card image cap" />
                    <CardBody>
                        <CardTitle tag="h5">{movie.name}</CardTitle>
                        <CardText>Rating: {movie.rating}</CardText>
                        <Button onClick={() => this.setState({redirect: true})}>Reviews</Button>
                    </CardBody>
                </Card>
            </Col>
        );
    }
}
