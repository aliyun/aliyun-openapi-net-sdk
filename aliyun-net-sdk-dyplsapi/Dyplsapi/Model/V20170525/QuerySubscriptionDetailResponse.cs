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

namespace Aliyun.Acs.Dyplsapi.Model.V20170525
{
	public class QuerySubscriptionDetailResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private QuerySubscriptionDetail_SecretBindDetailDTO secretBindDetailDTO;

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

		public QuerySubscriptionDetail_SecretBindDetailDTO SecretBindDetailDTO
		{
			get
			{
				return secretBindDetailDTO;
			}
			set	
			{
				secretBindDetailDTO = value;
			}
		}

		public class QuerySubscriptionDetail_SecretBindDetailDTO
		{

			private long? status;

			private string extension;

			private string phoneNoB;

			private long? groupId;

			private bool? needRecord;

			private bool? aSRStatus;

			private string gmtCreate;

			private string expireDate;

			private string subsId;

			private string phoneNoX;

			private string callRestrict;

			private string aSRModelId;

			private string phoneNoA;

			public long? Status
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

			public string Extension
			{
				get
				{
					return extension;
				}
				set	
				{
					extension = value;
				}
			}

			public string PhoneNoB
			{
				get
				{
					return phoneNoB;
				}
				set	
				{
					phoneNoB = value;
				}
			}

			public long? GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public bool? NeedRecord
			{
				get
				{
					return needRecord;
				}
				set	
				{
					needRecord = value;
				}
			}

			public bool? ASRStatus
			{
				get
				{
					return aSRStatus;
				}
				set	
				{
					aSRStatus = value;
				}
			}

			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public string ExpireDate
			{
				get
				{
					return expireDate;
				}
				set	
				{
					expireDate = value;
				}
			}

			public string SubsId
			{
				get
				{
					return subsId;
				}
				set	
				{
					subsId = value;
				}
			}

			public string PhoneNoX
			{
				get
				{
					return phoneNoX;
				}
				set	
				{
					phoneNoX = value;
				}
			}

			public string CallRestrict
			{
				get
				{
					return callRestrict;
				}
				set	
				{
					callRestrict = value;
				}
			}

			public string ASRModelId
			{
				get
				{
					return aSRModelId;
				}
				set	
				{
					aSRModelId = value;
				}
			}

			public string PhoneNoA
			{
				get
				{
					return phoneNoA;
				}
				set	
				{
					phoneNoA = value;
				}
			}
		}
	}
}
