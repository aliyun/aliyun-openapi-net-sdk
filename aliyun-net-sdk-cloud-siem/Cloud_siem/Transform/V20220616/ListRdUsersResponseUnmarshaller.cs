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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class ListRdUsersResponseUnmarshaller
    {
        public static ListRdUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRdUsersResponse listRdUsersResponse = new ListRdUsersResponse();

			listRdUsersResponse.HttpResponse = _ctx.HttpResponse;
			listRdUsersResponse.RequestId = _ctx.StringValue("ListRdUsers.RequestId");

			List<ListRdUsersResponse.ListRdUsers_DataItem> listRdUsersResponse_data = new List<ListRdUsersResponse.ListRdUsers_DataItem>();
			for (int i = 0; i < _ctx.Length("ListRdUsers.Data.Length"); i++) {
				ListRdUsersResponse.ListRdUsers_DataItem dataItem = new ListRdUsersResponse.ListRdUsers_DataItem();
				dataItem.Joined = _ctx.BooleanValue("ListRdUsers.Data["+ i +"].Joined");
				dataItem.JoinedTime = _ctx.StringValue("ListRdUsers.Data["+ i +"].JoinedTime");
				dataItem.DelegatedOrNot = _ctx.BooleanValue("ListRdUsers.Data["+ i +"].DelegatedOrNot");
				dataItem.MainUserId = _ctx.LongValue("ListRdUsers.Data["+ i +"].MainUserId");
				dataItem.SubUserId = _ctx.LongValue("ListRdUsers.Data["+ i +"].SubUserId");
				dataItem.SubUserName = _ctx.StringValue("ListRdUsers.Data["+ i +"].SubUserName");

				listRdUsersResponse_data.Add(dataItem);
			}
			listRdUsersResponse.Data = listRdUsersResponse_data;
        
			return listRdUsersResponse;
        }
    }
}
