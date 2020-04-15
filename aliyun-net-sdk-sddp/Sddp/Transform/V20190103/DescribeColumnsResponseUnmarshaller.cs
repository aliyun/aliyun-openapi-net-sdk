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
    public class DescribeColumnsResponseUnmarshaller
    {
        public static DescribeColumnsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeColumnsResponse describeColumnsResponse = new DescribeColumnsResponse();

			describeColumnsResponse.HttpResponse = context.HttpResponse;
			describeColumnsResponse.RequestId = context.StringValue("DescribeColumns.RequestId");
			describeColumnsResponse.PageSize = context.IntegerValue("DescribeColumns.PageSize");
			describeColumnsResponse.CurrentPage = context.IntegerValue("DescribeColumns.CurrentPage");
			describeColumnsResponse.TotalCount = context.IntegerValue("DescribeColumns.TotalCount");

			List<DescribeColumnsResponse.DescribeColumns_Column> describeColumnsResponse_items = new List<DescribeColumnsResponse.DescribeColumns_Column>();
			for (int i = 0; i < context.Length("DescribeColumns.Items.Length"); i++) {
				DescribeColumnsResponse.DescribeColumns_Column column = new DescribeColumnsResponse.DescribeColumns_Column();
				column.Id = context.StringValue("DescribeColumns.Items["+ i +"].Id");
				column.Name = context.StringValue("DescribeColumns.Items["+ i +"].Name");
				column.InstanceId = context.LongValue("DescribeColumns.Items["+ i +"].InstanceId");
				column.TableId = context.LongValue("DescribeColumns.Items["+ i +"].TableId");
				column.CreationTime = context.LongValue("DescribeColumns.Items["+ i +"].CreationTime");
				column.Sensitive = context.BooleanValue("DescribeColumns.Items["+ i +"].Sensitive");
				column.ProductCode = context.StringValue("DescribeColumns.Items["+ i +"].ProductCode");
				column.DataType = context.StringValue("DescribeColumns.Items["+ i +"].DataType");
				column.OdpsRiskLevelValue = context.IntegerValue("DescribeColumns.Items["+ i +"].OdpsRiskLevelValue");
				column.OdpsRiskLevelName = context.StringValue("DescribeColumns.Items["+ i +"].OdpsRiskLevelName");
				column.RiskLevelId = context.LongValue("DescribeColumns.Items["+ i +"].RiskLevelId");
				column.RiskLevelName = context.StringValue("DescribeColumns.Items["+ i +"].RiskLevelName");
				column.RuleId = context.LongValue("DescribeColumns.Items["+ i +"].RuleId");
				column.RuleName = context.StringValue("DescribeColumns.Items["+ i +"].RuleName");
				column.DepartName = context.StringValue("DescribeColumns.Items["+ i +"].DepartName");

				describeColumnsResponse_items.Add(column);
			}
			describeColumnsResponse.Items = describeColumnsResponse_items;
        
			return describeColumnsResponse;
        }
    }
}
