import Cookies from 'js-cookie'

const TokenKey = 'Admin-Token'

const RoleKey = 'User-Role'

export function getToken() {
  return Cookies.get(TokenKey)
}

export function setToken(token) {
  return Cookies.set(TokenKey, token)
}

export function removeToken() {
  return Cookies.remove(TokenKey)
}

export function getRole() {
  return Cookies.get(RoleKey)
}

export function setRole(role) {
  return Cookies.set(RoleKey, role)
}

export function removeRole() {
  return Cookies.remove(RoleKey)
}
