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
using Aliyun.Acs.PaiFeatureStore.Model.V20230621;

namespace Aliyun.Acs.PaiFeatureStore.Transform.V20230621
{
    public class ListInstancesResponseUnmarshaller
    {
        public static ListInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstancesResponse listInstancesResponse = new ListInstancesResponse();

			listInstancesResponse.HttpResponse = _ctx.HttpResponse;
			listInstancesResponse.RequestId = _ctx.StringValue("ListInstances.RequestId");
			listInstancesResponse.TotalCount = _ctx.LongValue("ListInstances.TotalCount");

			List<ListInstancesResponse.ListInstances_InstancesItem> listInstancesResponse_instances = new List<ListInstancesResponse.ListInstances_InstancesItem>();
			for (int i = 0; i < _ctx.Length("ListInstances.Instances.Length"); i++) {
				ListInstancesResponse.ListInstances_InstancesItem instancesItem = new ListInstancesResponse.ListInstances_InstancesItem();
				instancesItem.InstanceId = _ctx.StringValue("ListInstances.Instances["+ i +"].InstanceId");
				instancesItem.Type = _ctx.StringValue("ListInstances.Instances["+ i +"].Type");
				instancesItem.Status = _ctx.StringValue("ListInstances.Instances["+ i +"].Status");
				instancesItem.RegionId = _ctx.StringValue("ListInstances.Instances["+ i +"].RegionId");
				instancesItem.GmtCreateTime = _ctx.StringValue("ListInstances.Instances["+ i +"].GmtCreateTime");
				instancesItem.GmtModifiedTime = _ctx.StringValue("ListInstances.Instances["+ i +"].GmtModifiedTime");

				ListInstancesResponse.ListInstances_InstancesItem.ListInstances_FeatureDBInstanceInfo featureDBInstanceInfo = new ListInstancesResponse.ListInstances_InstancesItem.ListInstances_FeatureDBInstanceInfo();
				featureDBInstanceInfo.Status = _ctx.StringValue("ListInstances.Instances["+ i +"].FeatureDBInstanceInfo.Status");
				instancesItem.FeatureDBInstanceInfo = featureDBInstanceInfo;

				listInstancesResponse_instances.Add(instancesItem);
			}
			listInstancesResponse.Instances = listInstancesResponse_instances;
        
			return listInstancesResponse;
        }
    }
}
