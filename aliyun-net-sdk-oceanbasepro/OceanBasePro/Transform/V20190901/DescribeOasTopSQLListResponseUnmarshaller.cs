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
    public class DescribeOasTopSQLListResponseUnmarshaller
    {
        public static DescribeOasTopSQLListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOasTopSQLListResponse describeOasTopSQLListResponse = new DescribeOasTopSQLListResponse();

			describeOasTopSQLListResponse.HttpResponse = _ctx.HttpResponse;
			describeOasTopSQLListResponse.RequestId = _ctx.StringValue("DescribeOasTopSQLList.RequestId");

			List<DescribeOasTopSQLListResponse.DescribeOasTopSQLList_DataItem> describeOasTopSQLListResponse_data = new List<DescribeOasTopSQLListResponse.DescribeOasTopSQLList_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeOasTopSQLList.Data.Length"); i++) {
				DescribeOasTopSQLListResponse.DescribeOasTopSQLList_DataItem dataItem = new DescribeOasTopSQLListResponse.DescribeOasTopSQLList_DataItem();
				dataItem.Executions = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].Executions");
				dataItem.RpcCount = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].RpcCount");
				dataItem.RemotePlans = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].RemotePlans");
				dataItem.MissPlans = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].MissPlans");
				dataItem.MaxElapsedTime = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].MaxElapsedTime");
				dataItem.TotalWaitTime = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].TotalWaitTime");
				dataItem.ExecPs = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].ExecPs");
				dataItem.MaxCpuTime = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].MaxCpuTime");
				dataItem.CpuPercentage = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].CpuPercentage");
				dataItem.ClientIp = _ctx.StringValue("DescribeOasTopSQLList.Data["+ i +"].ClientIp");
				dataItem.UserName = _ctx.StringValue("DescribeOasTopSQLList.Data["+ i +"].UserName");
				dataItem.DbName = _ctx.StringValue("DescribeOasTopSQLList.Data["+ i +"].DbName");
				dataItem.RetCode4012Count = _ctx.LongValue("DescribeOasTopSQLList.Data["+ i +"].RetCode4012Count");
				dataItem.RetCode4013Count = _ctx.LongValue("DescribeOasTopSQLList.Data["+ i +"].RetCode4013Count");
				dataItem.RetCode5001Count = _ctx.LongValue("DescribeOasTopSQLList.Data["+ i +"].RetCode5001Count");
				dataItem.RetCode5024Count = _ctx.LongValue("DescribeOasTopSQLList.Data["+ i +"].RetCode5024Count");
				dataItem.RetCode5167Count = _ctx.LongValue("DescribeOasTopSQLList.Data["+ i +"].RetCode5167Count");
				dataItem.RetCode5217Count = _ctx.LongValue("DescribeOasTopSQLList.Data["+ i +"].RetCode5217Count");
				dataItem.RetCode6002Count = _ctx.LongValue("DescribeOasTopSQLList.Data["+ i +"].RetCode6002Count");
				dataItem.FailPercentage = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].FailPercentage");
				dataItem.SumWaitTime = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].SumWaitTime");
				dataItem.AvgWaitCount = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgWaitCount");
				dataItem.AvgRpcCount = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgRpcCount");
				dataItem.LocalPlanPercentage = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].LocalPlanPercentage");
				dataItem.RemotePlanPercentage = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].RemotePlanPercentage");
				dataItem.DistPlanPercentage = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].DistPlanPercentage");
				dataItem.SumElapsedTime = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].SumElapsedTime");
				dataItem.AvgNetTime = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgNetTime");
				dataItem.AvgExecutorRpcCount = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgExecutorRpcCount");
				dataItem.MissPlanPercentage = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].MissPlanPercentage");
				dataItem.TableScanPercentage = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].TableScanPercentage");
				dataItem.StrongConsistencyPercentage = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].StrongConsistencyPercentage");
				dataItem.WeakConsistencyPercentage = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].WeakConsistencyPercentage");
				dataItem.MaxAffectedRows = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].MaxAffectedRows");
				dataItem.MaxReturnRows = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].MaxReturnRows");
				dataItem.MaxWaitTime = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].MaxWaitTime");
				dataItem.MaxApplicationWaitTime = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].MaxApplicationWaitTime");
				dataItem.MaxConcurrencyWaitTime = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].MaxConcurrencyWaitTime");
				dataItem.MaxUserIoWaitTime = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].MaxUserIoWaitTime");
				dataItem.MaxDiskReads = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].MaxDiskReads");
				dataItem.AvgExpectedWorkerCount = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgExpectedWorkerCount");
				dataItem.AvgUsedWorkerCount = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgUsedWorkerCount");
				dataItem.SumLogicalReads = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].SumLogicalReads");
				dataItem.Server = _ctx.StringValue("DescribeOasTopSQLList.Data["+ i +"].Server");
				dataItem.ServerIp = _ctx.StringValue("DescribeOasTopSQLList.Data["+ i +"].ServerIp");
				dataItem.ServerPort = _ctx.LongValue("DescribeOasTopSQLList.Data["+ i +"].ServerPort");
				dataItem.SqlTextShort = _ctx.StringValue("DescribeOasTopSQLList.Data["+ i +"].SqlTextShort");
				dataItem.SqlType = _ctx.StringValue("DescribeOasTopSQLList.Data["+ i +"].SqlType");
				dataItem.SqlId = _ctx.StringValue("DescribeOasTopSQLList.Data["+ i +"].SqlId");
				dataItem.Inner = _ctx.BooleanValue("DescribeOasTopSQLList.Data["+ i +"].Inner");
				dataItem.WaitEvent = _ctx.StringValue("DescribeOasTopSQLList.Data["+ i +"].WaitEvent");
				dataItem.AvgAffectedRows = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgAffectedRows");
				dataItem.AvgReturnRows = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgReturnRows");
				dataItem.AvgPartitionCount = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgPartitionCount");
				dataItem.FailCount = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].FailCount");
				dataItem.AvgWaitTime = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgWaitTime");
				dataItem.AvgElapsedTime = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgElapsedTime");
				dataItem.AvgCpuTime = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgCpuTime");
				dataItem.AvgNetWaitTime = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgNetWaitTime");
				dataItem.AvgQueueTime = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgQueueTime");
				dataItem.AvgDecodeTime = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgDecodeTime");
				dataItem.AvgGetPlanTime = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgGetPlanTime");
				dataItem.AvgExecuteTime = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgExecuteTime");
				dataItem.AvgApplicationWaitTime = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgApplicationWaitTime");
				dataItem.AvgConcurrencyWaitTime = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgConcurrencyWaitTime");
				dataItem.AvgUserIoWaitTime = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgUserIoWaitTime");
				dataItem.AvgScheduleTime = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgScheduleTime");
				dataItem.AvgRowCacheHit = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgRowCacheHit");
				dataItem.AvgBloomFilterCacheHit = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgBloomFilterCacheHit");
				dataItem.AvgBlockCacheHit = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgBlockCacheHit");
				dataItem.AvgBlockIndexCacheHit = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgBlockIndexCacheHit");
				dataItem.AvgDiskReads = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgDiskReads");
				dataItem.RetryCount = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].RetryCount");
				dataItem.AvgMemstoreReadRows = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgMemstoreReadRows");
				dataItem.AvgSsstoreReadRows = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgSsstoreReadRows");
				dataItem.AvgLogicalReads = _ctx.DoubleValue("DescribeOasTopSQLList.Data["+ i +"].AvgLogicalReads");

				describeOasTopSQLListResponse_data.Add(dataItem);
			}
			describeOasTopSQLListResponse.Data = describeOasTopSQLListResponse_data;
        
			return describeOasTopSQLListResponse;
        }
    }
}
