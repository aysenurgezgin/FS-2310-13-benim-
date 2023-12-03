import './App.css';
import TodoWrapper from './Components/TodoWrapper';
import { v4 as idGenerate } from 'uuid';

const INITIAL_STATE = [
  { id: idGenerate(), desc: "Ayşe Nuru aramayı unutma!", isCompleted: false, isEditing: false },
  { id: idGenerate(), desc: "Sinemaya git", isCompleted: false, isEditing: false },
  { id: idGenerate(), desc: "Feyyazı ara", isCompleted: false, isEditing: false },
  { id: idGenerate(), desc: "Gibi", isCompleted: false, isEditing: false },
  { id: idGenerate(), desc: "Js konferansını unutma!", isCompleted: false, isEditing: false }
];

function App() {
  
  return (
    <>
      <TodoWrapper tasks={INITIAL_STATE} />
    </>
  );
}

export default App;
//bildiklerini kullanabilmek önemli olan.