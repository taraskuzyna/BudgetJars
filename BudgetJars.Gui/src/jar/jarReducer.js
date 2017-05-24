import _ from 'lodash';
import actionTypes from './jarActions';

const getInitialState = () => {
    const state = {
        jars: []
    };
    return state;
};

export default (state = getInitialState(), action) => {
    switch (action.type) {
        case actionTypes.setJars:
            return _.assign({}, state, { jars: action.data });
        default:
            return state;
    }
};
