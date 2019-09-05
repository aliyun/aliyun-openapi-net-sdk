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
    public class GetInstanceRunSummaryResponseUnmarshaller
    {
        public static GetInstanceRunSummaryResponse Unmarshall(UnmarshallerContext context)
        {
			GetInstanceRunSummaryResponse getInstanceRunSummaryResponse = new GetInstanceRunSummaryResponse();

			getInstanceRunSummaryResponse.HttpResponse = context.HttpResponse;
			getInstanceRunSummaryResponse.RequestId = context.StringValue("GetInstanceRunSummary.RequestId");

			GetInstanceRunSummaryResponse.GetInstanceRunSummary_RunSummary runSummary = new GetInstanceRunSummaryResponse.GetInstanceRunSummary_RunSummary();
			runSummary.Id = context.LongValue("GetInstanceRunSummary.RunSummary.Id");
			runSummary.ActualState = context.StringValue("GetInstanceRunSummary.RunSummary.ActualState");
			runSummary.ExpectState = context.StringValue("GetInstanceRunSummary.RunSummary.ExpectState");
			runSummary.LastErrorTime = context.LongValue("GetInstanceRunSummary.RunSummary.LastErrorTime");
			runSummary.LastErrorMessage = context.StringValue("GetInstanceRunSummary.RunSummary.LastErrorMessage");
			runSummary.EngineJobHandler = context.StringValue("GetInstanceRunSummary.RunSummary.EngineJobHandler");
			runSummary.InputDelay = context.LongValue("GetInstanceRunSummary.RunSummary.InputDelay");
			runSummary.JobName = context.StringValue("GetInstanceRunSummary.RunSummary.JobName");
			getInstanceRunSummaryResponse.RunSummary = runSummary;
        
			return getInstanceRunSummaryResponse;
        }
    }
}
