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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class ListRamUsersResponseUnmarshaller
    {
        public static ListRamUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRamUsersResponse listRamUsersResponse = new ListRamUsersResponse();

			listRamUsersResponse.HttpResponse = _ctx.HttpResponse;
			listRamUsersResponse.Code = _ctx.StringValue("ListRamUsers.Code");
			listRamUsersResponse.HttpStatusCode = _ctx.IntegerValue("ListRamUsers.HttpStatusCode");
			listRamUsersResponse.Message = _ctx.StringValue("ListRamUsers.Message");
			listRamUsersResponse.RequestId = _ctx.StringValue("ListRamUsers.RequestId");

			List<string> listRamUsersResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("ListRamUsers.Params.Length"); i++) {
				listRamUsersResponse_params.Add(_ctx.StringValue("ListRamUsers.Params["+ i +"]"));
			}
			listRamUsersResponse._Params = listRamUsersResponse_params;

			ListRamUsersResponse.ListRamUsers_Data data = new ListRamUsersResponse.ListRamUsers_Data();
			data.PageNumber = _ctx.IntegerValue("ListRamUsers.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListRamUsers.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListRamUsers.Data.TotalCount");

			List<ListRamUsersResponse.ListRamUsers_Data.ListRamUsers_RamUser> data_list = new List<ListRamUsersResponse.ListRamUsers_Data.ListRamUsers_RamUser>();
			for (int i = 0; i < _ctx.Length("ListRamUsers.Data.List.Length"); i++) {
				ListRamUsersResponse.ListRamUsers_Data.ListRamUsers_RamUser ramUser = new ListRamUsersResponse.ListRamUsers_Data.ListRamUsers_RamUser();
				ramUser.DisplayName = _ctx.StringValue("ListRamUsers.Data.List["+ i +"].DisplayName");
				ramUser.Email = _ctx.StringValue("ListRamUsers.Data.List["+ i +"].Email");
				ramUser.LoginName = _ctx.StringValue("ListRamUsers.Data.List["+ i +"].LoginName");
				ramUser.Mobile = _ctx.StringValue("ListRamUsers.Data.List["+ i +"].Mobile");
				ramUser.AliyunUid = _ctx.LongValue("ListRamUsers.Data.List["+ i +"].AliyunUid");
				ramUser.Primary = _ctx.BooleanValue("ListRamUsers.Data.List["+ i +"].Primary");
				ramUser.RamId = _ctx.StringValue("ListRamUsers.Data.List["+ i +"].RamId");

				data_list.Add(ramUser);
			}
			data.List = data_list;
			listRamUsersResponse.Data = data;
        
			return listRamUsersResponse;
        }
    }
}
