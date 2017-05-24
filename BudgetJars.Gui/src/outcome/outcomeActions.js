import store from '../store';
import { get, post, put } from '../modules/apiClient';

const actionTypes = {
    setOutcomes: 'OUTCOME_SET_OUTCOMES',
}

const apiRoutes = {
    getOutcomes: '/outcome/',
}

const getOutcomes = () => {
    get(apiRoutes.getOutcomes).then((data) => {
        store.dispatch({
            type: actionTypes.setOutcomes,
            data,
        });
    })
}

export default {
    actionTypes,
    getOutcomes,
}

export {
    actionTypes,
    getOutcomes,
}