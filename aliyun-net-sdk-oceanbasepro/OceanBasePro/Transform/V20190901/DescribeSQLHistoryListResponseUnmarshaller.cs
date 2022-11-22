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
    public class DescribeSQLHistoryListResponseUnmarshaller
    {
        public static DescribeSQLHistoryListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSQLHistoryListResponse describeSQLHistoryListResponse = new DescribeSQLHistoryListResponse();

			describeSQLHistoryListResponse.HttpResponse = _ctx.HttpResponse;
			describeSQLHistoryListResponse.RequestId = _ctx.StringValue("DescribeSQLHistoryList.RequestId");

			DescribeSQLHistoryListResponse.DescribeSQLHistoryList_SQLHistoryList sQLHistoryList = new DescribeSQLHistoryListResponse.DescribeSQLHistoryList_SQLHistoryList();
			sQLHistoryList.Count = _ctx.LongValue("DescribeSQLHistoryList.SQLHistoryList.Count");

			List<DescribeSQLHistoryListResponse.DescribeSQLHistoryList_SQLHistoryList.DescribeSQLHistoryList_ListItem> sQLHistoryList_list = new List<DescribeSQLHistoryListResponse.DescribeSQLHistoryList_SQLHistoryList.DescribeSQLHistoryList_ListItem>();
			for (int i = 0; i < _ctx.Length("DescribeSQLHistoryList.SQLHistoryList.List.Length"); i++) {
				DescribeSQLHistoryListResponse.DescribeSQLHistoryList_SQLHistoryList.DescribeSQLHistoryList_ListItem listItem = new DescribeSQLHistoryListResponse.DescribeSQLHistoryList_SQLHistoryList.DescribeSQLHistoryList_ListItem();
				listItem.ExecPerSecond = _ctx.LongValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].ExecPerSecond");
				listItem.MaxCpuTime = _ctx.FloatValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].MaxCpuTime");
				listItem.BlockCacheHit = _ctx.LongValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].BlockCacheHit");
				listItem.DecodeTime = _ctx.FloatValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].DecodeTime");
				listItem.RemotePlans = _ctx.LongValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].RemotePlans");
				listItem.RPCCount = _ctx.LongValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].RPCCount");
				listItem.NetWaitTime = _ctx.FloatValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].NetWaitTime");
				listItem.DiskRead = _ctx.LongValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].DiskRead");
				listItem.NodeIp = _ctx.StringValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].NodeIp");
				listItem.ConcurrencyWaitTime = _ctx.FloatValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].ConcurrencyWaitTime");
				listItem.DbName = _ctx.StringValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].DbName");
				listItem.MemstoreReadRowCount = _ctx.LongValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].MemstoreReadRowCount");
				listItem.AppWaitTime = _ctx.FloatValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].AppWaitTime");
				listItem.ElapsedTime = _ctx.FloatValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].ElapsedTime");
				listItem.MissPlans = _ctx.LongValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].MissPlans");
				listItem.AffectedRows = _ctx.LongValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].AffectedRows");
				listItem.ScheduleTime = _ctx.FloatValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].ScheduleTime");
				listItem._Event = _ctx.StringValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].Event");
				listItem.TotalWaitTime = _ctx.FloatValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].TotalWaitTime");
				listItem.ReturnRows = _ctx.LongValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].ReturnRows");
				listItem.ExecuteTime = _ctx.FloatValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].ExecuteTime");
				listItem.UserName = _ctx.StringValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].UserName");
				listItem.Executions = _ctx.LongValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].Executions");
				listItem.GetPlanTime = _ctx.FloatValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].GetPlanTime");
				listItem.CpuTime = _ctx.FloatValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].CpuTime");
				listItem.MaxElapsedTime = _ctx.FloatValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].MaxElapsedTime");
				listItem.BlockIndexCacheHit = _ctx.LongValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].BlockIndexCacheHit");
				listItem.EndTimeUTCString = _ctx.StringValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].EndTimeUTCString");
				listItem.EndTime = _ctx.LongValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].EndTime");
				listItem.RetryCount = _ctx.LongValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].RetryCount");
				listItem.ClientIp = _ctx.StringValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].ClientIp");
				listItem.BloomFilterCacheHit = _ctx.LongValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].BloomFilterCacheHit");
				listItem.IOWaitTime = _ctx.FloatValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].IOWaitTime");
				listItem.FailTimes = _ctx.LongValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].FailTimes");
				listItem.QueueTime = _ctx.FloatValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].QueueTime");
				listItem.RowCacheHit = _ctx.LongValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].RowCacheHit");
				listItem.LogicalRead = _ctx.LongValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].LogicalRead");
				listItem.SsstoreReadRowCount = _ctx.LongValue("DescribeSQLHistoryList.SQLHistoryList.List["+ i +"].SsstoreReadRowCount");

				sQLHistoryList_list.Add(listItem);
			}
			sQLHistoryList.List = sQLHistoryList_list;
			describeSQLHistoryListResponse.SQLHistoryList = sQLHistoryList;
        
			return describeSQLHistoryListResponse;
        }
    }
}
