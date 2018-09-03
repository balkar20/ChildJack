const receiveUsersType = 'RECEIVE_USERS';
const initialState = { users: [] };

export const actionCreators = {
    requestUsers: startDateIndex => async (dispatch, getState) => {
        const url = `api/User/GetUsers?id=${1}`;
        const response = await fetch(url);
        const users = await response.json();

        dispatch({ type: receiveUsersType, users });
    }  
};

export const reducer = (state, action) => {
    state = state || initialState;

    if (action.type === receiveUsersType) {
        return {
            ...state,
            users:action.users
        };
    }

    return state;
};
