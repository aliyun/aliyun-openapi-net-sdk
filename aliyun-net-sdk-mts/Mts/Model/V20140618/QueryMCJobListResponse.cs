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

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class QueryMCJobListResponse : AcsResponse
	{

		private string requestId;

		private string nextPageToken;

		private List<QueryMCJobList_Job> jobList;

		private List<string> nonExistIds;

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

		public string NextPageToken
		{
			get
			{
				return nextPageToken;
			}
			set	
			{
				nextPageToken = value;
			}
		}

		public List<QueryMCJobList_Job> JobList
		{
			get
			{
				return jobList;
			}
			set	
			{
				jobList = value;
			}
		}

		public List<string> NonExistIds
		{
			get
			{
				return nonExistIds;
			}
			set	
			{
				nonExistIds = value;
			}
		}

		public class QueryMCJobList_Job
		{

			private string jobId;

			private string userData;

			private string pipelineId;

			private string state;

			private string code;

			private string message;

			private string creationTime;

			private string resultOutputFile;

			private QueryMCJobList_Result result;

			public string JobId
			{
				get
				{
					return jobId;
				}
				set	
				{
					jobId = value;
				}
			}

			public string UserData
			{
				get
				{
					return userData;
				}
				set	
				{
					userData = value;
				}
			}

			public string PipelineId
			{
				get
				{
					return pipelineId;
				}
				set	
				{
					pipelineId = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
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

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string ResultOutputFile
			{
				get
				{
					return resultOutputFile;
				}
				set	
				{
					resultOutputFile = value;
				}
			}

			public QueryMCJobList_Result Result
			{
				get
				{
					return result;
				}
				set	
				{
					result = value;
				}
			}

			public class QueryMCJobList_Result
			{

				private string suggestion;

				private string score;

				private QueryMCJobList_PornResult pornResult;

				private QueryMCJobList_TerrorismResult terrorismResult;

				private QueryMCJobList_PoliticsResult politicsResult;

				private QueryMCJobList_AdResult adResult;

				private QueryMCJobList_QrcodeResult qrcodeResult;

				private QueryMCJobList_LiveResult liveResult;

				private QueryMCJobList_LogoResult logoResult;

				private QueryMCJobList_AbuseResult abuseResult;

				private QueryMCJobList_ContrabandResult contrabandResult;

				private QueryMCJobList_SpamResult spamResult;

				public string Suggestion
				{
					get
					{
						return suggestion;
					}
					set	
					{
						suggestion = value;
					}
				}

				public string Score
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

				public QueryMCJobList_PornResult PornResult
				{
					get
					{
						return pornResult;
					}
					set	
					{
						pornResult = value;
					}
				}

				public QueryMCJobList_TerrorismResult TerrorismResult
				{
					get
					{
						return terrorismResult;
					}
					set	
					{
						terrorismResult = value;
					}
				}

				public QueryMCJobList_PoliticsResult PoliticsResult
				{
					get
					{
						return politicsResult;
					}
					set	
					{
						politicsResult = value;
					}
				}

				public QueryMCJobList_AdResult AdResult
				{
					get
					{
						return adResult;
					}
					set	
					{
						adResult = value;
					}
				}

				public QueryMCJobList_QrcodeResult QrcodeResult
				{
					get
					{
						return qrcodeResult;
					}
					set	
					{
						qrcodeResult = value;
					}
				}

				public QueryMCJobList_LiveResult LiveResult
				{
					get
					{
						return liveResult;
					}
					set	
					{
						liveResult = value;
					}
				}

				public QueryMCJobList_LogoResult LogoResult
				{
					get
					{
						return logoResult;
					}
					set	
					{
						logoResult = value;
					}
				}

				public QueryMCJobList_AbuseResult AbuseResult
				{
					get
					{
						return abuseResult;
					}
					set	
					{
						abuseResult = value;
					}
				}

				public QueryMCJobList_ContrabandResult ContrabandResult
				{
					get
					{
						return contrabandResult;
					}
					set	
					{
						contrabandResult = value;
					}
				}

				public QueryMCJobList_SpamResult SpamResult
				{
					get
					{
						return spamResult;
					}
					set	
					{
						spamResult = value;
					}
				}

				public class QueryMCJobList_PornResult
				{

					private List<QueryMCJobList_PornVideo> pornVideos;

					private List<QueryMCJobList_PornAudio> pornAudios;

					private List<QueryMCJobList_PornText> pornTexts;

					private List<QueryMCJobList_PornImage> pornImages;

					private List<QueryMCJobList_PornOcr> pornOcrs;

					public List<QueryMCJobList_PornVideo> PornVideos
					{
						get
						{
							return pornVideos;
						}
						set	
						{
							pornVideos = value;
						}
					}

					public List<QueryMCJobList_PornAudio> PornAudios
					{
						get
						{
							return pornAudios;
						}
						set	
						{
							pornAudios = value;
						}
					}

					public List<QueryMCJobList_PornText> PornTexts
					{
						get
						{
							return pornTexts;
						}
						set	
						{
							pornTexts = value;
						}
					}

					public List<QueryMCJobList_PornImage> PornImages
					{
						get
						{
							return pornImages;
						}
						set	
						{
							pornImages = value;
						}
					}

					public List<QueryMCJobList_PornOcr> PornOcrs
					{
						get
						{
							return pornOcrs;
						}
						set	
						{
							pornOcrs = value;
						}
					}

					public class QueryMCJobList_PornVideo
					{

						private string suggestion;

						private string score;

						private string time;

						private string _object;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Time
						{
							get
							{
								return time;
							}
							set	
							{
								time = value;
							}
						}

						public string _Object
						{
							get
							{
								return _object;
							}
							set	
							{
								_object = value;
							}
						}
					}

					public class QueryMCJobList_PornAudio
					{

						private string suggestion;

						private string score;

						private string startTime;

						private string endTime;

						private string text;

						private string _object;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string StartTime
						{
							get
							{
								return startTime;
							}
							set	
							{
								startTime = value;
							}
						}

						public string EndTime
						{
							get
							{
								return endTime;
							}
							set	
							{
								endTime = value;
							}
						}

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}

						public string _Object
						{
							get
							{
								return _object;
							}
							set	
							{
								_object = value;
							}
						}
					}

					public class QueryMCJobList_PornText
					{

						private string suggestion;

						private string score;

						private string text;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}
					}

					public class QueryMCJobList_PornImage
					{

						private string suggestion;

						private string score;

						private string url;

						private string text;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}
					}

					public class QueryMCJobList_PornOcr
					{

						private string suggestion;

						private string score;

						private string time;

						private string _object;

						private string text;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Time
						{
							get
							{
								return time;
							}
							set	
							{
								time = value;
							}
						}

						public string _Object
						{
							get
							{
								return _object;
							}
							set	
							{
								_object = value;
							}
						}

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}
					}
				}

				public class QueryMCJobList_TerrorismResult
				{

					private List<QueryMCJobList_TerrorismVideo> terrorismVideos;

					private List<QueryMCJobList_TerrorismAudio> terrorismAudios;

					private List<QueryMCJobList_TerrorismText> terrorismTexts;

					private List<QueryMCJobList_TerrorismImage> terrorismImages;

					private List<QueryMCJobList_TerrorismOcr> terrorismOcrs;

					public List<QueryMCJobList_TerrorismVideo> TerrorismVideos
					{
						get
						{
							return terrorismVideos;
						}
						set	
						{
							terrorismVideos = value;
						}
					}

					public List<QueryMCJobList_TerrorismAudio> TerrorismAudios
					{
						get
						{
							return terrorismAudios;
						}
						set	
						{
							terrorismAudios = value;
						}
					}

					public List<QueryMCJobList_TerrorismText> TerrorismTexts
					{
						get
						{
							return terrorismTexts;
						}
						set	
						{
							terrorismTexts = value;
						}
					}

					public List<QueryMCJobList_TerrorismImage> TerrorismImages
					{
						get
						{
							return terrorismImages;
						}
						set	
						{
							terrorismImages = value;
						}
					}

					public List<QueryMCJobList_TerrorismOcr> TerrorismOcrs
					{
						get
						{
							return terrorismOcrs;
						}
						set	
						{
							terrorismOcrs = value;
						}
					}

					public class QueryMCJobList_TerrorismVideo
					{

						private string suggestion;

						private string score;

						private string time;

						private string _object;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Time
						{
							get
							{
								return time;
							}
							set	
							{
								time = value;
							}
						}

						public string _Object
						{
							get
							{
								return _object;
							}
							set	
							{
								_object = value;
							}
						}
					}

					public class QueryMCJobList_TerrorismAudio
					{

						private string suggestion;

						private string score;

						private string startTime;

						private string endTime;

						private string text;

						private string _object;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string StartTime
						{
							get
							{
								return startTime;
							}
							set	
							{
								startTime = value;
							}
						}

						public string EndTime
						{
							get
							{
								return endTime;
							}
							set	
							{
								endTime = value;
							}
						}

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}

						public string _Object
						{
							get
							{
								return _object;
							}
							set	
							{
								_object = value;
							}
						}
					}

					public class QueryMCJobList_TerrorismText
					{

						private string suggestion;

						private string score;

						private string text;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}
					}

					public class QueryMCJobList_TerrorismImage
					{

						private string suggestion;

						private string score;

						private string url;

						private string text;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}
					}

					public class QueryMCJobList_TerrorismOcr
					{

						private string suggestion;

						private string score;

						private string time;

						private string _object;

						private string text;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Time
						{
							get
							{
								return time;
							}
							set	
							{
								time = value;
							}
						}

						public string _Object
						{
							get
							{
								return _object;
							}
							set	
							{
								_object = value;
							}
						}

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}
					}
				}

				public class QueryMCJobList_PoliticsResult
				{

					private List<QueryMCJobList_PoliticsVideo> politicsVideos;

					private List<QueryMCJobList_PoliticsAudio> politicsAudios;

					private List<QueryMCJobList_PoliticsText> politicsTexts;

					private List<QueryMCJobList_PoliticsImage> politicsImages;

					private List<QueryMCJobList_PoliticsOcr> politicsOcrs;

					public List<QueryMCJobList_PoliticsVideo> PoliticsVideos
					{
						get
						{
							return politicsVideos;
						}
						set	
						{
							politicsVideos = value;
						}
					}

					public List<QueryMCJobList_PoliticsAudio> PoliticsAudios
					{
						get
						{
							return politicsAudios;
						}
						set	
						{
							politicsAudios = value;
						}
					}

					public List<QueryMCJobList_PoliticsText> PoliticsTexts
					{
						get
						{
							return politicsTexts;
						}
						set	
						{
							politicsTexts = value;
						}
					}

					public List<QueryMCJobList_PoliticsImage> PoliticsImages
					{
						get
						{
							return politicsImages;
						}
						set	
						{
							politicsImages = value;
						}
					}

					public List<QueryMCJobList_PoliticsOcr> PoliticsOcrs
					{
						get
						{
							return politicsOcrs;
						}
						set	
						{
							politicsOcrs = value;
						}
					}

					public class QueryMCJobList_PoliticsVideo
					{

						private string suggestion;

						private string score;

						private string time;

						private string _object;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Time
						{
							get
							{
								return time;
							}
							set	
							{
								time = value;
							}
						}

						public string _Object
						{
							get
							{
								return _object;
							}
							set	
							{
								_object = value;
							}
						}
					}

					public class QueryMCJobList_PoliticsAudio
					{

						private string suggestion;

						private string score;

						private string startTime;

						private string endTime;

						private string text;

						private string _object;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string StartTime
						{
							get
							{
								return startTime;
							}
							set	
							{
								startTime = value;
							}
						}

						public string EndTime
						{
							get
							{
								return endTime;
							}
							set	
							{
								endTime = value;
							}
						}

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}

						public string _Object
						{
							get
							{
								return _object;
							}
							set	
							{
								_object = value;
							}
						}
					}

					public class QueryMCJobList_PoliticsText
					{

						private string suggestion;

						private string score;

						private string text;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}
					}

					public class QueryMCJobList_PoliticsImage
					{

						private string suggestion;

						private string score;

						private string url;

						private string text;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}
					}

					public class QueryMCJobList_PoliticsOcr
					{

						private string suggestion;

						private string score;

						private string time;

						private string _object;

						private string text;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Time
						{
							get
							{
								return time;
							}
							set	
							{
								time = value;
							}
						}

						public string _Object
						{
							get
							{
								return _object;
							}
							set	
							{
								_object = value;
							}
						}

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}
					}
				}

				public class QueryMCJobList_AdResult
				{

					private List<QueryMCJobList_AdVideo> adVideos;

					private List<QueryMCJobList_AdAudio> adAudios;

					private List<QueryMCJobList_AdText> adTexts;

					private List<QueryMCJobList_AdImage> adImages;

					private List<QueryMCJobList_AdOcr> adOcrs;

					public List<QueryMCJobList_AdVideo> AdVideos
					{
						get
						{
							return adVideos;
						}
						set	
						{
							adVideos = value;
						}
					}

					public List<QueryMCJobList_AdAudio> AdAudios
					{
						get
						{
							return adAudios;
						}
						set	
						{
							adAudios = value;
						}
					}

					public List<QueryMCJobList_AdText> AdTexts
					{
						get
						{
							return adTexts;
						}
						set	
						{
							adTexts = value;
						}
					}

					public List<QueryMCJobList_AdImage> AdImages
					{
						get
						{
							return adImages;
						}
						set	
						{
							adImages = value;
						}
					}

					public List<QueryMCJobList_AdOcr> AdOcrs
					{
						get
						{
							return adOcrs;
						}
						set	
						{
							adOcrs = value;
						}
					}

					public class QueryMCJobList_AdVideo
					{

						private string suggestion;

						private string score;

						private string time;

						private string _object;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Time
						{
							get
							{
								return time;
							}
							set	
							{
								time = value;
							}
						}

						public string _Object
						{
							get
							{
								return _object;
							}
							set	
							{
								_object = value;
							}
						}
					}

					public class QueryMCJobList_AdAudio
					{

						private string suggestion;

						private string score;

						private string startTime;

						private string endTime;

						private string text;

						private string _object;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string StartTime
						{
							get
							{
								return startTime;
							}
							set	
							{
								startTime = value;
							}
						}

						public string EndTime
						{
							get
							{
								return endTime;
							}
							set	
							{
								endTime = value;
							}
						}

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}

						public string _Object
						{
							get
							{
								return _object;
							}
							set	
							{
								_object = value;
							}
						}
					}

					public class QueryMCJobList_AdText
					{

						private string suggestion;

						private string score;

						private string text;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}
					}

					public class QueryMCJobList_AdImage
					{

						private string suggestion;

						private string score;

						private string url;

						private string text;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}
					}

					public class QueryMCJobList_AdOcr
					{

						private string suggestion;

						private string score;

						private string time;

						private string _object;

						private string text;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Time
						{
							get
							{
								return time;
							}
							set	
							{
								time = value;
							}
						}

						public string _Object
						{
							get
							{
								return _object;
							}
							set	
							{
								_object = value;
							}
						}

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}
					}
				}

				public class QueryMCJobList_QrcodeResult
				{

					private List<QueryMCJobList_QrcodeVideo> qrcodeVideos;

					private List<QueryMCJobList_QrcodeImage> qrcodeImages;

					public List<QueryMCJobList_QrcodeVideo> QrcodeVideos
					{
						get
						{
							return qrcodeVideos;
						}
						set	
						{
							qrcodeVideos = value;
						}
					}

					public List<QueryMCJobList_QrcodeImage> QrcodeImages
					{
						get
						{
							return qrcodeImages;
						}
						set	
						{
							qrcodeImages = value;
						}
					}

					public class QueryMCJobList_QrcodeVideo
					{

						private string suggestion;

						private string score;

						private string time;

						private string _object;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Time
						{
							get
							{
								return time;
							}
							set	
							{
								time = value;
							}
						}

						public string _Object
						{
							get
							{
								return _object;
							}
							set	
							{
								_object = value;
							}
						}
					}

					public class QueryMCJobList_QrcodeImage
					{

						private string suggestion;

						private string score;

						private string url;

						private string text;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}
					}
				}

				public class QueryMCJobList_LiveResult
				{

					private List<QueryMCJobList_LiveVideo> liveVideos;

					private List<QueryMCJobList_LiveImage> liveImages;

					public List<QueryMCJobList_LiveVideo> LiveVideos
					{
						get
						{
							return liveVideos;
						}
						set	
						{
							liveVideos = value;
						}
					}

					public List<QueryMCJobList_LiveImage> LiveImages
					{
						get
						{
							return liveImages;
						}
						set	
						{
							liveImages = value;
						}
					}

					public class QueryMCJobList_LiveVideo
					{

						private string suggestion;

						private string score;

						private string time;

						private string _object;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Time
						{
							get
							{
								return time;
							}
							set	
							{
								time = value;
							}
						}

						public string _Object
						{
							get
							{
								return _object;
							}
							set	
							{
								_object = value;
							}
						}
					}

					public class QueryMCJobList_LiveImage
					{

						private string suggestion;

						private string score;

						private string url;

						private string text;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}
					}
				}

				public class QueryMCJobList_LogoResult
				{

					private List<QueryMCJobList_LogoVideo> logoVideos;

					private List<QueryMCJobList_LogoImage> logoImages;

					public List<QueryMCJobList_LogoVideo> LogoVideos
					{
						get
						{
							return logoVideos;
						}
						set	
						{
							logoVideos = value;
						}
					}

					public List<QueryMCJobList_LogoImage> LogoImages
					{
						get
						{
							return logoImages;
						}
						set	
						{
							logoImages = value;
						}
					}

					public class QueryMCJobList_LogoVideo
					{

						private string suggestion;

						private string score;

						private string time;

						private string _object;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Time
						{
							get
							{
								return time;
							}
							set	
							{
								time = value;
							}
						}

						public string _Object
						{
							get
							{
								return _object;
							}
							set	
							{
								_object = value;
							}
						}
					}

					public class QueryMCJobList_LogoImage
					{

						private string suggestion;

						private string score;

						private string url;

						private string text;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}
					}
				}

				public class QueryMCJobList_AbuseResult
				{

					private List<QueryMCJobList_AbuseAudio> abuseAudios;

					private List<QueryMCJobList_AbuseText> abuseTexts;

					private List<QueryMCJobList_AbuseOcr> abuseOcrs;

					public List<QueryMCJobList_AbuseAudio> AbuseAudios
					{
						get
						{
							return abuseAudios;
						}
						set	
						{
							abuseAudios = value;
						}
					}

					public List<QueryMCJobList_AbuseText> AbuseTexts
					{
						get
						{
							return abuseTexts;
						}
						set	
						{
							abuseTexts = value;
						}
					}

					public List<QueryMCJobList_AbuseOcr> AbuseOcrs
					{
						get
						{
							return abuseOcrs;
						}
						set	
						{
							abuseOcrs = value;
						}
					}

					public class QueryMCJobList_AbuseAudio
					{

						private string suggestion;

						private string score;

						private string startTime;

						private string endTime;

						private string text;

						private string _object;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string StartTime
						{
							get
							{
								return startTime;
							}
							set	
							{
								startTime = value;
							}
						}

						public string EndTime
						{
							get
							{
								return endTime;
							}
							set	
							{
								endTime = value;
							}
						}

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}

						public string _Object
						{
							get
							{
								return _object;
							}
							set	
							{
								_object = value;
							}
						}
					}

					public class QueryMCJobList_AbuseText
					{

						private string suggestion;

						private string score;

						private string text;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}
					}

					public class QueryMCJobList_AbuseOcr
					{

						private string suggestion;

						private string score;

						private string time;

						private string _object;

						private string text;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Time
						{
							get
							{
								return time;
							}
							set	
							{
								time = value;
							}
						}

						public string _Object
						{
							get
							{
								return _object;
							}
							set	
							{
								_object = value;
							}
						}

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}
					}
				}

				public class QueryMCJobList_ContrabandResult
				{

					private List<QueryMCJobList_ContrabandAudio> contrabandAudios;

					private List<QueryMCJobList_ContrabandText> contrabandTexts;

					private List<QueryMCJobList_ContrabandOcr> contrabandOcrs;

					public List<QueryMCJobList_ContrabandAudio> ContrabandAudios
					{
						get
						{
							return contrabandAudios;
						}
						set	
						{
							contrabandAudios = value;
						}
					}

					public List<QueryMCJobList_ContrabandText> ContrabandTexts
					{
						get
						{
							return contrabandTexts;
						}
						set	
						{
							contrabandTexts = value;
						}
					}

					public List<QueryMCJobList_ContrabandOcr> ContrabandOcrs
					{
						get
						{
							return contrabandOcrs;
						}
						set	
						{
							contrabandOcrs = value;
						}
					}

					public class QueryMCJobList_ContrabandAudio
					{

						private string suggestion;

						private string score;

						private string startTime;

						private string endTime;

						private string text;

						private string _object;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string StartTime
						{
							get
							{
								return startTime;
							}
							set	
							{
								startTime = value;
							}
						}

						public string EndTime
						{
							get
							{
								return endTime;
							}
							set	
							{
								endTime = value;
							}
						}

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}

						public string _Object
						{
							get
							{
								return _object;
							}
							set	
							{
								_object = value;
							}
						}
					}

					public class QueryMCJobList_ContrabandText
					{

						private string suggestion;

						private string score;

						private string text;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}
					}

					public class QueryMCJobList_ContrabandOcr
					{

						private string suggestion;

						private string score;

						private string time;

						private string _object;

						private string text;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Time
						{
							get
							{
								return time;
							}
							set	
							{
								time = value;
							}
						}

						public string _Object
						{
							get
							{
								return _object;
							}
							set	
							{
								_object = value;
							}
						}

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}
					}
				}

				public class QueryMCJobList_SpamResult
				{

					private List<QueryMCJobList_SpamAudio> spamAudios;

					private List<QueryMCJobList_SpamText> spamTexts;

					private List<QueryMCJobList_SpamOcr> spamOcrs;

					public List<QueryMCJobList_SpamAudio> SpamAudios
					{
						get
						{
							return spamAudios;
						}
						set	
						{
							spamAudios = value;
						}
					}

					public List<QueryMCJobList_SpamText> SpamTexts
					{
						get
						{
							return spamTexts;
						}
						set	
						{
							spamTexts = value;
						}
					}

					public List<QueryMCJobList_SpamOcr> SpamOcrs
					{
						get
						{
							return spamOcrs;
						}
						set	
						{
							spamOcrs = value;
						}
					}

					public class QueryMCJobList_SpamAudio
					{

						private string suggestion;

						private string score;

						private string startTime;

						private string endTime;

						private string text;

						private string _object;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string StartTime
						{
							get
							{
								return startTime;
							}
							set	
							{
								startTime = value;
							}
						}

						public string EndTime
						{
							get
							{
								return endTime;
							}
							set	
							{
								endTime = value;
							}
						}

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}

						public string _Object
						{
							get
							{
								return _object;
							}
							set	
							{
								_object = value;
							}
						}
					}

					public class QueryMCJobList_SpamText
					{

						private string suggestion;

						private string score;

						private string text;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}
					}

					public class QueryMCJobList_SpamOcr
					{

						private string suggestion;

						private string score;

						private string time;

						private string _object;

						private string text;

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}

						public string Score
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

						public string Time
						{
							get
							{
								return time;
							}
							set	
							{
								time = value;
							}
						}

						public string _Object
						{
							get
							{
								return _object;
							}
							set	
							{
								_object = value;
							}
						}

						public string Text
						{
							get
							{
								return text;
							}
							set	
							{
								text = value;
							}
						}
					}
				}
			}
		}
	}
}
