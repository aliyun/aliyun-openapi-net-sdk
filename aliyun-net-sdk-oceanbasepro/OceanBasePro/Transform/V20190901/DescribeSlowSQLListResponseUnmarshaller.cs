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
    public class DescribeSlowSQLListResponseUnmarshaller
    {
        public static DescribeSlowSQLListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSlowSQLListResponse describeSlowSQLListResponse = new DescribeSlowSQLListResponse();

			describeSlowSQLListResponse.HttpResponse = _ctx.HttpResponse;
			describeSlowSQLListResponse.TotalCount = _ctx.LongValue("DescribeSlowSQLList.TotalCount");
			describeSlowSQLListResponse.RequestId = _ctx.StringValue("DescribeSlowSQLList.RequestId");

			List<DescribeSlowSQLListResponse.DescribeSlowSQLList_Data> describeSlowSQLListResponse_slowSQLList = new List<DescribeSlowSQLListResponse.DescribeSlowSQLList_Data>();
			for (int i = 0; i < _ctx.Length("DescribeSlowSQLList.SlowSQLList.Length"); i++) {
				DescribeSlowSQLListResponse.DescribeSlowSQLList_Data data = new DescribeSlowSQLListResponse.DescribeSlowSQLList_Data();
				data.Key = _ctx.LongValue("DescribeSlowSQLList.SlowSQLList["+ i +"].Key");
				data.ExecPerSecond = _ctx.FloatValue("DescribeSlowSQLList.SlowSQLList["+ i +"].ExecPerSecond");
				data.SQLText = _ctx.StringValue("DescribeSlowSQLList.SlowSQLList["+ i +"].SQLText");
				data.MaxCpuTime = _ctx.FloatValue("DescribeSlowSQLList.SlowSQLList["+ i +"].MaxCpuTime");
				data.BlockCacheHit = _ctx.LongValue("DescribeSlowSQLList.SlowSQLList["+ i +"].BlockCacheHit");
				data.DecodeTime = _ctx.FloatValue("DescribeSlowSQLList.SlowSQLList["+ i +"].DecodeTime");
				data.RemotePlans = _ctx.LongValue("DescribeSlowSQLList.SlowSQLList["+ i +"].RemotePlans");
				data.RPCCount = _ctx.LongValue("DescribeSlowSQLList.SlowSQLList["+ i +"].RPCCount");
				data.NetWaitTime = _ctx.FloatValue("DescribeSlowSQLList.SlowSQLList["+ i +"].NetWaitTime");
				data.DiskRead = _ctx.LongValue("DescribeSlowSQLList.SlowSQLList["+ i +"].DiskRead");
				data.NodeIp = _ctx.StringValue("DescribeSlowSQLList.SlowSQLList["+ i +"].NodeIp");
				data.ConcurrencyWaitTime = _ctx.FloatValue("DescribeSlowSQLList.SlowSQLList["+ i +"].ConcurrencyWaitTime");
				data.MemstoreReadRowCount = _ctx.LongValue("DescribeSlowSQLList.SlowSQLList["+ i +"].MemstoreReadRowCount");
				data.DbName = _ctx.StringValue("DescribeSlowSQLList.SlowSQLList["+ i +"].DbName");
				data.AppWaitTime = _ctx.FloatValue("DescribeSlowSQLList.SlowSQLList["+ i +"].AppWaitTime");
				data.ElapsedTime = _ctx.FloatValue("DescribeSlowSQLList.SlowSQLList["+ i +"].ElapsedTime");
				data.MissPlans = _ctx.LongValue("DescribeSlowSQLList.SlowSQLList["+ i +"].MissPlans");
				data.AffectedRows = _ctx.LongValue("DescribeSlowSQLList.SlowSQLList["+ i +"].AffectedRows");
				data.ScheduleTime = _ctx.FloatValue("DescribeSlowSQLList.SlowSQLList["+ i +"].ScheduleTime");
				data._Event = _ctx.StringValue("DescribeSlowSQLList.SlowSQLList["+ i +"].Event");
				data.TotalWaitTime = _ctx.FloatValue("DescribeSlowSQLList.SlowSQLList["+ i +"].TotalWaitTime");
				data.ReturnRows = _ctx.LongValue("DescribeSlowSQLList.SlowSQLList["+ i +"].ReturnRows");
				data.ExecuteTime = _ctx.FloatValue("DescribeSlowSQLList.SlowSQLList["+ i +"].ExecuteTime");
				data.UserName = _ctx.StringValue("DescribeSlowSQLList.SlowSQLList["+ i +"].UserName");
				data.Executions = _ctx.LongValue("DescribeSlowSQLList.SlowSQLList["+ i +"].Executions");
				data.GetPlanTime = _ctx.FloatValue("DescribeSlowSQLList.SlowSQLList["+ i +"].GetPlanTime");
				data.CpuTime = _ctx.FloatValue("DescribeSlowSQLList.SlowSQLList["+ i +"].CpuTime");
				data.MaxElapsedTime = _ctx.FloatValue("DescribeSlowSQLList.SlowSQLList["+ i +"].MaxElapsedTime");
				data.SQLType = _ctx.LongValue("DescribeSlowSQLList.SlowSQLList["+ i +"].SQLType");
				data.BlockIndexCacheHit = _ctx.LongValue("DescribeSlowSQLList.SlowSQLList["+ i +"].BlockIndexCacheHit");
				data.RetryCount = _ctx.LongValue("DescribeSlowSQLList.SlowSQLList["+ i +"].RetryCount");
				data.SQLId = _ctx.StringValue("DescribeSlowSQLList.SlowSQLList["+ i +"].SQLId");
				data.ClientIp = _ctx.StringValue("DescribeSlowSQLList.SlowSQLList["+ i +"].ClientIp");
				data.BloomFilterCacheHit = _ctx.LongValue("DescribeSlowSQLList.SlowSQLList["+ i +"].BloomFilterCacheHit");
				data.IOWaitTime = _ctx.FloatValue("DescribeSlowSQLList.SlowSQLList["+ i +"].IOWaitTime");
				data.FailTimes = _ctx.LongValue("DescribeSlowSQLList.SlowSQLList["+ i +"].FailTimes");
				data.QueueTime = _ctx.FloatValue("DescribeSlowSQLList.SlowSQLList["+ i +"].QueueTime");
				data.RowCacheHit = _ctx.LongValue("DescribeSlowSQLList.SlowSQLList["+ i +"].RowCacheHit");
				data.LogicalRead = _ctx.LongValue("DescribeSlowSQLList.SlowSQLList["+ i +"].LogicalRead");
				data.SsstoreReadRowCount = _ctx.LongValue("DescribeSlowSQLList.SlowSQLList["+ i +"].SsstoreReadRowCount");

				describeSlowSQLListResponse_slowSQLList.Add(data);
			}
			describeSlowSQLListResponse.SlowSQLList = describeSlowSQLListResponse_slowSQLList;
        
			return describeSlowSQLListResponse;
        }
    }
}
