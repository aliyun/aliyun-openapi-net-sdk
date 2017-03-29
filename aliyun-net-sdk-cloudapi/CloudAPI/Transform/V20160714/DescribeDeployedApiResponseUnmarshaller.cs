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
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeDeployedApiResponseUnmarshaller
    {
        public static DescribeDeployedApiResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDeployedApiResponse describeDeployedApiResponse = new DescribeDeployedApiResponse();

			describeDeployedApiResponse.HttpResponse = context.HttpResponse;
			describeDeployedApiResponse.RequestId = context.StringValue("DescribeDeployedApi.RequestId");
			describeDeployedApiResponse.RegionId = context.StringValue("DescribeDeployedApi.RegionId");
			describeDeployedApiResponse.GroupId = context.StringValue("DescribeDeployedApi.GroupId");
			describeDeployedApiResponse.GroupName = context.StringValue("DescribeDeployedApi.GroupName");
			describeDeployedApiResponse.StageName = context.StringValue("DescribeDeployedApi.StageName");
			describeDeployedApiResponse.ApiId = context.StringValue("DescribeDeployedApi.ApiId");
			describeDeployedApiResponse.ApiName = context.StringValue("DescribeDeployedApi.ApiName");
			describeDeployedApiResponse.Description = context.StringValue("DescribeDeployedApi.Description");
			describeDeployedApiResponse.Visibility = context.StringValue("DescribeDeployedApi.Visibility");
			describeDeployedApiResponse.AuthType = context.StringValue("DescribeDeployedApi.AuthType");
			describeDeployedApiResponse.ResultType = context.StringValue("DescribeDeployedApi.ResultType");
			describeDeployedApiResponse.ResultSample = context.StringValue("DescribeDeployedApi.ResultSample");
			describeDeployedApiResponse.FailResultSample = context.StringValue("DescribeDeployedApi.FailResultSample");
			describeDeployedApiResponse.DeployedTime = context.StringValue("DescribeDeployedApi.DeployedTime");

			DescribeDeployedApiResponse.RequestConfig_ requestConfig = new DescribeDeployedApiResponse.RequestConfig_();
			requestConfig.RequestProtocol = context.StringValue("DescribeDeployedApi.RequestConfig.RequestProtocol");
			requestConfig.RequestHttpMethod = context.StringValue("DescribeDeployedApi.RequestConfig.RequestHttpMethod");
			requestConfig.RequestPath = context.StringValue("DescribeDeployedApi.RequestConfig.RequestPath");
			requestConfig.BodyFormat = context.StringValue("DescribeDeployedApi.RequestConfig.BodyFormat");
			requestConfig.PostBodyDescription = context.StringValue("DescribeDeployedApi.RequestConfig.PostBodyDescription");
			describeDeployedApiResponse.RequestConfig = requestConfig;

			DescribeDeployedApiResponse.ServiceConfig_ serviceConfig = new DescribeDeployedApiResponse.ServiceConfig_();
			serviceConfig.ServiceProtocol = context.StringValue("DescribeDeployedApi.ServiceConfig.ServiceProtocol");
			serviceConfig.ServiceAddress = context.StringValue("DescribeDeployedApi.ServiceConfig.ServiceAddress");
			serviceConfig.ServiceHttpMethod = context.StringValue("DescribeDeployedApi.ServiceConfig.ServiceHttpMethod");
			serviceConfig.ServicePath = context.StringValue("DescribeDeployedApi.ServiceConfig.ServicePath");
			serviceConfig.ServiceTimeout = context.IntegerValue("DescribeDeployedApi.ServiceConfig.ServiceTimeout");
			serviceConfig.Mock = context.EnumValue<DescribeDeployedApiResponse.ServiceConfig_.MockEnum>("DescribeDeployedApi.ServiceConfig.Mock");
			serviceConfig.MockResult = context.StringValue("DescribeDeployedApi.ServiceConfig.MockResult");
			serviceConfig.ServiceVpcEnable = context.EnumValue<DescribeDeployedApiResponse.ServiceConfig_.ServiceVpcEnableEnum>("DescribeDeployedApi.ServiceConfig.ServiceVpcEnable");

			DescribeDeployedApiResponse.ServiceConfig_.VpcConfig_ vpcConfig = new DescribeDeployedApiResponse.ServiceConfig_.VpcConfig_();
			vpcConfig.Name = context.StringValue("DescribeDeployedApi.ServiceConfig.VpcConfig.Name");
			vpcConfig.VpcId = context.StringValue("DescribeDeployedApi.ServiceConfig.VpcConfig.VpcId");
			vpcConfig.InstanceId = context.StringValue("DescribeDeployedApi.ServiceConfig.VpcConfig.InstanceId");
			vpcConfig.Port = context.IntegerValue("DescribeDeployedApi.ServiceConfig.VpcConfig.Port");
			serviceConfig.VpcConfig = vpcConfig;
			describeDeployedApiResponse.ServiceConfig = serviceConfig;

			DescribeDeployedApiResponse.OpenIdConnectConfig_ openIdConnectConfig = new DescribeDeployedApiResponse.OpenIdConnectConfig_();
			openIdConnectConfig.OpenIdApiType = context.StringValue("DescribeDeployedApi.OpenIdConnectConfig.OpenIdApiType");
			openIdConnectConfig.IdTokenParamName = context.StringValue("DescribeDeployedApi.OpenIdConnectConfig.IdTokenParamName");
			openIdConnectConfig.PublicKeyId = context.StringValue("DescribeDeployedApi.OpenIdConnectConfig.PublicKeyId");
			openIdConnectConfig.PublicKey = context.StringValue("DescribeDeployedApi.OpenIdConnectConfig.PublicKey");
			describeDeployedApiResponse.OpenIdConnectConfig = openIdConnectConfig;

			List<DescribeDeployedApiResponse.ErrorCodeSample> errorCodeSamples = new List<DescribeDeployedApiResponse.ErrorCodeSample>();
			for (int i = 0; i < context.Length("DescribeDeployedApi.ErrorCodeSamples.Length"); i++) {
				DescribeDeployedApiResponse.ErrorCodeSample errorCodeSample = new DescribeDeployedApiResponse.ErrorCodeSample();
				errorCodeSample.Code = context.StringValue("DescribeDeployedApi.ErrorCodeSamples["+ i +"].Code");
				errorCodeSample.Message = context.StringValue("DescribeDeployedApi.ErrorCodeSamples["+ i +"].Message");
				errorCodeSample.Description = context.StringValue("DescribeDeployedApi.ErrorCodeSamples["+ i +"].Description");

				errorCodeSamples.Add(errorCodeSample);
			}
			describeDeployedApiResponse.ErrorCodeSamples = errorCodeSamples;

			List<DescribeDeployedApiResponse.ResultDescription> resultDescriptions = new List<DescribeDeployedApiResponse.ResultDescription>();
			for (int i = 0; i < context.Length("DescribeDeployedApi.ResultDescriptions.Length"); i++) {
				DescribeDeployedApiResponse.ResultDescription resultDescription = new DescribeDeployedApiResponse.ResultDescription();
				resultDescription.Id = context.StringValue("DescribeDeployedApi.ResultDescriptions["+ i +"].Id");
				resultDescription.Pid = context.StringValue("DescribeDeployedApi.ResultDescriptions["+ i +"].Pid");
				resultDescription.HasChild = context.BooleanValue("DescribeDeployedApi.ResultDescriptions["+ i +"].HasChild");
				resultDescription.Key = context.StringValue("DescribeDeployedApi.ResultDescriptions["+ i +"].Key");
				resultDescription.Name = context.StringValue("DescribeDeployedApi.ResultDescriptions["+ i +"].Name");
				resultDescription.Mandatory = context.BooleanValue("DescribeDeployedApi.ResultDescriptions["+ i +"].Mandatory");
				resultDescription.Type = context.StringValue("DescribeDeployedApi.ResultDescriptions["+ i +"].Type");
				resultDescription.Description = context.StringValue("DescribeDeployedApi.ResultDescriptions["+ i +"].Description");

				resultDescriptions.Add(resultDescription);
			}
			describeDeployedApiResponse.ResultDescriptions = resultDescriptions;

			List<DescribeDeployedApiResponse.SystemParameter> systemParameters = new List<DescribeDeployedApiResponse.SystemParameter>();
			for (int i = 0; i < context.Length("DescribeDeployedApi.SystemParameters.Length"); i++) {
				DescribeDeployedApiResponse.SystemParameter systemParameter = new DescribeDeployedApiResponse.SystemParameter();
				systemParameter.ParameterName = context.StringValue("DescribeDeployedApi.SystemParameters["+ i +"].ParameterName");
				systemParameter.ServiceParameterName = context.StringValue("DescribeDeployedApi.SystemParameters["+ i +"].ServiceParameterName");
				systemParameter.Location = context.StringValue("DescribeDeployedApi.SystemParameters["+ i +"].Location");
				systemParameter.DemoValue = context.StringValue("DescribeDeployedApi.SystemParameters["+ i +"].DemoValue");
				systemParameter.Description = context.StringValue("DescribeDeployedApi.SystemParameters["+ i +"].Description");

				systemParameters.Add(systemParameter);
			}
			describeDeployedApiResponse.SystemParameters = systemParameters;

			List<DescribeDeployedApiResponse.CustomSystemParameter> customSystemParameters = new List<DescribeDeployedApiResponse.CustomSystemParameter>();
			for (int i = 0; i < context.Length("DescribeDeployedApi.CustomSystemParameters.Length"); i++) {
				DescribeDeployedApiResponse.CustomSystemParameter customSystemParameter = new DescribeDeployedApiResponse.CustomSystemParameter();
				customSystemParameter.ParameterName = context.StringValue("DescribeDeployedApi.CustomSystemParameters["+ i +"].ParameterName");
				customSystemParameter.ServiceParameterName = context.StringValue("DescribeDeployedApi.CustomSystemParameters["+ i +"].ServiceParameterName");
				customSystemParameter.Location = context.StringValue("DescribeDeployedApi.CustomSystemParameters["+ i +"].Location");
				customSystemParameter.DemoValue = context.StringValue("DescribeDeployedApi.CustomSystemParameters["+ i +"].DemoValue");
				customSystemParameter.Description = context.StringValue("DescribeDeployedApi.CustomSystemParameters["+ i +"].Description");

				customSystemParameters.Add(customSystemParameter);
			}
			describeDeployedApiResponse.CustomSystemParameters = customSystemParameters;

			List<DescribeDeployedApiResponse.ConstantParameter> constantParameters = new List<DescribeDeployedApiResponse.ConstantParameter>();
			for (int i = 0; i < context.Length("DescribeDeployedApi.ConstantParameters.Length"); i++) {
				DescribeDeployedApiResponse.ConstantParameter constantParameter = new DescribeDeployedApiResponse.ConstantParameter();
				constantParameter.ServiceParameterName = context.StringValue("DescribeDeployedApi.ConstantParameters["+ i +"].ServiceParameterName");
				constantParameter.ConstantValue = context.StringValue("DescribeDeployedApi.ConstantParameters["+ i +"].ConstantValue");
				constantParameter.Location = context.StringValue("DescribeDeployedApi.ConstantParameters["+ i +"].Location");
				constantParameter.Description = context.StringValue("DescribeDeployedApi.ConstantParameters["+ i +"].Description");

				constantParameters.Add(constantParameter);
			}
			describeDeployedApiResponse.ConstantParameters = constantParameters;

			List<DescribeDeployedApiResponse.RequestParameter> requestParameters = new List<DescribeDeployedApiResponse.RequestParameter>();
			for (int i = 0; i < context.Length("DescribeDeployedApi.RequestParameters.Length"); i++) {
				DescribeDeployedApiResponse.RequestParameter requestParameter = new DescribeDeployedApiResponse.RequestParameter();
				requestParameter.ApiParameterName = context.StringValue("DescribeDeployedApi.RequestParameters["+ i +"].ApiParameterName");
				requestParameter.Location = context.StringValue("DescribeDeployedApi.RequestParameters["+ i +"].Location");
				requestParameter.ParameterType = context.StringValue("DescribeDeployedApi.RequestParameters["+ i +"].ParameterType");
				requestParameter.Required = context.StringValue("DescribeDeployedApi.RequestParameters["+ i +"].Required");
				requestParameter.DefaultValue = context.StringValue("DescribeDeployedApi.RequestParameters["+ i +"].DefaultValue");
				requestParameter.DemoValue = context.StringValue("DescribeDeployedApi.RequestParameters["+ i +"].DemoValue");
				requestParameter.MaxValue = context.LongValue("DescribeDeployedApi.RequestParameters["+ i +"].MaxValue");
				requestParameter.MinValue = context.LongValue("DescribeDeployedApi.RequestParameters["+ i +"].MinValue");
				requestParameter.MaxLength = context.LongValue("DescribeDeployedApi.RequestParameters["+ i +"].MaxLength");
				requestParameter.MinLength = context.LongValue("DescribeDeployedApi.RequestParameters["+ i +"].MinLength");
				requestParameter.RegularExpression = context.StringValue("DescribeDeployedApi.RequestParameters["+ i +"].RegularExpression");
				requestParameter.JsonScheme = context.StringValue("DescribeDeployedApi.RequestParameters["+ i +"].JsonScheme");
				requestParameter.EnumValue = context.StringValue("DescribeDeployedApi.RequestParameters["+ i +"].EnumValue");
				requestParameter.DocShow = context.StringValue("DescribeDeployedApi.RequestParameters["+ i +"].DocShow");
				requestParameter.DocOrder = context.IntegerValue("DescribeDeployedApi.RequestParameters["+ i +"].DocOrder");
				requestParameter.Description = context.StringValue("DescribeDeployedApi.RequestParameters["+ i +"].Description");

				requestParameters.Add(requestParameter);
			}
			describeDeployedApiResponse.RequestParameters = requestParameters;

			List<DescribeDeployedApiResponse.ServiceParameter> serviceParameters = new List<DescribeDeployedApiResponse.ServiceParameter>();
			for (int i = 0; i < context.Length("DescribeDeployedApi.ServiceParameters.Length"); i++) {
				DescribeDeployedApiResponse.ServiceParameter serviceParameter = new DescribeDeployedApiResponse.ServiceParameter();
				serviceParameter.ServiceParameterName = context.StringValue("DescribeDeployedApi.ServiceParameters["+ i +"].ServiceParameterName");
				serviceParameter.Location = context.StringValue("DescribeDeployedApi.ServiceParameters["+ i +"].Location");
				serviceParameter.ParameterType = context.StringValue("DescribeDeployedApi.ServiceParameters["+ i +"].ParameterType");

				serviceParameters.Add(serviceParameter);
			}
			describeDeployedApiResponse.ServiceParameters = serviceParameters;

			List<DescribeDeployedApiResponse.ServiceParameterMap> serviceParametersMap = new List<DescribeDeployedApiResponse.ServiceParameterMap>();
			for (int i = 0; i < context.Length("DescribeDeployedApi.ServiceParametersMap.Length"); i++) {
				DescribeDeployedApiResponse.ServiceParameterMap serviceParameterMap = new DescribeDeployedApiResponse.ServiceParameterMap();
				serviceParameterMap.ServiceParameterName = context.StringValue("DescribeDeployedApi.ServiceParametersMap["+ i +"].ServiceParameterName");
				serviceParameterMap.RequestParameterName = context.StringValue("DescribeDeployedApi.ServiceParametersMap["+ i +"].RequestParameterName");

				serviceParametersMap.Add(serviceParameterMap);
			}
			describeDeployedApiResponse.ServiceParametersMap = serviceParametersMap;
        
			return describeDeployedApiResponse;
        }
    }
}