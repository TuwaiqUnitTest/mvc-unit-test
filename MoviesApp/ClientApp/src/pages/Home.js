import React, { Component } from 'react';
import Movie from '../components/Movie';

export default class Home extends Component {
    static displayName = Home.name;

    constructor(props) {
        super(props);
        this.state = { movies: [], loading: true };
    }
    
    componentDidMount() {
        this.populateTopMovies();
    }

    static renderTopTenMovies(movies) {
        return (
            <>
                {
                    movies.map((movie, index) =>
                        <Movie key={index} movie={{name: movie.name, coverURL: movie.coverURL, rating: movie.rating}} />
                    )
                }
            </>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Home.renderTopTenMovies(this.state.movies);
        
        return (
            <>
                <div className="row w-100">
                    <h1 className="w-100 text-center">Browse Movies</h1>
                </div>
                <div className="row">
                    {contents}
                </div>
            </>
        )
    }

    async populateTopMovies() {
        const response = await fetch(process.env.REACT_APP_API + 'movies');
        const data = await response.json();
        this.setState({ movies: data.$values, loading: false });
    }
}
