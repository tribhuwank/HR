<template>
    <section style="margin:20px;">
          <el-button round @click="handleAdd()" style="margin:20px;float:right">ADD EMPLOYEE</el-button>
     
          <template>
              <el-table :data="employees.results" v-loading="loading" 
                        :default-sort = "{prop: 'person.gender.name', order: 'descending'}"
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
                                   label="Department"
                                   width="180">
                      <template slot-scope="scope">
                          <div slot="reference" class="name-wrapper" v-if="scope.row.employeeJob.department">
                              {{ scope.row.employeeJob.department.name }}
                          </div>
                          <div slot="reference" class="name-wrapper" v-if="!scope.row.employeeJob.department">
                              Not assign yet
                          </div>
                      </template>
                  </el-table-column>
                  <el-table-column label="Post"
                                   width="180">
                      <template slot-scope="scope">
                          <div slot="reference" class="name-wrapper" v-if="scope.row.employeeJob.post">
                              {{ scope.row.employeeJob.post.name }}
                          </div>
                          <div slot="reference" class="name-wrapper" v-if="!scope.row.employeeJob.post">
                              Not assign yet
                          </div>
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
                                 :current-page.sync="employees.currentPage"
                                 :page-sizes="[5,10, 20, 50, 100]"
                                 :page-size="employees.pageSize"
                                 layout="total, sizes, prev, pager, next, jumper"
                                 :total="employees.rowCount">
                  </el-pagination>
              </div>
          </template>
    </section>
</template>

<script>
    import { getEmployeeList } from '@/api/table';
    import { deleteEmployee } from '@/api/employee';
    
    export default {
        data() {
            return {
                employees: [],  
                loading: false,
                search: '',
                index:''
            }
        },
        methods: {
            handleSizeChange(val) {
                this.getEmployees(1, val);
            },
            handleCurrentChange(val) {
                this.getEmployees(val, 5);
            },
            getImageFile: function (ImageURL) {
                return ImageURL;
            },
            
            
            getEmployees: function (page, pageSize) {
                this.loading = true;
                //NProgress.start();
                var params = { page: page, pageSize: pageSize }
                return new Promise((resolve, reject) => {
                    getEmployeeList(params).then((res) => {
                        this.employees = res.result;
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
                this.$router.push({ path: 'employee-edit', name: 'employee-edit', params: { row: row }, meta: { requiresAuth: true, adminAuth: true, operatorAuth: false } });
            },
            handleDelete(index, row) {
                this.$confirm('This will permanently delete the Role. Continue?', 'Warning', {
                    confirmButtonText: 'OK',
                    cancelButtonText: 'Cancel',
                    type: 'warning'
                }).then(() => {
                    this.loading = true;
                    //NProgress.start();

                    var employeeParams = { Id: row.id, PersonId: row.personId, Person: row.person, };
                    return new Promise((resolve, reject) => {
                        deleteEmployee(employeeParams).then((res) => {
                            this.loading = false;
                            //NProgress.done();
                            this.getEmployees();
                            this.$message({
                                type: 'success',
                                message: 'Delete completed'
                            });
                            resolve()
                        }).catch(error => {
                            this.$message({
                                type: 'info',
                                message: 'Delete canceled ' + error
                            });
                            this.loading = false;
                            reject(error)
                        })
                    })
                })
            },
         
            handleAdd() {
                this.$router.push({ path: 'employee-add', name: 'employee-add', meta: { requiresAuth: true, adminAuth: true, operatorAuth: false } });
            }
        },
        mounted() {
            this.getEmployees();
        }
    };
</script>
<style scoped>
    
</style>