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
using Aliyun.Acs.idrsservice.Model.V20200630;

namespace Aliyun.Acs.idrsservice.Transform.V20200630
{
    public class JoinLiveResponseUnmarshaller
    {
        public static JoinLiveResponse Unmarshall(UnmarshallerContext _ctx)
        {
			JoinLiveResponse joinLiveResponse = new JoinLiveResponse();

			joinLiveResponse.HttpResponse = _ctx.HttpResponse;
			joinLiveResponse.Code = _ctx.StringValue("JoinLive.Code");
			joinLiveResponse.Message = _ctx.StringValue("JoinLive.Message");
			joinLiveResponse.RequestId = _ctx.StringValue("JoinLive.RequestId");

			JoinLiveResponse.JoinLive_Data data = new JoinLiveResponse.JoinLive_Data();
			data.Code = _ctx.IntegerValue("JoinLive.Data.Code");

			JoinLiveResponse.JoinLive_Data.JoinLive_TokenData tokenData = new JoinLiveResponse.JoinLive_Data.JoinLive_TokenData();
			tokenData.AppId = _ctx.StringValue("JoinLive.Data.TokenData.AppId");
			tokenData.LiveId = _ctx.StringValue("JoinLive.Data.TokenData.LiveId");
			tokenData.Nonce = _ctx.StringValue("JoinLive.Data.TokenData.Nonce");
			tokenData.Timestamp = _ctx.LongValue("JoinLive.Data.TokenData.Timestamp");
			tokenData.Token = _ctx.StringValue("JoinLive.Data.TokenData.Token");
			tokenData.UserId = _ctx.StringValue("JoinLive.Data.TokenData.UserId");

			List<string> tokenData_gslb = new List<string>();
			for (int i = 0; i < _ctx.Length("JoinLive.Data.TokenData.Gslb.Length"); i++) {
				tokenData_gslb.Add(_ctx.StringValue("JoinLive.Data.TokenData.Gslb["+ i +"]"));
			}
			tokenData.Gslb = tokenData_gslb;

			JoinLiveResponse.JoinLive_Data.JoinLive_TokenData.JoinLive_Turn turn = new JoinLiveResponse.JoinLive_Data.JoinLive_TokenData.JoinLive_Turn();
			turn.Password = _ctx.StringValue("JoinLive.Data.TokenData.Turn.Password");
			turn.Username = _ctx.StringValue("JoinLive.Data.TokenData.Turn.Username");
			tokenData.Turn = turn;
			data.TokenData = tokenData;
			joinLiveResponse.Data = data;
        
			return joinLiveResponse;
        }
    }
}
