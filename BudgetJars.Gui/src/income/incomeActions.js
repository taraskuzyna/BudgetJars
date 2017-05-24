import store from '../store';
import { get, post, put } from '../modules/apiClient';

const actionTypes = {
    setIncomes: 'INCOME_SET_INCOMES',
}

const apiRoutes = {
    getIncomes: 'income/',
}

const getIncomes = () => {
    get(apiRoutes.getIncomes).then((data) => {
        store.dispatch({
            type: actionTypes.setIncomes,
            data,
        });
    })
}

export default {
    actionTypes,
    getIncomes,
}

export {
    actionTypes,
    getIncomes,
}