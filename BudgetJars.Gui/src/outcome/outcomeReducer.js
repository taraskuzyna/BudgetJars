import _ from 'lodash';
import actionTypes from './outcomeActions';

const getInitialState = () => {
    const state = {
        outcomes: []
    };
    return state;
};

export default (state = getInitialState(), action) => {
    switch (action.type) {
        case actionTypes.setOutcomes:
            return _.assign({}, state, { outcomes: action.data });
        default:
            return state;
    }
};
