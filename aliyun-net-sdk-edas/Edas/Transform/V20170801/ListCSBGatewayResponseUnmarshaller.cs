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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class ListCSBGatewayResponseUnmarshaller
    {
        public static ListCSBGatewayResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCSBGatewayResponse listCSBGatewayResponse = new ListCSBGatewayResponse();

			listCSBGatewayResponse.HttpResponse = _ctx.HttpResponse;
			listCSBGatewayResponse.Code = _ctx.IntegerValue("ListCSBGateway.Code");
			listCSBGatewayResponse.Message = _ctx.StringValue("ListCSBGateway.Message");
			listCSBGatewayResponse.RequestId = _ctx.StringValue("ListCSBGateway.RequestId");

			List<ListCSBGatewayResponse.ListCSBGateway_FindGatewaysResponseBodyData> listCSBGatewayResponse_data = new List<ListCSBGatewayResponse.ListCSBGateway_FindGatewaysResponseBodyData>();
			for (int i = 0; i < _ctx.Length("ListCSBGateway.Data.Length"); i++) {
				ListCSBGatewayResponse.ListCSBGateway_FindGatewaysResponseBodyData findGatewaysResponseBodyData = new ListCSBGatewayResponse.ListCSBGateway_FindGatewaysResponseBodyData();
				findGatewaysResponseBodyData.Id = _ctx.LongValue("ListCSBGateway.Data["+ i +"].Id");
				findGatewaysResponseBodyData.Name = _ctx.StringValue("ListCSBGateway.Data["+ i +"].Name");
				findGatewaysResponseBodyData.GatewayType = _ctx.StringValue("ListCSBGateway.Data["+ i +"].GatewayType");

				listCSBGatewayResponse_data.Add(findGatewaysResponseBodyData);
			}
			listCSBGatewayResponse.Data = listCSBGatewayResponse_data;
        
			return listCSBGatewayResponse;
        }
    }
}
