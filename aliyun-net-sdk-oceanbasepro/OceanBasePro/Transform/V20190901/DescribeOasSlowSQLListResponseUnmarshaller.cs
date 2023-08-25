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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class DescribeOasSlowSQLListResponseUnmarshaller
    {
        public static DescribeOasSlowSQLListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOasSlowSQLListResponse describeOasSlowSQLListResponse = new DescribeOasSlowSQLListResponse();

			describeOasSlowSQLListResponse.HttpResponse = _ctx.HttpResponse;
			describeOasSlowSQLListResponse.RequestId = _ctx.StringValue("DescribeOasSlowSQLList.RequestId");

			List<DescribeOasSlowSQLListResponse.DescribeOasSlowSQLList_DataItem> describeOasSlowSQLListResponse_data = new List<DescribeOasSlowSQLListResponse.DescribeOasSlowSQLList_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeOasSlowSQLList.Data.Length"); i++) {
				DescribeOasSlowSQLListResponse.DescribeOasSlowSQLList_DataItem dataItem = new DescribeOasSlowSQLListResponse.DescribeOasSlowSQLList_DataItem();
				dataItem.Executions = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].Executions");
				dataItem.RpcCount = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].RpcCount");
				dataItem.RemotePlans = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].RemotePlans");
				dataItem.MissPlans = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].MissPlans");
				dataItem.MaxElapsedTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].MaxElapsedTime");
				dataItem.TotalWaitTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].TotalWaitTime");
				dataItem.ExecPs = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].ExecPs");
				dataItem.MaxCpuTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].MaxCpuTime");
				dataItem.ClientIp = _ctx.StringValue("DescribeOasSlowSQLList.Data["+ i +"].ClientIp");
				dataItem.UserName = _ctx.StringValue("DescribeOasSlowSQLList.Data["+ i +"].UserName");
				dataItem.DbName = _ctx.StringValue("DescribeOasSlowSQLList.Data["+ i +"].DbName");
				dataItem.RetCode4012Count = _ctx.LongValue("DescribeOasSlowSQLList.Data["+ i +"].RetCode4012Count");
				dataItem.RetCode4013Count = _ctx.LongValue("DescribeOasSlowSQLList.Data["+ i +"].RetCode4013Count");
				dataItem.RetCode5001Count = _ctx.LongValue("DescribeOasSlowSQLList.Data["+ i +"].RetCode5001Count");
				dataItem.RetCode5024Count = _ctx.LongValue("DescribeOasSlowSQLList.Data["+ i +"].RetCode5024Count");
				dataItem.RetCode5167Count = _ctx.LongValue("DescribeOasSlowSQLList.Data["+ i +"].RetCode5167Count");
				dataItem.RetCode5217Count = _ctx.LongValue("DescribeOasSlowSQLList.Data["+ i +"].RetCode5217Count");
				dataItem.RetCode6002Count = _ctx.LongValue("DescribeOasSlowSQLList.Data["+ i +"].RetCode6002Count");
				dataItem.FailPercentage = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].FailPercentage");
				dataItem.SumWaitTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SumWaitTime");
				dataItem.AvgWaitCount = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgWaitCount");
				dataItem.AvgRpcCount = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgRpcCount");
				dataItem.LocalPlanPercentage = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].LocalPlanPercentage");
				dataItem.RemotePlanPercentage = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].RemotePlanPercentage");
				dataItem.DistPlanPercentage = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].DistPlanPercentage");
				dataItem.SumElapsedTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SumElapsedTime");
				dataItem.AvgNetTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgNetTime");
				dataItem.AvgExecutorRpcCount = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgExecutorRpcCount");
				dataItem.MissPlanPercentage = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].MissPlanPercentage");
				dataItem.TableScanPercentage = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].TableScanPercentage");
				dataItem.StrongConsistencyPercentage = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].StrongConsistencyPercentage");
				dataItem.WeakConsistencyPercentage = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].WeakConsistencyPercentage");
				dataItem.MaxAffectedRows = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].MaxAffectedRows");
				dataItem.MaxReturnRows = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].MaxReturnRows");
				dataItem.MaxWaitTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].MaxWaitTime");
				dataItem.MaxApplicationWaitTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].MaxApplicationWaitTime");
				dataItem.MaxConcurrencyWaitTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].MaxConcurrencyWaitTime");
				dataItem.MaxUserIoWaitTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].MaxUserIoWaitTime");
				dataItem.MaxDiskReads = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].MaxDiskReads");
				dataItem.AvgExpectedWorkerCount = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgExpectedWorkerCount");
				dataItem.AvgUsedWorkerCount = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgUsedWorkerCount");
				dataItem.SumLogicalReads = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SumLogicalReads");
				dataItem.Server = _ctx.StringValue("DescribeOasSlowSQLList.Data["+ i +"].Server");
				dataItem.ServerIp = _ctx.StringValue("DescribeOasSlowSQLList.Data["+ i +"].ServerIp");
				dataItem.ServerPort = _ctx.LongValue("DescribeOasSlowSQLList.Data["+ i +"].ServerPort");
				dataItem.SqlTextShort = _ctx.StringValue("DescribeOasSlowSQLList.Data["+ i +"].SqlTextShort");
				dataItem.SqlType = _ctx.StringValue("DescribeOasSlowSQLList.Data["+ i +"].SqlType");
				dataItem.SqlId = _ctx.StringValue("DescribeOasSlowSQLList.Data["+ i +"].SqlId");
				dataItem.Inner = _ctx.BooleanValue("DescribeOasSlowSQLList.Data["+ i +"].Inner");
				dataItem.WaitEvent = _ctx.StringValue("DescribeOasSlowSQLList.Data["+ i +"].WaitEvent");
				dataItem.AvgAffectedRows = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgAffectedRows");
				dataItem.AvgReturnRows = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgReturnRows");
				dataItem.AvgPartitionCount = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgPartitionCount");
				dataItem.FailCount = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].FailCount");
				dataItem.AvgWaitTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgWaitTime");
				dataItem.AvgElapsedTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgElapsedTime");
				dataItem.AvgCpuTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgCpuTime");
				dataItem.AvgNetWaitTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgNetWaitTime");
				dataItem.AvgQueueTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgQueueTime");
				dataItem.AvgDecodeTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgDecodeTime");
				dataItem.AvgGetPlanTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgGetPlanTime");
				dataItem.AvgExecuteTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgExecuteTime");
				dataItem.AvgApplicationWaitTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgApplicationWaitTime");
				dataItem.AvgConcurrencyWaitTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgConcurrencyWaitTime");
				dataItem.AvgUserIoWaitTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgUserIoWaitTime");
				dataItem.AvgScheduleTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgScheduleTime");
				dataItem.AvgRowCacheHit = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgRowCacheHit");
				dataItem.AvgBloomFilterCacheHit = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgBloomFilterCacheHit");
				dataItem.AvgBlockCacheHit = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgBlockCacheHit");
				dataItem.AvgBlockIndexCacheHit = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgBlockIndexCacheHit");
				dataItem.AvgDiskReads = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgDiskReads");
				dataItem.RetryCount = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].RetryCount");
				dataItem.AvgMemstoreReadRows = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgMemstoreReadRows");
				dataItem.AvgSsstoreReadRows = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgSsstoreReadRows");
				dataItem.AvgLogicalReads = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgLogicalReads");
				dataItem.DynamicSql = _ctx.BooleanValue("DescribeOasSlowSQLList.Data["+ i +"].DynamicSql");
				dataItem.AvgDbTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].AvgDbTime");
				dataItem.SumDbTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SumDbTime");

				List<DescribeOasSlowSQLListResponse.DescribeOasSlowSQLList_DataItem.DescribeOasSlowSQLList_SqlListItem> dataItem_sqlList = new List<DescribeOasSlowSQLListResponse.DescribeOasSlowSQLList_DataItem.DescribeOasSlowSQLList_SqlListItem>();
				for (int j = 0; j < _ctx.Length("DescribeOasSlowSQLList.Data["+ i +"].SqlList.Length"); j++) {
					DescribeOasSlowSQLListResponse.DescribeOasSlowSQLList_DataItem.DescribeOasSlowSQLList_SqlListItem sqlListItem = new DescribeOasSlowSQLListResponse.DescribeOasSlowSQLList_DataItem.DescribeOasSlowSQLList_SqlListItem();
					sqlListItem.Executions = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].Executions");
					sqlListItem.RpcCount = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].RpcCount");
					sqlListItem.RemotePlans = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].RemotePlans");
					sqlListItem.MissPlans = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].MissPlans");
					sqlListItem.MaxElapsedTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].MaxElapsedTime");
					sqlListItem.TotalWaitTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].TotalWaitTime");
					sqlListItem.ExecPs = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].ExecPs");
					sqlListItem.MaxCpuTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].MaxCpuTime");
					sqlListItem.ClientIp = _ctx.StringValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].ClientIp");
					sqlListItem.UserName = _ctx.StringValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].UserName");
					sqlListItem.DbName = _ctx.StringValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].DbName");
					sqlListItem.RetCode4012Count = _ctx.LongValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].RetCode4012Count");
					sqlListItem.RetCode4013Count = _ctx.LongValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].RetCode4013Count");
					sqlListItem.RetCode5001Count = _ctx.LongValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].RetCode5001Count");
					sqlListItem.RetCode5024Count = _ctx.LongValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].RetCode5024Count");
					sqlListItem.RetCode5167Count = _ctx.LongValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].RetCode5167Count");
					sqlListItem.RetCode5217Count = _ctx.LongValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].RetCode5217Count");
					sqlListItem.RetCode6002Count = _ctx.LongValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].RetCode6002Count");
					sqlListItem.FailPercentage = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].FailPercentage");
					sqlListItem.SumWaitTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].SumWaitTime");
					sqlListItem.AvgWaitCount = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgWaitCount");
					sqlListItem.AvgRpcCount = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgRpcCount");
					sqlListItem.LocalPlanPercentage = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].LocalPlanPercentage");
					sqlListItem.RemotePlanPercentage = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].RemotePlanPercentage");
					sqlListItem.DistPlanPercentage = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].DistPlanPercentage");
					sqlListItem.SumElapsedTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].SumElapsedTime");
					sqlListItem.AvgNetTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgNetTime");
					sqlListItem.AvgExecutorRpcCount = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgExecutorRpcCount");
					sqlListItem.MissPlanPercentage = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].MissPlanPercentage");
					sqlListItem.TableScanPercentage = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].TableScanPercentage");
					sqlListItem.StrongConsistencyPercentage = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].StrongConsistencyPercentage");
					sqlListItem.WeakConsistencyPercentage = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].WeakConsistencyPercentage");
					sqlListItem.MaxAffectedRows = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].MaxAffectedRows");
					sqlListItem.MaxReturnRows = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].MaxReturnRows");
					sqlListItem.MaxWaitTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].MaxWaitTime");
					sqlListItem.MaxApplicationWaitTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].MaxApplicationWaitTime");
					sqlListItem.MaxConcurrencyWaitTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].MaxConcurrencyWaitTime");
					sqlListItem.MaxUserIoWaitTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].MaxUserIoWaitTime");
					sqlListItem.MaxDiskReads = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].MaxDiskReads");
					sqlListItem.AvgExpectedWorkerCount = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgExpectedWorkerCount");
					sqlListItem.AvgUsedWorkerCount = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgUsedWorkerCount");
					sqlListItem.SumLogicalReads = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].SumLogicalReads");
					sqlListItem.Server = _ctx.StringValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].Server");
					sqlListItem.ServerIp = _ctx.StringValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].ServerIp");
					sqlListItem.ServerPort = _ctx.LongValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].ServerPort");
					sqlListItem.SqlTextShort = _ctx.StringValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].SqlTextShort");
					sqlListItem.SqlType = _ctx.StringValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].SqlType");
					sqlListItem.SqlId = _ctx.StringValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].SqlId");
					sqlListItem.Inner = _ctx.BooleanValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].Inner");
					sqlListItem.WaitEvent = _ctx.StringValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].WaitEvent");
					sqlListItem.AvgAffectedRows = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgAffectedRows");
					sqlListItem.AvgReturnRows = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgReturnRows");
					sqlListItem.AvgPartitionCount = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgPartitionCount");
					sqlListItem.FailCount = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].FailCount");
					sqlListItem.AvgWaitTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgWaitTime");
					sqlListItem.AvgElapsedTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgElapsedTime");
					sqlListItem.AvgCpuTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgCpuTime");
					sqlListItem.AvgNetWaitTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgNetWaitTime");
					sqlListItem.AvgQueueTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgQueueTime");
					sqlListItem.AvgDecodeTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgDecodeTime");
					sqlListItem.AvgGetPlanTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgGetPlanTime");
					sqlListItem.AvgExecuteTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgExecuteTime");
					sqlListItem.AvgApplicationWaitTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgApplicationWaitTime");
					sqlListItem.AvgConcurrencyWaitTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgConcurrencyWaitTime");
					sqlListItem.AvgUserIoWaitTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgUserIoWaitTime");
					sqlListItem.AvgScheduleTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgScheduleTime");
					sqlListItem.AvgRowCacheHit = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgRowCacheHit");
					sqlListItem.AvgBloomFilterCacheHit = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgBloomFilterCacheHit");
					sqlListItem.AvgBlockCacheHit = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgBlockCacheHit");
					sqlListItem.AvgBlockIndexCacheHit = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgBlockIndexCacheHit");
					sqlListItem.AvgDiskReads = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgDiskReads");
					sqlListItem.RetryCount = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].RetryCount");
					sqlListItem.AvgMemstoreReadRows = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgMemstoreReadRows");
					sqlListItem.AvgSsstoreReadRows = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgSsstoreReadRows");
					sqlListItem.AvgLogicalReads = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgLogicalReads");
					sqlListItem.AvgDbTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].AvgDbTime");
					sqlListItem.SumDbTime = _ctx.DoubleValue("DescribeOasSlowSQLList.Data["+ i +"].SqlList["+ j +"].SumDbTime");

					dataItem_sqlList.Add(sqlListItem);
				}
				dataItem.SqlList = dataItem_sqlList;

				describeOasSlowSQLListResponse_data.Add(dataItem);
			}
			describeOasSlowSQLListResponse.Data = describeOasSlowSQLListResponse_data;
        
			return describeOasSlowSQLListResponse;
        }
    }
}
