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
    public class DeleteFilteringAlgorithmResponseUnmarshaller
    {
        public static DeleteFilteringAlgorithmResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteFilteringAlgorithmResponse deleteFilteringAlgorithmResponse = new DeleteFilteringAlgorithmResponse();

			deleteFilteringAlgorithmResponse.HttpResponse = _ctx.HttpResponse;
			deleteFilteringAlgorithmResponse.RequestId = _ctx.StringValue("DeleteFilteringAlgorithm.requestId");

			DeleteFilteringAlgorithmResponse.DeleteFilteringAlgorithm_Result result = new DeleteFilteringAlgorithmResponse.DeleteFilteringAlgorithm_Result();
			result.Status = _ctx.StringValue("DeleteFilteringAlgorithm.Result.status");
			result.GmtCreate = _ctx.StringValue("DeleteFilteringAlgorithm.Result.gmtCreate");
			result.GmtModified = _ctx.StringValue("DeleteFilteringAlgorithm.Result.gmtModified");
			result.AlgorithmId = _ctx.StringValue("DeleteFilteringAlgorithm.Result.algorithmId");

			DeleteFilteringAlgorithmResponse.DeleteFilteringAlgorithm_Result.DeleteFilteringAlgorithm_Meta meta = new DeleteFilteringAlgorithmResponse.DeleteFilteringAlgorithm_Result.DeleteFilteringAlgorithm_Meta();
			meta.MetaType = _ctx.StringValue("DeleteFilteringAlgorithm.Result.Meta.metaType");
			meta.AlgorithmName = _ctx.StringValue("DeleteFilteringAlgorithm.Result.Meta.algorithmName");
			meta.Cron = _ctx.StringValue("DeleteFilteringAlgorithm.Result.Meta.cron");
			meta.CronEnabled = _ctx.BooleanValue("DeleteFilteringAlgorithm.Result.Meta.cronEnabled");
			meta.TaskId = _ctx.StringValue("DeleteFilteringAlgorithm.Result.Meta.taskId");
			meta.ProjectName = _ctx.StringValue("DeleteFilteringAlgorithm.Result.Meta.projectName");
			meta.TableName = _ctx.StringValue("DeleteFilteringAlgorithm.Result.Meta.tableName");
			meta.Type = _ctx.StringValue("DeleteFilteringAlgorithm.Result.Meta.type");
			meta.Category = _ctx.StringValue("DeleteFilteringAlgorithm.Result.Meta.category");
			meta.ClusterId = _ctx.StringValue("DeleteFilteringAlgorithm.Result.Meta.clusterId");
			meta.Description = _ctx.StringValue("DeleteFilteringAlgorithm.Result.Meta.description");

			DeleteFilteringAlgorithmResponse.DeleteFilteringAlgorithm_Result.DeleteFilteringAlgorithm_Meta.DeleteFilteringAlgorithm_ExtInfo extInfo = new DeleteFilteringAlgorithmResponse.DeleteFilteringAlgorithm_Result.DeleteFilteringAlgorithm_Meta.DeleteFilteringAlgorithm_ExtInfo();
			extInfo.ItemSeparator = _ctx.StringValue("DeleteFilteringAlgorithm.Result.Meta.ExtInfo.itemSeparator");
			extInfo.KvSeparator = _ctx.StringValue("DeleteFilteringAlgorithm.Result.Meta.ExtInfo.kvSeparator");
			meta.ExtInfo = extInfo;

			DeleteFilteringAlgorithmResponse.DeleteFilteringAlgorithm_Result.DeleteFilteringAlgorithm_Meta.DeleteFilteringAlgorithm_Threshold threshold = new DeleteFilteringAlgorithmResponse.DeleteFilteringAlgorithm_Result.DeleteFilteringAlgorithm_Meta.DeleteFilteringAlgorithm_Threshold();
			threshold.IndexLossThreshold = _ctx.IntegerValue("DeleteFilteringAlgorithm.Result.Meta.Threshold.indexLossThreshold");
			threshold.IndexSizeThreshold = _ctx.IntegerValue("DeleteFilteringAlgorithm.Result.Meta.Threshold.indexSizeThreshold");
			threshold.SourceDataSizeThreshold = _ctx.IntegerValue("DeleteFilteringAlgorithm.Result.Meta.Threshold.sourceDataSizeThreshold");
			threshold.SourceDataRecordThreshold = _ctx.IntegerValue("DeleteFilteringAlgorithm.Result.Meta.Threshold.sourceDataRecordThreshold");
			meta.Threshold = threshold;
			result.Meta = meta;
			deleteFilteringAlgorithmResponse.Result = result;
        
			return deleteFilteringAlgorithmResponse;
        }
    }
}
