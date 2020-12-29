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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListContainerAppsResponseUnmarshaller
    {
        public static ListContainerAppsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListContainerAppsResponse listContainerAppsResponse = new ListContainerAppsResponse();

			listContainerAppsResponse.HttpResponse = _ctx.HttpResponse;
			listContainerAppsResponse.RequestId = _ctx.StringValue("ListContainerApps.RequestId");
			listContainerAppsResponse.TotalCount = _ctx.IntegerValue("ListContainerApps.TotalCount");
			listContainerAppsResponse.PageNumber = _ctx.IntegerValue("ListContainerApps.PageNumber");
			listContainerAppsResponse.PageSize = _ctx.IntegerValue("ListContainerApps.PageSize");

			List<ListContainerAppsResponse.ListContainerApps_ContainerAppsItem> listContainerAppsResponse_containerApps = new List<ListContainerAppsResponse.ListContainerApps_ContainerAppsItem>();
			for (int i = 0; i < _ctx.Length("ListContainerApps.ContainerApps.Length"); i++) {
				ListContainerAppsResponse.ListContainerApps_ContainerAppsItem containerAppsItem = new ListContainerAppsResponse.ListContainerApps_ContainerAppsItem();
				containerAppsItem.Id = _ctx.StringValue("ListContainerApps.ContainerApps["+ i +"].Id");
				containerAppsItem.Name = _ctx.StringValue("ListContainerApps.ContainerApps["+ i +"].Name");
				containerAppsItem.Description = _ctx.StringValue("ListContainerApps.ContainerApps["+ i +"].Description");
				containerAppsItem.Repository = _ctx.StringValue("ListContainerApps.ContainerApps["+ i +"].Repository");
				containerAppsItem.ImageTag = _ctx.StringValue("ListContainerApps.ContainerApps["+ i +"].ImageTag");
				containerAppsItem.CreateTime = _ctx.StringValue("ListContainerApps.ContainerApps["+ i +"].CreateTime");
				containerAppsItem.Type = _ctx.StringValue("ListContainerApps.ContainerApps["+ i +"].Type");

				listContainerAppsResponse_containerApps.Add(containerAppsItem);
			}
			listContainerAppsResponse.ContainerApps = listContainerAppsResponse_containerApps;
        
			return listContainerAppsResponse;
        }
    }
}
