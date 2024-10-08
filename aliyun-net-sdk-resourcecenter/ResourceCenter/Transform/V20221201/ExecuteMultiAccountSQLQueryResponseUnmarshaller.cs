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
using Aliyun.Acs.ResourceCenter.Model.V20221201;

namespace Aliyun.Acs.ResourceCenter.Transform.V20221201
{
    public class ExecuteMultiAccountSQLQueryResponseUnmarshaller
    {
        public static ExecuteMultiAccountSQLQueryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ExecuteMultiAccountSQLQueryResponse executeMultiAccountSQLQueryResponse = new ExecuteMultiAccountSQLQueryResponse();

			executeMultiAccountSQLQueryResponse.HttpResponse = _ctx.HttpResponse;
			executeMultiAccountSQLQueryResponse.MaxResults = _ctx.IntegerValue("ExecuteMultiAccountSQLQuery.MaxResults");
			executeMultiAccountSQLQueryResponse.NextToken = _ctx.StringValue("ExecuteMultiAccountSQLQuery.NextToken");
			executeMultiAccountSQLQueryResponse.RequestId = _ctx.StringValue("ExecuteMultiAccountSQLQuery.RequestId");

			List<string> executeMultiAccountSQLQueryResponse_rows = new List<string>();
			for (int i = 0; i < _ctx.Length("ExecuteMultiAccountSQLQuery.Rows.Length"); i++) {
				executeMultiAccountSQLQueryResponse_rows.Add(_ctx.StringValue("ExecuteMultiAccountSQLQuery.Rows["+ i +"]"));
			}
			executeMultiAccountSQLQueryResponse.Rows = executeMultiAccountSQLQueryResponse_rows;

			List<ExecuteMultiAccountSQLQueryResponse.ExecuteMultiAccountSQLQuery_Column> executeMultiAccountSQLQueryResponse_columns = new List<ExecuteMultiAccountSQLQueryResponse.ExecuteMultiAccountSQLQuery_Column>();
			for (int i = 0; i < _ctx.Length("ExecuteMultiAccountSQLQuery.Columns.Length"); i++) {
				ExecuteMultiAccountSQLQueryResponse.ExecuteMultiAccountSQLQuery_Column column = new ExecuteMultiAccountSQLQueryResponse.ExecuteMultiAccountSQLQuery_Column();
				column.Name = _ctx.StringValue("ExecuteMultiAccountSQLQuery.Columns["+ i +"].Name");
				column.Type = _ctx.StringValue("ExecuteMultiAccountSQLQuery.Columns["+ i +"].Type");

				executeMultiAccountSQLQueryResponse_columns.Add(column);
			}
			executeMultiAccountSQLQueryResponse.Columns = executeMultiAccountSQLQueryResponse_columns;
        
			return executeMultiAccountSQLQueryResponse;
        }
    }
}
