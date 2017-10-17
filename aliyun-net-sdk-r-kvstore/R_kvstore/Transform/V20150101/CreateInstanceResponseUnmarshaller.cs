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
using Aliyun.Acs.R_kvstore.Model.V20150101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class CreateInstanceResponseUnmarshaller
    {
        public static CreateInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			CreateInstanceResponse createInstanceResponse = new CreateInstanceResponse();

			createInstanceResponse.HttpResponse = context.HttpResponse;
			createInstanceResponse.RequestId = context.StringValue("CreateInstance.RequestId");
			createInstanceResponse.InstanceId = context.StringValue("CreateInstance.InstanceId");
			createInstanceResponse.InstanceName = context.StringValue("CreateInstance.InstanceName");
			createInstanceResponse.ConnectionDomain = context.StringValue("CreateInstance.ConnectionDomain");
			createInstanceResponse.Port = context.IntegerValue("CreateInstance.Port");
			createInstanceResponse.UserName = context.StringValue("CreateInstance.UserName");
			createInstanceResponse.InstanceStatus = context.StringValue("CreateInstance.InstanceStatus");
			createInstanceResponse.RegionId = context.StringValue("CreateInstance.RegionId");
			createInstanceResponse.Capacity = context.LongValue("CreateInstance.Capacity");
			createInstanceResponse.QPS = context.LongValue("CreateInstance.QPS");
			createInstanceResponse.Bandwidth = context.LongValue("CreateInstance.Bandwidth");
			createInstanceResponse.Connections = context.LongValue("CreateInstance.Connections");
			createInstanceResponse.ZoneId = context.StringValue("CreateInstance.ZoneId");
			createInstanceResponse.Config = context.StringValue("CreateInstance.Config");
			createInstanceResponse.ChargeType = context.StringValue("CreateInstance.ChargeType");
			createInstanceResponse.EndTime = context.StringValue("CreateInstance.EndTime");
			createInstanceResponse.NodeType = context.StringValue("CreateInstance.NodeType");
			createInstanceResponse.NetworkType = context.StringValue("CreateInstance.NetworkType");
			createInstanceResponse.VpcId = context.StringValue("CreateInstance.VpcId");
			createInstanceResponse.VSwitchId = context.StringValue("CreateInstance.VSwitchId");
			createInstanceResponse.PrivateIpAddr = context.StringValue("CreateInstance.PrivateIpAddr");
        
			return createInstanceResponse;
        }
    }
}