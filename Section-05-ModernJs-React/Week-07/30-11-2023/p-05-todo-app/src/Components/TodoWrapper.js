import React, { useState } from 'react'
import TodoForm from './TodoForm';
import { v4 as uuidv4 } from 'uuid';

const TodoWrapper = () => {
    let [todos, setTodos] = useState([]);
    const addTodo = todo => {
       
        setTodos([...todos, {
            id:uuidv4,
            desc: todo,
            completed: false
        }]);
    };
    
    return (
        <>
            <div className='TodoWrapper'>
                <h1>FS-2310 Todo App</h1>
                <TodoForm addTodo={addTodo} />
            
            </div>
        </>
    )
}

export default TodoWrapper;

//uuid den (benzersiz id olusşturabilmek için )
//sunucu
//durdurmak içiç terminali; görev yöneticisince node.js run tine ı durdur
//dev toolusu nasıl kuarbilirş m
//dom mantığın air daha bak!