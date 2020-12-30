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
        public static CreateDedicatedInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateDedicatedInstanceResponse createDedicatedInstanceResponse = new CreateDedicatedInstanceResponse();

			createDedicatedInstanceResponse.HttpResponse = _ctx.HttpResponse;
			createDedicatedInstanceResponse.RequestId = _ctx.StringValue("CreateDedicatedInstance.RequestId");
			createDedicatedInstanceResponse.InstanceId = _ctx.StringValue("CreateDedicatedInstance.InstanceId");
			createDedicatedInstanceResponse.InstanceName = _ctx.StringValue("CreateDedicatedInstance.InstanceName");
			createDedicatedInstanceResponse.ConnectionDomain = _ctx.StringValue("CreateDedicatedInstance.ConnectionDomain");
			createDedicatedInstanceResponse.Port = _ctx.IntegerValue("CreateDedicatedInstance.Port");
			createDedicatedInstanceResponse.UserName = _ctx.StringValue("CreateDedicatedInstance.UserName");
			createDedicatedInstanceResponse.InstanceStatus = _ctx.StringValue("CreateDedicatedInstance.InstanceStatus");
			createDedicatedInstanceResponse.RegionId = _ctx.StringValue("CreateDedicatedInstance.RegionId");
			createDedicatedInstanceResponse.Capacity = _ctx.LongValue("CreateDedicatedInstance.Capacity");
			createDedicatedInstanceResponse.QPS = _ctx.StringValue("CreateDedicatedInstance.QPS");
			createDedicatedInstanceResponse.Bandwidth = _ctx.IntegerValue("CreateDedicatedInstance.Bandwidth");
			createDedicatedInstanceResponse.Connections = _ctx.IntegerValue("CreateDedicatedInstance.Connections");
			createDedicatedInstanceResponse.ZoneId = _ctx.StringValue("CreateDedicatedInstance.ZoneId");
			createDedicatedInstanceResponse.Config = _ctx.StringValue("CreateDedicatedInstance.Config");
			createDedicatedInstanceResponse.NodeType = _ctx.StringValue("CreateDedicatedInstance.NodeType");
			createDedicatedInstanceResponse.NetworkType = _ctx.StringValue("CreateDedicatedInstance.NetworkType");
			createDedicatedInstanceResponse.VpcId = _ctx.StringValue("CreateDedicatedInstance.VpcId");
			createDedicatedInstanceResponse.VSwitchId = _ctx.StringValue("CreateDedicatedInstance.VSwitchId");
			createDedicatedInstanceResponse.PrivateIpAddr = _ctx.StringValue("CreateDedicatedInstance.PrivateIpAddr");
        
			return createDedicatedInstanceResponse;
        }
    }
}
