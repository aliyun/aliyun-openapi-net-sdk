#!/usr/bin/env node

'use strict';

const fs = require('fs');

const retry_config = require('../aliyun-net-sdk-core/Retry/Util/retry_config.json');
const timeout_config = require('../aliyun-net-sdk-core/Timeout/Util/timeout_config.json');
const endpoints = require('../aliyun-net-sdk-core/Regions/endpoints.json');

var level = 4;
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

function emit(content, levelRow) {
    if (levelRow === undefined) {
        levelRow = level;
    }
    return "\n" + ' '.repeat(levelRow * 4) + content;
}

function convert_retry_config() {
    level = 4;
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
        str += emit(`try { products.Add("${product}", ${productVarName}); }`);
        str += emit(`catch (ArgumentException) { }`);
    }
    return str;
}

function convert_timeout_config() {
    level = 4;
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
        str += emit(`try { products.Add("${product}", ${productVarName}); }`);
        str += emit(`catch (ArgumentException) { }`);
    }
    return str;
}

function convert_endpoints() {
    level = 4;
    var params = {
        global_endpoints: "",
        regional_endpoints: "",
        regions: "",
        regional_endpoint_pattern: "",
        location_code_mapping: ""
    };
    for (const product in endpoints["global_endpoints"]) {
        params.global_endpoints += emit(`GlobalEndpoints.Add("${product}", "${endpoints["global_endpoints"][product]}");`);
    }
    for (const product in endpoints["regional_endpoints"]) {
        for (const region_id in endpoints["regional_endpoints"][product]) {
            params.regional_endpoints += emit(`RegionalEndpoints.Add("${product}_${region_id}", "${endpoints["regional_endpoints"][product][region_id]}");`);
        }
    }
    for (const index in endpoints["regions"]) {
        params.regions += emit(`Regions.Add("${endpoints["regions"][index]}");`);
    }
    for (const product in endpoints["regional_endpoint_pattern"]) {
        params.regional_endpoint_pattern += emit(`RegionalEndpointPattern.Add("${product}", "${endpoints["regional_endpoint_pattern"][product]}");`);
    }
    for (const product in endpoints["location_code_mapping"]) {
        params.location_code_mapping += emit(`LocationCodeMapping.Add("${product}", "${endpoints["location_code_mapping"][product]}");`);
    }
    return params;
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

fs.writeFileSync('../aliyun-net-sdk-core/Regions/EndpointResource.cs',
    render(
        fs.readFileSync('./source/EndpointResource.cs.template').toString(), convert_endpoints()
    )
);