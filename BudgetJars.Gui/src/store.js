import { createStore } from 'redux';
import reducers from './modules/combineReducers';

const store = createStore(reducers, {}, window.devToolsExtension && window.devToolsExtension());

export default store;