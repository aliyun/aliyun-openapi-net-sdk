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
    public class ListPowerStationResponseUnmarshaller
    {
        public static ListPowerStationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPowerStationResponse listPowerStationResponse = new ListPowerStationResponse();

			listPowerStationResponse.HttpResponse = _ctx.HttpResponse;
			listPowerStationResponse.RequestId = _ctx.StringValue("ListPowerStation.RequestId");
			listPowerStationResponse.Success = _ctx.BooleanValue("ListPowerStation.Success");
			listPowerStationResponse.Code = _ctx.StringValue("ListPowerStation.Code");
			listPowerStationResponse.ErrorMessage = _ctx.StringValue("ListPowerStation.ErrorMessage");

			ListPowerStationResponse.ListPowerStation_Data data = new ListPowerStationResponse.ListPowerStation_Data();
			data.PageNo = _ctx.IntegerValue("ListPowerStation.Data.PageNo");
			data.Total = _ctx.LongValue("ListPowerStation.Data.Total");
			data.PageSize = _ctx.IntegerValue("ListPowerStation.Data.PageSize");

			List<ListPowerStationResponse.ListPowerStation_Data.ListPowerStation_DataListItem> data_dataList = new List<ListPowerStationResponse.ListPowerStation_Data.ListPowerStation_DataListItem>();
			for (int i = 0; i < _ctx.Length("ListPowerStation.Data.DataList.Length"); i++) {
				ListPowerStationResponse.ListPowerStation_Data.ListPowerStation_DataListItem dataListItem = new ListPowerStationResponse.ListPowerStation_Data.ListPowerStation_DataListItem();
				dataListItem.PowerStationUid = _ctx.StringValue("ListPowerStation.Data.DataList["+ i +"].PowerStationUid");
				dataListItem.AlgoInstanceUid = _ctx.StringValue("ListPowerStation.Data.DataList["+ i +"].AlgoInstanceUid");
				dataListItem.Name = _ctx.StringValue("ListPowerStation.Data.DataList["+ i +"].Name");
				dataListItem.Description = _ctx.StringValue("ListPowerStation.Data.DataList["+ i +"].Description");
				dataListItem.RatedPower = _ctx.IntegerValue("ListPowerStation.Data.DataList["+ i +"].RatedPower");

				data_dataList.Add(dataListItem);
			}
			data.DataList = data_dataList;
			listPowerStationResponse.Data = data;
        
			return listPowerStationResponse;
        }
    }
}
