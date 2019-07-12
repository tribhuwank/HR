// Seven cattle upload plugin
const QiniuPlugin = require('qiniu-webpack-plugin');
const BundleAnalyzerPlugin = require('webpack-bundle-analyzer').BundleAnalyzerPlugin;
const path = require('path');

function resolve(dir) {
    return path.join(__dirname, dir)
}
module.exports = {
    // The base path for project deployment
    // We assume by default that your app will be deployed at the root of the domain name.，
    //For example https://www.my-app.com/
    // If your app is deployed under a subpath then you need to be here
    // Specify a subpath. For example, if your app is deployed in
    // https://www.foobar.com/my-app/
    // Then change this value to `/my-app/`
    baseUrl: '/',

    // Where will the constructed file be output?
    outputDir: 'wwwroot',
    

    // Where to place static resources (js/css/img/font/...)
    // assetsDir: '',

    // Whether to check with `eslint-loader` when saving。
    // Valid values: `ture` | `false` | `"error"
    // When set to `"error"`, the checked error will trigger the compilation to fail.
    lintOnSave: true,

    // Use a full build with an in-browser compiler
    // See https://cn.vuejs.org/v2/guide/installation.html#Runtime-Compiler-vs-only contains runtime
    // compiler: false,

    // By default, babel-loader skips the node_modules dependency.
    // This option allows you to explicitly translate a dependency.
    transpileDependencies: [/* string or regex */],

    // Is the source map generated for the production environment build?
    productionSourceMap: false,

    //Adjust the internal webpack configuration.
    // Check out https://github.com/vuejs/vue-docs-zh-cn/blob/master/vue-cli/webpack.md
    chainWebpack: config => {
        // aspnet uses the other hmr so remove this one
        config.plugins.delete('hmr');
    },
   // configureWebpack: () => { },

    // CSS related options
    css: {
        //Extract the CSS within the component into a single CSS file(used only in a production environment)
        // Can also be an option object passed to `extract-text-webpack-plugin`
        extract: true,

        // Do you want to enable CSS source map?
        sourceMap: false,

        // Pass custom options for the preprocessor's loader. Such as passing to
        // When using sass-loader, use `{ sass: { ... } }`.
        loaderOptions: {},

        // Turn on CSS Modules for all CSS and its preprocessed files.
        // his option does not affect the `*.vue` file.
        modules: false
    },

    // Use `thread-loader` for Babel and TypeScript in a production environment
    //It will be enabled by default on multi-core machines.
    parallel: require('os').cpus().length > 1,

    // Options for the PWA plugin.
    // Check out  https://github.com/vuejs/vue-docs-zh-cn/blob/master/vue-cli-plugin-pwa/README.md
    pwa: {},

    // Configure the webpack-dev-server behavior.
    devServer: {
        open: process.platform === 'darwin',
        host: 'localhost',
        port: 8888,
        https: false,
        hotOnly: false,
        //open:true,
        // 查阅 https://github.com/vuejs/vue-docs-zh-cn/blob/master/vue-cli/cli-service.md#配置代理
        proxy: 'http://localhost:3001', // string | Object
        before: app => { }
    },

    configureWebpack: config => {
        if (process.env.NODE_ENV === 'production') {
            // 为生产环境修改配置...
            if(process.env.npm_lifecycle_event === 'analyze'){
                config.plugins.push(
                    new BundleAnalyzerPlugin()
                );
            }
            
        } else {
            // 为开发环境修改配置...
        }
        
    },

    // 第三方插件的选项
    pluginOptions: {
       
    }
}