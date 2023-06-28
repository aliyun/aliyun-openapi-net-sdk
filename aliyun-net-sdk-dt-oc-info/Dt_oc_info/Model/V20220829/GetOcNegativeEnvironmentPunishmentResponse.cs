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
	public class GetOcNegativeEnvironmentPunishmentResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private int? totalNum;

		private int? pageIndex;

		private int? pageNum;

		private string requestId;

		private List<GetOcNegativeEnvironmentPunishment_DataItem> data;

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

		public List<GetOcNegativeEnvironmentPunishment_DataItem> Data
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

		public class GetOcNegativeEnvironmentPunishment_DataItem
		{

			private string entName;

			private string punishNum;

			private string punishLaw;

			private string punishBasis;

			private string punishRes;

			private string department;

			private string punishDate;

			private string execStatus;

			private string punishContent;

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

			public string PunishNum
			{
				get
				{
					return punishNum;
				}
				set	
				{
					punishNum = value;
				}
			}

			public string PunishLaw
			{
				get
				{
					return punishLaw;
				}
				set	
				{
					punishLaw = value;
				}
			}

			public string PunishBasis
			{
				get
				{
					return punishBasis;
				}
				set	
				{
					punishBasis = value;
				}
			}

			public string PunishRes
			{
				get
				{
					return punishRes;
				}
				set	
				{
					punishRes = value;
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

			public string PunishDate
			{
				get
				{
					return punishDate;
				}
				set	
				{
					punishDate = value;
				}
			}

			public string ExecStatus
			{
				get
				{
					return execStatus;
				}
				set	
				{
					execStatus = value;
				}
			}

			public string PunishContent
			{
				get
				{
					return punishContent;
				}
				set	
				{
					punishContent = value;
				}
			}
		}
	}
}
