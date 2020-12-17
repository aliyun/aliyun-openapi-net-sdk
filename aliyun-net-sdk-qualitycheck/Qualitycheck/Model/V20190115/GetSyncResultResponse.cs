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
	public class GetSyncResultResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? count;

		private int? pageSize;

		private int? pageNumber;

		private string resultCountId;

		private List<GetSyncResult_ResultInfo> data;

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

		public List<GetSyncResult_ResultInfo> Data
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

		public class GetSyncResult_ResultInfo
		{

			private int? score;

			private string comments;

			private string errorMessage;

			private int? status;

			private int? reviewStatus;

			private int? reviewResult;

			private string taskId;

			private string taskName;

			private string createTime;

			private string reviewer;

			private string resolver;

			private List<GetSyncResult_AsrResultItem> asrResult;

			private List<GetSyncResult_HitResultItem> hitResult;

			private GetSyncResult_Recording recording;

			private GetSyncResult_Agent agent;

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

			public List<GetSyncResult_AsrResultItem> AsrResult
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

			public List<GetSyncResult_HitResultItem> HitResult
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

			public GetSyncResult_Recording Recording
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

			public GetSyncResult_Agent Agent
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

			public class GetSyncResult_AsrResultItem
			{

				private string role;

				private string words;

				private long? begin;

				private long? end;

				private int? emotionValue;

				private int? silenceDuration;

				private int? speechRate;

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
			}

			public class GetSyncResult_HitResultItem
			{

				private string rid;

				private string name;

				private string type;

				private int? reviewResult;

				private List<GetSyncResult_Hit> hits;

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

				public List<GetSyncResult_Hit> Hits
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

				public class GetSyncResult_Hit
				{

					private List<GetSyncResult_KeyWord> keyWords;

					private List<string> cid;

					private GetSyncResult_Phrase phrase;

					public List<GetSyncResult_KeyWord> KeyWords
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

					public GetSyncResult_Phrase Phrase
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

					public class GetSyncResult_KeyWord
					{

						private string cid;

						private int? from;

						private int? to;

						private string val;

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
					}

					public class GetSyncResult_Phrase
					{

						private string role;

						private string words;

						private long? begin;

						private int? end;

						private int? emotionValue;

						private int? silenceDuration;

						private int? speechRate;

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
					}
				}
			}

			public class GetSyncResult_Recording
			{

				private string id;

				private string primaryId;

				private string callId;

				private string name;

				private string url;

				private string dataSetName;

				private long? duration;

				private string caller;

				private string callee;

				private string callTime;

				private int? callType;

				private string business;

				private string remark1;

				private string remark2;

				private string remark3;

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
			}

			public class GetSyncResult_Agent
			{

				private string id;

				private string name;

				private string skillGroup;

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
			}
		}
	}
}
