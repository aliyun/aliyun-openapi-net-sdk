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
    public class DescribeApisByTrafficControlResponseUnmarshaller
    {
        public static DescribeApisByTrafficControlResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeApisByTrafficControlResponse describeApisByTrafficControlResponse = new DescribeApisByTrafficControlResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeApisByTrafficControl.RequestId"),
                TotalCount = context.IntegerValue("DescribeApisByTrafficControl.TotalCount"),
                PageSize = context.IntegerValue("DescribeApisByTrafficControl.PageSize"),
                PageNumber = context.IntegerValue("DescribeApisByTrafficControl.PageNumber")
            };
            List<DescribeApisByTrafficControlResponse.ApiInfo> apiInfos = new List<DescribeApisByTrafficControlResponse.ApiInfo>();
			for (int i = 0; i < context.Length("DescribeApisByTrafficControl.ApiInfos.Length"); i++) {
                DescribeApisByTrafficControlResponse.ApiInfo apiInfo = new DescribeApisByTrafficControlResponse.ApiInfo()
                {
                    RegionId = context.StringValue($"DescribeApisByTrafficControl.ApiInfos[{i}].RegionId"),
                    GroupId = context.StringValue($"DescribeApisByTrafficControl.ApiInfos[{i}].GroupId"),
                    GroupName = context.StringValue($"DescribeApisByTrafficControl.ApiInfos[{i}].GroupName"),
                    StageName = context.StringValue($"DescribeApisByTrafficControl.ApiInfos[{i}].StageName"),
                    ApiId = context.StringValue($"DescribeApisByTrafficControl.ApiInfos[{i}].ApiId"),
                    ApiName = context.StringValue($"DescribeApisByTrafficControl.ApiInfos[{i}].ApiName"),
                    Description = context.StringValue($"DescribeApisByTrafficControl.ApiInfos[{i}].Description"),
                    Visibility = context.StringValue($"DescribeApisByTrafficControl.ApiInfos[{i}].Visibility"),
                    BoundTime = context.StringValue($"DescribeApisByTrafficControl.ApiInfos[{i}].BoundTime")
                };
                apiInfos.Add(apiInfo);
			}
			describeApisByTrafficControlResponse.ApiInfos = apiInfos;
        
			return describeApisByTrafficControlResponse;
        }
    }
}