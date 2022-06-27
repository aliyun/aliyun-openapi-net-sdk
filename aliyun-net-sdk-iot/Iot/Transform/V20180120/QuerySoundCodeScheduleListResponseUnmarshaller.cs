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
    public class QuerySoundCodeScheduleListResponseUnmarshaller
    {
        public static QuerySoundCodeScheduleListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySoundCodeScheduleListResponse querySoundCodeScheduleListResponse = new QuerySoundCodeScheduleListResponse();

			querySoundCodeScheduleListResponse.HttpResponse = _ctx.HttpResponse;
			querySoundCodeScheduleListResponse.RequestId = _ctx.StringValue("QuerySoundCodeScheduleList.RequestId");
			querySoundCodeScheduleListResponse.Success = _ctx.BooleanValue("QuerySoundCodeScheduleList.Success");
			querySoundCodeScheduleListResponse.Code = _ctx.StringValue("QuerySoundCodeScheduleList.Code");
			querySoundCodeScheduleListResponse.ErrorMessage = _ctx.StringValue("QuerySoundCodeScheduleList.ErrorMessage");

			QuerySoundCodeScheduleListResponse.QuerySoundCodeScheduleList_Data data = new QuerySoundCodeScheduleListResponse.QuerySoundCodeScheduleList_Data();
			data.Total = _ctx.IntegerValue("QuerySoundCodeScheduleList.Data.Total");
			data.PageId = _ctx.IntegerValue("QuerySoundCodeScheduleList.Data.PageId");
			data.PageSize = _ctx.IntegerValue("QuerySoundCodeScheduleList.Data.PageSize");

			List<QuerySoundCodeScheduleListResponse.QuerySoundCodeScheduleList_Data.QuerySoundCodeScheduleList_Items> data_list = new List<QuerySoundCodeScheduleListResponse.QuerySoundCodeScheduleList_Data.QuerySoundCodeScheduleList_Items>();
			for (int i = 0; i < _ctx.Length("QuerySoundCodeScheduleList.Data.List.Length"); i++) {
				QuerySoundCodeScheduleListResponse.QuerySoundCodeScheduleList_Data.QuerySoundCodeScheduleList_Items items = new QuerySoundCodeScheduleListResponse.QuerySoundCodeScheduleList_Data.QuerySoundCodeScheduleList_Items();
				items.ScheduleCode = _ctx.StringValue("QuerySoundCodeScheduleList.Data.List["+ i +"].ScheduleCode");
				items.Name = _ctx.StringValue("QuerySoundCodeScheduleList.Data.List["+ i +"].Name");
				items.Description = _ctx.StringValue("QuerySoundCodeScheduleList.Data.List["+ i +"].Description");
				items.GmtCreate = _ctx.LongValue("QuerySoundCodeScheduleList.Data.List["+ i +"].GmtCreate");
				items.Status = _ctx.StringValue("QuerySoundCodeScheduleList.Data.List["+ i +"].Status");
				items.StartTime = _ctx.StringValue("QuerySoundCodeScheduleList.Data.List["+ i +"].StartTime");
				items.EndTime = _ctx.StringValue("QuerySoundCodeScheduleList.Data.List["+ i +"].EndTime");
				items.StartDate = _ctx.StringValue("QuerySoundCodeScheduleList.Data.List["+ i +"].StartDate");
				items.EndDate = _ctx.StringValue("QuerySoundCodeScheduleList.Data.List["+ i +"].EndDate");
				items.OpenType = _ctx.StringValue("QuerySoundCodeScheduleList.Data.List["+ i +"].OpenType");

				data_list.Add(items);
			}
			data.List = data_list;
			querySoundCodeScheduleListResponse.Data = data;
        
			return querySoundCodeScheduleListResponse;
        }
    }
}
