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
using Aliyun.Acs.appstream_center.Model.V20210901;

namespace Aliyun.Acs.appstream_center.Transform.V20210901
{
    public class ListNodeInstanceTypeResponseUnmarshaller
    {
        public static ListNodeInstanceTypeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNodeInstanceTypeResponse listNodeInstanceTypeResponse = new ListNodeInstanceTypeResponse();

			listNodeInstanceTypeResponse.HttpResponse = _ctx.HttpResponse;
			listNodeInstanceTypeResponse.RequestId = _ctx.StringValue("ListNodeInstanceType.RequestId");
			listNodeInstanceTypeResponse.TotalCount = _ctx.IntegerValue("ListNodeInstanceType.TotalCount");
			listNodeInstanceTypeResponse.PageSize = _ctx.IntegerValue("ListNodeInstanceType.PageSize");
			listNodeInstanceTypeResponse.PageNumber = _ctx.IntegerValue("ListNodeInstanceType.PageNumber");

			List<ListNodeInstanceTypeResponse.ListNodeInstanceType_Node> listNodeInstanceTypeResponse_nodeInstanceTypeModels = new List<ListNodeInstanceTypeResponse.ListNodeInstanceType_Node>();
			for (int i = 0; i < _ctx.Length("ListNodeInstanceType.NodeInstanceTypeModels.Length"); i++) {
				ListNodeInstanceTypeResponse.ListNodeInstanceType_Node node = new ListNodeInstanceTypeResponse.ListNodeInstanceType_Node();
				node.NodeInstanceType = _ctx.StringValue("ListNodeInstanceType.NodeInstanceTypeModels["+ i +"].NodeInstanceType");
				node.NodeInstanceTypeFamily = _ctx.StringValue("ListNodeInstanceType.NodeInstanceTypeModels["+ i +"].NodeInstanceTypeFamily");
				node.Cpu = _ctx.StringValue("ListNodeInstanceType.NodeInstanceTypeModels["+ i +"].Cpu");
				node.Gpu = _ctx.StringValue("ListNodeInstanceType.NodeInstanceTypeModels["+ i +"].Gpu");
				node.Memory = _ctx.LongValue("ListNodeInstanceType.NodeInstanceTypeModels["+ i +"].Memory");
				node.SystemDiskSize = _ctx.LongValue("ListNodeInstanceType.NodeInstanceTypeModels["+ i +"].SystemDiskSize");
				node.DataDiskSize = _ctx.LongValue("ListNodeInstanceType.NodeInstanceTypeModels["+ i +"].DataDiskSize");
				node.GpuMemory = _ctx.LongValue("ListNodeInstanceType.NodeInstanceTypeModels["+ i +"].GpuMemory");
				node.MaxCapacity = _ctx.IntegerValue("ListNodeInstanceType.NodeInstanceTypeModels["+ i +"].MaxCapacity");
				node.NodeTypeName = _ctx.StringValue("ListNodeInstanceType.NodeInstanceTypeModels["+ i +"].NodeTypeName");

				listNodeInstanceTypeResponse_nodeInstanceTypeModels.Add(node);
			}
			listNodeInstanceTypeResponse.NodeInstanceTypeModels = listNodeInstanceTypeResponse_nodeInstanceTypeModels;
        
			return listNodeInstanceTypeResponse;
        }
    }
}
