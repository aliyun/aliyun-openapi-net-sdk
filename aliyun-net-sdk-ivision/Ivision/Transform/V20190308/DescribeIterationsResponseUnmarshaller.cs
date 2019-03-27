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
using Aliyun.Acs.ivision.Model.V20190308;

namespace Aliyun.Acs.ivision.Transform.V20190308
{
    public class DescribeIterationsResponseUnmarshaller
    {
        public static DescribeIterationsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeIterationsResponse describeIterationsResponse = new DescribeIterationsResponse();

			describeIterationsResponse.HttpResponse = context.HttpResponse;
			describeIterationsResponse.RequestId = context.StringValue("DescribeIterations.RequestId");
			describeIterationsResponse.TotalNum = context.LongValue("DescribeIterations.TotalNum");
			describeIterationsResponse.CurrentPage = context.LongValue("DescribeIterations.CurrentPage");
			describeIterationsResponse.PageSize = context.LongValue("DescribeIterations.PageSize");
			describeIterationsResponse.NextPageToken = context.StringValue("DescribeIterations.NextPageToken");

			List<DescribeIterationsResponse.DescribeIterations_Iteration> describeIterationsResponse_iterations = new List<DescribeIterationsResponse.DescribeIterations_Iteration>();
			for (int i = 0; i < context.Length("DescribeIterations.Iterations.Length"); i++) {
				DescribeIterationsResponse.DescribeIterations_Iteration iteration = new DescribeIterationsResponse.DescribeIterations_Iteration();
				iteration.ProjectId = context.StringValue("DescribeIterations.Iterations["+ i +"].ProjectId");
				iteration.IterationId = context.StringValue("DescribeIterations.Iterations["+ i +"].IterationId");
				iteration.IterationName = context.StringValue("DescribeIterations.Iterations["+ i +"].IterationName");
				iteration.Status = context.StringValue("DescribeIterations.Iterations["+ i +"].Status");
				iteration.CreationTime = context.StringValue("DescribeIterations.Iterations["+ i +"].CreationTime");
				iteration.FinishTime = context.StringValue("DescribeIterations.Iterations["+ i +"].FinishTime");
				iteration.ModelId = context.StringValue("DescribeIterations.Iterations["+ i +"].ModelId");
				iteration.Precision = context.StringValue("DescribeIterations.Iterations["+ i +"].Precision");
				iteration.Recall = context.StringValue("DescribeIterations.Iterations["+ i +"].Recall");
				iteration.MAP = context.StringValue("DescribeIterations.Iterations["+ i +"].MAP");

				describeIterationsResponse_iterations.Add(iteration);
			}
			describeIterationsResponse.Iterations = describeIterationsResponse_iterations;
        
			return describeIterationsResponse;
        }
    }
}
