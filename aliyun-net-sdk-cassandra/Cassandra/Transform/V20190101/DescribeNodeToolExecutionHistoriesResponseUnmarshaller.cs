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
using Aliyun.Acs.Cassandra.Model.V20190101;

namespace Aliyun.Acs.Cassandra.Transform.V20190101
{
    public class DescribeNodeToolExecutionHistoriesResponseUnmarshaller
    {
        public static DescribeNodeToolExecutionHistoriesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeNodeToolExecutionHistoriesResponse describeNodeToolExecutionHistoriesResponse = new DescribeNodeToolExecutionHistoriesResponse();

			describeNodeToolExecutionHistoriesResponse.HttpResponse = context.HttpResponse;
			describeNodeToolExecutionHistoriesResponse.RequestId = context.StringValue("DescribeNodeToolExecutionHistories.RequestId");
			describeNodeToolExecutionHistoriesResponse.PageNumber = context.IntegerValue("DescribeNodeToolExecutionHistories.PageNumber");
			describeNodeToolExecutionHistoriesResponse.PageSize = context.IntegerValue("DescribeNodeToolExecutionHistories.PageSize");
			describeNodeToolExecutionHistoriesResponse.TotalCount = context.LongValue("DescribeNodeToolExecutionHistories.TotalCount");

			List<DescribeNodeToolExecutionHistoriesResponse.DescribeNodeToolExecutionHistories_History> describeNodeToolExecutionHistoriesResponse_histories = new List<DescribeNodeToolExecutionHistoriesResponse.DescribeNodeToolExecutionHistories_History>();
			for (int i = 0; i < context.Length("DescribeNodeToolExecutionHistories.Histories.Length"); i++) {
				DescribeNodeToolExecutionHistoriesResponse.DescribeNodeToolExecutionHistories_History history = new DescribeNodeToolExecutionHistoriesResponse.DescribeNodeToolExecutionHistories_History();
				history.JobId = context.StringValue("DescribeNodeToolExecutionHistories.Histories["+ i +"].JobId");
				history.Command = context.StringValue("DescribeNodeToolExecutionHistories.Histories["+ i +"].Command");
				history.Nodes = context.StringValue("DescribeNodeToolExecutionHistories.Histories["+ i +"].Nodes");
				history.ModifyTime = context.LongValue("DescribeNodeToolExecutionHistories.Histories["+ i +"].ModifyTime");
				history.CreateTime = context.LongValue("DescribeNodeToolExecutionHistories.Histories["+ i +"].CreateTime");
				history.RegionId = context.StringValue("DescribeNodeToolExecutionHistories.Histories["+ i +"].RegionId");
				history.IsEnded = context.BooleanValue("DescribeNodeToolExecutionHistories.Histories["+ i +"].IsEnded");
				history.Arguments = context.StringValue("DescribeNodeToolExecutionHistories.Histories["+ i +"].Arguments");
				history.ErrorMessage = context.StringValue("DescribeNodeToolExecutionHistories.Histories["+ i +"].ErrorMessage");
				history.DataCenterId = context.StringValue("DescribeNodeToolExecutionHistories.Histories["+ i +"].DataCenterId");

				describeNodeToolExecutionHistoriesResponse_histories.Add(history);
			}
			describeNodeToolExecutionHistoriesResponse.Histories = describeNodeToolExecutionHistoriesResponse_histories;
        
			return describeNodeToolExecutionHistoriesResponse;
        }
    }
}
