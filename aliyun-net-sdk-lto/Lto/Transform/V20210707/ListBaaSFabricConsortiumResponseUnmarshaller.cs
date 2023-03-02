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
    public class ListBaaSFabricConsortiumResponseUnmarshaller
    {
        public static ListBaaSFabricConsortiumResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListBaaSFabricConsortiumResponse listBaaSFabricConsortiumResponse = new ListBaaSFabricConsortiumResponse();

			listBaaSFabricConsortiumResponse.HttpResponse = _ctx.HttpResponse;
			listBaaSFabricConsortiumResponse.Code = _ctx.StringValue("ListBaaSFabricConsortium.Code");
			listBaaSFabricConsortiumResponse.HttpStatusCode = _ctx.IntegerValue("ListBaaSFabricConsortium.HttpStatusCode");
			listBaaSFabricConsortiumResponse.Message = _ctx.StringValue("ListBaaSFabricConsortium.Message");
			listBaaSFabricConsortiumResponse.RequestId = _ctx.StringValue("ListBaaSFabricConsortium.RequestId");
			listBaaSFabricConsortiumResponse.Success = _ctx.BooleanValue("ListBaaSFabricConsortium.Success");

			List<ListBaaSFabricConsortiumResponse.ListBaaSFabricConsortium_BaaSFabricConsortiumInfo> listBaaSFabricConsortiumResponse_data = new List<ListBaaSFabricConsortiumResponse.ListBaaSFabricConsortium_BaaSFabricConsortiumInfo>();
			for (int i = 0; i < _ctx.Length("ListBaaSFabricConsortium.Data.Length"); i++) {
				ListBaaSFabricConsortiumResponse.ListBaaSFabricConsortium_BaaSFabricConsortiumInfo baaSFabricConsortiumInfo = new ListBaaSFabricConsortiumResponse.ListBaaSFabricConsortium_BaaSFabricConsortiumInfo();
				baaSFabricConsortiumInfo.BaaSFabricConsortiumId = _ctx.StringValue("ListBaaSFabricConsortium.Data["+ i +"].BaaSFabricConsortiumId");
				baaSFabricConsortiumInfo.BaaSFabricConsortiumName = _ctx.StringValue("ListBaaSFabricConsortium.Data["+ i +"].BaaSFabricConsortiumName");

				listBaaSFabricConsortiumResponse_data.Add(baaSFabricConsortiumInfo);
			}
			listBaaSFabricConsortiumResponse.Data = listBaaSFabricConsortiumResponse_data;
        
			return listBaaSFabricConsortiumResponse;
        }
    }
}
