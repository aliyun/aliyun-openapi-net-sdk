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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class ListPrivilegesOfUserResponseUnmarshaller
    {
        public static ListPrivilegesOfUserResponse Unmarshall(UnmarshallerContext context)
        {
			ListPrivilegesOfUserResponse listPrivilegesOfUserResponse = new ListPrivilegesOfUserResponse();

			listPrivilegesOfUserResponse.HttpResponse = context.HttpResponse;
			listPrivilegesOfUserResponse.RequestId = context.StringValue("ListPrivilegesOfUser.RequestId");
			listPrivilegesOfUserResponse.Success = context.BooleanValue("ListPrivilegesOfUser.Success");
			listPrivilegesOfUserResponse.Code = context.StringValue("ListPrivilegesOfUser.Code");
			listPrivilegesOfUserResponse.Message = context.StringValue("ListPrivilegesOfUser.Message");
			listPrivilegesOfUserResponse.HttpStatusCode = context.IntegerValue("ListPrivilegesOfUser.HttpStatusCode");

			List<ListPrivilegesOfUserResponse.ListPrivilegesOfUser_Privilege> listPrivilegesOfUserResponse_privileges = new List<ListPrivilegesOfUserResponse.ListPrivilegesOfUser_Privilege>();
			for (int i = 0; i < context.Length("ListPrivilegesOfUser.Privileges.Length"); i++) {
				ListPrivilegesOfUserResponse.ListPrivilegesOfUser_Privilege privilege = new ListPrivilegesOfUserResponse.ListPrivilegesOfUser_Privilege();
				privilege.PrivilegeId = context.StringValue("ListPrivilegesOfUser.Privileges["+ i +"].PrivilegeId");
				privilege.PrivilegeName = context.StringValue("ListPrivilegesOfUser.Privileges["+ i +"].PrivilegeName");
				privilege.PrivilegeDescription = context.StringValue("ListPrivilegesOfUser.Privileges["+ i +"].PrivilegeDescription");

				listPrivilegesOfUserResponse_privileges.Add(privilege);
			}
			listPrivilegesOfUserResponse.Privileges = listPrivilegesOfUserResponse_privileges;
        
			return listPrivilegesOfUserResponse;
        }
    }
}
