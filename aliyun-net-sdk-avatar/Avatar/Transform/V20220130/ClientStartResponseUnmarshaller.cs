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
using Aliyun.Acs.avatar.Model.V20220130;

namespace Aliyun.Acs.avatar.Transform.V20220130
{
    public class ClientStartResponseUnmarshaller
    {
        public static ClientStartResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ClientStartResponse clientStartResponse = new ClientStartResponse();

			clientStartResponse.HttpResponse = _ctx.HttpResponse;
			clientStartResponse.RequestId = _ctx.StringValue("ClientStart.RequestId");
			clientStartResponse.Success = _ctx.BooleanValue("ClientStart.Success");
			clientStartResponse.Code = _ctx.StringValue("ClientStart.Code");
			clientStartResponse.Message = _ctx.StringValue("ClientStart.Message");

			ClientStartResponse.ClientStart_Data data = new ClientStartResponse.ClientStart_Data();
			data.ImToken = _ctx.StringValue("ClientStart.Data.ImToken");
			clientStartResponse.Data = data;
        
			return clientStartResponse;
        }
    }
}
