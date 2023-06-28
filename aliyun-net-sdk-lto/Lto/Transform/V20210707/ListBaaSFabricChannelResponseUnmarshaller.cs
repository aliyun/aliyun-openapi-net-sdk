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
    public class ListBaaSFabricChannelResponseUnmarshaller
    {
        public static ListBaaSFabricChannelResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListBaaSFabricChannelResponse listBaaSFabricChannelResponse = new ListBaaSFabricChannelResponse();

			listBaaSFabricChannelResponse.HttpResponse = _ctx.HttpResponse;
			listBaaSFabricChannelResponse.Code = _ctx.StringValue("ListBaaSFabricChannel.Code");
			listBaaSFabricChannelResponse.HttpStatusCode = _ctx.IntegerValue("ListBaaSFabricChannel.HttpStatusCode");
			listBaaSFabricChannelResponse.Message = _ctx.StringValue("ListBaaSFabricChannel.Message");
			listBaaSFabricChannelResponse.RequestId = _ctx.StringValue("ListBaaSFabricChannel.RequestId");
			listBaaSFabricChannelResponse.Success = _ctx.BooleanValue("ListBaaSFabricChannel.Success");

			List<ListBaaSFabricChannelResponse.ListBaaSFabricChannel_BaaSFabricChannelInfo> listBaaSFabricChannelResponse_data = new List<ListBaaSFabricChannelResponse.ListBaaSFabricChannel_BaaSFabricChannelInfo>();
			for (int i = 0; i < _ctx.Length("ListBaaSFabricChannel.Data.Length"); i++) {
				ListBaaSFabricChannelResponse.ListBaaSFabricChannel_BaaSFabricChannelInfo baaSFabricChannelInfo = new ListBaaSFabricChannelResponse.ListBaaSFabricChannel_BaaSFabricChannelInfo();
				baaSFabricChannelInfo.BaaSFabricChannelName = _ctx.StringValue("ListBaaSFabricChannel.Data["+ i +"].BaaSFabricChannelName");
				baaSFabricChannelInfo.BaaSFabricChannelId = _ctx.StringValue("ListBaaSFabricChannel.Data["+ i +"].BaaSFabricChannelId");

				listBaaSFabricChannelResponse_data.Add(baaSFabricChannelInfo);
			}
			listBaaSFabricChannelResponse.Data = listBaaSFabricChannelResponse_data;
        
			return listBaaSFabricChannelResponse;
        }
    }
}
