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

namespace Aliyun.Acs.Qualitycheck.Model.V20190115
{
	public class SyncQualityCheckResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private SyncQualityCheck_Data data;

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

			private string tid;

			private long? beginTime;

			private string taskId;

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

				private string rid;

				private string ruleName;

				private List<SyncQualityCheck_ConditionHitInfo> hit;

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

						private string val;

						private int? pid;

						private int? from;

						private int? to;

						private int? cid;

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
					}

					public class SyncQualityCheck_Phrase
					{

						private string role;

						private string identity;

						private string words;

						private long? begin;

						private long? end;

						private int? emotionValue;

						private int? speechRate;

						private int? silenceDuration;

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
