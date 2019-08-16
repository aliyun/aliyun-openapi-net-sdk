#!/usr/bin/env node

'use strict';

const fs = require('fs');
const template = fs.readFileSync('./source/RetryConfig.cs.template').toString();
const retry_config = require('../aliyun-net-sdk-core/Retry/Util/retry_config.json');
const timeout_config = require('../aliyun-net-sdk-core/Timeout/Util/timeout_config.json');
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

function convert_retry_config() {
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

            str += emit(`${productVarName}.versions.Add("${version}", ${versionVarName});`);
        }
        str += emit('');
        str += emit(`products.Add("${product}", ${productVarName});`);
    }
    return str;
}

function convert_timeout_config() {
    var str = "";
    for (const product in timeout_config) {
        const productVarName = "product" + product.capitalize();
        str += emit(`Product ${productVarName} = new Product();`)
        str += emit(`${productVarName}.ProductName = "${product}";`)
        for (const version in timeout_config[product]) {
            const versionVarName = "version" + version.replace("-", "").replace("-", "");
            str += emit(`Version ${versionVarName} = new Version();`);
            str += emit(`${versionVarName}.VersionDate = "${version}";`);
            for (const api in timeout_config[product][version]) {
                const timeout = timeout_config[product][version][api];
                str += emit(`${versionVarName}.Apis.Add("${api}", ${timeout});`);
            }

            str += emit(`${productVarName}.versions.Add("${version}", ${versionVarName});`);
        }
        str += emit('');
        str += emit(`products.Add("${product}", ${productVarName});`);
    }
    return str;
}

fs.writeFileSync('../aliyun-net-sdk-core/Retry/Util/RetryConfig.cs',
    render(
        fs.readFileSync('./source/RetryConfig.cs.template').toString(), {
            retry_config_data: convert_retry_config(retry_config)
        }
    )
);

fs.writeFileSync('../aliyun-net-sdk-core/Timeout/Util/TimeoutConfig.cs',
    render(
        fs.readFileSync('./source/TimeoutConfig.cs.template').toString(), {
            timeout_config_data: convert_timeout_config(timeout_config)
        }
    )
);