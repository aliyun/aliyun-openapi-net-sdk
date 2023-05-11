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
    public class QueryFaceAllUserIdsByGroupIdResponseUnmarshaller
    {
        public static QueryFaceAllUserIdsByGroupIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryFaceAllUserIdsByGroupIdResponse queryFaceAllUserIdsByGroupIdResponse = new QueryFaceAllUserIdsByGroupIdResponse();

			queryFaceAllUserIdsByGroupIdResponse.HttpResponse = _ctx.HttpResponse;
			queryFaceAllUserIdsByGroupIdResponse.Code = _ctx.StringValue("QueryFaceAllUserIdsByGroupId.Code");
			queryFaceAllUserIdsByGroupIdResponse.RequestId = _ctx.StringValue("QueryFaceAllUserIdsByGroupId.RequestId");
			queryFaceAllUserIdsByGroupIdResponse.ErrorMessage = _ctx.StringValue("QueryFaceAllUserIdsByGroupId.ErrorMessage");
			queryFaceAllUserIdsByGroupIdResponse.Success = _ctx.BooleanValue("QueryFaceAllUserIdsByGroupId.Success");

			QueryFaceAllUserIdsByGroupIdResponse.QueryFaceAllUserIdsByGroupId_Data data = new QueryFaceAllUserIdsByGroupIdResponse.QueryFaceAllUserIdsByGroupId_Data();
			data.PageSize = _ctx.IntegerValue("QueryFaceAllUserIdsByGroupId.Data.PageSize");
			data.Total = _ctx.IntegerValue("QueryFaceAllUserIdsByGroupId.Data.Total");
			data.Page = _ctx.IntegerValue("QueryFaceAllUserIdsByGroupId.Data.Page");

			List<QueryFaceAllUserIdsByGroupIdResponse.QueryFaceAllUserIdsByGroupId_Data.QueryFaceAllUserIdsByGroupId_ListItem> data_list = new List<QueryFaceAllUserIdsByGroupIdResponse.QueryFaceAllUserIdsByGroupId_Data.QueryFaceAllUserIdsByGroupId_ListItem>();
			for (int i = 0; i < _ctx.Length("QueryFaceAllUserIdsByGroupId.Data.List.Length"); i++) {
				QueryFaceAllUserIdsByGroupIdResponse.QueryFaceAllUserIdsByGroupId_Data.QueryFaceAllUserIdsByGroupId_ListItem listItem = new QueryFaceAllUserIdsByGroupIdResponse.QueryFaceAllUserIdsByGroupId_Data.QueryFaceAllUserIdsByGroupId_ListItem();
				listItem._Params = _ctx.StringValue("QueryFaceAllUserIdsByGroupId.Data.List["+ i +"].Params");
				listItem.CustomUserId = _ctx.StringValue("QueryFaceAllUserIdsByGroupId.Data.List["+ i +"].CustomUserId");
				listItem.Name = _ctx.StringValue("QueryFaceAllUserIdsByGroupId.Data.List["+ i +"].Name");
				listItem.UserId = _ctx.StringValue("QueryFaceAllUserIdsByGroupId.Data.List["+ i +"].UserId");

				data_list.Add(listItem);
			}
			data.List = data_list;
			queryFaceAllUserIdsByGroupIdResponse.Data = data;
        
			return queryFaceAllUserIdsByGroupIdResponse;
        }
    }
}
