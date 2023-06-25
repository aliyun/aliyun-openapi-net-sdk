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
using Aliyun.Acs.ddosbgp.Model.V20180720;

namespace Aliyun.Acs.ddosbgp.Transform.V20180720
{
    public class ListOpenedAccessLogInstancesResponseUnmarshaller
    {
        public static ListOpenedAccessLogInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListOpenedAccessLogInstancesResponse listOpenedAccessLogInstancesResponse = new ListOpenedAccessLogInstancesResponse();

			listOpenedAccessLogInstancesResponse.HttpResponse = _ctx.HttpResponse;
			listOpenedAccessLogInstancesResponse.TotalCount = _ctx.IntegerValue("ListOpenedAccessLogInstances.TotalCount");
			listOpenedAccessLogInstancesResponse.RequestId = _ctx.StringValue("ListOpenedAccessLogInstances.RequestId");

			List<ListOpenedAccessLogInstancesResponse.ListOpenedAccessLogInstances_OpenedInstance> listOpenedAccessLogInstancesResponse_slsConfigStatus = new List<ListOpenedAccessLogInstancesResponse.ListOpenedAccessLogInstances_OpenedInstance>();
			for (int i = 0; i < _ctx.Length("ListOpenedAccessLogInstances.SlsConfigStatus.Length"); i++) {
				ListOpenedAccessLogInstancesResponse.ListOpenedAccessLogInstances_OpenedInstance openedInstance = new ListOpenedAccessLogInstancesResponse.ListOpenedAccessLogInstances_OpenedInstance();
				openedInstance.InstanceId = _ctx.StringValue("ListOpenedAccessLogInstances.SlsConfigStatus["+ i +"].InstanceId");
				openedInstance.Enable = _ctx.BooleanValue("ListOpenedAccessLogInstances.SlsConfigStatus["+ i +"].Enable");

				listOpenedAccessLogInstancesResponse_slsConfigStatus.Add(openedInstance);
			}
			listOpenedAccessLogInstancesResponse.SlsConfigStatus = listOpenedAccessLogInstancesResponse_slsConfigStatus;
        
			return listOpenedAccessLogInstancesResponse;
        }
    }
}
