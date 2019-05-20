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
using Aliyun.Acs.Trademark.Model.V20180724;

namespace Aliyun.Acs.Trademark.Transform.V20180724
{
    public class ListNotaryOrdersResponseUnmarshaller
    {
        public static ListNotaryOrdersResponse Unmarshall(UnmarshallerContext context)
        {
			ListNotaryOrdersResponse listNotaryOrdersResponse = new ListNotaryOrdersResponse();

			listNotaryOrdersResponse.HttpResponse = context.HttpResponse;
			listNotaryOrdersResponse.RequestId = context.StringValue("ListNotaryOrders.RequestId");
			listNotaryOrdersResponse.TotalItemNum = context.IntegerValue("ListNotaryOrders.TotalItemNum");
			listNotaryOrdersResponse.CurrentPageNum = context.IntegerValue("ListNotaryOrders.CurrentPageNum");
			listNotaryOrdersResponse.PageSize = context.IntegerValue("ListNotaryOrders.PageSize");
			listNotaryOrdersResponse.TotalPageNum = context.IntegerValue("ListNotaryOrders.TotalPageNum");
			listNotaryOrdersResponse.PrePage = context.BooleanValue("ListNotaryOrders.PrePage");
			listNotaryOrdersResponse.NextPage = context.BooleanValue("ListNotaryOrders.NextPage");
			listNotaryOrdersResponse.Success = context.BooleanValue("ListNotaryOrders.Success");
			listNotaryOrdersResponse.ErrorMsg = context.StringValue("ListNotaryOrders.ErrorMsg");
			listNotaryOrdersResponse.ErrorCode = context.StringValue("ListNotaryOrders.ErrorCode");

			List<ListNotaryOrdersResponse.ListNotaryOrders_NotaryOrder> listNotaryOrdersResponse_data = new List<ListNotaryOrdersResponse.ListNotaryOrders_NotaryOrder>();
			for (int i = 0; i < context.Length("ListNotaryOrders.Data.Length"); i++) {
				ListNotaryOrdersResponse.ListNotaryOrders_NotaryOrder notaryOrder = new ListNotaryOrdersResponse.ListNotaryOrders_NotaryOrder();
				notaryOrder.NotaryOrderId = context.LongValue("ListNotaryOrders.Data["+ i +"].NotaryOrderId");
				notaryOrder.AliyunOrderId = context.StringValue("ListNotaryOrders.Data["+ i +"].AliyunOrderId");
				notaryOrder.TmRegisterNo = context.StringValue("ListNotaryOrders.Data["+ i +"].TmRegisterNo");
				notaryOrder.TmName = context.StringValue("ListNotaryOrders.Data["+ i +"].TmName");
				notaryOrder.TmImage = context.StringValue("ListNotaryOrders.Data["+ i +"].TmImage");
				notaryOrder.TmClassification = context.StringValue("ListNotaryOrders.Data["+ i +"].TmClassification");
				notaryOrder.OrderPrice = context.FloatValue("ListNotaryOrders.Data["+ i +"].OrderPrice");
				notaryOrder.NotaryStatus = context.IntegerValue("ListNotaryOrders.Data["+ i +"].NotaryStatus");
				notaryOrder.OrderDate = context.LongValue("ListNotaryOrders.Data["+ i +"].OrderDate");
				notaryOrder.GmtModified = context.LongValue("ListNotaryOrders.Data["+ i +"].GmtModified");
				notaryOrder.NotaryCertificate = context.StringValue("ListNotaryOrders.Data["+ i +"].NotaryCertificate");
				notaryOrder.BizId = context.StringValue("ListNotaryOrders.Data["+ i +"].BizId");
				notaryOrder.NotaryType = context.IntegerValue("ListNotaryOrders.Data["+ i +"].NotaryType");
				notaryOrder.NotaryPlatformName = context.StringValue("ListNotaryOrders.Data["+ i +"].NotaryPlatformName");
				notaryOrder.ApplyPostStatus = context.StringValue("ListNotaryOrders.Data["+ i +"].ApplyPostStatus");

				listNotaryOrdersResponse_data.Add(notaryOrder);
			}
			listNotaryOrdersResponse.Data = listNotaryOrdersResponse_data;
        
			return listNotaryOrdersResponse;
        }
    }
}
