const mix = require('laravel-mix');
const path = require('path');
const webpack = require('webpack');
const fs = require("fs");
const homedir = require("os").homedir();
require('laravel-mix-tailwind');

mix
    .setPublicPath('../wwwroot/')
    .ts('src/main.ts', 'js')
    .vue({
        version:3,
        extractStyles: false,
        globalStyles: false
    })
    .webpackConfig({
        devServer: {
            key: fs.readFileSync(
                path.resolve(`${homedir}/.office-addin-dev-certs/localhost.key`)
            ),
            cert: fs.readFileSync(
                path.resolve(`${homedir}/.office-addin-dev-certs/localhost.crt`)
            ),
            ca: fs.readFileSync(
                path.resolve(`${homedir}/.office-addin-dev-certs/ca.crt`)
            ),
            https: true
        },
        output: {
            chunkFilename: 'js/chunks/[name].js?id=[chunkhash]'
        },
        plugins: [
            new webpack.DefinePlugin({
                __VUE_OPTIONS_API__: true,
                __VUE_PROD_DEVTOOLS__: false
            }),
            new webpack.LoaderOptionsPlugin({
                options: {
                    test: /\.scss$/,
                    use: [
                        'vue-style-loader',
                        'css-loader',
                        'sass-loader'
                    ]
                }
            })
        ]
    })
    .sourceMaps(false, 'source-map')
    .browserSync({
        proxy: 'https://localhost:5001',
    });

if (mix.inProduction()) {
    mix.version();
}