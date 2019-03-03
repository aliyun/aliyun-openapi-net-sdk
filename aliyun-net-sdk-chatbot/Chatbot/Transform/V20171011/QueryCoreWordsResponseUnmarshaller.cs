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
    public class QueryCoreWordsResponseUnmarshaller
    {
        public static QueryCoreWordsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryCoreWordsResponse queryCoreWordsResponse = new QueryCoreWordsResponse();

			queryCoreWordsResponse.HttpResponse = context.HttpResponse;
			queryCoreWordsResponse.RequestId = context.StringValue("QueryCoreWords.RequestId");
			queryCoreWordsResponse.PageNumber = context.IntegerValue("QueryCoreWords.PageNumber");
			queryCoreWordsResponse.PageSize = context.IntegerValue("QueryCoreWords.PageSize");
			queryCoreWordsResponse.TotalCount = context.IntegerValue("QueryCoreWords.TotalCount");

			List<QueryCoreWordsResponse.QueryCoreWords_CoreWord> queryCoreWordsResponse_coreWords = new List<QueryCoreWordsResponse.QueryCoreWords_CoreWord>();
			for (int i = 0; i < context.Length("QueryCoreWords.CoreWords.Length"); i++) {
				QueryCoreWordsResponse.QueryCoreWords_CoreWord coreWord = new QueryCoreWordsResponse.QueryCoreWords_CoreWord();
				coreWord.CoreWordCode = context.StringValue("QueryCoreWords.CoreWords["+ i +"].CoreWordCode");
				coreWord.CoreWordName = context.StringValue("QueryCoreWords.CoreWords["+ i +"].CoreWordName");
				coreWord.ModifyTime = context.StringValue("QueryCoreWords.CoreWords["+ i +"].ModifyTime");
				coreWord.CreateTime = context.StringValue("QueryCoreWords.CoreWords["+ i +"].CreateTime");

				List<string> coreWord_synonyms = new List<string>();
				for (int j = 0; j < context.Length("QueryCoreWords.CoreWords["+ i +"].Synonyms.Length"); j++) {
					coreWord_synonyms.Add(context.StringValue("QueryCoreWords.CoreWords["+ i +"].Synonyms["+ j +"]"));
				}
				coreWord.Synonyms = coreWord_synonyms;

				queryCoreWordsResponse_coreWords.Add(coreWord);
			}
			queryCoreWordsResponse.CoreWords = queryCoreWordsResponse_coreWords;
        
			return queryCoreWordsResponse;
        }
    }
}