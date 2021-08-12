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
    public class ListProxiesResponseUnmarshaller
    {
        public static ListProxiesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListProxiesResponse listProxiesResponse = new ListProxiesResponse();

			listProxiesResponse.HttpResponse = _ctx.HttpResponse;
			listProxiesResponse.RequestId = _ctx.StringValue("ListProxies.RequestId");
			listProxiesResponse.Success = _ctx.BooleanValue("ListProxies.Success");
			listProxiesResponse.ErrorMessage = _ctx.StringValue("ListProxies.ErrorMessage");
			listProxiesResponse.ErrorCode = _ctx.StringValue("ListProxies.ErrorCode");

			List<ListProxiesResponse.ListProxies_ProxyListItem> listProxiesResponse_proxyList = new List<ListProxiesResponse.ListProxies_ProxyListItem>();
			for (int i = 0; i < _ctx.Length("ListProxies.ProxyList.Length"); i++) {
				ListProxiesResponse.ListProxies_ProxyListItem proxyListItem = new ListProxiesResponse.ListProxies_ProxyListItem();
				proxyListItem.ProxyId = _ctx.LongValue("ListProxies.ProxyList["+ i +"].ProxyId");
				proxyListItem.CreatorId = _ctx.LongValue("ListProxies.ProxyList["+ i +"].CreatorId");
				proxyListItem.CreatorName = _ctx.StringValue("ListProxies.ProxyList["+ i +"].CreatorName");
				proxyListItem.InstanceId = _ctx.LongValue("ListProxies.ProxyList["+ i +"].InstanceId");
				proxyListItem.PrivateEnable = _ctx.BooleanValue("ListProxies.ProxyList["+ i +"].PrivateEnable");
				proxyListItem.PrivateHost = _ctx.StringValue("ListProxies.ProxyList["+ i +"].PrivateHost");
				proxyListItem.PublicEnable = _ctx.BooleanValue("ListProxies.ProxyList["+ i +"].PublicEnable");
				proxyListItem.PublicHost = _ctx.StringValue("ListProxies.ProxyList["+ i +"].PublicHost");
				proxyListItem.MysqlPort = _ctx.IntegerValue("ListProxies.ProxyList["+ i +"].MysqlPort");
				proxyListItem.HttpsPort = _ctx.IntegerValue("ListProxies.ProxyList["+ i +"].HttpsPort");

				listProxiesResponse_proxyList.Add(proxyListItem);
			}
			listProxiesResponse.ProxyList = listProxiesResponse_proxyList;
        
			return listProxiesResponse;
        }
    }
}
