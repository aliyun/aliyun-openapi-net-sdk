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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeDataTotalCountResponseUnmarshaller
    {
        public static DescribeDataTotalCountResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDataTotalCountResponse describeDataTotalCountResponse = new DescribeDataTotalCountResponse();

			describeDataTotalCountResponse.HttpResponse = _ctx.HttpResponse;
			describeDataTotalCountResponse.RequestId = _ctx.StringValue("DescribeDataTotalCount.RequestId");

			DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount dataCount = new DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount();

			DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Instance instance = new DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Instance();
			instance.TotalCount = _ctx.LongValue("DescribeDataTotalCount.DataCount.Instance.TotalCount");
			instance.Count = _ctx.LongValue("DescribeDataTotalCount.DataCount.Instance.Count");
			instance.SensitiveCount = _ctx.LongValue("DescribeDataTotalCount.DataCount.Instance.SensitiveCount");
			instance.LastCount = _ctx.LongValue("DescribeDataTotalCount.DataCount.Instance.LastCount");
			instance.LastSensitiveCount = _ctx.LongValue("DescribeDataTotalCount.DataCount.Instance.LastSensitiveCount");

			List<DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Instance.DescribeDataTotalCount_RiskCount> instance_riskCountList = new List<DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Instance.DescribeDataTotalCount_RiskCount>();
			for (int i = 0; i < _ctx.Length("DescribeDataTotalCount.DataCount.Instance.RiskCountList.Length"); i++) {
				DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Instance.DescribeDataTotalCount_RiskCount riskCount = new DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Instance.DescribeDataTotalCount_RiskCount();
				riskCount.Id = _ctx.LongValue("DescribeDataTotalCount.DataCount.Instance.RiskCountList["+ i +"].Id");
				riskCount.Name = _ctx.StringValue("DescribeDataTotalCount.DataCount.Instance.RiskCountList["+ i +"].Name");
				riskCount.Count = _ctx.LongValue("DescribeDataTotalCount.DataCount.Instance.RiskCountList["+ i +"].Count");

				instance_riskCountList.Add(riskCount);
			}
			instance.RiskCountList = instance_riskCountList;
			dataCount.Instance = instance;

			DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Table table = new DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Table();
			table.TotalCount = _ctx.LongValue("DescribeDataTotalCount.DataCount.Table.TotalCount");
			table.Count = _ctx.LongValue("DescribeDataTotalCount.DataCount.Table.Count");
			table.SensitiveCount = _ctx.LongValue("DescribeDataTotalCount.DataCount.Table.SensitiveCount");
			table.LastCount = _ctx.LongValue("DescribeDataTotalCount.DataCount.Table.LastCount");
			table.LastSensitiveCount = _ctx.LongValue("DescribeDataTotalCount.DataCount.Table.LastSensitiveCount");

			List<DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Table.DescribeDataTotalCount_RiskCount2> table_riskCountList1 = new List<DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Table.DescribeDataTotalCount_RiskCount2>();
			for (int i = 0; i < _ctx.Length("DescribeDataTotalCount.DataCount.Table.RiskCountList.Length"); i++) {
				DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Table.DescribeDataTotalCount_RiskCount2 riskCount2 = new DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Table.DescribeDataTotalCount_RiskCount2();
				riskCount2.Id = _ctx.LongValue("DescribeDataTotalCount.DataCount.Table.RiskCountList["+ i +"].Id");
				riskCount2.Name = _ctx.StringValue("DescribeDataTotalCount.DataCount.Table.RiskCountList["+ i +"].Name");
				riskCount2.Count = _ctx.LongValue("DescribeDataTotalCount.DataCount.Table.RiskCountList["+ i +"].Count");

				table_riskCountList1.Add(riskCount2);
			}
			table.RiskCountList1 = table_riskCountList1;
			dataCount.Table = table;

			DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Package package = new DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Package();
			package.TotalCount = _ctx.LongValue("DescribeDataTotalCount.DataCount.Package.TotalCount");
			package.Count = _ctx.LongValue("DescribeDataTotalCount.DataCount.Package.Count");
			package.SensitiveCount = _ctx.LongValue("DescribeDataTotalCount.DataCount.Package.SensitiveCount");
			package.LastCount = _ctx.LongValue("DescribeDataTotalCount.DataCount.Package.LastCount");
			package.LastSensitiveCount = _ctx.LongValue("DescribeDataTotalCount.DataCount.Package.LastSensitiveCount");

			List<DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Package.DescribeDataTotalCount_RiskCount4> package_riskCountList3 = new List<DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Package.DescribeDataTotalCount_RiskCount4>();
			for (int i = 0; i < _ctx.Length("DescribeDataTotalCount.DataCount.Package.RiskCountList.Length"); i++) {
				DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Package.DescribeDataTotalCount_RiskCount4 riskCount4 = new DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Package.DescribeDataTotalCount_RiskCount4();
				riskCount4.Id = _ctx.LongValue("DescribeDataTotalCount.DataCount.Package.RiskCountList["+ i +"].Id");
				riskCount4.Name = _ctx.StringValue("DescribeDataTotalCount.DataCount.Package.RiskCountList["+ i +"].Name");
				riskCount4.Count = _ctx.LongValue("DescribeDataTotalCount.DataCount.Package.RiskCountList["+ i +"].Count");

				package_riskCountList3.Add(riskCount4);
			}
			package.RiskCountList3 = package_riskCountList3;
			dataCount.Package = package;

			DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Column column = new DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Column();
			column.TotalCount = _ctx.LongValue("DescribeDataTotalCount.DataCount.Column.TotalCount");
			column.Count = _ctx.LongValue("DescribeDataTotalCount.DataCount.Column.Count");
			column.SensitiveCount = _ctx.LongValue("DescribeDataTotalCount.DataCount.Column.SensitiveCount");
			column.LastCount = _ctx.LongValue("DescribeDataTotalCount.DataCount.Column.LastCount");
			column.LastSensitiveCount = _ctx.LongValue("DescribeDataTotalCount.DataCount.Column.LastSensitiveCount");

			List<DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Column.DescribeDataTotalCount_RiskCount6> column_riskCountList5 = new List<DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Column.DescribeDataTotalCount_RiskCount6>();
			for (int i = 0; i < _ctx.Length("DescribeDataTotalCount.DataCount.Column.RiskCountList.Length"); i++) {
				DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Column.DescribeDataTotalCount_RiskCount6 riskCount6 = new DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Column.DescribeDataTotalCount_RiskCount6();
				riskCount6.Id = _ctx.LongValue("DescribeDataTotalCount.DataCount.Column.RiskCountList["+ i +"].Id");
				riskCount6.Name = _ctx.StringValue("DescribeDataTotalCount.DataCount.Column.RiskCountList["+ i +"].Name");
				riskCount6.Count = _ctx.LongValue("DescribeDataTotalCount.DataCount.Column.RiskCountList["+ i +"].Count");

				column_riskCountList5.Add(riskCount6);
			}
			column.RiskCountList5 = column_riskCountList5;

			List<DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Column.DescribeDataTotalCount_ColumnCount> column_columnRuleTop = new List<DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Column.DescribeDataTotalCount_ColumnCount>();
			for (int i = 0; i < _ctx.Length("DescribeDataTotalCount.DataCount.Column.ColumnRuleTop.Length"); i++) {
				DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Column.DescribeDataTotalCount_ColumnCount columnCount = new DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Column.DescribeDataTotalCount_ColumnCount();
				columnCount.Id = _ctx.LongValue("DescribeDataTotalCount.DataCount.Column.ColumnRuleTop["+ i +"].Id");
				columnCount.Name = _ctx.StringValue("DescribeDataTotalCount.DataCount.Column.ColumnRuleTop["+ i +"].Name");
				columnCount.Count = _ctx.LongValue("DescribeDataTotalCount.DataCount.Column.ColumnRuleTop["+ i +"].Count");

				column_columnRuleTop.Add(columnCount);
			}
			column.ColumnRuleTop = column_columnRuleTop;
			dataCount.Column = column;

			DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Oss oss = new DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Oss();
			oss.TotalCount = _ctx.LongValue("DescribeDataTotalCount.DataCount.Oss.TotalCount");
			oss.Count = _ctx.LongValue("DescribeDataTotalCount.DataCount.Oss.Count");
			oss.SensitiveCount = _ctx.LongValue("DescribeDataTotalCount.DataCount.Oss.SensitiveCount");
			oss.LastCount = _ctx.LongValue("DescribeDataTotalCount.DataCount.Oss.LastCount");
			oss.LastSensitiveCount = _ctx.LongValue("DescribeDataTotalCount.DataCount.Oss.LastSensitiveCount");

			List<DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Oss.DescribeDataTotalCount_RiskCount8> oss_riskCountList7 = new List<DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Oss.DescribeDataTotalCount_RiskCount8>();
			for (int i = 0; i < _ctx.Length("DescribeDataTotalCount.DataCount.Oss.RiskCountList.Length"); i++) {
				DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Oss.DescribeDataTotalCount_RiskCount8 riskCount8 = new DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Oss.DescribeDataTotalCount_RiskCount8();
				riskCount8.Id = _ctx.LongValue("DescribeDataTotalCount.DataCount.Oss.RiskCountList["+ i +"].Id");
				riskCount8.Name = _ctx.StringValue("DescribeDataTotalCount.DataCount.Oss.RiskCountList["+ i +"].Name");
				riskCount8.Count = _ctx.LongValue("DescribeDataTotalCount.DataCount.Oss.RiskCountList["+ i +"].Count");

				oss_riskCountList7.Add(riskCount8);
			}
			oss.RiskCountList7 = oss_riskCountList7;

			List<DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Oss.DescribeDataTotalCount_OssCount> oss_ossRuleTop = new List<DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Oss.DescribeDataTotalCount_OssCount>();
			for (int i = 0; i < _ctx.Length("DescribeDataTotalCount.DataCount.Oss.OssRuleTop.Length"); i++) {
				DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Oss.DescribeDataTotalCount_OssCount ossCount = new DescribeDataTotalCountResponse.DescribeDataTotalCount_DataCount.DescribeDataTotalCount_Oss.DescribeDataTotalCount_OssCount();
				ossCount.Id = _ctx.LongValue("DescribeDataTotalCount.DataCount.Oss.OssRuleTop["+ i +"].Id");
				ossCount.Name = _ctx.StringValue("DescribeDataTotalCount.DataCount.Oss.OssRuleTop["+ i +"].Name");
				ossCount.Count = _ctx.LongValue("DescribeDataTotalCount.DataCount.Oss.OssRuleTop["+ i +"].Count");

				oss_ossRuleTop.Add(ossCount);
			}
			oss.OssRuleTop = oss_ossRuleTop;
			dataCount.Oss = oss;
			describeDataTotalCountResponse.DataCount = dataCount;
        
			return describeDataTotalCountResponse;
        }
    }
}
