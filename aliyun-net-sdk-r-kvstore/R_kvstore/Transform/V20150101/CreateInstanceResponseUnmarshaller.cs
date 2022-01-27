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
    public class CreateInstanceResponseUnmarshaller
    {
        public static CreateInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateInstanceResponse createInstanceResponse = new CreateInstanceResponse();

			createInstanceResponse.HttpResponse = _ctx.HttpResponse;
			createInstanceResponse.VpcId = _ctx.StringValue("CreateInstance.VpcId");
			createInstanceResponse.QPS = _ctx.LongValue("CreateInstance.QPS");
			createInstanceResponse.Capacity = _ctx.LongValue("CreateInstance.Capacity");
			createInstanceResponse.ConnectionDomain = _ctx.StringValue("CreateInstance.ConnectionDomain");
			createInstanceResponse.ChargeType = _ctx.StringValue("CreateInstance.ChargeType");
			createInstanceResponse.NetworkType = _ctx.StringValue("CreateInstance.NetworkType");
			createInstanceResponse.InstanceId = _ctx.StringValue("CreateInstance.InstanceId");
			createInstanceResponse.Port = _ctx.IntegerValue("CreateInstance.Port");
			createInstanceResponse.Config = _ctx.StringValue("CreateInstance.Config");
			createInstanceResponse.RegionId = _ctx.StringValue("CreateInstance.RegionId");
			createInstanceResponse.EndTime = _ctx.StringValue("CreateInstance.EndTime");
			createInstanceResponse.VSwitchId = _ctx.StringValue("CreateInstance.VSwitchId");
			createInstanceResponse.RequestId = _ctx.StringValue("CreateInstance.RequestId");
			createInstanceResponse.NodeType = _ctx.StringValue("CreateInstance.NodeType");
			createInstanceResponse.Connections = _ctx.LongValue("CreateInstance.Connections");
			createInstanceResponse.Bandwidth = _ctx.LongValue("CreateInstance.Bandwidth");
			createInstanceResponse.InstanceName = _ctx.StringValue("CreateInstance.InstanceName");
			createInstanceResponse.ZoneId = _ctx.StringValue("CreateInstance.ZoneId");
			createInstanceResponse.InstanceStatus = _ctx.StringValue("CreateInstance.InstanceStatus");
			createInstanceResponse.PrivateIpAddr = _ctx.StringValue("CreateInstance.PrivateIpAddr");
			createInstanceResponse.UserName = _ctx.StringValue("CreateInstance.UserName");
        
			return createInstanceResponse;
        }
    }
}
