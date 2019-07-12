import axios from 'axios'
import { Message, MessageBox } from 'element-ui'
import store from '../store'
import { getToken } from '@/utils/auth'

// Create an axios instance


// var BASE_API = '';
// if (process.env.NODE_ENV == 'production') {
//     BASE_API = '"http://193.112.153.155:3001"';
// }else{
//     BASE_API = '"http://193.112.153.155:3001"';
// }
const service = axios.create({
    baseURL: "", // api like base_url
    timeout: 500000 // Request timeout
})

// requestInterceptor
service.interceptors.request.use(config => {
    //   if (store.getters.token) {
    //     config.headers['X-Token'] = getToken() // Let each request carry a custom token, please modify it according to the actual situation.
    //   };
    if (store.getters.token) {
        config.headers.Authorization = `Bearer ${getToken()}`;
    }
    return config
}, error => {
    // Do something with request error
    console.log(error) // for debug
    Promise.reject(error)
})

// responeInterceptor
service.interceptors.response.use(
    response => {
        /**
        * codeFor non-20000 is a mistake, you can modify your business
        */
        const res = response.data
        if (res.code !== 200) {
            Message({
                message: res.message,
                type: 'error',
                duration: 5 * 1000
            })

            // 50008:Unlawfultoken; 50012:Other clients are logged in;  50014:Token expired;
            if (res.code === 50008 || res.code === 50012 || res.code === 50014) {
                MessageBox.confirm('You have been logged out，you can cancel to stay on this page，or log in again', 'OK', {
                    confirmButtonText: 're-register',
                    cancelButtonText: 'cancel',
                    type: 'warning'
                }).then(() => {
                    store.dispatch('FedLogOut').then(() => {
                        location.reload()// To re-instantiate the vue-router object to avoid bugs
                    })
                })
            }
            return Promise.reject('error')
        } else {
            return response.data
        }
    },
    error => {
        console.log('err' + error)// for debug
        Message({
            message: error.message,
            type: 'error',
            duration: 5 * 1000
        })
        return Promise.reject(error)
    }
)

export default service
