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
        public static DescribeNodeToolExecutionHistoriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeNodeToolExecutionHistoriesResponse describeNodeToolExecutionHistoriesResponse = new DescribeNodeToolExecutionHistoriesResponse();

			describeNodeToolExecutionHistoriesResponse.HttpResponse = _ctx.HttpResponse;
			describeNodeToolExecutionHistoriesResponse.RequestId = _ctx.StringValue("DescribeNodeToolExecutionHistories.RequestId");
			describeNodeToolExecutionHistoriesResponse.PageNumber = _ctx.IntegerValue("DescribeNodeToolExecutionHistories.PageNumber");
			describeNodeToolExecutionHistoriesResponse.PageSize = _ctx.IntegerValue("DescribeNodeToolExecutionHistories.PageSize");
			describeNodeToolExecutionHistoriesResponse.TotalCount = _ctx.LongValue("DescribeNodeToolExecutionHistories.TotalCount");

			List<DescribeNodeToolExecutionHistoriesResponse.DescribeNodeToolExecutionHistories_History> describeNodeToolExecutionHistoriesResponse_histories = new List<DescribeNodeToolExecutionHistoriesResponse.DescribeNodeToolExecutionHistories_History>();
			for (int i = 0; i < _ctx.Length("DescribeNodeToolExecutionHistories.Histories.Length"); i++) {
				DescribeNodeToolExecutionHistoriesResponse.DescribeNodeToolExecutionHistories_History history = new DescribeNodeToolExecutionHistoriesResponse.DescribeNodeToolExecutionHistories_History();
				history.JobId = _ctx.StringValue("DescribeNodeToolExecutionHistories.Histories["+ i +"].JobId");
				history.Command = _ctx.StringValue("DescribeNodeToolExecutionHistories.Histories["+ i +"].Command");
				history.Nodes = _ctx.StringValue("DescribeNodeToolExecutionHistories.Histories["+ i +"].Nodes");
				history.ModifyTime = _ctx.LongValue("DescribeNodeToolExecutionHistories.Histories["+ i +"].ModifyTime");
				history.CreateTime = _ctx.LongValue("DescribeNodeToolExecutionHistories.Histories["+ i +"].CreateTime");
				history.RegionId = _ctx.StringValue("DescribeNodeToolExecutionHistories.Histories["+ i +"].RegionId");
				history.IsEnded = _ctx.BooleanValue("DescribeNodeToolExecutionHistories.Histories["+ i +"].IsEnded");
				history.Arguments = _ctx.StringValue("DescribeNodeToolExecutionHistories.Histories["+ i +"].Arguments");
				history.ErrorMessage = _ctx.StringValue("DescribeNodeToolExecutionHistories.Histories["+ i +"].ErrorMessage");
				history.DataCenterId = _ctx.StringValue("DescribeNodeToolExecutionHistories.Histories["+ i +"].DataCenterId");

				describeNodeToolExecutionHistoriesResponse_histories.Add(history);
			}
			describeNodeToolExecutionHistoriesResponse.Histories = describeNodeToolExecutionHistoriesResponse_histories;
        
			return describeNodeToolExecutionHistoriesResponse;
        }
    }
}
