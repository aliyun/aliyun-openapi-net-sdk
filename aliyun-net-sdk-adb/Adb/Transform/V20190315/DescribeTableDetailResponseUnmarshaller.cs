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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeTableDetailResponseUnmarshaller
    {
        public static DescribeTableDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTableDetailResponse describeTableDetailResponse = new DescribeTableDetailResponse();

			describeTableDetailResponse.HttpResponse = context.HttpResponse;
			describeTableDetailResponse.RequestId = context.StringValue("DescribeTableDetail.RequestId");
			describeTableDetailResponse.AvgSize = context.LongValue("DescribeTableDetail.AvgSize");

			List<DescribeTableDetailResponse.DescribeTableDetail_Shard> describeTableDetailResponse_items = new List<DescribeTableDetailResponse.DescribeTableDetail_Shard>();
			for (int i = 0; i < context.Length("DescribeTableDetail.Items.Length"); i++) {
				DescribeTableDetailResponse.DescribeTableDetail_Shard shard = new DescribeTableDetailResponse.DescribeTableDetail_Shard();
				shard.Id = context.IntegerValue("DescribeTableDetail.Items["+ i +"].Id");
				shard.Size = context.LongValue("DescribeTableDetail.Items["+ i +"].Size");

				describeTableDetailResponse_items.Add(shard);
			}
			describeTableDetailResponse.Items = describeTableDetailResponse_items;
        
			return describeTableDetailResponse;
        }
    }
}
