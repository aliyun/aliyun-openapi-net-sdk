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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Sas_api.Model.V20170705;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Sas_api.Transform.V20170705
{
    public class RenewInstanceResponseUnmarshaller
    {
        public static RenewInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			RenewInstanceResponse renewInstanceResponse = new RenewInstanceResponse();

			renewInstanceResponse.HttpResponse = context.HttpResponse;
			renewInstanceResponse.Code = context.StringValue("RenewInstance.Code");
			renewInstanceResponse.Message = context.StringValue("RenewInstance.Message");
			renewInstanceResponse.OrderId = context.StringValue("RenewInstance.OrderId");
			renewInstanceResponse.InstanceId = context.StringValue("RenewInstance.InstanceId");
			renewInstanceResponse.RequestId = context.StringValue("RenewInstance.RequestId");

			List<string> renewInstanceResponse_instanceIds = new List<string>();
			for (int i = 0; i < context.Length("RenewInstance.InstanceIds.Length"); i++) {
				renewInstanceResponse_instanceIds.Add(context.StringValue("RenewInstance.InstanceIds["+ i +"]"));
			}
			renewInstanceResponse.InstanceIds = renewInstanceResponse_instanceIds;
        
			return renewInstanceResponse;
        }
    }
}