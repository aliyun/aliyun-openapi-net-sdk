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
    public class ListSavedQueriesResponseUnmarshaller
    {
        public static ListSavedQueriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSavedQueriesResponse listSavedQueriesResponse = new ListSavedQueriesResponse();

			listSavedQueriesResponse.HttpResponse = _ctx.HttpResponse;
			listSavedQueriesResponse.RequestId = _ctx.StringValue("ListSavedQueries.RequestId");
			listSavedQueriesResponse.MaxResults = _ctx.StringValue("ListSavedQueries.MaxResults");
			listSavedQueriesResponse.NextToken = _ctx.StringValue("ListSavedQueries.NextToken");

			List<ListSavedQueriesResponse.ListSavedQueries_SavedQuery> listSavedQueriesResponse_savedQueries = new List<ListSavedQueriesResponse.ListSavedQueries_SavedQuery>();
			for (int i = 0; i < _ctx.Length("ListSavedQueries.SavedQueries.Length"); i++) {
				ListSavedQueriesResponse.ListSavedQueries_SavedQuery savedQuery = new ListSavedQueriesResponse.ListSavedQueries_SavedQuery();
				savedQuery.QueryId = _ctx.StringValue("ListSavedQueries.SavedQueries["+ i +"].QueryId");
				savedQuery.Name = _ctx.StringValue("ListSavedQueries.SavedQueries["+ i +"].Name");
				savedQuery.Description = _ctx.StringValue("ListSavedQueries.SavedQueries["+ i +"].Description");
				savedQuery.CreateTime = _ctx.StringValue("ListSavedQueries.SavedQueries["+ i +"].CreateTime");
				savedQuery.UpdateTime = _ctx.StringValue("ListSavedQueries.SavedQueries["+ i +"].UpdateTime");

				listSavedQueriesResponse_savedQueries.Add(savedQuery);
			}
			listSavedQueriesResponse.SavedQueries = listSavedQueriesResponse_savedQueries;
        
			return listSavedQueriesResponse;
        }
    }
}
