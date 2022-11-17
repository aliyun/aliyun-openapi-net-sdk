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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class DescribeAvailableCpuResourceResponseUnmarshaller
    {
        public static DescribeAvailableCpuResourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAvailableCpuResourceResponse describeAvailableCpuResourceResponse = new DescribeAvailableCpuResourceResponse();

			describeAvailableCpuResourceResponse.HttpResponse = _ctx.HttpResponse;
			describeAvailableCpuResourceResponse.RequestId = _ctx.StringValue("DescribeAvailableCpuResource.RequestId");

			List<DescribeAvailableCpuResourceResponse.DescribeAvailableCpuResource_DataItem> describeAvailableCpuResourceResponse_data = new List<DescribeAvailableCpuResourceResponse.DescribeAvailableCpuResource_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeAvailableCpuResource.Data.Length"); i++) {
				DescribeAvailableCpuResourceResponse.DescribeAvailableCpuResource_DataItem dataItem = new DescribeAvailableCpuResourceResponse.DescribeAvailableCpuResource_DataItem();
				dataItem.UnitNum = _ctx.LongValue("DescribeAvailableCpuResource.Data["+ i +"].UnitNum");
				dataItem.MinCpu = _ctx.LongValue("DescribeAvailableCpuResource.Data["+ i +"].MinCpu");
				dataItem.MaxCpu = _ctx.LongValue("DescribeAvailableCpuResource.Data["+ i +"].MaxCpu");

				describeAvailableCpuResourceResponse_data.Add(dataItem);
			}
			describeAvailableCpuResourceResponse.Data = describeAvailableCpuResourceResponse_data;
        
			return describeAvailableCpuResourceResponse;
        }
    }
}
