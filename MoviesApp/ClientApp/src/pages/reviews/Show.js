import React, { Component } from 'react';
import Review from '../../components/Review';
import { Card, CardBody, Button, Col } from 'reactstrap';

export default class Reviews extends Component {
    static displayName = Reviews.name;

    constructor(props) {
        super(props);
        this.state = {movie: this.props.location.state.movie};
    }

    render() {
        const movie = this.state.movie;

        if(movie.reviews.$values.length == 0) {
            return <h1>No reviews yet</h1>
        }

        return (
            <>
                {
                    movie.reviews.$values.map((review, index) => {
                        return(
                            <Col xs={12}>
                                <Card>
                                    <CardBody>
                                        <Review key={index} review={review} />
                                        <Button onClick={() => this.deleteLocalReview(review, index)} color="danger">Delete</Button>
                                    </CardBody>
                                </Card>
                            </Col>
                        );
                    })
                }
            </>
        )
    }

    deleteLocalReview(review, index) {
        const movie = this.state.movie;
        movie.reviews.$values.splice(index, 1);
        this.deleteReview(review);
        this.setState({movie: movie});
    }

    async deleteReview(review) {
        const movie = this.state.movie;
        fetch(process.env.REACT_APP_API + `movies/${movie.id}/reviews/${review.id}`, {method: 'DELETE'})
        .catch((error) => {
            console.error(`Failed to delete review with the id: ${review.id}`);
            console.error(`Error message: ${error}`);
        });
    }
}
