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
        public static CreateInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			CreateInstanceResponse createInstanceResponse = new CreateInstanceResponse();

			createInstanceResponse.HttpResponse = context.HttpResponse;
			createInstanceResponse.RequestId = context.StringValue("CreateInstance.RequestId");
			createInstanceResponse.Success = context.BooleanValue("CreateInstance.Success");
			createInstanceResponse.Code = context.StringValue("CreateInstance.Code");
			createInstanceResponse.Message = context.StringValue("CreateInstance.Message");
			createInstanceResponse.HttpStatusCode = context.IntegerValue("CreateInstance.HttpStatusCode");

			CreateInstanceResponse.CreateInstance_Instance instance = new CreateInstanceResponse.CreateInstance_Instance();
			instance.InstanceId = context.StringValue("CreateInstance.Instance.InstanceId");
			instance.InstanceName = context.StringValue("CreateInstance.Instance.InstanceName");
			instance.InstanceDescription = context.StringValue("CreateInstance.Instance.InstanceDescription");
			instance.MaxConcurrentConversation = context.IntegerValue("CreateInstance.Instance.MaxConcurrentConversation");
			instance.Owner = context.StringValue("CreateInstance.Instance.Owner");
			instance.CreationTime = context.LongValue("CreateInstance.Instance.CreationTime");
			instance.CallCenterInstanceId = context.StringValue("CreateInstance.Instance.CallCenterInstanceId");
			createInstanceResponse.Instance = instance;
        
			return createInstanceResponse;
        }
    }
}
