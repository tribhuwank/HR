<template>
    <section style="margin:20px;">
        <el-button round @click="handleusers()" style="margin:20px;float:right">Back to Users</el-button>
          <el-button round @click="handleAdd()" style="margin:20px;float:right">ADD ROLE</el-button>
     
          <template>
              <el-table :data="roletableData.results" v-loading="loading"
                        style="width: 100%">
                  <el-table-column type="index"
                                   :index="indexMethod">
                  </el-table-column>
                  <el-table-column prop="name" sortable
                                   label="Name"
                                   width="180">
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
                                 :current-page.sync="roletableData.currentPage"
                                 :page-sizes="[5,10, 20, 50, 100]"
                                 :page-size="roletableData.pageSize"
                                 layout="total, sizes, prev, pager, next, jumper"
                                 :total="roletableData.rowcount">
                  </el-pagination>
              </div>
          </template>
    </section>
</template>

<script>
    import { getPagedRoleList } from '@/api/table';
    import { deleteRole } from '@/api/user';
    export default {
        data() {
            return {
                roletableData: [],  
                loading: false,
                search: ''
            }
        },
        methods: {
            handleSizeChange(val) {
                this.getRoles(1, val);

            },
            handleCurrentChange(val) {
                this.getRoles(val, 5);
            },
            getRoles: function (page, pageSize) {
               
                this.loading = true;
                var params = { page: page, pageSize: pageSize }
                return new Promise((resolve, reject) => {
                    getPagedRoleList(params).then((res) => {
                    this.roletableData = res.result;
                    console.log(this.roletableData);
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
                this.$router.push({ path: 'role-edit', name:'role-edit', params: { row: row } });
            },
            handleDelete(index, row) {
                this.$confirm('This will permanently delete the Role. Continue?', 'Warning', {
                    confirmButtonText: 'OK',
                    cancelButtonText: 'Cancel',
                    type: 'warning'
                }).then(() => {
                    this.loading = true;
                    //NProgress.start();

                    var roleParams = { Name: row.name, Id: row.id };
                    deleteRole(roleParams).then((res) => {                       
                        this.loading = false;
                        //NProgress.done();
                        this.getRoles();
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
                this.$router.push({ path: 'role-add', name: 'role-add', meta: { requiresAuth: true, adminAuth: true, operatorAuth: false } });
            },
            handleusers() {
                this.$router.push({ path: 'user', name: 'user', meta: { requiresAuth: true, adminAuth: true, operatorAuth: false } });
            }
        },
        mounted() {
            this.getRoles(1,5);
        }
    };
</script>
<style scoped>
    
</style>