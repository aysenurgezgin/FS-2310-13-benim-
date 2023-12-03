import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPenToSquare, faTrash } from '@fortawesome/free-solid-svg-icons';
import React from 'react';

const Todo = ({ task, toggleComplete }) => {
  return (
    <>
      <div className='Todo'>
        <p onClick={() => { toggleComplete(task.id) }} className={task.completed ? "Completed TodoTask" : "TodoTask"}>
          {task.desc}
        </p>
        <div className='TodoButtons'>
          <FontAwesomeIcon icon={faPenToSquare} />
          <FontAwesomeIcon icon={faTrash} />
        </div>
      </div>
    </>
  )
}

export default Todo;











// import React, { useState } from 'react'

// const TodoForm = ({ addTodo, todos }) => {
//   const [value, setValue]=useState ("");

//   const handleSubmit=(e)=>{
//     e.preventDefault();
//     if(value){
//       addTodo(value);
//       setValue("");
//     }
//     console.log(todos);
    //todos dizizi ekllemek için buraya hemde props denemsi yapalıM;

//   }

//   return (
//    <>
//    <form onSubmit={handleSubmit} className='TodoForm'>
//     <input onChange={(e)=>{setValue(e.target.value)}} type="text" className='TodoInput' value={value} placeholder='What is the task today?' />
//     <button type='submit' className='TodoBtn'>Add Task</button>
//    </form>
//    </>
//   )
// }

// export default TodoForm;
//set valunun kullanım mantığı tam anlamıyla oturtman gerekiyor.state nin espir o input u rander etemesi gerekiyor
//submit bu işin yapılmasını sağlıyor.form kullanma nedeni form için de submit şeklide buton olunca
// butun subit olunca çalıştırması gereken handle submit çalıştırılan fonk