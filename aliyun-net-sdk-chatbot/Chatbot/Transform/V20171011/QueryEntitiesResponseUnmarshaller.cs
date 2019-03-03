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
    public class QueryEntitiesResponseUnmarshaller
    {
        public static QueryEntitiesResponse Unmarshall(UnmarshallerContext context)
        {
			QueryEntitiesResponse queryEntitiesResponse = new QueryEntitiesResponse();

			queryEntitiesResponse.HttpResponse = context.HttpResponse;
			queryEntitiesResponse.RequestId = context.StringValue("QueryEntities.RequestId");
			queryEntitiesResponse.PageNumber = context.IntegerValue("QueryEntities.PageNumber");
			queryEntitiesResponse.PageSize = context.IntegerValue("QueryEntities.PageSize");
			queryEntitiesResponse.TotalCount = context.IntegerValue("QueryEntities.TotalCount");

			List<QueryEntitiesResponse.QueryEntities_Entity> queryEntitiesResponse_entities = new List<QueryEntitiesResponse.QueryEntities_Entity>();
			for (int i = 0; i < context.Length("QueryEntities.Entities.Length"); i++) {
				QueryEntitiesResponse.QueryEntities_Entity entity = new QueryEntitiesResponse.QueryEntities_Entity();
				entity.EntityId = context.LongValue("QueryEntities.Entities["+ i +"].EntityId");
				entity.EntityName = context.StringValue("QueryEntities.Entities["+ i +"].EntityName");
				entity.EntityType = context.StringValue("QueryEntities.Entities["+ i +"].EntityType");
				entity.Regex = context.StringValue("QueryEntities.Entities["+ i +"].Regex");
				entity.CreateTime = context.StringValue("QueryEntities.Entities["+ i +"].CreateTime");
				entity.ModifyTime = context.StringValue("QueryEntities.Entities["+ i +"].ModifyTime");
				entity.CreateUserId = context.StringValue("QueryEntities.Entities["+ i +"].CreateUserId");
				entity.CreateUserName = context.StringValue("QueryEntities.Entities["+ i +"].CreateUserName");
				entity.ModifyUserId = context.StringValue("QueryEntities.Entities["+ i +"].ModifyUserId");
				entity.ModifyUserName = context.StringValue("QueryEntities.Entities["+ i +"].ModifyUserName");

				List<QueryEntitiesResponse.QueryEntities_Entity.QueryEntities_MembersItem> entity_members = new List<QueryEntitiesResponse.QueryEntities_Entity.QueryEntities_MembersItem>();
				for (int j = 0; j < context.Length("QueryEntities.Entities["+ i +"].Members.Length"); j++) {
					QueryEntitiesResponse.QueryEntities_Entity.QueryEntities_MembersItem membersItem = new QueryEntitiesResponse.QueryEntities_Entity.QueryEntities_MembersItem();
					membersItem.MemberName = context.StringValue("QueryEntities.Entities["+ i +"].Members["+ j +"].MemberName");

					List<string> membersItem_synonyms = new List<string>();
					for (int k = 0; k < context.Length("QueryEntities.Entities["+ i +"].Members["+ j +"].Synonyms.Length"); k++) {
						membersItem_synonyms.Add(context.StringValue("QueryEntities.Entities["+ i +"].Members["+ j +"].Synonyms["+ k +"]"));
					}
					membersItem.Synonyms = membersItem_synonyms;

					entity_members.Add(membersItem);
				}
				entity.Members = entity_members;

				queryEntitiesResponse_entities.Add(entity);
			}
			queryEntitiesResponse.Entities = queryEntitiesResponse_entities;
        
			return queryEntitiesResponse;
        }
    }
}