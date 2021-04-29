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
    public class CreateInstancesResponseUnmarshaller
    {
        public static CreateInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateInstancesResponse createInstancesResponse = new CreateInstancesResponse();

			createInstancesResponse.HttpResponse = _ctx.HttpResponse;
			createInstancesResponse.RequestId = _ctx.StringValue("CreateInstances.RequestId");
			createInstancesResponse.OrderId = _ctx.StringValue("CreateInstances.OrderId");

			List<string> createInstancesResponse_instanceIds = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateInstances.InstanceIds.Length"); i++) {
				createInstancesResponse_instanceIds.Add(_ctx.StringValue("CreateInstances.InstanceIds["+ i +"]"));
			}
			createInstancesResponse.InstanceIds = createInstancesResponse_instanceIds;
        
			return createInstancesResponse;
        }
    }
}
