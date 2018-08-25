import React, { Component } from 'react';
import { Todo } from './todo';

class Home extends Component {
    constructor(props) {
        super(props);
        this.state = {
            todos: [{
                title: 'Wash the dishes',
                todoState: 'Done'
            }]
        };

        this.onTodoStateChanged = this.onTodoStateChanged.bind(this);
    }

    async componentDidMount() {
        const todosResponse = await fetch("/api/todos");
        const todos = await todosResponse.json();

        this.setState({
            todos
        });
    }

    async updateTodo(todoId) {
        await fetch(`/api/todos/${todoId}`, {
            method: 'PUT',
        });
        const todos = this.state.todos;
        const theTodo = todos.find(todo => todo.id === +todoId);
        theTodo.isDone = !theTodo.isDone;
        this.setState({ todos });
    }

    onTodoStateChanged(ev) {
        const todoId = ev.target.value;
        console.log(todoId);
        this.updateTodo(todoId);
    }

    renderTodos() {
        return this.state.todos.map(
            todo => (
                <Todo {...todo}
                    key={todo.id}
                    onTodoStateChanged={this.onTodoStateChanged}
                />
            )
        );
    }

    render() {
        return (
            <div>
                {this.renderTodos()}
            </div>
        );
    }
}

export { Home };