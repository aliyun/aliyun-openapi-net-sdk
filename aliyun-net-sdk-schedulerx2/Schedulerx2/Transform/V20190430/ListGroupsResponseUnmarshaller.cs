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
using Aliyun.Acs.schedulerx2.Model.V20190430;

namespace Aliyun.Acs.schedulerx2.Transform.V20190430
{
    public class ListGroupsResponseUnmarshaller
    {
        public static ListGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListGroupsResponse listGroupsResponse = new ListGroupsResponse();

			listGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listGroupsResponse.RequestId = _ctx.StringValue("ListGroups.RequestId");
			listGroupsResponse.Code = _ctx.IntegerValue("ListGroups.Code");
			listGroupsResponse.Message = _ctx.StringValue("ListGroups.Message");
			listGroupsResponse.Success = _ctx.BooleanValue("ListGroups.Success");

			ListGroupsResponse.ListGroups_Data data = new ListGroupsResponse.ListGroups_Data();

			List<ListGroupsResponse.ListGroups_Data.ListGroups_AppGroup> data_appGroups = new List<ListGroupsResponse.ListGroups_Data.ListGroups_AppGroup>();
			for (int i = 0; i < _ctx.Length("ListGroups.Data.AppGroups.Length"); i++) {
				ListGroupsResponse.ListGroups_Data.ListGroups_AppGroup appGroup = new ListGroupsResponse.ListGroups_Data.ListGroups_AppGroup();
				appGroup.AppName = _ctx.StringValue("ListGroups.Data.AppGroups["+ i +"].AppName");
				appGroup.GroupId = _ctx.StringValue("ListGroups.Data.AppGroups["+ i +"].GroupId");
				appGroup.AppKey = _ctx.StringValue("ListGroups.Data.AppGroups["+ i +"].AppKey");
				appGroup.Description = _ctx.StringValue("ListGroups.Data.AppGroups["+ i +"].Description");

				data_appGroups.Add(appGroup);
			}
			data.AppGroups = data_appGroups;
			listGroupsResponse.Data = data;
        
			return listGroupsResponse;
        }
    }
}
