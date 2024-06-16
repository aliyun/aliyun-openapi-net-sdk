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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class MiguLivePullToPushStatusResponseUnmarshaller
    {
        public static MiguLivePullToPushStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			MiguLivePullToPushStatusResponse miguLivePullToPushStatusResponse = new MiguLivePullToPushStatusResponse();

			miguLivePullToPushStatusResponse.HttpResponse = _ctx.HttpResponse;
			miguLivePullToPushStatusResponse.Code = _ctx.StringValue("MiguLivePullToPushStatus.code");
			miguLivePullToPushStatusResponse.Message = _ctx.StringValue("MiguLivePullToPushStatus.message");
			miguLivePullToPushStatusResponse.RequestId = _ctx.StringValue("MiguLivePullToPushStatus.requestId");
			miguLivePullToPushStatusResponse.Timestamp = _ctx.StringValue("MiguLivePullToPushStatus.timestamp");

			MiguLivePullToPushStatusResponse.MiguLivePullToPushStatus_Data data = new MiguLivePullToPushStatusResponse.MiguLivePullToPushStatus_Data();
			data.Message = _ctx.StringValue("MiguLivePullToPushStatus.Data.message");
			data.Status = _ctx.StringValue("MiguLivePullToPushStatus.Data.status");
			miguLivePullToPushStatusResponse.Data = data;
        
			return miguLivePullToPushStatusResponse;
        }
    }
}
