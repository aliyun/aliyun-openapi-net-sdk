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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CloudAPI.Model.V20160714;

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
			describeDeployedApiResponse.AllowSignatureMethod = context.StringValue("DescribeDeployedApi.AllowSignatureMethod");
			describeDeployedApiResponse.ResultBodyModel = context.StringValue("DescribeDeployedApi.ResultBodyModel");
			describeDeployedApiResponse.ForceNonceCheck = context.BooleanValue("DescribeDeployedApi.ForceNonceCheck");
			describeDeployedApiResponse.DisableInternet = context.BooleanValue("DescribeDeployedApi.DisableInternet");

			DescribeDeployedApiResponse.DescribeDeployedApi_RequestConfig requestConfig = new DescribeDeployedApiResponse.DescribeDeployedApi_RequestConfig();
			requestConfig.RequestProtocol = context.StringValue("DescribeDeployedApi.RequestConfig.RequestProtocol");
			requestConfig.RequestHttpMethod = context.StringValue("DescribeDeployedApi.RequestConfig.RequestHttpMethod");
			requestConfig.RequestPath = context.StringValue("DescribeDeployedApi.RequestConfig.RequestPath");
			requestConfig.BodyFormat = context.StringValue("DescribeDeployedApi.RequestConfig.BodyFormat");
			requestConfig.PostBodyDescription = context.StringValue("DescribeDeployedApi.RequestConfig.PostBodyDescription");
			requestConfig.RequestMode = context.StringValue("DescribeDeployedApi.RequestConfig.RequestMode");
			requestConfig.BodyModel = context.StringValue("DescribeDeployedApi.RequestConfig.BodyModel");
			describeDeployedApiResponse.RequestConfig = requestConfig;

			DescribeDeployedApiResponse.DescribeDeployedApi_ServiceConfig serviceConfig = new DescribeDeployedApiResponse.DescribeDeployedApi_ServiceConfig();
			serviceConfig.ServiceProtocol = context.StringValue("DescribeDeployedApi.ServiceConfig.ServiceProtocol");
			serviceConfig.ServiceAddress = context.StringValue("DescribeDeployedApi.ServiceConfig.ServiceAddress");
			serviceConfig.ServiceHttpMethod = context.StringValue("DescribeDeployedApi.ServiceConfig.ServiceHttpMethod");
			serviceConfig.ServicePath = context.StringValue("DescribeDeployedApi.ServiceConfig.ServicePath");
			serviceConfig.ServiceTimeout = context.IntegerValue("DescribeDeployedApi.ServiceConfig.ServiceTimeout");
			serviceConfig.Mock = context.StringValue("DescribeDeployedApi.ServiceConfig.Mock");
			serviceConfig.MockResult = context.StringValue("DescribeDeployedApi.ServiceConfig.MockResult");
			serviceConfig.ServiceVpcEnable = context.StringValue("DescribeDeployedApi.ServiceConfig.ServiceVpcEnable");
			serviceConfig.MockStatusCode = context.IntegerValue("DescribeDeployedApi.ServiceConfig.MockStatusCode");
			serviceConfig.VpcId = context.StringValue("DescribeDeployedApi.ServiceConfig.VpcId");

			DescribeDeployedApiResponse.DescribeDeployedApi_ServiceConfig.DescribeDeployedApi_VpcConfig vpcConfig = new DescribeDeployedApiResponse.DescribeDeployedApi_ServiceConfig.DescribeDeployedApi_VpcConfig();
			vpcConfig.Name = context.StringValue("DescribeDeployedApi.ServiceConfig.VpcConfig.Name");
			vpcConfig.VpcId = context.StringValue("DescribeDeployedApi.ServiceConfig.VpcConfig.VpcId");
			vpcConfig.InstanceId = context.StringValue("DescribeDeployedApi.ServiceConfig.VpcConfig.InstanceId");
			vpcConfig.Port = context.IntegerValue("DescribeDeployedApi.ServiceConfig.VpcConfig.Port");
			serviceConfig.VpcConfig = vpcConfig;

			DescribeDeployedApiResponse.DescribeDeployedApi_ServiceConfig.DescribeDeployedApi_FunctionComputeConfig functionComputeConfig = new DescribeDeployedApiResponse.DescribeDeployedApi_ServiceConfig.DescribeDeployedApi_FunctionComputeConfig();
			functionComputeConfig.RegionId = context.StringValue("DescribeDeployedApi.ServiceConfig.FunctionComputeConfig.RegionId");
			functionComputeConfig.ServiceName = context.StringValue("DescribeDeployedApi.ServiceConfig.FunctionComputeConfig.ServiceName");
			functionComputeConfig.FunctionName = context.StringValue("DescribeDeployedApi.ServiceConfig.FunctionComputeConfig.FunctionName");
			functionComputeConfig.RoleArn = context.StringValue("DescribeDeployedApi.ServiceConfig.FunctionComputeConfig.RoleArn");
			serviceConfig.FunctionComputeConfig = functionComputeConfig;

			List<DescribeDeployedApiResponse.DescribeDeployedApi_ServiceConfig.DescribeDeployedApi_MockHeader> serviceConfig_mockHeaders = new List<DescribeDeployedApiResponse.DescribeDeployedApi_ServiceConfig.DescribeDeployedApi_MockHeader>();
			for (int i = 0; i < context.Length("DescribeDeployedApi.ServiceConfig.MockHeaders.Length"); i++) {
				DescribeDeployedApiResponse.DescribeDeployedApi_ServiceConfig.DescribeDeployedApi_MockHeader mockHeader = new DescribeDeployedApiResponse.DescribeDeployedApi_ServiceConfig.DescribeDeployedApi_MockHeader();
				mockHeader.HeaderName = context.StringValue("DescribeDeployedApi.ServiceConfig.MockHeaders["+ i +"].HeaderName");
				mockHeader.HeaderValue = context.StringValue("DescribeDeployedApi.ServiceConfig.MockHeaders["+ i +"].HeaderValue");

				serviceConfig_mockHeaders.Add(mockHeader);
			}
			serviceConfig.MockHeaders = serviceConfig_mockHeaders;
			describeDeployedApiResponse.ServiceConfig = serviceConfig;

			DescribeDeployedApiResponse.DescribeDeployedApi_OpenIdConnectConfig openIdConnectConfig = new DescribeDeployedApiResponse.DescribeDeployedApi_OpenIdConnectConfig();
			openIdConnectConfig.OpenIdApiType = context.StringValue("DescribeDeployedApi.OpenIdConnectConfig.OpenIdApiType");
			openIdConnectConfig.IdTokenParamName = context.StringValue("DescribeDeployedApi.OpenIdConnectConfig.IdTokenParamName");
			openIdConnectConfig.PublicKeyId = context.StringValue("DescribeDeployedApi.OpenIdConnectConfig.PublicKeyId");
			openIdConnectConfig.PublicKey = context.StringValue("DescribeDeployedApi.OpenIdConnectConfig.PublicKey");
			describeDeployedApiResponse.OpenIdConnectConfig = openIdConnectConfig;

			List<DescribeDeployedApiResponse.DescribeDeployedApi_ErrorCodeSample> describeDeployedApiResponse_errorCodeSamples = new List<DescribeDeployedApiResponse.DescribeDeployedApi_ErrorCodeSample>();
			for (int i = 0; i < context.Length("DescribeDeployedApi.ErrorCodeSamples.Length"); i++) {
				DescribeDeployedApiResponse.DescribeDeployedApi_ErrorCodeSample errorCodeSample = new DescribeDeployedApiResponse.DescribeDeployedApi_ErrorCodeSample();
				errorCodeSample.Code = context.StringValue("DescribeDeployedApi.ErrorCodeSamples["+ i +"].Code");
				errorCodeSample.Message = context.StringValue("DescribeDeployedApi.ErrorCodeSamples["+ i +"].Message");
				errorCodeSample.Description = context.StringValue("DescribeDeployedApi.ErrorCodeSamples["+ i +"].Description");

				describeDeployedApiResponse_errorCodeSamples.Add(errorCodeSample);
			}
			describeDeployedApiResponse.ErrorCodeSamples = describeDeployedApiResponse_errorCodeSamples;

			List<DescribeDeployedApiResponse.DescribeDeployedApi_ResultDescription> describeDeployedApiResponse_resultDescriptions = new List<DescribeDeployedApiResponse.DescribeDeployedApi_ResultDescription>();
			for (int i = 0; i < context.Length("DescribeDeployedApi.ResultDescriptions.Length"); i++) {
				DescribeDeployedApiResponse.DescribeDeployedApi_ResultDescription resultDescription = new DescribeDeployedApiResponse.DescribeDeployedApi_ResultDescription();
				resultDescription.Id = context.StringValue("DescribeDeployedApi.ResultDescriptions["+ i +"].Id");
				resultDescription.Pid = context.StringValue("DescribeDeployedApi.ResultDescriptions["+ i +"].Pid");
				resultDescription.HasChild = context.BooleanValue("DescribeDeployedApi.ResultDescriptions["+ i +"].HasChild");
				resultDescription.Key = context.StringValue("DescribeDeployedApi.ResultDescriptions["+ i +"].Key");
				resultDescription.Name = context.StringValue("DescribeDeployedApi.ResultDescriptions["+ i +"].Name");
				resultDescription.Mandatory = context.BooleanValue("DescribeDeployedApi.ResultDescriptions["+ i +"].Mandatory");
				resultDescription.Type = context.StringValue("DescribeDeployedApi.ResultDescriptions["+ i +"].Type");
				resultDescription.Description = context.StringValue("DescribeDeployedApi.ResultDescriptions["+ i +"].Description");

				describeDeployedApiResponse_resultDescriptions.Add(resultDescription);
			}
			describeDeployedApiResponse.ResultDescriptions = describeDeployedApiResponse_resultDescriptions;

			List<DescribeDeployedApiResponse.DescribeDeployedApi_SystemParameter> describeDeployedApiResponse_systemParameters = new List<DescribeDeployedApiResponse.DescribeDeployedApi_SystemParameter>();
			for (int i = 0; i < context.Length("DescribeDeployedApi.SystemParameters.Length"); i++) {
				DescribeDeployedApiResponse.DescribeDeployedApi_SystemParameter systemParameter = new DescribeDeployedApiResponse.DescribeDeployedApi_SystemParameter();
				systemParameter.ParameterName = context.StringValue("DescribeDeployedApi.SystemParameters["+ i +"].ParameterName");
				systemParameter.ServiceParameterName = context.StringValue("DescribeDeployedApi.SystemParameters["+ i +"].ServiceParameterName");
				systemParameter.Location = context.StringValue("DescribeDeployedApi.SystemParameters["+ i +"].Location");
				systemParameter.DemoValue = context.StringValue("DescribeDeployedApi.SystemParameters["+ i +"].DemoValue");
				systemParameter.Description = context.StringValue("DescribeDeployedApi.SystemParameters["+ i +"].Description");

				describeDeployedApiResponse_systemParameters.Add(systemParameter);
			}
			describeDeployedApiResponse.SystemParameters = describeDeployedApiResponse_systemParameters;

			List<DescribeDeployedApiResponse.DescribeDeployedApi_CustomSystemParameter> describeDeployedApiResponse_customSystemParameters = new List<DescribeDeployedApiResponse.DescribeDeployedApi_CustomSystemParameter>();
			for (int i = 0; i < context.Length("DescribeDeployedApi.CustomSystemParameters.Length"); i++) {
				DescribeDeployedApiResponse.DescribeDeployedApi_CustomSystemParameter customSystemParameter = new DescribeDeployedApiResponse.DescribeDeployedApi_CustomSystemParameter();
				customSystemParameter.ParameterName = context.StringValue("DescribeDeployedApi.CustomSystemParameters["+ i +"].ParameterName");
				customSystemParameter.ServiceParameterName = context.StringValue("DescribeDeployedApi.CustomSystemParameters["+ i +"].ServiceParameterName");
				customSystemParameter.Location = context.StringValue("DescribeDeployedApi.CustomSystemParameters["+ i +"].Location");
				customSystemParameter.DemoValue = context.StringValue("DescribeDeployedApi.CustomSystemParameters["+ i +"].DemoValue");
				customSystemParameter.Description = context.StringValue("DescribeDeployedApi.CustomSystemParameters["+ i +"].Description");

				describeDeployedApiResponse_customSystemParameters.Add(customSystemParameter);
			}
			describeDeployedApiResponse.CustomSystemParameters = describeDeployedApiResponse_customSystemParameters;

			List<DescribeDeployedApiResponse.DescribeDeployedApi_ConstantParameter> describeDeployedApiResponse_constantParameters = new List<DescribeDeployedApiResponse.DescribeDeployedApi_ConstantParameter>();
			for (int i = 0; i < context.Length("DescribeDeployedApi.ConstantParameters.Length"); i++) {
				DescribeDeployedApiResponse.DescribeDeployedApi_ConstantParameter constantParameter = new DescribeDeployedApiResponse.DescribeDeployedApi_ConstantParameter();
				constantParameter.ServiceParameterName = context.StringValue("DescribeDeployedApi.ConstantParameters["+ i +"].ServiceParameterName");
				constantParameter.ConstantValue = context.StringValue("DescribeDeployedApi.ConstantParameters["+ i +"].ConstantValue");
				constantParameter.Location = context.StringValue("DescribeDeployedApi.ConstantParameters["+ i +"].Location");
				constantParameter.Description = context.StringValue("DescribeDeployedApi.ConstantParameters["+ i +"].Description");

				describeDeployedApiResponse_constantParameters.Add(constantParameter);
			}
			describeDeployedApiResponse.ConstantParameters = describeDeployedApiResponse_constantParameters;

			List<DescribeDeployedApiResponse.DescribeDeployedApi_RequestParameter> describeDeployedApiResponse_requestParameters = new List<DescribeDeployedApiResponse.DescribeDeployedApi_RequestParameter>();
			for (int i = 0; i < context.Length("DescribeDeployedApi.RequestParameters.Length"); i++) {
				DescribeDeployedApiResponse.DescribeDeployedApi_RequestParameter requestParameter = new DescribeDeployedApiResponse.DescribeDeployedApi_RequestParameter();
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
				requestParameter.ArrayItemsType = context.StringValue("DescribeDeployedApi.RequestParameters["+ i +"].ArrayItemsType");

				describeDeployedApiResponse_requestParameters.Add(requestParameter);
			}
			describeDeployedApiResponse.RequestParameters = describeDeployedApiResponse_requestParameters;

			List<DescribeDeployedApiResponse.DescribeDeployedApi_ServiceParameter> describeDeployedApiResponse_serviceParameters = new List<DescribeDeployedApiResponse.DescribeDeployedApi_ServiceParameter>();
			for (int i = 0; i < context.Length("DescribeDeployedApi.ServiceParameters.Length"); i++) {
				DescribeDeployedApiResponse.DescribeDeployedApi_ServiceParameter serviceParameter = new DescribeDeployedApiResponse.DescribeDeployedApi_ServiceParameter();
				serviceParameter.ServiceParameterName = context.StringValue("DescribeDeployedApi.ServiceParameters["+ i +"].ServiceParameterName");
				serviceParameter.Location = context.StringValue("DescribeDeployedApi.ServiceParameters["+ i +"].Location");
				serviceParameter.ParameterType = context.StringValue("DescribeDeployedApi.ServiceParameters["+ i +"].ParameterType");

				describeDeployedApiResponse_serviceParameters.Add(serviceParameter);
			}
			describeDeployedApiResponse.ServiceParameters = describeDeployedApiResponse_serviceParameters;

			List<DescribeDeployedApiResponse.DescribeDeployedApi_ServiceParameterMap> describeDeployedApiResponse_serviceParametersMap = new List<DescribeDeployedApiResponse.DescribeDeployedApi_ServiceParameterMap>();
			for (int i = 0; i < context.Length("DescribeDeployedApi.ServiceParametersMap.Length"); i++) {
				DescribeDeployedApiResponse.DescribeDeployedApi_ServiceParameterMap serviceParameterMap = new DescribeDeployedApiResponse.DescribeDeployedApi_ServiceParameterMap();
				serviceParameterMap.ServiceParameterName = context.StringValue("DescribeDeployedApi.ServiceParametersMap["+ i +"].ServiceParameterName");
				serviceParameterMap.RequestParameterName = context.StringValue("DescribeDeployedApi.ServiceParametersMap["+ i +"].RequestParameterName");

				describeDeployedApiResponse_serviceParametersMap.Add(serviceParameterMap);
			}
			describeDeployedApiResponse.ServiceParametersMap = describeDeployedApiResponse_serviceParametersMap;
        
			return describeDeployedApiResponse;
        }
    }
}
