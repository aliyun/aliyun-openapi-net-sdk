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
	public class GetMediaAuditResultResponse : AcsResponse
	{

		private string requestId;

		private GetMediaAuditResult_MediaAuditResult mediaAuditResult;

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

		public GetMediaAuditResult_MediaAuditResult MediaAuditResult
		{
			get
			{
				return mediaAuditResult;
			}
			set	
			{
				mediaAuditResult = value;
			}
		}

		public class GetMediaAuditResult_MediaAuditResult
		{

			private string abnormalModules;

			private string label;

			private string suggestion;

			private List<GetMediaAuditResult_AudioResultItem> audioResult;

			private List<GetMediaAuditResult_ImageResultItem> imageResult;

			private List<GetMediaAuditResult_TextResultItem> textResult;

			private GetMediaAuditResult_VideoResult videoResult;

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

			public List<GetMediaAuditResult_AudioResultItem> AudioResult
			{
				get
				{
					return audioResult;
				}
				set	
				{
					audioResult = value;
				}
			}

			public List<GetMediaAuditResult_ImageResultItem> ImageResult
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

			public List<GetMediaAuditResult_TextResultItem> TextResult
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

			public GetMediaAuditResult_VideoResult VideoResult
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

			public class GetMediaAuditResult_AudioResultItem
			{

				private string label;

				private string scene;

				private string score;

				private string suggestion;

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
			}

			public class GetMediaAuditResult_ImageResultItem
			{

				private string label;

				private string suggestion;

				private string type;

				private string url;

				private List<GetMediaAuditResult_ResultItem> result;

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

				public List<GetMediaAuditResult_ResultItem> Result
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

				public class GetMediaAuditResult_ResultItem
				{

					private string label;

					private string scene;

					private string score;

					private string suggestion;

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
				}
			}

			public class GetMediaAuditResult_TextResultItem
			{

				private string content;

				private string label;

				private string scene;

				private string score;

				private string suggestion;

				private string type;

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
			}

			public class GetMediaAuditResult_VideoResult
			{

				private string label;

				private string suggestion;

				private GetMediaAuditResult_PornResult pornResult;

				private GetMediaAuditResult_AdResult adResult;

				private GetMediaAuditResult_LogoResult logoResult;

				private GetMediaAuditResult_LiveResult liveResult;

				private GetMediaAuditResult_TerrorismResult terrorismResult;

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

				public GetMediaAuditResult_PornResult PornResult
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

				public GetMediaAuditResult_AdResult AdResult
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

				public GetMediaAuditResult_LogoResult LogoResult
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

				public GetMediaAuditResult_LiveResult LiveResult
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

				public GetMediaAuditResult_TerrorismResult TerrorismResult
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

				public class GetMediaAuditResult_PornResult
				{

					private string averageScore;

					private string label;

					private string maxScore;

					private string suggestion;

					private List<GetMediaAuditResult_CounterListItem> counterList;

					private List<GetMediaAuditResult_TopListItem> topList;

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

					public List<GetMediaAuditResult_CounterListItem> CounterList
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

					public List<GetMediaAuditResult_TopListItem> TopList
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

					public class GetMediaAuditResult_CounterListItem
					{

						private int? count;

						private string label;

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
					}

					public class GetMediaAuditResult_TopListItem
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

				public class GetMediaAuditResult_AdResult
				{

					private string averageScore;

					private string label;

					private string maxScore;

					private string suggestion;

					private List<GetMediaAuditResult_CounterListItem3> counterList1;

					private List<GetMediaAuditResult_TopListItem4> topList2;

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

					public List<GetMediaAuditResult_CounterListItem3> CounterList1
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

					public List<GetMediaAuditResult_TopListItem4> TopList2
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

					public class GetMediaAuditResult_CounterListItem3
					{

						private int? count;

						private string label;

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
					}

					public class GetMediaAuditResult_TopListItem4
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

				public class GetMediaAuditResult_LogoResult
				{

					private string averageScore;

					private string label;

					private string maxScore;

					private string suggestion;

					private List<GetMediaAuditResult_CounterListItem7> counterList5;

					private List<GetMediaAuditResult_TopListItem8> topList6;

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

					public List<GetMediaAuditResult_CounterListItem7> CounterList5
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

					public List<GetMediaAuditResult_TopListItem8> TopList6
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

					public class GetMediaAuditResult_CounterListItem7
					{

						private int? count;

						private string label;

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
					}

					public class GetMediaAuditResult_TopListItem8
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

				public class GetMediaAuditResult_LiveResult
				{

					private string averageScore;

					private string label;

					private string maxScore;

					private string suggestion;

					private List<GetMediaAuditResult_CounterListItem11> counterList9;

					private List<GetMediaAuditResult_TopListItem12> topList10;

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

					public List<GetMediaAuditResult_CounterListItem11> CounterList9
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

					public List<GetMediaAuditResult_TopListItem12> TopList10
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

					public class GetMediaAuditResult_CounterListItem11
					{

						private int? count;

						private string label;

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
					}

					public class GetMediaAuditResult_TopListItem12
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

				public class GetMediaAuditResult_TerrorismResult
				{

					private string averageScore;

					private string label;

					private string maxScore;

					private string suggestion;

					private List<GetMediaAuditResult_CounterListItem15> counterList13;

					private List<GetMediaAuditResult_TopListItem16> topList14;

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

					public List<GetMediaAuditResult_CounterListItem15> CounterList13
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

					public List<GetMediaAuditResult_TopListItem16> TopList14
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

					public class GetMediaAuditResult_CounterListItem15
					{

						private int? count;

						private string label;

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
					}

					public class GetMediaAuditResult_TopListItem16
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
