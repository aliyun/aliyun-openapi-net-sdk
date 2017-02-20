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
    public class DescribeApiHistoryResponseUnmarshaller
    {
        public static DescribeApiHistoryResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeApiHistoryResponse describeApiHistoryResponse = new DescribeApiHistoryResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeApiHistory.RequestId"),
                RegionId = context.StringValue("DescribeApiHistory.RegionId"),
                GroupId = context.StringValue("DescribeApiHistory.GroupId"),
                GroupName = context.StringValue("DescribeApiHistory.GroupName"),
                StageName = context.StringValue("DescribeApiHistory.StageName"),
                ApiId = context.StringValue("DescribeApiHistory.ApiId"),
                ApiName = context.StringValue("DescribeApiHistory.ApiName"),
                Description = context.StringValue("DescribeApiHistory.Description"),
                HistoryVersion = context.StringValue("DescribeApiHistory.HistoryVersion"),
                Status = context.StringValue("DescribeApiHistory.Status"),
                Visibility = context.StringValue("DescribeApiHistory.Visibility"),
                AuthType = context.StringValue("DescribeApiHistory.AuthType"),
                ResultType = context.StringValue("DescribeApiHistory.ResultType"),
                ResultSample = context.StringValue("DescribeApiHistory.ResultSample"),
                FailResultSample = context.StringValue("DescribeApiHistory.FailResultSample"),
                DeployedTime = context.StringValue("DescribeApiHistory.DeployedTime")
            };
            DescribeApiHistoryResponse.RequestConfig_ requestConfig = new DescribeApiHistoryResponse.RequestConfig_()
            {
                RequestProtocol = context.StringValue("DescribeApiHistory.RequestConfig.RequestProtocol"),
                RequestHttpMethod = context.StringValue("DescribeApiHistory.RequestConfig.RequestHttpMethod"),
                RequestPath = context.StringValue("DescribeApiHistory.RequestConfig.RequestPath"),
                BodyFormat = context.StringValue("DescribeApiHistory.RequestConfig.BodyFormat"),
                PostBodyDescription = context.StringValue("DescribeApiHistory.RequestConfig.PostBodyDescription")
            };
            describeApiHistoryResponse.RequestConfig = requestConfig;

            DescribeApiHistoryResponse.ServiceConfig_ serviceConfig = new DescribeApiHistoryResponse.ServiceConfig_()
            {
                ServiceProtocol = context.StringValue("DescribeApiHistory.ServiceConfig.ServiceProtocol"),
                ServiceAddress = context.StringValue("DescribeApiHistory.ServiceConfig.ServiceAddress"),
                ServiceHttpMethod = context.StringValue("DescribeApiHistory.ServiceConfig.ServiceHttpMethod"),
                ServicePath = context.StringValue("DescribeApiHistory.ServiceConfig.ServicePath"),
                ServiceTimeout = context.IntegerValue("DescribeApiHistory.ServiceConfig.ServiceTimeout")
            };
            describeApiHistoryResponse.ServiceConfig = serviceConfig;

			List<DescribeApiHistoryResponse.ErrorCodeSample> errorCodeSamples = new List<DescribeApiHistoryResponse.ErrorCodeSample>();
			for (int i = 0; i < context.Length("DescribeApiHistory.ErrorCodeSamples.Length"); i++) {
                DescribeApiHistoryResponse.ErrorCodeSample errorCodeSample = new DescribeApiHistoryResponse.ErrorCodeSample()
                {
                    Code = context.StringValue($"DescribeApiHistory.ErrorCodeSamples[{i}].Code"),
                    Message = context.StringValue($"DescribeApiHistory.ErrorCodeSamples[{i}].Message"),
                    Description = context.StringValue($"DescribeApiHistory.ErrorCodeSamples[{i}].Description")
                };
                errorCodeSamples.Add(errorCodeSample);
			}
			describeApiHistoryResponse.ErrorCodeSamples = errorCodeSamples;

			List<DescribeApiHistoryResponse.SystemParameter> systemParameters = new List<DescribeApiHistoryResponse.SystemParameter>();
			for (int i = 0; i < context.Length("DescribeApiHistory.SystemParameters.Length"); i++) {
                DescribeApiHistoryResponse.SystemParameter systemParameter = new DescribeApiHistoryResponse.SystemParameter()
                {
                    ParameterName = context.StringValue($"DescribeApiHistory.SystemParameters[{i}].ParameterName"),
                    ServiceParameterName = context.StringValue($"DescribeApiHistory.SystemParameters[{i}].ServiceParameterName"),
                    Location = context.StringValue($"DescribeApiHistory.SystemParameters[{i}].Location"),
                    DemoValue = context.StringValue($"DescribeApiHistory.SystemParameters[{i}].DemoValue"),
                    Description = context.StringValue($"DescribeApiHistory.SystemParameters[{i}].Description")
                };
                systemParameters.Add(systemParameter);
			}
			describeApiHistoryResponse.SystemParameters = systemParameters;

			List<DescribeApiHistoryResponse.ConstantParameter> constantParameters = new List<DescribeApiHistoryResponse.ConstantParameter>();
			for (int i = 0; i < context.Length("DescribeApiHistory.ConstantParameters.Length"); i++) {
                DescribeApiHistoryResponse.ConstantParameter constantParameter = new DescribeApiHistoryResponse.ConstantParameter()
                {
                    ServiceParameterName = context.StringValue($"DescribeApiHistory.ConstantParameters[{i}].ServiceParameterName"),
                    ConstantValue = context.StringValue($"DescribeApiHistory.ConstantParameters[{i}].ConstantValue"),
                    Location = context.StringValue($"DescribeApiHistory.ConstantParameters[{i}].Location"),
                    Description = context.StringValue($"DescribeApiHistory.ConstantParameters[{i}].Description")
                };
                constantParameters.Add(constantParameter);
			}
			describeApiHistoryResponse.ConstantParameters = constantParameters;

			List<DescribeApiHistoryResponse.RequestParameter> requestParameters = new List<DescribeApiHistoryResponse.RequestParameter>();
			for (int i = 0; i < context.Length("DescribeApiHistory.RequestParameters.Length"); i++) {
                DescribeApiHistoryResponse.RequestParameter requestParameter = new DescribeApiHistoryResponse.RequestParameter()
                {
                    ApiParameterName = context.StringValue($"DescribeApiHistory.RequestParameters[{i}].ApiParameterName"),
                    Location = context.StringValue($"DescribeApiHistory.RequestParameters[{i}].Location"),
                    ParameterType = context.StringValue($"DescribeApiHistory.RequestParameters[{i}].ParameterType"),
                    Required = context.StringValue($"DescribeApiHistory.RequestParameters[{i}].Required"),
                    DefaultValue = context.StringValue($"DescribeApiHistory.RequestParameters[{i}].DefaultValue"),
                    DemoValue = context.StringValue($"DescribeApiHistory.RequestParameters[{i}].DemoValue"),
                    MaxValue = context.LongValue($"DescribeApiHistory.RequestParameters[{i}].MaxValue"),
                    MinValue = context.LongValue($"DescribeApiHistory.RequestParameters[{i}].MinValue"),
                    MaxLength = context.LongValue($"DescribeApiHistory.RequestParameters[{i}].MaxLength"),
                    MinLength = context.LongValue($"DescribeApiHistory.RequestParameters[{i}].MinLength"),
                    RegularExpression = context.StringValue($"DescribeApiHistory.RequestParameters[{i}].RegularExpression"),
                    JsonScheme = context.StringValue($"DescribeApiHistory.RequestParameters[{i}].JsonScheme"),
                    EnumValue = context.StringValue($"DescribeApiHistory.RequestParameters[{i}].EnumValue"),
                    DocShow = context.StringValue($"DescribeApiHistory.RequestParameters[{i}].DocShow"),
                    DocOrder = context.IntegerValue($"DescribeApiHistory.RequestParameters[{i}].DocOrder"),
                    Description = context.StringValue($"DescribeApiHistory.RequestParameters[{i}].Description")
                };
                requestParameters.Add(requestParameter);
			}
			describeApiHistoryResponse.RequestParameters = requestParameters;

			List<DescribeApiHistoryResponse.ServiceParameter> serviceParameters = new List<DescribeApiHistoryResponse.ServiceParameter>();
			for (int i = 0; i < context.Length("DescribeApiHistory.ServiceParameters.Length"); i++) {
                DescribeApiHistoryResponse.ServiceParameter serviceParameter = new DescribeApiHistoryResponse.ServiceParameter()
                {
                    ServiceParameterName = context.StringValue($"DescribeApiHistory.ServiceParameters[{i}].ServiceParameterName"),
                    Location = context.StringValue($"DescribeApiHistory.ServiceParameters[{i}].Location"),
                    ParameterType = context.StringValue($"DescribeApiHistory.ServiceParameters[{i}].ParameterType")
                };
                serviceParameters.Add(serviceParameter);
			}
			describeApiHistoryResponse.ServiceParameters = serviceParameters;

			List<DescribeApiHistoryResponse.ServiceParameterMap> serviceParametersMap = new List<DescribeApiHistoryResponse.ServiceParameterMap>();
			for (int i = 0; i < context.Length("DescribeApiHistory.ServiceParametersMap.Length"); i++) {
                DescribeApiHistoryResponse.ServiceParameterMap serviceParameterMap = new DescribeApiHistoryResponse.ServiceParameterMap()
                {
                    ServiceParameterName = context.StringValue($"DescribeApiHistory.ServiceParametersMap[{i}].ServiceParameterName"),
                    RequestParameterName = context.StringValue($"DescribeApiHistory.ServiceParametersMap[{i}].RequestParameterName")
                };
                serviceParametersMap.Add(serviceParameterMap);
			}
			describeApiHistoryResponse.ServiceParametersMap = serviceParametersMap;
        
			return describeApiHistoryResponse;
        }
    }
}