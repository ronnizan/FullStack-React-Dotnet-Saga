import { Todo } from './../types/todosTypes';
import { GET_TODOS_REQUEST, POST_TODO_REQUEST} from './../constants/todosConstants';

export const getTodosRequestAction = () => {
  return { type: GET_TODOS_REQUEST };
};
export const postTodoRequestAction = ( { todo }: { todo: Todo } ) => {
  return { type: POST_TODO_REQUEST, payload: todo };
};

