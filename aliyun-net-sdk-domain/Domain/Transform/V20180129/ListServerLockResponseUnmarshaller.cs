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
        public static ListServerLockResponse Unmarshall(UnmarshallerContext context)
        {
			ListServerLockResponse listServerLockResponse = new ListServerLockResponse();

			listServerLockResponse.HttpResponse = context.HttpResponse;
			listServerLockResponse.RequestId = context.StringValue("ListServerLock.RequestId");
			listServerLockResponse.TotalItemNum = context.IntegerValue("ListServerLock.TotalItemNum");
			listServerLockResponse.CurrentPageNum = context.IntegerValue("ListServerLock.CurrentPageNum");
			listServerLockResponse.TotalPageNum = context.IntegerValue("ListServerLock.TotalPageNum");
			listServerLockResponse.PageSize = context.IntegerValue("ListServerLock.PageSize");
			listServerLockResponse.PrePage = context.BooleanValue("ListServerLock.PrePage");
			listServerLockResponse.NextPage = context.BooleanValue("ListServerLock.NextPage");

			List<ListServerLockResponse.ListServerLock_QueryTransferInResponse> listServerLockResponse_data = new List<ListServerLockResponse.ListServerLock_QueryTransferInResponse>();
			for (int i = 0; i < context.Length("ListServerLock.Data.Length"); i++) {
				ListServerLockResponse.ListServerLock_QueryTransferInResponse queryTransferInResponse = new ListServerLockResponse.ListServerLock_QueryTransferInResponse();
				queryTransferInResponse.GmtCreate = context.StringValue("ListServerLock.Data["+ i +"].GmtCreate");
				queryTransferInResponse.GmtModified = context.StringValue("ListServerLock.Data["+ i +"].GmtModified");
				queryTransferInResponse.UserId = context.StringValue("ListServerLock.Data["+ i +"].UserId");
				queryTransferInResponse.DomainName = context.StringValue("ListServerLock.Data["+ i +"].DomainName");
				queryTransferInResponse.DomainInstanceId = context.StringValue("ListServerLock.Data["+ i +"].DomainInstanceId");
				queryTransferInResponse.LockProductId = context.StringValue("ListServerLock.Data["+ i +"].LockProductId");
				queryTransferInResponse.StartDate = context.StringValue("ListServerLock.Data["+ i +"].StartDate");
				queryTransferInResponse.ExpireDate = context.StringValue("ListServerLock.Data["+ i +"].ExpireDate");
				queryTransferInResponse.LockInstanceId = context.StringValue("ListServerLock.Data["+ i +"].LockInstanceId");
				queryTransferInResponse.ServerLockStatus = context.StringValue("ListServerLock.Data["+ i +"].ServerLockStatus");

				listServerLockResponse_data.Add(queryTransferInResponse);
			}
			listServerLockResponse.Data = listServerLockResponse_data;
        
			return listServerLockResponse;
        }
    }
}
