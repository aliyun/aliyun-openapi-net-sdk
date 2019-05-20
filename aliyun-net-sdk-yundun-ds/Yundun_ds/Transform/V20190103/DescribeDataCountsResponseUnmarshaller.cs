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
using Aliyun.Acs.Yundun_ds.Model.V20190103;

namespace Aliyun.Acs.Yundun_ds.Transform.V20190103
{
    public class DescribeDataCountsResponseUnmarshaller
    {
        public static DescribeDataCountsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDataCountsResponse describeDataCountsResponse = new DescribeDataCountsResponse();

			describeDataCountsResponse.HttpResponse = context.HttpResponse;
			describeDataCountsResponse.RequestId = context.StringValue("DescribeDataCounts.RequestId");

			List<DescribeDataCountsResponse.DescribeDataCounts_DataCount> describeDataCountsResponse_dataCountList = new List<DescribeDataCountsResponse.DescribeDataCounts_DataCount>();
			for (int i = 0; i < context.Length("DescribeDataCounts.DataCountList.Length"); i++) {
				DescribeDataCountsResponse.DescribeDataCounts_DataCount dataCount = new DescribeDataCountsResponse.DescribeDataCounts_DataCount();
				dataCount.ProductId = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].ProductId");
				dataCount.ProductCode = context.StringValue("DescribeDataCounts.DataCountList["+ i +"].ProductCode");

				DescribeDataCountsResponse.DescribeDataCounts_DataCount.DescribeDataCounts_Instance instance = new DescribeDataCountsResponse.DescribeDataCounts_DataCount.DescribeDataCounts_Instance();
				instance.TotalCount = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Instance.TotalCount");
				instance.Count = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Instance.Count");
				instance.SensitiveCount = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Instance.SensitiveCount");
				instance.LastCount = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Instance.LastCount");
				instance.LastSensitiveCount = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Instance.LastSensitiveCount");
				dataCount.Instance = instance;

				DescribeDataCountsResponse.DescribeDataCounts_DataCount.DescribeDataCounts_Table table = new DescribeDataCountsResponse.DescribeDataCounts_DataCount.DescribeDataCounts_Table();
				table.TotalCount = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Table.TotalCount");
				table.Count = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Table.Count");
				table.SensitiveCount = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Table.SensitiveCount");
				table.LastCount = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Table.LastCount");
				table.LastSensitiveCount = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Table.LastSensitiveCount");
				dataCount.Table = table;

				DescribeDataCountsResponse.DescribeDataCounts_DataCount.DescribeDataCounts_Package package = new DescribeDataCountsResponse.DescribeDataCounts_DataCount.DescribeDataCounts_Package();
				package.TotalCount = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Package.TotalCount");
				package.Count = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Package.Count");
				package.SensitiveCount = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Package.SensitiveCount");
				package.LastCount = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Package.LastCount");
				package.LastSensitiveCount = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Package.LastSensitiveCount");
				dataCount.Package = package;

				DescribeDataCountsResponse.DescribeDataCounts_DataCount.DescribeDataCounts_Column column = new DescribeDataCountsResponse.DescribeDataCounts_DataCount.DescribeDataCounts_Column();
				column.TotalCount = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Column.TotalCount");
				column.Count = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Column.Count");
				column.SensitiveCount = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Column.SensitiveCount");
				column.LastCount = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Column.LastCount");
				column.LastSensitiveCount = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Column.LastSensitiveCount");
				dataCount.Column = column;

				DescribeDataCountsResponse.DescribeDataCounts_DataCount.DescribeDataCounts_Oss oss = new DescribeDataCountsResponse.DescribeDataCounts_DataCount.DescribeDataCounts_Oss();
				oss.TotalCount = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Oss.TotalCount");
				oss.Count = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Oss.Count");
				oss.SensitiveCount = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Oss.SensitiveCount");
				oss.LastCount = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Oss.LastCount");
				oss.LastSensitiveCount = context.LongValue("DescribeDataCounts.DataCountList["+ i +"].Oss.LastSensitiveCount");
				dataCount.Oss = oss;

				describeDataCountsResponse_dataCountList.Add(dataCount);
			}
			describeDataCountsResponse.DataCountList = describeDataCountsResponse_dataCountList;
        
			return describeDataCountsResponse;
        }
    }
}
