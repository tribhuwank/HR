<template>
    <div class="app-container">
        <el-button round @click="handleRoles()" style="margin:20px;float:right">ROLES</el-button>
        <el-button round @click="handleAdd()" style="margin:20px;float:right">ADD USER</el-button>

        <template>
            <el-table :data="userstableData.results" v-loading="loading"
                      style="width: 100%">
                <el-table-column type="index"
                                 :index="indexMethod">
                </el-table-column>
                <el-table-column prop="name" sortable
                                 label="Name"
                                 width="200">
                </el-table-column>
                <el-table-column prop="username" sortable
                                 label="Username">
                </el-table-column>
                <el-table-column prop="role.name" sortable
                                 label="Role">

                </el-table-column>
                <el-table-column align="right">

                    <template slot-scope="scope">
                        <el-button size="mini"
                                   @click="handleEdit(scope.$index, scope.row)">Edit</el-button>
                        <el-button size="mini"
                                   type="danger"
                                   @click="handleDelete(scope.$index, scope.row)">Delete</el-button>
                    </template>
                </el-table-column>
            </el-table>
            <div class="block" style="text-align: center;">
                <span class="demonstration"></span>
                <el-pagination v-on:size-change="handleSizeChange"
                               v-on:current-change="handleCurrentChange"
                               :current-page.sync="userstableData.currentPage"
                               :page-sizes="[5,10, 20, 50, 100]"
                               :page-size="userstableData.pageSize"
                               layout="total, sizes, prev, pager, next, jumper"
                               :total="userstableData.rowCount">
                </el-pagination>
            </div>

        </template>
     </div>
</template>
<script>
    import { getUserList, getRoleList } from '@/api/table';
    import { deleteUser } from '@/api/user';
      
    export default {
        data() {
            var validatePass = (rule, value, callback) => {
                if (value === '') {
                    callback(new Error('Please input the password'));
                } else {
                    if (this.ruleForm.checkPass !== '') {
                        this.$refs.ruleForm.validateField('checkPass');
                    }
                    callback();
                }
            };
            var validatePass2 = (rule, value, callback) => {
                if (value === '') {
                    callback(new Error('Please input the password again'));
                } else if (value !== this.ruleForm.password) {
                    callback(new Error('Two inputs don\'t match!'));
                } else {
                    callback();
                }
            };
           
            return {
                userstableData: [], 
                roles:[],
                loading: false,
                search: '',
                ruleForm: {
                    name: '',
                    userName: '',
                    password: '',
                    checkPass: '',
                    roleId: '',
                    id: ''
                }
            }
        },
        methods: {
            handleSizeChange(val) {
                this.getUsers(1, val);

            },
            handleCurrentChange(val) {
                this.getUsers(val, null);
            },
            indexMethod(index) {
                return index + 1;
            },
            getUsers: function (page,pageSize) {
                this.loading = true;
                var params = { page: page, pageSize: pageSize }
                return new Promise((resolve, reject) => {
                getUserList(params).then((res) => {
                    this.userstableData = res.result;
                    this.loading = false;
                        resolve()
                    }).catch(error => {
                        reject(error)
                    })
                })
            },
            getRoles: function () {
                this.loading = true;
                return new Promise((resolve, reject) => {
                    getRoleList().then((res) => {
                        this.roles = res.result;
                        this.loading = false;
                        resolve()
                    }).catch(error => {
                        reject(error)
                    })
                })
            },
          
            indexMethod(index) {
                return index +1;
            },
            handleEdit(index, row) {
               
                this.$router.push({ path: 'user-edit', name: 'user-edit', params: { row: row } });             
            },
            handleDelete(index, row) {
                this.$confirm('This will permanently delete the User. Continue?', 'Warning', {
                    confirmButtonText: 'OK',
                    cancelButtonText: 'Cancel',
                    type: 'warning'
                }).then(() => {
                    this.loading = true;
                    var userParams = { Id: row.id, Name: row.name, UserName: row.username, Password: row.password, RoleId: row.roleId };
                    
                    deleteUser(userParams).then((res) => {
                        this.loading = false;
                        this.getUsers();
                        this.$message({
                            type: 'success',
                            message: 'Delete completed'
                        });
                    }).catch((error) => {
                        this.$message({
                            type: 'info',
                            message: 'Delete canceled ' + error 
                        });
                    });

                }).catch((error) => {
                    this.$message({
                        type: 'info',
                        message: 'Delete canceled ' + error 
                    });
                });
            },
            handleAdd() { 
                this.$router.push({ path: 'user-add', name: 'user-add', meta: { requiresAuth: true, adminAuth: true, operatorAuth: false } });             
            },
            handleRoles() {
                this.$router.push({ path: 'role' });
            },
           
        },
        created() {            
        },
        mounted() {
            this.getUsers(1,5);
            this.getRoles();
        }
    };
</script>
<style scoped>
    
</style>