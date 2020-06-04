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
	public class GetMediaAuditAudioResultDetailResponse : AcsResponse
	{

		private string requestId;

		private GetMediaAuditAudioResultDetail_MediaAuditAudioResultDetail mediaAuditAudioResultDetail;

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

		public GetMediaAuditAudioResultDetail_MediaAuditAudioResultDetail MediaAuditAudioResultDetail
		{
			get
			{
				return mediaAuditAudioResultDetail;
			}
			set	
			{
				mediaAuditAudioResultDetail = value;
			}
		}

		public class GetMediaAuditAudioResultDetail_MediaAuditAudioResultDetail
		{

			private int? total;

			private int? pageTotal;

			private List<GetMediaAuditAudioResultDetail_ListItem> list;

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

			public int? PageTotal
			{
				get
				{
					return pageTotal;
				}
				set	
				{
					pageTotal = value;
				}
			}

			public List<GetMediaAuditAudioResultDetail_ListItem> List
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

			public class GetMediaAuditAudioResultDetail_ListItem
			{

				private long? startTime;

				private long? endTime;

				private string text;

				private string label;

				public long? StartTime
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

				public long? EndTime
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
		}
	}
}
