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
    public class ListInstancesTrafficPackagesResponseUnmarshaller
    {
        public static ListInstancesTrafficPackagesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstancesTrafficPackagesResponse listInstancesTrafficPackagesResponse = new ListInstancesTrafficPackagesResponse();

			listInstancesTrafficPackagesResponse.HttpResponse = _ctx.HttpResponse;
			listInstancesTrafficPackagesResponse.RequestId = _ctx.StringValue("ListInstancesTrafficPackages.RequestId");

			List<ListInstancesTrafficPackagesResponse.ListInstancesTrafficPackages_InstanceTrafficPackageUsage> listInstancesTrafficPackagesResponse_instanceTrafficPackageUsages = new List<ListInstancesTrafficPackagesResponse.ListInstancesTrafficPackages_InstanceTrafficPackageUsage>();
			for (int i = 0; i < _ctx.Length("ListInstancesTrafficPackages.InstanceTrafficPackageUsages.Length"); i++) {
				ListInstancesTrafficPackagesResponse.ListInstancesTrafficPackages_InstanceTrafficPackageUsage instanceTrafficPackageUsage = new ListInstancesTrafficPackagesResponse.ListInstancesTrafficPackages_InstanceTrafficPackageUsage();
				instanceTrafficPackageUsage.InstanceId = _ctx.StringValue("ListInstancesTrafficPackages.InstanceTrafficPackageUsages["+ i +"].InstanceId");
				instanceTrafficPackageUsage.TrafficUsed = _ctx.LongValue("ListInstancesTrafficPackages.InstanceTrafficPackageUsages["+ i +"].TrafficUsed");
				instanceTrafficPackageUsage.TrafficPackageTotal = _ctx.LongValue("ListInstancesTrafficPackages.InstanceTrafficPackageUsages["+ i +"].TrafficPackageTotal");
				instanceTrafficPackageUsage.TrafficPackageRemaining = _ctx.LongValue("ListInstancesTrafficPackages.InstanceTrafficPackageUsages["+ i +"].TrafficPackageRemaining");
				instanceTrafficPackageUsage.TrafficOverflow = _ctx.LongValue("ListInstancesTrafficPackages.InstanceTrafficPackageUsages["+ i +"].TrafficOverflow");

				listInstancesTrafficPackagesResponse_instanceTrafficPackageUsages.Add(instanceTrafficPackageUsage);
			}
			listInstancesTrafficPackagesResponse.InstanceTrafficPackageUsages = listInstancesTrafficPackagesResponse_instanceTrafficPackageUsages;
        
			return listInstancesTrafficPackagesResponse;
        }
    }
}
