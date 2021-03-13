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
    public class DescribeColumnsResponseUnmarshaller
    {
        public static DescribeColumnsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeColumnsResponse describeColumnsResponse = new DescribeColumnsResponse();

			describeColumnsResponse.HttpResponse = _ctx.HttpResponse;
			describeColumnsResponse.RequestId = _ctx.StringValue("DescribeColumns.RequestId");

			List<DescribeColumnsResponse.DescribeColumns_Column> describeColumnsResponse_items = new List<DescribeColumnsResponse.DescribeColumns_Column>();
			for (int i = 0; i < _ctx.Length("DescribeColumns.Items.Length"); i++) {
				DescribeColumnsResponse.DescribeColumns_Column column = new DescribeColumnsResponse.DescribeColumns_Column();
				column.DBClusterId = _ctx.StringValue("DescribeColumns.Items["+ i +"].DBClusterId");
				column.SchemaName = _ctx.StringValue("DescribeColumns.Items["+ i +"].SchemaName");
				column.TableName = _ctx.StringValue("DescribeColumns.Items["+ i +"].TableName");
				column.ColumnName = _ctx.StringValue("DescribeColumns.Items["+ i +"].ColumnName");
				column.Type = _ctx.StringValue("DescribeColumns.Items["+ i +"].Type");
				column.PrimaryKey = _ctx.BooleanValue("DescribeColumns.Items["+ i +"].PrimaryKey");
				column.AutoIncrementColumn = _ctx.BooleanValue("DescribeColumns.Items["+ i +"].AutoIncrementColumn");

				describeColumnsResponse_items.Add(column);
			}
			describeColumnsResponse.Items = describeColumnsResponse_items;
        
			return describeColumnsResponse;
        }
    }
}
