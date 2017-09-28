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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Mts.Model.V20140618;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class PlayerAuthResponseUnmarshaller
    {
        public static PlayerAuthResponse Unmarshall(UnmarshallerContext context)
        {
			PlayerAuthResponse playerAuthResponse = new PlayerAuthResponse();

			playerAuthResponse.HttpResponse = context.HttpResponse;
			playerAuthResponse.RequestId = context.StringValue("PlayerAuth.RequestId");
			playerAuthResponse.LogURL = context.StringValue("PlayerAuth.LogURL");

			List<PlayerAuthResponse.Switch> switchList = new List<PlayerAuthResponse.Switch>();
			for (int i = 0; i < context.Length("PlayerAuth.SwitchList.Length"); i++) {
				PlayerAuthResponse.Switch switch_ = new PlayerAuthResponse.Switch();
				switch_.State = context.StringValue("PlayerAuth.SwitchList["+ i +"].State");
				switch_.FunctionId = context.StringValue("PlayerAuth.SwitchList["+ i +"].FunctionId");
				switch_.SwitchId = context.StringValue("PlayerAuth.SwitchList["+ i +"].SwitchId");
				switch_.FunctionName = context.StringValue("PlayerAuth.SwitchList["+ i +"].FunctionName");

				switchList.Add(switch_);
			}
			playerAuthResponse.SwitchList = switchList;
        
			return playerAuthResponse;
        }
    }
}