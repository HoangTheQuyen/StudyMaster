export const isAuthenticated = state => {
    return (
        state.auth !== null &&
        state.auth.access_token !== null &&
        new Date(state.auth.access_token_expiration) > new Date()
    );
};