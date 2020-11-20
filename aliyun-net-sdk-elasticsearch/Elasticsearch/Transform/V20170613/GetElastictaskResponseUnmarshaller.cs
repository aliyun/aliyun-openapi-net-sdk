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
    public class GetElastictaskResponseUnmarshaller
    {
        public static GetElastictaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetElastictaskResponse getElastictaskResponse = new GetElastictaskResponse();

			getElastictaskResponse.HttpResponse = _ctx.HttpResponse;
			getElastictaskResponse.RequestId = _ctx.StringValue("GetElastictask.RequestId");

			GetElastictaskResponse.GetElastictask_Result result = new GetElastictaskResponse.GetElastictask_Result();

			GetElastictaskResponse.GetElastictask_Result.GetElastictask_ElasticExpansionTask elasticExpansionTask = new GetElastictaskResponse.GetElastictask_Result.GetElastictask_ElasticExpansionTask();
			elasticExpansionTask.TriggerType = _ctx.StringValue("GetElastictask.Result.ElasticExpansionTask.triggerType");
			elasticExpansionTask.CronExpression = _ctx.StringValue("GetElastictask.Result.ElasticExpansionTask.cronExpression");
			elasticExpansionTask.ElasticNodeCount = _ctx.IntegerValue("GetElastictask.Result.ElasticExpansionTask.elasticNodeCount");
			elasticExpansionTask.ReplicaCount = _ctx.IntegerValue("GetElastictask.Result.ElasticExpansionTask.replicaCount");

			List<string> elasticExpansionTask_targetIndices = new List<string>();
			for (int i = 0; i < _ctx.Length("GetElastictask.Result.ElasticExpansionTask.TargetIndices.Length"); i++) {
				elasticExpansionTask_targetIndices.Add(_ctx.StringValue("GetElastictask.Result.ElasticExpansionTask.TargetIndices["+ i +"]"));
			}
			elasticExpansionTask.TargetIndices = elasticExpansionTask_targetIndices;
			result.ElasticExpansionTask = elasticExpansionTask;

			GetElastictaskResponse.GetElastictask_Result.GetElastictask_ElasticShrinkTask elasticShrinkTask = new GetElastictaskResponse.GetElastictask_Result.GetElastictask_ElasticShrinkTask();
			elasticShrinkTask.TriggerType = _ctx.StringValue("GetElastictask.Result.ElasticShrinkTask.triggerType");
			elasticShrinkTask.CronExpression = _ctx.StringValue("GetElastictask.Result.ElasticShrinkTask.cronExpression");
			elasticShrinkTask.ElasticNodeCount = _ctx.IntegerValue("GetElastictask.Result.ElasticShrinkTask.elasticNodeCount");
			elasticShrinkTask.ReplicaCount = _ctx.IntegerValue("GetElastictask.Result.ElasticShrinkTask.replicaCount");

			List<string> elasticShrinkTask_targetIndices1 = new List<string>();
			for (int i = 0; i < _ctx.Length("GetElastictask.Result.ElasticShrinkTask.TargetIndices.Length"); i++) {
				elasticShrinkTask_targetIndices1.Add(_ctx.StringValue("GetElastictask.Result.ElasticShrinkTask.TargetIndices["+ i +"]"));
			}
			elasticShrinkTask.TargetIndices1 = elasticShrinkTask_targetIndices1;
			result.ElasticShrinkTask = elasticShrinkTask;
			getElastictaskResponse.Result = result;
        
			return getElastictaskResponse;
        }
    }
}
