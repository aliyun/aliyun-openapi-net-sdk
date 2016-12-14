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

			DescribeApiResponse.RequestConfig_ requestConfig = new DescribeApiResponse.RequestConfig_();
			requestConfig.RequestProtocol = context.StringValue("DescribeApi.RequestConfig.RequestProtocol");
			requestConfig.RequestHttpMethod = context.StringValue("DescribeApi.RequestConfig.RequestHttpMethod");
			requestConfig.RequestPath = context.StringValue("DescribeApi.RequestConfig.RequestPath");
			requestConfig.BodyFormat = context.StringValue("DescribeApi.RequestConfig.BodyFormat");
			requestConfig.PostBodyDescription = context.StringValue("DescribeApi.RequestConfig.PostBodyDescription");
			describeApiResponse.RequestConfig = requestConfig;

			DescribeApiResponse.ServiceConfig_ serviceConfig = new DescribeApiResponse.ServiceConfig_();
			serviceConfig.ServiceProtocol = context.StringValue("DescribeApi.ServiceConfig.ServiceProtocol");
			serviceConfig.ServiceAddress = context.StringValue("DescribeApi.ServiceConfig.ServiceAddress");
			serviceConfig.ServiceHttpMethod = context.StringValue("DescribeApi.ServiceConfig.ServiceHttpMethod");
			serviceConfig.ServicePath = context.StringValue("DescribeApi.ServiceConfig.ServicePath");
			serviceConfig.ServiceTimeout = context.IntegerValue("DescribeApi.ServiceConfig.ServiceTimeout");
			describeApiResponse.ServiceConfig = serviceConfig;

			List<DescribeApiResponse.ErrorCodeSample> errorCodeSamples = new List<DescribeApiResponse.ErrorCodeSample>();
			for (int i = 0; i < context.Length("DescribeApi.ErrorCodeSamples.Length"); i++) {
				DescribeApiResponse.ErrorCodeSample errorCodeSample = new DescribeApiResponse.ErrorCodeSample();
				errorCodeSample.Code = context.StringValue("DescribeApi.ErrorCodeSamples["+ i +"].Code");
				errorCodeSample.Message = context.StringValue("DescribeApi.ErrorCodeSamples["+ i +"].Message");
				errorCodeSample.Description = context.StringValue("DescribeApi.ErrorCodeSamples["+ i +"].Description");

				errorCodeSamples.Add(errorCodeSample);
			}
			describeApiResponse.ErrorCodeSamples = errorCodeSamples;

			List<DescribeApiResponse.SystemParameter> systemParameters = new List<DescribeApiResponse.SystemParameter>();
			for (int i = 0; i < context.Length("DescribeApi.SystemParameters.Length"); i++) {
				DescribeApiResponse.SystemParameter systemParameter = new DescribeApiResponse.SystemParameter();
				systemParameter.ParameterName = context.StringValue("DescribeApi.SystemParameters["+ i +"].ParameterName");
				systemParameter.ServiceParameterName = context.StringValue("DescribeApi.SystemParameters["+ i +"].ServiceParameterName");
				systemParameter.Location = context.StringValue("DescribeApi.SystemParameters["+ i +"].Location");
				systemParameter.DemoValue = context.StringValue("DescribeApi.SystemParameters["+ i +"].DemoValue");
				systemParameter.Description = context.StringValue("DescribeApi.SystemParameters["+ i +"].Description");

				systemParameters.Add(systemParameter);
			}
			describeApiResponse.SystemParameters = systemParameters;

			List<DescribeApiResponse.ConstantParameter> constantParameters = new List<DescribeApiResponse.ConstantParameter>();
			for (int i = 0; i < context.Length("DescribeApi.ConstantParameters.Length"); i++) {
				DescribeApiResponse.ConstantParameter constantParameter = new DescribeApiResponse.ConstantParameter();
				constantParameter.ServiceParameterName = context.StringValue("DescribeApi.ConstantParameters["+ i +"].ServiceParameterName");
				constantParameter.ConstantValue = context.StringValue("DescribeApi.ConstantParameters["+ i +"].ConstantValue");
				constantParameter.Location = context.StringValue("DescribeApi.ConstantParameters["+ i +"].Location");
				constantParameter.Description = context.StringValue("DescribeApi.ConstantParameters["+ i +"].Description");

				constantParameters.Add(constantParameter);
			}
			describeApiResponse.ConstantParameters = constantParameters;

			List<DescribeApiResponse.RequestParameter> requestParameters = new List<DescribeApiResponse.RequestParameter>();
			for (int i = 0; i < context.Length("DescribeApi.RequestParameters.Length"); i++) {
				DescribeApiResponse.RequestParameter requestParameter = new DescribeApiResponse.RequestParameter();
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

				requestParameters.Add(requestParameter);
			}
			describeApiResponse.RequestParameters = requestParameters;

			List<DescribeApiResponse.ServiceParameter> serviceParameters = new List<DescribeApiResponse.ServiceParameter>();
			for (int i = 0; i < context.Length("DescribeApi.ServiceParameters.Length"); i++) {
				DescribeApiResponse.ServiceParameter serviceParameter = new DescribeApiResponse.ServiceParameter();
				serviceParameter.ServiceParameterName = context.StringValue("DescribeApi.ServiceParameters["+ i +"].ServiceParameterName");
				serviceParameter.Location = context.StringValue("DescribeApi.ServiceParameters["+ i +"].Location");
				serviceParameter.ParameterType = context.StringValue("DescribeApi.ServiceParameters["+ i +"].ParameterType");

				serviceParameters.Add(serviceParameter);
			}
			describeApiResponse.ServiceParameters = serviceParameters;

			List<DescribeApiResponse.ServiceParameterMap> serviceParametersMap = new List<DescribeApiResponse.ServiceParameterMap>();
			for (int i = 0; i < context.Length("DescribeApi.ServiceParametersMap.Length"); i++) {
				DescribeApiResponse.ServiceParameterMap serviceParameterMap = new DescribeApiResponse.ServiceParameterMap();
				serviceParameterMap.ServiceParameterName = context.StringValue("DescribeApi.ServiceParametersMap["+ i +"].ServiceParameterName");
				serviceParameterMap.RequestParameterName = context.StringValue("DescribeApi.ServiceParametersMap["+ i +"].RequestParameterName");

				serviceParametersMap.Add(serviceParameterMap);
			}
			describeApiResponse.ServiceParametersMap = serviceParametersMap;

			List<DescribeApiResponse.DeployedInfo> deployedInfos = new List<DescribeApiResponse.DeployedInfo>();
			for (int i = 0; i < context.Length("DescribeApi.DeployedInfos.Length"); i++) {
				DescribeApiResponse.DeployedInfo deployedInfo = new DescribeApiResponse.DeployedInfo();
				deployedInfo.StageName = context.StringValue("DescribeApi.DeployedInfos["+ i +"].StageName");
				deployedInfo.EffectiveVersion = context.StringValue("DescribeApi.DeployedInfos["+ i +"].EffectiveVersion");
				deployedInfo.DeployedStatus = context.StringValue("DescribeApi.DeployedInfos["+ i +"].DeployedStatus");

				deployedInfos.Add(deployedInfo);
			}
			describeApiResponse.DeployedInfos = deployedInfos;
        
			return describeApiResponse;
        }
    }
}