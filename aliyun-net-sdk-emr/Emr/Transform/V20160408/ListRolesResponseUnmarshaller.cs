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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListRolesResponseUnmarshaller
    {
        public static ListRolesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRolesResponse listRolesResponse = new ListRolesResponse();

			listRolesResponse.HttpResponse = _ctx.HttpResponse;
			listRolesResponse.Paging = _ctx.BooleanValue("ListRoles.Paging");
			listRolesResponse.RequestId = _ctx.StringValue("ListRoles.RequestId");

			List<ListRolesResponse.ListRoles_RoleDTO> listRolesResponse_data = new List<ListRolesResponse.ListRoles_RoleDTO>();
			for (int i = 0; i < _ctx.Length("ListRoles.Data.Length"); i++) {
				ListRolesResponse.ListRoles_RoleDTO roleDTO = new ListRolesResponse.ListRoles_RoleDTO();
				roleDTO.Id = _ctx.LongValue("ListRoles.Data["+ i +"].Id");
				roleDTO.Name = _ctx.StringValue("ListRoles.Data["+ i +"].Name");
				roleDTO.ResourceType = _ctx.StringValue("ListRoles.Data["+ i +"].ResourceType");
				roleDTO.GmtCreate = _ctx.StringValue("ListRoles.Data["+ i +"].GmtCreate");
				roleDTO.GmtModified = _ctx.StringValue("ListRoles.Data["+ i +"].GmtModified");
				roleDTO.Description = _ctx.StringValue("ListRoles.Data["+ i +"].Description");

				listRolesResponse_data.Add(roleDTO);
			}
			listRolesResponse.Data = listRolesResponse_data;
        
			return listRolesResponse;
        }
    }
}
