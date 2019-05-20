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
    public class DescribeDataTotalCountResponseUnmarshaller
    {
        public static DescribeDataTotalCountResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDataTotalCountResponse describeDataTotalCountResponse = new DescribeDataTotalCountResponse();

			describeDataTotalCountResponse.HttpResponse = context.HttpResponse;
			describeDataTotalCountResponse.RequestId = context.StringValue("DescribeDataTotalCount.RequestId");

			DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount dataCount = new DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount();

			DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Instance instance = new DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Instance();
			instance.TotalCount = context.LongValue("DescribeDataTotalCount.DataCount.Instance.TotalCount");
			instance.Count = context.LongValue("DescribeDataTotalCount.DataCount.Instance.Count");
			instance.SensitiveCount = context.LongValue("DescribeDataTotalCount.DataCount.Instance.SensitiveCount");
			instance.LastCount = context.LongValue("DescribeDataTotalCount.DataCount.Instance.LastCount");
			instance.LastSensitiveCount = context.LongValue("DescribeDataTotalCount.DataCount.Instance.LastSensitiveCount");

			List<DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Instance.DescribeDataTotalCount_RiskCount> instance_riskCountList = new List<DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Instance.DescribeDataTotalCount_RiskCount>();
			for (int i = 0; i < context.Length("DescribeDataTotalCount.DataCount.Instance.RiskCountList.Length"); i++) {
				DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Instance.DescribeDataTotalCount_RiskCount riskCount = new DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Instance.DescribeDataTotalCount_RiskCount();
				riskCount.Id = context.LongValue("DescribeDataTotalCount.DataCount.Instance.RiskCountList["+ i +"].Id");
				riskCount.Name = context.StringValue("DescribeDataTotalCount.DataCount.Instance.RiskCountList["+ i +"].Name");
				riskCount.Count = context.LongValue("DescribeDataTotalCount.DataCount.Instance.RiskCountList["+ i +"].Count");

				instance_riskCountList.Add(riskCount);
			}
			instance.RiskCountList = instance_riskCountList;
			dataCount.Instance = instance;

			DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Table table = new DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Table();
			table.TotalCount = context.LongValue("DescribeDataTotalCount.DataCount.Table.TotalCount");
			table.Count = context.LongValue("DescribeDataTotalCount.DataCount.Table.Count");
			table.SensitiveCount = context.LongValue("DescribeDataTotalCount.DataCount.Table.SensitiveCount");
			table.LastCount = context.LongValue("DescribeDataTotalCount.DataCount.Table.LastCount");
			table.LastSensitiveCount = context.LongValue("DescribeDataTotalCount.DataCount.Table.LastSensitiveCount");

			List<DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Table.DescribeDataTotalCount_RiskCount2> table_riskCountList1 = new List<DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Table.DescribeDataTotalCount_RiskCount2>();
			for (int i = 0; i < context.Length("DescribeDataTotalCount.DataCount.Table.RiskCountList.Length"); i++) {
				DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Table.DescribeDataTotalCount_RiskCount2 riskCount2 = new DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Table.DescribeDataTotalCount_RiskCount2();
				riskCount2.Id = context.LongValue("DescribeDataTotalCount.DataCount.Table.RiskCountList["+ i +"].Id");
				riskCount2.Name = context.StringValue("DescribeDataTotalCount.DataCount.Table.RiskCountList["+ i +"].Name");
				riskCount2.Count = context.LongValue("DescribeDataTotalCount.DataCount.Table.RiskCountList["+ i +"].Count");

				table_riskCountList1.Add(riskCount2);
			}
			table.RiskCountList1 = table_riskCountList1;
			dataCount.Table = table;

			DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Package package = new DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Package();
			package.TotalCount = context.LongValue("DescribeDataTotalCount.DataCount.Package.TotalCount");
			package.Count = context.LongValue("DescribeDataTotalCount.DataCount.Package.Count");
			package.SensitiveCount = context.LongValue("DescribeDataTotalCount.DataCount.Package.SensitiveCount");
			package.LastCount = context.LongValue("DescribeDataTotalCount.DataCount.Package.LastCount");
			package.LastSensitiveCount = context.LongValue("DescribeDataTotalCount.DataCount.Package.LastSensitiveCount");

			List<DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Package.DescribeDataTotalCount_RiskCount4> package_riskCountList3 = new List<DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Package.DescribeDataTotalCount_RiskCount4>();
			for (int i = 0; i < context.Length("DescribeDataTotalCount.DataCount.Package.RiskCountList.Length"); i++) {
				DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Package.DescribeDataTotalCount_RiskCount4 riskCount4 = new DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Package.DescribeDataTotalCount_RiskCount4();
				riskCount4.Id = context.LongValue("DescribeDataTotalCount.DataCount.Package.RiskCountList["+ i +"].Id");
				riskCount4.Name = context.StringValue("DescribeDataTotalCount.DataCount.Package.RiskCountList["+ i +"].Name");
				riskCount4.Count = context.LongValue("DescribeDataTotalCount.DataCount.Package.RiskCountList["+ i +"].Count");

				package_riskCountList3.Add(riskCount4);
			}
			package.RiskCountList3 = package_riskCountList3;
			dataCount.Package = package;

			DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Column column = new DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Column();
			column.TotalCount = context.LongValue("DescribeDataTotalCount.DataCount.Column.TotalCount");
			column.Count = context.LongValue("DescribeDataTotalCount.DataCount.Column.Count");
			column.SensitiveCount = context.LongValue("DescribeDataTotalCount.DataCount.Column.SensitiveCount");
			column.LastCount = context.LongValue("DescribeDataTotalCount.DataCount.Column.LastCount");
			column.LastSensitiveCount = context.LongValue("DescribeDataTotalCount.DataCount.Column.LastSensitiveCount");

			List<DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Column.DescribeDataTotalCount_RiskCount6> column_riskCountList5 = new List<DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Column.DescribeDataTotalCount_RiskCount6>();
			for (int i = 0; i < context.Length("DescribeDataTotalCount.DataCount.Column.RiskCountList.Length"); i++) {
				DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Column.DescribeDataTotalCount_RiskCount6 riskCount6 = new DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Column.DescribeDataTotalCount_RiskCount6();
				riskCount6.Id = context.LongValue("DescribeDataTotalCount.DataCount.Column.RiskCountList["+ i +"].Id");
				riskCount6.Name = context.StringValue("DescribeDataTotalCount.DataCount.Column.RiskCountList["+ i +"].Name");
				riskCount6.Count = context.LongValue("DescribeDataTotalCount.DataCount.Column.RiskCountList["+ i +"].Count");

				column_riskCountList5.Add(riskCount6);
			}
			column.RiskCountList5 = column_riskCountList5;
			dataCount.Column = column;

			DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Oss oss = new DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Oss();
			oss.TotalCount = context.LongValue("DescribeDataTotalCount.DataCount.Oss.TotalCount");
			oss.Count = context.LongValue("DescribeDataTotalCount.DataCount.Oss.Count");
			oss.SensitiveCount = context.LongValue("DescribeDataTotalCount.DataCount.Oss.SensitiveCount");
			oss.LastCount = context.LongValue("DescribeDataTotalCount.DataCount.Oss.LastCount");
			oss.LastSensitiveCount = context.LongValue("DescribeDataTotalCount.DataCount.Oss.LastSensitiveCount");

			List<DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Oss.DescribeDataTotalCount_RiskCount8> oss_riskCountList7 = new List<DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Oss.DescribeDataTotalCount_RiskCount8>();
			for (int i = 0; i < context.Length("DescribeDataTotalCount.DataCount.Oss.RiskCountList.Length"); i++) {
				DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Oss.DescribeDataTotalCount_RiskCount8 riskCount8 = new DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Oss.DescribeDataTotalCount_RiskCount8();
				riskCount8.Id = context.LongValue("DescribeDataTotalCount.DataCount.Oss.RiskCountList["+ i +"].Id");
				riskCount8.Name = context.StringValue("DescribeDataTotalCount.DataCount.Oss.RiskCountList["+ i +"].Name");
				riskCount8.Count = context.LongValue("DescribeDataTotalCount.DataCount.Oss.RiskCountList["+ i +"].Count");

				oss_riskCountList7.Add(riskCount8);
			}
			oss.RiskCountList7 = oss_riskCountList7;
			dataCount.Oss = oss;
			describeDataTotalCountResponse.DataCount = dataCount;
        
			return describeDataTotalCountResponse;
        }
    }
}
