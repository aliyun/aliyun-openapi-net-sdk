/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CloudAPI.Model.V20160714;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeDeployedApiResponseUnmarshaller
    {
        public static DescribeDeployedApiResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDeployedApiResponse describeDeployedApiResponse = new DescribeDeployedApiResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDeployedApi.RequestId"),
                RegionId = context.StringValue("DescribeDeployedApi.RegionId"),
                GroupId = context.StringValue("DescribeDeployedApi.GroupId"),
                GroupName = context.StringValue("DescribeDeployedApi.GroupName"),
                StageName = context.StringValue("DescribeDeployedApi.StageName"),
                ApiId = context.StringValue("DescribeDeployedApi.ApiId"),
                ApiName = context.StringValue("DescribeDeployedApi.ApiName"),
                Description = context.StringValue("DescribeDeployedApi.Description"),
                Visibility = context.StringValue("DescribeDeployedApi.Visibility"),
                AuthType = context.StringValue("DescribeDeployedApi.AuthType"),
                ResultType = context.StringValue("DescribeDeployedApi.ResultType"),
                ResultSample = context.StringValue("DescribeDeployedApi.ResultSample"),
                FailResultSample = context.StringValue("DescribeDeployedApi.FailResultSample"),
                DeployedTime = context.StringValue("DescribeDeployedApi.DeployedTime")
            };
            DescribeDeployedApiResponse.RequestConfig_ requestConfig = new DescribeDeployedApiResponse.RequestConfig_()
            {
                RequestProtocol = context.StringValue("DescribeDeployedApi.RequestConfig.RequestProtocol"),
                RequestHttpMethod = context.StringValue("DescribeDeployedApi.RequestConfig.RequestHttpMethod"),
                RequestPath = context.StringValue("DescribeDeployedApi.RequestConfig.RequestPath"),
                BodyFormat = context.StringValue("DescribeDeployedApi.RequestConfig.BodyFormat"),
                PostBodyDescription = context.StringValue("DescribeDeployedApi.RequestConfig.PostBodyDescription")
            };
            describeDeployedApiResponse.RequestConfig = requestConfig;

            DescribeDeployedApiResponse.ServiceConfig_ serviceConfig = new DescribeDeployedApiResponse.ServiceConfig_()
            {
                ServiceProtocol = context.StringValue("DescribeDeployedApi.ServiceConfig.ServiceProtocol"),
                ServiceAddress = context.StringValue("DescribeDeployedApi.ServiceConfig.ServiceAddress"),
                ServiceHttpMethod = context.StringValue("DescribeDeployedApi.ServiceConfig.ServiceHttpMethod"),
                ServicePath = context.StringValue("DescribeDeployedApi.ServiceConfig.ServicePath"),
                ServiceTimeout = context.IntegerValue("DescribeDeployedApi.ServiceConfig.ServiceTimeout")
            };
            describeDeployedApiResponse.ServiceConfig = serviceConfig;

			List<DescribeDeployedApiResponse.ErrorCodeSample> errorCodeSamples = new List<DescribeDeployedApiResponse.ErrorCodeSample>();
			for (int i = 0; i < context.Length("DescribeDeployedApi.ErrorCodeSamples.Length"); i++) {
                DescribeDeployedApiResponse.ErrorCodeSample errorCodeSample = new DescribeDeployedApiResponse.ErrorCodeSample()
                {
                    Code = context.StringValue($"DescribeDeployedApi.ErrorCodeSamples[{i}].Code"),
                    Message = context.StringValue($"DescribeDeployedApi.ErrorCodeSamples[{i}].Message"),
                    Description = context.StringValue($"DescribeDeployedApi.ErrorCodeSamples[{i}].Description")
                };
                errorCodeSamples.Add(errorCodeSample);
			}
			describeDeployedApiResponse.ErrorCodeSamples = errorCodeSamples;

			List<DescribeDeployedApiResponse.SystemParameter> systemParameters = new List<DescribeDeployedApiResponse.SystemParameter>();
			for (int i = 0; i < context.Length("DescribeDeployedApi.SystemParameters.Length"); i++) {
                DescribeDeployedApiResponse.SystemParameter systemParameter = new DescribeDeployedApiResponse.SystemParameter()
                {
                    ParameterName = context.StringValue($"DescribeDeployedApi.SystemParameters[{i}].ParameterName"),
                    ServiceParameterName = context.StringValue($"DescribeDeployedApi.SystemParameters[{i}].ServiceParameterName"),
                    Location = context.StringValue($"DescribeDeployedApi.SystemParameters[{i}].Location"),
                    DemoValue = context.StringValue($"DescribeDeployedApi.SystemParameters[{i}].DemoValue"),
                    Description = context.StringValue($"DescribeDeployedApi.SystemParameters[{i}].Description")
                };
                systemParameters.Add(systemParameter);
			}
			describeDeployedApiResponse.SystemParameters = systemParameters;

			List<DescribeDeployedApiResponse.ConstantParameter> constantParameters = new List<DescribeDeployedApiResponse.ConstantParameter>();
			for (int i = 0; i < context.Length("DescribeDeployedApi.ConstantParameters.Length"); i++) {
                DescribeDeployedApiResponse.ConstantParameter constantParameter = new DescribeDeployedApiResponse.ConstantParameter()
                {
                    ServiceParameterName = context.StringValue($"DescribeDeployedApi.ConstantParameters[{i}].ServiceParameterName"),
                    ConstantValue = context.StringValue($"DescribeDeployedApi.ConstantParameters[{i}].ConstantValue"),
                    Location = context.StringValue($"DescribeDeployedApi.ConstantParameters[{i}].Location"),
                    Description = context.StringValue($"DescribeDeployedApi.ConstantParameters[{i}].Description")
                };
                constantParameters.Add(constantParameter);
			}
			describeDeployedApiResponse.ConstantParameters = constantParameters;

			List<DescribeDeployedApiResponse.RequestParameter> requestParameters = new List<DescribeDeployedApiResponse.RequestParameter>();
			for (int i = 0; i < context.Length("DescribeDeployedApi.RequestParameters.Length"); i++) {
                DescribeDeployedApiResponse.RequestParameter requestParameter = new DescribeDeployedApiResponse.RequestParameter()
                {
                    ApiParameterName = context.StringValue($"DescribeDeployedApi.RequestParameters[{i}].ApiParameterName"),
                    Location = context.StringValue($"DescribeDeployedApi.RequestParameters[{i}].Location"),
                    ParameterType = context.StringValue($"DescribeDeployedApi.RequestParameters[{i}].ParameterType"),
                    Required = context.StringValue($"DescribeDeployedApi.RequestParameters[{i}].Required"),
                    DefaultValue = context.StringValue($"DescribeDeployedApi.RequestParameters[{i}].DefaultValue"),
                    DemoValue = context.StringValue($"DescribeDeployedApi.RequestParameters[{i}].DemoValue"),
                    MaxValue = context.LongValue($"DescribeDeployedApi.RequestParameters[{i}].MaxValue"),
                    MinValue = context.LongValue($"DescribeDeployedApi.RequestParameters[{i}].MinValue"),
                    MaxLength = context.LongValue($"DescribeDeployedApi.RequestParameters[{i}].MaxLength"),
                    MinLength = context.LongValue($"DescribeDeployedApi.RequestParameters[{i}].MinLength"),
                    RegularExpression = context.StringValue($"DescribeDeployedApi.RequestParameters[{i}].RegularExpression"),
                    JsonScheme = context.StringValue($"DescribeDeployedApi.RequestParameters[{i}].JsonScheme"),
                    EnumValue = context.StringValue($"DescribeDeployedApi.RequestParameters[{i}].EnumValue"),
                    DocShow = context.StringValue($"DescribeDeployedApi.RequestParameters[{i}].DocShow"),
                    DocOrder = context.IntegerValue($"DescribeDeployedApi.RequestParameters[{i}].DocOrder"),
                    Description = context.StringValue($"DescribeDeployedApi.RequestParameters[{i}].Description")
                };
                requestParameters.Add(requestParameter);
			}
			describeDeployedApiResponse.RequestParameters = requestParameters;

			List<DescribeDeployedApiResponse.ServiceParameter> serviceParameters = new List<DescribeDeployedApiResponse.ServiceParameter>();
			for (int i = 0; i < context.Length("DescribeDeployedApi.ServiceParameters.Length"); i++) {
                DescribeDeployedApiResponse.ServiceParameter serviceParameter = new DescribeDeployedApiResponse.ServiceParameter()
                {
                    ServiceParameterName = context.StringValue($"DescribeDeployedApi.ServiceParameters[{i}].ServiceParameterName"),
                    Location = context.StringValue($"DescribeDeployedApi.ServiceParameters[{i}].Location"),
                    ParameterType = context.StringValue($"DescribeDeployedApi.ServiceParameters[{i}].ParameterType")
                };
                serviceParameters.Add(serviceParameter);
			}
			describeDeployedApiResponse.ServiceParameters = serviceParameters;

			List<DescribeDeployedApiResponse.ServiceParameterMap> serviceParametersMap = new List<DescribeDeployedApiResponse.ServiceParameterMap>();
			for (int i = 0; i < context.Length("DescribeDeployedApi.ServiceParametersMap.Length"); i++) {
                DescribeDeployedApiResponse.ServiceParameterMap serviceParameterMap = new DescribeDeployedApiResponse.ServiceParameterMap()
                {
                    ServiceParameterName = context.StringValue($"DescribeDeployedApi.ServiceParametersMap[{i}].ServiceParameterName"),
                    RequestParameterName = context.StringValue($"DescribeDeployedApi.ServiceParametersMap[{i}].RequestParameterName")
                };
                serviceParametersMap.Add(serviceParameterMap);
			}
			describeDeployedApiResponse.ServiceParametersMap = serviceParametersMap;
        
			return describeDeployedApiResponse;
        }
    }
}