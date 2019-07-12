import Vue from 'vue'
import Router from 'vue-router'
/* Layout */
import Layout from './views/admin/layout/Layout'

Vue.use(Router)

export const constantRouterMap = [
    { path: '/login', component: () => import('@/views/login/index'), hidden: true },
    { path: '/404', component: () => import('@/views/404'), hidden: true },

    {
        path: '/',
        component: Layout,
        redirect: '/dashboard',
        name: 'Dashboard',
        hidden: true,
        children: [{
            path: 'dashboard',
            component: () => import('@/views/admin/dashboard/index')
        }]
    },
    {
        path: '/setting',
        component: Layout,
        redirect: '/setting/user',
        name: 'Setting',
        // meta: { title: 'Example', icon: 'example' },
        meta: { title: 'Setting', icon: 'icon-fenleiorguangchangorqitatianchong' },
        children: [
            {
                path: 'user',
                name: 'User',
                component: () => import('@/views/admin/user/index'),
                meta: { title: 'User', icon: 'icon-shoujitianchong' }
            },
            {
                path: 'user-edit',
                name: 'user-edit',
                hidden: true,
                component: () => import('@/views/admin/user/editUser'),
                meta: { title: 'user-edit', icon: 'icon-shoujitianchong' }
            },
            {
                path: 'user-add',
                name: 'user-add',
                hidden: true,
                component: () => import('@/views/admin/user/createUser'),
                meta: { title: 'user-add', icon: 'icon-shoujitianchong' }
            },
            {
                path: 'role',
                name: 'Role',
                component: () => import('@/views/admin/role/index'),
                // meta: { title: 'Tree', icon: 'tree' }
                meta: { title: 'Role', icon: 'icon-gengduotianchong' }
            },
            {
                path: 'role-add',
                name: 'role-add',
                hidden: true,
                component: () => import('@/views/admin/role/roleCreate'),
                meta: { title: 'role-add', icon: 'icon-shoujitianchong' }
            },
            {
                path: 'role-edit',
                name: 'role-edit',
                hidden: true,
                component: () => import('@/views/admin/role/roleEdit'),
                meta: { title: 'role-edit', icon: 'icon-shoujitianchong' }
            }
        ]
    },
    {
        path: '/jolting ',
        component: Layout,
        redirect: '/jolting /employee',
        name: 'jolting ',
        // meta: { title: 'Example', icon: 'example' },
        meta: { title: 'jolting', icon: 'icon-fenleiorguangchangorqitatianchong' },
        children: [
            {
                path: 'employee',
                name: 'Employee',
                component: () => import('@/views/employee/Index'),
                meta: { title: 'Employee', icon: 'icon-shoujitianchong' }
            },
            {
                path: 'employee-edit',
                name: 'employee-edit',
                hidden: true,
                component: () => import('@/views/employee/EditEmployee'),
                meta: { title: 'employee-edit', icon: 'icon-shoujitianchong' }
            },
            {
                path: 'employee-add',
                name: 'employee-add',
                hidden: true,
                component: () => import('@/views/employee/CreateEmployee'),
                meta: { title: 'employee-add', icon: 'icon-shoujitianchong' }
            }
          
        ]
    },

    {
        path: '/example',
        component: Layout,
        redirect: '/example/table',
        name: 'Example',
        // meta: { title: 'Example', icon: 'example' },
        meta: { title: 'Example', icon: 'icon-fenleiorguangchangorqitatianchong' },
        children: [
            {
                path: 'table',
                name: 'Table',
                component: () => import('@/views/employee/DependentDetail'),
                meta: { title: 'Table', icon: 'icon-shoujitianchong' }
            }            
        ]
    },

    {
        path: '/form',
        component: Layout,
        children: [
            {
                path: 'index',
                name: 'Form',
                component: () => import('@/views/admin/form/index'),
                meta: { title: 'Form', icon: 'icon-xinfengtianchong' }
            }
        ]
    },

    {
        path: '/nested',
        component: Layout,
        redirect: '/nested/menu1',
        name: 'nested',
        meta: {
            title: 'nested',
            icon: 'icon-wenbenbianjitianchong'
        },
        children: [
            {
                path: 'menu1',
                component: () => import('@/views/operator/nested/menu1/index'), // Parent router-view
                name: 'menu1',
                meta: { title: 'menu1' },
                children: [
                    {
                        path: 'menu1-1',
                        component: () => import('@/views/operator/nested/menu1/menu1-1'),
                        name: 'menu1-1',
                        meta: { title: 'menu1-1' }
                    },
                    {
                        path: 'menu1-2',
                        component: () => import('@/views/operator/nested/menu1/menu1-2'),
                        name: 'menu1-2',
                        meta: { title: 'menu1-2' },
                        children: [
                            {
                                path: 'menu1-2-1',
                                component: () => import('@/views/operator/nested/menu1/menu1-2/menu1-2-1'),
                                name: 'menu1-2-1',
                                meta: { title: 'menu1-2-1' }
                            },
                            {
                                path: 'menu1-2-2',
                                component: () => import('@/views/operator/nested/menu1/menu1-2/menu1-2-2'),
                                name: 'menu1-2-2',
                                meta: { title: 'menu1-2-2' }
                            }
                        ]
                    },
                    {
                        path: 'menu1-3',
                        component: () => import('@/views/operator/nested/menu1/menu1-3'),
                        name: 'menu1-3',
                        meta: { title: 'menu1-3' }
                    }
                ]
            },
            {
                path: 'menu2',
                component: () => import('@/views/operator/nested/menu2/index'),
                meta: { title: 'menu2' }
            }
        ]
    },

    { path: '*', redirect: '/404', hidden: true }
];
export default new Router({
    mode: "history",
    scrollBehavior: () => ({ y: 0 }),
    routes: constantRouterMap
});
