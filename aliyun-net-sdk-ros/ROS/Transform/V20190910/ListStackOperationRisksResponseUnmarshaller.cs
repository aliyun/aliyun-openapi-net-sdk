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
using Aliyun.Acs.ROS.Model.V20190910;

namespace Aliyun.Acs.ROS.Transform.V20190910
{
    public class ListStackOperationRisksResponseUnmarshaller
    {
        public static ListStackOperationRisksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListStackOperationRisksResponse listStackOperationRisksResponse = new ListStackOperationRisksResponse();

			listStackOperationRisksResponse.HttpResponse = _ctx.HttpResponse;
			listStackOperationRisksResponse.RequestId = _ctx.StringValue("ListStackOperationRisks.RequestId");

			List<ListStackOperationRisksResponse.ListStackOperationRisks_Resource> listStackOperationRisksResponse_riskResources = new List<ListStackOperationRisksResponse.ListStackOperationRisks_Resource>();
			for (int i = 0; i < _ctx.Length("ListStackOperationRisks.RiskResources.Length"); i++) {
				ListStackOperationRisksResponse.ListStackOperationRisks_Resource resource = new ListStackOperationRisksResponse.ListStackOperationRisks_Resource();
				resource.LogicalResourceId = _ctx.StringValue("ListStackOperationRisks.RiskResources["+ i +"].LogicalResourceId");
				resource.PhysicalResourceId = _ctx.StringValue("ListStackOperationRisks.RiskResources["+ i +"].PhysicalResourceId");
				resource.ResourceType = _ctx.StringValue("ListStackOperationRisks.RiskResources["+ i +"].ResourceType");
				resource.Reason = _ctx.StringValue("ListStackOperationRisks.RiskResources["+ i +"].Reason");
				resource.RiskType = _ctx.StringValue("ListStackOperationRisks.RiskResources["+ i +"].RiskType");
				resource.Code = _ctx.StringValue("ListStackOperationRisks.RiskResources["+ i +"].Code");
				resource.Message = _ctx.StringValue("ListStackOperationRisks.RiskResources["+ i +"].Message");
				resource.RequestId = _ctx.StringValue("ListStackOperationRisks.RiskResources["+ i +"].RequestId");

				listStackOperationRisksResponse_riskResources.Add(resource);
			}
			listStackOperationRisksResponse.RiskResources = listStackOperationRisksResponse_riskResources;
        
			return listStackOperationRisksResponse;
        }
    }
}
