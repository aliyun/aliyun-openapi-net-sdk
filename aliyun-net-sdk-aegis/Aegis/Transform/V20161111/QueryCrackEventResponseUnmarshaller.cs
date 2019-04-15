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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class QueryCrackEventResponseUnmarshaller
    {
        public static QueryCrackEventResponse Unmarshall(UnmarshallerContext context)
        {
			QueryCrackEventResponse queryCrackEventResponse = new QueryCrackEventResponse();

			queryCrackEventResponse.HttpResponse = context.HttpResponse;
			queryCrackEventResponse.RequestId = context.StringValue("QueryCrackEvent.RequestId");
			queryCrackEventResponse.Code = context.StringValue("QueryCrackEvent.Code");
			queryCrackEventResponse.Success = context.BooleanValue("QueryCrackEvent.Success");
			queryCrackEventResponse.Message = context.StringValue("QueryCrackEvent.Message");

			QueryCrackEventResponse.QueryCrackEvent_Data data = new QueryCrackEventResponse.QueryCrackEvent_Data();

			QueryCrackEventResponse.QueryCrackEvent_Data.QueryCrackEvent_PageInfo pageInfo = new QueryCrackEventResponse.QueryCrackEvent_Data.QueryCrackEvent_PageInfo();
			pageInfo.CurrentPage = context.IntegerValue("QueryCrackEvent.Data.PageInfo.CurrentPage");
			pageInfo.PageSize = context.IntegerValue("QueryCrackEvent.Data.PageInfo.PageSize");
			pageInfo.TotalCount = context.IntegerValue("QueryCrackEvent.Data.PageInfo.TotalCount");
			pageInfo.Count = context.IntegerValue("QueryCrackEvent.Data.PageInfo.Count");
			data.PageInfo = pageInfo;

			List<QueryCrackEventResponse.QueryCrackEvent_Data.QueryCrackEvent_Entity> data_list = new List<QueryCrackEventResponse.QueryCrackEvent_Data.QueryCrackEvent_Entity>();
			for (int i = 0; i < context.Length("QueryCrackEvent.Data.List.Length"); i++) {
				QueryCrackEventResponse.QueryCrackEvent_Data.QueryCrackEvent_Entity entity = new QueryCrackEventResponse.QueryCrackEvent_Data.QueryCrackEvent_Entity();
				entity.Uuid = context.StringValue("QueryCrackEvent.Data.List["+ i +"].Uuid");
				entity.AttackTime = context.StringValue("QueryCrackEvent.Data.List["+ i +"].AttackTime");
				entity.AttackType = context.IntegerValue("QueryCrackEvent.Data.List["+ i +"].AttackType");
				entity.AttackTypeName = context.StringValue("QueryCrackEvent.Data.List["+ i +"].AttackTypeName");
				entity.BuyVersion = context.StringValue("QueryCrackEvent.Data.List["+ i +"].BuyVersion");
				entity.CrackSourceIp = context.StringValue("QueryCrackEvent.Data.List["+ i +"].CrackSourceIp");
				entity.CrackTimes = context.IntegerValue("QueryCrackEvent.Data.List["+ i +"].CrackTimes");
				entity.GroupId = context.IntegerValue("QueryCrackEvent.Data.List["+ i +"].GroupId");
				entity.InstanceName = context.StringValue("QueryCrackEvent.Data.List["+ i +"].InstanceName");
				entity.InstanceId = context.StringValue("QueryCrackEvent.Data.List["+ i +"].InstanceId");
				entity.Ip = context.StringValue("QueryCrackEvent.Data.List["+ i +"].Ip");
				entity.Region = context.StringValue("QueryCrackEvent.Data.List["+ i +"].Region");
				entity.Status = context.IntegerValue("QueryCrackEvent.Data.List["+ i +"].Status");
				entity.StatusName = context.StringValue("QueryCrackEvent.Data.List["+ i +"].StatusName");
				entity.Location = context.StringValue("QueryCrackEvent.Data.List["+ i +"].Location");
				entity.InWhite = context.IntegerValue("QueryCrackEvent.Data.List["+ i +"].InWhite");
				entity.UserName = context.StringValue("QueryCrackEvent.Data.List["+ i +"].UserName");

				data_list.Add(entity);
			}
			data.List = data_list;
			queryCrackEventResponse.Data = data;
        
			return queryCrackEventResponse;
        }
    }
}
