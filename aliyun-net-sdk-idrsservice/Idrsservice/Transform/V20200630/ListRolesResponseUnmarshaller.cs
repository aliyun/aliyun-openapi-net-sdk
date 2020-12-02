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
using Aliyun.Acs.idrsservice.Model.V20200630;

namespace Aliyun.Acs.idrsservice.Transform.V20200630
{
    public class ListRolesResponseUnmarshaller
    {
        public static ListRolesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRolesResponse listRolesResponse = new ListRolesResponse();

			listRolesResponse.HttpResponse = _ctx.HttpResponse;
			listRolesResponse.Code = _ctx.StringValue("ListRoles.Code");
			listRolesResponse.Message = _ctx.StringValue("ListRoles.Message");
			listRolesResponse.RequestId = _ctx.StringValue("ListRoles.RequestId");

			List<string> listRolesResponse_data = new List<string>();
			for (int i = 0; i < _ctx.Length("ListRoles.Data.Length"); i++) {
				listRolesResponse_data.Add(_ctx.StringValue("ListRoles.Data["+ i +"]"));
			}
			listRolesResponse.Data = listRolesResponse_data;
        
			return listRolesResponse;
        }
    }
}
