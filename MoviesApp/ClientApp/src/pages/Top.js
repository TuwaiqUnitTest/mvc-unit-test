import React, { Component } from 'react'
import Movie from '../components/Movie'

export default class Top extends Component {
    static displayName = Top.name;

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
            : Top.renderTopTenMovies(this.state.movies);
        
        return (
            <>
                <div style={{textAlign: 'center'}}>
                    <h1>Top 10 movies</h1>
                </div>
                {contents}
            </>
        )
    }

    async populateTopMovies() {
        const response = await fetch('movies?top=true');
        const data = await response.json();
        console.log(data.$values);
        this.setState({ movies: data.$values, loading: false });
    }
}
