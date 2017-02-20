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
    public class DescribeAppAttributesResponseUnmarshaller
    {
        public static DescribeAppAttributesResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeAppAttributesResponse describeAppAttributesResponse = new DescribeAppAttributesResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeAppAttributes.RequestId"),
                TotalCount = context.IntegerValue("DescribeAppAttributes.TotalCount"),
                PageSize = context.IntegerValue("DescribeAppAttributes.PageSize"),
                PageNumber = context.IntegerValue("DescribeAppAttributes.PageNumber")
            };
            List<DescribeAppAttributesResponse.AppAttribute> apps = new List<DescribeAppAttributesResponse.AppAttribute>();
			for (int i = 0; i < context.Length("DescribeAppAttributes.Apps.Length"); i++) {
                DescribeAppAttributesResponse.AppAttribute appAttribute = new DescribeAppAttributesResponse.AppAttribute()
                {
                    AppId = context.LongValue($"DescribeAppAttributes.Apps[{i}].AppId"),
                    AppName = context.StringValue($"DescribeAppAttributes.Apps[{i}].AppName"),
                    Description = context.StringValue($"DescribeAppAttributes.Apps[{i}].Description"),
                    CreatedTime = context.StringValue($"DescribeAppAttributes.Apps[{i}].CreatedTime"),
                    ModifiedTime = context.StringValue($"DescribeAppAttributes.Apps[{i}].ModifiedTime")
                };
                apps.Add(appAttribute);
			}
			describeAppAttributesResponse.Apps = apps;
        
			return describeAppAttributesResponse;
        }
    }
}