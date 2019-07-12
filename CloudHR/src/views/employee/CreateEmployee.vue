<template>
    <section style="margin:20px;">
        <el-row>
            <el-button round @click="handleBack()" style="margin:20px;float:right">BACK TO EMPLOYEES</el-button>
        </el-row>
        <el-form :model="ruleForm" ref="ruleForm" label-width="120px">
            <el-row>
                <el-col :span="8">
                    <el-form-item label="First Name" prop="employee.person.firstName" placeholder="First Name"
                                  :rules="{ required: true, message: 'Please input First Name', trigger: 'blur' }">
                        <el-input v-model="ruleForm.employee.person.firstName"></el-input>
                    </el-form-item>
                </el-col>
                <el-col :span="8">
                    <el-form-item label="Middle Name" prop="employee.person.middleName" placeholder="Middle Name">
                        <el-input v-model="ruleForm.employee.person.middleName"></el-input>
                    </el-form-item>
                </el-col>
                <el-col :span="8">
                    <el-form-item label="Last Name" prop="employee.person.lastName" placeholder="Last Name"
                                  :rules="{ required: true, message: 'Please input Last Name', trigger: 'blur' }">
                        <el-input v-model="ruleForm.employee.person.lastName"></el-input>
                    </el-form-item>
                </el-col>
            </el-row>
            <el-row>
                <el-col :span="8">
                    <el-form-item label="Date of birth" prop="employee.person.dob" placeholder="Date of birth"
                                  :rules="{ type: 'date', required: true, message: 'Please Pick a date', trigger: 'change' }">
                        <el-date-picker v-model="ruleForm.employee.person.dob"
                                        type="date"
                                        placeholder="Pick a date"
                                        default-value="2001-01-01">
                        </el-date-picker>
                    </el-form-item>


                    <el-form-item label="Hiring Date" prop="employee.employeeJob.hiringDate" placeholder="Hiring Date"
                                  :rules="{ type: 'date', required: true, message: 'Please Pick a date', trigger: 'change' }">
                        <el-date-picker v-model="ruleForm.employee.employeeJob.hiringDate"
                                        type="date"
                                        placeholder="Pick a date"
                                        default-value="2001-01-01">
                        </el-date-picker>
                    </el-form-item>
                    <el-form-item label="Symbol Number" prop="employee.employeeJob.symbolNumber" placeholder="Symbol Number"
                                  :rules="{ required: true, message: 'Please input Employee Number', trigger: 'blur' }">
                        <el-input v-model="ruleForm.employee.employeeJob.symbolNumber" autocomplete="off"></el-input>
                    </el-form-item>
                </el-col>
                <el-col :span="8">
                    <el-form-item label="Gender" prop="employee.person.genderId"
                                  :rules="{ required: true, message: 'Please Select Gender', pattern: /.+/, trigger: 'change' }">
                        <el-select v-model="ruleForm.employee.person.genderId" placeholder="Select Gender">
                            <el-option v-for="item in genders"
                                       :key="item.id"
                                       :label="item.name"
                                       :value="item.id">
                            </el-option>

                        </el-select>
                    </el-form-item>


                </el-col>
                <el-col :span="8">
                    <el-form-item label="Photograph" prop="imageUrl" placeholder="photo"
                                  :rules="{ required: true, message: 'Please Select an image', trigger: 'change' }">
                        <el-upload class="avatar-uploader"
                                   action="/api/account/posts/"                                   
                                   :show-file-list="false"
                                   :on-success="handleAvatarSuccess"
                                   :before-upload="beforeAvatarUpload" 
                                   >
                            <img v-if="ruleForm.imageUrl" :src="ruleForm.imageUrl" class="avatar" >
                            <i v-else class="el-icon-plus avatar-uploader-icon"></i>
                        </el-upload>
                    </el-form-item>
                </el-col>
            </el-row>
            <el-row>
                <el-col :span="8">
                    <el-checkbox v-model="setLoginCredential" label="Set Login Credentials" border></el-checkbox>
                    <el-row v-if="setLoginCredential">
                        <el-form-item label="User Name" prop="user.username" placeholder="User Name">
                            <el-input v-model="ruleForm.user.username"></el-input>
                        </el-form-item>
                        <el-form-item label="Password" prop="user.password" placeholder="Password">
                            <el-input type="password" v-model="ruleForm.user.password" autocomplete="off"></el-input>
                        </el-form-item>
                        <el-form-item label="Confirm" prop="user.checkPass" placeholder="Confirm Password">
                            <el-input type="password" v-model="ruleForm.user.checkPass" autocomplete="off"></el-input>
                        </el-form-item>
                    </el-row>
                </el-col>
            </el-row>
            <el-form-item>
                <el-button type="primary" @click="submitForm('ruleForm')">Create</el-button>
                <el-button @click="resetForm('ruleForm')">Reset</el-button>
            </el-form-item>
        </el-form>
    </section>
</template>
<script>
    import { getGenderList } from '@/api/table';
    import { addEmployee, deleteEmployee } from '@/api/employee';
    import CryptoJS from 'crypto-js'
    export default {
        data() {
            return {

                setLoginCredential: false,
                ruleForm: {
                    imageUrl:'',
                    employee: {
                        id: null,
                    employeeJob:{
                            id:null,
                            departmentId:null,
                            postId:null,
                            hiringDate:null,
                            symbolNumber:'',
                            probationPeriodFrom:null,
                            probationPeriodTo:null,
                            probationPermorfanceSummary:'',
                            opinionSuggestion:''
                         },
                       person: {
                            id: null,
                            firstName: '',
                            middleName: '',
                            lastName: '',
                            genderId: null,
                            dob: null,
                            photo: ''
                         }

                    },
                    user: {
                        id: null,
                        name: '',
                        userName: '',
                        password: '',
                        checkPass:'',
                        rolId:2
                    }
                },
                genders: []

            };
        },
        mounted() {
            this.getGenders();
        },
        methods: {
            handleAvatarSuccess(res, file) {
                var self=this;
                this.ruleForm.imageUrl = URL.createObjectURL(file.raw);
                          var reader = new FileReader();
                reader.readAsDataURL(file.raw);
                     reader.onloadend = function() {
                        var rss=reader.result;
                         self.ruleForm.employee.person.photo = rss;
                }



            },
            beforeAvatarUpload(file) {
                const isJPG = file.type === 'image/jpeg';
                const isLt2M = file.size / 1024 / 1024 < 2;

                if (!isJPG) {
                    this.$message.error('Avatar picture must be JPG format!');
                }
                if (!isLt2M) {
                    this.$message.error('Avatar picture size can not exceed 2MB!');
                }
                return isJPG && isLt2M;
            },
            getGenders: function () {
                this.loading = true;
                return new Promise((resolve, reject) => {
                getGenderList().then((res) => {
                    this.genders = res.result;
                    this.loading = false;
                   resolve();
                 }).catch(error => {
                        reject(error)
                    })
                 })
               },
            submitForm(formName) {
                this.$refs[formName].validate((valid) => {
                    if (valid) {
                        this.loading = true;
                            if(this.setLoginCredential)
                            {
                                this.ruleForm.user.name = this.ruleForm.employee.person.firstName.concat(' ',this.ruleForm.employee.person.middleName);
                                this.ruleForm.user.name =this.ruleForm.user.name.concat(' ',this.ruleForm.employee.person.lastName);

                                var key = CryptoJS.enc.Hex.parse('000102030405060708090a0b0c0d0e0f');
                                var iv = CryptoJS.enc.Hex.parse('101112131415161718191a1b1c1d1e1f');
                                var encrypted = CryptoJS.AES.encrypt(this.ruleForm.user.checkPass, key, { iv: iv }).toString();
                               this.ruleForm.user.password=encrypted;
                            }

                        var employeeParams = {  EmployeeViewModel: this.ruleForm.employee, UserViewModel: this.ruleForm.user }
                        return new Promise((resolve, reject) => {
                           addEmployee(employeeParams).then((res) => {
                                this.$message({
                                    type: 'success',
                                    message: 'Employee Add completed'
                                })
                                this.loading = false
                                resolve()
                                this.$router.back()
                            }).catch(error => {
                                reject(error)
                            })
                        })
                       }
                    })
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
<style>
    .avatar-uploader .el-upload {
        border: 1px dashed #d9d9d9;
        border-radius: 6px;
        cursor: pointer;
        position: relative;
        overflow: hidden;
    }

        .avatar-uploader .el-upload:hover {
            border-color: #409EFF;
        }

    .avatar-uploader-icon {
        font-size: 28px;
        color: #8c939d;
        width: 178px;
        height: 178px;
        line-height: 178px;
        text-align: center;
    }

    .avatar {
        width: 178px;
        height: 178px;
        display: block;
    }
</style>
