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
    public class DescribeApiHistoryResponseUnmarshaller
    {
        public static DescribeApiHistoryResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeApiHistoryResponse describeApiHistoryResponse = new DescribeApiHistoryResponse();

			describeApiHistoryResponse.HttpResponse = context.HttpResponse;
			describeApiHistoryResponse.RequestId = context.StringValue("DescribeApiHistory.RequestId");
			describeApiHistoryResponse.RegionId = context.StringValue("DescribeApiHistory.RegionId");
			describeApiHistoryResponse.GroupId = context.StringValue("DescribeApiHistory.GroupId");
			describeApiHistoryResponse.GroupName = context.StringValue("DescribeApiHistory.GroupName");
			describeApiHistoryResponse.StageName = context.StringValue("DescribeApiHistory.StageName");
			describeApiHistoryResponse.ApiId = context.StringValue("DescribeApiHistory.ApiId");
			describeApiHistoryResponse.ApiName = context.StringValue("DescribeApiHistory.ApiName");
			describeApiHistoryResponse.Description = context.StringValue("DescribeApiHistory.Description");
			describeApiHistoryResponse.HistoryVersion = context.StringValue("DescribeApiHistory.HistoryVersion");
			describeApiHistoryResponse.Status = context.StringValue("DescribeApiHistory.Status");
			describeApiHistoryResponse.Visibility = context.StringValue("DescribeApiHistory.Visibility");
			describeApiHistoryResponse.AuthType = context.StringValue("DescribeApiHistory.AuthType");
			describeApiHistoryResponse.ResultType = context.StringValue("DescribeApiHistory.ResultType");
			describeApiHistoryResponse.ResultSample = context.StringValue("DescribeApiHistory.ResultSample");
			describeApiHistoryResponse.FailResultSample = context.StringValue("DescribeApiHistory.FailResultSample");
			describeApiHistoryResponse.DeployedTime = context.StringValue("DescribeApiHistory.DeployedTime");
			describeApiHistoryResponse.AllowSignatureMethod = context.StringValue("DescribeApiHistory.AllowSignatureMethod");
			describeApiHistoryResponse.ResultBodyModel = context.StringValue("DescribeApiHistory.ResultBodyModel");
			describeApiHistoryResponse.ForceNonceCheck = context.BooleanValue("DescribeApiHistory.ForceNonceCheck");
			describeApiHistoryResponse.DisableInternet = context.BooleanValue("DescribeApiHistory.DisableInternet");

			DescribeApiHistoryResponse.DescribeApiHistory_RequestConfig requestConfig = new DescribeApiHistoryResponse.DescribeApiHistory_RequestConfig();
			requestConfig.RequestProtocol = context.StringValue("DescribeApiHistory.RequestConfig.RequestProtocol");
			requestConfig.RequestHttpMethod = context.StringValue("DescribeApiHistory.RequestConfig.RequestHttpMethod");
			requestConfig.RequestPath = context.StringValue("DescribeApiHistory.RequestConfig.RequestPath");
			requestConfig.BodyFormat = context.StringValue("DescribeApiHistory.RequestConfig.BodyFormat");
			requestConfig.PostBodyDescription = context.StringValue("DescribeApiHistory.RequestConfig.PostBodyDescription");
			requestConfig.RequestMode = context.StringValue("DescribeApiHistory.RequestConfig.RequestMode");
			requestConfig.BodyModel = context.StringValue("DescribeApiHistory.RequestConfig.BodyModel");
			describeApiHistoryResponse.RequestConfig = requestConfig;

			DescribeApiHistoryResponse.DescribeApiHistory_ServiceConfig serviceConfig = new DescribeApiHistoryResponse.DescribeApiHistory_ServiceConfig();
			serviceConfig.ServiceProtocol = context.StringValue("DescribeApiHistory.ServiceConfig.ServiceProtocol");
			serviceConfig.ServiceAddress = context.StringValue("DescribeApiHistory.ServiceConfig.ServiceAddress");
			serviceConfig.ServiceHttpMethod = context.StringValue("DescribeApiHistory.ServiceConfig.ServiceHttpMethod");
			serviceConfig.ServicePath = context.StringValue("DescribeApiHistory.ServiceConfig.ServicePath");
			serviceConfig.ServiceTimeout = context.IntegerValue("DescribeApiHistory.ServiceConfig.ServiceTimeout");
			serviceConfig.Mock = context.StringValue("DescribeApiHistory.ServiceConfig.Mock");
			serviceConfig.MockResult = context.StringValue("DescribeApiHistory.ServiceConfig.MockResult");
			serviceConfig.ServiceVpcEnable = context.StringValue("DescribeApiHistory.ServiceConfig.ServiceVpcEnable");
			serviceConfig.MockStatusCode = context.IntegerValue("DescribeApiHistory.ServiceConfig.MockStatusCode");
			serviceConfig.VpcId = context.StringValue("DescribeApiHistory.ServiceConfig.VpcId");

			DescribeApiHistoryResponse.DescribeApiHistory_ServiceConfig.DescribeApiHistory_VpcConfig vpcConfig = new DescribeApiHistoryResponse.DescribeApiHistory_ServiceConfig.DescribeApiHistory_VpcConfig();
			vpcConfig.Name = context.StringValue("DescribeApiHistory.ServiceConfig.VpcConfig.Name");
			vpcConfig.VpcId = context.StringValue("DescribeApiHistory.ServiceConfig.VpcConfig.VpcId");
			vpcConfig.InstanceId = context.StringValue("DescribeApiHistory.ServiceConfig.VpcConfig.InstanceId");
			vpcConfig.Port = context.IntegerValue("DescribeApiHistory.ServiceConfig.VpcConfig.Port");
			serviceConfig.VpcConfig = vpcConfig;

			DescribeApiHistoryResponse.DescribeApiHistory_ServiceConfig.DescribeApiHistory_FunctionComputeConfig functionComputeConfig = new DescribeApiHistoryResponse.DescribeApiHistory_ServiceConfig.DescribeApiHistory_FunctionComputeConfig();
			functionComputeConfig.RegionId = context.StringValue("DescribeApiHistory.ServiceConfig.FunctionComputeConfig.RegionId");
			functionComputeConfig.ServiceName = context.StringValue("DescribeApiHistory.ServiceConfig.FunctionComputeConfig.ServiceName");
			functionComputeConfig.FunctionName = context.StringValue("DescribeApiHistory.ServiceConfig.FunctionComputeConfig.FunctionName");
			functionComputeConfig.RoleArn = context.StringValue("DescribeApiHistory.ServiceConfig.FunctionComputeConfig.RoleArn");
			serviceConfig.FunctionComputeConfig = functionComputeConfig;

			List<DescribeApiHistoryResponse.DescribeApiHistory_ServiceConfig.DescribeApiHistory_MockHeader> serviceConfig_mockHeaders = new List<DescribeApiHistoryResponse.DescribeApiHistory_ServiceConfig.DescribeApiHistory_MockHeader>();
			for (int i = 0; i < context.Length("DescribeApiHistory.ServiceConfig.MockHeaders.Length"); i++) {
				DescribeApiHistoryResponse.DescribeApiHistory_ServiceConfig.DescribeApiHistory_MockHeader mockHeader = new DescribeApiHistoryResponse.DescribeApiHistory_ServiceConfig.DescribeApiHistory_MockHeader();
				mockHeader.HeaderName = context.StringValue("DescribeApiHistory.ServiceConfig.MockHeaders["+ i +"].HeaderName");
				mockHeader.HeaderValue = context.StringValue("DescribeApiHistory.ServiceConfig.MockHeaders["+ i +"].HeaderValue");

				serviceConfig_mockHeaders.Add(mockHeader);
			}
			serviceConfig.MockHeaders = serviceConfig_mockHeaders;
			describeApiHistoryResponse.ServiceConfig = serviceConfig;

			DescribeApiHistoryResponse.DescribeApiHistory_OpenIdConnectConfig openIdConnectConfig = new DescribeApiHistoryResponse.DescribeApiHistory_OpenIdConnectConfig();
			openIdConnectConfig.OpenIdApiType = context.StringValue("DescribeApiHistory.OpenIdConnectConfig.OpenIdApiType");
			openIdConnectConfig.IdTokenParamName = context.StringValue("DescribeApiHistory.OpenIdConnectConfig.IdTokenParamName");
			openIdConnectConfig.PublicKeyId = context.StringValue("DescribeApiHistory.OpenIdConnectConfig.PublicKeyId");
			openIdConnectConfig.PublicKey = context.StringValue("DescribeApiHistory.OpenIdConnectConfig.PublicKey");
			describeApiHistoryResponse.OpenIdConnectConfig = openIdConnectConfig;

			List<DescribeApiHistoryResponse.DescribeApiHistory_ErrorCodeSample> describeApiHistoryResponse_errorCodeSamples = new List<DescribeApiHistoryResponse.DescribeApiHistory_ErrorCodeSample>();
			for (int i = 0; i < context.Length("DescribeApiHistory.ErrorCodeSamples.Length"); i++) {
				DescribeApiHistoryResponse.DescribeApiHistory_ErrorCodeSample errorCodeSample = new DescribeApiHistoryResponse.DescribeApiHistory_ErrorCodeSample();
				errorCodeSample.Code = context.StringValue("DescribeApiHistory.ErrorCodeSamples["+ i +"].Code");
				errorCodeSample.Message = context.StringValue("DescribeApiHistory.ErrorCodeSamples["+ i +"].Message");
				errorCodeSample.Description = context.StringValue("DescribeApiHistory.ErrorCodeSamples["+ i +"].Description");

				describeApiHistoryResponse_errorCodeSamples.Add(errorCodeSample);
			}
			describeApiHistoryResponse.ErrorCodeSamples = describeApiHistoryResponse_errorCodeSamples;

			List<DescribeApiHistoryResponse.DescribeApiHistory_ResultDescription> describeApiHistoryResponse_resultDescriptions = new List<DescribeApiHistoryResponse.DescribeApiHistory_ResultDescription>();
			for (int i = 0; i < context.Length("DescribeApiHistory.ResultDescriptions.Length"); i++) {
				DescribeApiHistoryResponse.DescribeApiHistory_ResultDescription resultDescription = new DescribeApiHistoryResponse.DescribeApiHistory_ResultDescription();
				resultDescription.Id = context.StringValue("DescribeApiHistory.ResultDescriptions["+ i +"].Id");
				resultDescription.Pid = context.StringValue("DescribeApiHistory.ResultDescriptions["+ i +"].Pid");
				resultDescription.HasChild = context.BooleanValue("DescribeApiHistory.ResultDescriptions["+ i +"].HasChild");
				resultDescription.Key = context.StringValue("DescribeApiHistory.ResultDescriptions["+ i +"].Key");
				resultDescription.Name = context.StringValue("DescribeApiHistory.ResultDescriptions["+ i +"].Name");
				resultDescription.Mandatory = context.BooleanValue("DescribeApiHistory.ResultDescriptions["+ i +"].Mandatory");
				resultDescription.Type = context.StringValue("DescribeApiHistory.ResultDescriptions["+ i +"].Type");
				resultDescription.Description = context.StringValue("DescribeApiHistory.ResultDescriptions["+ i +"].Description");

				describeApiHistoryResponse_resultDescriptions.Add(resultDescription);
			}
			describeApiHistoryResponse.ResultDescriptions = describeApiHistoryResponse_resultDescriptions;

			List<DescribeApiHistoryResponse.DescribeApiHistory_SystemParameter> describeApiHistoryResponse_systemParameters = new List<DescribeApiHistoryResponse.DescribeApiHistory_SystemParameter>();
			for (int i = 0; i < context.Length("DescribeApiHistory.SystemParameters.Length"); i++) {
				DescribeApiHistoryResponse.DescribeApiHistory_SystemParameter systemParameter = new DescribeApiHistoryResponse.DescribeApiHistory_SystemParameter();
				systemParameter.ParameterName = context.StringValue("DescribeApiHistory.SystemParameters["+ i +"].ParameterName");
				systemParameter.ServiceParameterName = context.StringValue("DescribeApiHistory.SystemParameters["+ i +"].ServiceParameterName");
				systemParameter.Location = context.StringValue("DescribeApiHistory.SystemParameters["+ i +"].Location");
				systemParameter.DemoValue = context.StringValue("DescribeApiHistory.SystemParameters["+ i +"].DemoValue");
				systemParameter.Description = context.StringValue("DescribeApiHistory.SystemParameters["+ i +"].Description");

				describeApiHistoryResponse_systemParameters.Add(systemParameter);
			}
			describeApiHistoryResponse.SystemParameters = describeApiHistoryResponse_systemParameters;

			List<DescribeApiHistoryResponse.DescribeApiHistory_CustomSystemParameter> describeApiHistoryResponse_customSystemParameters = new List<DescribeApiHistoryResponse.DescribeApiHistory_CustomSystemParameter>();
			for (int i = 0; i < context.Length("DescribeApiHistory.CustomSystemParameters.Length"); i++) {
				DescribeApiHistoryResponse.DescribeApiHistory_CustomSystemParameter customSystemParameter = new DescribeApiHistoryResponse.DescribeApiHistory_CustomSystemParameter();
				customSystemParameter.ParameterName = context.StringValue("DescribeApiHistory.CustomSystemParameters["+ i +"].ParameterName");
				customSystemParameter.ServiceParameterName = context.StringValue("DescribeApiHistory.CustomSystemParameters["+ i +"].ServiceParameterName");
				customSystemParameter.Location = context.StringValue("DescribeApiHistory.CustomSystemParameters["+ i +"].Location");
				customSystemParameter.DemoValue = context.StringValue("DescribeApiHistory.CustomSystemParameters["+ i +"].DemoValue");
				customSystemParameter.Description = context.StringValue("DescribeApiHistory.CustomSystemParameters["+ i +"].Description");

				describeApiHistoryResponse_customSystemParameters.Add(customSystemParameter);
			}
			describeApiHistoryResponse.CustomSystemParameters = describeApiHistoryResponse_customSystemParameters;

			List<DescribeApiHistoryResponse.DescribeApiHistory_ConstantParameter> describeApiHistoryResponse_constantParameters = new List<DescribeApiHistoryResponse.DescribeApiHistory_ConstantParameter>();
			for (int i = 0; i < context.Length("DescribeApiHistory.ConstantParameters.Length"); i++) {
				DescribeApiHistoryResponse.DescribeApiHistory_ConstantParameter constantParameter = new DescribeApiHistoryResponse.DescribeApiHistory_ConstantParameter();
				constantParameter.ServiceParameterName = context.StringValue("DescribeApiHistory.ConstantParameters["+ i +"].ServiceParameterName");
				constantParameter.ConstantValue = context.StringValue("DescribeApiHistory.ConstantParameters["+ i +"].ConstantValue");
				constantParameter.Location = context.StringValue("DescribeApiHistory.ConstantParameters["+ i +"].Location");
				constantParameter.Description = context.StringValue("DescribeApiHistory.ConstantParameters["+ i +"].Description");

				describeApiHistoryResponse_constantParameters.Add(constantParameter);
			}
			describeApiHistoryResponse.ConstantParameters = describeApiHistoryResponse_constantParameters;

			List<DescribeApiHistoryResponse.DescribeApiHistory_RequestParameter> describeApiHistoryResponse_requestParameters = new List<DescribeApiHistoryResponse.DescribeApiHistory_RequestParameter>();
			for (int i = 0; i < context.Length("DescribeApiHistory.RequestParameters.Length"); i++) {
				DescribeApiHistoryResponse.DescribeApiHistory_RequestParameter requestParameter = new DescribeApiHistoryResponse.DescribeApiHistory_RequestParameter();
				requestParameter.ApiParameterName = context.StringValue("DescribeApiHistory.RequestParameters["+ i +"].ApiParameterName");
				requestParameter.Location = context.StringValue("DescribeApiHistory.RequestParameters["+ i +"].Location");
				requestParameter.ParameterType = context.StringValue("DescribeApiHistory.RequestParameters["+ i +"].ParameterType");
				requestParameter.Required = context.StringValue("DescribeApiHistory.RequestParameters["+ i +"].Required");
				requestParameter.DefaultValue = context.StringValue("DescribeApiHistory.RequestParameters["+ i +"].DefaultValue");
				requestParameter.DemoValue = context.StringValue("DescribeApiHistory.RequestParameters["+ i +"].DemoValue");
				requestParameter.MaxValue = context.LongValue("DescribeApiHistory.RequestParameters["+ i +"].MaxValue");
				requestParameter.MinValue = context.LongValue("DescribeApiHistory.RequestParameters["+ i +"].MinValue");
				requestParameter.MaxLength = context.LongValue("DescribeApiHistory.RequestParameters["+ i +"].MaxLength");
				requestParameter.MinLength = context.LongValue("DescribeApiHistory.RequestParameters["+ i +"].MinLength");
				requestParameter.RegularExpression = context.StringValue("DescribeApiHistory.RequestParameters["+ i +"].RegularExpression");
				requestParameter.JsonScheme = context.StringValue("DescribeApiHistory.RequestParameters["+ i +"].JsonScheme");
				requestParameter.EnumValue = context.StringValue("DescribeApiHistory.RequestParameters["+ i +"].EnumValue");
				requestParameter.DocShow = context.StringValue("DescribeApiHistory.RequestParameters["+ i +"].DocShow");
				requestParameter.DocOrder = context.IntegerValue("DescribeApiHistory.RequestParameters["+ i +"].DocOrder");
				requestParameter.Description = context.StringValue("DescribeApiHistory.RequestParameters["+ i +"].Description");
				requestParameter.ArrayItemsType = context.StringValue("DescribeApiHistory.RequestParameters["+ i +"].ArrayItemsType");

				describeApiHistoryResponse_requestParameters.Add(requestParameter);
			}
			describeApiHistoryResponse.RequestParameters = describeApiHistoryResponse_requestParameters;

			List<DescribeApiHistoryResponse.DescribeApiHistory_ServiceParameter> describeApiHistoryResponse_serviceParameters = new List<DescribeApiHistoryResponse.DescribeApiHistory_ServiceParameter>();
			for (int i = 0; i < context.Length("DescribeApiHistory.ServiceParameters.Length"); i++) {
				DescribeApiHistoryResponse.DescribeApiHistory_ServiceParameter serviceParameter = new DescribeApiHistoryResponse.DescribeApiHistory_ServiceParameter();
				serviceParameter.ServiceParameterName = context.StringValue("DescribeApiHistory.ServiceParameters["+ i +"].ServiceParameterName");
				serviceParameter.Location = context.StringValue("DescribeApiHistory.ServiceParameters["+ i +"].Location");
				serviceParameter.ParameterType = context.StringValue("DescribeApiHistory.ServiceParameters["+ i +"].ParameterType");

				describeApiHistoryResponse_serviceParameters.Add(serviceParameter);
			}
			describeApiHistoryResponse.ServiceParameters = describeApiHistoryResponse_serviceParameters;

			List<DescribeApiHistoryResponse.DescribeApiHistory_ServiceParameterMap> describeApiHistoryResponse_serviceParametersMap = new List<DescribeApiHistoryResponse.DescribeApiHistory_ServiceParameterMap>();
			for (int i = 0; i < context.Length("DescribeApiHistory.ServiceParametersMap.Length"); i++) {
				DescribeApiHistoryResponse.DescribeApiHistory_ServiceParameterMap serviceParameterMap = new DescribeApiHistoryResponse.DescribeApiHistory_ServiceParameterMap();
				serviceParameterMap.ServiceParameterName = context.StringValue("DescribeApiHistory.ServiceParametersMap["+ i +"].ServiceParameterName");
				serviceParameterMap.RequestParameterName = context.StringValue("DescribeApiHistory.ServiceParametersMap["+ i +"].RequestParameterName");

				describeApiHistoryResponse_serviceParametersMap.Add(serviceParameterMap);
			}
			describeApiHistoryResponse.ServiceParametersMap = describeApiHistoryResponse_serviceParametersMap;
        
			return describeApiHistoryResponse;
        }
    }
}
