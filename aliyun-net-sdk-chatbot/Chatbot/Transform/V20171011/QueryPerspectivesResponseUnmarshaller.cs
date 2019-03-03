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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Chatbot.Model.V20171011;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Chatbot.Transform.V20171011
{
    public class QueryPerspectivesResponseUnmarshaller
    {
        public static QueryPerspectivesResponse Unmarshall(UnmarshallerContext context)
        {
			QueryPerspectivesResponse queryPerspectivesResponse = new QueryPerspectivesResponse();

			queryPerspectivesResponse.HttpResponse = context.HttpResponse;
			queryPerspectivesResponse.RequestId = context.StringValue("QueryPerspectives.RequestId");

			List<QueryPerspectivesResponse.QueryPerspectives_Perspective> queryPerspectivesResponse_perspectives = new List<QueryPerspectivesResponse.QueryPerspectives_Perspective>();
			for (int i = 0; i < context.Length("QueryPerspectives.Perspectives.Length"); i++) {
				QueryPerspectivesResponse.QueryPerspectives_Perspective perspective = new QueryPerspectivesResponse.QueryPerspectives_Perspective();
				perspective.ModifyUserName = context.StringValue("QueryPerspectives.Perspectives["+ i +"].ModifyUserName");
				perspective.ModifyTime = context.StringValue("QueryPerspectives.Perspectives["+ i +"].ModifyTime");
				perspective.CreateTime = context.StringValue("QueryPerspectives.Perspectives["+ i +"].CreateTime");
				perspective.SelfDefine = context.StringValue("QueryPerspectives.Perspectives["+ i +"].SelfDefine");
				perspective.PerspectiveId = context.StringValue("QueryPerspectives.Perspectives["+ i +"].PerspectiveId");
				perspective.CreateUserName = context.StringValue("QueryPerspectives.Perspectives["+ i +"].CreateUserName");
				perspective.PerspectiveCode = context.StringValue("QueryPerspectives.Perspectives["+ i +"].PerspectiveCode");
				perspective.Status = context.IntegerValue("QueryPerspectives.Perspectives["+ i +"].Status");
				perspective.Name = context.StringValue("QueryPerspectives.Perspectives["+ i +"].Name");

				queryPerspectivesResponse_perspectives.Add(perspective);
			}
			queryPerspectivesResponse.Perspectives = queryPerspectivesResponse_perspectives;
        
			return queryPerspectivesResponse;
        }
    }
}