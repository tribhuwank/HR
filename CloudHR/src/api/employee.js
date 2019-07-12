import request from '@/utils/request'

export const addEmployee = params => {
    return request({
        url: '/api/employee/addEmployee',
        method: 'post',
        data: params
    }) 
};
export const editEmployee = params => {
    return request({
        url: '/api/employee/editEmployee',
        method: 'post',
        params
    }) 
};
export const deleteEmployee = params => {
    return request({
        url: '/api/employee/deleteEmployee',
        method: 'post',
        params
    })   
};
