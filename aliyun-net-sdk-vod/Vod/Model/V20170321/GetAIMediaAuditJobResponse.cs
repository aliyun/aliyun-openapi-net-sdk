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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class GetAIMediaAuditJobResponse : AcsResponse
	{

		private string requestId;

		private GetAIMediaAuditJob_MediaAuditJob mediaAuditJob;

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

		public GetAIMediaAuditJob_MediaAuditJob MediaAuditJob
		{
			get
			{
				return mediaAuditJob;
			}
			set	
			{
				mediaAuditJob = value;
			}
		}

		public class GetAIMediaAuditJob_MediaAuditJob
		{

			private string jobId;

			private string mediaId;

			private string type;

			private string status;

			private string code;

			private string message;

			private string creationTime;

			private string completeTime;

			private GetAIMediaAuditJob_Data data;

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

			public string MediaId
			{
				get
				{
					return mediaId;
				}
				set	
				{
					mediaId = value;
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

			public string Status
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

			public string CompleteTime
			{
				get
				{
					return completeTime;
				}
				set	
				{
					completeTime = value;
				}
			}

			public GetAIMediaAuditJob_Data Data
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

			public class GetAIMediaAuditJob_Data
			{

				private string suggestion;

				private string abnormalModules;

				private string label;

				private List<GetAIMediaAuditJob_ImageResultItem> imageResult;

				private List<GetAIMediaAuditJob_TextResultItem> textResult;

				private GetAIMediaAuditJob_VideoResult videoResult;

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

				public string AbnormalModules
				{
					get
					{
						return abnormalModules;
					}
					set	
					{
						abnormalModules = value;
					}
				}

				public string Label
				{
					get
					{
						return label;
					}
					set	
					{
						label = value;
					}
				}

				public List<GetAIMediaAuditJob_ImageResultItem> ImageResult
				{
					get
					{
						return imageResult;
					}
					set	
					{
						imageResult = value;
					}
				}

				public List<GetAIMediaAuditJob_TextResultItem> TextResult
				{
					get
					{
						return textResult;
					}
					set	
					{
						textResult = value;
					}
				}

				public GetAIMediaAuditJob_VideoResult VideoResult
				{
					get
					{
						return videoResult;
					}
					set	
					{
						videoResult = value;
					}
				}

				public class GetAIMediaAuditJob_ImageResultItem
				{

					private string suggestion;

					private string label;

					private string type;

					private string url;

					private List<GetAIMediaAuditJob_ResultItem> result;

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

					public string Label
					{
						get
						{
							return label;
						}
						set	
						{
							label = value;
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

					public List<GetAIMediaAuditJob_ResultItem> Result
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

					public class GetAIMediaAuditJob_ResultItem
					{

						private string suggestion;

						private string label;

						private string score;

						private string scene;

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

						public string Label
						{
							get
							{
								return label;
							}
							set	
							{
								label = value;
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

						public string Scene
						{
							get
							{
								return scene;
							}
							set	
							{
								scene = value;
							}
						}
					}
				}

				public class GetAIMediaAuditJob_TextResultItem
				{

					private string suggestion;

					private string label;

					private string score;

					private string scene;

					private string type;

					private string content;

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

					public string Label
					{
						get
						{
							return label;
						}
						set	
						{
							label = value;
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

					public string Scene
					{
						get
						{
							return scene;
						}
						set	
						{
							scene = value;
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

					public string Content
					{
						get
						{
							return content;
						}
						set	
						{
							content = value;
						}
					}
				}

				public class GetAIMediaAuditJob_VideoResult
				{

					private string suggestion;

					private string label;

					private GetAIMediaAuditJob_TerrorismResult terrorismResult;

					private GetAIMediaAuditJob_PornResult pornResult;

					private GetAIMediaAuditJob_AdResult adResult;

					private GetAIMediaAuditJob_LiveResult liveResult;

					private GetAIMediaAuditJob_LogoResult logoResult;

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

					public string Label
					{
						get
						{
							return label;
						}
						set	
						{
							label = value;
						}
					}

					public GetAIMediaAuditJob_TerrorismResult TerrorismResult
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

					public GetAIMediaAuditJob_PornResult PornResult
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

					public GetAIMediaAuditJob_AdResult AdResult
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

					public GetAIMediaAuditJob_LiveResult LiveResult
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

					public GetAIMediaAuditJob_LogoResult LogoResult
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

					public class GetAIMediaAuditJob_TerrorismResult
					{

						private string suggestion;

						private string label;

						private string maxScore;

						private string averageScore;

						private List<GetAIMediaAuditJob_CounterListItem> counterList;

						private List<GetAIMediaAuditJob_TopListItem> topList;

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

						public string Label
						{
							get
							{
								return label;
							}
							set	
							{
								label = value;
							}
						}

						public string MaxScore
						{
							get
							{
								return maxScore;
							}
							set	
							{
								maxScore = value;
							}
						}

						public string AverageScore
						{
							get
							{
								return averageScore;
							}
							set	
							{
								averageScore = value;
							}
						}

						public List<GetAIMediaAuditJob_CounterListItem> CounterList
						{
							get
							{
								return counterList;
							}
							set	
							{
								counterList = value;
							}
						}

						public List<GetAIMediaAuditJob_TopListItem> TopList
						{
							get
							{
								return topList;
							}
							set	
							{
								topList = value;
							}
						}

						public class GetAIMediaAuditJob_CounterListItem
						{

							private string label;

							private int? count;

							public string Label
							{
								get
								{
									return label;
								}
								set	
								{
									label = value;
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
						}

						public class GetAIMediaAuditJob_TopListItem
						{

							private string label;

							private string score;

							private string timestamp;

							private string url;

							public string Label
							{
								get
								{
									return label;
								}
								set	
								{
									label = value;
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

							public string Timestamp
							{
								get
								{
									return timestamp;
								}
								set	
								{
									timestamp = value;
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
						}
					}

					public class GetAIMediaAuditJob_PornResult
					{

						private string suggestion;

						private string label;

						private string maxScore;

						private string averageScore;

						private List<GetAIMediaAuditJob_CounterListItem3> counterList1;

						private List<GetAIMediaAuditJob_TopListItem4> topList2;

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

						public string Label
						{
							get
							{
								return label;
							}
							set	
							{
								label = value;
							}
						}

						public string MaxScore
						{
							get
							{
								return maxScore;
							}
							set	
							{
								maxScore = value;
							}
						}

						public string AverageScore
						{
							get
							{
								return averageScore;
							}
							set	
							{
								averageScore = value;
							}
						}

						public List<GetAIMediaAuditJob_CounterListItem3> CounterList1
						{
							get
							{
								return counterList1;
							}
							set	
							{
								counterList1 = value;
							}
						}

						public List<GetAIMediaAuditJob_TopListItem4> TopList2
						{
							get
							{
								return topList2;
							}
							set	
							{
								topList2 = value;
							}
						}

						public class GetAIMediaAuditJob_CounterListItem3
						{

							private string label;

							private int? count;

							public string Label
							{
								get
								{
									return label;
								}
								set	
								{
									label = value;
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
						}

						public class GetAIMediaAuditJob_TopListItem4
						{

							private string label;

							private string score;

							private string timestamp;

							private string url;

							public string Label
							{
								get
								{
									return label;
								}
								set	
								{
									label = value;
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

							public string Timestamp
							{
								get
								{
									return timestamp;
								}
								set	
								{
									timestamp = value;
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
						}
					}

					public class GetAIMediaAuditJob_AdResult
					{

						private string suggestion;

						private string label;

						private string maxScore;

						private string averageScore;

						private List<GetAIMediaAuditJob_CounterListItem7> counterList5;

						private List<GetAIMediaAuditJob_TopListItem8> topList6;

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

						public string Label
						{
							get
							{
								return label;
							}
							set	
							{
								label = value;
							}
						}

						public string MaxScore
						{
							get
							{
								return maxScore;
							}
							set	
							{
								maxScore = value;
							}
						}

						public string AverageScore
						{
							get
							{
								return averageScore;
							}
							set	
							{
								averageScore = value;
							}
						}

						public List<GetAIMediaAuditJob_CounterListItem7> CounterList5
						{
							get
							{
								return counterList5;
							}
							set	
							{
								counterList5 = value;
							}
						}

						public List<GetAIMediaAuditJob_TopListItem8> TopList6
						{
							get
							{
								return topList6;
							}
							set	
							{
								topList6 = value;
							}
						}

						public class GetAIMediaAuditJob_CounterListItem7
						{

							private string label;

							private int? count;

							public string Label
							{
								get
								{
									return label;
								}
								set	
								{
									label = value;
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
						}

						public class GetAIMediaAuditJob_TopListItem8
						{

							private string label;

							private string score;

							private string timestamp;

							private string url;

							public string Label
							{
								get
								{
									return label;
								}
								set	
								{
									label = value;
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

							public string Timestamp
							{
								get
								{
									return timestamp;
								}
								set	
								{
									timestamp = value;
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
						}
					}

					public class GetAIMediaAuditJob_LiveResult
					{

						private string suggestion;

						private string label;

						private string maxScore;

						private string averageScore;

						private List<GetAIMediaAuditJob_CounterListItem11> counterList9;

						private List<GetAIMediaAuditJob_TopListItem12> topList10;

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

						public string Label
						{
							get
							{
								return label;
							}
							set	
							{
								label = value;
							}
						}

						public string MaxScore
						{
							get
							{
								return maxScore;
							}
							set	
							{
								maxScore = value;
							}
						}

						public string AverageScore
						{
							get
							{
								return averageScore;
							}
							set	
							{
								averageScore = value;
							}
						}

						public List<GetAIMediaAuditJob_CounterListItem11> CounterList9
						{
							get
							{
								return counterList9;
							}
							set	
							{
								counterList9 = value;
							}
						}

						public List<GetAIMediaAuditJob_TopListItem12> TopList10
						{
							get
							{
								return topList10;
							}
							set	
							{
								topList10 = value;
							}
						}

						public class GetAIMediaAuditJob_CounterListItem11
						{

							private string label;

							private int? count;

							public string Label
							{
								get
								{
									return label;
								}
								set	
								{
									label = value;
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
						}

						public class GetAIMediaAuditJob_TopListItem12
						{

							private string label;

							private string score;

							private string timestamp;

							private string url;

							public string Label
							{
								get
								{
									return label;
								}
								set	
								{
									label = value;
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

							public string Timestamp
							{
								get
								{
									return timestamp;
								}
								set	
								{
									timestamp = value;
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
						}
					}

					public class GetAIMediaAuditJob_LogoResult
					{

						private string suggestion;

						private string label;

						private string maxScore;

						private string averageScore;

						private List<GetAIMediaAuditJob_CounterListItem15> counterList13;

						private List<GetAIMediaAuditJob_TopListItem16> topList14;

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

						public string Label
						{
							get
							{
								return label;
							}
							set	
							{
								label = value;
							}
						}

						public string MaxScore
						{
							get
							{
								return maxScore;
							}
							set	
							{
								maxScore = value;
							}
						}

						public string AverageScore
						{
							get
							{
								return averageScore;
							}
							set	
							{
								averageScore = value;
							}
						}

						public List<GetAIMediaAuditJob_CounterListItem15> CounterList13
						{
							get
							{
								return counterList13;
							}
							set	
							{
								counterList13 = value;
							}
						}

						public List<GetAIMediaAuditJob_TopListItem16> TopList14
						{
							get
							{
								return topList14;
							}
							set	
							{
								topList14 = value;
							}
						}

						public class GetAIMediaAuditJob_CounterListItem15
						{

							private string label;

							private int? count;

							public string Label
							{
								get
								{
									return label;
								}
								set	
								{
									label = value;
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
						}

						public class GetAIMediaAuditJob_TopListItem16
						{

							private string label;

							private string score;

							private string timestamp;

							private string url;

							public string Label
							{
								get
								{
									return label;
								}
								set	
								{
									label = value;
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

							public string Timestamp
							{
								get
								{
									return timestamp;
								}
								set	
								{
									timestamp = value;
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
						}
					}
				}
			}
		}
	}
}
