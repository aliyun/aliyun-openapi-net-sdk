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
    public class DbfsRecordResponseUnmarshaller
    {
        public static DbfsRecordResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DbfsRecordResponse dbfsRecordResponse = new DbfsRecordResponse();

			dbfsRecordResponse.HttpResponse = _ctx.HttpResponse;
			dbfsRecordResponse.RequestId = _ctx.StringValue("DbfsRecord.RequestId");

			List<DbfsRecordResponse.DbfsRecord_RecordsItem> dbfsRecordResponse_records = new List<DbfsRecordResponse.DbfsRecord_RecordsItem>();
			for (int i = 0; i < _ctx.Length("DbfsRecord.Records.Length"); i++) {
				DbfsRecordResponse.DbfsRecord_RecordsItem recordsItem = new DbfsRecordResponse.DbfsRecord_RecordsItem();
				recordsItem.Id = _ctx.LongValue("DbfsRecord.Records["+ i +"].Id");
				recordsItem.BatchStrategyNo = _ctx.StringValue("DbfsRecord.Records["+ i +"].BatchStrategyNo");
				recordsItem.AccountId = _ctx.StringValue("DbfsRecord.Records["+ i +"].AccountId");
				recordsItem.DbfsId = _ctx.StringValue("DbfsRecord.Records["+ i +"].DbfsId");
				recordsItem.EcsId = _ctx.StringValue("DbfsRecord.Records["+ i +"].EcsId");
				recordsItem.TaskId = _ctx.StringValue("DbfsRecord.Records["+ i +"].TaskId");
				recordsItem.RegionId = _ctx.StringValue("DbfsRecord.Records["+ i +"].RegionId");
				recordsItem.ZoneId = _ctx.StringValue("DbfsRecord.Records["+ i +"].ZoneId");
				recordsItem.State = _ctx.StringValue("DbfsRecord.Records["+ i +"].State");
				recordsItem.CurrentVersion = _ctx.StringValue("DbfsRecord.Records["+ i +"].CurrentVersion");
				recordsItem.TargetVersion = _ctx.StringValue("DbfsRecord.Records["+ i +"].TargetVersion");
				recordsItem.UpgradeStartTime = _ctx.LongValue("DbfsRecord.Records["+ i +"].UpgradeStartTime");
				recordsItem.UpgradeEndTime = _ctx.LongValue("DbfsRecord.Records["+ i +"].UpgradeEndTime");
				recordsItem.TaskExecutionCounts = _ctx.IntegerValue("DbfsRecord.Records["+ i +"].TaskExecutionCounts");
				recordsItem.TaskErrorReason = _ctx.StringValue("DbfsRecord.Records["+ i +"].TaskErrorReason");
				recordsItem.CreateTime = _ctx.LongValue("DbfsRecord.Records["+ i +"].CreateTime");
				recordsItem.UpdateTime = _ctx.LongValue("DbfsRecord.Records["+ i +"].UpdateTime");
				recordsItem.IsDel = _ctx.StringValue("DbfsRecord.Records["+ i +"].IsDel");

				dbfsRecordResponse_records.Add(recordsItem);
			}
			dbfsRecordResponse.Records = dbfsRecordResponse_records;
        
			return dbfsRecordResponse;
        }
    }
}
