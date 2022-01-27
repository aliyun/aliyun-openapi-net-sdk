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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class TriggerGatewayRemoteSyncResponseUnmarshaller
    {
        public static TriggerGatewayRemoteSyncResponse Unmarshall(UnmarshallerContext _ctx)
        {
			TriggerGatewayRemoteSyncResponse triggerGatewayRemoteSyncResponse = new TriggerGatewayRemoteSyncResponse();

			triggerGatewayRemoteSyncResponse.HttpResponse = _ctx.HttpResponse;
			triggerGatewayRemoteSyncResponse.Code = _ctx.StringValue("TriggerGatewayRemoteSync.Code");
			triggerGatewayRemoteSyncResponse.Message = _ctx.StringValue("TriggerGatewayRemoteSync.Message");
			triggerGatewayRemoteSyncResponse.RequestId = _ctx.StringValue("TriggerGatewayRemoteSync.RequestId");
			triggerGatewayRemoteSyncResponse.TaskId = _ctx.StringValue("TriggerGatewayRemoteSync.TaskId");
			triggerGatewayRemoteSyncResponse.Success = _ctx.BooleanValue("TriggerGatewayRemoteSync.Success");
        
			return triggerGatewayRemoteSyncResponse;
        }
    }
}
