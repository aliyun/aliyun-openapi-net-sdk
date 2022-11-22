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
    public class DescribeTopSQLListResponseUnmarshaller
    {
        public static DescribeTopSQLListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTopSQLListResponse describeTopSQLListResponse = new DescribeTopSQLListResponse();

			describeTopSQLListResponse.HttpResponse = _ctx.HttpResponse;
			describeTopSQLListResponse.TotalCount = _ctx.LongValue("DescribeTopSQLList.TotalCount");
			describeTopSQLListResponse.RequestId = _ctx.StringValue("DescribeTopSQLList.RequestId");

			List<DescribeTopSQLListResponse.DescribeTopSQLList_Data> describeTopSQLListResponse_topSQLList = new List<DescribeTopSQLListResponse.DescribeTopSQLList_Data>();
			for (int i = 0; i < _ctx.Length("DescribeTopSQLList.TopSQLList.Length"); i++) {
				DescribeTopSQLListResponse.DescribeTopSQLList_Data data = new DescribeTopSQLListResponse.DescribeTopSQLList_Data();
				data.Key = _ctx.LongValue("DescribeTopSQLList.TopSQLList["+ i +"].Key");
				data.ExecPerSecond = _ctx.FloatValue("DescribeTopSQLList.TopSQLList["+ i +"].ExecPerSecond");
				data.SQLText = _ctx.StringValue("DescribeTopSQLList.TopSQLList["+ i +"].SQLText");
				data.MaxCpuTime = _ctx.FloatValue("DescribeTopSQLList.TopSQLList["+ i +"].MaxCpuTime");
				data.BlockCacheHit = _ctx.LongValue("DescribeTopSQLList.TopSQLList["+ i +"].BlockCacheHit");
				data.DecodeTime = _ctx.FloatValue("DescribeTopSQLList.TopSQLList["+ i +"].DecodeTime");
				data.RemotePlans = _ctx.LongValue("DescribeTopSQLList.TopSQLList["+ i +"].RemotePlans");
				data.RPCCount = _ctx.LongValue("DescribeTopSQLList.TopSQLList["+ i +"].RPCCount");
				data.NetWaitTime = _ctx.FloatValue("DescribeTopSQLList.TopSQLList["+ i +"].NetWaitTime");
				data.DiskRead = _ctx.LongValue("DescribeTopSQLList.TopSQLList["+ i +"].DiskRead");
				data.NodeIp = _ctx.StringValue("DescribeTopSQLList.TopSQLList["+ i +"].NodeIp");
				data.ConcurrencyWaitTime = _ctx.FloatValue("DescribeTopSQLList.TopSQLList["+ i +"].ConcurrencyWaitTime");
				data.MemstoreReadRowCount = _ctx.LongValue("DescribeTopSQLList.TopSQLList["+ i +"].MemstoreReadRowCount");
				data.DbName = _ctx.StringValue("DescribeTopSQLList.TopSQLList["+ i +"].DbName");
				data.AppWaitTime = _ctx.FloatValue("DescribeTopSQLList.TopSQLList["+ i +"].AppWaitTime");
				data.ElapsedTime = _ctx.FloatValue("DescribeTopSQLList.TopSQLList["+ i +"].ElapsedTime");
				data.MissPlans = _ctx.LongValue("DescribeTopSQLList.TopSQLList["+ i +"].MissPlans");
				data.AffectedRows = _ctx.LongValue("DescribeTopSQLList.TopSQLList["+ i +"].AffectedRows");
				data.ScheduleTime = _ctx.FloatValue("DescribeTopSQLList.TopSQLList["+ i +"].ScheduleTime");
				data._Event = _ctx.StringValue("DescribeTopSQLList.TopSQLList["+ i +"].Event");
				data.TotalWaitTime = _ctx.FloatValue("DescribeTopSQLList.TopSQLList["+ i +"].TotalWaitTime");
				data.ReturnRows = _ctx.LongValue("DescribeTopSQLList.TopSQLList["+ i +"].ReturnRows");
				data.ExecuteTime = _ctx.FloatValue("DescribeTopSQLList.TopSQLList["+ i +"].ExecuteTime");
				data.UserName = _ctx.StringValue("DescribeTopSQLList.TopSQLList["+ i +"].UserName");
				data.Executions = _ctx.LongValue("DescribeTopSQLList.TopSQLList["+ i +"].Executions");
				data.GetPlanTime = _ctx.FloatValue("DescribeTopSQLList.TopSQLList["+ i +"].GetPlanTime");
				data.CpuTime = _ctx.FloatValue("DescribeTopSQLList.TopSQLList["+ i +"].CpuTime");
				data.MaxElapsedTime = _ctx.FloatValue("DescribeTopSQLList.TopSQLList["+ i +"].MaxElapsedTime");
				data.SQLType = _ctx.LongValue("DescribeTopSQLList.TopSQLList["+ i +"].SQLType");
				data.BlockIndexCacheHit = _ctx.LongValue("DescribeTopSQLList.TopSQLList["+ i +"].BlockIndexCacheHit");
				data.RetryCount = _ctx.LongValue("DescribeTopSQLList.TopSQLList["+ i +"].RetryCount");
				data.SQLId = _ctx.StringValue("DescribeTopSQLList.TopSQLList["+ i +"].SQLId");
				data.ClientIp = _ctx.StringValue("DescribeTopSQLList.TopSQLList["+ i +"].ClientIp");
				data.BloomFilterCacheHit = _ctx.LongValue("DescribeTopSQLList.TopSQLList["+ i +"].BloomFilterCacheHit");
				data.IOWaitTime = _ctx.FloatValue("DescribeTopSQLList.TopSQLList["+ i +"].IOWaitTime");
				data.FailTimes = _ctx.LongValue("DescribeTopSQLList.TopSQLList["+ i +"].FailTimes");
				data.QueueTime = _ctx.FloatValue("DescribeTopSQLList.TopSQLList["+ i +"].QueueTime");
				data.RowCacheHit = _ctx.LongValue("DescribeTopSQLList.TopSQLList["+ i +"].RowCacheHit");
				data.LogicalRead = _ctx.LongValue("DescribeTopSQLList.TopSQLList["+ i +"].LogicalRead");
				data.SsstoreReadRowCount = _ctx.LongValue("DescribeTopSQLList.TopSQLList["+ i +"].SsstoreReadRowCount");

				describeTopSQLListResponse_topSQLList.Add(data);
			}
			describeTopSQLListResponse.TopSQLList = describeTopSQLListResponse_topSQLList;
        
			return describeTopSQLListResponse;
        }
    }
}
