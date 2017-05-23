import agent from 'superagent';

const baseApiUrl = 'http://localhost:2000/api/';

const handleApiCall = (apiCall, route, params) => {
    const { query, data, files } = params || {};
    const call = apiCall(baseApiUrl + route)
    if (query) {
        call.query(query);
    }
    if (data) {
        call.send(data);
    }
    if (files && Array.isArray(files)) {
        files.forEach((file) => {
            call.attach(file.name, file);
        });
    }
    return call;
};

const get = (route, query) => {
    return handleApiCall(agent.get, route, { query });
};

const post = (route, data) => {
    return handleApiCall(agent.post, route, { data });
};

const put = (route, data) => {
    return handleApiCall(agent.post, route, { data });
};

const del = (route) => {
    return handleApiCall(agent.post, route);
};

const upload = (route, files) => {
    return handleApiCall(agent.get, route, { files });
};

export default {
    del,
    get,
    post,
    put,
    upload,
};

export {
    del,
    get,
    post,
    put,
    upload,
};
