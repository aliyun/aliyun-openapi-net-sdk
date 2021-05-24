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
    public class RemoveUsersResponseUnmarshaller
    {
        public static RemoveUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RemoveUsersResponse removeUsersResponse = new RemoveUsersResponse();

			removeUsersResponse.HttpResponse = _ctx.HttpResponse;
			removeUsersResponse.Code = _ctx.StringValue("RemoveUsers.Code");
			removeUsersResponse.HttpStatusCode = _ctx.IntegerValue("RemoveUsers.HttpStatusCode");
			removeUsersResponse.Message = _ctx.StringValue("RemoveUsers.Message");
			removeUsersResponse.RequestId = _ctx.StringValue("RemoveUsers.RequestId");

			List<string> removeUsersResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("RemoveUsers.Params.Length"); i++) {
				removeUsersResponse_params.Add(_ctx.StringValue("RemoveUsers.Params["+ i +"]"));
			}
			removeUsersResponse._Params = removeUsersResponse_params;
        
			return removeUsersResponse;
        }
    }
}
