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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class ListRecentChangeOrderResponseUnmarshaller
    {
        public static ListRecentChangeOrderResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRecentChangeOrderResponse listRecentChangeOrderResponse = new ListRecentChangeOrderResponse();

			listRecentChangeOrderResponse.HttpResponse = _ctx.HttpResponse;
			listRecentChangeOrderResponse.Code = _ctx.IntegerValue("ListRecentChangeOrder.Code");
			listRecentChangeOrderResponse.Message = _ctx.StringValue("ListRecentChangeOrder.Message");
			listRecentChangeOrderResponse.RequestId = _ctx.StringValue("ListRecentChangeOrder.RequestId");

			List<ListRecentChangeOrderResponse.ListRecentChangeOrder_ChangeOrder> listRecentChangeOrderResponse_changeOrderList = new List<ListRecentChangeOrderResponse.ListRecentChangeOrder_ChangeOrder>();
			for (int i = 0; i < _ctx.Length("ListRecentChangeOrder.ChangeOrderList.Length"); i++) {
				ListRecentChangeOrderResponse.ListRecentChangeOrder_ChangeOrder changeOrder = new ListRecentChangeOrderResponse.ListRecentChangeOrder_ChangeOrder();
				changeOrder.ChangeOrderId = _ctx.StringValue("ListRecentChangeOrder.ChangeOrderList["+ i +"].ChangeOrderId");
				changeOrder.UserId = _ctx.StringValue("ListRecentChangeOrder.ChangeOrderList["+ i +"].UserId");
				changeOrder.BatchType = _ctx.StringValue("ListRecentChangeOrder.ChangeOrderList["+ i +"].BatchType");
				changeOrder.BatchCount = _ctx.IntegerValue("ListRecentChangeOrder.ChangeOrderList["+ i +"].BatchCount");
				changeOrder.AppId = _ctx.StringValue("ListRecentChangeOrder.ChangeOrderList["+ i +"].AppId");
				changeOrder.GroupId = _ctx.StringValue("ListRecentChangeOrder.ChangeOrderList["+ i +"].GroupId");
				changeOrder.Status = _ctx.IntegerValue("ListRecentChangeOrder.ChangeOrderList["+ i +"].Status");
				changeOrder.CreateTime = _ctx.StringValue("ListRecentChangeOrder.ChangeOrderList["+ i +"].CreateTime");
				changeOrder.FinishTime = _ctx.StringValue("ListRecentChangeOrder.ChangeOrderList["+ i +"].FinishTime");
				changeOrder.CoType = _ctx.StringValue("ListRecentChangeOrder.ChangeOrderList["+ i +"].CoType");
				changeOrder.CreateUserId = _ctx.StringValue("ListRecentChangeOrder.ChangeOrderList["+ i +"].CreateUserId");
				changeOrder.CoTypeCode = _ctx.StringValue("ListRecentChangeOrder.ChangeOrderList["+ i +"].CoTypeCode");
				changeOrder.Source = _ctx.StringValue("ListRecentChangeOrder.ChangeOrderList["+ i +"].Source");
				changeOrder.ChangeOrderDescription = _ctx.StringValue("ListRecentChangeOrder.ChangeOrderList["+ i +"].ChangeOrderDescription");

				listRecentChangeOrderResponse_changeOrderList.Add(changeOrder);
			}
			listRecentChangeOrderResponse.ChangeOrderList = listRecentChangeOrderResponse_changeOrderList;
        
			return listRecentChangeOrderResponse;
        }
    }
}
