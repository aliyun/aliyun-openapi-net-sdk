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
    public class DescribeOasSQLHistoryListResponseUnmarshaller
    {
        public static DescribeOasSQLHistoryListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOasSQLHistoryListResponse describeOasSQLHistoryListResponse = new DescribeOasSQLHistoryListResponse();

			describeOasSQLHistoryListResponse.HttpResponse = _ctx.HttpResponse;
			describeOasSQLHistoryListResponse.RequestId = _ctx.StringValue("DescribeOasSQLHistoryList.RequestId");

			List<DescribeOasSQLHistoryListResponse.DescribeOasSQLHistoryList_DataItem> describeOasSQLHistoryListResponse_data = new List<DescribeOasSQLHistoryListResponse.DescribeOasSQLHistoryList_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeOasSQLHistoryList.Data.Length"); i++) {
				DescribeOasSQLHistoryListResponse.DescribeOasSQLHistoryList_DataItem dataItem = new DescribeOasSQLHistoryListResponse.DescribeOasSQLHistoryList_DataItem();
				dataItem.SQLId = _ctx.StringValue("DescribeOasSQLHistoryList.Data["+ i +"].SQLId");
				dataItem.DbName = _ctx.StringValue("DescribeOasSQLHistoryList.Data["+ i +"].DbName");
				dataItem.AvgAffectedRows = _ctx.LongValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgAffectedRows");
				dataItem.AvgBlockCacheHit = _ctx.LongValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgBlockCacheHit");
				dataItem.AvgBlockIndexCacheHit = _ctx.LongValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgBlockIndexCacheHit");
				dataItem.AvgBloomFilterCacheHit = _ctx.LongValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgBloomFilterCacheHit");
				dataItem.Executions = _ctx.LongValue("DescribeOasSQLHistoryList.Data["+ i +"].Executions");
				dataItem.FailCount = _ctx.LongValue("DescribeOasSQLHistoryList.Data["+ i +"].FailCount");
				dataItem.AvgRpcCount = _ctx.LongValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgRpcCount");
				dataItem.RemotePlans = _ctx.LongValue("DescribeOasSQLHistoryList.Data["+ i +"].RemotePlans");
				dataItem.MissPlans = _ctx.LongValue("DescribeOasSQLHistoryList.Data["+ i +"].MissPlans");
				dataItem.AvgReturnRows = _ctx.LongValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgReturnRows");
				dataItem.AvgLogicalReads = _ctx.LongValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgLogicalReads");
				dataItem.RetryCount = _ctx.LongValue("DescribeOasSQLHistoryList.Data["+ i +"].RetryCount");
				dataItem.AvgRowCacheHit = _ctx.LongValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgRowCacheHit");
				dataItem.AvgDiskReads = _ctx.LongValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgDiskReads");
				dataItem.AvgMemstoreReadRows = _ctx.LongValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgMemstoreReadRows");
				dataItem.AvgSsstoreReadRows = _ctx.LongValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgSsstoreReadRows");
				dataItem.AvgApplicationWaitTime = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgApplicationWaitTime");
				dataItem.AvgElapsedTime = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgElapsedTime");
				dataItem.AvgExecuteTime = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgExecuteTime");
				dataItem.AvgQueueTime = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgQueueTime");
				dataItem.AvgConcurrencyWaitTime = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgConcurrencyWaitTime");
				dataItem.AvgCpuTime = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgCpuTime");
				dataItem.AvgDecodeTime = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgDecodeTime");
				dataItem.AvgNetWaitTime = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgNetWaitTime");
				dataItem.AvgUserIoWaitTime = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgUserIoWaitTime");
				dataItem.AvgGetPlanTime = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgGetPlanTime");
				dataItem.MaxElapsedTime = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].MaxElapsedTime");
				dataItem.SumWaitTime = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].SumWaitTime");
				dataItem.AvgScheduleTime = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgScheduleTime");
				dataItem.MaxCpuTime = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].MaxCpuTime");
				dataItem.SumElapsedTime = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].SumElapsedTime");
				dataItem.Timestamp = _ctx.StringValue("DescribeOasSQLHistoryList.Data["+ i +"].Timestamp");
				dataItem.Server = _ctx.StringValue("DescribeOasSQLHistoryList.Data["+ i +"].Server");
				dataItem.UserName = _ctx.StringValue("DescribeOasSQLHistoryList.Data["+ i +"].UserName");
				dataItem.AvgPartitionCount = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgPartitionCount");
				dataItem.FailPercentage = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].FailPercentage");
				dataItem.RetCode4012Count = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].RetCode4012Count");
				dataItem.RetCode4013Count = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].RetCode4013Count");
				dataItem.RetCode5001Count = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].RetCode5001Count");
				dataItem.RetCode5024Count = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].RetCode5024Count");
				dataItem.RetCode5167Count = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].RetCode5167Count");
				dataItem.RetCode5217Count = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].RetCode5217Count");
				dataItem.RetCode6002Count = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].RetCode6002Count");
				dataItem.AvgWaitTime = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgWaitTime");
				dataItem.AvgWaitCount = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgWaitCount");
				dataItem.LocalPlanPercentage = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].LocalPlanPercentage");
				dataItem.RemotePlanPercentage = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].RemotePlanPercentage");
				dataItem.DistPlanPercentage = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].DistPlanPercentage");
				dataItem.AvgNetTime = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgNetTime");
				dataItem.AvgExecutorRpcCount = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgExecutorRpcCount");
				dataItem.MissPlanPercentage = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].MissPlanPercentage");
				dataItem.TableScanPercentage = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].TableScanPercentage");
				dataItem.StrongConsistencyPercentage = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].StrongConsistencyPercentage");
				dataItem.WeakConsistencyPercentage = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].WeakConsistencyPercentage");
				dataItem.MaxAffectedRows = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].MaxAffectedRows");
				dataItem.MaxReturnRows = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].MaxReturnRows");
				dataItem.MaxWaitTime = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].MaxWaitTime");
				dataItem.MaxApplicationWaitTime = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].MaxApplicationWaitTime");
				dataItem.MaxConcurrencyWaitTime = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].MaxConcurrencyWaitTime");
				dataItem.MaxUserIoWaitTime = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].MaxUserIoWaitTime");
				dataItem.MaxDiskReads = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].MaxDiskReads");
				dataItem.AvgExpectedWorkerCount = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgExpectedWorkerCount");
				dataItem.AvgUsedWorkerCount = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].AvgUsedWorkerCount");
				dataItem.SumLogicalReads = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].SumLogicalReads");
				dataItem.ExecPs = _ctx.DoubleValue("DescribeOasSQLHistoryList.Data["+ i +"].ExecPs");

				describeOasSQLHistoryListResponse_data.Add(dataItem);
			}
			describeOasSQLHistoryListResponse.Data = describeOasSQLHistoryListResponse_data;
        
			return describeOasSQLHistoryListResponse;
        }
    }
}
