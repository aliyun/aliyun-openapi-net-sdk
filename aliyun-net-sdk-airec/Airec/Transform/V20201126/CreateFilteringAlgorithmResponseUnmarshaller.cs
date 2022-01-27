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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class CreateFilteringAlgorithmResponseUnmarshaller
    {
        public static CreateFilteringAlgorithmResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateFilteringAlgorithmResponse createFilteringAlgorithmResponse = new CreateFilteringAlgorithmResponse();

			createFilteringAlgorithmResponse.HttpResponse = _ctx.HttpResponse;
			createFilteringAlgorithmResponse.RequestId = _ctx.StringValue("CreateFilteringAlgorithm.requestId");

			CreateFilteringAlgorithmResponse.CreateFilteringAlgorithm_Result result = new CreateFilteringAlgorithmResponse.CreateFilteringAlgorithm_Result();
			result.AlgorithmId = _ctx.StringValue("CreateFilteringAlgorithm.Result.algorithmId");
			result.Status = _ctx.StringValue("CreateFilteringAlgorithm.Result.status");
			result.GmtCreate = _ctx.StringValue("CreateFilteringAlgorithm.Result.gmtCreate");
			result.GmtModified = _ctx.StringValue("CreateFilteringAlgorithm.Result.gmtModified");

			CreateFilteringAlgorithmResponse.CreateFilteringAlgorithm_Result.CreateFilteringAlgorithm_Meta meta = new CreateFilteringAlgorithmResponse.CreateFilteringAlgorithm_Result.CreateFilteringAlgorithm_Meta();
			meta.AlgorithmName = _ctx.StringValue("CreateFilteringAlgorithm.Result.Meta.algorithmName");
			meta.Type = _ctx.StringValue("CreateFilteringAlgorithm.Result.Meta.type");
			meta.ProjectName = _ctx.StringValue("CreateFilteringAlgorithm.Result.Meta.projectName");
			meta.TableName = _ctx.StringValue("CreateFilteringAlgorithm.Result.Meta.tableName");
			meta.Category = _ctx.StringValue("CreateFilteringAlgorithm.Result.Meta.category");
			meta.ExtInfo = _ctx.StringValue("CreateFilteringAlgorithm.Result.Meta.extInfo");
			meta.Cron = _ctx.StringValue("CreateFilteringAlgorithm.Result.Meta.cron");
			meta.CronEnabled = _ctx.BooleanValue("CreateFilteringAlgorithm.Result.Meta.cronEnabled");
			meta.GmtModified = _ctx.StringValue("CreateFilteringAlgorithm.Result.Meta.gmtModified");
			meta.GmtCreate = _ctx.StringValue("CreateFilteringAlgorithm.Result.Meta.gmtCreate");
			meta.Status = _ctx.StringValue("CreateFilteringAlgorithm.Result.Meta.status");
			meta.Description = _ctx.StringValue("CreateFilteringAlgorithm.Result.Meta.description");

			CreateFilteringAlgorithmResponse.CreateFilteringAlgorithm_Result.CreateFilteringAlgorithm_Meta.CreateFilteringAlgorithm_Threshold threshold = new CreateFilteringAlgorithmResponse.CreateFilteringAlgorithm_Result.CreateFilteringAlgorithm_Meta.CreateFilteringAlgorithm_Threshold();
			threshold.IndexLossThreshold = _ctx.IntegerValue("CreateFilteringAlgorithm.Result.Meta.Threshold.indexLossThreshold");
			threshold.IndexSizeThreshold = _ctx.IntegerValue("CreateFilteringAlgorithm.Result.Meta.Threshold.indexSizeThreshold");
			threshold.SourceDataSizeThreshold = _ctx.IntegerValue("CreateFilteringAlgorithm.Result.Meta.Threshold.sourceDataSizeThreshold");
			threshold.SourceDataRecordThreshold = _ctx.IntegerValue("CreateFilteringAlgorithm.Result.Meta.Threshold.sourceDataRecordThreshold");
			meta.Threshold = threshold;
			result.Meta = meta;
			createFilteringAlgorithmResponse.Result = result;
        
			return createFilteringAlgorithmResponse;
        }
    }
}
