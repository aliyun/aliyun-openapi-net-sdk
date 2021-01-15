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
using Aliyun.Acs.OpenSearch.Model.V20171225;

namespace Aliyun.Acs.OpenSearch.Transform.V20171225
{
    public class ListSlowQueryQueriesResponseUnmarshaller
    {
        public static ListSlowQueryQueriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSlowQueryQueriesResponse listSlowQueryQueriesResponse = new ListSlowQueryQueriesResponse();

			listSlowQueryQueriesResponse.HttpResponse = _ctx.HttpResponse;
			listSlowQueryQueriesResponse.RequestId = _ctx.StringValue("ListSlowQueryQueries.requestId");

			ListSlowQueryQueriesResponse.ListSlowQueryQueries_Result result = new ListSlowQueryQueriesResponse.ListSlowQueryQueries_Result();
			result.Start = _ctx.IntegerValue("ListSlowQueryQueries.Result.start");
			result.End = _ctx.IntegerValue("ListSlowQueryQueries.Result.end");
			result.Index = _ctx.IntegerValue("ListSlowQueryQueries.Result.index");
			result.AppQuery = _ctx.StringValue("ListSlowQueryQueries.Result.appQuery");
			listSlowQueryQueriesResponse.Result = result;
        
			return listSlowQueryQueriesResponse;
        }
    }
}
