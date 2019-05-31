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

			public class GetMediaAuditResult_ImageResultItem
			{

				private string suggestion;

				private string label;

				private string type;

				private string url;

				private List<GetMediaAuditResult_ResultItem> result;

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

			public class GetMediaAuditResult_TextResultItem
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

			public class GetMediaAuditResult_VideoResult
			{

				private string suggestion;

				private string label;

				private GetMediaAuditResult_TerrorismResult terrorismResult;

				private GetMediaAuditResult_PornResult pornResult;

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

				public class GetMediaAuditResult_TerrorismResult
				{

					private string suggestion;

					private string label;

					private string maxScore;

					private string averageScore;

					private List<GetMediaAuditResult_CounterListItem> counterList;

					private List<GetMediaAuditResult_TopListItem> topList;

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

				public class GetMediaAuditResult_PornResult
				{

					private string suggestion;

					private string label;

					private string maxScore;

					private string averageScore;

					private List<GetMediaAuditResult_CounterListItem3> counterList1;

					private List<GetMediaAuditResult_TopListItem4> topList2;

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
			}
		}
	}
}
