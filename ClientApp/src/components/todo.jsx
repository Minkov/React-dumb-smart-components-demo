import React, { Component } from 'react';

const Todo = (props) => (
    <div>
        <h1>{props.title}</h1>
        <label>
            <input type="checkbox"
                checked={props.isDone}
                value={props.id}
                onChange={props.onTodoStateChanged} />
            Click
        </label>
    </div>
)



export { Todo };