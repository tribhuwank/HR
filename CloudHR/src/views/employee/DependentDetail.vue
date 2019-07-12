<template>
    <section style="margin:20px;">
        <el-button round @click="handleAddDependent()" style="margin:20px;float:right">ADD DEPENDENT</el-button>
        <template>

        </template>
        <template>
            <el-table :data="ruleForm.employee.dependentPersons"
                      style="width: 100%">
                <el-table-column type="index"
                                 :index="indexMethod">
                </el-table-column>
                <el-table-column label="Photo"
                                 width="100">
                    <template slot-scope="scope">
                        <img :src="getImageFile(scope.row.person.photo)" height="40">
                    </template>
                </el-table-column>
                <el-table-column label="Name"
                                 width="200">

                    <template slot-scope="scope">
                        <div slot="reference" class="name-wrapper" v-if="scope.row.person.middleName">
                            {{ scope.row.person.firstName+' '+scope.row.person.middleName+' '+scope.row.person.lastName }}
                        </div>
                        <div slot="reference" class="name-wrapper" v-if="!scope.row.person.middleName">
                            {{ scope.row.person.firstName+' '+scope.row.person.lastName }}
                        </div>

                    </template>
                </el-table-column>
                <el-table-column sortable
                                 label="Gender"
                                 width="100">
                    <template slot-scope="scope">
                        <div slot="reference" class="name-wrapper" v-if="scope.row.person.gender">
                            <el-tag size="medium">{{ scope.row.person.gender.name }}</el-tag>
                        </div>
                        <div slot="reference" class="name-wrapper" v-if="!scope.row.person.gender">
                            <el-tag size="medium">Gender is missing</el-tag>
                        </div>
                    </template>
                </el-table-column>
                <el-table-column sortable
                                 label="Relation"
                                 width="180">
                    <template slot-scope="scope">
                        {{ scope.row.relation.name }}
                    </template>
                </el-table-column>
                <el-table-column label="Contact"
                                 width="100">
                    <template slot-scope="scope">
                        {{ scope.row.phone1 }}
                    </template>
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
                               :current-page.sync="ruleForm.dependentPersons.currentPage"
                               :page-sizes="[5,10, 20, 50, 100]"
                               :page-size="ruleForm.employee.dependentPersons.pageSize"
                               layout="total, sizes, prev, pager, next, jumper"
                               :total="ruleForm.employee.dependentPersons.rowCount">
                </el-pagination>
            </div>
        </template>
    </section>
</template>
<script>
     import { getCastList, getGenderList, getMaritalStatusList,getReligionsList,getLitracyList,
    getHealthStatusList, getCountryList, getProvinceList, getDistrictList, getMunVdcList, getWardList } from '@/api/table';
    import { addEmployee, deleteEmployee } from '@/api/employee';
    import { getUserByPerson } from '@/api/user';
import { Script } from 'vm';
    export default {
        props:['ruleForm.employee.dependentPersons'],
        data() {

            return {
                index: '',
                ruleForm: {                    
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
                        identityTypeId: null,
                        identityNumber: null,
                        identityIssueDate: null,
                        identityIssuePlace: null,
                        litracyId: null,
                        educationId: null,
                        eduInstitutionTypeId: null

                    },
                    religions: [],
                    casts: [],
                    addressTypes: [],
                    countrys1: [],
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
                    identityTypes: [],
                    litracys: [],
                    educations: [],
                    eduInstitutionTypes: [],

                }
            }
        },
            //created() {

            //},
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
