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
	public class GetOcIpPatentResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private int? totalNum;

		private int? pageIndex;

		private int? pageNum;

		private string requestId;

		private List<GetOcIpPatent_DataItem> data;

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

		public List<GetOcIpPatent_DataItem> Data
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

		public class GetOcIpPatent_DataItem
		{

			private string entName;

			private string patentType;

			private string patentName;

			private string patentStatus;

			private string requestNum;

			private string requestDate;

			private string publicNum;

			private string publicDate;

			private string inventorList;

			private string patenteeList;

			private string cateNum;

			private string prioNum;

			private string prioDate;

			private string agency;

			private string agent;

			private string brief;

			private string mainClaim;

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

			public string PatentType
			{
				get
				{
					return patentType;
				}
				set	
				{
					patentType = value;
				}
			}

			public string PatentName
			{
				get
				{
					return patentName;
				}
				set	
				{
					patentName = value;
				}
			}

			public string PatentStatus
			{
				get
				{
					return patentStatus;
				}
				set	
				{
					patentStatus = value;
				}
			}

			public string RequestNum
			{
				get
				{
					return requestNum;
				}
				set	
				{
					requestNum = value;
				}
			}

			public string RequestDate
			{
				get
				{
					return requestDate;
				}
				set	
				{
					requestDate = value;
				}
			}

			public string PublicNum
			{
				get
				{
					return publicNum;
				}
				set	
				{
					publicNum = value;
				}
			}

			public string PublicDate
			{
				get
				{
					return publicDate;
				}
				set	
				{
					publicDate = value;
				}
			}

			public string InventorList
			{
				get
				{
					return inventorList;
				}
				set	
				{
					inventorList = value;
				}
			}

			public string PatenteeList
			{
				get
				{
					return patenteeList;
				}
				set	
				{
					patenteeList = value;
				}
			}

			public string CateNum
			{
				get
				{
					return cateNum;
				}
				set	
				{
					cateNum = value;
				}
			}

			public string PrioNum
			{
				get
				{
					return prioNum;
				}
				set	
				{
					prioNum = value;
				}
			}

			public string PrioDate
			{
				get
				{
					return prioDate;
				}
				set	
				{
					prioDate = value;
				}
			}

			public string Agency
			{
				get
				{
					return agency;
				}
				set	
				{
					agency = value;
				}
			}

			public string Agent
			{
				get
				{
					return agent;
				}
				set	
				{
					agent = value;
				}
			}

			public string Brief
			{
				get
				{
					return brief;
				}
				set	
				{
					brief = value;
				}
			}

			public string MainClaim
			{
				get
				{
					return mainClaim;
				}
				set	
				{
					mainClaim = value;
				}
			}
		}
	}
}
