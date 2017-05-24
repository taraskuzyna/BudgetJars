import _ from 'lodash';
import { actionTypes } from './incomeActions';

const getInitialState = () => {
    const state = {
        incomes: []
    };
    return state;
};

export default (state = getInitialState(), action) => {
    switch (action.type) {
        case actionTypes.setIncomes:
            return _.assign({}, state, { incomes: action.data });
        default:
            return state;
    }
};
