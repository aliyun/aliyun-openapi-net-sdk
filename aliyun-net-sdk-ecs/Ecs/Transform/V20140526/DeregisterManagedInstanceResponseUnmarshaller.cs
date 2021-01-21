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
    public class DeregisterManagedInstanceResponseUnmarshaller
    {
        public static DeregisterManagedInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeregisterManagedInstanceResponse deregisterManagedInstanceResponse = new DeregisterManagedInstanceResponse();

			deregisterManagedInstanceResponse.HttpResponse = _ctx.HttpResponse;
			deregisterManagedInstanceResponse.RequestId = _ctx.StringValue("DeregisterManagedInstance.RequestId");

			DeregisterManagedInstanceResponse.DeregisterManagedInstance_Instance instance = new DeregisterManagedInstanceResponse.DeregisterManagedInstance_Instance();
			instance.InstanceId = _ctx.StringValue("DeregisterManagedInstance.Instance.InstanceId");
			instance.InstanceName = _ctx.StringValue("DeregisterManagedInstance.Instance.InstanceName");
			instance.ActivationId = _ctx.StringValue("DeregisterManagedInstance.Instance.ActivationId");
			instance.Hostname = _ctx.StringValue("DeregisterManagedInstance.Instance.Hostname");
			instance.MachineId = _ctx.StringValue("DeregisterManagedInstance.Instance.MachineId");
			instance.OsType = _ctx.StringValue("DeregisterManagedInstance.Instance.OsType");
			instance.OsVersion = _ctx.StringValue("DeregisterManagedInstance.Instance.OsVersion");
			instance.IntranetIp = _ctx.StringValue("DeregisterManagedInstance.Instance.IntranetIp");
			instance.InternetIp = _ctx.StringValue("DeregisterManagedInstance.Instance.InternetIp");
			instance.AgentVersion = _ctx.StringValue("DeregisterManagedInstance.Instance.AgentVersion");
			instance.RegistrationTime = _ctx.StringValue("DeregisterManagedInstance.Instance.RegistrationTime");
			instance.InvocationCount = _ctx.LongValue("DeregisterManagedInstance.Instance.InvocationCount");
			instance.LastInvokedTime = _ctx.StringValue("DeregisterManagedInstance.Instance.LastInvokedTime");
			deregisterManagedInstanceResponse.Instance = instance;
        
			return deregisterManagedInstanceResponse;
        }
    }
}
