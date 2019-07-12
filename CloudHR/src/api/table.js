import request from '@/utils/request'

export function getList(params) {
  return request({
    url: '/table/list',
    method: 'get',
    params
  })
}
export const getUserList = params => {
    return request({
        url: '/api/account/getUsers',
        method: 'get',
        params
    })
};
export const getRoleList = params => {
    return request({
        url: '/api/account/getRoles',
        method: 'get',
        params
    })  
};

export const getPagedRoleList = params => {
    return request({
        url: '/api/account/getPagedRoles',
        method: 'get',
        params
    })
};

export const getEmployeeList = params => {
    return request({
        url: '/api/employee/getEmployees',
        method: 'get',
        params
    }) 
};
export const getHealthStatusList = params => {
    return request({
        url: '/api/settings/getHealthStatuses',
        method: 'get',
        params
    })     
};
export const getGenderList = params => {
    return request({
        url: '/api/settings/getGenders',
        method: 'get',
        params
    })  
   
};

export const getMaritalStatusList = params => {
    return request({
        url: '/api/settings/getMaritalStatuses',
        method: 'get',
        params
    })  
    
};

export const getLitracyList = params => {
    return request({
        url: '/api/settings/getLitracys',
        method: 'get',
        params
    })  
    
};
export const getReligionsList = params => {
    return request({
        url: '/api/settings/getReligions',
        method: 'get',
        params
    })  
    
};
export const getCastList = params => {
    return request({
        url: '/api/settings/getCasts',
        method: 'get',
        params
    })  
   
};
export const getDepartmentList = params => {
    return request({
        url: '/api/settings/getDepartments',
        method: 'get',
        params
    })  
    
};
export const getCountryList = params => {
    return request({
        url: '/api/settings/getCountrys',
        method: 'get',
        params
    })  
   
};
export const getProvinceList = params => {
    return request({
        url: '/api/settings/getProvinces',
        method: 'get',
        params
    })  
    
};
export const getDistrictList = params => {
    return request({
        url: '/api/settings/getDistricts',
        method: 'get',
        params
    })  
    
};
export const getMunVdcList = params => {
    return request({
        url: '/api/settings/getMunVdcs',
        method: 'get',
        params
    })  
   
};
export const getWardList = params => {
    return request({
        url: '/api/settings/getWard',
        method: 'get',
        params
    })  
    
};
export const getEmployeeDependentsList = params => {
    return request({
        url: '/api/employee/getDependentsByEmployeeId',
        method: 'get',
        params
    })

};
export const getDocumentRecordList = params => {
    return request({
        url: '/api/employee/getDocumentRecords',
        method: 'get',
        params
    })

};


