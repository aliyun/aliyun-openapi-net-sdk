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
    public class QueryDeviceOriginalPropertyStatusResponseUnmarshaller
    {
        public static QueryDeviceOriginalPropertyStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDeviceOriginalPropertyStatusResponse queryDeviceOriginalPropertyStatusResponse = new QueryDeviceOriginalPropertyStatusResponse();

			queryDeviceOriginalPropertyStatusResponse.HttpResponse = _ctx.HttpResponse;
			queryDeviceOriginalPropertyStatusResponse.RequestId = _ctx.StringValue("QueryDeviceOriginalPropertyStatus.RequestId");
			queryDeviceOriginalPropertyStatusResponse.Success = _ctx.BooleanValue("QueryDeviceOriginalPropertyStatus.Success");
			queryDeviceOriginalPropertyStatusResponse.Code = _ctx.StringValue("QueryDeviceOriginalPropertyStatus.Code");
			queryDeviceOriginalPropertyStatusResponse.ErrorMessage = _ctx.StringValue("QueryDeviceOriginalPropertyStatus.ErrorMessage");

			QueryDeviceOriginalPropertyStatusResponse.QueryDeviceOriginalPropertyStatus_Data data = new QueryDeviceOriginalPropertyStatusResponse.QueryDeviceOriginalPropertyStatus_Data();
			data.NextValid = _ctx.BooleanValue("QueryDeviceOriginalPropertyStatus.Data.NextValid");
			data.NextPageToken = _ctx.StringValue("QueryDeviceOriginalPropertyStatus.Data.NextPageToken");

			List<QueryDeviceOriginalPropertyStatusResponse.QueryDeviceOriginalPropertyStatus_Data.QueryDeviceOriginalPropertyStatus_PropertyStatusDataInfo> data_list = new List<QueryDeviceOriginalPropertyStatusResponse.QueryDeviceOriginalPropertyStatus_Data.QueryDeviceOriginalPropertyStatus_PropertyStatusDataInfo>();
			for (int i = 0; i < _ctx.Length("QueryDeviceOriginalPropertyStatus.Data.List.Length"); i++) {
				QueryDeviceOriginalPropertyStatusResponse.QueryDeviceOriginalPropertyStatus_Data.QueryDeviceOriginalPropertyStatus_PropertyStatusDataInfo propertyStatusDataInfo = new QueryDeviceOriginalPropertyStatusResponse.QueryDeviceOriginalPropertyStatus_Data.QueryDeviceOriginalPropertyStatus_PropertyStatusDataInfo();
				propertyStatusDataInfo.Identifier = _ctx.StringValue("QueryDeviceOriginalPropertyStatus.Data.List["+ i +"].Identifier");
				propertyStatusDataInfo._Value = _ctx.StringValue("QueryDeviceOriginalPropertyStatus.Data.List["+ i +"].Value");
				propertyStatusDataInfo.Time = _ctx.LongValue("QueryDeviceOriginalPropertyStatus.Data.List["+ i +"].Time");

				data_list.Add(propertyStatusDataInfo);
			}
			data.List = data_list;
			queryDeviceOriginalPropertyStatusResponse.Data = data;
        
			return queryDeviceOriginalPropertyStatusResponse;
        }
    }
}
