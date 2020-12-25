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
    public class ListClusterServiceComponentResponseUnmarshaller
    {
        public static ListClusterServiceComponentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListClusterServiceComponentResponse listClusterServiceComponentResponse = new ListClusterServiceComponentResponse();

			listClusterServiceComponentResponse.HttpResponse = _ctx.HttpResponse;
			listClusterServiceComponentResponse.RequestId = _ctx.StringValue("ListClusterServiceComponent.RequestId");
			listClusterServiceComponentResponse.PageNumber = _ctx.IntegerValue("ListClusterServiceComponent.PageNumber");
			listClusterServiceComponentResponse.PageSize = _ctx.IntegerValue("ListClusterServiceComponent.PageSize");
			listClusterServiceComponentResponse.Total = _ctx.IntegerValue("ListClusterServiceComponent.Total");

			List<ListClusterServiceComponentResponse.ListClusterServiceComponent_Component> listClusterServiceComponentResponse_componentList = new List<ListClusterServiceComponentResponse.ListClusterServiceComponent_Component>();
			for (int i = 0; i < _ctx.Length("ListClusterServiceComponent.ComponentList.Length"); i++) {
				ListClusterServiceComponentResponse.ListClusterServiceComponent_Component component = new ListClusterServiceComponentResponse.ListClusterServiceComponent_Component();
				component.ServiceName = _ctx.StringValue("ListClusterServiceComponent.ComponentList["+ i +"].ServiceName");
				component.ServiceDisplayName = _ctx.StringValue("ListClusterServiceComponent.ComponentList["+ i +"].ServiceDisplayName");
				component.ComponentName = _ctx.StringValue("ListClusterServiceComponent.ComponentList["+ i +"].ComponentName");
				component.ComponentDisplayName = _ctx.StringValue("ListClusterServiceComponent.ComponentList["+ i +"].ComponentDisplayName");
				component.Status = _ctx.StringValue("ListClusterServiceComponent.ComponentList["+ i +"].Status");
				component.NeedRestart = _ctx.BooleanValue("ListClusterServiceComponent.ComponentList["+ i +"].NeedRestart");
				component.ServerStatus = _ctx.StringValue("ListClusterServiceComponent.ComponentList["+ i +"].ServerStatus");
				component.PodName = _ctx.StringValue("ListClusterServiceComponent.ComponentList["+ i +"].PodName");
				component.PublicIp = _ctx.StringValue("ListClusterServiceComponent.ComponentList["+ i +"].PublicIp");
				component.PrivateIp = _ctx.StringValue("ListClusterServiceComponent.ComponentList["+ i +"].PrivateIp");
				component.Role = _ctx.StringValue("ListClusterServiceComponent.ComponentList["+ i +"].Role");
				component.CommissionStatus = _ctx.StringValue("ListClusterServiceComponent.ComponentList["+ i +"].CommissionStatus");
				component.DesiredCount = _ctx.IntegerValue("ListClusterServiceComponent.ComponentList["+ i +"].DesiredCount");
				component._Namespace = _ctx.StringValue("ListClusterServiceComponent.ComponentList["+ i +"].Namespace");
				component.WorkloadType = _ctx.StringValue("ListClusterServiceComponent.ComponentList["+ i +"].WorkloadType");
				component.WorkloadName = _ctx.StringValue("ListClusterServiceComponent.ComponentList["+ i +"].WorkloadName");

				listClusterServiceComponentResponse_componentList.Add(component);
			}
			listClusterServiceComponentResponse.ComponentList = listClusterServiceComponentResponse_componentList;
        
			return listClusterServiceComponentResponse;
        }
    }
}
