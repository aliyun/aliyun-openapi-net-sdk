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
    public class OfflineFilteringAlgorithmResponseUnmarshaller
    {
        public static OfflineFilteringAlgorithmResponse Unmarshall(UnmarshallerContext _ctx)
        {
			OfflineFilteringAlgorithmResponse offlineFilteringAlgorithmResponse = new OfflineFilteringAlgorithmResponse();

			offlineFilteringAlgorithmResponse.HttpResponse = _ctx.HttpResponse;
			offlineFilteringAlgorithmResponse.RequestId = _ctx.StringValue("OfflineFilteringAlgorithm.requestId");

			OfflineFilteringAlgorithmResponse.OfflineFilteringAlgorithm_Result result = new OfflineFilteringAlgorithmResponse.OfflineFilteringAlgorithm_Result();
			result.Status = _ctx.StringValue("OfflineFilteringAlgorithm.Result.status");
			result.GmtCreate = _ctx.StringValue("OfflineFilteringAlgorithm.Result.gmtCreate");
			result.GmtModified = _ctx.StringValue("OfflineFilteringAlgorithm.Result.gmtModified");
			result.AlgorithmId = _ctx.StringValue("OfflineFilteringAlgorithm.Result.algorithmId");

			OfflineFilteringAlgorithmResponse.OfflineFilteringAlgorithm_Result.OfflineFilteringAlgorithm_Meta meta = new OfflineFilteringAlgorithmResponse.OfflineFilteringAlgorithm_Result.OfflineFilteringAlgorithm_Meta();
			meta.MetaType = _ctx.StringValue("OfflineFilteringAlgorithm.Result.Meta.metaType");
			meta.AlgorithmName = _ctx.StringValue("OfflineFilteringAlgorithm.Result.Meta.algorithmName");
			meta.Cron = _ctx.StringValue("OfflineFilteringAlgorithm.Result.Meta.cron");
			meta.CronEnabled = _ctx.BooleanValue("OfflineFilteringAlgorithm.Result.Meta.cronEnabled");
			meta.TaskId = _ctx.StringValue("OfflineFilteringAlgorithm.Result.Meta.taskId");
			meta.ProjectName = _ctx.StringValue("OfflineFilteringAlgorithm.Result.Meta.projectName");
			meta.TableName = _ctx.StringValue("OfflineFilteringAlgorithm.Result.Meta.tableName");
			meta.Type = _ctx.StringValue("OfflineFilteringAlgorithm.Result.Meta.type");
			meta.Category = _ctx.StringValue("OfflineFilteringAlgorithm.Result.Meta.category");
			meta.ClusterId = _ctx.StringValue("OfflineFilteringAlgorithm.Result.Meta.clusterId");
			meta.Description = _ctx.StringValue("OfflineFilteringAlgorithm.Result.Meta.description");

			OfflineFilteringAlgorithmResponse.OfflineFilteringAlgorithm_Result.OfflineFilteringAlgorithm_Meta.OfflineFilteringAlgorithm_ExtInfo extInfo = new OfflineFilteringAlgorithmResponse.OfflineFilteringAlgorithm_Result.OfflineFilteringAlgorithm_Meta.OfflineFilteringAlgorithm_ExtInfo();
			extInfo.ItemSeparator = _ctx.StringValue("OfflineFilteringAlgorithm.Result.Meta.ExtInfo.itemSeparator");
			extInfo.KvSeparator = _ctx.StringValue("OfflineFilteringAlgorithm.Result.Meta.ExtInfo.kvSeparator");
			meta.ExtInfo = extInfo;

			OfflineFilteringAlgorithmResponse.OfflineFilteringAlgorithm_Result.OfflineFilteringAlgorithm_Meta.OfflineFilteringAlgorithm_Threshold threshold = new OfflineFilteringAlgorithmResponse.OfflineFilteringAlgorithm_Result.OfflineFilteringAlgorithm_Meta.OfflineFilteringAlgorithm_Threshold();
			threshold.IndexLossThreshold = _ctx.IntegerValue("OfflineFilteringAlgorithm.Result.Meta.Threshold.indexLossThreshold");
			threshold.IndexSizeThreshold = _ctx.IntegerValue("OfflineFilteringAlgorithm.Result.Meta.Threshold.indexSizeThreshold");
			threshold.SourceDataSizeThreshold = _ctx.IntegerValue("OfflineFilteringAlgorithm.Result.Meta.Threshold.sourceDataSizeThreshold");
			threshold.SourceDataRecordThreshold = _ctx.IntegerValue("OfflineFilteringAlgorithm.Result.Meta.Threshold.sourceDataRecordThreshold");
			meta.Threshold = threshold;
			result.Meta = meta;
			offlineFilteringAlgorithmResponse.Result = result;
        
			return offlineFilteringAlgorithmResponse;
        }
    }
}
