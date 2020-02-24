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
        public static ModifyInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyInstanceResponse modifyInstanceResponse = new ModifyInstanceResponse();

			modifyInstanceResponse.HttpResponse = context.HttpResponse;
			modifyInstanceResponse.RequestId = context.StringValue("ModifyInstance.RequestId");
			modifyInstanceResponse.Success = context.BooleanValue("ModifyInstance.Success");
			modifyInstanceResponse.Code = context.StringValue("ModifyInstance.Code");
			modifyInstanceResponse.Message = context.StringValue("ModifyInstance.Message");
			modifyInstanceResponse.HttpStatusCode = context.IntegerValue("ModifyInstance.HttpStatusCode");

			ModifyInstanceResponse.ModifyInstance_Instance instance = new ModifyInstanceResponse.ModifyInstance_Instance();
			instance.InstanceId = context.StringValue("ModifyInstance.Instance.InstanceId");
			instance.InstanceName = context.StringValue("ModifyInstance.Instance.InstanceName");
			instance.InstanceDescription = context.StringValue("ModifyInstance.Instance.InstanceDescription");
			instance.MaxConcurrentConversation = context.IntegerValue("ModifyInstance.Instance.MaxConcurrentConversation");
			instance.Owner = context.StringValue("ModifyInstance.Instance.Owner");
			instance.CreationTime = context.LongValue("ModifyInstance.Instance.CreationTime");
			instance.CallCenterInstanceId = context.StringValue("ModifyInstance.Instance.CallCenterInstanceId");
			modifyInstanceResponse.Instance = instance;
        
			return modifyInstanceResponse;
        }
    }
}
