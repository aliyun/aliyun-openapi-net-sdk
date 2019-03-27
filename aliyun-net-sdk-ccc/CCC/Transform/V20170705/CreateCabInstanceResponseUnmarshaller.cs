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
    public class CreateCabInstanceResponseUnmarshaller
    {
        public static CreateCabInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			CreateCabInstanceResponse createCabInstanceResponse = new CreateCabInstanceResponse();

			createCabInstanceResponse.HttpResponse = context.HttpResponse;
			createCabInstanceResponse.RequestId = context.StringValue("CreateCabInstance.RequestId");
			createCabInstanceResponse.Success = context.BooleanValue("CreateCabInstance.Success");
			createCabInstanceResponse.Code = context.StringValue("CreateCabInstance.Code");
			createCabInstanceResponse.Message = context.StringValue("CreateCabInstance.Message");
			createCabInstanceResponse.HttpStatusCode = context.IntegerValue("CreateCabInstance.HttpStatusCode");

			CreateCabInstanceResponse.CreateCabInstance_Instance instance = new CreateCabInstanceResponse.CreateCabInstance_Instance();
			instance.InstanceId = context.StringValue("CreateCabInstance.Instance.InstanceId");
			instance.InstanceName = context.StringValue("CreateCabInstance.Instance.InstanceName");
			instance.InstanceDescription = context.StringValue("CreateCabInstance.Instance.InstanceDescription");
			instance.MaxConcurrentConversation = context.IntegerValue("CreateCabInstance.Instance.MaxConcurrentConversation");
			instance.Owner = context.StringValue("CreateCabInstance.Instance.Owner");
			instance.CreationTime = context.LongValue("CreateCabInstance.Instance.CreationTime");
			instance.CallCenterInstanceId = context.StringValue("CreateCabInstance.Instance.CallCenterInstanceId");
			createCabInstanceResponse.Instance = instance;
        
			return createCabInstanceResponse;
        }
    }
}
