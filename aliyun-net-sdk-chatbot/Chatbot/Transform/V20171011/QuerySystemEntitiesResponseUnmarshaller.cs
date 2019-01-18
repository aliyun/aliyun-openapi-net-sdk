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
    public class QuerySystemEntitiesResponseUnmarshaller
    {
        public static QuerySystemEntitiesResponse Unmarshall(UnmarshallerContext context)
        {
			QuerySystemEntitiesResponse querySystemEntitiesResponse = new QuerySystemEntitiesResponse();

			querySystemEntitiesResponse.HttpResponse = context.HttpResponse;
			querySystemEntitiesResponse.RequestId = context.StringValue("QuerySystemEntities.RequestId");

			List<QuerySystemEntitiesResponse.QuerySystemEntities_Entity> querySystemEntitiesResponse_systemEntities = new List<QuerySystemEntitiesResponse.QuerySystemEntities_Entity>();
			for (int i = 0; i < context.Length("QuerySystemEntities.SystemEntities.Length"); i++) {
				QuerySystemEntitiesResponse.QuerySystemEntities_Entity entity = new QuerySystemEntitiesResponse.QuerySystemEntities_Entity();
				entity.DefaultQuestion = context.StringValue("QuerySystemEntities.SystemEntities["+ i +"].DefaultQuestion");
				entity.EntityName = context.StringValue("QuerySystemEntities.SystemEntities["+ i +"].EntityName");
				entity.EntityCode = context.StringValue("QuerySystemEntities.SystemEntities["+ i +"].EntityCode");

				querySystemEntitiesResponse_systemEntities.Add(entity);
			}
			querySystemEntitiesResponse.SystemEntities = querySystemEntitiesResponse_systemEntities;
        
			return querySystemEntitiesResponse;
        }
    }
}