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
using Aliyun.Acs.CDRS.Model.V20201101;

namespace Aliyun.Acs.CDRS.Transform.V20201101
{
    public class ListRangeDeviceResponseUnmarshaller
    {
        public static ListRangeDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRangeDeviceResponse listRangeDeviceResponse = new ListRangeDeviceResponse();

			listRangeDeviceResponse.HttpResponse = _ctx.HttpResponse;
			listRangeDeviceResponse.Code = _ctx.StringValue("ListRangeDevice.Code");
			listRangeDeviceResponse.Message = _ctx.StringValue("ListRangeDevice.Message");
			listRangeDeviceResponse.RequestId = _ctx.StringValue("ListRangeDevice.RequestId");
			listRangeDeviceResponse.PageNumber = _ctx.LongValue("ListRangeDevice.PageNumber");
			listRangeDeviceResponse.PageSize = _ctx.LongValue("ListRangeDevice.PageSize");
			listRangeDeviceResponse.TotalCount = _ctx.LongValue("ListRangeDevice.TotalCount");

			List<ListRangeDeviceResponse.ListRangeDevice_Datas> listRangeDeviceResponse_data = new List<ListRangeDeviceResponse.ListRangeDevice_Datas>();
			for (int i = 0; i < _ctx.Length("ListRangeDevice.Data.Length"); i++) {
				ListRangeDeviceResponse.ListRangeDevice_Datas datas = new ListRangeDeviceResponse.ListRangeDevice_Datas();
				datas.CorpId = _ctx.StringValue("ListRangeDevice.Data["+ i +"].CorpId");
				datas.DataSourceId = _ctx.StringValue("ListRangeDevice.Data["+ i +"].DataSourceId");
				datas.NearPoi = _ctx.StringValue("ListRangeDevice.Data["+ i +"].NearPoi");
				datas.Distance = _ctx.StringValue("ListRangeDevice.Data["+ i +"].Distance");
				datas.DataSourceIdPoi = _ctx.StringValue("ListRangeDevice.Data["+ i +"].DataSourceIdPoi");
				datas.Latitude = _ctx.StringValue("ListRangeDevice.Data["+ i +"].Latitude");
				datas.DataSourceIdName = _ctx.StringValue("ListRangeDevice.Data["+ i +"].DataSourceIdName");
				datas.Longitude = _ctx.StringValue("ListRangeDevice.Data["+ i +"].Longitude");

				listRangeDeviceResponse_data.Add(datas);
			}
			listRangeDeviceResponse.Data = listRangeDeviceResponse_data;
        
			return listRangeDeviceResponse;
        }
    }
}
