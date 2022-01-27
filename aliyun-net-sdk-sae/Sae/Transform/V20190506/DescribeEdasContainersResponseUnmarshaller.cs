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
    public class DescribeEdasContainersResponseUnmarshaller
    {
        public static DescribeEdasContainersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEdasContainersResponse describeEdasContainersResponse = new DescribeEdasContainersResponse();

			describeEdasContainersResponse.HttpResponse = _ctx.HttpResponse;
			describeEdasContainersResponse.RequestId = _ctx.StringValue("DescribeEdasContainers.RequestId");
			describeEdasContainersResponse.Code = _ctx.StringValue("DescribeEdasContainers.Code");
			describeEdasContainersResponse.Message = _ctx.StringValue("DescribeEdasContainers.Message");
			describeEdasContainersResponse.Success = _ctx.BooleanValue("DescribeEdasContainers.Success");
			describeEdasContainersResponse.ErrorCode = _ctx.StringValue("DescribeEdasContainers.ErrorCode");
			describeEdasContainersResponse.TraceId = _ctx.StringValue("DescribeEdasContainers.TraceId");

			List<DescribeEdasContainersResponse.DescribeEdasContainers_DataItem> describeEdasContainersResponse_data = new List<DescribeEdasContainersResponse.DescribeEdasContainers_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeEdasContainers.Data.Length"); i++) {
				DescribeEdasContainersResponse.DescribeEdasContainers_DataItem dataItem = new DescribeEdasContainersResponse.DescribeEdasContainers_DataItem();
				dataItem.Disabled = _ctx.BooleanValue("DescribeEdasContainers.Data["+ i +"].Disabled");
				dataItem.EdasContainerVersion = _ctx.StringValue("DescribeEdasContainers.Data["+ i +"].EdasContainerVersion");

				describeEdasContainersResponse_data.Add(dataItem);
			}
			describeEdasContainersResponse.Data = describeEdasContainersResponse_data;
        
			return describeEdasContainersResponse;
        }
    }
}
