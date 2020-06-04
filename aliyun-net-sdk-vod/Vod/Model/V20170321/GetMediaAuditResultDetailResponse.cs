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
	public class GetMediaAuditResultDetailResponse : AcsResponse
	{

		private string requestId;

		private GetMediaAuditResultDetail_MediaAuditResultDetail mediaAuditResultDetail;

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

		public GetMediaAuditResultDetail_MediaAuditResultDetail MediaAuditResultDetail
		{
			get
			{
				return mediaAuditResultDetail;
			}
			set	
			{
				mediaAuditResultDetail = value;
			}
		}

		public class GetMediaAuditResultDetail_MediaAuditResultDetail
		{

			private int? total;

			private List<GetMediaAuditResultDetail_ListItem> list;

			public int? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public List<GetMediaAuditResultDetail_ListItem> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class GetMediaAuditResultDetail_ListItem
			{

				private string pornLabel;

				private string pornScore;

				private string terrorismLabel;

				private string terrorismScore;

				private string timestamp;

				private string url;

				private string adLabel;

				private string adScore;

				private string liveLabel;

				private string liveScore;

				private string logoLabel;

				private string logoScore;

				public string PornLabel
				{
					get
					{
						return pornLabel;
					}
					set	
					{
						pornLabel = value;
					}
				}

				public string PornScore
				{
					get
					{
						return pornScore;
					}
					set	
					{
						pornScore = value;
					}
				}

				public string TerrorismLabel
				{
					get
					{
						return terrorismLabel;
					}
					set	
					{
						terrorismLabel = value;
					}
				}

				public string TerrorismScore
				{
					get
					{
						return terrorismScore;
					}
					set	
					{
						terrorismScore = value;
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

				public string AdLabel
				{
					get
					{
						return adLabel;
					}
					set	
					{
						adLabel = value;
					}
				}

				public string AdScore
				{
					get
					{
						return adScore;
					}
					set	
					{
						adScore = value;
					}
				}

				public string LiveLabel
				{
					get
					{
						return liveLabel;
					}
					set	
					{
						liveLabel = value;
					}
				}

				public string LiveScore
				{
					get
					{
						return liveScore;
					}
					set	
					{
						liveScore = value;
					}
				}

				public string LogoLabel
				{
					get
					{
						return logoLabel;
					}
					set	
					{
						logoLabel = value;
					}
				}

				public string LogoScore
				{
					get
					{
						return logoScore;
					}
					set	
					{
						logoScore = value;
					}
				}
			}
		}
	}
}
