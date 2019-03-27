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
    public class FindOrderedListResponseUnmarshaller
    {
        public static FindOrderedListResponse Unmarshall(UnmarshallerContext context)
        {
			FindOrderedListResponse findOrderedListResponse = new FindOrderedListResponse();

			findOrderedListResponse.HttpResponse = context.HttpResponse;
			findOrderedListResponse.Code = context.IntegerValue("FindOrderedList.Code");
			findOrderedListResponse.Message = context.StringValue("FindOrderedList.Message");
			findOrderedListResponse.RequestId = context.StringValue("FindOrderedList.RequestId");

			FindOrderedListResponse.FindOrderedList_Data data = new FindOrderedListResponse.FindOrderedList_Data();
			data.CurrentPage = context.IntegerValue("FindOrderedList.Data.CurrentPage");
			data.PageNumber = context.IntegerValue("FindOrderedList.Data.PageNumber");

			List<FindOrderedListResponse.FindOrderedList_Data.FindOrderedList_Order> data_orderList = new List<FindOrderedListResponse.FindOrderedList_Data.FindOrderedList_Order>();
			for (int i = 0; i < context.Length("FindOrderedList.Data.OrderList.Length"); i++) {
				FindOrderedListResponse.FindOrderedList_Data.FindOrderedList_Order order = new FindOrderedListResponse.FindOrderedList_Data.FindOrderedList_Order();
				order.Alias = context.StringValue("FindOrderedList.Data.OrderList["+ i +"].Alias");
				order.ProjectName = context.StringValue("FindOrderedList.Data.OrderList["+ i +"].ProjectName");
				order.ServiceName = context.StringValue("FindOrderedList.Data.OrderList["+ i +"].ServiceName");
				order.ServiceVersion = context.StringValue("FindOrderedList.Data.OrderList["+ i +"].ServiceVersion");
				order.OrderStatus = context.IntegerValue("FindOrderedList.Data.OrderList["+ i +"].OrderStatus");
				order.AliveOrderCount = context.IntegerValue("FindOrderedList.Data.OrderList["+ i +"].AliveOrderCount");
				order.GmtCreate = context.LongValue("FindOrderedList.Data.OrderList["+ i +"].GmtCreate");
				order.MaxRT = context.IntegerValue("FindOrderedList.Data.OrderList["+ i +"].MaxRT");
				order.MinRT = context.IntegerValue("FindOrderedList.Data.OrderList["+ i +"].MinRT");
				order.ServiceId = context.StringValue("FindOrderedList.Data.OrderList["+ i +"].ServiceId");
				order.ServiceStatus = context.IntegerValue("FindOrderedList.Data.OrderList["+ i +"].ServiceStatus");

				FindOrderedListResponse.FindOrderedList_Data.FindOrderedList_Order.FindOrderedList_Total total = new FindOrderedListResponse.FindOrderedList_Data.FindOrderedList_Order.FindOrderedList_Total();
				total.ErrorNum = context.IntegerValue("FindOrderedList.Data.OrderList["+ i +"].Total.ErrorNum");
				total.Total = context.IntegerValue("FindOrderedList.Data.OrderList["+ i +"].Total.Total");
				order.Total = total;

				List<FindOrderedListResponse.FindOrderedList_Data.FindOrderedList_Order.FindOrderedList_ErrorTypeCatagory> order_errorTypeCatagoryList = new List<FindOrderedListResponse.FindOrderedList_Data.FindOrderedList_Order.FindOrderedList_ErrorTypeCatagory>();
				for (int j = 0; j < context.Length("FindOrderedList.Data.OrderList["+ i +"].ErrorTypeCatagoryList.Length"); j++) {
					FindOrderedListResponse.FindOrderedList_Data.FindOrderedList_Order.FindOrderedList_ErrorTypeCatagory errorTypeCatagory = new FindOrderedListResponse.FindOrderedList_Data.FindOrderedList_Order.FindOrderedList_ErrorTypeCatagory();
					errorTypeCatagory.Name = context.StringValue("FindOrderedList.Data.OrderList["+ i +"].ErrorTypeCatagoryList["+ j +"].Name");
					errorTypeCatagory.Total = context.LongValue("FindOrderedList.Data.OrderList["+ i +"].ErrorTypeCatagoryList["+ j +"].Total");
					errorTypeCatagory.ErrorNum = context.LongValue("FindOrderedList.Data.OrderList["+ i +"].ErrorTypeCatagoryList["+ j +"].ErrorNum");

					order_errorTypeCatagoryList.Add(errorTypeCatagory);
				}
				order.ErrorTypeCatagoryList = order_errorTypeCatagoryList;

				List<FindOrderedListResponse.FindOrderedList_Data.FindOrderedList_Order.FindOrderedList_Order1> order_orders = new List<FindOrderedListResponse.FindOrderedList_Data.FindOrderedList_Order.FindOrderedList_Order1>();
				for (int j = 0; j < context.Length("FindOrderedList.Data.OrderList["+ i +"].Orders.Length"); j++) {
					FindOrderedListResponse.FindOrderedList_Data.FindOrderedList_Order.FindOrderedList_Order1 order1 = new FindOrderedListResponse.FindOrderedList_Data.FindOrderedList_Order.FindOrderedList_Order1();
					order1.Alias = context.StringValue("FindOrderedList.Data.OrderList["+ i +"].Orders["+ j +"].Alias");
					order1.ApproveComments = context.StringValue("FindOrderedList.Data.OrderList["+ i +"].Orders["+ j +"].ApproveComments");
					order1.CsbId = context.LongValue("FindOrderedList.Data.OrderList["+ i +"].Orders["+ j +"].CsbId");
					order1.GmtCreate = context.LongValue("FindOrderedList.Data.OrderList["+ i +"].Orders["+ j +"].GmtCreate");
					order1.GmtModified = context.LongValue("FindOrderedList.Data.OrderList["+ i +"].Orders["+ j +"].GmtModified");
					order1.GroupName = context.StringValue("FindOrderedList.Data.OrderList["+ i +"].Orders["+ j +"].GroupName");
					order1.Id = context.LongValue("FindOrderedList.Data.OrderList["+ i +"].Orders["+ j +"].Id");
					order1.ProjectName = context.StringValue("FindOrderedList.Data.OrderList["+ i +"].Orders["+ j +"].ProjectName");
					order1.ServiceId = context.LongValue("FindOrderedList.Data.OrderList["+ i +"].Orders["+ j +"].ServiceId");
					order1.ServiceName = context.StringValue("FindOrderedList.Data.OrderList["+ i +"].Orders["+ j +"].ServiceName");
					order1.ServiceStatus = context.IntegerValue("FindOrderedList.Data.OrderList["+ i +"].Orders["+ j +"].ServiceStatus");
					order1.ServiceVersion = context.StringValue("FindOrderedList.Data.OrderList["+ i +"].Orders["+ j +"].ServiceVersion");
					order1.StatisticName = context.StringValue("FindOrderedList.Data.OrderList["+ i +"].Orders["+ j +"].StatisticName");
					order1.Status = context.IntegerValue("FindOrderedList.Data.OrderList["+ i +"].Orders["+ j +"].Status");
					order1.UserId = context.StringValue("FindOrderedList.Data.OrderList["+ i +"].Orders["+ j +"].UserId");

					FindOrderedListResponse.FindOrderedList_Data.FindOrderedList_Order.FindOrderedList_Order1.FindOrderedList_SlaInfo slaInfo = new FindOrderedListResponse.FindOrderedList_Data.FindOrderedList_Order.FindOrderedList_Order1.FindOrderedList_SlaInfo();
					slaInfo.Qph = context.StringValue("FindOrderedList.Data.OrderList["+ i +"].Orders["+ j +"].SlaInfo.Qph");
					slaInfo.Qps = context.StringValue("FindOrderedList.Data.OrderList["+ i +"].Orders["+ j +"].SlaInfo.Qps");
					order1.SlaInfo = slaInfo;

					FindOrderedListResponse.FindOrderedList_Data.FindOrderedList_Order.FindOrderedList_Order1.FindOrderedList_Total2 total2 = new FindOrderedListResponse.FindOrderedList_Data.FindOrderedList_Order.FindOrderedList_Order1.FindOrderedList_Total2();
					total2.ErrorNum = context.IntegerValue("FindOrderedList.Data.OrderList["+ i +"].Orders["+ j +"].Total.ErrorNum");
					total2.Total = context.IntegerValue("FindOrderedList.Data.OrderList["+ i +"].Orders["+ j +"].Total.Total");
					order1.Total2 = total2;

					order_orders.Add(order1);
				}
				order.Orders = order_orders;

				data_orderList.Add(order);
			}
			data.OrderList = data_orderList;
			findOrderedListResponse.Data = data;
        
			return findOrderedListResponse;
        }
    }
}
