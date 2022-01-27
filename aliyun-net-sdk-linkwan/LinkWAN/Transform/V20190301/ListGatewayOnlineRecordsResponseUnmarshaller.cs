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
using Aliyun.Acs.LinkWAN.Model.V20190301;

namespace Aliyun.Acs.LinkWAN.Transform.V20190301
{
    public class ListGatewayOnlineRecordsResponseUnmarshaller
    {
        public static ListGatewayOnlineRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListGatewayOnlineRecordsResponse listGatewayOnlineRecordsResponse = new ListGatewayOnlineRecordsResponse();

			listGatewayOnlineRecordsResponse.HttpResponse = _ctx.HttpResponse;
			listGatewayOnlineRecordsResponse.RequestId = _ctx.StringValue("ListGatewayOnlineRecords.RequestId");
			listGatewayOnlineRecordsResponse.Success = _ctx.BooleanValue("ListGatewayOnlineRecords.Success");

			ListGatewayOnlineRecordsResponse.ListGatewayOnlineRecords_Data data = new ListGatewayOnlineRecordsResponse.ListGatewayOnlineRecords_Data();
			data.TotalCount = _ctx.LongValue("ListGatewayOnlineRecords.Data.TotalCount");

			List<ListGatewayOnlineRecordsResponse.ListGatewayOnlineRecords_Data.ListGatewayOnlineRecords_Record> data_list = new List<ListGatewayOnlineRecordsResponse.ListGatewayOnlineRecords_Data.ListGatewayOnlineRecords_Record>();
			for (int i = 0; i < _ctx.Length("ListGatewayOnlineRecords.Data.List.Length"); i++) {
				ListGatewayOnlineRecordsResponse.ListGatewayOnlineRecords_Data.ListGatewayOnlineRecords_Record record = new ListGatewayOnlineRecordsResponse.ListGatewayOnlineRecords_Data.ListGatewayOnlineRecords_Record();
				record.OnlineState = _ctx.StringValue("ListGatewayOnlineRecords.Data.List["+ i +"].OnlineState");
				record.StateChangedMillis = _ctx.LongValue("ListGatewayOnlineRecords.Data.List["+ i +"].StateChangedMillis");
				record.GwEui = _ctx.StringValue("ListGatewayOnlineRecords.Data.List["+ i +"].GwEui");

				data_list.Add(record);
			}
			data.List = data_list;
			listGatewayOnlineRecordsResponse.Data = data;
        
			return listGatewayOnlineRecordsResponse;
        }
    }
}
