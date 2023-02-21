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

namespace Aliyun.Acs.dt_oc_info.Model.V20220829
{
	public class GetOcJusticeCourtAnnouncementResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private int? totalNum;

		private int? pageIndex;

		private int? pageNum;

		private string requestId;

		private List<GetOcJusticeCourtAnnouncement_DataItem> data;

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

		public int? TotalNum
		{
			get
			{
				return totalNum;
			}
			set	
			{
				totalNum = value;
			}
		}

		public int? PageIndex
		{
			get
			{
				return pageIndex;
			}
			set	
			{
				pageIndex = value;
			}
		}

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
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

		public List<GetOcJusticeCourtAnnouncement_DataItem> Data
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

		public class GetOcJusticeCourtAnnouncement_DataItem
		{

			private string causeAction;

			private string caseNum;

			private string hearingDate;

			private string department;

			private string court;

			private string tribunal;

			private string judge;

			private string title;

			private string party;

			public string CauseAction
			{
				get
				{
					return causeAction;
				}
				set	
				{
					causeAction = value;
				}
			}

			public string CaseNum
			{
				get
				{
					return caseNum;
				}
				set	
				{
					caseNum = value;
				}
			}

			public string HearingDate
			{
				get
				{
					return hearingDate;
				}
				set	
				{
					hearingDate = value;
				}
			}

			public string Department
			{
				get
				{
					return department;
				}
				set	
				{
					department = value;
				}
			}

			public string Court
			{
				get
				{
					return court;
				}
				set	
				{
					court = value;
				}
			}

			public string Tribunal
			{
				get
				{
					return tribunal;
				}
				set	
				{
					tribunal = value;
				}
			}

			public string Judge
			{
				get
				{
					return judge;
				}
				set	
				{
					judge = value;
				}
			}

			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			public string Party
			{
				get
				{
					return party;
				}
				set	
				{
					party = value;
				}
			}
		}
	}
}
