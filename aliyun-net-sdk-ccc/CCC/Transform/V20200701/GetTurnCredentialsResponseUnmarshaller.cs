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
    public class GetTurnCredentialsResponseUnmarshaller
    {
        public static GetTurnCredentialsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTurnCredentialsResponse getTurnCredentialsResponse = new GetTurnCredentialsResponse();

			getTurnCredentialsResponse.HttpResponse = _ctx.HttpResponse;
			getTurnCredentialsResponse.Code = _ctx.StringValue("GetTurnCredentials.Code");
			getTurnCredentialsResponse.HttpStatusCode = _ctx.IntegerValue("GetTurnCredentials.HttpStatusCode");
			getTurnCredentialsResponse.Message = _ctx.StringValue("GetTurnCredentials.Message");
			getTurnCredentialsResponse.RequestId = _ctx.StringValue("GetTurnCredentials.RequestId");

			List<string> getTurnCredentialsResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("GetTurnCredentials.Params.Length"); i++) {
				getTurnCredentialsResponse_params.Add(_ctx.StringValue("GetTurnCredentials.Params["+ i +"]"));
			}
			getTurnCredentialsResponse._Params = getTurnCredentialsResponse_params;

			GetTurnCredentialsResponse.GetTurnCredentials_Data data = new GetTurnCredentialsResponse.GetTurnCredentials_Data();
			data.Password = _ctx.StringValue("GetTurnCredentials.Data.Password");
			data.UserName = _ctx.StringValue("GetTurnCredentials.Data.UserName");
			getTurnCredentialsResponse.Data = data;
        
			return getTurnCredentialsResponse;
        }
    }
}
