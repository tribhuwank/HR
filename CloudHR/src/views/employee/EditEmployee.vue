<template>
    <section style="margin:20px;">
        <el-row>
            <el-button round @click="handleBack()" style="margin:20px;float:right">BACK TO EMPLOYEES</el-button>
        </el-row>
        <el-form :model="ruleForm" ref="ruleForm" label-width="120px">
            <el-tabs :tab-position="tabPosition">
                <el-tab-pane>
                    <span slot="label"><i class="el-icon-date"></i> Personal Details</span>
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

                            <el-form-item label="Marital Status" prop="employee.person.maritalStatusId"
                                          :rules="{ required: true, message: 'Please Select Marital Status', pattern: /.+/, trigger: 'change' }">
                                <el-select v-model="ruleForm.employee.person.maritalStatusId" placeholder="Select Marital Status">
                                    <el-option v-for="item in maritalStatuses"
                                               :key="item.id"
                                               :label="item.name"
                                               :value="item.id">
                                    </el-option>

                                </el-select>
                            </el-form-item>
                            <el-form-item label="Religion" prop="employee.person.religionId"
                                          :rules="{ required: true, message: 'Please Select Religion', pattern: /.+/, trigger: 'change' }">
                                <el-select v-model="ruleForm.employee.person.religionId" placeholder="Select Religion">
                                    <el-option v-for="item in religions"
                                               :key="item.id"
                                               :label="item.name"
                                               :value="item.id">
                                    </el-option>

                                </el-select>
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
                            <el-form-item label="Health Status" prop="employee.person.healthStatusId"
                                          :rules="{ required: true, message: 'Please Select Health Status', pattern: /.+/, trigger: 'change' }">
                                <el-select v-model="ruleForm.employee.person.healthStatusId" placeholder="Select Health Status">
                                    <el-option v-for="item in healthStatuses"
                                               :key="item.id"
                                               :label="item.name"
                                               :value="item.id">
                                    </el-option>

                                </el-select>
                            </el-form-item>
                            <el-form-item label="Cast" prop="employee.person.castId"
                                          :rules="{ required: true, message: 'Please Select Cast', pattern: /.+/, trigger: 'change' }">
                                <el-select v-model="ruleForm.employee.person.castId" placeholder="Select Cast">
                                    <el-option v-for="item in casts"
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
                                           action=""
                                           :show-file-list="false"
                                           :on-success="handleAvatarSuccess"
                                           :before-upload="beforeAvatarUpload">
                                    <img v-if="ruleForm.imageUrl" :src="ruleForm.imageUrl" class="avatar">
                                    <i v-else class="el-icon-plus avatar-uploader-icon"></i>
                                </el-upload>
                            </el-form-item>

                        </el-col>
                    </el-row>
                </el-tab-pane>
                <el-tab-pane label="Config">
                    <span slot="label"><i class="el-icon-date"></i> Contact Details</span>
                    <el-row>
                        <el-col :span="8">
                            <el-form-item label="Mobile" prop="employee.person.Phone1" placeholder="Mobile"
                                          :rules="{ required: true, message: 'Please input Mobile Number', trigger: 'blur' }">
                                <el-input v-model="ruleForm.employee.person.Phone1"></el-input>
                            </el-form-item>

                        </el-col>
                        <el-col :span="8">
                            <el-form-item label="Phone" prop="employee.person.Phone2" placeholder="Phone">
                                <el-input v-model="ruleForm.employee.person.Phone2"></el-input>
                            </el-form-item>
                        </el-col>
                        <el-col :span="8">
                            <el-form-item label="Email" prop="employee.person.email" placeholder="Enter Email"
                                          :rules="{required: true, pattern:/\D*([2-9]\d{2})(\D*)([2-9]\d{2})(\D*)(\d{4})\D*/, message: 'Please input Email', trigger: 'blur' }">
                                <el-input v-model="ruleForm.employee.person.email"></el-input>
                            </el-form-item>
                        </el-col>
                    </el-row>
                    <el-row style="display: block; border: 1px solid #ebebeb; border-radius: 3px;transition: .2s;">
                        <header>Address Line 1</header>
                        <el-col :span="8">
                            <el-form-item label="Country" prop="employee.person.permanentAddress.countryId"
                                          :rules="{ required: true, message: 'Please Select Country', pattern: /.+/, trigger: 'change' }">
                                <el-select v-model="ruleForm.employee.person.permanentAddress.countryId" placeholder="Select Country" @change="getProvinces1" disabled>
                                    <el-option v-for="item in countrys1"
                                               :key="item.id"
                                               :label="item.name"
                                               :value="item.id">
                                    </el-option>

                                </el-select>
                            </el-form-item>
                            <el-form-item label="MunVdc" prop="employee.person.permanentAddress.munVdcId"
                                          :rules="{ required: true, message: 'Please Select MunVdc', pattern: /.+/, trigger: 'change' }">
                                <el-select v-model="ruleForm.employee.person.permanentAddress.munVdcId" placeholder="Select MunVdc" @change="getWards1">
                                    <el-option v-for="item in munVdcs1"
                                               :key="item.id"
                                               :label="item.name"
                                               :value="item.id">
                                    </el-option>

                                </el-select>
                            </el-form-item>
                            <el-form-item label="Pin Code / Zip Code" prop="employee.person.permanentAddress.pinCode" placeholder="Pin Code / Zip Code">
                                <el-input v-model="ruleForm.employee.person.permanentAddress.pinCode"></el-input>
                            </el-form-item>
                        </el-col>
                        <el-col :span="8">
                            <el-form-item label="Province" prop="employee.person.permanentAddress.provinceId"
                                          :rules="{ required: true, message: 'Please Select Province', pattern: /.+/, trigger: 'change' }">
                                <el-select v-model="ruleForm.employee.person.permanentAddress.provinceId" placeholder="Select Province" @change="getDistricts1">
                                    <el-option v-for="item in provinces1"
                                               :key="item.id"
                                               :label="item.name"
                                               :value="item.id">
                                    </el-option>

                                </el-select>
                            </el-form-item>
                            <el-form-item label="Ward" prop="employee.person.permanentAddress.wardNo"
                                          :rules="{ required: true, message: 'Please Select Ward', pattern: /.+/, trigger: 'change' }">
                                <el-select v-model="ruleForm.employee.person.permanentAddress.wardNo" placeholder="Select Ward">
                                    <el-option v-for="item in wards1"
                                               :key="item.value"
                                               :label="item.label"
                                               :value="item.value">
                                    </el-option>

                                </el-select>
                            </el-form-item>
                        </el-col>
                        <el-col :span="8">
                            <el-form-item label="District" prop="employee.person.permanentAddress.districtId"
                                          :rules="{ required: true, message: 'Please Select District', pattern: /.+/, trigger: 'change' }">
                                <el-select v-model="ruleForm.employee.person.permanentAddress.districtId" placeholder="Select District" @change="getMunVdcs1">
                                    <el-option v-for="item in districts1"
                                               :key="item.id"
                                               :label="item.name"
                                               :value="item.id">
                                    </el-option>

                                </el-select>
                            </el-form-item>
                            <el-form-item label="House Number" prop="employee.person.permanentAddress.houseNo" placeholder="House Number">
                                <el-input v-model="ruleForm.employee.person.permanentAddress.houseNo"></el-input>
                            </el-form-item>
                        </el-col>

                    </el-row>
                    <el-row style="display: block; border: 1px solid #ebebeb; border-radius: 3px;transition: .2s;">
                        <header>Address Line 2</header>
                        <el-col :span="8">
                            <el-form-item label="Country" prop="employee.person.temporaryAddress.countryId"
                                          :rules="{ required: true, message: 'Please Select Country', pattern: /.+/, trigger: 'change' }">
                                <el-select v-model="ruleForm.employee.person.temporaryAddress.countryId" placeholder="Select Country" @change="getProvinces2" disabled>
                                    <el-option v-for="item in countrys2"
                                               :key="item.id"
                                               :label="item.name"
                                               :value="item.id">
                                    </el-option>

                                </el-select>
                            </el-form-item>
                            <el-form-item label="MunVdc" prop="employee.person.temporaryAddress.munVdcId"
                                          :rules="{ required: true, message: 'Please Select MunVdc', pattern: /.+/, trigger: 'change' }">
                                <el-select v-model="ruleForm.employee.person.temporaryAddress.munVdcId" placeholder="Select MunVdc" @change="getWards2">
                                    <el-option v-for="item in munVdcs2"
                                               :key="item.id"
                                               :label="item.name"
                                               :value="item.id">
                                    </el-option>

                                </el-select>
                            </el-form-item>
                            <el-form-item label="Pin Code / Zip Code" prop="employee.person.temporaryAddress.pinCode" placeholder="Pin Code / Zip Code">
                                <el-input v-model="ruleForm.employee.person.temporaryAddress.pinCode"></el-input>
                            </el-form-item>
                        </el-col>
                        <el-col :span="8">
                            <el-form-item label="Province" prop="employee.person.temporaryAddress.provinceId"
                                          :rules="{ required: true, message: 'Please Select Province', pattern: /.+/, trigger: 'change' }">
                                <el-select v-model="ruleForm.employee.person.temporaryAddress.provinceId" placeholder="Select Province" @change="getDistricts2">
                                    <el-option v-for="item in provinces2"
                                               :key="item.id"
                                               :label="item.name"
                                               :value="item.id">
                                    </el-option>

                                </el-select>
                            </el-form-item>
                            <el-form-item label="Ward" prop="employee.person.temporaryAddress.wardNo"
                                          :rules="{ required: true, message: 'Please Select Ward', pattern: /.+/, trigger: 'change' }">
                                <el-select v-model="ruleForm.employee.person.temporaryAddress.wardNo" placeholder="Select Ward">
                                    <el-option v-for="item in wards2"
                                               :key="item.value"
                                               :label="item.label"
                                               :value="item.value">
                                    </el-option>

                                </el-select>
                            </el-form-item>
                        </el-col>
                        <el-col :span="8">
                            <el-form-item label="District" prop="employee.person.temporaryAddress.districtId"
                                          :rules="{ required: true, message: 'Please Select District', pattern: /.+/, trigger: 'change' }">
                                <el-select v-model="ruleForm.employee.person.temporaryAddress.districtId" placeholder="Select District" @change="getMunVdcs2">
                                    <el-option v-for="item in districts2"
                                               :key="item.id"
                                               :label="item.name"
                                               :value="item.id">
                                    </el-option>

                                </el-select>
                            </el-form-item>
                            <el-form-item label="House Number" prop="employee.person.temporaryAddress.houseNo" placeholder="House Number">
                                <el-input v-model="ruleForm.employee.person.temporaryAddress.houseNo"></el-input>
                            </el-form-item>
                        </el-col>

                    </el-row>
                </el-tab-pane>
                <el-tab-pane label="Officials" v-if="role===1">
                    <span slot="label"><i class="el-icon-date"></i> Officials</span>
                    <el-row>
                        <el-col :span="11">
                            <el-form-item label="Hiring Date" prop="employee.employeeJob.hiringDate" placeholder="Hiring Date"
                                          :rules="{ type: 'date', required: true, message: 'Please Pick a date', trigger: 'change' }">
                                <el-date-picker v-model="ruleForm.employee.employeeJob.hiringDate"
                                                type="date"
                                                placeholder="Pick a date"
                                                default-value="2001-01-01">
                                </el-date-picker>
                            </el-form-item>
                            <el-form-item label="Post" prop="employee.employeeJob.postId"
                                          :rules="{ required: true, message: 'Please Select Post', pattern: /.+/, trigger: 'change' }">
                                <el-cascader :options="departments" @active-item-change="handlePostChange" :props="posts" v-model="ruleForm.employee.employeeJob.postId"></el-cascader>
                            </el-form-item>
                        </el-col>
                        <el-col :span="11">
                            <el-form-item label="Symbol Number" prop="employee.employeeJob.symbolNumber" placeholder="Symbol Number"
                                          :rules="{ required: true, message: 'Please input Employee Number', trigger: 'blur' }">
                                <el-input v-model="ruleForm.employee.employeeJob.symbolNumber" autocomplete="off"></el-input>
                            </el-form-item>
                        </el-col>
                    </el-row>
                    <el-row>

                    </el-row>
                </el-tab-pane>

                <el-tab-pane label="Role">
                    <span slot="label"><i class="el-icon-date"></i> Dependents Details</span>
                    <el-row>
                        <form-dependents v-bind:ruleForm.employee.dependentPersons="ruleForm.employee.dependentPersons"></form-dependents>
                    </el-row>
                </el-tab-pane>
                <el-tab-pane label="Role">
                    <span slot="label"><i class="el-icon-date"></i> Education Details</span>
                    <el-row>
                        <el-col :span="11">
                            <el-form-item label="Litracy" prop="employee.person.litracyId"
                                          :rules="{ required: true, message: 'Please Select Litracys', pattern: /.+/, trigger: 'change' }">
                                <el-select v-model="ruleForm.employee.person.litracyId" placeholder="Select Litracys">
                                    <el-option v-for="item in litracys"
                                               :key="item.id"
                                               :label="item.name"
                                               :value="item.id">
                                    </el-option>

                                </el-select>
                            </el-form-item>
                        </el-col>
                    </el-row>
                </el-tab-pane>
                <el-tab-pane label="Role">
                    <span slot="label"><i class="el-icon-date"></i> Documents</span>
                    Documents
                </el-tab-pane>
            </el-tabs>
            <el-row style="margin:20px;">
                <el-form-item>
                    <el-button type="primary" @click="submitForm('ruleForm')">Update</el-button>
                    <el-button @click="resetForm('ruleForm')">Cancel</el-button>
                </el-form-item>
            </el-row>
        </el-form>

    </section>
</template>
<script>
    import Dependents from '@/views/employee/DependentDetail.vue'
     import { getCastList, getGenderList, getMaritalStatusList,getReligionsList,getLitracyList,getEmployeeDependentsList, getDocumentRecordList,
    getHealthStatusList, getCountryList, getProvinceList, getDistrictList, getMunVdcList, getWardList, getDepartmentList } from '@/api/table';
    import { addEmployee, deleteEmployee } from '@/api/employee';
    import { getUserByPerson } from '@/api/user';
    export default {
        components: {
            'form-dependents':Dependents
        },
        data() {

            return {
                activeName: 'first',
                tabPosition: 'right',
                role:'',
               index:'',
                ruleForm: {
                   imageUrl:'',
                    employee: {
                        id: null,
                        employeeJobId: '',
                        employeeJob:{
                           id:'',
                            departmentId:'',
                            postId:'',
                            hiringDate:'',
                            symbolNumber:'',
                            probationPeriodFrom:'',
                            probationPeriodTo:'',
                            probationPermorfanceSummary:'',
                            opinionSuggestion:''

                        },
                        personId: '',
                        person: {
                            id: null,
                            firstName: '',
                            middleName: '',
                            lastName: '',
                            dob: null,
                            genderId: null,
                            religionId: null,
                            castId: null,
                            email: '',
                            phone1: '',
                            phone2: '',
                            permanentAddressId: '',
                            permanentAddress: {
                                id: null,
                                addressTypeId: 1,
                                countryId: null,
                                provinceId: null,
                                districtId: null,
                                munVdcId: null,
                                addressLine1: '',
                                addressLine2: '',
                                wardNo: null,
                                pinCode: null,
                                houseNo: null
                            },
                            temporaryAddressId: '',
                            temporaryAddress: {
                                id: null,
                                addressTypeId: 2,
                                countryId: null,
                                provinceId: null,
                                districtId: null,
                                munVdcId: null,
                                addressLine1: '',
                                addressLine2: '',
                                wardNo: null,
                                pinCode: null,
                                houseNo: null
                            },
                            maritalStatusId: null,
                            healthStatusId: null,
                            photoUrl: '',
                            identityTypeId: null,
                            identityNumber: null,
                            identityIssueDate: null,
                            identityIssuePlace: null,
                            litracyId: null,
                            educationId: null,
                            eduInstitutionTypeId: null

                        },
                        managerId: null,
                        officeContact: '',
                        nomineeId: null,
                        panNumber: '',
                        citNumber: '',
                        dependentPersons:[],
                        documents:[]

                    },
                    salary:{

                    }

                },
               
                genders: [],


                religions: [],
                casts: [],
                addressTypes: [],
                countrys1:[],
                countrys2: [],
                provinces1: [],
                provinces2: [],
                districts1: [],
                districts2: [],
                munVdcs1: [],
                munVdcs2: [],
                wards1: [],
                wards2: [],
                maritalStatuses: [],
                healthStatuses: [],
                identityTypes: [],
                litracys: [],
                educations: [],
                eduInstitutionTypes: [],
                departments: [],
                persons: [],
                managers: [],
                posts:[],
                departments:[]
            };
        },
        created() {
            this.getUserByPerson(this.$route.params.row);
            this.getEmployeeDependents(this.$route.params.row);
            this.getEmployeeDocuments(this.$route.params.row);
            this.ruleForm.employee = this.$route.params.row;
            this.ruleForm.imageUrl=this.ruleForm.employee.person.photo;
            let user = JSON.parse(sessionStorage.getItem('user'));
            if(user!==null){
                this.role=user.roleId;
            }

        },
        mounted() {
            this.getGenders();
            this.getMaritalStatus();
            this.getReligions();
            this.getCasts();
            this.getLitracys();
            this.getHealthStatuses();
            this.getCountrys1();
            this.getCountrys2();
            this.getProvinces1();
            this.getProvinces2();

        },
        methods: {
            getUserByPerson: function (row) {
                        this.loading = true;
                        var params = { personId: row.personId }
                        return new Promise((resolve, reject) => {
                            getUserByPerson(params).then((res) => {
                                this.loading = false;
                                resolve()
                               this.$set(this.$route.params.row, 'user', res.result) ;
                            }).catch(error => {
                                reject(error)
                            })
                        })
                    },
           getEmployeeDependents: function (row) {
                this.loading = true;
                var params = { employeeId: row.id }
                return new Promise((resolve, reject) => {
                    getEmployeeDependentsList(params).then((res) => {
                        this.loading = false;
                        resolve()
                         this.$set(this.$route.params.row, 'dependentPersons', res.result) ;
                    }).catch(error => {
                        reject(error)
                    })
                })
            },
            getEmployeeDocuments: function (row) {
                this.loading = true;
                var params = { recordId: row.id }
                return new Promise((resolve, reject) => {
                    getDocumentRecordList(params).then((res) => {
                        this.loading = false;
                        resolve()
                    this.$set(this.$route.params.row, 'documents', res.result)
                    }).catch(error => {
                        reject(error)
                    })
                })
            },
            handlePostChange(val){

            },
             indexMethod(index) {
                return index +1;
            },
            handleSaveDependent() {
                if(this.formAdd){
                    this.ruleForrm.dependentPersons.add(this.person)
                }
            },
            handleAvatarSuccess(res, file) {
                var self = this;
                this.ruleForm.imageUrl = URL.createObjectURL(file.raw);
                var reader = new FileReader();
                reader.readAsDataURL(file.raw);
                reader.onloadend = function () {
                    var rss = reader.result;
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

            getCountrys1: function () {
              return new Promise((resolve, reject) => {
               this.loading = true;
                    getCountryList().then((res) => {
                    this.countrys1 = res.result;
                    this.loading = false;
                        resolve()
                    }).catch(error => {
                        reject(error)
                    })
                })
            },

            getDepartments: function () {
                        this.loading = true;
                     return new Promise((resolve, reject) => {
                        getDepartmentList().then((res) => {
                            this.departments = res.result;
                            this.loading = false;
                            resolve()
                    }).catch(error => {
                        reject(error)
                    })
                  })
               },
               getCountrys2: function () {
                        this.loading = true;
                    return new Promise((resolve, reject) => {
                        getCountryList().then((res) => {
                            this.countrys2 = res.result;
                            this.loading = false;
                             resolve()
                    }).catch(error => {
                        reject(error)
                    })
                  })
                 },
                getProvinces1: function () {
                                this.loading = true;
                      return new Promise((resolve, reject) => {
                                getProvinceList().then((res) => {
                                    this.provinces1 = res.result;
                                    this.loading = false;
                                 resolve()
                            }).catch(error => {
                                reject(error)
                            })
                         })
                    },
                    getProvinces2: function () {
                                this.loading = true;
                             return new Promise((resolve, reject) => {
                                getProvinceList().then((res) => {
                                    this.provinces2 = res.result;
                                    this.loading = false;
                                   resolve()
                            }).catch(error => {
                                reject(error)
                            })
                         })
                      },
                        getDistricts1: function (provinceId) {
                                    this.loading = true;
                              return new Promise((resolve, reject) => {
                                    var params = { provinceId: provinceId }
                                    getDistrictList(params).then((res) => {
                                        this.districts1 = res.result;
                                        this.loading = false;
                                        resolve()
                            }).catch(error => {
                                reject(error)
                            })
                         })
                   },
                  getDistricts2: function (provinceId) {
                                    this.loading = true;
                             return new Promise((resolve, reject) => {
                                    var params = { provinceId: provinceId }
                                    getDistrictList(params).then((res) => {
                                        this.districts2 = res.result;
                                        this.loading = false;
                                       resolve()
                            }).catch(error => {
                                reject(error)
                            })
                         })
                  },


            getMunVdcs1: function (districtId) {
                                this.loading = true;
                        return new Promise((resolve, reject) => {
                            var params = { districtId: districtId }
                                getMunVdcList(params).then((res) => {
                                    this.munVdcs1 = res.result;
                                    this.loading = false;
                                    resolve()
                            }).catch(error => {
                                reject(error)
                            })
                         })
            },
            getMunVdcs2: function (districtId) {
                                this.loading = true;
                     return new Promise((resolve, reject) => {
                             var params = { districtId: districtId }
                                getMunVdcList(params).then((res) => {
                                    this.munVdcs2 = res.result;
                                    this.loading = false;
                                    resolve()
                            }).catch(error => {
                                reject(error)
                            })
                         })
                         },
            getWards1: function (munVdcId) {
                                this.loading = true;
                               return new Promise((resolve, reject) => {
                                var params = { munVdcId: munVdcId }
                                getWardList(params).then((res) => {
                                    this.wards1 = res.result;
                                    this.loading = false;
                                   resolve()
                            }).catch(error => {
                                reject(error)
                            })
                         })
                      },
            getWards2: function (munVdcId) {
                                        this.loading = true;
                                        return new Promise((resolve, reject) => {
                                        var params = { munVdcId: munVdcId }
                                        getWardList(params).then((res) => {
                                            this.wards2 = res.result;
                                            this.loading = false;
                                           resolve()
                            }).catch(error => {
                                reject(error)
                            })
                         })
                      },
            getLitracys: function () {
                        this.loading = true;
                return new Promise((resolve, reject) => {
                        getLitracyList().then((res) => {
                            this.litracys = res.result;
                            this.loading = false;
                            resolve()
                    }).catch(error => {
                        reject(error)
                    })
                  })
            },
           getHealthStatuses: function () {
                        this.loading = true;
               return new Promise((resolve, reject) => {
                        getHealthStatusList().then((res) => {
                            this.healthStatuses = res.result;
                            this.loading = false;
                            resolve()
                    }).catch(error => {
                        reject(error)
                    })
                 })
             },
            getGenders: function () {
                this.loading = true;
                 return new Promise((resolve, reject) => {
                getGenderList().then((res) => {
                    this.genders = res.result;
                    this.loading = false;
                        resolve()
                    }).catch(error => {
                        reject(error)
                    })
                })
            },
            getCasts: function () {
                        this.loading = true;
                   return new Promise((resolve, reject) => {
                        getCastList().then((res) => {
                            this.casts = res.result;
                            this.loading = false;
                              resolve()
                    }).catch(error => {
                        reject(error)
                    })
                 })
          },
          getMaritalStatus: function () {
                this.loading = true;
            return new Promise((resolve, reject) => {
                getMaritalStatusList().then((res) => {
                    this.maritalStatuses = res.result;
                    this.loading = false;
                     resolve()
                    }).catch(error => {
                        reject(error)
                    })
                })
            },
            getReligions: function () {
                        this.loading = true;
                     return new Promise((resolve, reject) => {
                        getReligionsList().then((res) => {
                            this.religions = res.result;
                            this.loading = false;
                            resolve()
                    }).catch(error => {
                        reject(error)
                    })
                  })
            },
            handleClick(tab, event) {
                console.log(tab, event);
            },

            submitForm(formName) {
                this.$refs[formName].validate((valid) => {
                    if (valid) {
                        this.loading = true;
                        return new Promise((resolve, reject) => {
                        var employeeParams = { Id: this.ruleForm.id, Name: this.ruleForm.name, UserName: this.ruleForm.username, Password: this.ruleForm.password, RoleId: this.ruleForm.roleId };
                        editEmployee(employeeParams).then((res) => {
                            this.$router.back();
                            this.loading = false;
                             resolve()
                            this.$message({
                                type: 'success',
                                message: 'Employee Edit completed'
                            })
                        }).catch(error => {
                           reject(error)
                         })
                        })
                    } else {
                        this.$message({
                            type: 'info',
                            message: 'Employee Edit Canceled'
                        });
                        return false;
                    }
                })
            },
            resetForm(formName) {
                this.$router.back();
                //this.$refs[formName].resetFields();
            },
            handleBack() {
                this.$router.back();
            }
        }

    }
</script>