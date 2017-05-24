import { combineReducers } from 'redux';
import { routerReducer } from 'react-router-redux';
import jar from '../jar/jarReducer';
import income from '../income/incomeReducer';
import outcome from '../outcome/outcomeReducer';

export default combineReducers({
  routing: routerReducer,
  jar,
  income,
  outcome,
});
