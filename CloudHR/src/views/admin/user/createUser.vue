<template>
    <div class="app-container">
        <el-row>
            <el-button round @click="handleBack()" style="margin:20px;float:right">BACK TO USERS</el-button>
        </el-row>
        <el-form :model="ruleForm" :rules="rules" ref="ruleForm" label-width="120px">
            <el-form-item label="Name" prop="name">
                <el-input v-model="ruleForm.name"></el-input>
            </el-form-item>
            <el-form-item label="User Name" prop="username" placeholder="User Name">
                <el-input v-model="ruleForm.username"></el-input>
            </el-form-item>
            <el-form-item label="Role" prop="roleId">
                <el-select v-model="ruleForm.roleId" placeholder="Role">
                    <el-option v-for="item in roles"
                               :key="item.id"
                               :label="item.name"
                               :value="item.id">
                    </el-option>

                </el-select>
            </el-form-item>
            <el-form-item label="Password" prop="password" placeholder="Password">
                <el-input type="password" v-model="ruleForm.password" autocomplete="off"></el-input>
            </el-form-item>
            <el-form-item label="Confirm" prop="checkPass" placeholder="Confirm Password">
                <el-input type="password" v-model="ruleForm.checkPass" autocomplete="off"></el-input>
            </el-form-item>
            <el-form-item>
                <el-button type="primary" @click="submitForm('ruleForm')">Create</el-button>
                <el-button @click="resetForm('ruleForm')">Reset</el-button>
            </el-form-item>
        </el-form>
    </div>
</template>
<script>
    import { getRoleList } from '@/api/table';
    import { addUser } from '@/api/user';
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
                ruleForm: {
                    id: '',
                    name: '',
                    username: '',
                    password: '',
                    checkPass: '',
                    roleId: null
                    
                },
                roles: [],
                rules: {
                    roleId: [
                        { required: true, message: 'Please select at least one Role', pattern: /.+/, trigger: 'change' }                     
                    ],
                    name: [
                        { required: true, message: 'Please input Role Name', trigger: 'blur' }
                    ],
                    username: [
                        { required: true, message: 'Please input User Name', trigger: 'blur' }
                    ],
                    password: [
                        { validator: validatePass, trigger: 'blur' }
                    ],
                    checkPass: [
                        { validator: validatePass2, trigger: 'blur' }
                    ]
                }
            };
        },
        mounted() {
            this.getRoles();
        },
        methods: {
            getRoles: function () {
                this.loading = true;
                return new Promise((resolve, reject) => {
                    getRoleList().then((res) => {
                        console.log('roles', res.result);
                    this.roles = res.result;
                    this.loading = false;
                        resolve()
                    }).catch(error => {
                        reject(error)
                    })
                })   
            },
            submitForm(formName) {
                this.$refs[formName].validate((valid) => {
                    if (valid) {

                        this.loading = true;
                        return new Promise((resolve, reject) => {
                        var userParams = { Id: this.ruleForm.id, Name: this.ruleForm.name, UserName: this.ruleForm.username, Password: this.ruleForm.password, RoleId: this.ruleForm.roleId };
                        addUser(userParams).then((res) => {
                            this.$router.back();
                            this.loading = false;
                            this.$message({
                                type: 'success',
                                message: 'User Add completed'
                            });
                                resolve();
                            }).catch(error => {
                                reject(error)
                            })
                        })                   
                    } else {
                        this.$message({
                            type: 'info',
                            message: 'User Add Canceled'
                        });
                        return false;
                    }
                });
            },
            resetForm(formName) {
                this.$refs[formName].resetFields();
            },
            handleBack() {
                this.$router.back();
            }
        }

    }
</script>