import React, { useContext, useState } from 'react'
import { TodoContext } from '../Contexts/TodoContext';

const TodoAddForm = () => {
    const context = useContext(TodoContext);
    const [desc,setDesc] = useState("");

    const handleSubmit=(e)=>{
        e.preventDefault();
        if(desc){
            context.addTask(desc);
            setDesc("");
            e.target.firstChild.firstChild.focus();
        }else{
            alert("Boş bırakma!")
        }
    }
    return (
        <div className='container-fluid g-0'>
            <h1 className="display-5 text-center mb-5 text-danger">Todo App</h1>
            <form onSubmit={handleSubmit}> 
            {/* //callback fonf */}
            <div className="input-group mb-3">
                <input onChange={(e)=>{ setDesc(e.target.value) }} value={desc} type="text" className="form-control" placeholder="What is the task today?" aria-describedby="button-addon2" />
                <button className="btn btn-outline-success" type="button" id="button-addon2">Add Task</button>
            </div>
            </form>
        </div>
    )
}

export default TodoAddForm;