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
using Aliyun.Acs.Yundun_ds.Model.V20190103;

namespace Aliyun.Acs.Yundun_ds.Transform.V20190103
{
    public class DescribeTransferEventCountsResponseUnmarshaller
    {
        public static DescribeTransferEventCountsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTransferEventCountsResponse describeTransferEventCountsResponse = new DescribeTransferEventCountsResponse();

			describeTransferEventCountsResponse.HttpResponse = context.HttpResponse;
			describeTransferEventCountsResponse.RequestId = context.StringValue("DescribeTransferEventCounts.RequestId");

			List<DescribeTransferEventCountsResponse.DescribeTransferEventCounts_Transfer> describeTransferEventCountsResponse_transferEventCountList = new List<DescribeTransferEventCountsResponse.DescribeTransferEventCounts_Transfer>();
			for (int i = 0; i < context.Length("DescribeTransferEventCounts.TransferEventCountList.Length"); i++) {
				DescribeTransferEventCountsResponse.DescribeTransferEventCounts_Transfer transfer = new DescribeTransferEventCountsResponse.DescribeTransferEventCounts_Transfer();
				transfer.TotalCount = context.LongValue("DescribeTransferEventCounts.TransferEventCountList["+ i +"].TotalCount");
				transfer.ProductCode = context.StringValue("DescribeTransferEventCounts.TransferEventCountList["+ i +"].ProductCode");
				transfer.TargetProductCode = context.StringValue("DescribeTransferEventCounts.TransferEventCountList["+ i +"].TargetProductCode");

				describeTransferEventCountsResponse_transferEventCountList.Add(transfer);
			}
			describeTransferEventCountsResponse.TransferEventCountList = describeTransferEventCountsResponse_transferEventCountList;
        
			return describeTransferEventCountsResponse;
        }
    }
}
