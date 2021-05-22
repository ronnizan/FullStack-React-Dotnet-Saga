import { createStore, applyMiddleware, combineReducers } from 'redux';
import { todosReducer } from './reducers/todoReducer';
import createSagaMiddleware from "redux-saga";
import { composeWithDevTools } from "redux-devtools-extension";
import todoSaga from "./sagas"
const sagaMiddleWare = createSagaMiddleware();




const rootReducer = combineReducers({
  todos: todosReducer,
});


const store = createStore(
	rootReducer,
	composeWithDevTools(applyMiddleware(sagaMiddleWare))
);

sagaMiddleWare.run(todoSaga);

export type RootState = ReturnType<typeof rootReducer>;

export default store;