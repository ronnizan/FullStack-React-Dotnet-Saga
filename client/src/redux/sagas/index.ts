import { all } from 'redux-saga/effects';
import { watchGetTodosSaga,watchPostTodoSaga } from './todosSaga';


export default function* rootSaga() {
  yield all([
    watchGetTodosSaga(),
    watchPostTodoSaga(),
  ]);
}
