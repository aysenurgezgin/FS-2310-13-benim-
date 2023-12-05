import React from 'react'
import { TodoContext } from '../Contexts/TodoContext';

const TodoFilter = () => {
    
  return (
    <div className='button'>
        <button className='btn btn-warning' type='submit'id='btn-add-task'>All</button>
        <button className='btn btn-success' type='submit' id='btn-add-task'>True</button>
        <button className='btn btn-warning' type='submit' id='btn-add-task'>False</button>


    </div>
  )
}

export default TodoFilter;