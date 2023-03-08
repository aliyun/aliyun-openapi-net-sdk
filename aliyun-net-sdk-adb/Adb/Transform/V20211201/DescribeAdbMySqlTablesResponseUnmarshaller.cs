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
    public class DescribeAdbMySqlTablesResponseUnmarshaller
    {
        public static DescribeAdbMySqlTablesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAdbMySqlTablesResponse describeAdbMySqlTablesResponse = new DescribeAdbMySqlTablesResponse();

			describeAdbMySqlTablesResponse.HttpResponse = _ctx.HttpResponse;
			describeAdbMySqlTablesResponse.Message = _ctx.StringValue("DescribeAdbMySqlTables.Message");
			describeAdbMySqlTablesResponse.RequestId = _ctx.StringValue("DescribeAdbMySqlTables.RequestId");
			describeAdbMySqlTablesResponse.Success = _ctx.BooleanValue("DescribeAdbMySqlTables.Success");
			describeAdbMySqlTablesResponse.Schema = _ctx.StringValue("DescribeAdbMySqlTables.Schema");

			List<string> describeAdbMySqlTablesResponse_tables = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeAdbMySqlTables.Tables.Length"); i++) {
				describeAdbMySqlTablesResponse_tables.Add(_ctx.StringValue("DescribeAdbMySqlTables.Tables["+ i +"]"));
			}
			describeAdbMySqlTablesResponse.Tables = describeAdbMySqlTablesResponse_tables;
        
			return describeAdbMySqlTablesResponse;
        }
    }
}
