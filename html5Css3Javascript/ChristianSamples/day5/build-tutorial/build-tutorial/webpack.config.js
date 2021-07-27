var path = require('path');
var webpack = require('webpack');

module.exports = {
    entry: ['babel-polyfill', './scripts/app.js'],
    output: {
        path: path.resolve(__dirname, 'build'),
        filename: 'app.bundle.js'
    },
    module: {
        rules: [
            {
                test: /\.js$/,
                loader: 'babel-loader',
                options: {
                    presets: ["@babel/preset-env"],
                    plugins: ["transform-async-functions"]
                }
            }
        ]
    },
    stats: {
        colors: true
    },
    devtool: 'source-map'
};