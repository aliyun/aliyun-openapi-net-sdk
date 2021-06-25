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
    public class CreateInstanceResponseUnmarshaller
    {
        public static CreateInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateInstanceResponse createInstanceResponse = new CreateInstanceResponse();

			createInstanceResponse.HttpResponse = _ctx.HttpResponse;
			createInstanceResponse.Code = _ctx.StringValue("CreateInstance.Code");
			createInstanceResponse.HttpStatusCode = _ctx.IntegerValue("CreateInstance.HttpStatusCode");
			createInstanceResponse.Message = _ctx.StringValue("CreateInstance.Message");
			createInstanceResponse.RequestId = _ctx.StringValue("CreateInstance.RequestId");
			createInstanceResponse.Success = _ctx.BooleanValue("CreateInstance.Success");

			CreateInstanceResponse.CreateInstance_Instance instance = new CreateInstanceResponse.CreateInstance_Instance();
			instance.CallCenterInstanceId = _ctx.StringValue("CreateInstance.Instance.CallCenterInstanceId");
			instance.CreationTime = _ctx.LongValue("CreateInstance.Instance.CreationTime");
			instance.InstanceDescription = _ctx.StringValue("CreateInstance.Instance.InstanceDescription");
			instance.InstanceId = _ctx.StringValue("CreateInstance.Instance.InstanceId");
			instance.InstanceName = _ctx.StringValue("CreateInstance.Instance.InstanceName");
			instance.MaxConcurrentConversation = _ctx.IntegerValue("CreateInstance.Instance.MaxConcurrentConversation");
			instance.NluServiceType = _ctx.StringValue("CreateInstance.Instance.NluServiceType");
			instance.Owner = _ctx.StringValue("CreateInstance.Instance.Owner");
			instance.CreatorId = _ctx.LongValue("CreateInstance.Instance.CreatorId");
			instance.CreatorName = _ctx.StringValue("CreateInstance.Instance.CreatorName");
			instance.OwnerName = _ctx.StringValue("CreateInstance.Instance.OwnerName");
			instance.ResourceGroupId = _ctx.StringValue("CreateInstance.Instance.ResourceGroupId");

			CreateInstanceResponse.CreateInstance_Instance.CreateInstance_NluProfile nluProfile = new CreateInstanceResponse.CreateInstance_Instance.CreateInstance_NluProfile();
			nluProfile.AccessKey = _ctx.StringValue("CreateInstance.Instance.NluProfile.AccessKey");
			nluProfile.Endpoint = _ctx.StringValue("CreateInstance.Instance.NluProfile.Endpoint");
			nluProfile.SecretKey = _ctx.StringValue("CreateInstance.Instance.NluProfile.SecretKey");
			instance.NluProfile = nluProfile;
			createInstanceResponse.Instance = instance;
        
			return createInstanceResponse;
        }
    }
}
