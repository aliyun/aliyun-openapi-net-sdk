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
using Aliyun.Acs.Domain.Model.V20180129;

namespace Aliyun.Acs.Domain.Transform.V20180129
{
    public class QueryServerLockResponseUnmarshaller
    {
        public static QueryServerLockResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryServerLockResponse queryServerLockResponse = new QueryServerLockResponse();

			queryServerLockResponse.HttpResponse = _ctx.HttpResponse;
			queryServerLockResponse.RequestId = _ctx.StringValue("QueryServerLock.RequestId");
			queryServerLockResponse.GmtCreate = _ctx.StringValue("QueryServerLock.GmtCreate");
			queryServerLockResponse.GmtModified = _ctx.StringValue("QueryServerLock.GmtModified");
			queryServerLockResponse.UserId = _ctx.StringValue("QueryServerLock.UserId");
			queryServerLockResponse.DomainName = _ctx.StringValue("QueryServerLock.DomainName");
			queryServerLockResponse.DomainInstanceId = _ctx.StringValue("QueryServerLock.DomainInstanceId");
			queryServerLockResponse.LockProductId = _ctx.StringValue("QueryServerLock.LockProductId");
			queryServerLockResponse.StartDate = _ctx.StringValue("QueryServerLock.StartDate");
			queryServerLockResponse.ExpireDate = _ctx.StringValue("QueryServerLock.ExpireDate");
			queryServerLockResponse.LockInstanceId = _ctx.StringValue("QueryServerLock.LockInstanceId");
			queryServerLockResponse.ServerLockStatus = _ctx.IntegerValue("QueryServerLock.ServerLockStatus");
        
			return queryServerLockResponse;
        }
    }
}
