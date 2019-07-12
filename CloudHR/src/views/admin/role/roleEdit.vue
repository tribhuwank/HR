<template>
    <section style="margin:20px;">
        <el-row>
            <el-button round @click="handleBack()" style="margin:20px;float:right">BACK TO ROLES</el-button>
        </el-row>
        <el-form :model="ruleForm" :rules="rules" ref="ruleForm" label-width="120px">
            <el-form-item label="Name" prop="name">
                <el-input v-model="ruleForm.name"></el-input>
            </el-form-item>

            <el-form-item>
                <el-button type="primary" @click="submitForm('ruleForm')">Save</el-button>
                <el-button @click="resetForm('ruleForm')">Reset</el-button>
            </el-form-item>
        </el-form>
    </section>
</template>
<script>
    import { editRole } from '@/api/user';
    export default {
        data() {
            return {
                ruleForm: {
                    name: '',
                    id: ''
                },
                rules: {
                    name: [
                        { required: true, message: 'Please input Role Name', trigger: 'blur' }
                    ]
                }
            };
        },
        created() {
            this.ruleForm = this.$route.params.row;
        },
        methods: {
            submitForm(formName) {
                this.$refs[formName].validate((valid) => {
                    if (valid) {
                       
                        this.loading = true;
                        var roleParams = { Name: this.ruleForm.name, Id: this.ruleForm.id };                        
                        editRole(roleParams).then((res) => {
                            this.$router.back();
                            this.loading = false;
                            this.$message({
                                type: 'success',
                                message: 'Role Edit completed'
                            });
                        })
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


