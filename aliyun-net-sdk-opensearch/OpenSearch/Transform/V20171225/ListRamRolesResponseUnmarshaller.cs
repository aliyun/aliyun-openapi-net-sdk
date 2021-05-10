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
using Aliyun.Acs.OpenSearch.Model.V20171225;

namespace Aliyun.Acs.OpenSearch.Transform.V20171225
{
    public class ListRamRolesResponseUnmarshaller
    {
        public static ListRamRolesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRamRolesResponse listRamRolesResponse = new ListRamRolesResponse();

			listRamRolesResponse.HttpResponse = _ctx.HttpResponse;
			listRamRolesResponse.RequestId = _ctx.StringValue("ListRamRoles.requestId");

			List<ListRamRolesResponse.ListRamRoles_ResultItem> listRamRolesResponse_result = new List<ListRamRolesResponse.ListRamRoles_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListRamRoles.Result.Length"); i++) {
				ListRamRolesResponse.ListRamRoles_ResultItem resultItem = new ListRamRolesResponse.ListRamRoles_ResultItem();
				resultItem.Name = _ctx.StringValue("ListRamRoles.Result["+ i +"].name");
				resultItem.Service = _ctx.StringValue("ListRamRoles.Result["+ i +"].service");
				resultItem.Template_id = _ctx.StringValue("ListRamRoles.Result["+ i +"].template_id");
				resultItem.Assumed = _ctx.BooleanValue("ListRamRoles.Result["+ i +"].assumed");

				listRamRolesResponse_result.Add(resultItem);
			}
			listRamRolesResponse.Result = listRamRolesResponse_result;
        
			return listRamRolesResponse;
        }
    }
}
