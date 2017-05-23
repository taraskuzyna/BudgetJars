'use strict';

import _ from 'lodash';
import { actionTypes } from './incomeActions';

const getInitialState = () => {
    const state = {
        incomes: []
    };
    return state;
};

export default (state = getInitialState(), action) => {
    console.log(actionTypes);
    switch (action.type) {
        case actionTypes.setIncomes:
            return _.assign({}, state, { incomes: action.data });
    }
    return state;
};
