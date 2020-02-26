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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class CreateDedicatedInstanceResponseUnmarshaller
    {
        public static CreateDedicatedInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			CreateDedicatedInstanceResponse createDedicatedInstanceResponse = new CreateDedicatedInstanceResponse();

			createDedicatedInstanceResponse.HttpResponse = context.HttpResponse;
			createDedicatedInstanceResponse.RequestId = context.StringValue("CreateDedicatedInstance.RequestId");
			createDedicatedInstanceResponse.InstanceId = context.StringValue("CreateDedicatedInstance.InstanceId");
			createDedicatedInstanceResponse.InstanceName = context.StringValue("CreateDedicatedInstance.InstanceName");
			createDedicatedInstanceResponse.ConnectionDomain = context.StringValue("CreateDedicatedInstance.ConnectionDomain");
			createDedicatedInstanceResponse.Port = context.IntegerValue("CreateDedicatedInstance.Port");
			createDedicatedInstanceResponse.UserName = context.StringValue("CreateDedicatedInstance.UserName");
			createDedicatedInstanceResponse.InstanceStatus = context.StringValue("CreateDedicatedInstance.InstanceStatus");
			createDedicatedInstanceResponse.RegionId = context.StringValue("CreateDedicatedInstance.RegionId");
			createDedicatedInstanceResponse.Capacity = context.LongValue("CreateDedicatedInstance.Capacity");
			createDedicatedInstanceResponse.QPS = context.StringValue("CreateDedicatedInstance.QPS");
			createDedicatedInstanceResponse.Bandwidth = context.IntegerValue("CreateDedicatedInstance.Bandwidth");
			createDedicatedInstanceResponse.Connections = context.IntegerValue("CreateDedicatedInstance.Connections");
			createDedicatedInstanceResponse.ZoneId = context.StringValue("CreateDedicatedInstance.ZoneId");
			createDedicatedInstanceResponse.Config = context.StringValue("CreateDedicatedInstance.Config");
			createDedicatedInstanceResponse.NodeType = context.StringValue("CreateDedicatedInstance.NodeType");
			createDedicatedInstanceResponse.NetworkType = context.StringValue("CreateDedicatedInstance.NetworkType");
			createDedicatedInstanceResponse.VpcId = context.StringValue("CreateDedicatedInstance.VpcId");
			createDedicatedInstanceResponse.VSwitchId = context.StringValue("CreateDedicatedInstance.VSwitchId");
			createDedicatedInstanceResponse.PrivateIpAddr = context.StringValue("CreateDedicatedInstance.PrivateIpAddr");
        
			return createDedicatedInstanceResponse;
        }
    }
}
