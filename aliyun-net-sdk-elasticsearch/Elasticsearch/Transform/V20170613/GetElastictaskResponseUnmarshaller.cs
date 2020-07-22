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
        public static GetElastictaskResponse Unmarshall(UnmarshallerContext context)
        {
			GetElastictaskResponse getElastictaskResponse = new GetElastictaskResponse();

			getElastictaskResponse.HttpResponse = context.HttpResponse;
			getElastictaskResponse.RequestId = context.StringValue("GetElastictask.RequestId");

			GetElastictaskResponse.GetElastictask_Result result = new GetElastictaskResponse.GetElastictask_Result();

			GetElastictaskResponse.GetElastictask_Result.GetElastictask_ElasticExpansionTask elasticExpansionTask = new GetElastictaskResponse.GetElastictask_Result.GetElastictask_ElasticExpansionTask();
			elasticExpansionTask.TriggerType = context.StringValue("GetElastictask.Result.ElasticExpansionTask.TriggerType");
			elasticExpansionTask.CronExpression = context.StringValue("GetElastictask.Result.ElasticExpansionTask.CronExpression");
			elasticExpansionTask.ElasticNodeCount = context.IntegerValue("GetElastictask.Result.ElasticExpansionTask.ElasticNodeCount");
			elasticExpansionTask.ReplicaCount = context.IntegerValue("GetElastictask.Result.ElasticExpansionTask.ReplicaCount");

			List<string> elasticExpansionTask_targetIndices = new List<string>();
			for (int i = 0; i < context.Length("GetElastictask.Result.ElasticExpansionTask.TargetIndices.Length"); i++) {
				elasticExpansionTask_targetIndices.Add(context.StringValue("GetElastictask.Result.ElasticExpansionTask.TargetIndices["+ i +"]"));
			}
			elasticExpansionTask.TargetIndices = elasticExpansionTask_targetIndices;
			result.ElasticExpansionTask = elasticExpansionTask;

			GetElastictaskResponse.GetElastictask_Result.GetElastictask_ElasticShrinkTask elasticShrinkTask = new GetElastictaskResponse.GetElastictask_Result.GetElastictask_ElasticShrinkTask();
			elasticShrinkTask.TriggerType = context.StringValue("GetElastictask.Result.ElasticShrinkTask.TriggerType");
			elasticShrinkTask.CronExpression = context.StringValue("GetElastictask.Result.ElasticShrinkTask.CronExpression");
			elasticShrinkTask.ElasticNodeCount = context.IntegerValue("GetElastictask.Result.ElasticShrinkTask.ElasticNodeCount");
			elasticShrinkTask.ReplicaCount = context.IntegerValue("GetElastictask.Result.ElasticShrinkTask.ReplicaCount");

			List<string> elasticShrinkTask_targetIndices1 = new List<string>();
			for (int i = 0; i < context.Length("GetElastictask.Result.ElasticShrinkTask.TargetIndices.Length"); i++) {
				elasticShrinkTask_targetIndices1.Add(context.StringValue("GetElastictask.Result.ElasticShrinkTask.TargetIndices["+ i +"]"));
			}
			elasticShrinkTask.TargetIndices1 = elasticShrinkTask_targetIndices1;
			result.ElasticShrinkTask = elasticShrinkTask;
			getElastictaskResponse.Result = result;
        
			return getElastictaskResponse;
        }
    }
}
