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
            QueryEntitiesResponse queryEntitiesResponse = new QueryEntitiesResponse
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("QueryEntities.RequestId"),
                PageNumber = context.IntegerValue("QueryEntities.PageNumber"),
                PageSize = context.IntegerValue("QueryEntities.PageSize"),
                TotalCount = context.IntegerValue("QueryEntities.TotalCount")
            };

            List<QueryEntitiesResponse.QueryEntities_Entity> queryEntitiesResponse_entities = new List<QueryEntitiesResponse.QueryEntities_Entity>();
			for (int i = 0; i < context.Length("QueryEntities.Entities.Length"); i++) {
                QueryEntitiesResponse.QueryEntities_Entity entity = new QueryEntitiesResponse.QueryEntities_Entity
                {
                    EntityId = context.LongValue("QueryEntities.Entities[" + i + "].EntityId"),
                    EntityName = context.StringValue("QueryEntities.Entities[" + i + "].EntityName"),
                    EntityType = context.StringValue("QueryEntities.Entities[" + i + "].EntityType"),
                    Regex = context.StringValue("QueryEntities.Entities[" + i + "].Regex"),
                    CreateTime = context.StringValue("QueryEntities.Entities[" + i + "].CreateTime"),
                    ModifyTime = context.StringValue("QueryEntities.Entities[" + i + "].ModifyTime"),
                    CreateUserId = context.StringValue("QueryEntities.Entities[" + i + "].CreateUserId"),
                    CreateUserName = context.StringValue("QueryEntities.Entities[" + i + "].CreateUserName"),
                    ModifyUserId = context.StringValue("QueryEntities.Entities[" + i + "].ModifyUserId"),
                    ModifyUserName = context.StringValue("QueryEntities.Entities[" + i + "].ModifyUserName")
                };

                List<QueryEntitiesResponse.QueryEntities_Entity.QueryEntities_MembersItem> entity_members = new List<QueryEntitiesResponse.QueryEntities_Entity.QueryEntities_MembersItem>();
				for (int j = 0; j < context.Length("QueryEntities.Entities["+ i +"].Members.Length"); j++) {
                    QueryEntitiesResponse.QueryEntities_Entity.QueryEntities_MembersItem membersItem = new QueryEntitiesResponse.QueryEntities_Entity.QueryEntities_MembersItem
                    {
                        MemberName = context.StringValue("QueryEntities.Entities[" + i + "].Members[" + j + "].MemberName")
                    };

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