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
using Aliyun.Acs.lto.Model.V20210707;

namespace Aliyun.Acs.lto.Transform.V20210707
{
    public class ListBaaSAntChainPeerResponseUnmarshaller
    {
        public static ListBaaSAntChainPeerResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListBaaSAntChainPeerResponse listBaaSAntChainPeerResponse = new ListBaaSAntChainPeerResponse();

			listBaaSAntChainPeerResponse.HttpResponse = _ctx.HttpResponse;
			listBaaSAntChainPeerResponse.Code = _ctx.StringValue("ListBaaSAntChainPeer.Code");
			listBaaSAntChainPeerResponse.HttpStatusCode = _ctx.IntegerValue("ListBaaSAntChainPeer.HttpStatusCode");
			listBaaSAntChainPeerResponse.Message = _ctx.StringValue("ListBaaSAntChainPeer.Message");
			listBaaSAntChainPeerResponse.RequestId = _ctx.StringValue("ListBaaSAntChainPeer.RequestId");
			listBaaSAntChainPeerResponse.Success = _ctx.BooleanValue("ListBaaSAntChainPeer.Success");

			List<ListBaaSAntChainPeerResponse.ListBaaSAntChainPeer_BaaSAntChainPeerInfo> listBaaSAntChainPeerResponse_data = new List<ListBaaSAntChainPeerResponse.ListBaaSAntChainPeer_BaaSAntChainPeerInfo>();
			for (int i = 0; i < _ctx.Length("ListBaaSAntChainPeer.Data.Length"); i++) {
				ListBaaSAntChainPeerResponse.ListBaaSAntChainPeer_BaaSAntChainPeerInfo baaSAntChainPeerInfo = new ListBaaSAntChainPeerResponse.ListBaaSAntChainPeer_BaaSAntChainPeerInfo();
				baaSAntChainPeerInfo.NodeName = _ctx.StringValue("ListBaaSAntChainPeer.Data["+ i +"].NodeName");

				listBaaSAntChainPeerResponse_data.Add(baaSAntChainPeerInfo);
			}
			listBaaSAntChainPeerResponse.Data = listBaaSAntChainPeerResponse_data;
        
			return listBaaSAntChainPeerResponse;
        }
    }
}
