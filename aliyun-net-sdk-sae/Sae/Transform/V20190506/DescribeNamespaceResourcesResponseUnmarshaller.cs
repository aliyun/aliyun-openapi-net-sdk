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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class DescribeNamespaceResourcesResponseUnmarshaller
    {
        public static DescribeNamespaceResourcesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeNamespaceResourcesResponse describeNamespaceResourcesResponse = new DescribeNamespaceResourcesResponse();

			describeNamespaceResourcesResponse.HttpResponse = context.HttpResponse;
			describeNamespaceResourcesResponse.RequestId = context.StringValue("DescribeNamespaceResources.RequestId");
			describeNamespaceResourcesResponse.Code = context.StringValue("DescribeNamespaceResources.Code");
			describeNamespaceResourcesResponse.Message = context.StringValue("DescribeNamespaceResources.Message");
			describeNamespaceResourcesResponse.ErrorCode = context.StringValue("DescribeNamespaceResources.ErrorCode");
			describeNamespaceResourcesResponse.TraceId = context.StringValue("DescribeNamespaceResources.TraceId");
			describeNamespaceResourcesResponse.Success = context.BooleanValue("DescribeNamespaceResources.Success");

			DescribeNamespaceResourcesResponse.DescribeNamespaceResources_Data data = new DescribeNamespaceResourcesResponse.DescribeNamespaceResources_Data();
			data.NamespaceId = context.StringValue("DescribeNamespaceResources.Data.NamespaceId");
			data.NamespaceName = context.StringValue("DescribeNamespaceResources.Data.NamespaceName");
			data.Description = context.StringValue("DescribeNamespaceResources.Data.Description");
			data.UserId = context.StringValue("DescribeNamespaceResources.Data.UserId");
			data.BelongRegion = context.StringValue("DescribeNamespaceResources.Data.BelongRegion");
			data.TenantId = context.StringValue("DescribeNamespaceResources.Data.TenantId");
			data.VpcId = context.StringValue("DescribeNamespaceResources.Data.VpcId");
			data.VSwitchId = context.StringValue("DescribeNamespaceResources.Data.VSwitchId");
			data.SecurityGroupId = context.StringValue("DescribeNamespaceResources.Data.SecurityGroupId");
			data.AppCount = context.LongValue("DescribeNamespaceResources.Data.AppCount");
			data.LastChangeOrderId = context.StringValue("DescribeNamespaceResources.Data.LastChangeOrderId");
			data.LastChangeOrderStatus = context.StringValue("DescribeNamespaceResources.Data.LastChangeOrderStatus");
			data.LastChangeOrderRunning = context.BooleanValue("DescribeNamespaceResources.Data.LastChangeOrderRunning");
			data.VpcName = context.StringValue("DescribeNamespaceResources.Data.VpcName");
			data.VSwitchName = context.StringValue("DescribeNamespaceResources.Data.VSwitchName");
			data.NotificationExpired = context.BooleanValue("DescribeNamespaceResources.Data.NotificationExpired");
			describeNamespaceResourcesResponse.Data = data;
        
			return describeNamespaceResourcesResponse;
        }
    }
}
