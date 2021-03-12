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
    public class CreateTairInstanceResponseUnmarshaller
    {
        public static CreateTairInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateTairInstanceResponse createTairInstanceResponse = new CreateTairInstanceResponse();

			createTairInstanceResponse.HttpResponse = _ctx.HttpResponse;
			createTairInstanceResponse.RequestId = _ctx.StringValue("CreateTairInstance.RequestId");
			createTairInstanceResponse.InstanceId = _ctx.StringValue("CreateTairInstance.InstanceId");
			createTairInstanceResponse.InstanceName = _ctx.StringValue("CreateTairInstance.InstanceName");
			createTairInstanceResponse.ConnectionDomain = _ctx.StringValue("CreateTairInstance.ConnectionDomain");
			createTairInstanceResponse.Port = _ctx.IntegerValue("CreateTairInstance.Port");
			createTairInstanceResponse.InstanceStatus = _ctx.StringValue("CreateTairInstance.InstanceStatus");
			createTairInstanceResponse.RegionId = _ctx.StringValue("CreateTairInstance.RegionId");
			createTairInstanceResponse.QPS = _ctx.LongValue("CreateTairInstance.QPS");
			createTairInstanceResponse.Bandwidth = _ctx.LongValue("CreateTairInstance.Bandwidth");
			createTairInstanceResponse.Connections = _ctx.LongValue("CreateTairInstance.Connections");
			createTairInstanceResponse.ZoneId = _ctx.StringValue("CreateTairInstance.ZoneId");
			createTairInstanceResponse.Config = _ctx.StringValue("CreateTairInstance.Config");
			createTairInstanceResponse.ChargeType = _ctx.StringValue("CreateTairInstance.ChargeType");
			createTairInstanceResponse.TaskId = _ctx.StringValue("CreateTairInstance.TaskId");
        
			return createTairInstanceResponse;
        }
    }
}
