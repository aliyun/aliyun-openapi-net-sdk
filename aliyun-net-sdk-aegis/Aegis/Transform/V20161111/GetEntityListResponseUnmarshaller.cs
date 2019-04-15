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
    public class GetEntityListResponseUnmarshaller
    {
        public static GetEntityListResponse Unmarshall(UnmarshallerContext context)
        {
			GetEntityListResponse getEntityListResponse = new GetEntityListResponse();

			getEntityListResponse.HttpResponse = context.HttpResponse;
			getEntityListResponse.RequestId = context.StringValue("GetEntityList.RequestId");
			getEntityListResponse.Code = context.StringValue("GetEntityList.Code");
			getEntityListResponse.Success = context.BooleanValue("GetEntityList.Success");
			getEntityListResponse.Message = context.StringValue("GetEntityList.Message");

			GetEntityListResponse.GetEntityList_Data data = new GetEntityListResponse.GetEntityList_Data();

			GetEntityListResponse.GetEntityList_Data.GetEntityList_PageInfo pageInfo = new GetEntityListResponse.GetEntityList_Data.GetEntityList_PageInfo();
			pageInfo.CurrentPage = context.IntegerValue("GetEntityList.Data.PageInfo.CurrentPage");
			pageInfo.PageSize = context.IntegerValue("GetEntityList.Data.PageInfo.PageSize");
			pageInfo.TotalCount = context.IntegerValue("GetEntityList.Data.PageInfo.TotalCount");
			pageInfo.Count = context.IntegerValue("GetEntityList.Data.PageInfo.Count");
			data.PageInfo = pageInfo;

			List<GetEntityListResponse.GetEntityList_Data.GetEntityList_Entity> data_list = new List<GetEntityListResponse.GetEntityList_Data.GetEntityList_Entity>();
			for (int i = 0; i < context.Length("GetEntityList.Data.List.Length"); i++) {
				GetEntityListResponse.GetEntityList_Data.GetEntityList_Entity entity = new GetEntityListResponse.GetEntityList_Data.GetEntityList_Entity();
				entity.Uuid = context.StringValue("GetEntityList.Data.List["+ i +"].Uuid");
				entity.GroupId = context.LongValue("GetEntityList.Data.List["+ i +"].GroupId");
				entity.Ip = context.StringValue("GetEntityList.Data.List["+ i +"].Ip");
				entity.InstanceName = context.StringValue("GetEntityList.Data.List["+ i +"].InstanceName");
				entity.InstanceId = context.StringValue("GetEntityList.Data.List["+ i +"].InstanceId");
				entity.Region = context.StringValue("GetEntityList.Data.List["+ i +"].Region");
				entity.Os = context.StringValue("GetEntityList.Data.List["+ i +"].Os");
				entity.Flag = context.StringValue("GetEntityList.Data.List["+ i +"].Flag");
				entity.BuyVersion = context.StringValue("GetEntityList.Data.List["+ i +"].BuyVersion");
				entity.AegisOnline = context.BooleanValue("GetEntityList.Data.List["+ i +"].AegisOnline");
				entity.AegisVersion = context.StringValue("GetEntityList.Data.List["+ i +"].AegisVersion");

				data_list.Add(entity);
			}
			data.List = data_list;
			getEntityListResponse.Data = data;
        
			return getEntityListResponse;
        }
    }
}
