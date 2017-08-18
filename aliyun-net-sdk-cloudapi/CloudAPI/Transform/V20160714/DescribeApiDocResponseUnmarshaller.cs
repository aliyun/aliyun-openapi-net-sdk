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
    public class DescribeApiDocResponseUnmarshaller
    {
        public static DescribeApiDocResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeApiDocResponse describeApiDocResponse = new DescribeApiDocResponse();

			describeApiDocResponse.HttpResponse = context.HttpResponse;
			describeApiDocResponse.RequestId = context.StringValue("DescribeApiDoc.RequestId");
			describeApiDocResponse.RegionId = context.StringValue("DescribeApiDoc.RegionId");
			describeApiDocResponse.GroupId = context.StringValue("DescribeApiDoc.GroupId");
			describeApiDocResponse.GroupName = context.StringValue("DescribeApiDoc.GroupName");
			describeApiDocResponse.StageName = context.StringValue("DescribeApiDoc.StageName");
			describeApiDocResponse.ApiId = context.StringValue("DescribeApiDoc.ApiId");
			describeApiDocResponse.ApiName = context.StringValue("DescribeApiDoc.ApiName");
			describeApiDocResponse.Description = context.StringValue("DescribeApiDoc.Description");
			describeApiDocResponse.Visibility = context.StringValue("DescribeApiDoc.Visibility");
			describeApiDocResponse.AuthType = context.StringValue("DescribeApiDoc.AuthType");
			describeApiDocResponse.ResultType = context.StringValue("DescribeApiDoc.ResultType");
			describeApiDocResponse.ResultSample = context.StringValue("DescribeApiDoc.ResultSample");
			describeApiDocResponse.FailResultSample = context.StringValue("DescribeApiDoc.FailResultSample");
			describeApiDocResponse.DeployedTime = context.StringValue("DescribeApiDoc.DeployedTime");

			DescribeApiDocResponse.RequestConfig_ requestConfig = new DescribeApiDocResponse.RequestConfig_();
			requestConfig.RequestProtocol = context.StringValue("DescribeApiDoc.RequestConfig.RequestProtocol");
			requestConfig.RequestHttpMethod = context.StringValue("DescribeApiDoc.RequestConfig.RequestHttpMethod");
			requestConfig.RequestPath = context.StringValue("DescribeApiDoc.RequestConfig.RequestPath");
			requestConfig.BodyFormat = context.StringValue("DescribeApiDoc.RequestConfig.BodyFormat");
			requestConfig.PostBodyDescription = context.StringValue("DescribeApiDoc.RequestConfig.PostBodyDescription");
			requestConfig.RequestMode = context.StringValue("DescribeApiDoc.RequestConfig.RequestMode");
			describeApiDocResponse.RequestConfig = requestConfig;

			List<DescribeApiDocResponse.ErrorCodeSample> errorCodeSamples = new List<DescribeApiDocResponse.ErrorCodeSample>();
			for (int i = 0; i < context.Length("DescribeApiDoc.ErrorCodeSamples.Length"); i++) {
				DescribeApiDocResponse.ErrorCodeSample errorCodeSample = new DescribeApiDocResponse.ErrorCodeSample();
				errorCodeSample.Code = context.StringValue("DescribeApiDoc.ErrorCodeSamples["+ i +"].Code");
				errorCodeSample.Message = context.StringValue("DescribeApiDoc.ErrorCodeSamples["+ i +"].Message");
				errorCodeSample.Description = context.StringValue("DescribeApiDoc.ErrorCodeSamples["+ i +"].Description");

				errorCodeSamples.Add(errorCodeSample);
			}
			describeApiDocResponse.ErrorCodeSamples = errorCodeSamples;

			List<DescribeApiDocResponse.ResultDescription> resultDescriptions = new List<DescribeApiDocResponse.ResultDescription>();
			for (int i = 0; i < context.Length("DescribeApiDoc.ResultDescriptions.Length"); i++) {
				DescribeApiDocResponse.ResultDescription resultDescription = new DescribeApiDocResponse.ResultDescription();
				resultDescription.Id = context.StringValue("DescribeApiDoc.ResultDescriptions["+ i +"].Id");
				resultDescription.Pid = context.StringValue("DescribeApiDoc.ResultDescriptions["+ i +"].Pid");
				resultDescription.HasChild = context.BooleanValue("DescribeApiDoc.ResultDescriptions["+ i +"].HasChild");
				resultDescription.Key = context.StringValue("DescribeApiDoc.ResultDescriptions["+ i +"].Key");
				resultDescription.Name = context.StringValue("DescribeApiDoc.ResultDescriptions["+ i +"].Name");
				resultDescription.Mandatory = context.BooleanValue("DescribeApiDoc.ResultDescriptions["+ i +"].Mandatory");
				resultDescription.Type = context.StringValue("DescribeApiDoc.ResultDescriptions["+ i +"].Type");
				resultDescription.Description = context.StringValue("DescribeApiDoc.ResultDescriptions["+ i +"].Description");
				resultDescription.Example = context.StringValue("DescribeApiDoc.ResultDescriptions["+ i +"].Example");

				resultDescriptions.Add(resultDescription);
			}
			describeApiDocResponse.ResultDescriptions = resultDescriptions;

			List<DescribeApiDocResponse.RequestParameter> requestParameters = new List<DescribeApiDocResponse.RequestParameter>();
			for (int i = 0; i < context.Length("DescribeApiDoc.RequestParameters.Length"); i++) {
				DescribeApiDocResponse.RequestParameter requestParameter = new DescribeApiDocResponse.RequestParameter();
				requestParameter.ApiParameterName = context.StringValue("DescribeApiDoc.RequestParameters["+ i +"].ApiParameterName");
				requestParameter.Location = context.StringValue("DescribeApiDoc.RequestParameters["+ i +"].Location");
				requestParameter.ParameterType = context.StringValue("DescribeApiDoc.RequestParameters["+ i +"].ParameterType");
				requestParameter.Required = context.StringValue("DescribeApiDoc.RequestParameters["+ i +"].Required");
				requestParameter.DefaultValue = context.StringValue("DescribeApiDoc.RequestParameters["+ i +"].DefaultValue");
				requestParameter.DemoValue = context.StringValue("DescribeApiDoc.RequestParameters["+ i +"].DemoValue");
				requestParameter.MaxValue = context.LongValue("DescribeApiDoc.RequestParameters["+ i +"].MaxValue");
				requestParameter.MinValue = context.LongValue("DescribeApiDoc.RequestParameters["+ i +"].MinValue");
				requestParameter.MaxLength = context.LongValue("DescribeApiDoc.RequestParameters["+ i +"].MaxLength");
				requestParameter.MinLength = context.LongValue("DescribeApiDoc.RequestParameters["+ i +"].MinLength");
				requestParameter.RegularExpression = context.StringValue("DescribeApiDoc.RequestParameters["+ i +"].RegularExpression");
				requestParameter.JsonScheme = context.StringValue("DescribeApiDoc.RequestParameters["+ i +"].JsonScheme");
				requestParameter.EnumValue = context.StringValue("DescribeApiDoc.RequestParameters["+ i +"].EnumValue");
				requestParameter.DocShow = context.StringValue("DescribeApiDoc.RequestParameters["+ i +"].DocShow");
				requestParameter.DocOrder = context.IntegerValue("DescribeApiDoc.RequestParameters["+ i +"].DocOrder");
				requestParameter.Description = context.StringValue("DescribeApiDoc.RequestParameters["+ i +"].Description");

				requestParameters.Add(requestParameter);
			}
			describeApiDocResponse.RequestParameters = requestParameters;
        
			return describeApiDocResponse;
        }
    }
}