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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeManagedInstancesResponseUnmarshaller
    {
        public static DescribeManagedInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeManagedInstancesResponse describeManagedInstancesResponse = new DescribeManagedInstancesResponse();

			describeManagedInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeManagedInstancesResponse.PageSize = _ctx.LongValue("DescribeManagedInstances.PageSize");
			describeManagedInstancesResponse.RequestId = _ctx.StringValue("DescribeManagedInstances.RequestId");
			describeManagedInstancesResponse.PageNumber = _ctx.LongValue("DescribeManagedInstances.PageNumber");
			describeManagedInstancesResponse.TotalCount = _ctx.LongValue("DescribeManagedInstances.TotalCount");

			List<DescribeManagedInstancesResponse.DescribeManagedInstances_Instance> describeManagedInstancesResponse_instances = new List<DescribeManagedInstancesResponse.DescribeManagedInstances_Instance>();
			for (int i = 0; i < _ctx.Length("DescribeManagedInstances.Instances.Length"); i++) {
				DescribeManagedInstancesResponse.DescribeManagedInstances_Instance instance = new DescribeManagedInstancesResponse.DescribeManagedInstances_Instance();
				instance.LastInvokedTime = _ctx.StringValue("DescribeManagedInstances.Instances["+ i +"].LastInvokedTime");
				instance.Connected = _ctx.BooleanValue("DescribeManagedInstances.Instances["+ i +"].Connected");
				instance.InternetIp = _ctx.StringValue("DescribeManagedInstances.Instances["+ i +"].InternetIp");
				instance.Hostname = _ctx.StringValue("DescribeManagedInstances.Instances["+ i +"].Hostname");
				instance.InstanceId = _ctx.StringValue("DescribeManagedInstances.Instances["+ i +"].InstanceId");
				instance.ActivationId = _ctx.StringValue("DescribeManagedInstances.Instances["+ i +"].ActivationId");
				instance.IntranetIp = _ctx.StringValue("DescribeManagedInstances.Instances["+ i +"].IntranetIp");
				instance.AgentVersion = _ctx.StringValue("DescribeManagedInstances.Instances["+ i +"].AgentVersion");
				instance.RegistrationTime = _ctx.StringValue("DescribeManagedInstances.Instances["+ i +"].RegistrationTime");
				instance.InstanceName = _ctx.StringValue("DescribeManagedInstances.Instances["+ i +"].InstanceName");
				instance.OsType = _ctx.StringValue("DescribeManagedInstances.Instances["+ i +"].OsType");
				instance.OsVersion = _ctx.StringValue("DescribeManagedInstances.Instances["+ i +"].OsVersion");
				instance.InvocationCount = _ctx.LongValue("DescribeManagedInstances.Instances["+ i +"].InvocationCount");
				instance.MachineId = _ctx.StringValue("DescribeManagedInstances.Instances["+ i +"].MachineId");

				describeManagedInstancesResponse_instances.Add(instance);
			}
			describeManagedInstancesResponse.Instances = describeManagedInstancesResponse_instances;
        
			return describeManagedInstancesResponse;
        }
    }
}
