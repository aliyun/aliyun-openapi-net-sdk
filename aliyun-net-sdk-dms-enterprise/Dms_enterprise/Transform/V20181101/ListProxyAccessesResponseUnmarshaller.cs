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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class ListProxyAccessesResponseUnmarshaller
    {
        public static ListProxyAccessesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListProxyAccessesResponse listProxyAccessesResponse = new ListProxyAccessesResponse();

			listProxyAccessesResponse.HttpResponse = _ctx.HttpResponse;
			listProxyAccessesResponse.RequestId = _ctx.StringValue("ListProxyAccesses.RequestId");
			listProxyAccessesResponse.Success = _ctx.BooleanValue("ListProxyAccesses.Success");
			listProxyAccessesResponse.ErrorMessage = _ctx.StringValue("ListProxyAccesses.ErrorMessage");
			listProxyAccessesResponse.ErrorCode = _ctx.StringValue("ListProxyAccesses.ErrorCode");

			List<ListProxyAccessesResponse.ListProxyAccesses_ProxyAccessListItem> listProxyAccessesResponse_proxyAccessList = new List<ListProxyAccessesResponse.ListProxyAccesses_ProxyAccessListItem>();
			for (int i = 0; i < _ctx.Length("ListProxyAccesses.ProxyAccessList.Length"); i++) {
				ListProxyAccessesResponse.ListProxyAccesses_ProxyAccessListItem proxyAccessListItem = new ListProxyAccessesResponse.ListProxyAccesses_ProxyAccessListItem();
				proxyAccessListItem.ProxyAccessId = _ctx.LongValue("ListProxyAccesses.ProxyAccessList["+ i +"].ProxyAccessId");
				proxyAccessListItem.GmtCreate = _ctx.StringValue("ListProxyAccesses.ProxyAccessList["+ i +"].GmtCreate");
				proxyAccessListItem.AccessId = _ctx.StringValue("ListProxyAccesses.ProxyAccessList["+ i +"].AccessId");
				proxyAccessListItem.OriginInfo = _ctx.StringValue("ListProxyAccesses.ProxyAccessList["+ i +"].OriginInfo");
				proxyAccessListItem.IndepAccount = _ctx.StringValue("ListProxyAccesses.ProxyAccessList["+ i +"].IndepAccount");
				proxyAccessListItem.UserId = _ctx.LongValue("ListProxyAccesses.ProxyAccessList["+ i +"].UserId");
				proxyAccessListItem.UserUid = _ctx.StringValue("ListProxyAccesses.ProxyAccessList["+ i +"].UserUid");
				proxyAccessListItem.UserName = _ctx.StringValue("ListProxyAccesses.ProxyAccessList["+ i +"].UserName");
				proxyAccessListItem.ProxyId = _ctx.LongValue("ListProxyAccesses.ProxyAccessList["+ i +"].ProxyId");
				proxyAccessListItem.InstanceId = _ctx.LongValue("ListProxyAccesses.ProxyAccessList["+ i +"].InstanceId");

				listProxyAccessesResponse_proxyAccessList.Add(proxyAccessListItem);
			}
			listProxyAccessesResponse.ProxyAccessList = listProxyAccessesResponse_proxyAccessList;
        
			return listProxyAccessesResponse;
        }
    }
}
