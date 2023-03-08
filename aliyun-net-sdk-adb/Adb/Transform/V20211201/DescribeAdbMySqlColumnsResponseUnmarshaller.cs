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
using Aliyun.Acs.adb.Model.V20211201;

namespace Aliyun.Acs.adb.Transform.V20211201
{
    public class DescribeAdbMySqlColumnsResponseUnmarshaller
    {
        public static DescribeAdbMySqlColumnsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAdbMySqlColumnsResponse describeAdbMySqlColumnsResponse = new DescribeAdbMySqlColumnsResponse();

			describeAdbMySqlColumnsResponse.HttpResponse = _ctx.HttpResponse;
			describeAdbMySqlColumnsResponse.Message = _ctx.StringValue("DescribeAdbMySqlColumns.Message");
			describeAdbMySqlColumnsResponse.RequestId = _ctx.StringValue("DescribeAdbMySqlColumns.RequestId");
			describeAdbMySqlColumnsResponse.Success = _ctx.BooleanValue("DescribeAdbMySqlColumns.Success");
			describeAdbMySqlColumnsResponse.Schema = _ctx.StringValue("DescribeAdbMySqlColumns.Schema");
			describeAdbMySqlColumnsResponse.TableName = _ctx.StringValue("DescribeAdbMySqlColumns.TableName");
			describeAdbMySqlColumnsResponse.ColumnCount = _ctx.IntegerValue("DescribeAdbMySqlColumns.ColumnCount");

			List<DescribeAdbMySqlColumnsResponse.DescribeAdbMySqlColumns_Column> describeAdbMySqlColumnsResponse_columns = new List<DescribeAdbMySqlColumnsResponse.DescribeAdbMySqlColumns_Column>();
			for (int i = 0; i < _ctx.Length("DescribeAdbMySqlColumns.Columns.Length"); i++) {
				DescribeAdbMySqlColumnsResponse.DescribeAdbMySqlColumns_Column column = new DescribeAdbMySqlColumnsResponse.DescribeAdbMySqlColumns_Column();
				column.Type = _ctx.StringValue("DescribeAdbMySqlColumns.Columns["+ i +"].Type");
				column.Name = _ctx.StringValue("DescribeAdbMySqlColumns.Columns["+ i +"].Name");
				column.Comment = _ctx.StringValue("DescribeAdbMySqlColumns.Columns["+ i +"].Comment");

				describeAdbMySqlColumnsResponse_columns.Add(column);
			}
			describeAdbMySqlColumnsResponse.Columns = describeAdbMySqlColumnsResponse_columns;
        
			return describeAdbMySqlColumnsResponse;
        }
    }
}
