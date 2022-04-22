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
    public class QuerySchedulePeriodListResponseUnmarshaller
    {
        public static QuerySchedulePeriodListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySchedulePeriodListResponse querySchedulePeriodListResponse = new QuerySchedulePeriodListResponse();

			querySchedulePeriodListResponse.HttpResponse = _ctx.HttpResponse;
			querySchedulePeriodListResponse.RequestId = _ctx.StringValue("QuerySchedulePeriodList.RequestId");
			querySchedulePeriodListResponse.Success = _ctx.BooleanValue("QuerySchedulePeriodList.Success");
			querySchedulePeriodListResponse.Code = _ctx.StringValue("QuerySchedulePeriodList.Code");
			querySchedulePeriodListResponse.ErrorMessage = _ctx.StringValue("QuerySchedulePeriodList.ErrorMessage");

			QuerySchedulePeriodListResponse.QuerySchedulePeriodList_Data data = new QuerySchedulePeriodListResponse.QuerySchedulePeriodList_Data();
			data.Total = _ctx.IntegerValue("QuerySchedulePeriodList.Data.Total");
			data.PageId = _ctx.IntegerValue("QuerySchedulePeriodList.Data.PageId");
			data.PageSize = _ctx.IntegerValue("QuerySchedulePeriodList.Data.PageSize");

			List<QuerySchedulePeriodListResponse.QuerySchedulePeriodList_Data.QuerySchedulePeriodList_Items> data_list = new List<QuerySchedulePeriodListResponse.QuerySchedulePeriodList_Data.QuerySchedulePeriodList_Items>();
			for (int i = 0; i < _ctx.Length("QuerySchedulePeriodList.Data.List.Length"); i++) {
				QuerySchedulePeriodListResponse.QuerySchedulePeriodList_Data.QuerySchedulePeriodList_Items items = new QuerySchedulePeriodListResponse.QuerySchedulePeriodList_Data.QuerySchedulePeriodList_Items();
				items.PeriodCode = _ctx.StringValue("QuerySchedulePeriodList.Data.List["+ i +"].PeriodCode");
				items.SoundCodeContent = _ctx.StringValue("QuerySchedulePeriodList.Data.List["+ i +"].SoundCodeContent");
				items.Description = _ctx.StringValue("QuerySchedulePeriodList.Data.List["+ i +"].Description");
				items.StartTime = _ctx.StringValue("QuerySchedulePeriodList.Data.List["+ i +"].StartTime");
				items.EndTime = _ctx.StringValue("QuerySchedulePeriodList.Data.List["+ i +"].EndTime");

				data_list.Add(items);
			}
			data.List = data_list;
			querySchedulePeriodListResponse.Data = data;
        
			return querySchedulePeriodListResponse;
        }
    }
}
