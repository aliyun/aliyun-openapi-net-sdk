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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ess.Model.V20140828;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ess.Transform.V20140828
{
    public class DescribeCapacityHistoryResponseUnmarshaller
    {
        public static DescribeCapacityHistoryResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCapacityHistoryResponse describeCapacityHistoryResponse = new DescribeCapacityHistoryResponse();

			describeCapacityHistoryResponse.HttpResponse = context.HttpResponse;
			describeCapacityHistoryResponse.TotalCount = context.IntegerValue("DescribeCapacityHistory.TotalCount");
			describeCapacityHistoryResponse.PageNumber = context.IntegerValue("DescribeCapacityHistory.PageNumber");
			describeCapacityHistoryResponse.PageSize = context.IntegerValue("DescribeCapacityHistory.PageSize");

			List<DescribeCapacityHistoryResponse.DescribeCapacityHistory_CapacityHistoryModel> describeCapacityHistoryResponse_capacityHistoryItems = new List<DescribeCapacityHistoryResponse.DescribeCapacityHistory_CapacityHistoryModel>();
			for (int i = 0; i < context.Length("DescribeCapacityHistory.CapacityHistoryItems.Length"); i++) {
				DescribeCapacityHistoryResponse.DescribeCapacityHistory_CapacityHistoryModel capacityHistoryModel = new DescribeCapacityHistoryResponse.DescribeCapacityHistory_CapacityHistoryModel();
				capacityHistoryModel.ScalingGroupId = context.StringValue("DescribeCapacityHistory.CapacityHistoryItems["+ i +"].ScalingGroupId");
				capacityHistoryModel.TotalCapacity = context.IntegerValue("DescribeCapacityHistory.CapacityHistoryItems["+ i +"].TotalCapacity");
				capacityHistoryModel.AttachedCapacity = context.IntegerValue("DescribeCapacityHistory.CapacityHistoryItems["+ i +"].AttachedCapacity");
				capacityHistoryModel.AutoCreatedCapacity = context.IntegerValue("DescribeCapacityHistory.CapacityHistoryItems["+ i +"].AutoCreatedCapacity");
				capacityHistoryModel.Timestamp = context.StringValue("DescribeCapacityHistory.CapacityHistoryItems["+ i +"].Timestamp");

				describeCapacityHistoryResponse_capacityHistoryItems.Add(capacityHistoryModel);
			}
			describeCapacityHistoryResponse.CapacityHistoryItems = describeCapacityHistoryResponse_capacityHistoryItems;
        
			return describeCapacityHistoryResponse;
        }
    }
}