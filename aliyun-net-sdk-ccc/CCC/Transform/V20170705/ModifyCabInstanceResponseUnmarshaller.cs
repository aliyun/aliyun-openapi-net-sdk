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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class ModifyCabInstanceResponseUnmarshaller
    {
        public static ModifyCabInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyCabInstanceResponse modifyCabInstanceResponse = new ModifyCabInstanceResponse();

			modifyCabInstanceResponse.HttpResponse = _ctx.HttpResponse;
			modifyCabInstanceResponse.RequestId = _ctx.StringValue("ModifyCabInstance.RequestId");
			modifyCabInstanceResponse.Success = _ctx.BooleanValue("ModifyCabInstance.Success");
			modifyCabInstanceResponse.Code = _ctx.StringValue("ModifyCabInstance.Code");
			modifyCabInstanceResponse.Message = _ctx.StringValue("ModifyCabInstance.Message");
			modifyCabInstanceResponse.HttpStatusCode = _ctx.IntegerValue("ModifyCabInstance.HttpStatusCode");

			ModifyCabInstanceResponse.ModifyCabInstance_Instance instance = new ModifyCabInstanceResponse.ModifyCabInstance_Instance();
			instance.InstanceId = _ctx.StringValue("ModifyCabInstance.Instance.InstanceId");
			instance.InstanceName = _ctx.StringValue("ModifyCabInstance.Instance.InstanceName");
			instance.InstanceDescription = _ctx.StringValue("ModifyCabInstance.Instance.InstanceDescription");
			instance.MaxConcurrentConversation = _ctx.IntegerValue("ModifyCabInstance.Instance.MaxConcurrentConversation");
			instance.Owner = _ctx.StringValue("ModifyCabInstance.Instance.Owner");
			instance.CreationTime = _ctx.LongValue("ModifyCabInstance.Instance.CreationTime");
			instance.CallCenterInstanceId = _ctx.StringValue("ModifyCabInstance.Instance.CallCenterInstanceId");
			modifyCabInstanceResponse.Instance = instance;
        
			return modifyCabInstanceResponse;
        }
    }
}
