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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Chatbot.Model.V20171011
{
	public class QueryKnowledgesResponse : AcsResponse
	{
        public new string RequestId { get; set; }

        public int? PageNumber { get; set; }

        public int? PageSize { get; set; }

        public int? TotalCount { get; set; }

        public List<QueryKnowledges_Knowledge> Knowledges { get; set; }

        public class QueryKnowledges_Knowledge
		{
            public long? KnowledgeId { get; set; }

            public string ModifyTime { get; set; }

            public string ModifyUserName { get; set; }

            public string CreateTime { get; set; }

            public string CreateUserName { get; set; }

            public long? CategoryId { get; set; }

            public int? KnowledgeStatus { get; set; }

            public string KnowledgeTitle { get; set; }

            public string StartDate { get; set; }

            public string EndDate { get; set; }

            public string Version { get; set; }

            public List<string> CoreWords { get; set; }
        }
	}
}