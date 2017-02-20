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
    public class DescribeApiResponseUnmarshaller
    {
        public static DescribeApiResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeApiResponse describeApiResponse = new DescribeApiResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeApi.RequestId"),
                RegionId = context.StringValue("DescribeApi.RegionId"),
                ApiId = context.StringValue("DescribeApi.ApiId"),
                ApiName = context.StringValue("DescribeApi.ApiName"),
                GroupId = context.StringValue("DescribeApi.GroupId"),
                GroupName = context.StringValue("DescribeApi.GroupName"),
                Visibility = context.StringValue("DescribeApi.Visibility"),
                AuthType = context.StringValue("DescribeApi.AuthType"),
                ResultType = context.StringValue("DescribeApi.ResultType"),
                ResultSample = context.StringValue("DescribeApi.ResultSample"),
                FailResultSample = context.StringValue("DescribeApi.FailResultSample"),
                CreatedTime = context.StringValue("DescribeApi.CreatedTime"),
                ModifiedTime = context.StringValue("DescribeApi.ModifiedTime"),
                Description = context.StringValue("DescribeApi.Description"),
                Mock = context.StringValue("DescribeApi.Mock"),
                MockResult = context.StringValue("DescribeApi.MockResult")
            };
            DescribeApiResponse.RequestConfig_ requestConfig = new DescribeApiResponse.RequestConfig_()
            {
                RequestProtocol = context.StringValue("DescribeApi.RequestConfig.RequestProtocol"),
                RequestHttpMethod = context.StringValue("DescribeApi.RequestConfig.RequestHttpMethod"),
                RequestPath = context.StringValue("DescribeApi.RequestConfig.RequestPath"),
                BodyFormat = context.StringValue("DescribeApi.RequestConfig.BodyFormat"),
                PostBodyDescription = context.StringValue("DescribeApi.RequestConfig.PostBodyDescription")
            };
            describeApiResponse.RequestConfig = requestConfig;

            DescribeApiResponse.ServiceConfig_ serviceConfig = new DescribeApiResponse.ServiceConfig_()
            {
                ServiceProtocol = context.StringValue("DescribeApi.ServiceConfig.ServiceProtocol"),
                ServiceAddress = context.StringValue("DescribeApi.ServiceConfig.ServiceAddress"),
                ServiceHttpMethod = context.StringValue("DescribeApi.ServiceConfig.ServiceHttpMethod"),
                ServicePath = context.StringValue("DescribeApi.ServiceConfig.ServicePath"),
                ServiceTimeout = context.IntegerValue("DescribeApi.ServiceConfig.ServiceTimeout")
            };
            describeApiResponse.ServiceConfig = serviceConfig;

			List<DescribeApiResponse.ErrorCodeSample> errorCodeSamples = new List<DescribeApiResponse.ErrorCodeSample>();
			for (int i = 0; i < context.Length("DescribeApi.ErrorCodeSamples.Length"); i++) {
                DescribeApiResponse.ErrorCodeSample errorCodeSample = new DescribeApiResponse.ErrorCodeSample()
                {
                    Code = context.StringValue($"DescribeApi.ErrorCodeSamples[{i}].Code"),
                    Message = context.StringValue($"DescribeApi.ErrorCodeSamples[{i}].Message"),
                    Description = context.StringValue($"DescribeApi.ErrorCodeSamples[{i}].Description")
                };
                errorCodeSamples.Add(errorCodeSample);
			}
			describeApiResponse.ErrorCodeSamples = errorCodeSamples;

			List<DescribeApiResponse.SystemParameter> systemParameters = new List<DescribeApiResponse.SystemParameter>();
			for (int i = 0; i < context.Length("DescribeApi.SystemParameters.Length"); i++) {
                DescribeApiResponse.SystemParameter systemParameter = new DescribeApiResponse.SystemParameter()
                {
                    ParameterName = context.StringValue($"DescribeApi.SystemParameters[{i}].ParameterName"),
                    ServiceParameterName = context.StringValue($"DescribeApi.SystemParameters[{i}].ServiceParameterName"),
                    Location = context.StringValue($"DescribeApi.SystemParameters[{i}].Location"),
                    DemoValue = context.StringValue($"DescribeApi.SystemParameters[{i}].DemoValue"),
                    Description = context.StringValue($"DescribeApi.SystemParameters[{i}].Description")
                };
                systemParameters.Add(systemParameter);
			}
			describeApiResponse.SystemParameters = systemParameters;

			List<DescribeApiResponse.ConstantParameter> constantParameters = new List<DescribeApiResponse.ConstantParameter>();
			for (int i = 0; i < context.Length("DescribeApi.ConstantParameters.Length"); i++) {
                DescribeApiResponse.ConstantParameter constantParameter = new DescribeApiResponse.ConstantParameter()
                {
                    ServiceParameterName = context.StringValue($"DescribeApi.ConstantParameters[{i}].ServiceParameterName"),
                    ConstantValue = context.StringValue($"DescribeApi.ConstantParameters[{i}].ConstantValue"),
                    Location = context.StringValue($"DescribeApi.ConstantParameters[{i}].Location"),
                    Description = context.StringValue($"DescribeApi.ConstantParameters[{i}].Description")
                };
                constantParameters.Add(constantParameter);
			}
			describeApiResponse.ConstantParameters = constantParameters;

			List<DescribeApiResponse.RequestParameter> requestParameters = new List<DescribeApiResponse.RequestParameter>();
			for (int i = 0; i < context.Length("DescribeApi.RequestParameters.Length"); i++) {
                DescribeApiResponse.RequestParameter requestParameter = new DescribeApiResponse.RequestParameter()
                {
                    ApiParameterName = context.StringValue($"DescribeApi.RequestParameters[{i}].ApiParameterName"),
                    Location = context.StringValue($"DescribeApi.RequestParameters[{i}].Location"),
                    ParameterType = context.StringValue($"DescribeApi.RequestParameters[{i}].ParameterType"),
                    Required = context.StringValue($"DescribeApi.RequestParameters[{i}].Required"),
                    DefaultValue = context.StringValue($"DescribeApi.RequestParameters[{i}].DefaultValue"),
                    DemoValue = context.StringValue($"DescribeApi.RequestParameters[{i}].DemoValue"),
                    MaxValue = context.LongValue($"DescribeApi.RequestParameters[{i}].MaxValue"),
                    MinValue = context.LongValue($"DescribeApi.RequestParameters[{i}].MinValue"),
                    MaxLength = context.LongValue($"DescribeApi.RequestParameters[{i}].MaxLength"),
                    MinLength = context.LongValue($"DescribeApi.RequestParameters[{i}].MinLength"),
                    RegularExpression = context.StringValue($"DescribeApi.RequestParameters[{i}].RegularExpression"),
                    JsonScheme = context.StringValue($"DescribeApi.RequestParameters[{i}].JsonScheme"),
                    EnumValue = context.StringValue($"DescribeApi.RequestParameters[{i}].EnumValue"),
                    DocShow = context.StringValue($"DescribeApi.RequestParameters[{i}].DocShow"),
                    DocOrder = context.IntegerValue($"DescribeApi.RequestParameters[{i}].DocOrder"),
                    Description = context.StringValue($"DescribeApi.RequestParameters[{i}].Description")
                };
                requestParameters.Add(requestParameter);
			}
			describeApiResponse.RequestParameters = requestParameters;

			List<DescribeApiResponse.ServiceParameter> serviceParameters = new List<DescribeApiResponse.ServiceParameter>();
			for (int i = 0; i < context.Length("DescribeApi.ServiceParameters.Length"); i++) {
                DescribeApiResponse.ServiceParameter serviceParameter = new DescribeApiResponse.ServiceParameter()
                {
                    ServiceParameterName = context.StringValue($"DescribeApi.ServiceParameters[{i}].ServiceParameterName"),
                    Location = context.StringValue($"DescribeApi.ServiceParameters[{i}].Location"),
                    ParameterType = context.StringValue($"DescribeApi.ServiceParameters[{i}].ParameterType")
                };
                serviceParameters.Add(serviceParameter);
			}
			describeApiResponse.ServiceParameters = serviceParameters;

			List<DescribeApiResponse.ServiceParameterMap> serviceParametersMap = new List<DescribeApiResponse.ServiceParameterMap>();
			for (int i = 0; i < context.Length("DescribeApi.ServiceParametersMap.Length"); i++) {
                DescribeApiResponse.ServiceParameterMap serviceParameterMap = new DescribeApiResponse.ServiceParameterMap()
                {
                    ServiceParameterName = context.StringValue($"DescribeApi.ServiceParametersMap[{i}].ServiceParameterName"),
                    RequestParameterName = context.StringValue($"DescribeApi.ServiceParametersMap[{i}].RequestParameterName")
                };
                serviceParametersMap.Add(serviceParameterMap);
			}
			describeApiResponse.ServiceParametersMap = serviceParametersMap;

			List<DescribeApiResponse.DeployedInfo> deployedInfos = new List<DescribeApiResponse.DeployedInfo>();
			for (int i = 0; i < context.Length("DescribeApi.DeployedInfos.Length"); i++) {
                DescribeApiResponse.DeployedInfo deployedInfo = new DescribeApiResponse.DeployedInfo()
                {
                    StageName = context.StringValue($"DescribeApi.DeployedInfos[{i}].StageName"),
                    EffectiveVersion = context.StringValue($"DescribeApi.DeployedInfos[{i}].EffectiveVersion"),
                    DeployedStatus = context.StringValue($"DescribeApi.DeployedInfos[{i}].DeployedStatus")
                };
                deployedInfos.Add(deployedInfo);
			}
			describeApiResponse.DeployedInfos = deployedInfos;
        
			return describeApiResponse;
        }
    }
}