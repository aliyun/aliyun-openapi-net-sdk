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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class GetTurnServerListResponseUnmarshaller
    {
        public static GetTurnServerListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTurnServerListResponse getTurnServerListResponse = new GetTurnServerListResponse();

			getTurnServerListResponse.HttpResponse = _ctx.HttpResponse;
			getTurnServerListResponse.HttpStatusCode = _ctx.IntegerValue("GetTurnServerList.HttpStatusCode");
			getTurnServerListResponse.Code = _ctx.StringValue("GetTurnServerList.Code");
			getTurnServerListResponse.Message = _ctx.StringValue("GetTurnServerList.Message");
			getTurnServerListResponse.Data = _ctx.StringValue("GetTurnServerList.Data");
			getTurnServerListResponse.RequestId = _ctx.StringValue("GetTurnServerList.RequestId");

			List<string> getTurnServerListResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("GetTurnServerList.Params.Length"); i++) {
				getTurnServerListResponse_params.Add(_ctx.StringValue("GetTurnServerList.Params["+ i +"]"));
			}
			getTurnServerListResponse._Params = getTurnServerListResponse_params;
        
			return getTurnServerListResponse;
        }
    }
}
