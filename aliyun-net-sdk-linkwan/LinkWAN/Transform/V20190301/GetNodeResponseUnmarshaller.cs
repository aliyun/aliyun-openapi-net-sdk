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
using Aliyun.Acs.LinkWAN.Model.V20190301;

namespace Aliyun.Acs.LinkWAN.Transform.V20190301
{
    public class GetNodeResponseUnmarshaller
    {
        public static GetNodeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetNodeResponse getNodeResponse = new GetNodeResponse();

			getNodeResponse.HttpResponse = _ctx.HttpResponse;
			getNodeResponse.RequestId = _ctx.StringValue("GetNode.RequestId");
			getNodeResponse.Success = _ctx.BooleanValue("GetNode.Success");

			GetNodeResponse.GetNode_Data data = new GetNodeResponse.GetNode_Data();
			data.DevEui = _ctx.StringValue("GetNode.Data.DevEui");
			data.DevAddr = _ctx.StringValue("GetNode.Data.DevAddr");
			data.ClassMode = _ctx.StringValue("GetNode.Data.ClassMode");
			data.LastJoinMillis = _ctx.LongValue("GetNode.Data.LastJoinMillis");
			data.BoundMillis = _ctx.LongValue("GetNode.Data.BoundMillis");
			data.AuthTypes = _ctx.StringValue("GetNode.Data.AuthTypes");
			getNodeResponse.Data = data;
        
			return getNodeResponse;
        }
    }
}
