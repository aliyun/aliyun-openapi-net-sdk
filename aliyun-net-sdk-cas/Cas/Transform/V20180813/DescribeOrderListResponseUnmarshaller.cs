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
using Aliyun.Acs.cas.Model.V20180813;

namespace Aliyun.Acs.cas.Transform.V20180813
{
    public class DescribeOrderListResponseUnmarshaller
    {
        public static DescribeOrderListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOrderListResponse describeOrderListResponse = new DescribeOrderListResponse();

			describeOrderListResponse.HttpResponse = context.HttpResponse;
			describeOrderListResponse.RequestId = context.StringValue("DescribeOrderList.RequestId");
			describeOrderListResponse.TotalCount = context.IntegerValue("DescribeOrderList.TotalCount");
			describeOrderListResponse.ShowSize = context.IntegerValue("DescribeOrderList.ShowSize");
			describeOrderListResponse.CurrentPage = context.IntegerValue("DescribeOrderList.CurrentPage");

			List<DescribeOrderListResponse.DescribeOrderList_Order> describeOrderListResponse_orderList = new List<DescribeOrderListResponse.DescribeOrderList_Order>();
			for (int i = 0; i < context.Length("DescribeOrderList.OrderList.Length"); i++) {
				DescribeOrderListResponse.DescribeOrderList_Order order = new DescribeOrderListResponse.DescribeOrderList_Order();
				order.Id = context.LongValue("DescribeOrderList.OrderList["+ i +"].Id");
				order.SourceType = context.StringValue("DescribeOrderList.OrderList["+ i +"].SourceType");
				order.CertType = context.StringValue("DescribeOrderList.OrderList["+ i +"].CertType");
				order.InstanceId = context.StringValue("DescribeOrderList.OrderList["+ i +"].InstanceId");
				order.Year = context.LongValue("DescribeOrderList.OrderList["+ i +"].Year");
				order.OrderId = context.LongValue("DescribeOrderList.OrderList["+ i +"].OrderId");
				order.OrderType = context.StringValue("DescribeOrderList.OrderList["+ i +"].OrderType");
				order.BrandName = context.StringValue("DescribeOrderList.OrderList["+ i +"].BrandName");
				order.BuyDate = context.LongValue("DescribeOrderList.OrderList["+ i +"].BuyDate");
				order.StatusCode = context.StringValue("DescribeOrderList.OrderList["+ i +"].StatusCode");
				order.Domain = context.StringValue("DescribeOrderList.OrderList["+ i +"].Domain");
				order.ProductAliasName = context.StringValue("DescribeOrderList.OrderList["+ i +"].ProductAliasName");
				order.DomainCount = context.IntegerValue("DescribeOrderList.OrderList["+ i +"].DomainCount");
				order.WildDomainCount = context.IntegerValue("DescribeOrderList.OrderList["+ i +"].WildDomainCount");
				order.VerifyStatus = context.IntegerValue("DescribeOrderList.OrderList["+ i +"].VerifyStatus");
				order.MaybeIssueDate = context.LongValue("DescribeOrderList.OrderList["+ i +"].MaybeIssueDate");
				order.BeforeDate = context.LongValue("DescribeOrderList.OrderList["+ i +"].BeforeDate");
				order.AfterDate = context.LongValue("DescribeOrderList.OrderList["+ i +"].AfterDate");
				order.ShowCancel = context.BooleanValue("DescribeOrderList.OrderList["+ i +"].ShowCancel");

				describeOrderListResponse_orderList.Add(order);
			}
			describeOrderListResponse.OrderList = describeOrderListResponse_orderList;
        
			return describeOrderListResponse;
        }
    }
}
