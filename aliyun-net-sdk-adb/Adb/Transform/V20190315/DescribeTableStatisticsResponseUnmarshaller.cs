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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeTableStatisticsResponseUnmarshaller
    {
        public static DescribeTableStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTableStatisticsResponse describeTableStatisticsResponse = new DescribeTableStatisticsResponse();

			describeTableStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			describeTableStatisticsResponse.TotalCount = _ctx.StringValue("DescribeTableStatistics.TotalCount");
			describeTableStatisticsResponse.RequestId = _ctx.StringValue("DescribeTableStatistics.RequestId");
			describeTableStatisticsResponse.PageSize = _ctx.StringValue("DescribeTableStatistics.PageSize");
			describeTableStatisticsResponse.PageNumber = _ctx.StringValue("DescribeTableStatistics.PageNumber");
			describeTableStatisticsResponse.DBClusterId = _ctx.StringValue("DescribeTableStatistics.DBClusterId");

			List<DescribeTableStatisticsResponse.DescribeTableStatistics_TableStatisticRecords> describeTableStatisticsResponse_items = new List<DescribeTableStatisticsResponse.DescribeTableStatistics_TableStatisticRecords>();
			for (int i = 0; i < _ctx.Length("DescribeTableStatistics.Items.Length"); i++) {
				DescribeTableStatisticsResponse.DescribeTableStatistics_TableStatisticRecords tableStatisticRecords = new DescribeTableStatisticsResponse.DescribeTableStatistics_TableStatisticRecords();
				tableStatisticRecords.TableName = _ctx.StringValue("DescribeTableStatistics.Items["+ i +"].TableName");
				tableStatisticRecords.ColdDataSize = _ctx.LongValue("DescribeTableStatistics.Items["+ i +"].ColdDataSize");
				tableStatisticRecords.DataSize = _ctx.LongValue("DescribeTableStatistics.Items["+ i +"].DataSize");
				tableStatisticRecords.PrimaryKeyIndexSize = _ctx.LongValue("DescribeTableStatistics.Items["+ i +"].PrimaryKeyIndexSize");
				tableStatisticRecords.IndexSize = _ctx.LongValue("DescribeTableStatistics.Items["+ i +"].IndexSize");
				tableStatisticRecords.RowCount = _ctx.LongValue("DescribeTableStatistics.Items["+ i +"].RowCount");
				tableStatisticRecords.PartitionCount = _ctx.LongValue("DescribeTableStatistics.Items["+ i +"].PartitionCount");
				tableStatisticRecords.SchemaName = _ctx.StringValue("DescribeTableStatistics.Items["+ i +"].SchemaName");

				describeTableStatisticsResponse_items.Add(tableStatisticRecords);
			}
			describeTableStatisticsResponse.Items = describeTableStatisticsResponse_items;
        
			return describeTableStatisticsResponse;
        }
    }
}
