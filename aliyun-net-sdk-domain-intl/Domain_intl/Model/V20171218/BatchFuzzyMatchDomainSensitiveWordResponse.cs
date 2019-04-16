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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Domain_intl.Model.V20171218
{
	public class BatchFuzzyMatchDomainSensitiveWordResponse : AcsResponse
	{

		private string requestId;

		private List<BatchFuzzyMatchDomainSensitiveWord_SensitiveWordMatchResult> sensitiveWordMatchResultList;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public List<BatchFuzzyMatchDomainSensitiveWord_SensitiveWordMatchResult> SensitiveWordMatchResultList
		{
			get
			{
				return sensitiveWordMatchResultList;
			}
			set	
			{
				sensitiveWordMatchResultList = value;
			}
		}

		public class BatchFuzzyMatchDomainSensitiveWord_SensitiveWordMatchResult
		{

			private string keyword;

			private bool? exist;

			private List<BatchFuzzyMatchDomainSensitiveWord_MatchedSensitiveWord> matchedSentiveWords;

			public string Keyword
			{
				get
				{
					return keyword;
				}
				set	
				{
					keyword = value;
				}
			}

			public bool? Exist
			{
				get
				{
					return exist;
				}
				set	
				{
					exist = value;
				}
			}

			public List<BatchFuzzyMatchDomainSensitiveWord_MatchedSensitiveWord> MatchedSentiveWords
			{
				get
				{
					return matchedSentiveWords;
				}
				set	
				{
					matchedSentiveWords = value;
				}
			}

			public class BatchFuzzyMatchDomainSensitiveWord_MatchedSensitiveWord
			{

				private string word;

				public string Word
				{
					get
					{
						return word;
					}
					set	
					{
						word = value;
					}
				}
			}
		}
	}
}
