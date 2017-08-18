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

			DescribeApiHistoryResponse.RequestConfig_ requestConfig = new DescribeApiHistoryResponse.RequestConfig_();
			requestConfig.RequestProtocol = context.StringValue("DescribeApiHistory.RequestConfig.RequestProtocol");
			requestConfig.RequestHttpMethod = context.StringValue("DescribeApiHistory.RequestConfig.RequestHttpMethod");
			requestConfig.RequestPath = context.StringValue("DescribeApiHistory.RequestConfig.RequestPath");
			requestConfig.BodyFormat = context.StringValue("DescribeApiHistory.RequestConfig.BodyFormat");
			requestConfig.PostBodyDescription = context.StringValue("DescribeApiHistory.RequestConfig.PostBodyDescription");
			requestConfig.RequestMode = context.StringValue("DescribeApiHistory.RequestConfig.RequestMode");
			describeApiHistoryResponse.RequestConfig = requestConfig;

			DescribeApiHistoryResponse.ServiceConfig_ serviceConfig = new DescribeApiHistoryResponse.ServiceConfig_();
			serviceConfig.ServiceProtocol = context.StringValue("DescribeApiHistory.ServiceConfig.ServiceProtocol");
			serviceConfig.ServiceAddress = context.StringValue("DescribeApiHistory.ServiceConfig.ServiceAddress");
			serviceConfig.ServiceHttpMethod = context.StringValue("DescribeApiHistory.ServiceConfig.ServiceHttpMethod");
			serviceConfig.ServicePath = context.StringValue("DescribeApiHistory.ServiceConfig.ServicePath");
			serviceConfig.ServiceTimeout = context.IntegerValue("DescribeApiHistory.ServiceConfig.ServiceTimeout");
			serviceConfig.Mock = context.EnumValue<DescribeApiHistoryResponse.ServiceConfig_.MockEnum>("DescribeApiHistory.ServiceConfig.Mock");
			serviceConfig.MockResult = context.StringValue("DescribeApiHistory.ServiceConfig.MockResult");
			serviceConfig.ServiceVpcEnable = context.EnumValue<DescribeApiHistoryResponse.ServiceConfig_.ServiceVpcEnableEnum>("DescribeApiHistory.ServiceConfig.ServiceVpcEnable");

			DescribeApiHistoryResponse.ServiceConfig_.VpcConfig_ vpcConfig = new DescribeApiHistoryResponse.ServiceConfig_.VpcConfig_();
			vpcConfig.Name = context.StringValue("DescribeApiHistory.ServiceConfig.VpcConfig.Name");
			vpcConfig.VpcId = context.StringValue("DescribeApiHistory.ServiceConfig.VpcConfig.VpcId");
			vpcConfig.InstanceId = context.StringValue("DescribeApiHistory.ServiceConfig.VpcConfig.InstanceId");
			vpcConfig.Port = context.IntegerValue("DescribeApiHistory.ServiceConfig.VpcConfig.Port");
			serviceConfig.VpcConfig = vpcConfig;
			describeApiHistoryResponse.ServiceConfig = serviceConfig;

			DescribeApiHistoryResponse.OpenIdConnectConfig_ openIdConnectConfig = new DescribeApiHistoryResponse.OpenIdConnectConfig_();
			openIdConnectConfig.OpenIdApiType = context.StringValue("DescribeApiHistory.OpenIdConnectConfig.OpenIdApiType");
			openIdConnectConfig.IdTokenParamName = context.StringValue("DescribeApiHistory.OpenIdConnectConfig.IdTokenParamName");
			openIdConnectConfig.PublicKeyId = context.StringValue("DescribeApiHistory.OpenIdConnectConfig.PublicKeyId");
			openIdConnectConfig.PublicKey = context.StringValue("DescribeApiHistory.OpenIdConnectConfig.PublicKey");
			describeApiHistoryResponse.OpenIdConnectConfig = openIdConnectConfig;

			List<DescribeApiHistoryResponse.ErrorCodeSample> errorCodeSamples = new List<DescribeApiHistoryResponse.ErrorCodeSample>();
			for (int i = 0; i < context.Length("DescribeApiHistory.ErrorCodeSamples.Length"); i++) {
				DescribeApiHistoryResponse.ErrorCodeSample errorCodeSample = new DescribeApiHistoryResponse.ErrorCodeSample();
				errorCodeSample.Code = context.StringValue("DescribeApiHistory.ErrorCodeSamples["+ i +"].Code");
				errorCodeSample.Message = context.StringValue("DescribeApiHistory.ErrorCodeSamples["+ i +"].Message");
				errorCodeSample.Description = context.StringValue("DescribeApiHistory.ErrorCodeSamples["+ i +"].Description");

				errorCodeSamples.Add(errorCodeSample);
			}
			describeApiHistoryResponse.ErrorCodeSamples = errorCodeSamples;

			List<DescribeApiHistoryResponse.ResultDescription> resultDescriptions = new List<DescribeApiHistoryResponse.ResultDescription>();
			for (int i = 0; i < context.Length("DescribeApiHistory.ResultDescriptions.Length"); i++) {
				DescribeApiHistoryResponse.ResultDescription resultDescription = new DescribeApiHistoryResponse.ResultDescription();
				resultDescription.Id = context.StringValue("DescribeApiHistory.ResultDescriptions["+ i +"].Id");
				resultDescription.Pid = context.StringValue("DescribeApiHistory.ResultDescriptions["+ i +"].Pid");
				resultDescription.HasChild = context.BooleanValue("DescribeApiHistory.ResultDescriptions["+ i +"].HasChild");
				resultDescription.Key = context.StringValue("DescribeApiHistory.ResultDescriptions["+ i +"].Key");
				resultDescription.Name = context.StringValue("DescribeApiHistory.ResultDescriptions["+ i +"].Name");
				resultDescription.Mandatory = context.BooleanValue("DescribeApiHistory.ResultDescriptions["+ i +"].Mandatory");
				resultDescription.Type = context.StringValue("DescribeApiHistory.ResultDescriptions["+ i +"].Type");
				resultDescription.Description = context.StringValue("DescribeApiHistory.ResultDescriptions["+ i +"].Description");

				resultDescriptions.Add(resultDescription);
			}
			describeApiHistoryResponse.ResultDescriptions = resultDescriptions;

			List<DescribeApiHistoryResponse.SystemParameter> systemParameters = new List<DescribeApiHistoryResponse.SystemParameter>();
			for (int i = 0; i < context.Length("DescribeApiHistory.SystemParameters.Length"); i++) {
				DescribeApiHistoryResponse.SystemParameter systemParameter = new DescribeApiHistoryResponse.SystemParameter();
				systemParameter.ParameterName = context.StringValue("DescribeApiHistory.SystemParameters["+ i +"].ParameterName");
				systemParameter.ServiceParameterName = context.StringValue("DescribeApiHistory.SystemParameters["+ i +"].ServiceParameterName");
				systemParameter.Location = context.StringValue("DescribeApiHistory.SystemParameters["+ i +"].Location");
				systemParameter.DemoValue = context.StringValue("DescribeApiHistory.SystemParameters["+ i +"].DemoValue");
				systemParameter.Description = context.StringValue("DescribeApiHistory.SystemParameters["+ i +"].Description");

				systemParameters.Add(systemParameter);
			}
			describeApiHistoryResponse.SystemParameters = systemParameters;

			List<DescribeApiHistoryResponse.CustomSystemParameter> customSystemParameters = new List<DescribeApiHistoryResponse.CustomSystemParameter>();
			for (int i = 0; i < context.Length("DescribeApiHistory.CustomSystemParameters.Length"); i++) {
				DescribeApiHistoryResponse.CustomSystemParameter customSystemParameter = new DescribeApiHistoryResponse.CustomSystemParameter();
				customSystemParameter.ParameterName = context.StringValue("DescribeApiHistory.CustomSystemParameters["+ i +"].ParameterName");
				customSystemParameter.ServiceParameterName = context.StringValue("DescribeApiHistory.CustomSystemParameters["+ i +"].ServiceParameterName");
				customSystemParameter.Location = context.StringValue("DescribeApiHistory.CustomSystemParameters["+ i +"].Location");
				customSystemParameter.DemoValue = context.StringValue("DescribeApiHistory.CustomSystemParameters["+ i +"].DemoValue");
				customSystemParameter.Description = context.StringValue("DescribeApiHistory.CustomSystemParameters["+ i +"].Description");

				customSystemParameters.Add(customSystemParameter);
			}
			describeApiHistoryResponse.CustomSystemParameters = customSystemParameters;

			List<DescribeApiHistoryResponse.ConstantParameter> constantParameters = new List<DescribeApiHistoryResponse.ConstantParameter>();
			for (int i = 0; i < context.Length("DescribeApiHistory.ConstantParameters.Length"); i++) {
				DescribeApiHistoryResponse.ConstantParameter constantParameter = new DescribeApiHistoryResponse.ConstantParameter();
				constantParameter.ServiceParameterName = context.StringValue("DescribeApiHistory.ConstantParameters["+ i +"].ServiceParameterName");
				constantParameter.ConstantValue = context.StringValue("DescribeApiHistory.ConstantParameters["+ i +"].ConstantValue");
				constantParameter.Location = context.StringValue("DescribeApiHistory.ConstantParameters["+ i +"].Location");
				constantParameter.Description = context.StringValue("DescribeApiHistory.ConstantParameters["+ i +"].Description");

				constantParameters.Add(constantParameter);
			}
			describeApiHistoryResponse.ConstantParameters = constantParameters;

			List<DescribeApiHistoryResponse.RequestParameter> requestParameters = new List<DescribeApiHistoryResponse.RequestParameter>();
			for (int i = 0; i < context.Length("DescribeApiHistory.RequestParameters.Length"); i++) {
				DescribeApiHistoryResponse.RequestParameter requestParameter = new DescribeApiHistoryResponse.RequestParameter();
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

				requestParameters.Add(requestParameter);
			}
			describeApiHistoryResponse.RequestParameters = requestParameters;

			List<DescribeApiHistoryResponse.ServiceParameter> serviceParameters = new List<DescribeApiHistoryResponse.ServiceParameter>();
			for (int i = 0; i < context.Length("DescribeApiHistory.ServiceParameters.Length"); i++) {
				DescribeApiHistoryResponse.ServiceParameter serviceParameter = new DescribeApiHistoryResponse.ServiceParameter();
				serviceParameter.ServiceParameterName = context.StringValue("DescribeApiHistory.ServiceParameters["+ i +"].ServiceParameterName");
				serviceParameter.Location = context.StringValue("DescribeApiHistory.ServiceParameters["+ i +"].Location");
				serviceParameter.ParameterType = context.StringValue("DescribeApiHistory.ServiceParameters["+ i +"].ParameterType");

				serviceParameters.Add(serviceParameter);
			}
			describeApiHistoryResponse.ServiceParameters = serviceParameters;

			List<DescribeApiHistoryResponse.ServiceParameterMap> serviceParametersMap = new List<DescribeApiHistoryResponse.ServiceParameterMap>();
			for (int i = 0; i < context.Length("DescribeApiHistory.ServiceParametersMap.Length"); i++) {
				DescribeApiHistoryResponse.ServiceParameterMap serviceParameterMap = new DescribeApiHistoryResponse.ServiceParameterMap();
				serviceParameterMap.ServiceParameterName = context.StringValue("DescribeApiHistory.ServiceParametersMap["+ i +"].ServiceParameterName");
				serviceParameterMap.RequestParameterName = context.StringValue("DescribeApiHistory.ServiceParametersMap["+ i +"].RequestParameterName");

				serviceParametersMap.Add(serviceParameterMap);
			}
			describeApiHistoryResponse.ServiceParametersMap = serviceParametersMap;
        
			return describeApiHistoryResponse;
        }
    }
}