import { login, logout } from '@/api/login'
import { getToken, setToken, removeToken } from '@/utils/auth'
import CryptoJS from 'crypto-js'

const user = {
    state: {
        token: getToken(),
        name: '',
        avatar: '',
        roles: []
    },

    mutations: {
        SET_TOKEN: (state, token) => {
            state.token = token
        },
        SET_NAME: (state, name) => {
            state.name = name
        },
        SET_AVATAR: (state, avatar) => {
            state.avatar = avatar
        },
        SET_ROLES: (state, roles) => {
            state.roles = roles
        }
    },

    actions: {       
        Login({ commit }, userInfo) {
            const username = userInfo.username.trim()
            var key = CryptoJS.enc.Hex.parse('000102030405060708090a0b0c0d0e0f')
            var iv = CryptoJS.enc.Hex.parse('101112131415161718191a1b1c1d1e1f')
            var encryptedPass = CryptoJS.AES.encrypt(userInfo.password, key, { iv: iv }).toString()
            return new Promise((resolve, reject) => {
                login(username, encryptedPass).then(response => {
                    console.log('response',response);
                    const data = response.data;
                    setToken(data.token)
                    commit('SET_TOKEN', data.token)
                    if (data.roleId && data.roleId > 0) { 
                        commit('SET_ROLES', data.roleId)
                    } else {
                        reject('getInfo: roles must be a non-null array !')
                    }
                    commit('SET_NAME', data.name)
                    commit('SET_AVATAR', data.avatar)
                    resolve()
                }).catch(error => {
                    reject(error)
                })
            })
        },

       
        
        LogOut({ commit, state }) {
            return new Promise((resolve, reject) => {
                logout(state.token).then(() => {
                    commit('SET_TOKEN', '')
                    commit('SET_ROLES', [])
                    removeToken()
                    resolve()
                }).catch(error => {
                    reject(error)
                })
            })
        },

        // 前端 登出
        FedLogOut({ commit }) {
            return new Promise(resolve => {
                commit('SET_TOKEN', '')
                removeToken()
                resolve()
            })
        }
    }
}

export default user
