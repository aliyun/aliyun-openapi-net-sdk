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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Qualitycheck.Model.V20190115
{
	public class TestRuleResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private TestRule_Data data;

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public TestRule_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class TestRule_Data
		{

			private bool? poc;

			private List<TestRule_HitRuleReviewInfo> hitRuleReviewInfoList;

			public bool? Poc
			{
				get
				{
					return poc;
				}
				set	
				{
					poc = value;
				}
			}

			public List<TestRule_HitRuleReviewInfo> HitRuleReviewInfoList
			{
				get
				{
					return hitRuleReviewInfoList;
				}
				set	
				{
					hitRuleReviewInfoList = value;
				}
			}

			public class TestRule_HitRuleReviewInfo
			{

				private long? rid;

				private List<TestRule_ConditionHitInfo> conditionHitInfoList;

				public long? Rid
				{
					get
					{
						return rid;
					}
					set	
					{
						rid = value;
					}
				}

				public List<TestRule_ConditionHitInfo> ConditionHitInfoList
				{
					get
					{
						return conditionHitInfoList;
					}
					set	
					{
						conditionHitInfoList = value;
					}
				}

				public class TestRule_ConditionHitInfo
				{

					private List<TestRule_KeyWord> keyWords;

					private List<string> cid;

					private TestRule_Phrase phrase;

					public List<TestRule_KeyWord> KeyWords
					{
						get
						{
							return keyWords;
						}
						set	
						{
							keyWords = value;
						}
					}

					public List<string> Cid
					{
						get
						{
							return cid;
						}
						set	
						{
							cid = value;
						}
					}

					public TestRule_Phrase Phrase
					{
						get
						{
							return phrase;
						}
						set	
						{
							phrase = value;
						}
					}

					public class TestRule_KeyWord
					{

						private int? to;

						private int? from;

						private string val;

						private string tid;

						private int? pid;

						public int? To
						{
							get
							{
								return to;
							}
							set	
							{
								to = value;
							}
						}

						public int? From
						{
							get
							{
								return from;
							}
							set	
							{
								from = value;
							}
						}

						public string Val
						{
							get
							{
								return val;
							}
							set	
							{
								val = value;
							}
						}

						public string Tid
						{
							get
							{
								return tid;
							}
							set	
							{
								tid = value;
							}
						}

						public int? Pid
						{
							get
							{
								return pid;
							}
							set	
							{
								pid = value;
							}
						}
					}

					public class TestRule_Phrase
					{

						private string words;

						private long? begin;

						private string identity;

						private int? pid;

						private int? emotionValue;

						private long? end;

						private string role;

						public string Words
						{
							get
							{
								return words;
							}
							set	
							{
								words = value;
							}
						}

						public long? Begin
						{
							get
							{
								return begin;
							}
							set	
							{
								begin = value;
							}
						}

						public string Identity
						{
							get
							{
								return identity;
							}
							set	
							{
								identity = value;
							}
						}

						public int? Pid
						{
							get
							{
								return pid;
							}
							set	
							{
								pid = value;
							}
						}

						public int? EmotionValue
						{
							get
							{
								return emotionValue;
							}
							set	
							{
								emotionValue = value;
							}
						}

						public long? End
						{
							get
							{
								return end;
							}
							set	
							{
								end = value;
							}
						}

						public string Role
						{
							get
							{
								return role;
							}
							set	
							{
								role = value;
							}
						}
					}
				}
			}
		}
	}
}
