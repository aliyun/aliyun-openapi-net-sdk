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
    public class QueryKnowledgesResponseUnmarshaller
    {
        public static QueryKnowledgesResponse Unmarshall(UnmarshallerContext context)
        {
            QueryKnowledgesResponse queryKnowledgesResponse = new QueryKnowledgesResponse
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("QueryKnowledges.RequestId"),
                PageNumber = context.IntegerValue("QueryKnowledges.PageNumber"),
                PageSize = context.IntegerValue("QueryKnowledges.PageSize"),
                TotalCount = context.IntegerValue("QueryKnowledges.TotalCount")
            };

            List<QueryKnowledgesResponse.QueryKnowledges_Knowledge> queryKnowledgesResponse_knowledges = new List<QueryKnowledgesResponse.QueryKnowledges_Knowledge>();
			for (int i = 0; i < context.Length("QueryKnowledges.Knowledges.Length"); i++) {
                QueryKnowledgesResponse.QueryKnowledges_Knowledge knowledge = new QueryKnowledgesResponse.QueryKnowledges_Knowledge
                {
                    KnowledgeId = context.LongValue("QueryKnowledges.Knowledges[" + i + "].KnowledgeId"),
                    ModifyTime = context.StringValue("QueryKnowledges.Knowledges[" + i + "].ModifyTime"),
                    ModifyUserName = context.StringValue("QueryKnowledges.Knowledges[" + i + "].ModifyUserName"),
                    CreateTime = context.StringValue("QueryKnowledges.Knowledges[" + i + "].CreateTime"),
                    CreateUserName = context.StringValue("QueryKnowledges.Knowledges[" + i + "].CreateUserName"),
                    CategoryId = context.LongValue("QueryKnowledges.Knowledges[" + i + "].CategoryId"),
                    KnowledgeStatus = context.IntegerValue("QueryKnowledges.Knowledges[" + i + "].KnowledgeStatus"),
                    KnowledgeTitle = context.StringValue("QueryKnowledges.Knowledges[" + i + "].KnowledgeTitle"),
                    StartDate = context.StringValue("QueryKnowledges.Knowledges[" + i + "].StartDate"),
                    EndDate = context.StringValue("QueryKnowledges.Knowledges[" + i + "].EndDate"),
                    Version = context.StringValue("QueryKnowledges.Knowledges[" + i + "].Version")
                };

                List<string> knowledge_coreWords = new List<string>();
				for (int j = 0; j < context.Length("QueryKnowledges.Knowledges["+ i +"].CoreWords.Length"); j++) {
					knowledge_coreWords.Add(context.StringValue("QueryKnowledges.Knowledges["+ i +"].CoreWords["+ j +"]"));
				}
				knowledge.CoreWords = knowledge_coreWords;

				queryKnowledgesResponse_knowledges.Add(knowledge);
			}
			queryKnowledgesResponse.Knowledges = queryKnowledgesResponse_knowledges;
        
			return queryKnowledgesResponse;
        }
    }
}