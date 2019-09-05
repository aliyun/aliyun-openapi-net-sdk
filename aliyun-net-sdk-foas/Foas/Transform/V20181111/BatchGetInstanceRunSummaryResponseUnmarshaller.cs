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
using Aliyun.Acs.foas.Model.V20181111;

namespace Aliyun.Acs.foas.Transform.V20181111
{
    public class BatchGetInstanceRunSummaryResponseUnmarshaller
    {
        public static BatchGetInstanceRunSummaryResponse Unmarshall(UnmarshallerContext context)
        {
			BatchGetInstanceRunSummaryResponse batchGetInstanceRunSummaryResponse = new BatchGetInstanceRunSummaryResponse();

			batchGetInstanceRunSummaryResponse.HttpResponse = context.HttpResponse;
			batchGetInstanceRunSummaryResponse.RequestId = context.StringValue("BatchGetInstanceRunSummary.RequestId");

			List<BatchGetInstanceRunSummaryResponse.BatchGetInstanceRunSummary_RunSummary> batchGetInstanceRunSummaryResponse_runSummarys = new List<BatchGetInstanceRunSummaryResponse.BatchGetInstanceRunSummary_RunSummary>();
			for (int i = 0; i < context.Length("BatchGetInstanceRunSummary.RunSummarys.Length"); i++) {
				BatchGetInstanceRunSummaryResponse.BatchGetInstanceRunSummary_RunSummary runSummary = new BatchGetInstanceRunSummaryResponse.BatchGetInstanceRunSummary_RunSummary();
				runSummary.Id = context.LongValue("BatchGetInstanceRunSummary.RunSummarys["+ i +"].Id");
				runSummary.ActualState = context.StringValue("BatchGetInstanceRunSummary.RunSummarys["+ i +"].ActualState");
				runSummary.ExpectState = context.StringValue("BatchGetInstanceRunSummary.RunSummarys["+ i +"].ExpectState");
				runSummary.LastErrorTime = context.LongValue("BatchGetInstanceRunSummary.RunSummarys["+ i +"].LastErrorTime");
				runSummary.LastErrorMessage = context.StringValue("BatchGetInstanceRunSummary.RunSummarys["+ i +"].LastErrorMessage");
				runSummary.EngineJobHandler = context.StringValue("BatchGetInstanceRunSummary.RunSummarys["+ i +"].EngineJobHandler");
				runSummary.InputDelay = context.LongValue("BatchGetInstanceRunSummary.RunSummarys["+ i +"].InputDelay");
				runSummary.JobName = context.StringValue("BatchGetInstanceRunSummary.RunSummarys["+ i +"].JobName");

				batchGetInstanceRunSummaryResponse_runSummarys.Add(runSummary);
			}
			batchGetInstanceRunSummaryResponse.RunSummarys = batchGetInstanceRunSummaryResponse_runSummarys;
        
			return batchGetInstanceRunSummaryResponse;
        }
    }
}
