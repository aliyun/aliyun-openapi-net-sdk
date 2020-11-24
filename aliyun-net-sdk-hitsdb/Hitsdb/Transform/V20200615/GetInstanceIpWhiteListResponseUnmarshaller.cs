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
using Aliyun.Acs.hitsdb.Model.V20200615;

namespace Aliyun.Acs.hitsdb.Transform.V20200615
{
    public class GetInstanceIpWhiteListResponseUnmarshaller
    {
        public static GetInstanceIpWhiteListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetInstanceIpWhiteListResponse getInstanceIpWhiteListResponse = new GetInstanceIpWhiteListResponse();

			getInstanceIpWhiteListResponse.HttpResponse = _ctx.HttpResponse;
			getInstanceIpWhiteListResponse.RequestId = _ctx.StringValue("GetInstanceIpWhiteList.RequestId");
			getInstanceIpWhiteListResponse.InstanceId = _ctx.StringValue("GetInstanceIpWhiteList.InstanceId");

			List<string> getInstanceIpWhiteListResponse_ipList = new List<string>();
			for (int i = 0; i < _ctx.Length("GetInstanceIpWhiteList.IpList.Length"); i++) {
				getInstanceIpWhiteListResponse_ipList.Add(_ctx.StringValue("GetInstanceIpWhiteList.IpList["+ i +"]"));
			}
			getInstanceIpWhiteListResponse.IpList = getInstanceIpWhiteListResponse_ipList;
        
			return getInstanceIpWhiteListResponse;
        }
    }
}
