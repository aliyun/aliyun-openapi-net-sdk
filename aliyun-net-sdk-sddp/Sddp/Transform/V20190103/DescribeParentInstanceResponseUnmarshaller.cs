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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeParentInstanceResponseUnmarshaller
    {
        public static DescribeParentInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeParentInstanceResponse describeParentInstanceResponse = new DescribeParentInstanceResponse();

			describeParentInstanceResponse.HttpResponse = _ctx.HttpResponse;
			describeParentInstanceResponse.RequestId = _ctx.StringValue("DescribeParentInstance.RequestId");
			describeParentInstanceResponse.CurrentPage = _ctx.IntegerValue("DescribeParentInstance.CurrentPage");
			describeParentInstanceResponse.PageSize = _ctx.IntegerValue("DescribeParentInstance.PageSize");
			describeParentInstanceResponse.TotalCount = _ctx.IntegerValue("DescribeParentInstance.TotalCount");

			List<DescribeParentInstanceResponse.DescribeParentInstance_Data> describeParentInstanceResponse_items = new List<DescribeParentInstanceResponse.DescribeParentInstance_Data>();
			for (int i = 0; i < _ctx.Length("DescribeParentInstance.Items.Length"); i++) {
				DescribeParentInstanceResponse.DescribeParentInstance_Data data = new DescribeParentInstanceResponse.DescribeParentInstance_Data();
				data.InstanceId = _ctx.StringValue("DescribeParentInstance.Items["+ i +"].InstanceId");
				data.LocalName = _ctx.StringValue("DescribeParentInstance.Items["+ i +"].LocalName");
				data.EngineType = _ctx.StringValue("DescribeParentInstance.Items["+ i +"].EngineType");
				data.ParentId = _ctx.StringValue("DescribeParentInstance.Items["+ i +"].ParentId");
				data.DbNum = _ctx.StringValue("DescribeParentInstance.Items["+ i +"].DbNum");
				data.ClusterStatus = _ctx.StringValue("DescribeParentInstance.Items["+ i +"].ClusterStatus");
				data.TenantId = _ctx.StringValue("DescribeParentInstance.Items["+ i +"].TenantId");
				data.TenantName = _ctx.StringValue("DescribeParentInstance.Items["+ i +"].TenantName");
				data.InstanceDescription = _ctx.StringValue("DescribeParentInstance.Items["+ i +"].InstanceDescription");
				data.ResourceType = _ctx.StringValue("DescribeParentInstance.Items["+ i +"].ResourceType");
				data.UnConnectDbCount = _ctx.StringValue("DescribeParentInstance.Items["+ i +"].UnConnectDbCount");
				data.UnSupportOneClickAuthReason = _ctx.StringValue("DescribeParentInstance.Items["+ i +"].UnSupportOneClickAuthReason");
				data.ConnectNode = _ctx.StringValue("DescribeParentInstance.Items["+ i +"].ConnectNode");
				data.SupportConnectNodes = _ctx.StringValue("DescribeParentInstance.Items["+ i +"].SupportConnectNodes");
				data.AuthStatus = _ctx.IntegerValue("DescribeParentInstance.Items["+ i +"].AuthStatus");
				data.InstanceSize = _ctx.LongValue("DescribeParentInstance.Items["+ i +"].InstanceSize");
				data.AuditStatus = _ctx.IntegerValue("DescribeParentInstance.Items["+ i +"].AuditStatus");

				describeParentInstanceResponse_items.Add(data);
			}
			describeParentInstanceResponse.Items = describeParentInstanceResponse_items;
        
			return describeParentInstanceResponse;
        }
    }
}
