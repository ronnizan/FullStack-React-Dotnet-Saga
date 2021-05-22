import {GET_TODOS_REQUEST,GET_TODOS_SUCCESS,POST_TODO_REQUEST,POST_TODO_SUCCESS  } from '../constants/todosConstants';


export interface Todo {
  id: number;
  description: string;
  isCompleted: boolean;
}
interface GetTodosSuccess {
  type: typeof GET_TODOS_SUCCESS;
  payload: Todo[];
}

interface PostTodosSuccess {
  type: typeof POST_TODO_SUCCESS;
  payload: Todo;
}


export type TodosActions =  GetTodosSuccess|PostTodosSuccess;

