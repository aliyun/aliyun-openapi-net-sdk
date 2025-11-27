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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class QueryIProductionJobResponseUnmarshaller
    {
        public static QueryIProductionJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryIProductionJobResponse queryIProductionJobResponse = new QueryIProductionJobResponse();

			queryIProductionJobResponse.HttpResponse = _ctx.HttpResponse;
			queryIProductionJobResponse.FunctionName = _ctx.StringValue("QueryIProductionJob.FunctionName");
			queryIProductionJobResponse.Input = _ctx.StringValue("QueryIProductionJob.Input");
			queryIProductionJobResponse.RequestId = _ctx.StringValue("QueryIProductionJob.RequestId");
			queryIProductionJobResponse.UserData = _ctx.StringValue("QueryIProductionJob.UserData");
			queryIProductionJobResponse.State = _ctx.StringValue("QueryIProductionJob.State");
			queryIProductionJobResponse.Output = _ctx.StringValue("QueryIProductionJob.Output");
			queryIProductionJobResponse.PipelineId = _ctx.StringValue("QueryIProductionJob.PipelineId");
			queryIProductionJobResponse.JobParams = _ctx.StringValue("QueryIProductionJob.JobParams");
			queryIProductionJobResponse.JobId = _ctx.StringValue("QueryIProductionJob.JobId");
			queryIProductionJobResponse.Result = _ctx.StringValue("QueryIProductionJob.Result");
        
			return queryIProductionJobResponse;
        }
    }
}
