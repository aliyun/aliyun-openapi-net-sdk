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
    public class ListServerLockResponseUnmarshaller
    {
        public static ListServerLockResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListServerLockResponse listServerLockResponse = new ListServerLockResponse();

			listServerLockResponse.HttpResponse = _ctx.HttpResponse;
			listServerLockResponse.RequestId = _ctx.StringValue("ListServerLock.RequestId");
			listServerLockResponse.TotalItemNum = _ctx.IntegerValue("ListServerLock.TotalItemNum");
			listServerLockResponse.CurrentPageNum = _ctx.IntegerValue("ListServerLock.CurrentPageNum");
			listServerLockResponse.TotalPageNum = _ctx.IntegerValue("ListServerLock.TotalPageNum");
			listServerLockResponse.PageSize = _ctx.IntegerValue("ListServerLock.PageSize");
			listServerLockResponse.PrePage = _ctx.BooleanValue("ListServerLock.PrePage");
			listServerLockResponse.NextPage = _ctx.BooleanValue("ListServerLock.NextPage");

			List<ListServerLockResponse.ListServerLock_QueryTransferInResponse> listServerLockResponse_data = new List<ListServerLockResponse.ListServerLock_QueryTransferInResponse>();
			for (int i = 0; i < _ctx.Length("ListServerLock.Data.Length"); i++) {
				ListServerLockResponse.ListServerLock_QueryTransferInResponse queryTransferInResponse = new ListServerLockResponse.ListServerLock_QueryTransferInResponse();
				queryTransferInResponse.GmtCreate = _ctx.StringValue("ListServerLock.Data["+ i +"].GmtCreate");
				queryTransferInResponse.GmtModified = _ctx.StringValue("ListServerLock.Data["+ i +"].GmtModified");
				queryTransferInResponse.UserId = _ctx.StringValue("ListServerLock.Data["+ i +"].UserId");
				queryTransferInResponse.DomainName = _ctx.StringValue("ListServerLock.Data["+ i +"].DomainName");
				queryTransferInResponse.DomainInstanceId = _ctx.StringValue("ListServerLock.Data["+ i +"].DomainInstanceId");
				queryTransferInResponse.LockProductId = _ctx.StringValue("ListServerLock.Data["+ i +"].LockProductId");
				queryTransferInResponse.StartDate = _ctx.StringValue("ListServerLock.Data["+ i +"].StartDate");
				queryTransferInResponse.ExpireDate = _ctx.StringValue("ListServerLock.Data["+ i +"].ExpireDate");
				queryTransferInResponse.LockInstanceId = _ctx.StringValue("ListServerLock.Data["+ i +"].LockInstanceId");
				queryTransferInResponse.ServerLockStatus = _ctx.StringValue("ListServerLock.Data["+ i +"].ServerLockStatus");

				listServerLockResponse_data.Add(queryTransferInResponse);
			}
			listServerLockResponse.Data = listServerLockResponse_data;
        
			return listServerLockResponse;
        }
    }
}
