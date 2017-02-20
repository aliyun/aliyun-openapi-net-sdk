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
    public class DescribeAuthorizedApisResponseUnmarshaller
    {
        public static DescribeAuthorizedApisResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeAuthorizedApisResponse describeAuthorizedApisResponse = new DescribeAuthorizedApisResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeAuthorizedApis.RequestId"),
                TotalCount = context.IntegerValue("DescribeAuthorizedApis.TotalCount"),
                PageSize = context.IntegerValue("DescribeAuthorizedApis.PageSize"),
                PageNumber = context.IntegerValue("DescribeAuthorizedApis.PageNumber")
            };
            List<DescribeAuthorizedApisResponse.AuthorizedApi> authorizedApis = new List<DescribeAuthorizedApisResponse.AuthorizedApi>();
			for (int i = 0; i < context.Length("DescribeAuthorizedApis.AuthorizedApis.Length"); i++) {
                DescribeAuthorizedApisResponse.AuthorizedApi authorizedApi = new DescribeAuthorizedApisResponse.AuthorizedApi()
                {
                    RegionId = context.StringValue($"DescribeAuthorizedApis.AuthorizedApis[{i}].RegionId"),
                    GroupId = context.StringValue($"DescribeAuthorizedApis.AuthorizedApis[{i}].GroupId"),
                    GroupName = context.StringValue($"DescribeAuthorizedApis.AuthorizedApis[{i}].GroupName"),
                    StageName = context.StringValue($"DescribeAuthorizedApis.AuthorizedApis[{i}].StageName"),
                    Operator = context.StringValue($"DescribeAuthorizedApis.AuthorizedApis[{i}].Operator"),
                    ApiId = context.StringValue($"DescribeAuthorizedApis.AuthorizedApis[{i}].ApiId"),
                    ApiName = context.StringValue($"DescribeAuthorizedApis.AuthorizedApis[{i}].ApiName"),
                    AuthorizationSource = context.StringValue($"DescribeAuthorizedApis.AuthorizedApis[{i}].AuthorizationSource"),
                    Description = context.StringValue($"DescribeAuthorizedApis.AuthorizedApis[{i}].Description"),
                    AuthorizedTime = context.StringValue($"DescribeAuthorizedApis.AuthorizedApis[{i}].AuthorizedTime")
                };
                authorizedApis.Add(authorizedApi);
			}
			describeAuthorizedApisResponse.AuthorizedApis = authorizedApis;
        
			return describeAuthorizedApisResponse;
        }
    }
}