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
        public static ListClusterHostComponentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListClusterHostComponentResponse listClusterHostComponentResponse = new ListClusterHostComponentResponse();

			listClusterHostComponentResponse.HttpResponse = _ctx.HttpResponse;
			listClusterHostComponentResponse.RequestId = _ctx.StringValue("ListClusterHostComponent.RequestId");
			listClusterHostComponentResponse.PageNumber = _ctx.IntegerValue("ListClusterHostComponent.PageNumber");
			listClusterHostComponentResponse.PageSize = _ctx.IntegerValue("ListClusterHostComponent.PageSize");
			listClusterHostComponentResponse.Total = _ctx.IntegerValue("ListClusterHostComponent.Total");

			List<ListClusterHostComponentResponse.ListClusterHostComponent_Component> listClusterHostComponentResponse_componentList = new List<ListClusterHostComponentResponse.ListClusterHostComponent_Component>();
			for (int i = 0; i < _ctx.Length("ListClusterHostComponent.ComponentList.Length"); i++) {
				ListClusterHostComponentResponse.ListClusterHostComponent_Component component = new ListClusterHostComponentResponse.ListClusterHostComponent_Component();
				component.ServiceName = _ctx.StringValue("ListClusterHostComponent.ComponentList["+ i +"].ServiceName");
				component.ServiceDisplayName = _ctx.StringValue("ListClusterHostComponent.ComponentList["+ i +"].ServiceDisplayName");
				component.ComponentName = _ctx.StringValue("ListClusterHostComponent.ComponentList["+ i +"].ComponentName");
				component.ComponentDisplayName = _ctx.StringValue("ListClusterHostComponent.ComponentList["+ i +"].ComponentDisplayName");
				component.Status = _ctx.StringValue("ListClusterHostComponent.ComponentList["+ i +"].Status");
				component.NeedRestart = _ctx.BooleanValue("ListClusterHostComponent.ComponentList["+ i +"].NeedRestart");
				component.HostId = _ctx.StringValue("ListClusterHostComponent.ComponentList["+ i +"].HostId");
				component.ServerStatus = _ctx.StringValue("ListClusterHostComponent.ComponentList["+ i +"].ServerStatus");
				component.HostName = _ctx.StringValue("ListClusterHostComponent.ComponentList["+ i +"].HostName");
				component.PublicIp = _ctx.StringValue("ListClusterHostComponent.ComponentList["+ i +"].PublicIp");
				component.PrivateIp = _ctx.StringValue("ListClusterHostComponent.ComponentList["+ i +"].PrivateIp");
				component.Role = _ctx.StringValue("ListClusterHostComponent.ComponentList["+ i +"].Role");
				component.InstanceType = _ctx.StringValue("ListClusterHostComponent.ComponentList["+ i +"].InstanceType");
				component.Cpu = _ctx.IntegerValue("ListClusterHostComponent.ComponentList["+ i +"].Cpu");
				component.Memory = _ctx.IntegerValue("ListClusterHostComponent.ComponentList["+ i +"].Memory");
				component.HostInstanceId = _ctx.StringValue("ListClusterHostComponent.ComponentList["+ i +"].HostInstanceId");
				component.SerialNumber = _ctx.StringValue("ListClusterHostComponent.ComponentList["+ i +"].SerialNumber");
				component.CommissionStatus = _ctx.StringValue("ListClusterHostComponent.ComponentList["+ i +"].CommissionStatus");

				listClusterHostComponentResponse_componentList.Add(component);
			}
			listClusterHostComponentResponse.ComponentList = listClusterHostComponentResponse_componentList;
        
			return listClusterHostComponentResponse;
        }
    }
}
