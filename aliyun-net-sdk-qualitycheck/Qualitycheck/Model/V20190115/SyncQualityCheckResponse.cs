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
	public class SyncQualityCheckResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private SyncQualityCheck_Data data;

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

		public SyncQualityCheck_Data Data
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

		public class SyncQualityCheck_Data
		{

			private int? score;

			private string taskId;

			private string tid;

			private long? beginTime;

			private List<SyncQualityCheck_RuleHitInfo> rules;

			public int? Score
			{
				get
				{
					return score;
				}
				set	
				{
					score = value;
				}
			}

			public string TaskId
			{
				get
				{
					return taskId;
				}
				set	
				{
					taskId = value;
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

			public long? BeginTime
			{
				get
				{
					return beginTime;
				}
				set	
				{
					beginTime = value;
				}
			}

			public List<SyncQualityCheck_RuleHitInfo> Rules
			{
				get
				{
					return rules;
				}
				set	
				{
					rules = value;
				}
			}

			public class SyncQualityCheck_RuleHitInfo
			{

				private string ruleName;

				private string rid;

				private List<SyncQualityCheck_ConditionHitInfo> hit;

				public string RuleName
				{
					get
					{
						return ruleName;
					}
					set	
					{
						ruleName = value;
					}
				}

				public string Rid
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

				public List<SyncQualityCheck_ConditionHitInfo> Hit
				{
					get
					{
						return hit;
					}
					set	
					{
						hit = value;
					}
				}

				public class SyncQualityCheck_ConditionHitInfo
				{

					private List<SyncQualityCheck_HitKeyWord> hitKeyWords;

					private SyncQualityCheck_Phrase phrase;

					public List<SyncQualityCheck_HitKeyWord> HitKeyWords
					{
						get
						{
							return hitKeyWords;
						}
						set	
						{
							hitKeyWords = value;
						}
					}

					public SyncQualityCheck_Phrase Phrase
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

					public class SyncQualityCheck_HitKeyWord
					{

						private int? to;

						private int? from;

						private string val;

						private int? cid;

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

						public int? Cid
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

					public class SyncQualityCheck_Phrase
					{

						private string words;

						private string identity;

						private long? begin;

						private int? emotionValue;

						private long? end;

						private int? speechRate;

						private string role;

						private int? silenceDuration;

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

						public int? SpeechRate
						{
							get
							{
								return speechRate;
							}
							set	
							{
								speechRate = value;
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

						public int? SilenceDuration
						{
							get
							{
								return silenceDuration;
							}
							set	
							{
								silenceDuration = value;
							}
						}
					}
				}
			}
		}
	}
}
