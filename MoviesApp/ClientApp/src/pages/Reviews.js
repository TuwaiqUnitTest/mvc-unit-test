import React, { Component } from 'react';
import Review from '../components/Review'

export default class Reviews extends Component {
    static displayName = Reviews.name;

    render() {
        const movie = this.props.location.state.movie;

        if(movie.reviews.$values.length == 0) {
            return <h1>No reviews yet</h1>
        }

        return (
            <>
                {
                    movie.reviews.$values.map((review, index) =>
                        <Review key={index} review={review} />
                    )
                }
            </>
        )
    }
}
