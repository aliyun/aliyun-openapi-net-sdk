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
    public class QuerySolutionDeviceGroupPageResponseUnmarshaller
    {
        public static QuerySolutionDeviceGroupPageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySolutionDeviceGroupPageResponse querySolutionDeviceGroupPageResponse = new QuerySolutionDeviceGroupPageResponse();

			querySolutionDeviceGroupPageResponse.HttpResponse = _ctx.HttpResponse;
			querySolutionDeviceGroupPageResponse.RequestId = _ctx.StringValue("QuerySolutionDeviceGroupPage.RequestId");
			querySolutionDeviceGroupPageResponse.Success = _ctx.BooleanValue("QuerySolutionDeviceGroupPage.Success");
			querySolutionDeviceGroupPageResponse.Code = _ctx.StringValue("QuerySolutionDeviceGroupPage.Code");
			querySolutionDeviceGroupPageResponse.ErrorMessage = _ctx.StringValue("QuerySolutionDeviceGroupPage.ErrorMessage");

			QuerySolutionDeviceGroupPageResponse.QuerySolutionDeviceGroupPage_Data data = new QuerySolutionDeviceGroupPageResponse.QuerySolutionDeviceGroupPage_Data();
			data.PageId = _ctx.IntegerValue("QuerySolutionDeviceGroupPage.Data.PageId");
			data.PageSize = _ctx.IntegerValue("QuerySolutionDeviceGroupPage.Data.PageSize");
			data.Total = _ctx.IntegerValue("QuerySolutionDeviceGroupPage.Data.Total");

			List<QuerySolutionDeviceGroupPageResponse.QuerySolutionDeviceGroupPage_Data.QuerySolutionDeviceGroupPage_ItemName> data_list = new List<QuerySolutionDeviceGroupPageResponse.QuerySolutionDeviceGroupPage_Data.QuerySolutionDeviceGroupPage_ItemName>();
			for (int i = 0; i < _ctx.Length("QuerySolutionDeviceGroupPage.Data.List.Length"); i++) {
				QuerySolutionDeviceGroupPageResponse.QuerySolutionDeviceGroupPage_Data.QuerySolutionDeviceGroupPage_ItemName itemName = new QuerySolutionDeviceGroupPageResponse.QuerySolutionDeviceGroupPage_Data.QuerySolutionDeviceGroupPage_ItemName();
				itemName.GmtCreate = _ctx.LongValue("QuerySolutionDeviceGroupPage.Data.List["+ i +"].GmtCreate");
				itemName.GmtModified = _ctx.LongValue("QuerySolutionDeviceGroupPage.Data.List["+ i +"].GmtModified");
				itemName.GroupId = _ctx.StringValue("QuerySolutionDeviceGroupPage.Data.List["+ i +"].GroupId");
				itemName.GroupName = _ctx.StringValue("QuerySolutionDeviceGroupPage.Data.List["+ i +"].GroupName");
				itemName.GroupDesc = _ctx.StringValue("QuerySolutionDeviceGroupPage.Data.List["+ i +"].GroupDesc");
				itemName.DeviceCount = _ctx.LongValue("QuerySolutionDeviceGroupPage.Data.List["+ i +"].DeviceCount");

				data_list.Add(itemName);
			}
			data.List = data_list;
			querySolutionDeviceGroupPageResponse.Data = data;
        
			return querySolutionDeviceGroupPageResponse;
        }
    }
}
