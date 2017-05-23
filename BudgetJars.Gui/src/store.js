'use strict';

import { createStore } from 'redux';
import reducers from './modules/combineReducers';
import _ from 'lodash';

const store = createStore(reducers, {}, window.devToolsExtension && window.devToolsExtension());

export default store;