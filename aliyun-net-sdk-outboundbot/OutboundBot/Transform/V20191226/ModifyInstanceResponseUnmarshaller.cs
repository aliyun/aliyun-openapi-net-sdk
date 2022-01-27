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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class ModifyInstanceResponseUnmarshaller
    {
        public static ModifyInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyInstanceResponse modifyInstanceResponse = new ModifyInstanceResponse();

			modifyInstanceResponse.HttpResponse = _ctx.HttpResponse;
			modifyInstanceResponse.Code = _ctx.StringValue("ModifyInstance.Code");
			modifyInstanceResponse.HttpStatusCode = _ctx.IntegerValue("ModifyInstance.HttpStatusCode");
			modifyInstanceResponse.Message = _ctx.StringValue("ModifyInstance.Message");
			modifyInstanceResponse.RequestId = _ctx.StringValue("ModifyInstance.RequestId");
			modifyInstanceResponse.Success = _ctx.BooleanValue("ModifyInstance.Success");

			ModifyInstanceResponse.ModifyInstance_Instance instance = new ModifyInstanceResponse.ModifyInstance_Instance();
			instance.CallCenterInstanceId = _ctx.StringValue("ModifyInstance.Instance.CallCenterInstanceId");
			instance.CreationTime = _ctx.LongValue("ModifyInstance.Instance.CreationTime");
			instance.InstanceDescription = _ctx.StringValue("ModifyInstance.Instance.InstanceDescription");
			instance.InstanceId = _ctx.StringValue("ModifyInstance.Instance.InstanceId");
			instance.InstanceName = _ctx.StringValue("ModifyInstance.Instance.InstanceName");
			instance.MaxConcurrentConversation = _ctx.IntegerValue("ModifyInstance.Instance.MaxConcurrentConversation");
			instance.NluServiceType = _ctx.StringValue("ModifyInstance.Instance.NluServiceType");
			instance.Owner = _ctx.StringValue("ModifyInstance.Instance.Owner");
			instance.CreatorId = _ctx.LongValue("ModifyInstance.Instance.CreatorId");
			instance.CreatorName = _ctx.StringValue("ModifyInstance.Instance.CreatorName");
			instance.OwnerName = _ctx.StringValue("ModifyInstance.Instance.OwnerName");

			ModifyInstanceResponse.ModifyInstance_Instance.ModifyInstance_NluProfile nluProfile = new ModifyInstanceResponse.ModifyInstance_Instance.ModifyInstance_NluProfile();
			nluProfile.AccessKey = _ctx.StringValue("ModifyInstance.Instance.NluProfile.AccessKey");
			nluProfile.Endpoint = _ctx.StringValue("ModifyInstance.Instance.NluProfile.Endpoint");
			nluProfile.SecretKey = _ctx.StringValue("ModifyInstance.Instance.NluProfile.SecretKey");
			instance.NluProfile = nluProfile;
			modifyInstanceResponse.Instance = instance;
        
			return modifyInstanceResponse;
        }
    }
}
