import { TodosActions } from '../types/todosTypes';
import { Todo } from '../types/todosTypes';
import { GET_TODOS_REQUEST, GET_TODOS_SUCCESS, POST_TODO_REQUEST, POST_TODO_SUCCESS } from '../constants/todosConstants';


export interface TodosState {
  todos: Todo[];
}


export const todosReducer = (state: TodosState = { todos: [] }, action: TodosActions) => {
  switch (action.type) {
    case GET_TODOS_SUCCESS:
      return {
        todos: action.payload
      }
    case POST_TODO_SUCCESS:
      return {
        todos: [...state.todos, action.payload]
      }
    default:
      return state;
  }
}



