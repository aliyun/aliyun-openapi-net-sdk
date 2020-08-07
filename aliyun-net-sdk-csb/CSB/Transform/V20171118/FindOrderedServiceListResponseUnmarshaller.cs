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
using Aliyun.Acs.CSB.Model.V20171118;

namespace Aliyun.Acs.CSB.Transform.V20171118
{
    public class FindOrderedServiceListResponseUnmarshaller
    {
        public static FindOrderedServiceListResponse Unmarshall(UnmarshallerContext context)
        {
			FindOrderedServiceListResponse findOrderedServiceListResponse = new FindOrderedServiceListResponse();

			findOrderedServiceListResponse.HttpResponse = context.HttpResponse;
			findOrderedServiceListResponse.Code = context.IntegerValue("FindOrderedServiceList.Code");
			findOrderedServiceListResponse.Message = context.StringValue("FindOrderedServiceList.Message");
			findOrderedServiceListResponse.RequestId = context.StringValue("FindOrderedServiceList.RequestId");

			FindOrderedServiceListResponse.FindOrderedServiceList_Data data = new FindOrderedServiceListResponse.FindOrderedServiceList_Data();
			data.CurrentPage = context.IntegerValue("FindOrderedServiceList.Data.CurrentPage");
			data.PageNumber = context.IntegerValue("FindOrderedServiceList.Data.PageNumber");
			data.Total = context.LongValue("FindOrderedServiceList.Data.Total");

			List<FindOrderedServiceListResponse.FindOrderedServiceList_Data.FindOrderedServiceList_Order> data_orderList = new List<FindOrderedServiceListResponse.FindOrderedServiceList_Data.FindOrderedServiceList_Order>();
			for (int i = 0; i < context.Length("FindOrderedServiceList.Data.OrderList.Length"); i++) {
				FindOrderedServiceListResponse.FindOrderedServiceList_Data.FindOrderedServiceList_Order order = new FindOrderedServiceListResponse.FindOrderedServiceList_Data.FindOrderedServiceList_Order();
				order.ServiceName = context.StringValue("FindOrderedServiceList.Data.OrderList["+ i +"].ServiceName");
				order.ServiceVersion = context.StringValue("FindOrderedServiceList.Data.OrderList["+ i +"].ServiceVersion");
				order.OrderStatus = context.IntegerValue("FindOrderedServiceList.Data.OrderList["+ i +"].OrderStatus");
				order.GmtCreate = context.LongValue("FindOrderedServiceList.Data.OrderList["+ i +"].GmtCreate");
				order.ServiceId = context.StringValue("FindOrderedServiceList.Data.OrderList["+ i +"].ServiceId");
				order.ServiceStatus = context.IntegerValue("FindOrderedServiceList.Data.OrderList["+ i +"].ServiceStatus");
				order.CredentialGroupId = context.LongValue("FindOrderedServiceList.Data.OrderList["+ i +"].CredentialGroupId");
				order.GmtModified = context.LongValue("FindOrderedServiceList.Data.OrderList["+ i +"].GmtModified");
				order.ProjectName = context.StringValue("FindOrderedServiceList.Data.OrderList["+ i +"].ProjectName");
				order.Id = context.LongValue("FindOrderedServiceList.Data.OrderList["+ i +"].Id");
				order.CredentialGroupName = context.StringValue("FindOrderedServiceList.Data.OrderList["+ i +"].CredentialGroupName");

				FindOrderedServiceListResponse.FindOrderedServiceList_Data.FindOrderedServiceList_Order.FindOrderedServiceList_SlaInfo slaInfo = new FindOrderedServiceListResponse.FindOrderedServiceList_Data.FindOrderedServiceList_Order.FindOrderedServiceList_SlaInfo();
				slaInfo.Qps = context.LongValue("FindOrderedServiceList.Data.OrderList["+ i +"].SlaInfo.Qps");
				slaInfo.Qph = context.LongValue("FindOrderedServiceList.Data.OrderList["+ i +"].SlaInfo.Qph");
				order.SlaInfo = slaInfo;

				data_orderList.Add(order);
			}
			data.OrderList = data_orderList;
			findOrderedServiceListResponse.Data = data;
        
			return findOrderedServiceListResponse;
        }
    }
}
