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
    public class FuzzyMatchDomainSensitiveWordResponseUnmarshaller
    {
        public static FuzzyMatchDomainSensitiveWordResponse Unmarshall(UnmarshallerContext context)
        {
			FuzzyMatchDomainSensitiveWordResponse fuzzyMatchDomainSensitiveWordResponse = new FuzzyMatchDomainSensitiveWordResponse();

			fuzzyMatchDomainSensitiveWordResponse.HttpResponse = context.HttpResponse;
			fuzzyMatchDomainSensitiveWordResponse.RequestId = context.StringValue("FuzzyMatchDomainSensitiveWord.RequestId");
			fuzzyMatchDomainSensitiveWordResponse.Keyword = context.StringValue("FuzzyMatchDomainSensitiveWord.Keyword");
			fuzzyMatchDomainSensitiveWordResponse.Exist = context.BooleanValue("FuzzyMatchDomainSensitiveWord.Exist");

			List<FuzzyMatchDomainSensitiveWordResponse.FuzzyMatchDomainSensitiveWord_MatchedSensitiveWord> fuzzyMatchDomainSensitiveWordResponse_matchedSentiveWords = new List<FuzzyMatchDomainSensitiveWordResponse.FuzzyMatchDomainSensitiveWord_MatchedSensitiveWord>();
			for (int i = 0; i < context.Length("FuzzyMatchDomainSensitiveWord.MatchedSentiveWords.Length"); i++) {
				FuzzyMatchDomainSensitiveWordResponse.FuzzyMatchDomainSensitiveWord_MatchedSensitiveWord matchedSensitiveWord = new FuzzyMatchDomainSensitiveWordResponse.FuzzyMatchDomainSensitiveWord_MatchedSensitiveWord();
				matchedSensitiveWord.Word = context.StringValue("FuzzyMatchDomainSensitiveWord.MatchedSentiveWords["+ i +"].Word");

				fuzzyMatchDomainSensitiveWordResponse_matchedSentiveWords.Add(matchedSensitiveWord);
			}
			fuzzyMatchDomainSensitiveWordResponse.MatchedSentiveWords = fuzzyMatchDomainSensitiveWordResponse_matchedSentiveWords;
        
			return fuzzyMatchDomainSensitiveWordResponse;
        }
    }
}
