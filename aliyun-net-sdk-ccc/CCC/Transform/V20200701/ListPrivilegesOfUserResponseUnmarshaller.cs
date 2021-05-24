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
    public class ListPrivilegesOfUserResponseUnmarshaller
    {
        public static ListPrivilegesOfUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPrivilegesOfUserResponse listPrivilegesOfUserResponse = new ListPrivilegesOfUserResponse();

			listPrivilegesOfUserResponse.HttpResponse = _ctx.HttpResponse;
			listPrivilegesOfUserResponse.Code = _ctx.StringValue("ListPrivilegesOfUser.Code");
			listPrivilegesOfUserResponse.HttpStatusCode = _ctx.IntegerValue("ListPrivilegesOfUser.HttpStatusCode");
			listPrivilegesOfUserResponse.Message = _ctx.StringValue("ListPrivilegesOfUser.Message");
			listPrivilegesOfUserResponse.RequestId = _ctx.StringValue("ListPrivilegesOfUser.RequestId");

			List<ListPrivilegesOfUserResponse.ListPrivilegesOfUser_DataItem> listPrivilegesOfUserResponse_data = new List<ListPrivilegesOfUserResponse.ListPrivilegesOfUser_DataItem>();
			for (int i = 0; i < _ctx.Length("ListPrivilegesOfUser.Data.Length"); i++) {
				ListPrivilegesOfUserResponse.ListPrivilegesOfUser_DataItem dataItem = new ListPrivilegesOfUserResponse.ListPrivilegesOfUser_DataItem();
				dataItem.InstanceId = _ctx.StringValue("ListPrivilegesOfUser.Data["+ i +"].InstanceId");
				dataItem.Name = _ctx.StringValue("ListPrivilegesOfUser.Data["+ i +"].Name");
				dataItem.Scope = _ctx.StringValue("ListPrivilegesOfUser.Data["+ i +"].Scope");

				listPrivilegesOfUserResponse_data.Add(dataItem);
			}
			listPrivilegesOfUserResponse.Data = listPrivilegesOfUserResponse_data;
        
			return listPrivilegesOfUserResponse;
        }
    }
}
