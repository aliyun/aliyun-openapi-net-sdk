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
using Aliyun.Acs.DBFS.Model.V20200418;

namespace Aliyun.Acs.DBFS.Transform.V20200418
{
    public class GenerateUpgradeRecordResponseUnmarshaller
    {
        public static GenerateUpgradeRecordResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GenerateUpgradeRecordResponse generateUpgradeRecordResponse = new GenerateUpgradeRecordResponse();

			generateUpgradeRecordResponse.HttpResponse = _ctx.HttpResponse;
			generateUpgradeRecordResponse.RequestId = _ctx.StringValue("GenerateUpgradeRecord.RequestId");

			List<GenerateUpgradeRecordResponse.GenerateUpgradeRecord_RecordsItem> generateUpgradeRecordResponse_records = new List<GenerateUpgradeRecordResponse.GenerateUpgradeRecord_RecordsItem>();
			for (int i = 0; i < _ctx.Length("GenerateUpgradeRecord.Records.Length"); i++) {
				GenerateUpgradeRecordResponse.GenerateUpgradeRecord_RecordsItem recordsItem = new GenerateUpgradeRecordResponse.GenerateUpgradeRecord_RecordsItem();
				recordsItem.Id = _ctx.LongValue("GenerateUpgradeRecord.Records["+ i +"].Id");
				recordsItem.BatchStrategyNo = _ctx.StringValue("GenerateUpgradeRecord.Records["+ i +"].BatchStrategyNo");
				recordsItem.AccountId = _ctx.StringValue("GenerateUpgradeRecord.Records["+ i +"].AccountId");
				recordsItem.DbfsId = _ctx.StringValue("GenerateUpgradeRecord.Records["+ i +"].DbfsId");
				recordsItem.EcsId = _ctx.StringValue("GenerateUpgradeRecord.Records["+ i +"].EcsId");
				recordsItem.TaskId = _ctx.StringValue("GenerateUpgradeRecord.Records["+ i +"].TaskId");
				recordsItem.RegionId = _ctx.StringValue("GenerateUpgradeRecord.Records["+ i +"].RegionId");
				recordsItem.ZoneId = _ctx.StringValue("GenerateUpgradeRecord.Records["+ i +"].ZoneId");
				recordsItem.State = _ctx.StringValue("GenerateUpgradeRecord.Records["+ i +"].State");
				recordsItem.CurrentVersion = _ctx.StringValue("GenerateUpgradeRecord.Records["+ i +"].CurrentVersion");
				recordsItem.TargetVersion = _ctx.StringValue("GenerateUpgradeRecord.Records["+ i +"].TargetVersion");
				recordsItem.UpgradeStartTime = _ctx.LongValue("GenerateUpgradeRecord.Records["+ i +"].UpgradeStartTime");
				recordsItem.UpgradeEndTime = _ctx.LongValue("GenerateUpgradeRecord.Records["+ i +"].UpgradeEndTime");
				recordsItem.TaskExecutionCounts = _ctx.IntegerValue("GenerateUpgradeRecord.Records["+ i +"].TaskExecutionCounts");
				recordsItem.TaskErrorReason = _ctx.StringValue("GenerateUpgradeRecord.Records["+ i +"].TaskErrorReason");
				recordsItem.CreateTime = _ctx.LongValue("GenerateUpgradeRecord.Records["+ i +"].CreateTime");
				recordsItem.UpdateTime = _ctx.LongValue("GenerateUpgradeRecord.Records["+ i +"].UpdateTime");

				generateUpgradeRecordResponse_records.Add(recordsItem);
			}
			generateUpgradeRecordResponse.Records = generateUpgradeRecordResponse_records;
        
			return generateUpgradeRecordResponse;
        }
    }
}
