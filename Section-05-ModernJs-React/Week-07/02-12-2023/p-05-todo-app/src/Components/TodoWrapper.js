import React, { useState } from 'react'
import TodoForm from './TodoForm';
import { v4 as uuidv4 } from 'uuid';
import Todo from './Todo';
import TodoContainer from './TodoContainer';

const TodoWrapper = () => {
    let [todos, setTodos] = useState([]);

    const addTodo = todo => {
        setTodos([...todos, {
            id:uuidv4(),
            desc: todo,
            completed: false
        }]);
    };
//fonk parametre noktası=()
    const toggleComplete = (id)=>{
       setTodos(
        todos.map((todo)=>todo.id==id ?{...todo, completed: !todo.completed}: todo)
       );
    }
    //turnery if kulandık
// const deletedTaskArray
    
    return (
        <>
            <div className='TodoWrapper'>
                <h1>FS-2310 Todo App</h1>
                <TodoForm addTodo={addTodo} todos={todos}/>
               {
               todos.map((todo)=>{
                    return<Todo
                        key={todo.id}
                        task={todo}
                        toggelComplete={toggleComplete}
                    />
                })
               }
            
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
//dönrüreleck her bir elemana key //durumunu değiştirme =toggel la yapılır


// gereken ilk olrak neyin ne olduğunu anlmak,fonk mantığını otturmak.