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
	public class GetOcCompetitorsResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private int? totalNum;

		private int? pageIndex;

		private int? pageNum;

		private string requestId;

		private List<GetOcCompetitors_DataItem> data;

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

		public List<GetOcCompetitors_DataItem> Data
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

		public class GetOcCompetitors_DataItem
		{

			private string entName;

			private string competitionProductName;

			private string competitionEntName;

			private string competitionWebsite;

			private string competitionTag;

			private string competitionLogoUrl;

			private string competitionIntroduction;

			private string competitionBrandIntroduction;

			private string competitionEntFinTurn;

			private string competitionEntAddress;

			private string competitionEntEsDate;

			public string EntName
			{
				get
				{
					return entName;
				}
				set	
				{
					entName = value;
				}
			}

			public string CompetitionProductName
			{
				get
				{
					return competitionProductName;
				}
				set	
				{
					competitionProductName = value;
				}
			}

			public string CompetitionEntName
			{
				get
				{
					return competitionEntName;
				}
				set	
				{
					competitionEntName = value;
				}
			}

			public string CompetitionWebsite
			{
				get
				{
					return competitionWebsite;
				}
				set	
				{
					competitionWebsite = value;
				}
			}

			public string CompetitionTag
			{
				get
				{
					return competitionTag;
				}
				set	
				{
					competitionTag = value;
				}
			}

			public string CompetitionLogoUrl
			{
				get
				{
					return competitionLogoUrl;
				}
				set	
				{
					competitionLogoUrl = value;
				}
			}

			public string CompetitionIntroduction
			{
				get
				{
					return competitionIntroduction;
				}
				set	
				{
					competitionIntroduction = value;
				}
			}

			public string CompetitionBrandIntroduction
			{
				get
				{
					return competitionBrandIntroduction;
				}
				set	
				{
					competitionBrandIntroduction = value;
				}
			}

			public string CompetitionEntFinTurn
			{
				get
				{
					return competitionEntFinTurn;
				}
				set	
				{
					competitionEntFinTurn = value;
				}
			}

			public string CompetitionEntAddress
			{
				get
				{
					return competitionEntAddress;
				}
				set	
				{
					competitionEntAddress = value;
				}
			}

			public string CompetitionEntEsDate
			{
				get
				{
					return competitionEntEsDate;
				}
				set	
				{
					competitionEntEsDate = value;
				}
			}
		}
	}
}
