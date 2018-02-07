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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.aegis.Model.V20161111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class QueryLoginEventResponseUnmarshaller
    {
        public static QueryLoginEventResponse Unmarshall(UnmarshallerContext context)
        {
			QueryLoginEventResponse queryLoginEventResponse = new QueryLoginEventResponse();

			queryLoginEventResponse.HttpResponse = context.HttpResponse;
			queryLoginEventResponse.RequestId = context.StringValue("QueryLoginEvent.RequestId");
			queryLoginEventResponse.Code = context.StringValue("QueryLoginEvent.Code");
			queryLoginEventResponse.Success = context.BooleanValue("QueryLoginEvent.Success");
			queryLoginEventResponse.Message = context.StringValue("QueryLoginEvent.Message");

			QueryLoginEventResponse.QueryLoginEvent_Data data = new QueryLoginEventResponse.QueryLoginEvent_Data();

			QueryLoginEventResponse.QueryLoginEvent_Data.QueryLoginEvent_PageInfo pageInfo = new QueryLoginEventResponse.QueryLoginEvent_Data.QueryLoginEvent_PageInfo();
			pageInfo.CurrentPage = context.IntegerValue("QueryLoginEvent.Data.PageInfo.CurrentPage");
			pageInfo.PageSize = context.IntegerValue("QueryLoginEvent.Data.PageInfo.PageSize");
			pageInfo.TotalCount = context.IntegerValue("QueryLoginEvent.Data.PageInfo.TotalCount");
			pageInfo.Count = context.IntegerValue("QueryLoginEvent.Data.PageInfo.Count");
			data.PageInfo = pageInfo;

			List<QueryLoginEventResponse.QueryLoginEvent_Data.QueryLoginEvent_Entity> data_list = new List<QueryLoginEventResponse.QueryLoginEvent_Data.QueryLoginEvent_Entity>();
			for (int i = 0; i < context.Length("QueryLoginEvent.Data.List.Length"); i++) {
				QueryLoginEventResponse.QueryLoginEvent_Data.QueryLoginEvent_Entity entity = new QueryLoginEventResponse.QueryLoginEvent_Data.QueryLoginEvent_Entity();
				entity.Uuid = context.StringValue("QueryLoginEvent.Data.List["+ i +"].Uuid");
				entity.LoginTime = context.StringValue("QueryLoginEvent.Data.List["+ i +"].LoginTime");
				entity.LoginType = context.IntegerValue("QueryLoginEvent.Data.List["+ i +"].LoginType");
				entity.LoginTypeName = context.StringValue("QueryLoginEvent.Data.List["+ i +"].LoginTypeName");
				entity.BuyVersion = context.StringValue("QueryLoginEvent.Data.List["+ i +"].BuyVersion");
				entity.LoginSourceIp = context.StringValue("QueryLoginEvent.Data.List["+ i +"].LoginSourceIp");
				entity.GroupId = context.IntegerValue("QueryLoginEvent.Data.List["+ i +"].GroupId");
				entity.InstanceName = context.StringValue("QueryLoginEvent.Data.List["+ i +"].InstanceName");
				entity.InstanceId = context.StringValue("QueryLoginEvent.Data.List["+ i +"].InstanceId");
				entity.Ip = context.StringValue("QueryLoginEvent.Data.List["+ i +"].Ip");
				entity.Region = context.StringValue("QueryLoginEvent.Data.List["+ i +"].Region");
				entity.Status = context.IntegerValue("QueryLoginEvent.Data.List["+ i +"].Status");
				entity.StatusName = context.StringValue("QueryLoginEvent.Data.List["+ i +"].StatusName");
				entity.Location = context.StringValue("QueryLoginEvent.Data.List["+ i +"].Location");
				entity.UserName = context.StringValue("QueryLoginEvent.Data.List["+ i +"].UserName");

				data_list.Add(entity);
			}
			data.List = data_list;
			queryLoginEventResponse.Data = data;
        
			return queryLoginEventResponse;
        }
    }
}