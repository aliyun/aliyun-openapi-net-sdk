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
using Aliyun.Acs.Market.Model.V20151101;

namespace Aliyun.Acs.Market.Transform.V20151101
{
    public class DescribeInstancesResponseUnmarshaller
    {
        public static DescribeInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstancesResponse describeInstancesResponse = new DescribeInstancesResponse();

			describeInstancesResponse.HttpResponse = context.HttpResponse;
			describeInstancesResponse.RequestId = context.StringValue("DescribeInstances.RequestId");
			describeInstancesResponse.PageNumber = context.IntegerValue("DescribeInstances.PageNumber");
			describeInstancesResponse.PageSize = context.IntegerValue("DescribeInstances.PageSize");
			describeInstancesResponse.TotalCount = context.IntegerValue("DescribeInstances.TotalCount");

			List<DescribeInstancesResponse.DescribeInstances_InstanceItem> describeInstancesResponse_instanceItems = new List<DescribeInstancesResponse.DescribeInstances_InstanceItem>();
			for (int i = 0; i < context.Length("DescribeInstances.InstanceItems.Length"); i++) {
				DescribeInstancesResponse.DescribeInstances_InstanceItem instanceItem = new DescribeInstancesResponse.DescribeInstances_InstanceItem();
				instanceItem.InstanceId = context.LongValue("DescribeInstances.InstanceItems["+ i +"].InstanceId");
				instanceItem.OrderId = context.LongValue("DescribeInstances.InstanceItems["+ i +"].OrderId");
				instanceItem.SupplierName = context.StringValue("DescribeInstances.InstanceItems["+ i +"].SupplierName");
				instanceItem.ProductCode = context.StringValue("DescribeInstances.InstanceItems["+ i +"].ProductCode");
				instanceItem.ProductSkuCode = context.StringValue("DescribeInstances.InstanceItems["+ i +"].ProductSkuCode");
				instanceItem.ProductName = context.StringValue("DescribeInstances.InstanceItems["+ i +"].ProductName");
				instanceItem.ProductType = context.StringValue("DescribeInstances.InstanceItems["+ i +"].ProductType");
				instanceItem.Status = context.StringValue("DescribeInstances.InstanceItems["+ i +"].Status");
				instanceItem.BeganOn = context.LongValue("DescribeInstances.InstanceItems["+ i +"].BeganOn");
				instanceItem.EndOn = context.LongValue("DescribeInstances.InstanceItems["+ i +"].EndOn");
				instanceItem.CreatedOn = context.LongValue("DescribeInstances.InstanceItems["+ i +"].CreatedOn");
				instanceItem.ExtendJson = context.StringValue("DescribeInstances.InstanceItems["+ i +"].ExtendJson");
				instanceItem.HostJson = context.StringValue("DescribeInstances.InstanceItems["+ i +"].HostJson");
				instanceItem.AppJson = context.StringValue("DescribeInstances.InstanceItems["+ i +"].AppJson");
				instanceItem.ApiJson = context.StringValue("DescribeInstances.InstanceItems["+ i +"].ApiJson");
				instanceItem.ImageJson = context.StringValue("DescribeInstances.InstanceItems["+ i +"].ImageJson");
				instanceItem.IdaasJson = context.StringValue("DescribeInstances.InstanceItems["+ i +"].IdaasJson");

				describeInstancesResponse_instanceItems.Add(instanceItem);
			}
			describeInstancesResponse.InstanceItems = describeInstancesResponse_instanceItems;
        
			return describeInstancesResponse;
        }
    }
}
