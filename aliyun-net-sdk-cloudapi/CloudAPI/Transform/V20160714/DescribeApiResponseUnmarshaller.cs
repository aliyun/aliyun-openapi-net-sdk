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
    public class DescribeApiResponseUnmarshaller
    {
        public static DescribeApiResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeApiResponse describeApiResponse = new DescribeApiResponse();

			describeApiResponse.HttpResponse = context.HttpResponse;
			describeApiResponse.RequestId = context.StringValue("DescribeApi.RequestId");
			describeApiResponse.RegionId = context.StringValue("DescribeApi.RegionId");
			describeApiResponse.ApiId = context.StringValue("DescribeApi.ApiId");
			describeApiResponse.ApiName = context.StringValue("DescribeApi.ApiName");
			describeApiResponse.GroupId = context.StringValue("DescribeApi.GroupId");
			describeApiResponse.GroupName = context.StringValue("DescribeApi.GroupName");
			describeApiResponse.Visibility = context.StringValue("DescribeApi.Visibility");
			describeApiResponse.AuthType = context.StringValue("DescribeApi.AuthType");
			describeApiResponse.ResultType = context.StringValue("DescribeApi.ResultType");
			describeApiResponse.ResultSample = context.StringValue("DescribeApi.ResultSample");
			describeApiResponse.FailResultSample = context.StringValue("DescribeApi.FailResultSample");
			describeApiResponse.CreatedTime = context.StringValue("DescribeApi.CreatedTime");
			describeApiResponse.ModifiedTime = context.StringValue("DescribeApi.ModifiedTime");
			describeApiResponse.Description = context.StringValue("DescribeApi.Description");
			describeApiResponse.Mock = context.StringValue("DescribeApi.Mock");
			describeApiResponse.MockResult = context.StringValue("DescribeApi.MockResult");
			describeApiResponse.AllowSignatureMethod = context.StringValue("DescribeApi.AllowSignatureMethod");
			describeApiResponse.WebSocketApiType = context.StringValue("DescribeApi.WebSocketApiType");
			describeApiResponse.ResultBodyModel = context.StringValue("DescribeApi.ResultBodyModel");
			describeApiResponse.ForceNonceCheck = context.BooleanValue("DescribeApi.ForceNonceCheck");
			describeApiResponse.DisableInternet = context.BooleanValue("DescribeApi.DisableInternet");
			describeApiResponse.AppCodeAuthType = context.StringValue("DescribeApi.AppCodeAuthType");

			DescribeApiResponse.DescribeApi_RequestConfig requestConfig = new DescribeApiResponse.DescribeApi_RequestConfig();
			requestConfig.RequestProtocol = context.StringValue("DescribeApi.RequestConfig.RequestProtocol");
			requestConfig.RequestHttpMethod = context.StringValue("DescribeApi.RequestConfig.RequestHttpMethod");
			requestConfig.RequestPath = context.StringValue("DescribeApi.RequestConfig.RequestPath");
			requestConfig.BodyFormat = context.StringValue("DescribeApi.RequestConfig.BodyFormat");
			requestConfig.PostBodyDescription = context.StringValue("DescribeApi.RequestConfig.PostBodyDescription");
			requestConfig.RequestMode = context.StringValue("DescribeApi.RequestConfig.RequestMode");
			requestConfig.BodyModel = context.StringValue("DescribeApi.RequestConfig.BodyModel");
			describeApiResponse.RequestConfig = requestConfig;

			DescribeApiResponse.DescribeApi_ServiceConfig serviceConfig = new DescribeApiResponse.DescribeApi_ServiceConfig();
			serviceConfig.ServiceProtocol = context.StringValue("DescribeApi.ServiceConfig.ServiceProtocol");
			serviceConfig.ServiceAddress = context.StringValue("DescribeApi.ServiceConfig.ServiceAddress");
			serviceConfig.ServiceHttpMethod = context.StringValue("DescribeApi.ServiceConfig.ServiceHttpMethod");
			serviceConfig.ServicePath = context.StringValue("DescribeApi.ServiceConfig.ServicePath");
			serviceConfig.ServiceTimeout = context.IntegerValue("DescribeApi.ServiceConfig.ServiceTimeout");
			serviceConfig.ContentTypeCatagory = context.StringValue("DescribeApi.ServiceConfig.ContentTypeCatagory");
			serviceConfig.ContentTypeValue = context.StringValue("DescribeApi.ServiceConfig.ContentTypeValue");
			serviceConfig.Mock = context.StringValue("DescribeApi.ServiceConfig.Mock");
			serviceConfig.MockResult = context.StringValue("DescribeApi.ServiceConfig.MockResult");
			serviceConfig.ServiceVpcEnable = context.StringValue("DescribeApi.ServiceConfig.ServiceVpcEnable");
			serviceConfig.AoneAppName = context.StringValue("DescribeApi.ServiceConfig.AoneAppName");
			serviceConfig.MockStatusCode = context.IntegerValue("DescribeApi.ServiceConfig.MockStatusCode");

			DescribeApiResponse.DescribeApi_ServiceConfig.DescribeApi_VpcConfig vpcConfig = new DescribeApiResponse.DescribeApi_ServiceConfig.DescribeApi_VpcConfig();
			vpcConfig.Name = context.StringValue("DescribeApi.ServiceConfig.VpcConfig.Name");
			vpcConfig.VpcId = context.StringValue("DescribeApi.ServiceConfig.VpcConfig.VpcId");
			vpcConfig.InstanceId = context.StringValue("DescribeApi.ServiceConfig.VpcConfig.InstanceId");
			vpcConfig.Port = context.IntegerValue("DescribeApi.ServiceConfig.VpcConfig.Port");
			serviceConfig.VpcConfig = vpcConfig;

			DescribeApiResponse.DescribeApi_ServiceConfig.DescribeApi_FunctionComputeConfig functionComputeConfig = new DescribeApiResponse.DescribeApi_ServiceConfig.DescribeApi_FunctionComputeConfig();
			functionComputeConfig.RegionId = context.StringValue("DescribeApi.ServiceConfig.FunctionComputeConfig.RegionId");
			functionComputeConfig.ServiceName = context.StringValue("DescribeApi.ServiceConfig.FunctionComputeConfig.ServiceName");
			functionComputeConfig.FunctionName = context.StringValue("DescribeApi.ServiceConfig.FunctionComputeConfig.FunctionName");
			functionComputeConfig.RoleArn = context.StringValue("DescribeApi.ServiceConfig.FunctionComputeConfig.RoleArn");
			serviceConfig.FunctionComputeConfig = functionComputeConfig;

			List<DescribeApiResponse.DescribeApi_ServiceConfig.DescribeApi_MockHeader> serviceConfig_mockHeaders = new List<DescribeApiResponse.DescribeApi_ServiceConfig.DescribeApi_MockHeader>();
			for (int i = 0; i < context.Length("DescribeApi.ServiceConfig.MockHeaders.Length"); i++) {
				DescribeApiResponse.DescribeApi_ServiceConfig.DescribeApi_MockHeader mockHeader = new DescribeApiResponse.DescribeApi_ServiceConfig.DescribeApi_MockHeader();
				mockHeader.HeaderName = context.StringValue("DescribeApi.ServiceConfig.MockHeaders["+ i +"].HeaderName");
				mockHeader.HeaderValue = context.StringValue("DescribeApi.ServiceConfig.MockHeaders["+ i +"].HeaderValue");

				serviceConfig_mockHeaders.Add(mockHeader);
			}
			serviceConfig.MockHeaders = serviceConfig_mockHeaders;
			describeApiResponse.ServiceConfig = serviceConfig;

			DescribeApiResponse.DescribeApi_OpenIdConnectConfig openIdConnectConfig = new DescribeApiResponse.DescribeApi_OpenIdConnectConfig();
			openIdConnectConfig.OpenIdApiType = context.StringValue("DescribeApi.OpenIdConnectConfig.OpenIdApiType");
			openIdConnectConfig.IdTokenParamName = context.StringValue("DescribeApi.OpenIdConnectConfig.IdTokenParamName");
			openIdConnectConfig.PublicKeyId = context.StringValue("DescribeApi.OpenIdConnectConfig.PublicKeyId");
			openIdConnectConfig.PublicKey = context.StringValue("DescribeApi.OpenIdConnectConfig.PublicKey");
			describeApiResponse.OpenIdConnectConfig = openIdConnectConfig;

			List<DescribeApiResponse.DescribeApi_ErrorCodeSample> describeApiResponse_errorCodeSamples = new List<DescribeApiResponse.DescribeApi_ErrorCodeSample>();
			for (int i = 0; i < context.Length("DescribeApi.ErrorCodeSamples.Length"); i++) {
				DescribeApiResponse.DescribeApi_ErrorCodeSample errorCodeSample = new DescribeApiResponse.DescribeApi_ErrorCodeSample();
				errorCodeSample.Code = context.StringValue("DescribeApi.ErrorCodeSamples["+ i +"].Code");
				errorCodeSample.Message = context.StringValue("DescribeApi.ErrorCodeSamples["+ i +"].Message");
				errorCodeSample.Description = context.StringValue("DescribeApi.ErrorCodeSamples["+ i +"].Description");
				errorCodeSample.Model = context.StringValue("DescribeApi.ErrorCodeSamples["+ i +"].Model");

				describeApiResponse_errorCodeSamples.Add(errorCodeSample);
			}
			describeApiResponse.ErrorCodeSamples = describeApiResponse_errorCodeSamples;

			List<DescribeApiResponse.DescribeApi_ResultDescription> describeApiResponse_resultDescriptions = new List<DescribeApiResponse.DescribeApi_ResultDescription>();
			for (int i = 0; i < context.Length("DescribeApi.ResultDescriptions.Length"); i++) {
				DescribeApiResponse.DescribeApi_ResultDescription resultDescription = new DescribeApiResponse.DescribeApi_ResultDescription();
				resultDescription.Id = context.StringValue("DescribeApi.ResultDescriptions["+ i +"].Id");
				resultDescription.Pid = context.StringValue("DescribeApi.ResultDescriptions["+ i +"].Pid");
				resultDescription.HasChild = context.BooleanValue("DescribeApi.ResultDescriptions["+ i +"].HasChild");
				resultDescription.Key = context.StringValue("DescribeApi.ResultDescriptions["+ i +"].Key");
				resultDescription.Name = context.StringValue("DescribeApi.ResultDescriptions["+ i +"].Name");
				resultDescription.Mandatory = context.BooleanValue("DescribeApi.ResultDescriptions["+ i +"].Mandatory");
				resultDescription.Type = context.StringValue("DescribeApi.ResultDescriptions["+ i +"].Type");
				resultDescription.Description = context.StringValue("DescribeApi.ResultDescriptions["+ i +"].Description");

				describeApiResponse_resultDescriptions.Add(resultDescription);
			}
			describeApiResponse.ResultDescriptions = describeApiResponse_resultDescriptions;

			List<DescribeApiResponse.DescribeApi_SystemParameter> describeApiResponse_systemParameters = new List<DescribeApiResponse.DescribeApi_SystemParameter>();
			for (int i = 0; i < context.Length("DescribeApi.SystemParameters.Length"); i++) {
				DescribeApiResponse.DescribeApi_SystemParameter systemParameter = new DescribeApiResponse.DescribeApi_SystemParameter();
				systemParameter.ParameterName = context.StringValue("DescribeApi.SystemParameters["+ i +"].ParameterName");
				systemParameter.ServiceParameterName = context.StringValue("DescribeApi.SystemParameters["+ i +"].ServiceParameterName");
				systemParameter.Location = context.StringValue("DescribeApi.SystemParameters["+ i +"].Location");
				systemParameter.DemoValue = context.StringValue("DescribeApi.SystemParameters["+ i +"].DemoValue");
				systemParameter.Description = context.StringValue("DescribeApi.SystemParameters["+ i +"].Description");

				describeApiResponse_systemParameters.Add(systemParameter);
			}
			describeApiResponse.SystemParameters = describeApiResponse_systemParameters;

			List<DescribeApiResponse.DescribeApi_CustomSystemParameter> describeApiResponse_customSystemParameters = new List<DescribeApiResponse.DescribeApi_CustomSystemParameter>();
			for (int i = 0; i < context.Length("DescribeApi.CustomSystemParameters.Length"); i++) {
				DescribeApiResponse.DescribeApi_CustomSystemParameter customSystemParameter = new DescribeApiResponse.DescribeApi_CustomSystemParameter();
				customSystemParameter.ParameterName = context.StringValue("DescribeApi.CustomSystemParameters["+ i +"].ParameterName");
				customSystemParameter.ServiceParameterName = context.StringValue("DescribeApi.CustomSystemParameters["+ i +"].ServiceParameterName");
				customSystemParameter.Location = context.StringValue("DescribeApi.CustomSystemParameters["+ i +"].Location");
				customSystemParameter.DemoValue = context.StringValue("DescribeApi.CustomSystemParameters["+ i +"].DemoValue");
				customSystemParameter.Description = context.StringValue("DescribeApi.CustomSystemParameters["+ i +"].Description");

				describeApiResponse_customSystemParameters.Add(customSystemParameter);
			}
			describeApiResponse.CustomSystemParameters = describeApiResponse_customSystemParameters;

			List<DescribeApiResponse.DescribeApi_ConstantParameter> describeApiResponse_constantParameters = new List<DescribeApiResponse.DescribeApi_ConstantParameter>();
			for (int i = 0; i < context.Length("DescribeApi.ConstantParameters.Length"); i++) {
				DescribeApiResponse.DescribeApi_ConstantParameter constantParameter = new DescribeApiResponse.DescribeApi_ConstantParameter();
				constantParameter.ServiceParameterName = context.StringValue("DescribeApi.ConstantParameters["+ i +"].ServiceParameterName");
				constantParameter.ConstantValue = context.StringValue("DescribeApi.ConstantParameters["+ i +"].ConstantValue");
				constantParameter.Location = context.StringValue("DescribeApi.ConstantParameters["+ i +"].Location");
				constantParameter.Description = context.StringValue("DescribeApi.ConstantParameters["+ i +"].Description");

				describeApiResponse_constantParameters.Add(constantParameter);
			}
			describeApiResponse.ConstantParameters = describeApiResponse_constantParameters;

			List<DescribeApiResponse.DescribeApi_RequestParameter> describeApiResponse_requestParameters = new List<DescribeApiResponse.DescribeApi_RequestParameter>();
			for (int i = 0; i < context.Length("DescribeApi.RequestParameters.Length"); i++) {
				DescribeApiResponse.DescribeApi_RequestParameter requestParameter = new DescribeApiResponse.DescribeApi_RequestParameter();
				requestParameter.ApiParameterName = context.StringValue("DescribeApi.RequestParameters["+ i +"].ApiParameterName");
				requestParameter.Location = context.StringValue("DescribeApi.RequestParameters["+ i +"].Location");
				requestParameter.ParameterType = context.StringValue("DescribeApi.RequestParameters["+ i +"].ParameterType");
				requestParameter.Required = context.StringValue("DescribeApi.RequestParameters["+ i +"].Required");
				requestParameter.DefaultValue = context.StringValue("DescribeApi.RequestParameters["+ i +"].DefaultValue");
				requestParameter.DemoValue = context.StringValue("DescribeApi.RequestParameters["+ i +"].DemoValue");
				requestParameter.MaxValue = context.LongValue("DescribeApi.RequestParameters["+ i +"].MaxValue");
				requestParameter.MinValue = context.LongValue("DescribeApi.RequestParameters["+ i +"].MinValue");
				requestParameter.MaxLength = context.LongValue("DescribeApi.RequestParameters["+ i +"].MaxLength");
				requestParameter.MinLength = context.LongValue("DescribeApi.RequestParameters["+ i +"].MinLength");
				requestParameter.RegularExpression = context.StringValue("DescribeApi.RequestParameters["+ i +"].RegularExpression");
				requestParameter.JsonScheme = context.StringValue("DescribeApi.RequestParameters["+ i +"].JsonScheme");
				requestParameter.EnumValue = context.StringValue("DescribeApi.RequestParameters["+ i +"].EnumValue");
				requestParameter.DocShow = context.StringValue("DescribeApi.RequestParameters["+ i +"].DocShow");
				requestParameter.DocOrder = context.IntegerValue("DescribeApi.RequestParameters["+ i +"].DocOrder");
				requestParameter.Description = context.StringValue("DescribeApi.RequestParameters["+ i +"].Description");
				requestParameter.ArrayItemsType = context.StringValue("DescribeApi.RequestParameters["+ i +"].ArrayItemsType");

				describeApiResponse_requestParameters.Add(requestParameter);
			}
			describeApiResponse.RequestParameters = describeApiResponse_requestParameters;

			List<DescribeApiResponse.DescribeApi_ServiceParameter> describeApiResponse_serviceParameters = new List<DescribeApiResponse.DescribeApi_ServiceParameter>();
			for (int i = 0; i < context.Length("DescribeApi.ServiceParameters.Length"); i++) {
				DescribeApiResponse.DescribeApi_ServiceParameter serviceParameter = new DescribeApiResponse.DescribeApi_ServiceParameter();
				serviceParameter.ServiceParameterName = context.StringValue("DescribeApi.ServiceParameters["+ i +"].ServiceParameterName");
				serviceParameter.Location = context.StringValue("DescribeApi.ServiceParameters["+ i +"].Location");
				serviceParameter.ParameterType = context.StringValue("DescribeApi.ServiceParameters["+ i +"].ParameterType");

				describeApiResponse_serviceParameters.Add(serviceParameter);
			}
			describeApiResponse.ServiceParameters = describeApiResponse_serviceParameters;

			List<DescribeApiResponse.DescribeApi_ServiceParameterMap> describeApiResponse_serviceParametersMap = new List<DescribeApiResponse.DescribeApi_ServiceParameterMap>();
			for (int i = 0; i < context.Length("DescribeApi.ServiceParametersMap.Length"); i++) {
				DescribeApiResponse.DescribeApi_ServiceParameterMap serviceParameterMap = new DescribeApiResponse.DescribeApi_ServiceParameterMap();
				serviceParameterMap.ServiceParameterName = context.StringValue("DescribeApi.ServiceParametersMap["+ i +"].ServiceParameterName");
				serviceParameterMap.RequestParameterName = context.StringValue("DescribeApi.ServiceParametersMap["+ i +"].RequestParameterName");

				describeApiResponse_serviceParametersMap.Add(serviceParameterMap);
			}
			describeApiResponse.ServiceParametersMap = describeApiResponse_serviceParametersMap;

			List<DescribeApiResponse.DescribeApi_DeployedInfo> describeApiResponse_deployedInfos = new List<DescribeApiResponse.DescribeApi_DeployedInfo>();
			for (int i = 0; i < context.Length("DescribeApi.DeployedInfos.Length"); i++) {
				DescribeApiResponse.DescribeApi_DeployedInfo deployedInfo = new DescribeApiResponse.DescribeApi_DeployedInfo();
				deployedInfo.StageName = context.StringValue("DescribeApi.DeployedInfos["+ i +"].StageName");
				deployedInfo.EffectiveVersion = context.StringValue("DescribeApi.DeployedInfos["+ i +"].EffectiveVersion");
				deployedInfo.DeployedStatus = context.StringValue("DescribeApi.DeployedInfos["+ i +"].DeployedStatus");

				describeApiResponse_deployedInfos.Add(deployedInfo);
			}
			describeApiResponse.DeployedInfos = describeApiResponse_deployedInfos;
        
			return describeApiResponse;
        }
    }
}
