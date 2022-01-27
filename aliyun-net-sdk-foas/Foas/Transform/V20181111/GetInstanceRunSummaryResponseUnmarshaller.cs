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
        public static GetInstanceRunSummaryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetInstanceRunSummaryResponse getInstanceRunSummaryResponse = new GetInstanceRunSummaryResponse();

			getInstanceRunSummaryResponse.HttpResponse = _ctx.HttpResponse;
			getInstanceRunSummaryResponse.RequestId = _ctx.StringValue("GetInstanceRunSummary.RequestId");

			GetInstanceRunSummaryResponse.GetInstanceRunSummary_RunSummary runSummary = new GetInstanceRunSummaryResponse.GetInstanceRunSummary_RunSummary();
			runSummary.Id = _ctx.LongValue("GetInstanceRunSummary.RunSummary.Id");
			runSummary.ActualState = _ctx.StringValue("GetInstanceRunSummary.RunSummary.ActualState");
			runSummary.ExpectState = _ctx.StringValue("GetInstanceRunSummary.RunSummary.ExpectState");
			runSummary.LastErrorTime = _ctx.LongValue("GetInstanceRunSummary.RunSummary.LastErrorTime");
			runSummary.LastErrorMessage = _ctx.StringValue("GetInstanceRunSummary.RunSummary.LastErrorMessage");
			runSummary.EngineJobHandler = _ctx.StringValue("GetInstanceRunSummary.RunSummary.EngineJobHandler");
			runSummary.InputDelay = _ctx.LongValue("GetInstanceRunSummary.RunSummary.InputDelay");
			runSummary.JobName = _ctx.StringValue("GetInstanceRunSummary.RunSummary.JobName");
			getInstanceRunSummaryResponse.RunSummary = runSummary;
        
			return getInstanceRunSummaryResponse;
        }
    }
}
