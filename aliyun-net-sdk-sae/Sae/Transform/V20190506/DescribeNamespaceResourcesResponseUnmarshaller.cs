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
        public static DescribeNamespaceResourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeNamespaceResourcesResponse describeNamespaceResourcesResponse = new DescribeNamespaceResourcesResponse();

			describeNamespaceResourcesResponse.HttpResponse = _ctx.HttpResponse;
			describeNamespaceResourcesResponse.RequestId = _ctx.StringValue("DescribeNamespaceResources.RequestId");
			describeNamespaceResourcesResponse.Message = _ctx.StringValue("DescribeNamespaceResources.Message");
			describeNamespaceResourcesResponse.TraceId = _ctx.StringValue("DescribeNamespaceResources.TraceId");
			describeNamespaceResourcesResponse.ErrorCode = _ctx.StringValue("DescribeNamespaceResources.ErrorCode");
			describeNamespaceResourcesResponse.Code = _ctx.StringValue("DescribeNamespaceResources.Code");
			describeNamespaceResourcesResponse.Success = _ctx.BooleanValue("DescribeNamespaceResources.Success");

			DescribeNamespaceResourcesResponse.DescribeNamespaceResources_Data data = new DescribeNamespaceResourcesResponse.DescribeNamespaceResources_Data();
			data.VpcId = _ctx.StringValue("DescribeNamespaceResources.Data.VpcId");
			data.LastChangeOrderId = _ctx.StringValue("DescribeNamespaceResources.Data.LastChangeOrderId");
			data.BelongRegion = _ctx.StringValue("DescribeNamespaceResources.Data.BelongRegion");
			data.NamespaceId = _ctx.StringValue("DescribeNamespaceResources.Data.NamespaceId");
			data.SecurityGroupId = _ctx.StringValue("DescribeNamespaceResources.Data.SecurityGroupId");
			data.UserId = _ctx.StringValue("DescribeNamespaceResources.Data.UserId");
			data.NamespaceName = _ctx.StringValue("DescribeNamespaceResources.Data.NamespaceName");
			data.LastChangeOrderStatus = _ctx.StringValue("DescribeNamespaceResources.Data.LastChangeOrderStatus");
			data.VpcName = _ctx.StringValue("DescribeNamespaceResources.Data.VpcName");
			data.VSwitchId = _ctx.StringValue("DescribeNamespaceResources.Data.VSwitchId");
			data.Description = _ctx.StringValue("DescribeNamespaceResources.Data.Description");
			data.LastChangeOrderRunning = _ctx.BooleanValue("DescribeNamespaceResources.Data.LastChangeOrderRunning");
			data.AppCount = _ctx.LongValue("DescribeNamespaceResources.Data.AppCount");
			data.VSwitchName = _ctx.StringValue("DescribeNamespaceResources.Data.VSwitchName");
			data.NotificationExpired = _ctx.BooleanValue("DescribeNamespaceResources.Data.NotificationExpired");
			data.TenantId = _ctx.StringValue("DescribeNamespaceResources.Data.TenantId");
			data.JumpServerAppId = _ctx.StringValue("DescribeNamespaceResources.Data.JumpServerAppId");
			describeNamespaceResourcesResponse.Data = data;
        
			return describeNamespaceResourcesResponse;
        }
    }
}
