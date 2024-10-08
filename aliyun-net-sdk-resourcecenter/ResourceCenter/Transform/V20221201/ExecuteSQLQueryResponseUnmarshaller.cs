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
    public class ExecuteSQLQueryResponseUnmarshaller
    {
        public static ExecuteSQLQueryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ExecuteSQLQueryResponse executeSQLQueryResponse = new ExecuteSQLQueryResponse();

			executeSQLQueryResponse.HttpResponse = _ctx.HttpResponse;
			executeSQLQueryResponse.MaxResults = _ctx.IntegerValue("ExecuteSQLQuery.MaxResults");
			executeSQLQueryResponse.NextToken = _ctx.StringValue("ExecuteSQLQuery.NextToken");
			executeSQLQueryResponse.RequestId = _ctx.StringValue("ExecuteSQLQuery.RequestId");

			List<string> executeSQLQueryResponse_rows = new List<string>();
			for (int i = 0; i < _ctx.Length("ExecuteSQLQuery.Rows.Length"); i++) {
				executeSQLQueryResponse_rows.Add(_ctx.StringValue("ExecuteSQLQuery.Rows["+ i +"]"));
			}
			executeSQLQueryResponse.Rows = executeSQLQueryResponse_rows;

			List<ExecuteSQLQueryResponse.ExecuteSQLQuery_Column> executeSQLQueryResponse_columns = new List<ExecuteSQLQueryResponse.ExecuteSQLQuery_Column>();
			for (int i = 0; i < _ctx.Length("ExecuteSQLQuery.Columns.Length"); i++) {
				ExecuteSQLQueryResponse.ExecuteSQLQuery_Column column = new ExecuteSQLQueryResponse.ExecuteSQLQuery_Column();
				column.Name = _ctx.StringValue("ExecuteSQLQuery.Columns["+ i +"].Name");
				column.Type = _ctx.StringValue("ExecuteSQLQuery.Columns["+ i +"].Type");

				executeSQLQueryResponse_columns.Add(column);
			}
			executeSQLQueryResponse.Columns = executeSQLQueryResponse_columns;
        
			return executeSQLQueryResponse;
        }
    }
}
