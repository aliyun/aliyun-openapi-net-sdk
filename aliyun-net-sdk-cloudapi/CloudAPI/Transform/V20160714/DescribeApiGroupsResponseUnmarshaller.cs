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
    public class DescribeApiGroupsResponseUnmarshaller
    {
        public static DescribeApiGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeApiGroupsResponse describeApiGroupsResponse = new DescribeApiGroupsResponse();

			describeApiGroupsResponse.HttpResponse = context.HttpResponse;
			describeApiGroupsResponse.RequestId = context.StringValue("DescribeApiGroups.RequestId");
			describeApiGroupsResponse.TotalCount = context.IntegerValue("DescribeApiGroups.TotalCount");
			describeApiGroupsResponse.PageSize = context.IntegerValue("DescribeApiGroups.PageSize");
			describeApiGroupsResponse.PageNumber = context.IntegerValue("DescribeApiGroups.PageNumber");

			List<DescribeApiGroupsResponse.ApiGroupAttribute> apiGroupAttributes = new List<DescribeApiGroupsResponse.ApiGroupAttribute>();
			for (int i = 0; i < context.Length("DescribeApiGroups.ApiGroupAttributes.Length"); i++) {
				DescribeApiGroupsResponse.ApiGroupAttribute apiGroupAttribute = new DescribeApiGroupsResponse.ApiGroupAttribute();
				apiGroupAttribute.GroupId = context.StringValue("DescribeApiGroups.ApiGroupAttributes["+ i +"].GroupId");
				apiGroupAttribute.GroupName = context.StringValue("DescribeApiGroups.ApiGroupAttributes["+ i +"].GroupName");
				apiGroupAttribute.SubDomain = context.StringValue("DescribeApiGroups.ApiGroupAttributes["+ i +"].SubDomain");
				apiGroupAttribute.Description = context.StringValue("DescribeApiGroups.ApiGroupAttributes["+ i +"].Description");
				apiGroupAttribute.CreatedTime = context.StringValue("DescribeApiGroups.ApiGroupAttributes["+ i +"].CreatedTime");
				apiGroupAttribute.ModifiedTime = context.StringValue("DescribeApiGroups.ApiGroupAttributes["+ i +"].ModifiedTime");
				apiGroupAttribute.RegionId = context.StringValue("DescribeApiGroups.ApiGroupAttributes["+ i +"].RegionId");
				apiGroupAttribute.TrafficLimit = context.IntegerValue("DescribeApiGroups.ApiGroupAttributes["+ i +"].TrafficLimit");
				apiGroupAttribute.BillingStatus = context.EnumValue<DescribeApiGroupsResponse.ApiGroupAttribute.BillingStatusEnum>("DescribeApiGroups.ApiGroupAttributes["+ i +"].BillingStatus");
				apiGroupAttribute.IllegalStatus = context.EnumValue<DescribeApiGroupsResponse.ApiGroupAttribute.IllegalStatusEnum>("DescribeApiGroups.ApiGroupAttributes["+ i +"].IllegalStatus");

				apiGroupAttributes.Add(apiGroupAttribute);
			}
			describeApiGroupsResponse.ApiGroupAttributes = apiGroupAttributes;
        
			return describeApiGroupsResponse;
        }
    }
}