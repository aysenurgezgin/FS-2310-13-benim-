import React from 'react'
import Todo from './Todo'
const TodoContainer = ({ todos, toggleComplete }) => {
    return (
        <>
            {
                todos.map((todo) => {
                    return <Todo
                        key={todo.id}
                        task={todo}
                        toggleComplete={toggleComplete}
                    />
                })
            }
        </>
    )
}

export default TodoContainer