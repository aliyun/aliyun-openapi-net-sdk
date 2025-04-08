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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeActiveOperationTaskRegionResponseUnmarshaller
    {
        public static DescribeActiveOperationTaskRegionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeActiveOperationTaskRegionResponse describeActiveOperationTaskRegionResponse = new DescribeActiveOperationTaskRegionResponse();

			describeActiveOperationTaskRegionResponse.HttpResponse = _ctx.HttpResponse;
			describeActiveOperationTaskRegionResponse.RequestId = _ctx.StringValue("DescribeActiveOperationTaskRegion.RequestId");

			List<DescribeActiveOperationTaskRegionResponse.DescribeActiveOperationTaskRegion_Items> describeActiveOperationTaskRegionResponse_regionList = new List<DescribeActiveOperationTaskRegionResponse.DescribeActiveOperationTaskRegion_Items>();
			for (int i = 0; i < _ctx.Length("DescribeActiveOperationTaskRegion.RegionList.Length"); i++) {
				DescribeActiveOperationTaskRegionResponse.DescribeActiveOperationTaskRegion_Items items = new DescribeActiveOperationTaskRegionResponse.DescribeActiveOperationTaskRegion_Items();
				items.Region = _ctx.StringValue("DescribeActiveOperationTaskRegion.RegionList["+ i +"].Region");
				items.Count = _ctx.IntegerValue("DescribeActiveOperationTaskRegion.RegionList["+ i +"].Count");

				describeActiveOperationTaskRegionResponse_regionList.Add(items);
			}
			describeActiveOperationTaskRegionResponse.RegionList = describeActiveOperationTaskRegionResponse_regionList;
        
			return describeActiveOperationTaskRegionResponse;
        }
    }
}
