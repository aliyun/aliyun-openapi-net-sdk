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
	public class GetResultResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string resultCountId;

		private string code;

		private string message;

		private int? pageNumber;

		private int? pageSize;

		private int? count;

		private List<GetResult_ResultInfo> data;

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

		public string ResultCountId
		{
			get
			{
				return resultCountId;
			}
			set	
			{
				resultCountId = value;
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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
			}
		}

		public List<GetResult_ResultInfo> Data
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

		public class GetResult_ResultInfo
		{

			private int? status;

			private string assignmentTime;

			private string lastDataId;

			private string errorMessage;

			private string reviewer;

			private string createTime;

			private int? reviewStatus;

			private string reviewTimeLong;

			private string taskName;

			private int? reviewResult;

			private int? score;

			private string createTimeLong;

			private string reviewTime;

			private string comments;

			private string taskId;

			private int? reviewType;

			private string resolver;

			private List<GetResult_AsrResultItem> asrResult;

			private List<GetResult_HitResultItem> hitResult;

			private List<GetResult_HitScoreItem> hitScore;

			private List<string> schemeIdList;

			private List<string> schemeNameList;

			private GetResult_Recording recording;

			private GetResult_Agent agent;

			public int? Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string AssignmentTime
			{
				get
				{
					return assignmentTime;
				}
				set	
				{
					assignmentTime = value;
				}
			}

			public string LastDataId
			{
				get
				{
					return lastDataId;
				}
				set	
				{
					lastDataId = value;
				}
			}

			public string ErrorMessage
			{
				get
				{
					return errorMessage;
				}
				set	
				{
					errorMessage = value;
				}
			}

			public string Reviewer
			{
				get
				{
					return reviewer;
				}
				set	
				{
					reviewer = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public int? ReviewStatus
			{
				get
				{
					return reviewStatus;
				}
				set	
				{
					reviewStatus = value;
				}
			}

			public string ReviewTimeLong
			{
				get
				{
					return reviewTimeLong;
				}
				set	
				{
					reviewTimeLong = value;
				}
			}

			public string TaskName
			{
				get
				{
					return taskName;
				}
				set	
				{
					taskName = value;
				}
			}

			public int? ReviewResult
			{
				get
				{
					return reviewResult;
				}
				set	
				{
					reviewResult = value;
				}
			}

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

			public string CreateTimeLong
			{
				get
				{
					return createTimeLong;
				}
				set	
				{
					createTimeLong = value;
				}
			}

			public string ReviewTime
			{
				get
				{
					return reviewTime;
				}
				set	
				{
					reviewTime = value;
				}
			}

			public string Comments
			{
				get
				{
					return comments;
				}
				set	
				{
					comments = value;
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

			public int? ReviewType
			{
				get
				{
					return reviewType;
				}
				set	
				{
					reviewType = value;
				}
			}

			public string Resolver
			{
				get
				{
					return resolver;
				}
				set	
				{
					resolver = value;
				}
			}

			public List<GetResult_AsrResultItem> AsrResult
			{
				get
				{
					return asrResult;
				}
				set	
				{
					asrResult = value;
				}
			}

			public List<GetResult_HitResultItem> HitResult
			{
				get
				{
					return hitResult;
				}
				set	
				{
					hitResult = value;
				}
			}

			public List<GetResult_HitScoreItem> HitScore
			{
				get
				{
					return hitScore;
				}
				set	
				{
					hitScore = value;
				}
			}

			public List<string> SchemeIdList
			{
				get
				{
					return schemeIdList;
				}
				set	
				{
					schemeIdList = value;
				}
			}

			public List<string> SchemeNameList
			{
				get
				{
					return schemeNameList;
				}
				set	
				{
					schemeNameList = value;
				}
			}

			public GetResult_Recording Recording
			{
				get
				{
					return recording;
				}
				set	
				{
					recording = value;
				}
			}

			public GetResult_Agent Agent
			{
				get
				{
					return agent;
				}
				set	
				{
					agent = value;
				}
			}

			public class GetResult_AsrResultItem
			{

				private string words;

				private long? begin;

				private int? emotionValue;

				private long? end;

				private int? speechRate;

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
			}

			public class GetResult_HitResultItem
			{

				private string type;

				private int? reviewResult;

				private string name;

				private string rid;

				private long? schemeId;

				private long? schemeVersion;

				private List<GetResult_Hit> hits;

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public int? ReviewResult
				{
					get
					{
						return reviewResult;
					}
					set	
					{
						reviewResult = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
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

				public long? SchemeId
				{
					get
					{
						return schemeId;
					}
					set	
					{
						schemeId = value;
					}
				}

				public long? SchemeVersion
				{
					get
					{
						return schemeVersion;
					}
					set	
					{
						schemeVersion = value;
					}
				}

				public List<GetResult_Hit> Hits
				{
					get
					{
						return hits;
					}
					set	
					{
						hits = value;
					}
				}

				public class GetResult_Hit
				{

					private List<GetResult_KeyWord> keyWords;

					private List<string> cid;

					private GetResult_Phrase phrase;

					public List<GetResult_KeyWord> KeyWords
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

					public GetResult_Phrase Phrase
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

					public class GetResult_KeyWord
					{

						private int? from;

						private int? to;

						private string val;

						private string cid;

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

						public string Cid
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

					public class GetResult_Phrase
					{

						private int? emotionValue;

						private int? end;

						private string words;

						private string role;

						private long? begin;

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

						public int? End
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
					}
				}
			}

			public class GetResult_HitScoreItem
			{

				private string scoreName;

				private string scoreNumber;

				private string scoreId;

				private string ruleId;

				public string ScoreName
				{
					get
					{
						return scoreName;
					}
					set	
					{
						scoreName = value;
					}
				}

				public string ScoreNumber
				{
					get
					{
						return scoreNumber;
					}
					set	
					{
						scoreNumber = value;
					}
				}

				public string ScoreId
				{
					get
					{
						return scoreId;
					}
					set	
					{
						scoreId = value;
					}
				}

				public string RuleId
				{
					get
					{
						return ruleId;
					}
					set	
					{
						ruleId = value;
					}
				}
			}

			public class GetResult_Recording
			{

				private string remark13;

				private string callee;

				private int? dialogueSize;

				private string primaryId;

				private string remark12;

				private string remark1;

				private string remark7;

				private string remark8;

				private string remark2;

				private string callId;

				private string remark9;

				private string name;

				private string remark6;

				private string remark10;

				private string business;

				private string remark3;

				private string url;

				private string remark11;

				private string remark4;

				private int? callType;

				private string caller;

				private string dataSetName;

				private long? duration;

				private long? remark5;

				private string id;

				private string callTime;

				public string Remark13
				{
					get
					{
						return remark13;
					}
					set	
					{
						remark13 = value;
					}
				}

				public string Callee
				{
					get
					{
						return callee;
					}
					set	
					{
						callee = value;
					}
				}

				public int? DialogueSize
				{
					get
					{
						return dialogueSize;
					}
					set	
					{
						dialogueSize = value;
					}
				}

				public string PrimaryId
				{
					get
					{
						return primaryId;
					}
					set	
					{
						primaryId = value;
					}
				}

				public string Remark12
				{
					get
					{
						return remark12;
					}
					set	
					{
						remark12 = value;
					}
				}

				public string Remark1
				{
					get
					{
						return remark1;
					}
					set	
					{
						remark1 = value;
					}
				}

				public string Remark7
				{
					get
					{
						return remark7;
					}
					set	
					{
						remark7 = value;
					}
				}

				public string Remark8
				{
					get
					{
						return remark8;
					}
					set	
					{
						remark8 = value;
					}
				}

				public string Remark2
				{
					get
					{
						return remark2;
					}
					set	
					{
						remark2 = value;
					}
				}

				public string CallId
				{
					get
					{
						return callId;
					}
					set	
					{
						callId = value;
					}
				}

				public string Remark9
				{
					get
					{
						return remark9;
					}
					set	
					{
						remark9 = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string Remark6
				{
					get
					{
						return remark6;
					}
					set	
					{
						remark6 = value;
					}
				}

				public string Remark10
				{
					get
					{
						return remark10;
					}
					set	
					{
						remark10 = value;
					}
				}

				public string Business
				{
					get
					{
						return business;
					}
					set	
					{
						business = value;
					}
				}

				public string Remark3
				{
					get
					{
						return remark3;
					}
					set	
					{
						remark3 = value;
					}
				}

				public string Url
				{
					get
					{
						return url;
					}
					set	
					{
						url = value;
					}
				}

				public string Remark11
				{
					get
					{
						return remark11;
					}
					set	
					{
						remark11 = value;
					}
				}

				public string Remark4
				{
					get
					{
						return remark4;
					}
					set	
					{
						remark4 = value;
					}
				}

				public int? CallType
				{
					get
					{
						return callType;
					}
					set	
					{
						callType = value;
					}
				}

				public string Caller
				{
					get
					{
						return caller;
					}
					set	
					{
						caller = value;
					}
				}

				public string DataSetName
				{
					get
					{
						return dataSetName;
					}
					set	
					{
						dataSetName = value;
					}
				}

				public long? Duration
				{
					get
					{
						return duration;
					}
					set	
					{
						duration = value;
					}
				}

				public long? Remark5
				{
					get
					{
						return remark5;
					}
					set	
					{
						remark5 = value;
					}
				}

				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public string CallTime
				{
					get
					{
						return callTime;
					}
					set	
					{
						callTime = value;
					}
				}
			}

			public class GetResult_Agent
			{

				private string name;

				private string skillGroup;

				private string id;

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string SkillGroup
				{
					get
					{
						return skillGroup;
					}
					set	
					{
						skillGroup = value;
					}
				}

				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}
			}
		}
	}
}
