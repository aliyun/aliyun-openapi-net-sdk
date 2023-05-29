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
        public static DescribeInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstancesResponse describeInstancesResponse = new DescribeInstancesResponse();

			describeInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeInstancesResponse.RequestId = _ctx.StringValue("DescribeInstances.RequestId");
			describeInstancesResponse.PageNumber = _ctx.IntegerValue("DescribeInstances.PageNumber");
			describeInstancesResponse.PageSize = _ctx.IntegerValue("DescribeInstances.PageSize");
			describeInstancesResponse.TotalCount = _ctx.IntegerValue("DescribeInstances.TotalCount");

			List<DescribeInstancesResponse.DescribeInstances_InstanceItem> describeInstancesResponse_instanceItems = new List<DescribeInstancesResponse.DescribeInstances_InstanceItem>();
			for (int i = 0; i < _ctx.Length("DescribeInstances.InstanceItems.Length"); i++) {
				DescribeInstancesResponse.DescribeInstances_InstanceItem instanceItem = new DescribeInstancesResponse.DescribeInstances_InstanceItem();
				instanceItem.Status = _ctx.StringValue("DescribeInstances.InstanceItems["+ i +"].Status");
				instanceItem.AppJson = _ctx.StringValue("DescribeInstances.InstanceItems["+ i +"].AppJson");
				instanceItem.ApiJson = _ctx.StringValue("DescribeInstances.InstanceItems["+ i +"].ApiJson");
				instanceItem.ProductName = _ctx.StringValue("DescribeInstances.InstanceItems["+ i +"].ProductName");
				instanceItem.ImageJson = _ctx.StringValue("DescribeInstances.InstanceItems["+ i +"].ImageJson");
				instanceItem.InstanceId = _ctx.LongValue("DescribeInstances.InstanceItems["+ i +"].InstanceId");
				instanceItem.ExtendJson = _ctx.StringValue("DescribeInstances.InstanceItems["+ i +"].ExtendJson");
				instanceItem.BeganOn = _ctx.LongValue("DescribeInstances.InstanceItems["+ i +"].BeganOn");
				instanceItem.ProductType = _ctx.StringValue("DescribeInstances.InstanceItems["+ i +"].ProductType");
				instanceItem.HostJson = _ctx.StringValue("DescribeInstances.InstanceItems["+ i +"].HostJson");
				instanceItem.ProductSkuCode = _ctx.StringValue("DescribeInstances.InstanceItems["+ i +"].ProductSkuCode");
				instanceItem.CreatedOn = _ctx.LongValue("DescribeInstances.InstanceItems["+ i +"].CreatedOn");
				instanceItem.IdaasJson = _ctx.StringValue("DescribeInstances.InstanceItems["+ i +"].IdaasJson");
				instanceItem.EndOn = _ctx.LongValue("DescribeInstances.InstanceItems["+ i +"].EndOn");
				instanceItem.OrderId = _ctx.LongValue("DescribeInstances.InstanceItems["+ i +"].OrderId");
				instanceItem.ProductCode = _ctx.StringValue("DescribeInstances.InstanceItems["+ i +"].ProductCode");
				instanceItem.SupplierName = _ctx.StringValue("DescribeInstances.InstanceItems["+ i +"].SupplierName");

				describeInstancesResponse_instanceItems.Add(instanceItem);
			}
			describeInstancesResponse.InstanceItems = describeInstancesResponse_instanceItems;
        
			return describeInstancesResponse;
        }
    }
}
