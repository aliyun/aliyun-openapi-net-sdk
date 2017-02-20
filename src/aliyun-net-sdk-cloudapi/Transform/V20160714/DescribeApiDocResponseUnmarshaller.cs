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
    public class DescribeApiDocResponseUnmarshaller
    {
        public static DescribeApiDocResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeApiDocResponse describeApiDocResponse = new DescribeApiDocResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeApiDoc.RequestId"),
                RegionId = context.StringValue("DescribeApiDoc.RegionId"),
                GroupId = context.StringValue("DescribeApiDoc.GroupId"),
                GroupName = context.StringValue("DescribeApiDoc.GroupName"),
                StageName = context.StringValue("DescribeApiDoc.StageName"),
                ApiId = context.StringValue("DescribeApiDoc.ApiId"),
                ApiName = context.StringValue("DescribeApiDoc.ApiName"),
                Description = context.StringValue("DescribeApiDoc.Description"),
                Visibility = context.StringValue("DescribeApiDoc.Visibility"),
                AuthType = context.StringValue("DescribeApiDoc.AuthType"),
                ResultType = context.StringValue("DescribeApiDoc.ResultType"),
                ResultSample = context.StringValue("DescribeApiDoc.ResultSample"),
                FailResultSample = context.StringValue("DescribeApiDoc.FailResultSample"),
                DeployedTime = context.StringValue("DescribeApiDoc.DeployedTime")
            };
            DescribeApiDocResponse.RequestConfig_ requestConfig = new DescribeApiDocResponse.RequestConfig_()
            {
                RequestProtocol = context.StringValue("DescribeApiDoc.RequestConfig.RequestProtocol"),
                RequestHttpMethod = context.StringValue("DescribeApiDoc.RequestConfig.RequestHttpMethod"),
                RequestPath = context.StringValue("DescribeApiDoc.RequestConfig.RequestPath"),
                BodyFormat = context.StringValue("DescribeApiDoc.RequestConfig.BodyFormat"),
                PostBodyDescription = context.StringValue("DescribeApiDoc.RequestConfig.PostBodyDescription")
            };
            describeApiDocResponse.RequestConfig = requestConfig;

			List<DescribeApiDocResponse.ErrorCodeSample> errorCodeSamples = new List<DescribeApiDocResponse.ErrorCodeSample>();
			for (int i = 0; i < context.Length("DescribeApiDoc.ErrorCodeSamples.Length"); i++) {
                DescribeApiDocResponse.ErrorCodeSample errorCodeSample = new DescribeApiDocResponse.ErrorCodeSample()
                {
                    Code = context.StringValue($"DescribeApiDoc.ErrorCodeSamples[{i}].Code"),
                    Message = context.StringValue($"DescribeApiDoc.ErrorCodeSamples[{i}].Message"),
                    Description = context.StringValue($"DescribeApiDoc.ErrorCodeSamples[{i}].Description")
                };
                errorCodeSamples.Add(errorCodeSample);
			}
			describeApiDocResponse.ErrorCodeSamples = errorCodeSamples;

			List<DescribeApiDocResponse.RequestParameter> requestParameters = new List<DescribeApiDocResponse.RequestParameter>();
			for (int i = 0; i < context.Length("DescribeApiDoc.RequestParameters.Length"); i++) {
                DescribeApiDocResponse.RequestParameter requestParameter = new DescribeApiDocResponse.RequestParameter()
                {
                    ApiParameterName = context.StringValue($"DescribeApiDoc.RequestParameters[{i}].ApiParameterName"),
                    Location = context.StringValue($"DescribeApiDoc.RequestParameters[{i}].Location"),
                    ParameterType = context.StringValue($"DescribeApiDoc.RequestParameters[{i}].ParameterType"),
                    Required = context.StringValue($"DescribeApiDoc.RequestParameters[{i}].Required"),
                    DefaultValue = context.StringValue($"DescribeApiDoc.RequestParameters[{i}].DefaultValue"),
                    DemoValue = context.StringValue($"DescribeApiDoc.RequestParameters[{i}].DemoValue"),
                    MaxValue = context.LongValue($"DescribeApiDoc.RequestParameters[{i}].MaxValue"),
                    MinValue = context.LongValue($"DescribeApiDoc.RequestParameters[{i}].MinValue"),
                    MaxLength = context.LongValue($"DescribeApiDoc.RequestParameters[{i}].MaxLength"),
                    MinLength = context.LongValue($"DescribeApiDoc.RequestParameters[{i}].MinLength"),
                    RegularExpression = context.StringValue($"DescribeApiDoc.RequestParameters[{i}].RegularExpression"),
                    JsonScheme = context.StringValue($"DescribeApiDoc.RequestParameters[{i}].JsonScheme"),
                    EnumValue = context.StringValue($"DescribeApiDoc.RequestParameters[{i}].EnumValue"),
                    DocShow = context.StringValue($"DescribeApiDoc.RequestParameters[{i}].DocShow"),
                    DocOrder = context.IntegerValue($"DescribeApiDoc.RequestParameters[{i}].DocOrder"),
                    Description = context.StringValue($"DescribeApiDoc.RequestParameters[{i}].Description")
                };
                requestParameters.Add(requestParameter);
			}
			describeApiDocResponse.RequestParameters = requestParameters;
        
			return describeApiDocResponse;
        }
    }
}