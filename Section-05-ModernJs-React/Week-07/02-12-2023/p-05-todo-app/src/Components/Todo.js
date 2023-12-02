import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faPenToSquare, faTrash } from '@fortawesome/free-solid-svg-icons';
import React from "react";

const Todo = ({ task, toggleComplete }) => {
  // console.log(toggleComplete)
  return (
    <>
      <div className='Todo'>
        <p onClick={()=> { toggleComplete(task.id) }} className={task.completed ? "Complated":"TodoTask"}>
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

// ilk olarak arrow fonk yazıyoruz.(rfca)divi çeirmek mecbur olduğumuz birşey değil
//componentsi prop oluyor
//tek tek ne anlama geldiklrini yaz