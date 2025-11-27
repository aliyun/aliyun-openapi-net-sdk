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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class DescribePipelineResponseUnmarshaller
    {
        public static DescribePipelineResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePipelineResponse describePipelineResponse = new DescribePipelineResponse();

			describePipelineResponse.HttpResponse = _ctx.HttpResponse;
			describePipelineResponse.RequestId = _ctx.StringValue("DescribePipeline.RequestId");

			DescribePipelineResponse.DescribePipeline_Result result = new DescribePipelineResponse.DescribePipeline_Result();
			result.PipelineId = _ctx.StringValue("DescribePipeline.Result.pipelineId");
			result.GmtUpdateTime = _ctx.StringValue("DescribePipeline.Result.gmtUpdateTime");
			result.QueueType = _ctx.StringValue("DescribePipeline.Result.queueType");
			result.QueueCheckPointWrites = _ctx.IntegerValue("DescribePipeline.Result.queueCheckPointWrites");
			result.QueueMaxBytes = _ctx.IntegerValue("DescribePipeline.Result.queueMaxBytes");
			result.Config = _ctx.StringValue("DescribePipeline.Result.config");
			result.BatchDelay = _ctx.IntegerValue("DescribePipeline.Result.batchDelay");
			result.Workers = _ctx.IntegerValue("DescribePipeline.Result.workers");
			result.Description = _ctx.StringValue("DescribePipeline.Result.description");
			result.GmtCreatedTime = _ctx.StringValue("DescribePipeline.Result.gmtCreatedTime");
			result.BatchSize = _ctx.IntegerValue("DescribePipeline.Result.batchSize");
			result.PipelineStatus = _ctx.StringValue("DescribePipeline.Result.pipelineStatus");
			describePipelineResponse.Result = result;
        
			return describePipelineResponse;
        }
    }
}
