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
using Aliyun.Acs.Linkvisual.Model.V20180120;

namespace Aliyun.Acs.Linkvisual.Transform.V20180120
{
    public class QueryDeviceRecordLifeCycleResponseUnmarshaller
    {
        public static QueryDeviceRecordLifeCycleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDeviceRecordLifeCycleResponse queryDeviceRecordLifeCycleResponse = new QueryDeviceRecordLifeCycleResponse();

			queryDeviceRecordLifeCycleResponse.HttpResponse = _ctx.HttpResponse;
			queryDeviceRecordLifeCycleResponse.Code = _ctx.IntegerValue("QueryDeviceRecordLifeCycle.Code");
			queryDeviceRecordLifeCycleResponse.RequestId = _ctx.StringValue("QueryDeviceRecordLifeCycle.RequestId");
			queryDeviceRecordLifeCycleResponse.ErrorMessage = _ctx.StringValue("QueryDeviceRecordLifeCycle.ErrorMessage");
			queryDeviceRecordLifeCycleResponse.Success = _ctx.BooleanValue("QueryDeviceRecordLifeCycle.Success");

			List<QueryDeviceRecordLifeCycleResponse.QueryDeviceRecordLifeCycle_DataItem> queryDeviceRecordLifeCycleResponse_data = new List<QueryDeviceRecordLifeCycleResponse.QueryDeviceRecordLifeCycle_DataItem>();
			for (int i = 0; i < _ctx.Length("QueryDeviceRecordLifeCycle.Data.Length"); i++) {
				QueryDeviceRecordLifeCycleResponse.QueryDeviceRecordLifeCycle_DataItem dataItem = new QueryDeviceRecordLifeCycleResponse.QueryDeviceRecordLifeCycle_DataItem();
				dataItem.Day = _ctx.IntegerValue("QueryDeviceRecordLifeCycle.Data["+ i +"].Day");
				dataItem.IotId = _ctx.StringValue("QueryDeviceRecordLifeCycle.Data["+ i +"].IotId");

				queryDeviceRecordLifeCycleResponse_data.Add(dataItem);
			}
			queryDeviceRecordLifeCycleResponse.Data = queryDeviceRecordLifeCycleResponse_data;
        
			return queryDeviceRecordLifeCycleResponse;
        }
    }
}
