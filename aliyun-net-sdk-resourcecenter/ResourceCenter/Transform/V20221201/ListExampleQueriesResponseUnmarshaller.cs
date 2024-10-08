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
    public class ListExampleQueriesResponseUnmarshaller
    {
        public static ListExampleQueriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListExampleQueriesResponse listExampleQueriesResponse = new ListExampleQueriesResponse();

			listExampleQueriesResponse.HttpResponse = _ctx.HttpResponse;
			listExampleQueriesResponse.RequestId = _ctx.StringValue("ListExampleQueries.RequestId");
			listExampleQueriesResponse.MaxResults = _ctx.StringValue("ListExampleQueries.MaxResults");
			listExampleQueriesResponse.NextToken = _ctx.StringValue("ListExampleQueries.NextToken");

			List<ListExampleQueriesResponse.ListExampleQueries_ExampleQuery> listExampleQueriesResponse_exampleQueries = new List<ListExampleQueriesResponse.ListExampleQueries_ExampleQuery>();
			for (int i = 0; i < _ctx.Length("ListExampleQueries.ExampleQueries.Length"); i++) {
				ListExampleQueriesResponse.ListExampleQueries_ExampleQuery exampleQuery = new ListExampleQueriesResponse.ListExampleQueries_ExampleQuery();
				exampleQuery.QueryId = _ctx.StringValue("ListExampleQueries.ExampleQueries["+ i +"].QueryId");
				exampleQuery.Name = _ctx.StringValue("ListExampleQueries.ExampleQueries["+ i +"].Name");
				exampleQuery.Description = _ctx.StringValue("ListExampleQueries.ExampleQueries["+ i +"].Description");

				listExampleQueriesResponse_exampleQueries.Add(exampleQuery);
			}
			listExampleQueriesResponse.ExampleQueries = listExampleQueriesResponse_exampleQueries;
        
			return listExampleQueriesResponse;
        }
    }
}
