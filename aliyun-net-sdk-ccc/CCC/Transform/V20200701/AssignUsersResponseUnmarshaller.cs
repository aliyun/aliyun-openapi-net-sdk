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
    public class AssignUsersResponseUnmarshaller
    {
        public static AssignUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AssignUsersResponse assignUsersResponse = new AssignUsersResponse();

			assignUsersResponse.HttpResponse = _ctx.HttpResponse;
			assignUsersResponse.Code = _ctx.StringValue("AssignUsers.Code");
			assignUsersResponse.Data = _ctx.StringValue("AssignUsers.Data");
			assignUsersResponse.HttpStatusCode = _ctx.IntegerValue("AssignUsers.HttpStatusCode");
			assignUsersResponse.Message = _ctx.StringValue("AssignUsers.Message");
			assignUsersResponse.RequestId = _ctx.StringValue("AssignUsers.RequestId");
			assignUsersResponse.Sync = _ctx.StringValue("AssignUsers.Sync");
			assignUsersResponse.WorkflowId = _ctx.StringValue("AssignUsers.WorkflowId");
        
			return assignUsersResponse;
        }
    }
}
