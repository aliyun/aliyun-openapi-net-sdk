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
using Aliyun.Acs.SWAS_OPEN.Model.V20200601;

namespace Aliyun.Acs.SWAS_OPEN.Transform.V20200601
{
    public class ListInstancesResponseUnmarshaller
    {
        public static ListInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstancesResponse listInstancesResponse = new ListInstancesResponse();

			listInstancesResponse.HttpResponse = _ctx.HttpResponse;
			listInstancesResponse.TotalCount = _ctx.IntegerValue("ListInstances.TotalCount");
			listInstancesResponse.RequestId = _ctx.StringValue("ListInstances.RequestId");
			listInstancesResponse.PageSize = _ctx.IntegerValue("ListInstances.PageSize");
			listInstancesResponse.PageNumber = _ctx.IntegerValue("ListInstances.PageNumber");

			List<ListInstancesResponse.ListInstances_Instance> listInstancesResponse_instances = new List<ListInstancesResponse.ListInstances_Instance>();
			for (int i = 0; i < _ctx.Length("ListInstances.Instances.Length"); i++) {
				ListInstancesResponse.ListInstances_Instance instance = new ListInstancesResponse.ListInstances_Instance();
				instance.Status = _ctx.StringValue("ListInstances.Instances["+ i +"].Status");
				instance.CreationTime = _ctx.StringValue("ListInstances.Instances["+ i +"].CreationTime");
				instance.InnerIpAddress = _ctx.StringValue("ListInstances.Instances["+ i +"].InnerIpAddress");
				instance.ChargeType = _ctx.StringValue("ListInstances.Instances["+ i +"].ChargeType");
				instance.InstanceId = _ctx.StringValue("ListInstances.Instances["+ i +"].InstanceId");
				instance.PlanId = _ctx.StringValue("ListInstances.Instances["+ i +"].PlanId");
				instance.PublicIpAddress = _ctx.StringValue("ListInstances.Instances["+ i +"].PublicIpAddress");
				instance.RegionId = _ctx.StringValue("ListInstances.Instances["+ i +"].RegionId");
				instance.ExpiredTime = _ctx.StringValue("ListInstances.Instances["+ i +"].ExpiredTime");
				instance.InstanceName = _ctx.StringValue("ListInstances.Instances["+ i +"].InstanceName");
				instance.BusinessStatus = _ctx.StringValue("ListInstances.Instances["+ i +"].BusinessStatus");
				instance.DdosStatus = _ctx.StringValue("ListInstances.Instances["+ i +"].DdosStatus");
				instance.ImageId = _ctx.StringValue("ListInstances.Instances["+ i +"].ImageId");

				listInstancesResponse_instances.Add(instance);
			}
			listInstancesResponse.Instances = listInstancesResponse_instances;
        
			return listInstancesResponse;
        }
    }
}
