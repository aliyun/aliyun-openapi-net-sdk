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
    public class DescribeSQLSamplesResponseUnmarshaller
    {
        public static DescribeSQLSamplesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSQLSamplesResponse describeSQLSamplesResponse = new DescribeSQLSamplesResponse();

			describeSQLSamplesResponse.HttpResponse = _ctx.HttpResponse;
			describeSQLSamplesResponse.RequestId = _ctx.StringValue("DescribeSQLSamples.RequestId");

			List<DescribeSQLSamplesResponse.DescribeSQLSamples_DataItem> describeSQLSamplesResponse_data = new List<DescribeSQLSamplesResponse.DescribeSQLSamples_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeSQLSamples.Data.Length"); i++) {
				DescribeSQLSamplesResponse.DescribeSQLSamples_DataItem dataItem = new DescribeSQLSamplesResponse.DescribeSQLSamples_DataItem();
				dataItem.RequestId = _ctx.StringValue("DescribeSQLSamples.Data["+ i +"].RequestId");
				dataItem.TraceId = _ctx.StringValue("DescribeSQLSamples.Data["+ i +"].TraceId");
				dataItem.RequestTime = _ctx.StringValue("DescribeSQLSamples.Data["+ i +"].RequestTime");
				dataItem.Server = _ctx.StringValue("DescribeSQLSamples.Data["+ i +"].Server");
				dataItem.ClientIp = _ctx.StringValue("DescribeSQLSamples.Data["+ i +"].ClientIp");
				dataItem.ClientPort = _ctx.StringValue("DescribeSQLSamples.Data["+ i +"].ClientPort");
				dataItem.DbName = _ctx.StringValue("DescribeSQLSamples.Data["+ i +"].DbName");
				dataItem.UserName = _ctx.StringValue("DescribeSQLSamples.Data["+ i +"].UserName");
				dataItem.SqlType = _ctx.StringValue("DescribeSQLSamples.Data["+ i +"].SqlType");
				dataItem.PlanId = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].PlanId");
				dataItem.AffectedRows = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].AffectedRows");
				dataItem.ReturnRows = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].ReturnRows");
				dataItem.PartitionCount = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].PartitionCount");
				dataItem.RetCode = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].RetCode");
				dataItem.WaitEvent = _ctx.StringValue("DescribeSQLSamples.Data["+ i +"].WaitEvent");
				dataItem.WaitTime = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].WaitTime");
				dataItem.WaitCount = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].WaitCount");
				dataItem.RpcCount = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].RpcCount");
				dataItem.PlanType = _ctx.StringValue("DescribeSQLSamples.Data["+ i +"].PlanType");
				dataItem.Inner = _ctx.BooleanValue("DescribeSQLSamples.Data["+ i +"].Inner");
				dataItem.ExecutorRpc = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].ExecutorRpc");
				dataItem.HitPlan = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].HitPlan");
				dataItem.ElapsedTime = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].ElapsedTime");
				dataItem.CpuTime = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].CpuTime");
				dataItem.NetTime = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].NetTime");
				dataItem.NetWaitTime = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].NetWaitTime");
				dataItem.QueueTime = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].QueueTime");
				dataItem.DecodeTime = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].DecodeTime");
				dataItem.GetPlanTime = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].GetPlanTime");
				dataItem.ExecuteTime = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].ExecuteTime");
				dataItem.ApplicationWaitTime = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].ApplicationWaitTime");
				dataItem.ConcurrencyWaitTime = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].ConcurrencyWaitTime");
				dataItem.UserIoWaitTime = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].UserIoWaitTime");
				dataItem.ScheduleTime = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].ScheduleTime");
				dataItem.RowCacheHit = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].RowCacheHit");
				dataItem.BloomFilterCacheHit = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].BloomFilterCacheHit");
				dataItem.BlockCacheHit = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].BlockCacheHit");
				dataItem.BlockIndexCacheHit = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].BlockIndexCacheHit");
				dataItem.DiskReads = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].DiskReads");
				dataItem.RetryCount = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].RetryCount");
				dataItem.TableScan = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].TableScan");
				dataItem.ConsistencyLevel = _ctx.StringValue("DescribeSQLSamples.Data["+ i +"].ConsistencyLevel");
				dataItem.MemstoreReadRows = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].MemstoreReadRows");
				dataItem.ExpectedWorkerCount = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].ExpectedWorkerCount");
				dataItem.UsedWorkerCount = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].UsedWorkerCount");
				dataItem.SsstoreReadRows = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].SsstoreReadRows");
				dataItem.ObServerId = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].ObServerId");
				dataItem.ObUserId = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].ObUserId");
				dataItem.ObDbId = _ctx.DoubleValue("DescribeSQLSamples.Data["+ i +"].ObDbId");
				dataItem.Statement = _ctx.StringValue("DescribeSQLSamples.Data["+ i +"].Statement");
				dataItem.TransHash = _ctx.StringValue("DescribeSQLSamples.Data["+ i +"].TransHash");

				describeSQLSamplesResponse_data.Add(dataItem);
			}
			describeSQLSamplesResponse.Data = describeSQLSamplesResponse_data;
        
			return describeSQLSamplesResponse;
        }
    }
}
