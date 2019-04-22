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
        public static QueryServerLockResponse Unmarshall(UnmarshallerContext context)
        {
			QueryServerLockResponse queryServerLockResponse = new QueryServerLockResponse();

			queryServerLockResponse.HttpResponse = context.HttpResponse;
			queryServerLockResponse.RequestId = context.StringValue("QueryServerLock.RequestId");
			queryServerLockResponse.GmtCreate = context.StringValue("QueryServerLock.GmtCreate");
			queryServerLockResponse.GmtModified = context.StringValue("QueryServerLock.GmtModified");
			queryServerLockResponse.UserId = context.StringValue("QueryServerLock.UserId");
			queryServerLockResponse.DomainName = context.StringValue("QueryServerLock.DomainName");
			queryServerLockResponse.DomainInstanceId = context.StringValue("QueryServerLock.DomainInstanceId");
			queryServerLockResponse.LockProductId = context.StringValue("QueryServerLock.LockProductId");
			queryServerLockResponse.StartDate = context.StringValue("QueryServerLock.StartDate");
			queryServerLockResponse.ExpireDate = context.StringValue("QueryServerLock.ExpireDate");
			queryServerLockResponse.LockInstanceId = context.StringValue("QueryServerLock.LockInstanceId");
			queryServerLockResponse.ServerLockStatus = context.IntegerValue("QueryServerLock.ServerLockStatus");
        
			return queryServerLockResponse;
        }
    }
}
