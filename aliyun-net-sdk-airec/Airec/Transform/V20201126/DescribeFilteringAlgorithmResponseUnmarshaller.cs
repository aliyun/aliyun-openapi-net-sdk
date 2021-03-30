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
    public class DescribeFilteringAlgorithmResponseUnmarshaller
    {
        public static DescribeFilteringAlgorithmResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeFilteringAlgorithmResponse describeFilteringAlgorithmResponse = new DescribeFilteringAlgorithmResponse();

			describeFilteringAlgorithmResponse.HttpResponse = _ctx.HttpResponse;
			describeFilteringAlgorithmResponse.RequestId = _ctx.StringValue("DescribeFilteringAlgorithm.requestId");

			DescribeFilteringAlgorithmResponse.DescribeFilteringAlgorithm_Result result = new DescribeFilteringAlgorithmResponse.DescribeFilteringAlgorithm_Result();
			result.Status = _ctx.StringValue("DescribeFilteringAlgorithm.Result.status");
			result.GmtCreate = _ctx.StringValue("DescribeFilteringAlgorithm.Result.gmtCreate");
			result.GmtModified = _ctx.StringValue("DescribeFilteringAlgorithm.Result.gmtModified");
			result.AlgorithmId = _ctx.StringValue("DescribeFilteringAlgorithm.Result.algorithmId");

			DescribeFilteringAlgorithmResponse.DescribeFilteringAlgorithm_Result.DescribeFilteringAlgorithm_Meta meta = new DescribeFilteringAlgorithmResponse.DescribeFilteringAlgorithm_Result.DescribeFilteringAlgorithm_Meta();
			meta.MetaType = _ctx.StringValue("DescribeFilteringAlgorithm.Result.Meta.metaType");
			meta.AlgorithmName = _ctx.StringValue("DescribeFilteringAlgorithm.Result.Meta.algorithmName");
			meta.Cron = _ctx.StringValue("DescribeFilteringAlgorithm.Result.Meta.cron");
			meta.CronEnabled = _ctx.BooleanValue("DescribeFilteringAlgorithm.Result.Meta.cronEnabled");
			meta.TaskId = _ctx.StringValue("DescribeFilteringAlgorithm.Result.Meta.taskId");
			meta.ProjectName = _ctx.StringValue("DescribeFilteringAlgorithm.Result.Meta.projectName");
			meta.TableName = _ctx.StringValue("DescribeFilteringAlgorithm.Result.Meta.tableName");
			meta.Type = _ctx.StringValue("DescribeFilteringAlgorithm.Result.Meta.type");
			meta.Category = _ctx.StringValue("DescribeFilteringAlgorithm.Result.Meta.category");
			meta.ClusterId = _ctx.StringValue("DescribeFilteringAlgorithm.Result.Meta.clusterId");
			meta.Description = _ctx.StringValue("DescribeFilteringAlgorithm.Result.Meta.description");

			DescribeFilteringAlgorithmResponse.DescribeFilteringAlgorithm_Result.DescribeFilteringAlgorithm_Meta.DescribeFilteringAlgorithm_ExtInfo extInfo = new DescribeFilteringAlgorithmResponse.DescribeFilteringAlgorithm_Result.DescribeFilteringAlgorithm_Meta.DescribeFilteringAlgorithm_ExtInfo();
			extInfo.ItemSeparator = _ctx.StringValue("DescribeFilteringAlgorithm.Result.Meta.ExtInfo.itemSeparator");
			extInfo.KvSeparator = _ctx.StringValue("DescribeFilteringAlgorithm.Result.Meta.ExtInfo.kvSeparator");
			meta.ExtInfo = extInfo;

			DescribeFilteringAlgorithmResponse.DescribeFilteringAlgorithm_Result.DescribeFilteringAlgorithm_Meta.DescribeFilteringAlgorithm_Threshold threshold = new DescribeFilteringAlgorithmResponse.DescribeFilteringAlgorithm_Result.DescribeFilteringAlgorithm_Meta.DescribeFilteringAlgorithm_Threshold();
			threshold.IndexLossThreshold = _ctx.IntegerValue("DescribeFilteringAlgorithm.Result.Meta.Threshold.indexLossThreshold");
			threshold.IndexSizeThreshold = _ctx.IntegerValue("DescribeFilteringAlgorithm.Result.Meta.Threshold.indexSizeThreshold");
			threshold.SourceDataSizeThreshold = _ctx.IntegerValue("DescribeFilteringAlgorithm.Result.Meta.Threshold.sourceDataSizeThreshold");
			threshold.SourceDataRecordThreshold = _ctx.IntegerValue("DescribeFilteringAlgorithm.Result.Meta.Threshold.sourceDataRecordThreshold");
			meta.Threshold = threshold;
			result.Meta = meta;
			describeFilteringAlgorithmResponse.Result = result;
        
			return describeFilteringAlgorithmResponse;
        }
    }
}
