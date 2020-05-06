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
        public static DescribeRestoreTablesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRestoreTablesResponse describeRestoreTablesResponse = new DescribeRestoreTablesResponse();

			describeRestoreTablesResponse.HttpResponse = context.HttpResponse;
			describeRestoreTablesResponse.RequestId = context.StringValue("DescribeRestoreTables.RequestId");

			List<string> describeRestoreTablesResponse_tables = new List<string>();
			for (int i = 0; i < context.Length("DescribeRestoreTables.Tables.Length"); i++) {
				describeRestoreTablesResponse_tables.Add(context.StringValue("DescribeRestoreTables.Tables["+ i +"]"));
			}
			describeRestoreTablesResponse.Tables = describeRestoreTablesResponse_tables;

			DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreSummary restoreSummary = new DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreSummary();
			restoreSummary.RecordId = context.StringValue("DescribeRestoreTables.RestoreSummary.RecordId");
			restoreSummary.StartTime = context.StringValue("DescribeRestoreTables.RestoreSummary.StartTime");
			restoreSummary.EndTime = context.StringValue("DescribeRestoreTables.RestoreSummary.EndTime");
			restoreSummary.State = context.StringValue("DescribeRestoreTables.RestoreSummary.State");
			restoreSummary.TargetCluster = context.StringValue("DescribeRestoreTables.RestoreSummary.TargetCluster");
			restoreSummary.RestoreToDate = context.StringValue("DescribeRestoreTables.RestoreSummary.RestoreToDate");
			describeRestoreTablesResponse.RestoreSummary = restoreSummary;

			DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreSchema restoreSchema = new DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreSchema();
			restoreSchema.Succeed = context.IntegerValue("DescribeRestoreTables.RestoreSchema.Succeed");
			restoreSchema.Fail = context.IntegerValue("DescribeRestoreTables.RestoreSchema.Fail");
			restoreSchema.Total = context.LongValue("DescribeRestoreTables.RestoreSchema.Total");
			restoreSchema.PageNumber = context.IntegerValue("DescribeRestoreTables.RestoreSchema.PageNumber");
			restoreSchema.PageSize = context.IntegerValue("DescribeRestoreTables.RestoreSchema.PageSize");

			List<DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreSchema.DescribeRestoreTables_RestoreSchemaDetail> restoreSchema_restoreSchemaDetails = new List<DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreSchema.DescribeRestoreTables_RestoreSchemaDetail>();
			for (int i = 0; i < context.Length("DescribeRestoreTables.RestoreSchema.RestoreSchemaDetails.Length"); i++) {
				DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreSchema.DescribeRestoreTables_RestoreSchemaDetail restoreSchemaDetail = new DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreSchema.DescribeRestoreTables_RestoreSchemaDetail();
				restoreSchemaDetail.Table = context.StringValue("DescribeRestoreTables.RestoreSchema.RestoreSchemaDetails["+ i +"].Table");
				restoreSchemaDetail.StartTime = context.StringValue("DescribeRestoreTables.RestoreSchema.RestoreSchemaDetails["+ i +"].StartTime");
				restoreSchemaDetail.EndTime = context.StringValue("DescribeRestoreTables.RestoreSchema.RestoreSchemaDetails["+ i +"].EndTime");
				restoreSchemaDetail.State = context.StringValue("DescribeRestoreTables.RestoreSchema.RestoreSchemaDetails["+ i +"].State");
				restoreSchemaDetail.Message = context.StringValue("DescribeRestoreTables.RestoreSchema.RestoreSchemaDetails["+ i +"].Message");

				restoreSchema_restoreSchemaDetails.Add(restoreSchemaDetail);
			}
			restoreSchema.RestoreSchemaDetails = restoreSchema_restoreSchemaDetails;
			describeRestoreTablesResponse.RestoreSchema = restoreSchema;

			DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreFull restoreFull = new DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreFull();
			restoreFull.Succeed = context.IntegerValue("DescribeRestoreTables.RestoreFull.Succeed");
			restoreFull.Fail = context.IntegerValue("DescribeRestoreTables.RestoreFull.Fail");
			restoreFull.DataSize = context.StringValue("DescribeRestoreTables.RestoreFull.DataSize");
			restoreFull.Speed = context.StringValue("DescribeRestoreTables.RestoreFull.Speed");
			restoreFull.Total = context.LongValue("DescribeRestoreTables.RestoreFull.Total");
			restoreFull.PageNumber = context.IntegerValue("DescribeRestoreTables.RestoreFull.PageNumber");
			restoreFull.PageSize = context.IntegerValue("DescribeRestoreTables.RestoreFull.PageSize");

			List<DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreFull.DescribeRestoreTables_RestoreFullDetail> restoreFull_restoreFullDetails = new List<DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreFull.DescribeRestoreTables_RestoreFullDetail>();
			for (int i = 0; i < context.Length("DescribeRestoreTables.RestoreFull.RestoreFullDetails.Length"); i++) {
				DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreFull.DescribeRestoreTables_RestoreFullDetail restoreFullDetail = new DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreFull.DescribeRestoreTables_RestoreFullDetail();
				restoreFullDetail.Table = context.StringValue("DescribeRestoreTables.RestoreFull.RestoreFullDetails["+ i +"].Table");
				restoreFullDetail.State = context.StringValue("DescribeRestoreTables.RestoreFull.RestoreFullDetails["+ i +"].State");
				restoreFullDetail.StartTime = context.StringValue("DescribeRestoreTables.RestoreFull.RestoreFullDetails["+ i +"].StartTime");
				restoreFullDetail.EndTime = context.StringValue("DescribeRestoreTables.RestoreFull.RestoreFullDetails["+ i +"].EndTime");
				restoreFullDetail.Process = context.StringValue("DescribeRestoreTables.RestoreFull.RestoreFullDetails["+ i +"].Process");
				restoreFullDetail.DataSize = context.StringValue("DescribeRestoreTables.RestoreFull.RestoreFullDetails["+ i +"].DataSize");
				restoreFullDetail.Speed = context.StringValue("DescribeRestoreTables.RestoreFull.RestoreFullDetails["+ i +"].Speed");
				restoreFullDetail.Message = context.StringValue("DescribeRestoreTables.RestoreFull.RestoreFullDetails["+ i +"].Message");

				restoreFull_restoreFullDetails.Add(restoreFullDetail);
			}
			restoreFull.RestoreFullDetails = restoreFull_restoreFullDetails;
			describeRestoreTablesResponse.RestoreFull = restoreFull;

			DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreIncrDetail restoreIncrDetail = new DescribeRestoreTablesResponse.DescribeRestoreTables_RestoreIncrDetail();
			restoreIncrDetail.State = context.StringValue("DescribeRestoreTables.RestoreIncrDetail.State");
			restoreIncrDetail.StartTime = context.StringValue("DescribeRestoreTables.RestoreIncrDetail.StartTime");
			restoreIncrDetail.EndTime = context.StringValue("DescribeRestoreTables.RestoreIncrDetail.EndTime");
			restoreIncrDetail.RestoreStartTs = context.StringValue("DescribeRestoreTables.RestoreIncrDetail.RestoreStartTs");
			restoreIncrDetail.RestoredTs = context.StringValue("DescribeRestoreTables.RestoreIncrDetail.RestoredTs");
			restoreIncrDetail.RestoreDelay = context.StringValue("DescribeRestoreTables.RestoreIncrDetail.RestoreDelay");
			restoreIncrDetail.Process = context.StringValue("DescribeRestoreTables.RestoreIncrDetail.Process");
			describeRestoreTablesResponse.RestoreIncrDetail = restoreIncrDetail;
        
			return describeRestoreTablesResponse;
        }
    }
}
