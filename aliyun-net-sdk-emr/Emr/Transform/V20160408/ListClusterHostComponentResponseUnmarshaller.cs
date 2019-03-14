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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListClusterHostComponentResponseUnmarshaller
    {
        public static ListClusterHostComponentResponse Unmarshall(UnmarshallerContext context)
        {
			ListClusterHostComponentResponse listClusterHostComponentResponse = new ListClusterHostComponentResponse();

			listClusterHostComponentResponse.HttpResponse = context.HttpResponse;
			listClusterHostComponentResponse.RequestId = context.StringValue("ListClusterHostComponent.RequestId");
			listClusterHostComponentResponse.PageNumber = context.IntegerValue("ListClusterHostComponent.PageNumber");
			listClusterHostComponentResponse.PageSize = context.IntegerValue("ListClusterHostComponent.PageSize");
			listClusterHostComponentResponse.Total = context.IntegerValue("ListClusterHostComponent.Total");

			List<ListClusterHostComponentResponse.ListClusterHostComponent_Component> listClusterHostComponentResponse_componentList = new List<ListClusterHostComponentResponse.ListClusterHostComponent_Component>();
			for (int i = 0; i < context.Length("ListClusterHostComponent.ComponentList.Length"); i++) {
				ListClusterHostComponentResponse.ListClusterHostComponent_Component component = new ListClusterHostComponentResponse.ListClusterHostComponent_Component();
				component.ServiceName = context.StringValue("ListClusterHostComponent.ComponentList["+ i +"].ServiceName");
				component.ServiceDisplayName = context.StringValue("ListClusterHostComponent.ComponentList["+ i +"].ServiceDisplayName");
				component.ComponentName = context.StringValue("ListClusterHostComponent.ComponentList["+ i +"].ComponentName");
				component.ComponentDisplayName = context.StringValue("ListClusterHostComponent.ComponentList["+ i +"].ComponentDisplayName");
				component.Status = context.StringValue("ListClusterHostComponent.ComponentList["+ i +"].Status");
				component.NeedRestart = context.BooleanValue("ListClusterHostComponent.ComponentList["+ i +"].NeedRestart");
				component.HostId = context.StringValue("ListClusterHostComponent.ComponentList["+ i +"].HostId");
				component.ServerStatus = context.StringValue("ListClusterHostComponent.ComponentList["+ i +"].ServerStatus");
				component.HostName = context.StringValue("ListClusterHostComponent.ComponentList["+ i +"].HostName");
				component.PublicIp = context.StringValue("ListClusterHostComponent.ComponentList["+ i +"].PublicIp");
				component.PrivateIp = context.StringValue("ListClusterHostComponent.ComponentList["+ i +"].PrivateIp");
				component.Role = context.StringValue("ListClusterHostComponent.ComponentList["+ i +"].Role");
				component.InstanceType = context.StringValue("ListClusterHostComponent.ComponentList["+ i +"].InstanceType");
				component.Cpu = context.IntegerValue("ListClusterHostComponent.ComponentList["+ i +"].Cpu");
				component.Memory = context.IntegerValue("ListClusterHostComponent.ComponentList["+ i +"].Memory");
				component.HostInstanceId = context.StringValue("ListClusterHostComponent.ComponentList["+ i +"].HostInstanceId");
				component.SerialNumber = context.StringValue("ListClusterHostComponent.ComponentList["+ i +"].SerialNumber");

				listClusterHostComponentResponse_componentList.Add(component);
			}
			listClusterHostComponentResponse.ComponentList = listClusterHostComponentResponse_componentList;
        
			return listClusterHostComponentResponse;
        }
    }
}
