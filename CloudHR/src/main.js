import Vue from "vue";
import App from "./App.vue";
import router from "./router";
import store from "./store";
//  reset CSS
import "normalize.css/normalize.css";

import ElementUI from "element-ui";
import "element-ui/lib/theme-chalk/index.css";
import locale from 'element-ui/lib/locale/lang/en'
import "./assets/iconfont/iconfont.css"
import '@/styles/index.scss' // global css

import '@/permission' // permission control

Vue.use(ElementUI, { locale });
Vue.config.productionTip = false;

new Vue({
    router,
    store,
    render: h => h(App)
}).$mount("#app");
