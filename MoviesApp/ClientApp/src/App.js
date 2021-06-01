import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import Home from './pages/Home';
import Top from './pages/Top';
import Reviews from './pages/reviews/Show';
import CreateReview from './pages/reviews/Create';
import EditReview from './pages/reviews/Edit';

import './custom.css';

export default class App extends Component {
  static displayName = App.name;

  render () {
    // add movies
    // delete movies
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/top-movies' component={Top}/>
        <Route path='/reviews' component={Reviews} />
        <Route path='/create-review' component={CreateReview} />
        <Route path='/edit-review' component={EditReview} />
      </Layout>
    );
  }
}
