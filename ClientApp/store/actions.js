export const login = ({ commit }, payload) => {
    return new Promise((resolve, reject) => {
        commit("loginRequest");
        axios
            .post("/api/token", payload)
            .then(response => {
                const auth = response.data;
                axios.defaults.headers.common["Authorization"] = `Bearer ${
                    auth.access_token
                    }`;
                commit("loginSuccess", auth);
                commit("hideAuthModal");
                resolve(response);
            })
            .catch(error => {
                commit("loginError");
                delete axios.defaults.headers.common["Authorization"];
                reject(error.response);
            });
    });
};

export const register = ({ commit }, payload) => {
    return new Promise((resolve, reject) => {
        commit("registerRequest");
        axios
            .post("/api/account", payload)
            .then(response => {
                commit("registerSuccess");
                resolve(response);
            })
            .catch(error => {
                commit("registerError");
                reject(error.response);
            });
    });
};export const logout = ({ commit }) => {
    commit("logout");
    delete axios.defaults.headers.common["Authorization"];
};