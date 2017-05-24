import store from '../store';
import { get, post, put } from '../modules/apiClient';

const actionTypes = {
    setJars: 'JAR_SET_JARS',
}

const apiRoutes = {
    getJars: 'jar/',
}

const getJars = () => {
    get(apiRoutes.getJars).then((data) => {
        store.dispatch({
            type: actionTypes.setJars,
            data,
        });
    })
}

export default {
    actionTypes,
    getJars,
}

export {
    actionTypes,
    getJars,
}