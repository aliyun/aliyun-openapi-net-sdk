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
        public static DescribeNodeToolExecutionHistoryResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeNodeToolExecutionHistoryResponse describeNodeToolExecutionHistoryResponse = new DescribeNodeToolExecutionHistoryResponse();

			describeNodeToolExecutionHistoryResponse.HttpResponse = context.HttpResponse;
			describeNodeToolExecutionHistoryResponse.RequestId = context.StringValue("DescribeNodeToolExecutionHistory.RequestId");
			describeNodeToolExecutionHistoryResponse.JobId = context.StringValue("DescribeNodeToolExecutionHistory.JobId");
			describeNodeToolExecutionHistoryResponse.Command = context.StringValue("DescribeNodeToolExecutionHistory.Command");
			describeNodeToolExecutionHistoryResponse.Nodes = context.StringValue("DescribeNodeToolExecutionHistory.Nodes");
			describeNodeToolExecutionHistoryResponse.ModifyTime = context.LongValue("DescribeNodeToolExecutionHistory.ModifyTime");
			describeNodeToolExecutionHistoryResponse.CreateTime = context.LongValue("DescribeNodeToolExecutionHistory.CreateTime");
			describeNodeToolExecutionHistoryResponse.RegionId = context.StringValue("DescribeNodeToolExecutionHistory.RegionId");
			describeNodeToolExecutionHistoryResponse.IsEnded = context.BooleanValue("DescribeNodeToolExecutionHistory.IsEnded");
			describeNodeToolExecutionHistoryResponse.Arguments = context.StringValue("DescribeNodeToolExecutionHistory.Arguments");
			describeNodeToolExecutionHistoryResponse.ErrorMessage = context.StringValue("DescribeNodeToolExecutionHistory.ErrorMessage");
			describeNodeToolExecutionHistoryResponse.DataCenterId = context.StringValue("DescribeNodeToolExecutionHistory.DataCenterId");
			describeNodeToolExecutionHistoryResponse.Result = context.StringValue("DescribeNodeToolExecutionHistory.Result");
        
			return describeNodeToolExecutionHistoryResponse;
        }
    }
}
