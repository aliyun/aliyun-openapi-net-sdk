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
    public class ListFilteringAlgorithmsResponseUnmarshaller
    {
        public static ListFilteringAlgorithmsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFilteringAlgorithmsResponse listFilteringAlgorithmsResponse = new ListFilteringAlgorithmsResponse();

			listFilteringAlgorithmsResponse.HttpResponse = _ctx.HttpResponse;
			listFilteringAlgorithmsResponse.RequestId = _ctx.StringValue("ListFilteringAlgorithms.requestId");

			ListFilteringAlgorithmsResponse.ListFilteringAlgorithms_Headers headers = new ListFilteringAlgorithmsResponse.ListFilteringAlgorithms_Headers();
			headers.XTotalCount = _ctx.IntegerValue("ListFilteringAlgorithms.Headers.X-Total-Count");
			listFilteringAlgorithmsResponse.Headers = headers;

			List<ListFilteringAlgorithmsResponse.ListFilteringAlgorithms_FilteringAlgorithm> listFilteringAlgorithmsResponse_result = new List<ListFilteringAlgorithmsResponse.ListFilteringAlgorithms_FilteringAlgorithm>();
			for (int i = 0; i < _ctx.Length("ListFilteringAlgorithms.Result.Length"); i++) {
				ListFilteringAlgorithmsResponse.ListFilteringAlgorithms_FilteringAlgorithm filteringAlgorithm = new ListFilteringAlgorithmsResponse.ListFilteringAlgorithms_FilteringAlgorithm();
				filteringAlgorithm.Status = _ctx.StringValue("ListFilteringAlgorithms.Result["+ i +"].status");
				filteringAlgorithm.GmtCreate = _ctx.StringValue("ListFilteringAlgorithms.Result["+ i +"].gmtCreate");
				filteringAlgorithm.GmtModified = _ctx.StringValue("ListFilteringAlgorithms.Result["+ i +"].gmtModified");
				filteringAlgorithm.AlgorithmId = _ctx.StringValue("ListFilteringAlgorithms.Result["+ i +"].algorithmId");

				ListFilteringAlgorithmsResponse.ListFilteringAlgorithms_FilteringAlgorithm.ListFilteringAlgorithms_Meta meta = new ListFilteringAlgorithmsResponse.ListFilteringAlgorithms_FilteringAlgorithm.ListFilteringAlgorithms_Meta();
				meta.MetaType = _ctx.StringValue("ListFilteringAlgorithms.Result["+ i +"].Meta.metaType");
				meta.AlgorithmName = _ctx.StringValue("ListFilteringAlgorithms.Result["+ i +"].Meta.algorithmName");
				meta.Cron = _ctx.StringValue("ListFilteringAlgorithms.Result["+ i +"].Meta.cron");
				meta.CronEnabled = _ctx.BooleanValue("ListFilteringAlgorithms.Result["+ i +"].Meta.cronEnabled");
				meta.TaskId = _ctx.StringValue("ListFilteringAlgorithms.Result["+ i +"].Meta.taskId");
				meta.ProjectName = _ctx.StringValue("ListFilteringAlgorithms.Result["+ i +"].Meta.projectName");
				meta.TableName = _ctx.StringValue("ListFilteringAlgorithms.Result["+ i +"].Meta.tableName");
				meta.Type = _ctx.StringValue("ListFilteringAlgorithms.Result["+ i +"].Meta.type");
				meta.Category = _ctx.StringValue("ListFilteringAlgorithms.Result["+ i +"].Meta.category");
				meta.ClusterId = _ctx.StringValue("ListFilteringAlgorithms.Result["+ i +"].Meta.clusterId");
				meta.Description = _ctx.StringValue("ListFilteringAlgorithms.Result["+ i +"].Meta.description");

				ListFilteringAlgorithmsResponse.ListFilteringAlgorithms_FilteringAlgorithm.ListFilteringAlgorithms_Meta.ListFilteringAlgorithms_ExtInfo extInfo = new ListFilteringAlgorithmsResponse.ListFilteringAlgorithms_FilteringAlgorithm.ListFilteringAlgorithms_Meta.ListFilteringAlgorithms_ExtInfo();
				extInfo.ItemSeparator = _ctx.StringValue("ListFilteringAlgorithms.Result["+ i +"].Meta.ExtInfo.itemSeparator");
				extInfo.KvSeparator = _ctx.StringValue("ListFilteringAlgorithms.Result["+ i +"].Meta.ExtInfo.kvSeparator");
				meta.ExtInfo = extInfo;

				ListFilteringAlgorithmsResponse.ListFilteringAlgorithms_FilteringAlgorithm.ListFilteringAlgorithms_Meta.ListFilteringAlgorithms_Threshold threshold = new ListFilteringAlgorithmsResponse.ListFilteringAlgorithms_FilteringAlgorithm.ListFilteringAlgorithms_Meta.ListFilteringAlgorithms_Threshold();
				threshold.IndexLossThreshold = _ctx.IntegerValue("ListFilteringAlgorithms.Result["+ i +"].Meta.Threshold.indexLossThreshold");
				threshold.IndexSizeThreshold = _ctx.IntegerValue("ListFilteringAlgorithms.Result["+ i +"].Meta.Threshold.indexSizeThreshold");
				threshold.SourceDataSizeThreshold = _ctx.IntegerValue("ListFilteringAlgorithms.Result["+ i +"].Meta.Threshold.sourceDataSizeThreshold");
				threshold.SourceDataRecordThreshold = _ctx.IntegerValue("ListFilteringAlgorithms.Result["+ i +"].Meta.Threshold.sourceDataRecordThreshold");
				meta.Threshold = threshold;
				filteringAlgorithm.Meta = meta;

				listFilteringAlgorithmsResponse_result.Add(filteringAlgorithm);
			}
			listFilteringAlgorithmsResponse.Result = listFilteringAlgorithmsResponse_result;
        
			return listFilteringAlgorithmsResponse;
        }
    }
}
