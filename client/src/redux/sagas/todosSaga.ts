import axios from 'axios';
import { put, takeEvery } from 'redux-saga/effects';
import { Todo } from '../types/todosTypes';
import {
  GET_TODOS_REQUEST,
  GET_TODOS_SUCCESS,
  POST_TODO_REQUEST,
  POST_TODO_SUCCESS
} from '../constants/todosConstants';

export function* getTodosSaga() {
  try {
    const { data } = yield axios.get(
      `https://localhost:44387/api/todos`
    );
    yield put({ type: GET_TODOS_SUCCESS, payload: data });
  } catch (error) {
    console.log('get todos Fail')
  }

}
export function* postTodoSaga(action:any) {
  try {
    const {id,isCompleted,description} = action.payload
        const { data } = yield axios.post(`https://localhost:44387/api/todos`, {
      id,isCompleted,description
    });
    yield put({ type: POST_TODO_SUCCESS, payload: data });
  } catch (error) {
    console.log('post todo Fail') 
  }

}



export function* watchGetTodosSaga() {
  yield takeEvery(GET_TODOS_REQUEST, getTodosSaga);
}
export function* watchPostTodoSaga() {
  yield takeEvery(POST_TODO_REQUEST, postTodoSaga);
}
