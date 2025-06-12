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
using Aliyun.Acs.clickhouse.Model.V20191111;

namespace Aliyun.Acs.clickhouse.Transform.V20191111
{
    public class DescribeProcessListResponseUnmarshaller
    {
        public static DescribeProcessListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeProcessListResponse describeProcessListResponse = new DescribeProcessListResponse();

			describeProcessListResponse.HttpResponse = _ctx.HttpResponse;
			describeProcessListResponse.RequestId = _ctx.StringValue("DescribeProcessList.RequestId");

			DescribeProcessListResponse.DescribeProcessList_ProcessList processList = new DescribeProcessListResponse.DescribeProcessList_ProcessList();
			processList.Rows = _ctx.StringValue("DescribeProcessList.ProcessList.Rows");
			processList.RowsBeforeLimitAtLeast = _ctx.StringValue("DescribeProcessList.ProcessList.RowsBeforeLimitAtLeast");

			DescribeProcessListResponse.DescribeProcessList_ProcessList.DescribeProcessList_Statistics statistics = new DescribeProcessListResponse.DescribeProcessList_ProcessList.DescribeProcessList_Statistics();
			statistics.RowsRead = _ctx.IntegerValue("DescribeProcessList.ProcessList.Statistics.RowsRead");
			statistics.ElapsedTime = _ctx.FloatValue("DescribeProcessList.ProcessList.Statistics.ElapsedTime");
			statistics.BytesRead = _ctx.IntegerValue("DescribeProcessList.ProcessList.Statistics.BytesRead");
			processList.Statistics = statistics;

			List<DescribeProcessListResponse.DescribeProcessList_ProcessList.DescribeProcessList_ResultSet> processList_tableSchema = new List<DescribeProcessListResponse.DescribeProcessList_ProcessList.DescribeProcessList_ResultSet>();
			for (int i = 0; i < _ctx.Length("DescribeProcessList.ProcessList.TableSchema.Length"); i++) {
				DescribeProcessListResponse.DescribeProcessList_ProcessList.DescribeProcessList_ResultSet resultSet = new DescribeProcessListResponse.DescribeProcessList_ProcessList.DescribeProcessList_ResultSet();
				resultSet.Type = _ctx.StringValue("DescribeProcessList.ProcessList.TableSchema["+ i +"].Type");
				resultSet.Name = _ctx.StringValue("DescribeProcessList.ProcessList.TableSchema["+ i +"].Name");

				processList_tableSchema.Add(resultSet);
			}
			processList.TableSchema = processList_tableSchema;

			List<DescribeProcessListResponse.DescribeProcessList_ProcessList.DescribeProcessList_ResultSet1> processList_data = new List<DescribeProcessListResponse.DescribeProcessList_ProcessList.DescribeProcessList_ResultSet1>();
			for (int i = 0; i < _ctx.Length("DescribeProcessList.ProcessList.Data.Length"); i++) {
				DescribeProcessListResponse.DescribeProcessList_ProcessList.DescribeProcessList_ResultSet1 resultSet1 = new DescribeProcessListResponse.DescribeProcessList_ProcessList.DescribeProcessList_ResultSet1();
				resultSet1.QueryStartTime = _ctx.StringValue("DescribeProcessList.ProcessList.Data["+ i +"].QueryStartTime");
				resultSet1.Query = _ctx.StringValue("DescribeProcessList.ProcessList.Data["+ i +"].Query");
				resultSet1.InitialAddress = _ctx.StringValue("DescribeProcessList.ProcessList.Data["+ i +"].InitialAddress");
				resultSet1.InitialQueryId = _ctx.StringValue("DescribeProcessList.ProcessList.Data["+ i +"].InitialQueryId");
				resultSet1.InitialUser = _ctx.StringValue("DescribeProcessList.ProcessList.Data["+ i +"].InitialUser");
				resultSet1.QueryDurationMs = _ctx.StringValue("DescribeProcessList.ProcessList.Data["+ i +"].QueryDurationMs");

				processList_data.Add(resultSet1);
			}
			processList.Data = processList_data;
			describeProcessListResponse.ProcessList = processList;
        
			return describeProcessListResponse;
        }
    }
}
