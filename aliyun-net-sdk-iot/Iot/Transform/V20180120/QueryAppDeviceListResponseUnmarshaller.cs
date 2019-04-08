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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QueryAppDeviceListResponseUnmarshaller
    {
        public static QueryAppDeviceListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryAppDeviceListResponse queryAppDeviceListResponse = new QueryAppDeviceListResponse();

			queryAppDeviceListResponse.HttpResponse = context.HttpResponse;
			queryAppDeviceListResponse.RequestId = context.StringValue("QueryAppDeviceList.RequestId");
			queryAppDeviceListResponse.Success = context.BooleanValue("QueryAppDeviceList.Success");
			queryAppDeviceListResponse.ErrorMessage = context.StringValue("QueryAppDeviceList.ErrorMessage");
			queryAppDeviceListResponse.Code = context.StringValue("QueryAppDeviceList.Code");
			queryAppDeviceListResponse.Page = context.IntegerValue("QueryAppDeviceList.Page");
			queryAppDeviceListResponse.PageSize = context.IntegerValue("QueryAppDeviceList.PageSize");
			queryAppDeviceListResponse.PageCount = context.IntegerValue("QueryAppDeviceList.PageCount");
			queryAppDeviceListResponse.Total = context.IntegerValue("QueryAppDeviceList.Total");

			List<QueryAppDeviceListResponse.QueryAppDeviceList_DataItem> queryAppDeviceListResponse_data = new List<QueryAppDeviceListResponse.QueryAppDeviceList_DataItem>();
			for (int i = 0; i < context.Length("QueryAppDeviceList.Data.Length"); i++) {
				QueryAppDeviceListResponse.QueryAppDeviceList_DataItem dataItem = new QueryAppDeviceListResponse.QueryAppDeviceList_DataItem();
				dataItem.ProductName = context.StringValue("QueryAppDeviceList.Data["+ i +"].ProductName");
				dataItem.ProductKey = context.StringValue("QueryAppDeviceList.Data["+ i +"].ProductKey");
				dataItem.DeviceName = context.StringValue("QueryAppDeviceList.Data["+ i +"].DeviceName");
				dataItem.NodeType = context.IntegerValue("QueryAppDeviceList.Data["+ i +"].NodeType");
				dataItem.Status = context.StringValue("QueryAppDeviceList.Data["+ i +"].Status");
				dataItem.ActiveTime = context.StringValue("QueryAppDeviceList.Data["+ i +"].ActiveTime");
				dataItem.LastOnlineTime = context.StringValue("QueryAppDeviceList.Data["+ i +"].LastOnlineTime");
				dataItem.CreateTime = context.StringValue("QueryAppDeviceList.Data["+ i +"].CreateTime");
				dataItem.ChildDeviceCount = context.LongValue("QueryAppDeviceList.Data["+ i +"].ChildDeviceCount");
				dataItem.UtcActiveTime = context.StringValue("QueryAppDeviceList.Data["+ i +"].UtcActiveTime");
				dataItem.UtcLastOnlineTime = context.StringValue("QueryAppDeviceList.Data["+ i +"].UtcLastOnlineTime");
				dataItem.UtcCreateTime = context.StringValue("QueryAppDeviceList.Data["+ i +"].UtcCreateTime");

				queryAppDeviceListResponse_data.Add(dataItem);
			}
			queryAppDeviceListResponse.Data = queryAppDeviceListResponse_data;
        
			return queryAppDeviceListResponse;
        }
    }
}
