const receiveUsersType = 'RECEIVE_USERS'
const receiveUserByIdType = 'RECEIVE_USER_BY_ID'
const initialState = { user: {id:1, name:"OPar"} };

export const actionCreators = {
    requestUser: startDateIndex => async (dispatch, getState) => {    
        const url = `api/User/GetUser?id=${startDateIndex}`;
        const response = await fetch(url);
        const user = await response.json();
    
        dispatch({ type: receiveUserByIdType, user });
      }
  // requestUser: id => async (dispatch, getState) => {  
  //     const url = `api/User/GetUser:id=${id}`
  //     const response = await fetch(url)
  //     const user = await response.json()

//     dispatch({ type: receiveUserByIdType, user })
// }  
}

export const reducer = (state, action) => {
  state = state || initialState

  if (action.type === receiveUserByIdType) {
    return {
      ...state,
      user: action.user
    }
  }

  return state
}
