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
	public class UploadDataSyncResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private List<UploadDataSync_ResultInfo> data;

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

		public List<UploadDataSync_ResultInfo> Data
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

		public class UploadDataSync_ResultInfo
		{

			private int? score;

			private List<UploadDataSync_RuleHitInfo> rules;

			private List<string> handScoreIdList;

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

			public List<UploadDataSync_RuleHitInfo> Rules
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

			public List<string> HandScoreIdList
			{
				get
				{
					return handScoreIdList;
				}
				set	
				{
					handScoreIdList = value;
				}
			}

			public class UploadDataSync_RuleHitInfo
			{

				private string rid;

				private string tid;

				private List<UploadDataSync_ConditionHitInfo> hit;

				private List<UploadDataSync_ConditionBasicInfo> conditionInfo;

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

				public List<UploadDataSync_ConditionHitInfo> Hit
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

				public List<UploadDataSync_ConditionBasicInfo> ConditionInfo
				{
					get
					{
						return conditionInfo;
					}
					set	
					{
						conditionInfo = value;
					}
				}

				public class UploadDataSync_ConditionHitInfo
				{

					private List<UploadDataSync_HitKeyWord> hitKeyWords;

					private List<string> hitCids;

					private UploadDataSync_Phrase phrase;

					public List<UploadDataSync_HitKeyWord> HitKeyWords
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

					public List<string> HitCids
					{
						get
						{
							return hitCids;
						}
						set	
						{
							hitCids = value;
						}
					}

					public UploadDataSync_Phrase Phrase
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

					public class UploadDataSync_HitKeyWord
					{

						private string val;

						private int? pid;

						private int? from;

						private int? to;

						private string tid;

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
					}

					public class UploadDataSync_Phrase
					{

						private string role;

						private string identity;

						private string words;

						private long? begin;

						private long? end;

						private string beginTime;

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

						public string BeginTime
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
					}
				}

				public class UploadDataSync_ConditionBasicInfo
				{

					private string conditionInfoCid;

					public string ConditionInfoCid
					{
						get
						{
							return conditionInfoCid;
						}
						set	
						{
							conditionInfoCid = value;
						}
					}
				}
			}
		}
	}
}
