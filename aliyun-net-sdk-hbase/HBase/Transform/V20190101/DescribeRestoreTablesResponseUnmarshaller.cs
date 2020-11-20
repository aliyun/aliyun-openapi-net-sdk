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
using Aliyun.Acs.HBase.Model.V20190101;

namespace Aliyun.Acs.HBase.Transform.V20190101
{
    public class DescribeRestoreTablesResponseUnmarshaller
    {
        public static DescribeRestoreTablesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRestoreTablesResponse describeRestoreTablesResponse = new DescribeRestoreTablesResponse();

			describeRestoreTablesResponse.HttpResponse = _ctx.HttpResponse;
			describeRestoreTablesResponse.RequestId = _ctx.StringValue("DescribeRestoreTables.RequestId");

			List<string> describeRestoreTablesResponse_tables = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeRestoreTables.Tables.Length"); i++) {
				describeRestoreTablesResponse_tables.Add(_ctx.StringValue("DescribeRestoreTables.Tables["+ i +"]"));
			}
			describeRestoreTablesResponse.Tables = describeRestoreTablesResponse_tables;

			DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreSummary restoreSummary = new DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreSummary();
			restoreSummary.RecordId = _ctx.StringValue("DescribeRestoreTables.RestoreSummary.RecordId");
			restoreSummary.StartTime = _ctx.StringValue("DescribeRestoreTables.RestoreSummary.StartTime");
			restoreSummary.EndTime = _ctx.StringValue("DescribeRestoreTables.RestoreSummary.EndTime");
			restoreSummary.State = _ctx.StringValue("DescribeRestoreTables.RestoreSummary.State");
			restoreSummary.TargetCluster = _ctx.StringValue("DescribeRestoreTables.RestoreSummary.TargetCluster");
			restoreSummary.RestoreToDate = _ctx.StringValue("DescribeRestoreTables.RestoreSummary.RestoreToDate");
			describeRestoreTablesResponse.RestoreSummary = restoreSummary;

			DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreSchema restoreSchema = new DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreSchema();
			restoreSchema.Succeed = _ctx.IntegerValue("DescribeRestoreTables.RestoreSchema.Succeed");
			restoreSchema.Fail = _ctx.IntegerValue("DescribeRestoreTables.RestoreSchema.Fail");
			restoreSchema.Total = _ctx.LongValue("DescribeRestoreTables.RestoreSchema.Total");
			restoreSchema.PageNumber = _ctx.IntegerValue("DescribeRestoreTables.RestoreSchema.PageNumber");
			restoreSchema.PageSize = _ctx.IntegerValue("DescribeRestoreTables.RestoreSchema.PageSize");

			List<DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreSchema.DescribeRestoreTables_RestoreSchemaDetail> restoreSchema_restoreSchemaDetails = new List<DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreSchema.DescribeRestoreTables_RestoreSchemaDetail>();
			for (int i = 0; i < _ctx.Length("DescribeRestoreTables.RestoreSchema.RestoreSchemaDetails.Length"); i++) {
				DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreSchema.DescribeRestoreTables_RestoreSchemaDetail restoreSchemaDetail = new DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreSchema.DescribeRestoreTables_RestoreSchemaDetail();
				restoreSchemaDetail.Table = _ctx.StringValue("DescribeRestoreTables.RestoreSchema.RestoreSchemaDetails["+ i +"].Table");
				restoreSchemaDetail.StartTime = _ctx.StringValue("DescribeRestoreTables.RestoreSchema.RestoreSchemaDetails["+ i +"].StartTime");
				restoreSchemaDetail.EndTime = _ctx.StringValue("DescribeRestoreTables.RestoreSchema.RestoreSchemaDetails["+ i +"].EndTime");
				restoreSchemaDetail.State = _ctx.StringValue("DescribeRestoreTables.RestoreSchema.RestoreSchemaDetails["+ i +"].State");
				restoreSchemaDetail.Message = _ctx.StringValue("DescribeRestoreTables.RestoreSchema.RestoreSchemaDetails["+ i +"].Message");

				restoreSchema_restoreSchemaDetails.Add(restoreSchemaDetail);
			}
			restoreSchema.RestoreSchemaDetails = restoreSchema_restoreSchemaDetails;
			describeRestoreTablesResponse.RestoreSchema = restoreSchema;

			DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreFull restoreFull = new DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreFull();
			restoreFull.Succeed = _ctx.IntegerValue("DescribeRestoreTables.RestoreFull.Succeed");
			restoreFull.Fail = _ctx.IntegerValue("DescribeRestoreTables.RestoreFull.Fail");
			restoreFull.DataSize = _ctx.StringValue("DescribeRestoreTables.RestoreFull.DataSize");
			restoreFull.Speed = _ctx.StringValue("DescribeRestoreTables.RestoreFull.Speed");
			restoreFull.Total = _ctx.LongValue("DescribeRestoreTables.RestoreFull.Total");
			restoreFull.PageNumber = _ctx.IntegerValue("DescribeRestoreTables.RestoreFull.PageNumber");
			restoreFull.PageSize = _ctx.IntegerValue("DescribeRestoreTables.RestoreFull.PageSize");

			List<DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreFull.DescribeRestoreTables_RestoreFullDetail> restoreFull_restoreFullDetails = new List<DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreFull.DescribeRestoreTables_RestoreFullDetail>();
			for (int i = 0; i < _ctx.Length("DescribeRestoreTables.RestoreFull.RestoreFullDetails.Length"); i++) {
				DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreFull.DescribeRestoreTables_RestoreFullDetail restoreFullDetail = new DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreFull.DescribeRestoreTables_RestoreFullDetail();
				restoreFullDetail.Table = _ctx.StringValue("DescribeRestoreTables.RestoreFull.RestoreFullDetails["+ i +"].Table");
				restoreFullDetail.State = _ctx.StringValue("DescribeRestoreTables.RestoreFull.RestoreFullDetails["+ i +"].State");
				restoreFullDetail.StartTime = _ctx.StringValue("DescribeRestoreTables.RestoreFull.RestoreFullDetails["+ i +"].StartTime");
				restoreFullDetail.EndTime = _ctx.StringValue("DescribeRestoreTables.RestoreFull.RestoreFullDetails["+ i +"].EndTime");
				restoreFullDetail.Process = _ctx.StringValue("DescribeRestoreTables.RestoreFull.RestoreFullDetails["+ i +"].Process");
				restoreFullDetail.DataSize = _ctx.StringValue("DescribeRestoreTables.RestoreFull.RestoreFullDetails["+ i +"].DataSize");
				restoreFullDetail.Speed = _ctx.StringValue("DescribeRestoreTables.RestoreFull.RestoreFullDetails["+ i +"].Speed");
				restoreFullDetail.Message = _ctx.StringValue("DescribeRestoreTables.RestoreFull.RestoreFullDetails["+ i +"].Message");

				restoreFull_restoreFullDetails.Add(restoreFullDetail);
			}
			restoreFull.RestoreFullDetails = restoreFull_restoreFullDetails;
			describeRestoreTablesResponse.RestoreFull = restoreFull;

			DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreIncrDetail restoreIncrDetail = new DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreIncrDetail();
			restoreIncrDetail.State = _ctx.StringValue("DescribeRestoreTables.RestoreIncrDetail.State");
			restoreIncrDetail.StartTime = _ctx.StringValue("DescribeRestoreTables.RestoreIncrDetail.StartTime");
			restoreIncrDetail.EndTime = _ctx.StringValue("DescribeRestoreTables.RestoreIncrDetail.EndTime");
			restoreIncrDetail.RestoreStartTs = _ctx.StringValue("DescribeRestoreTables.RestoreIncrDetail.RestoreStartTs");
			restoreIncrDetail.RestoredTs = _ctx.StringValue("DescribeRestoreTables.RestoreIncrDetail.RestoredTs");
			restoreIncrDetail.RestoreDelay = _ctx.StringValue("DescribeRestoreTables.RestoreIncrDetail.RestoreDelay");
			restoreIncrDetail.Process = _ctx.StringValue("DescribeRestoreTables.RestoreIncrDetail.Process");
			describeRestoreTablesResponse.RestoreIncrDetail = restoreIncrDetail;
        
			return describeRestoreTablesResponse;
        }
    }
}
