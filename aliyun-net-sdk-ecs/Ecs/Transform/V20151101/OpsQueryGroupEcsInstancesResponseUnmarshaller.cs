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
using Aliyun.Acs.Ecs.Model.V20151101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20151101
{
    public class OpsQueryGroupEcsInstancesResponseUnmarshaller
    {
        public static OpsQueryGroupEcsInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			OpsQueryGroupEcsInstancesResponse opsQueryGroupEcsInstancesResponse = new OpsQueryGroupEcsInstancesResponse();

			opsQueryGroupEcsInstancesResponse.HttpResponse = context.HttpResponse;
			opsQueryGroupEcsInstancesResponse.RequestId = context.StringValue("OpsQueryGroupEcsInstances.RequestId");
			opsQueryGroupEcsInstancesResponse.TotalCount = context.IntegerValue("OpsQueryGroupEcsInstances.TotalCount");
			opsQueryGroupEcsInstancesResponse.PageNo = context.IntegerValue("OpsQueryGroupEcsInstances.PageNo");
			opsQueryGroupEcsInstancesResponse.PageSize = context.IntegerValue("OpsQueryGroupEcsInstances.PageSize");

			List<string> ecsInstances = new List<string>();
			for (int i = 0; i < context.Length("OpsQueryGroupEcsInstances.EcsInstances.Length"); i++) {
				ecsInstances.Add(context.StringValue("OpsQueryGroupEcsInstances.EcsInstances["+ i +"]"));
			}
			opsQueryGroupEcsInstancesResponse.EcsInstances = ecsInstances;
        
			return opsQueryGroupEcsInstancesResponse;
        }
    }
}