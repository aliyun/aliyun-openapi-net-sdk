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
using Aliyun.Acs.Domain.Model.V20180129;

namespace Aliyun.Acs.Domain.Transform.V20180129
{
    public class BatchFuzzyMatchDomainSensitiveWordResponseUnmarshaller
    {
        public static BatchFuzzyMatchDomainSensitiveWordResponse Unmarshall(UnmarshallerContext context)
        {
			BatchFuzzyMatchDomainSensitiveWordResponse batchFuzzyMatchDomainSensitiveWordResponse = new BatchFuzzyMatchDomainSensitiveWordResponse();

			batchFuzzyMatchDomainSensitiveWordResponse.HttpResponse = context.HttpResponse;
			batchFuzzyMatchDomainSensitiveWordResponse.RequestId = context.StringValue("BatchFuzzyMatchDomainSensitiveWord.RequestId");

			List<BatchFuzzyMatchDomainSensitiveWordResponse.BatchFuzzyMatchDomainSensitiveWord_SensitiveWordMatchResult> batchFuzzyMatchDomainSensitiveWordResponse_sensitiveWordMatchResultList = new List<BatchFuzzyMatchDomainSensitiveWordResponse.BatchFuzzyMatchDomainSensitiveWord_SensitiveWordMatchResult>();
			for (int i = 0; i < context.Length("BatchFuzzyMatchDomainSensitiveWord.SensitiveWordMatchResultList.Length"); i++) {
				BatchFuzzyMatchDomainSensitiveWordResponse.BatchFuzzyMatchDomainSensitiveWord_SensitiveWordMatchResult sensitiveWordMatchResult = new BatchFuzzyMatchDomainSensitiveWordResponse.BatchFuzzyMatchDomainSensitiveWord_SensitiveWordMatchResult();
				sensitiveWordMatchResult.Keyword = context.StringValue("BatchFuzzyMatchDomainSensitiveWord.SensitiveWordMatchResultList["+ i +"].Keyword");
				sensitiveWordMatchResult.Exist = context.BooleanValue("BatchFuzzyMatchDomainSensitiveWord.SensitiveWordMatchResultList["+ i +"].Exist");

				List<BatchFuzzyMatchDomainSensitiveWordResponse.BatchFuzzyMatchDomainSensitiveWord_SensitiveWordMatchResult.BatchFuzzyMatchDomainSensitiveWord_MatchedSensitiveWord> sensitiveWordMatchResult_matchedSentiveWords = new List<BatchFuzzyMatchDomainSensitiveWordResponse.BatchFuzzyMatchDomainSensitiveWord_SensitiveWordMatchResult.BatchFuzzyMatchDomainSensitiveWord_MatchedSensitiveWord>();
				for (int j = 0; j < context.Length("BatchFuzzyMatchDomainSensitiveWord.SensitiveWordMatchResultList["+ i +"].MatchedSentiveWords.Length"); j++) {
					BatchFuzzyMatchDomainSensitiveWordResponse.BatchFuzzyMatchDomainSensitiveWord_SensitiveWordMatchResult.BatchFuzzyMatchDomainSensitiveWord_MatchedSensitiveWord matchedSensitiveWord = new BatchFuzzyMatchDomainSensitiveWordResponse.BatchFuzzyMatchDomainSensitiveWord_SensitiveWordMatchResult.BatchFuzzyMatchDomainSensitiveWord_MatchedSensitiveWord();
					matchedSensitiveWord.Word = context.StringValue("BatchFuzzyMatchDomainSensitiveWord.SensitiveWordMatchResultList["+ i +"].MatchedSentiveWords["+ j +"].Word");

					sensitiveWordMatchResult_matchedSentiveWords.Add(matchedSensitiveWord);
				}
				sensitiveWordMatchResult.MatchedSentiveWords = sensitiveWordMatchResult_matchedSentiveWords;

				batchFuzzyMatchDomainSensitiveWordResponse_sensitiveWordMatchResultList.Add(sensitiveWordMatchResult);
			}
			batchFuzzyMatchDomainSensitiveWordResponse.SensitiveWordMatchResultList = batchFuzzyMatchDomainSensitiveWordResponse_sensitiveWordMatchResultList;
        
			return batchFuzzyMatchDomainSensitiveWordResponse;
        }
    }
}
