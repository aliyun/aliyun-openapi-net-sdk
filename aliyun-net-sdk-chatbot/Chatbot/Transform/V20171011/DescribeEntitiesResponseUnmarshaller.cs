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
    public class DescribeEntitiesResponseUnmarshaller
    {
        public static DescribeEntitiesResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeEntitiesResponse describeEntitiesResponse = new DescribeEntitiesResponse
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeEntities.RequestId"),
                EntityId = context.LongValue("DescribeEntities.EntityId"),
                EntityName = context.StringValue("DescribeEntities.EntityName"),
                EntityType = context.StringValue("DescribeEntities.EntityType"),
                Regex = context.StringValue("DescribeEntities.Regex"),
                CreateTime = context.StringValue("DescribeEntities.CreateTime"),
                ModifyTime = context.StringValue("DescribeEntities.ModifyTime"),
                CreateUserId = context.StringValue("DescribeEntities.CreateUserId"),
                CreateUserName = context.StringValue("DescribeEntities.CreateUserName"),
                ModifyUserId = context.StringValue("DescribeEntities.ModifyUserId"),
                ModifyUserName = context.StringValue("DescribeEntities.ModifyUserName")
            };

            List<DescribeEntitiesResponse.DescribeEntities_MembersItem> describeEntitiesResponse_members = new List<DescribeEntitiesResponse.DescribeEntities_MembersItem>();
			for (int i = 0; i < context.Length("DescribeEntities.Members.Length"); i++) {
                DescribeEntitiesResponse.DescribeEntities_MembersItem membersItem = new DescribeEntitiesResponse.DescribeEntities_MembersItem
                {
                    MemberName = context.StringValue("DescribeEntities.Members[" + i + "].MemberName")
                };

                List<string> membersItem_synonyms = new List<string>();
				for (int j = 0; j < context.Length("DescribeEntities.Members["+ i +"].Synonyms.Length"); j++) {
					membersItem_synonyms.Add(context.StringValue("DescribeEntities.Members["+ i +"].Synonyms["+ j +"]"));
				}
				membersItem.Synonyms = membersItem_synonyms;

				describeEntitiesResponse_members.Add(membersItem);
			}
			describeEntitiesResponse.Members = describeEntitiesResponse_members;
        
			return describeEntitiesResponse;
        }
    }
}