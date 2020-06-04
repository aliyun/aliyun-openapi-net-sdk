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
	public class GetMediaAuditResultTimelineResponse : AcsResponse
	{

		private string requestId;

		private GetMediaAuditResultTimeline_MediaAuditResultTimeline mediaAuditResultTimeline;

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

		public GetMediaAuditResultTimeline_MediaAuditResultTimeline MediaAuditResultTimeline
		{
			get
			{
				return mediaAuditResultTimeline;
			}
			set	
			{
				mediaAuditResultTimeline = value;
			}
		}

		public class GetMediaAuditResultTimeline_MediaAuditResultTimeline
		{

			private List<GetMediaAuditResultTimeline_PornItem> porn;

			private List<GetMediaAuditResultTimeline_TerrorismItem> terrorism;

			private List<GetMediaAuditResultTimeline_LogoItem> logo;

			private List<GetMediaAuditResultTimeline_LiveItem> live;

			private List<GetMediaAuditResultTimeline_AdItem> ad;

			public List<GetMediaAuditResultTimeline_PornItem> Porn
			{
				get
				{
					return porn;
				}
				set	
				{
					porn = value;
				}
			}

			public List<GetMediaAuditResultTimeline_TerrorismItem> Terrorism
			{
				get
				{
					return terrorism;
				}
				set	
				{
					terrorism = value;
				}
			}

			public List<GetMediaAuditResultTimeline_LogoItem> Logo
			{
				get
				{
					return logo;
				}
				set	
				{
					logo = value;
				}
			}

			public List<GetMediaAuditResultTimeline_LiveItem> Live
			{
				get
				{
					return live;
				}
				set	
				{
					live = value;
				}
			}

			public List<GetMediaAuditResultTimeline_AdItem> Ad
			{
				get
				{
					return ad;
				}
				set	
				{
					ad = value;
				}
			}

			public class GetMediaAuditResultTimeline_PornItem
			{

				private string label;

				private string score;

				private string timestamp;

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
			}

			public class GetMediaAuditResultTimeline_TerrorismItem
			{

				private string label;

				private string score;

				private string timestamp;

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
			}

			public class GetMediaAuditResultTimeline_LogoItem
			{

				private string label;

				private string score;

				private string timestamp;

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
			}

			public class GetMediaAuditResultTimeline_LiveItem
			{

				private string label;

				private string score;

				private string timestamp;

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
			}

			public class GetMediaAuditResultTimeline_AdItem
			{

				private string label;

				private string score;

				private string timestamp;

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
			}
		}
	}
}
