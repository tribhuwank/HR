import request from '@/utils/request'

export const addRole = params => {
    return request({
        url: '/api/account/addRole',
        method: 'post',
        params
    }) 
};
export const editRole = params => {
    return request({
        url: '/api/account/editRole',
        method: 'post',
        params
    })
};
export const deleteRole = params => {
    return request({
        url: '/api/account/deleteRole',
        method: 'post',
        params
    }) 
};
export const addUser = params => {
    return request({
        url: '/api/account/addUser',
        method: 'post',
        params
    }) 
};
export const editUser = params => {
    return request({
        url: '/api/account/editUser',
        method: 'post',
        params
    })
};
export const deleteUser = params => {
    return request({
        url: '/api/account/deleteUser',
        method: 'post',
        params
    }) 
};
export const getUserByPerson = params => {
    return request({
        url: '/api/employee/getUserByPersonId',
        method: 'get',
        params
    })
};