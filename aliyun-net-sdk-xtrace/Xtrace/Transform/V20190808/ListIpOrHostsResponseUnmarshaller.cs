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
using Aliyun.Acs.xtrace.Model.V20190808;

namespace Aliyun.Acs.xtrace.Transform.V20190808
{
    public class ListIpOrHostsResponseUnmarshaller
    {
        public static ListIpOrHostsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListIpOrHostsResponse listIpOrHostsResponse = new ListIpOrHostsResponse();

			listIpOrHostsResponse.HttpResponse = _ctx.HttpResponse;
			listIpOrHostsResponse.RequestId = _ctx.StringValue("ListIpOrHosts.RequestId");

			List<string> listIpOrHostsResponse_ipNames = new List<string>();
			for (int i = 0; i < _ctx.Length("ListIpOrHosts.IpNames.Length"); i++) {
				listIpOrHostsResponse_ipNames.Add(_ctx.StringValue("ListIpOrHosts.IpNames["+ i +"]"));
			}
			listIpOrHostsResponse.IpNames = listIpOrHostsResponse_ipNames;
        
			return listIpOrHostsResponse;
        }
    }
}
