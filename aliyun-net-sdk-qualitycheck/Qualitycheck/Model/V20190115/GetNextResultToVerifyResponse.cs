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
	public class GetNextResultToVerifyResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private GetNextResultToVerify_Data data;

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

		public GetNextResultToVerify_Data Data
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

		public class GetNextResultToVerify_Data
		{

			private int? index;

			private int? status;

			private string audioScheme;

			private string audioURL;

			private string updateTime;

			private int? incorrectWords;

			private int? verifiedCount;

			private bool? verified;

			private string fileName;

			private int? totalCount;

			private float? precision;

			private string fileId;

			private int? duration;

			private List<GetNextResultToVerify_Dialogue> dialogues;

			public int? Index
			{
				get
				{
					return index;
				}
				set	
				{
					index = value;
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

			public string AudioScheme
			{
				get
				{
					return audioScheme;
				}
				set	
				{
					audioScheme = value;
				}
			}

			public string AudioURL
			{
				get
				{
					return audioURL;
				}
				set	
				{
					audioURL = value;
				}
			}

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public int? IncorrectWords
			{
				get
				{
					return incorrectWords;
				}
				set	
				{
					incorrectWords = value;
				}
			}

			public int? VerifiedCount
			{
				get
				{
					return verifiedCount;
				}
				set	
				{
					verifiedCount = value;
				}
			}

			public bool? Verified
			{
				get
				{
					return verified;
				}
				set	
				{
					verified = value;
				}
			}

			public string FileName
			{
				get
				{
					return fileName;
				}
				set	
				{
					fileName = value;
				}
			}

			public int? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
				}
			}

			public float? Precision
			{
				get
				{
					return precision;
				}
				set	
				{
					precision = value;
				}
			}

			public string FileId
			{
				get
				{
					return fileId;
				}
				set	
				{
					fileId = value;
				}
			}

			public int? Duration
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

			public List<GetNextResultToVerify_Dialogue> Dialogues
			{
				get
				{
					return dialogues;
				}
				set	
				{
					dialogues = value;
				}
			}

			public class GetNextResultToVerify_Dialogue
			{

				private string words;

				private string identity;

				private int? incorrectWords;

				private string beginTime;

				private string sourceWords;

				private long? end;

				private int? speechRate;

				private string hourMinSec;

				private string sourceRole;

				private long? begin;

				private int? emotionValue;

				private string role;

				private int? silenceDuration;

				private List<GetNextResultToVerify_Delta> deltas;

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

				public int? IncorrectWords
				{
					get
					{
						return incorrectWords;
					}
					set	
					{
						incorrectWords = value;
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

				public string SourceWords
				{
					get
					{
						return sourceWords;
					}
					set	
					{
						sourceWords = value;
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

				public string HourMinSec
				{
					get
					{
						return hourMinSec;
					}
					set	
					{
						hourMinSec = value;
					}
				}

				public string SourceRole
				{
					get
					{
						return sourceRole;
					}
					set	
					{
						sourceRole = value;
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

				public List<GetNextResultToVerify_Delta> Deltas
				{
					get
					{
						return deltas;
					}
					set	
					{
						deltas = value;
					}
				}

				public class GetNextResultToVerify_Delta
				{

					private string type;

					private GetNextResultToVerify_Source source;

					private GetNextResultToVerify_Target target;

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

					public GetNextResultToVerify_Source Source
					{
						get
						{
							return source;
						}
						set	
						{
							source = value;
						}
					}

					public GetNextResultToVerify_Target Target
					{
						get
						{
							return target;
						}
						set	
						{
							target = value;
						}
					}

					public class GetNextResultToVerify_Source
					{

						private int? position;

						private List<string> line;

						public int? Position
						{
							get
							{
								return position;
							}
							set	
							{
								position = value;
							}
						}

						public List<string> Line
						{
							get
							{
								return line;
							}
							set	
							{
								line = value;
							}
						}
					}

					public class GetNextResultToVerify_Target
					{

						private int? position;

						private List<string> line1;

						public int? Position
						{
							get
							{
								return position;
							}
							set	
							{
								position = value;
							}
						}

						public List<string> Line1
						{
							get
							{
								return line1;
							}
							set	
							{
								line1 = value;
							}
						}
					}
				}
			}
		}
	}
}
