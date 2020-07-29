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
        public static ListStackOperationRisksResponse Unmarshall(UnmarshallerContext context)
        {
			ListStackOperationRisksResponse listStackOperationRisksResponse = new ListStackOperationRisksResponse();

			listStackOperationRisksResponse.HttpResponse = context.HttpResponse;
			listStackOperationRisksResponse.RequestId = context.StringValue("ListStackOperationRisks.RequestId");

			List<ListStackOperationRisksResponse.ListStackOperationRisks_Resource> listStackOperationRisksResponse_riskResources = new List<ListStackOperationRisksResponse.ListStackOperationRisks_Resource>();
			for (int i = 0; i < context.Length("ListStackOperationRisks.RiskResources.Length"); i++) {
				ListStackOperationRisksResponse.ListStackOperationRisks_Resource resource = new ListStackOperationRisksResponse.ListStackOperationRisks_Resource();
				resource.LogicalResourceId = context.StringValue("ListStackOperationRisks.RiskResources["+ i +"].LogicalResourceId");
				resource.PhysicalResourceId = context.StringValue("ListStackOperationRisks.RiskResources["+ i +"].PhysicalResourceId");
				resource.ResourceType = context.StringValue("ListStackOperationRisks.RiskResources["+ i +"].ResourceType");
				resource.Reason = context.StringValue("ListStackOperationRisks.RiskResources["+ i +"].Reason");
				resource.RiskType = context.StringValue("ListStackOperationRisks.RiskResources["+ i +"].RiskType");
				resource.Code = context.StringValue("ListStackOperationRisks.RiskResources["+ i +"].Code");
				resource.Message = context.StringValue("ListStackOperationRisks.RiskResources["+ i +"].Message");
				resource.RequestId = context.StringValue("ListStackOperationRisks.RiskResources["+ i +"].RequestId");

				listStackOperationRisksResponse_riskResources.Add(resource);
			}
			listStackOperationRisksResponse.RiskResources = listStackOperationRisksResponse_riskResources;
        
			return listStackOperationRisksResponse;
        }
    }
}
