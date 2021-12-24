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
    public class SwitchCSGClientsReverseSyncConfigurationResponseUnmarshaller
    {
        public static SwitchCSGClientsReverseSyncConfigurationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SwitchCSGClientsReverseSyncConfigurationResponse switchCSGClientsReverseSyncConfigurationResponse = new SwitchCSGClientsReverseSyncConfigurationResponse();

			switchCSGClientsReverseSyncConfigurationResponse.HttpResponse = _ctx.HttpResponse;
			switchCSGClientsReverseSyncConfigurationResponse.Code = _ctx.StringValue("SwitchCSGClientsReverseSyncConfiguration.Code");
			switchCSGClientsReverseSyncConfigurationResponse.Message = _ctx.StringValue("SwitchCSGClientsReverseSyncConfiguration.Message");
			switchCSGClientsReverseSyncConfigurationResponse.RequestId = _ctx.StringValue("SwitchCSGClientsReverseSyncConfiguration.RequestId");
			switchCSGClientsReverseSyncConfigurationResponse.TaskId = _ctx.StringValue("SwitchCSGClientsReverseSyncConfiguration.TaskId");
			switchCSGClientsReverseSyncConfigurationResponse.Success = _ctx.BooleanValue("SwitchCSGClientsReverseSyncConfiguration.Success");
        
			return switchCSGClientsReverseSyncConfigurationResponse;
        }
    }
}
