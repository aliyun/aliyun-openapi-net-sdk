#!/usr/bin/env node

'use strict';

const fs = require('fs');
const template = fs.readFileSync('./source/RetryConfig.cs.template').toString();
const retry_config = require('../aliyun-net-sdk-core/Retry/Util/retry_config.json');
const level = 3;

String.prototype.capitalize = function () {
    return this.charAt(0).toUpperCase() + this.slice(1);
}

function render(template, param) {
    var str = template;
    for (const key in param) {
        str = str.replace("{" + key + "}", param[key])
    }
    return str;
}

function emit(content) {
    return "\n" + ' '.repeat(level * 4) + content;
}

function convert(retry_config) {
    var str = "";
    for (const product in retry_config) {
        const productVarName = "product" + product.capitalize();
        str += emit(`Product ${productVarName} = new Product();`)
        str += emit(`${productVarName}.ProductName = "${product}";`)
        for (const version in retry_config[product]) {
            const versionVarName = "version" + version.replace("-", "").replace("-", "");
            str += emit(`Version ${versionVarName} = new Version();`);
            str += emit(`${versionVarName}.VersionDate = "${version}";`);
            for (const section in retry_config[product][version]) {
                for (const api of retry_config[product][version][section]) {
                    str += emit(`${versionVarName}.${section}.Add("${api}");`);
                }
            }
        }
    }
    return str;
}

var content = render(template, {
    retry_config_data: convert(retry_config)
});

fs.writeFileSync('../aliyun-net-sdk-core/Retry/Util/RetryConfig.cs', content);