import React, { useState } from 'react'
import { TodoContext } from '../Contexts/TodoContext';
import TodoAddForm from './TodoAddForm';
import TodoContainer from './TodoContainer';
import { v4 as idGenerate } from 'uuid';

const TodoWrapper = ({ tasks }) => {
    const [taskList, setTaskList] = useState(tasks);

    const addTask = _desc => {
        setTaskList(
            [...taskList, {
                id: idGenerate(),
                desc: _desc,
                isCompleted: false,
                isEditing: false

            }]
        );
            console.log(taskList);
    }

    const toggleComplete = id => {
        setTaskList(
            taskList.map(task => task.id === id ? { ...task, isCompleted: !task.isCompleted } : task)
        );
    }

    const deleteTask= id =>{
        setTaskList(
            taskList.filter(task => task.id != id)
        );
    }
    
    const toggleEditing = id => {
        setTaskList(
            taskList.map(task => task.id === id ? {...task,isEditing: !task.isEditing} : task)
        );
    }

    const upDateTask = (id, _desc) => {
        setTaskList(
            taskList.map(task=>task.id === id ?{...task, desc: _desc, isEditing:!task.isEditing} : task)
        )
    }

    

    return (
        <TodoContext.Provider value={{ taskList, addTask, toggleComplete,deleteTask,toggleEditing,upDateTask }} >
            <div className='container w-50 p-5'></div>
            <TodoAddForm />
            <TodoContainer />

        </TodoContext.Provider>
    )
}

export default TodoWrapper;


// Bir kreye mahsus elle yazıcaz sonra tdodcontex arasına
//js te üc eşittir ne anlama geliyor?= tipini de kontrol et