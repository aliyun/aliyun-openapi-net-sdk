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
    public class DescribeIpControlPolicyItemsResponseUnmarshaller
    {
        public static DescribeIpControlPolicyItemsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeIpControlPolicyItemsResponse describeIpControlPolicyItemsResponse = new DescribeIpControlPolicyItemsResponse();

			describeIpControlPolicyItemsResponse.HttpResponse = context.HttpResponse;
			describeIpControlPolicyItemsResponse.RequestId = context.StringValue("DescribeIpControlPolicyItems.RequestId");
			describeIpControlPolicyItemsResponse.TotalCount = context.IntegerValue("DescribeIpControlPolicyItems.TotalCount");
			describeIpControlPolicyItemsResponse.PageSize = context.IntegerValue("DescribeIpControlPolicyItems.PageSize");
			describeIpControlPolicyItemsResponse.PageNumber = context.IntegerValue("DescribeIpControlPolicyItems.PageNumber");

			List<DescribeIpControlPolicyItemsResponse.DescribeIpControlPolicyItems_IpControlPolicyItem> describeIpControlPolicyItemsResponse_ipControlPolicyItems = new List<DescribeIpControlPolicyItemsResponse.DescribeIpControlPolicyItems_IpControlPolicyItem>();
			for (int i = 0; i < context.Length("DescribeIpControlPolicyItems.IpControlPolicyItems.Length"); i++) {
				DescribeIpControlPolicyItemsResponse.DescribeIpControlPolicyItems_IpControlPolicyItem ipControlPolicyItem = new DescribeIpControlPolicyItemsResponse.DescribeIpControlPolicyItems_IpControlPolicyItem();
				ipControlPolicyItem.AppId = context.StringValue("DescribeIpControlPolicyItems.IpControlPolicyItems["+ i +"].AppId");
				ipControlPolicyItem.CidrIp = context.StringValue("DescribeIpControlPolicyItems.IpControlPolicyItems["+ i +"].CidrIp");
				ipControlPolicyItem.PolicyItemId = context.StringValue("DescribeIpControlPolicyItems.IpControlPolicyItems["+ i +"].PolicyItemId");
				ipControlPolicyItem.CreateTime = context.StringValue("DescribeIpControlPolicyItems.IpControlPolicyItems["+ i +"].CreateTime");
				ipControlPolicyItem.ModifiedTime = context.StringValue("DescribeIpControlPolicyItems.IpControlPolicyItems["+ i +"].ModifiedTime");

				describeIpControlPolicyItemsResponse_ipControlPolicyItems.Add(ipControlPolicyItem);
			}
			describeIpControlPolicyItemsResponse.IpControlPolicyItems = describeIpControlPolicyItemsResponse_ipControlPolicyItems;
        
			return describeIpControlPolicyItemsResponse;
        }
    }
}
