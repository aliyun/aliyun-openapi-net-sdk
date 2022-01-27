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
    public class ModifyFilteringAlgorithmMetaResponseUnmarshaller
    {
        public static ModifyFilteringAlgorithmMetaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyFilteringAlgorithmMetaResponse modifyFilteringAlgorithmMetaResponse = new ModifyFilteringAlgorithmMetaResponse();

			modifyFilteringAlgorithmMetaResponse.HttpResponse = _ctx.HttpResponse;
			modifyFilteringAlgorithmMetaResponse.RequestId = _ctx.StringValue("ModifyFilteringAlgorithmMeta.requestId");

			ModifyFilteringAlgorithmMetaResponse.ModifyFilteringAlgorithmMeta_Result result = new ModifyFilteringAlgorithmMetaResponse.ModifyFilteringAlgorithmMeta_Result();
			result.Status = _ctx.StringValue("ModifyFilteringAlgorithmMeta.Result.status");
			result.GmtCreate = _ctx.StringValue("ModifyFilteringAlgorithmMeta.Result.gmtCreate");
			result.GmtModified = _ctx.StringValue("ModifyFilteringAlgorithmMeta.Result.gmtModified");
			result.AlgorithmId = _ctx.StringValue("ModifyFilteringAlgorithmMeta.Result.algorithmId");

			ModifyFilteringAlgorithmMetaResponse.ModifyFilteringAlgorithmMeta_Result.ModifyFilteringAlgorithmMeta_Meta meta = new ModifyFilteringAlgorithmMetaResponse.ModifyFilteringAlgorithmMeta_Result.ModifyFilteringAlgorithmMeta_Meta();
			meta.MetaType = _ctx.StringValue("ModifyFilteringAlgorithmMeta.Result.Meta.metaType");
			meta.AlgorithmName = _ctx.StringValue("ModifyFilteringAlgorithmMeta.Result.Meta.algorithmName");
			meta.Cron = _ctx.StringValue("ModifyFilteringAlgorithmMeta.Result.Meta.cron");
			meta.CronEnabled = _ctx.BooleanValue("ModifyFilteringAlgorithmMeta.Result.Meta.cronEnabled");
			meta.TaskId = _ctx.StringValue("ModifyFilteringAlgorithmMeta.Result.Meta.taskId");
			meta.ProjectName = _ctx.StringValue("ModifyFilteringAlgorithmMeta.Result.Meta.projectName");
			meta.TableName = _ctx.StringValue("ModifyFilteringAlgorithmMeta.Result.Meta.tableName");
			meta.Type = _ctx.StringValue("ModifyFilteringAlgorithmMeta.Result.Meta.type");
			meta.Category = _ctx.StringValue("ModifyFilteringAlgorithmMeta.Result.Meta.category");
			meta.ClusterId = _ctx.StringValue("ModifyFilteringAlgorithmMeta.Result.Meta.clusterId");
			meta.Description = _ctx.StringValue("ModifyFilteringAlgorithmMeta.Result.Meta.description");

			ModifyFilteringAlgorithmMetaResponse.ModifyFilteringAlgorithmMeta_Result.ModifyFilteringAlgorithmMeta_Meta.ModifyFilteringAlgorithmMeta_ExtInfo extInfo = new ModifyFilteringAlgorithmMetaResponse.ModifyFilteringAlgorithmMeta_Result.ModifyFilteringAlgorithmMeta_Meta.ModifyFilteringAlgorithmMeta_ExtInfo();
			extInfo.ItemSeparator = _ctx.StringValue("ModifyFilteringAlgorithmMeta.Result.Meta.ExtInfo.itemSeparator");
			extInfo.KvSeparator = _ctx.StringValue("ModifyFilteringAlgorithmMeta.Result.Meta.ExtInfo.kvSeparator");
			meta.ExtInfo = extInfo;

			ModifyFilteringAlgorithmMetaResponse.ModifyFilteringAlgorithmMeta_Result.ModifyFilteringAlgorithmMeta_Meta.ModifyFilteringAlgorithmMeta_Threshold threshold = new ModifyFilteringAlgorithmMetaResponse.ModifyFilteringAlgorithmMeta_Result.ModifyFilteringAlgorithmMeta_Meta.ModifyFilteringAlgorithmMeta_Threshold();
			threshold.IndexLossThreshold = _ctx.IntegerValue("ModifyFilteringAlgorithmMeta.Result.Meta.Threshold.indexLossThreshold");
			threshold.IndexSizeThreshold = _ctx.IntegerValue("ModifyFilteringAlgorithmMeta.Result.Meta.Threshold.indexSizeThreshold");
			threshold.SourceDataSizeThreshold = _ctx.IntegerValue("ModifyFilteringAlgorithmMeta.Result.Meta.Threshold.sourceDataSizeThreshold");
			threshold.SourceDataRecordThreshold = _ctx.IntegerValue("ModifyFilteringAlgorithmMeta.Result.Meta.Threshold.sourceDataRecordThreshold");
			meta.Threshold = threshold;
			result.Meta = meta;
			modifyFilteringAlgorithmMetaResponse.Result = result;
        
			return modifyFilteringAlgorithmMetaResponse;
        }
    }
}
