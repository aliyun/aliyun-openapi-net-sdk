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
    public class DeleteActivationResponseUnmarshaller
    {
        public static DeleteActivationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteActivationResponse deleteActivationResponse = new DeleteActivationResponse();

			deleteActivationResponse.HttpResponse = _ctx.HttpResponse;
			deleteActivationResponse.RequestId = _ctx.StringValue("DeleteActivation.RequestId");

			DeleteActivationResponse.DeleteActivation_Activation activation = new DeleteActivationResponse.DeleteActivation_Activation();
			activation.ActivationId = _ctx.StringValue("DeleteActivation.Activation.ActivationId");
			activation.InstanceName = _ctx.StringValue("DeleteActivation.Activation.InstanceName");
			activation.Description = _ctx.StringValue("DeleteActivation.Activation.Description");
			activation.InstanceCount = _ctx.IntegerValue("DeleteActivation.Activation.InstanceCount");
			activation.TimeToLiveInHours = _ctx.LongValue("DeleteActivation.Activation.TimeToLiveInHours");
			activation.IpAddressRange = _ctx.StringValue("DeleteActivation.Activation.IpAddressRange");
			activation.RegisteredCount = _ctx.IntegerValue("DeleteActivation.Activation.RegisteredCount");
			activation.DeregisteredCount = _ctx.IntegerValue("DeleteActivation.Activation.DeregisteredCount");
			activation.CreationTime = _ctx.StringValue("DeleteActivation.Activation.CreationTime");
			deleteActivationResponse.Activation = activation;
        
			return deleteActivationResponse;
        }
    }
}
