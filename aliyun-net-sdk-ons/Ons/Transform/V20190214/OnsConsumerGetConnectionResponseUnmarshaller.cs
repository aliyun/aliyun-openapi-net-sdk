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
using Aliyun.Acs.Ons.Model.V20190214;

namespace Aliyun.Acs.Ons.Transform.V20190214
{
    public class OnsConsumerGetConnectionResponseUnmarshaller
    {
        public static OnsConsumerGetConnectionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			OnsConsumerGetConnectionResponse onsConsumerGetConnectionResponse = new OnsConsumerGetConnectionResponse();

			onsConsumerGetConnectionResponse.HttpResponse = _ctx.HttpResponse;
			onsConsumerGetConnectionResponse.RequestId = _ctx.StringValue("OnsConsumerGetConnection.RequestId");
			onsConsumerGetConnectionResponse.HelpUrl = _ctx.StringValue("OnsConsumerGetConnection.HelpUrl");

			OnsConsumerGetConnectionResponse.OnsConsumerGetConnection_Data data = new OnsConsumerGetConnectionResponse.OnsConsumerGetConnection_Data();

			List<OnsConsumerGetConnectionResponse.OnsConsumerGetConnection_Data.OnsConsumerGetConnection_ConnectionDo> data_connectionList = new List<OnsConsumerGetConnectionResponse.OnsConsumerGetConnection_Data.OnsConsumerGetConnection_ConnectionDo>();
			for (int i = 0; i < _ctx.Length("OnsConsumerGetConnection.Data.ConnectionList.Length"); i++) {
				OnsConsumerGetConnectionResponse.OnsConsumerGetConnection_Data.OnsConsumerGetConnection_ConnectionDo connectionDo = new OnsConsumerGetConnectionResponse.OnsConsumerGetConnection_Data.OnsConsumerGetConnection_ConnectionDo();
				connectionDo.ClientId = _ctx.StringValue("OnsConsumerGetConnection.Data.ConnectionList["+ i +"].ClientId");
				connectionDo.ClientAddr = _ctx.StringValue("OnsConsumerGetConnection.Data.ConnectionList["+ i +"].ClientAddr");
				connectionDo.Language = _ctx.StringValue("OnsConsumerGetConnection.Data.ConnectionList["+ i +"].Language");
				connectionDo.Version = _ctx.StringValue("OnsConsumerGetConnection.Data.ConnectionList["+ i +"].Version");

				data_connectionList.Add(connectionDo);
			}
			data.ConnectionList = data_connectionList;
			onsConsumerGetConnectionResponse.Data = data;
        
			return onsConsumerGetConnectionResponse;
        }
    }
}
