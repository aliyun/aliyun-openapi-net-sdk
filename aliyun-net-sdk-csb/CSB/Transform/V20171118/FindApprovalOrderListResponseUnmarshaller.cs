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
using Aliyun.Acs.CSB.Model.V20171118;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CSB.Transform.V20171118
{
    public class FindApprovalOrderListResponseUnmarshaller
    {
        public static FindApprovalOrderListResponse Unmarshall(UnmarshallerContext context)
        {
			FindApprovalOrderListResponse findApprovalOrderListResponse = new FindApprovalOrderListResponse();

			findApprovalOrderListResponse.HttpResponse = context.HttpResponse;
			findApprovalOrderListResponse.Code = context.IntegerValue("FindApprovalOrderList.Code");
			findApprovalOrderListResponse.Message = context.StringValue("FindApprovalOrderList.Message");
			findApprovalOrderListResponse.RequestId = context.StringValue("FindApprovalOrderList.RequestId");

			FindApprovalOrderListResponse.FindApprovalOrderList_Data data = new FindApprovalOrderListResponse.FindApprovalOrderList_Data();
			data.CurrentPage = context.IntegerValue("FindApprovalOrderList.Data.CurrentPage");
			data.PageNumber = context.IntegerValue("FindApprovalOrderList.Data.PageNumber");

			List<FindApprovalOrderListResponse.FindApprovalOrderList_Data.FindApprovalOrderList_Order> data_orderList = new List<FindApprovalOrderListResponse.FindApprovalOrderList_Data.FindApprovalOrderList_Order>();
			for (int i = 0; i < context.Length("FindApprovalOrderList.Data.OrderList.Length"); i++) {
				FindApprovalOrderListResponse.FindApprovalOrderList_Data.FindApprovalOrderList_Order order = new FindApprovalOrderListResponse.FindApprovalOrderList_Data.FindApprovalOrderList_Order();
				order.Alias = context.StringValue("FindApprovalOrderList.Data.OrderList["+ i +"].Alias");
				order.CredentialGroupId = context.LongValue("FindApprovalOrderList.Data.OrderList["+ i +"].CredentialGroupId");
				order.CsbId = context.LongValue("FindApprovalOrderList.Data.OrderList["+ i +"].CsbId");
				order.GmtCreate = context.LongValue("FindApprovalOrderList.Data.OrderList["+ i +"].GmtCreate");
				order.GmtModified = context.LongValue("FindApprovalOrderList.Data.OrderList["+ i +"].GmtModified");
				order.GroupName = context.StringValue("FindApprovalOrderList.Data.OrderList["+ i +"].GroupName");
				order.Id = context.LongValue("FindApprovalOrderList.Data.OrderList["+ i +"].Id");
				order.ProjectName = context.StringValue("FindApprovalOrderList.Data.OrderList["+ i +"].ProjectName");
				order.ServiceId = context.LongValue("FindApprovalOrderList.Data.OrderList["+ i +"].ServiceId");
				order.ServiceName = context.StringValue("FindApprovalOrderList.Data.OrderList["+ i +"].ServiceName");
				order.ServiceStatus = context.IntegerValue("FindApprovalOrderList.Data.OrderList["+ i +"].ServiceStatus");
				order.ServiceVersion = context.StringValue("FindApprovalOrderList.Data.OrderList["+ i +"].ServiceVersion");
				order.StatisticName = context.StringValue("FindApprovalOrderList.Data.OrderList["+ i +"].StatisticName");
				order.Status = context.IntegerValue("FindApprovalOrderList.Data.OrderList["+ i +"].Status");
				order.StrictWhiteListJson = context.StringValue("FindApprovalOrderList.Data.OrderList["+ i +"].StrictWhiteListJson");
				order.UserId = context.StringValue("FindApprovalOrderList.Data.OrderList["+ i +"].UserId");
				order.UserName = context.StringValue("FindApprovalOrderList.Data.OrderList["+ i +"].UserName");

				FindApprovalOrderListResponse.FindApprovalOrderList_Data.FindApprovalOrderList_Order.FindApprovalOrderList_SlaInfo slaInfo = new FindApprovalOrderListResponse.FindApprovalOrderList_Data.FindApprovalOrderList_Order.FindApprovalOrderList_SlaInfo();
				slaInfo.Qph = context.IntegerValue("FindApprovalOrderList.Data.OrderList["+ i +"].SlaInfo.Qph");
				slaInfo.Qps = context.IntegerValue("FindApprovalOrderList.Data.OrderList["+ i +"].SlaInfo.Qps");
				order.SlaInfo = slaInfo;

				FindApprovalOrderListResponse.FindApprovalOrderList_Data.FindApprovalOrderList_Order.FindApprovalOrderList_Total total = new FindApprovalOrderListResponse.FindApprovalOrderList_Data.FindApprovalOrderList_Order.FindApprovalOrderList_Total();
				total.ErrorNum = context.IntegerValue("FindApprovalOrderList.Data.OrderList["+ i +"].Total.ErrorNum");
				total.Total = context.IntegerValue("FindApprovalOrderList.Data.OrderList["+ i +"].Total.Total");
				order.Total = total;

				data_orderList.Add(order);
			}
			data.OrderList = data_orderList;
			findApprovalOrderListResponse.Data = data;
        
			return findApprovalOrderListResponse;
        }
    }
}