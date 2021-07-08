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
    public class DescribeNodeToolExecutionHistoryResponseUnmarshaller
    {
        public static DescribeNodeToolExecutionHistoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeNodeToolExecutionHistoryResponse describeNodeToolExecutionHistoryResponse = new DescribeNodeToolExecutionHistoryResponse();

			describeNodeToolExecutionHistoryResponse.HttpResponse = _ctx.HttpResponse;
			describeNodeToolExecutionHistoryResponse.RequestId = _ctx.StringValue("DescribeNodeToolExecutionHistory.RequestId");
			describeNodeToolExecutionHistoryResponse.JobId = _ctx.StringValue("DescribeNodeToolExecutionHistory.JobId");
			describeNodeToolExecutionHistoryResponse.Command = _ctx.StringValue("DescribeNodeToolExecutionHistory.Command");
			describeNodeToolExecutionHistoryResponse.Nodes = _ctx.StringValue("DescribeNodeToolExecutionHistory.Nodes");
			describeNodeToolExecutionHistoryResponse.ModifyTime = _ctx.LongValue("DescribeNodeToolExecutionHistory.ModifyTime");
			describeNodeToolExecutionHistoryResponse.CreateTime = _ctx.LongValue("DescribeNodeToolExecutionHistory.CreateTime");
			describeNodeToolExecutionHistoryResponse.RegionId = _ctx.StringValue("DescribeNodeToolExecutionHistory.RegionId");
			describeNodeToolExecutionHistoryResponse.IsEnded = _ctx.BooleanValue("DescribeNodeToolExecutionHistory.IsEnded");
			describeNodeToolExecutionHistoryResponse.Arguments = _ctx.StringValue("DescribeNodeToolExecutionHistory.Arguments");
			describeNodeToolExecutionHistoryResponse.ErrorMessage = _ctx.StringValue("DescribeNodeToolExecutionHistory.ErrorMessage");
			describeNodeToolExecutionHistoryResponse.DataCenterId = _ctx.StringValue("DescribeNodeToolExecutionHistory.DataCenterId");
			describeNodeToolExecutionHistoryResponse.Result = _ctx.StringValue("DescribeNodeToolExecutionHistory.Result");
        
			return describeNodeToolExecutionHistoryResponse;
        }
    }
}
