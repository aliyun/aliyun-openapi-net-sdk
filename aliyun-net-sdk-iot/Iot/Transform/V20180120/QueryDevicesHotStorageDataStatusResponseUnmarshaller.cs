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
    public class QueryDevicesHotStorageDataStatusResponseUnmarshaller
    {
        public static QueryDevicesHotStorageDataStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDevicesHotStorageDataStatusResponse queryDevicesHotStorageDataStatusResponse = new QueryDevicesHotStorageDataStatusResponse();

			queryDevicesHotStorageDataStatusResponse.HttpResponse = _ctx.HttpResponse;
			queryDevicesHotStorageDataStatusResponse.RequestId = _ctx.StringValue("QueryDevicesHotStorageDataStatus.RequestId");
			queryDevicesHotStorageDataStatusResponse.Success = _ctx.BooleanValue("QueryDevicesHotStorageDataStatus.Success");
			queryDevicesHotStorageDataStatusResponse.Code = _ctx.StringValue("QueryDevicesHotStorageDataStatus.Code");
			queryDevicesHotStorageDataStatusResponse.ErrorMessage = _ctx.StringValue("QueryDevicesHotStorageDataStatus.ErrorMessage");

			QueryDevicesHotStorageDataStatusResponse.QueryDevicesHotStorageDataStatus_Data data = new QueryDevicesHotStorageDataStatusResponse.QueryDevicesHotStorageDataStatus_Data();
			data.NextValid = _ctx.BooleanValue("QueryDevicesHotStorageDataStatus.Data.NextValid");
			data.NextPageToken = _ctx.StringValue("QueryDevicesHotStorageDataStatus.Data.NextPageToken");

			List<QueryDevicesHotStorageDataStatusResponse.QueryDevicesHotStorageDataStatus_Data.QueryDevicesHotStorageDataStatus_PropertyStatusDataInfo> data_list = new List<QueryDevicesHotStorageDataStatusResponse.QueryDevicesHotStorageDataStatus_Data.QueryDevicesHotStorageDataStatus_PropertyStatusDataInfo>();
			for (int i = 0; i < _ctx.Length("QueryDevicesHotStorageDataStatus.Data.List.Length"); i++) {
				QueryDevicesHotStorageDataStatusResponse.QueryDevicesHotStorageDataStatus_Data.QueryDevicesHotStorageDataStatus_PropertyStatusDataInfo propertyStatusDataInfo = new QueryDevicesHotStorageDataStatusResponse.QueryDevicesHotStorageDataStatus_Data.QueryDevicesHotStorageDataStatus_PropertyStatusDataInfo();
				propertyStatusDataInfo.Identifier = _ctx.StringValue("QueryDevicesHotStorageDataStatus.Data.List["+ i +"].Identifier");
				propertyStatusDataInfo._Value = _ctx.StringValue("QueryDevicesHotStorageDataStatus.Data.List["+ i +"].Value");
				propertyStatusDataInfo.Time = _ctx.LongValue("QueryDevicesHotStorageDataStatus.Data.List["+ i +"].Time");

				data_list.Add(propertyStatusDataInfo);
			}
			data.List = data_list;
			queryDevicesHotStorageDataStatusResponse.Data = data;
        
			return queryDevicesHotStorageDataStatusResponse;
        }
    }
}
