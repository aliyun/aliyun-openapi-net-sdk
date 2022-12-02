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
    public class DescribeSlowSQLHistoryListResponseUnmarshaller
    {
        public static DescribeSlowSQLHistoryListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSlowSQLHistoryListResponse describeSlowSQLHistoryListResponse = new DescribeSlowSQLHistoryListResponse();

			describeSlowSQLHistoryListResponse.HttpResponse = _ctx.HttpResponse;
			describeSlowSQLHistoryListResponse.RequestId = _ctx.StringValue("DescribeSlowSQLHistoryList.RequestId");

			DescribeSlowSQLHistoryListResponse.DescribeSlowSQLHistoryList_SlowSQLHistoryList slowSQLHistoryList = new DescribeSlowSQLHistoryListResponse.DescribeSlowSQLHistoryList_SlowSQLHistoryList();
			slowSQLHistoryList.Count = _ctx.LongValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.Count");

			List<DescribeSlowSQLHistoryListResponse.DescribeSlowSQLHistoryList_SlowSQLHistoryList.DescribeSlowSQLHistoryList_ListItem> slowSQLHistoryList_list = new List<DescribeSlowSQLHistoryListResponse.DescribeSlowSQLHistoryList_SlowSQLHistoryList.DescribeSlowSQLHistoryList_ListItem>();
			for (int i = 0; i < _ctx.Length("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List.Length"); i++) {
				DescribeSlowSQLHistoryListResponse.DescribeSlowSQLHistoryList_SlowSQLHistoryList.DescribeSlowSQLHistoryList_ListItem listItem = new DescribeSlowSQLHistoryListResponse.DescribeSlowSQLHistoryList_SlowSQLHistoryList.DescribeSlowSQLHistoryList_ListItem();
				listItem.SqlId = _ctx.StringValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].SqlId");
				listItem.SqlType = _ctx.StringValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].SqlType");
				listItem.TenantName = _ctx.StringValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].TenantName");
				listItem.UserName = _ctx.StringValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].UserName");
				listItem.ClientIp = _ctx.StringValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].ClientIp");
				listItem.DbName = _ctx.StringValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].DbName");
				listItem._Event = _ctx.StringValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].Event");
				listItem.NodeIp = _ctx.StringValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].NodeIp");
				listItem.AffectedRows = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].AffectedRows");
				listItem.BlockCacheHit = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].BlockCacheHit");
				listItem.BlockIndexCacheHit = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].BlockIndexCacheHit");
				listItem.BloomFilterCacheHit = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].BloomFilterCacheHit");
				listItem.Executions = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].Executions");
				listItem.FailTimes = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].FailTimes");
				listItem.RPCCount = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].RPCCount");
				listItem.RemotePlans = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].RemotePlans");
				listItem.MissPlans = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].MissPlans");
				listItem.ReturnRows = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].ReturnRows");
				listItem.LogicalRead = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].LogicalRead");
				listItem.RetryCount = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].RetryCount");
				listItem.RowCacheHit = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].RowCacheHit");
				listItem.DiskRead = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].DiskRead");
				listItem.MemstoreReadRowCount = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].MemstoreReadRowCount");
				listItem.SsstoreReadRowCount = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].SsstoreReadRowCount");
				listItem.ExecPerSecond = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].ExecPerSecond");
				listItem.AppWaitTime = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].AppWaitTime");
				listItem.ElapsedTime = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].ElapsedTime");
				listItem.ExecuteTime = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].ExecuteTime");
				listItem.QueueTime = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].QueueTime");
				listItem.ConcurrencyWaitTime = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].ConcurrencyWaitTime");
				listItem.CpuTime = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].CpuTime");
				listItem.DecodeTime = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].DecodeTime");
				listItem.NetWaitTime = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].NetWaitTime");
				listItem.IOWaitTime = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].IOWaitTime");
				listItem.GetPlanTime = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].GetPlanTime");
				listItem.MaxElapsedTime = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].MaxElapsedTime");
				listItem.TotalWaitTime = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].TotalWaitTime");
				listItem.ScheduleTime = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].ScheduleTime");
				listItem.MaxCpuTime = _ctx.DoubleValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].MaxCpuTime");
				listItem.EndTimeUTCString = _ctx.StringValue("DescribeSlowSQLHistoryList.SlowSQLHistoryList.List["+ i +"].EndTimeUTCString");

				slowSQLHistoryList_list.Add(listItem);
			}
			slowSQLHistoryList.List = slowSQLHistoryList_list;
			describeSlowSQLHistoryListResponse.SlowSQLHistoryList = slowSQLHistoryList;
        
			return describeSlowSQLHistoryListResponse;
        }
    }
}
