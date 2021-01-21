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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DisableActivationResponseUnmarshaller
    {
        public static DisableActivationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DisableActivationResponse disableActivationResponse = new DisableActivationResponse();

			disableActivationResponse.HttpResponse = _ctx.HttpResponse;
			disableActivationResponse.RequestId = _ctx.StringValue("DisableActivation.RequestId");

			DisableActivationResponse.DisableActivation_Activation activation = new DisableActivationResponse.DisableActivation_Activation();
			activation.ActivationId = _ctx.StringValue("DisableActivation.Activation.ActivationId");
			activation.InstanceName = _ctx.StringValue("DisableActivation.Activation.InstanceName");
			activation.Description = _ctx.StringValue("DisableActivation.Activation.Description");
			activation.InstanceCount = _ctx.IntegerValue("DisableActivation.Activation.InstanceCount");
			activation.TimeToLiveInHours = _ctx.LongValue("DisableActivation.Activation.TimeToLiveInHours");
			activation.IpAddressRange = _ctx.StringValue("DisableActivation.Activation.IpAddressRange");
			activation.RegisteredCount = _ctx.IntegerValue("DisableActivation.Activation.RegisteredCount");
			activation.DeregisteredCount = _ctx.IntegerValue("DisableActivation.Activation.DeregisteredCount");
			activation.Disabled = _ctx.BooleanValue("DisableActivation.Activation.Disabled");
			activation.CreationTime = _ctx.StringValue("DisableActivation.Activation.CreationTime");
			disableActivationResponse.Activation = activation;
        
			return disableActivationResponse;
        }
    }
}
