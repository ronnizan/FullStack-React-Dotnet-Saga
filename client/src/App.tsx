import React, { useEffect } from 'react';
import './App.css';
import { useDispatch, useSelector } from 'react-redux';
import { TodosState } from './redux/reducers/todoReducer';
import { Todo } from './redux/types/todosTypes';
import { RootState } from './redux/store';
import { getTodosRequestAction, postTodoRequestAction } from './redux/actions/todosActions';

function App() {
  const dispatch = useDispatch();
  const { todos }: { todos: Todo[] } = useSelector((state: RootState) => state.todos);

  useEffect(() => {
    console.log('asdasd')
    dispatch(getTodosRequestAction());


  }, [])

  return (
    <div className="App">
      <button onClick={() => {
        let todo = { id: 2, isCompleted: true, description: "test" }
        dispatch(postTodoRequestAction({todo}));
      }}>post </button>
      <button onClick={() => {
        dispatch(getTodosRequestAction());
      }}>get </button>
      {todos && JSON.stringify(todos)}

    </div>
  );
}

export default App;
