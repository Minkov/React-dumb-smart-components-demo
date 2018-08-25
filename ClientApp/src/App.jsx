import React, { Component } from 'react';
import { Route } from 'react-router';
import { Home } from './components/home';
import { CreateTodo } from './components/create';

export default class App extends Component {
  displayName = App.name

  render() {
    return (
      <div>
        <Route exact path='/' component={Home} />
        <Route exact path='/create' component={CreateTodo} />
      </div>
    );
  }
}
