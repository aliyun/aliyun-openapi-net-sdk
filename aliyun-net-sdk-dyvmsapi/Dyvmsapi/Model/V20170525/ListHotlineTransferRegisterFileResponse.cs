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

namespace Aliyun.Acs.Dyvmsapi.Model.V20170525
{
	public class ListHotlineTransferRegisterFileResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private ListHotlineTransferRegisterFile_Data data;

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

		public ListHotlineTransferRegisterFile_Data Data
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

		public class ListHotlineTransferRegisterFile_Data
		{

			private long? total;

			private int? pageNo;

			private int? pageSize;

			private List<ListHotlineTransferRegisterFile_ValuesItem> values;

			public long? Total
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

			public int? PageNo
			{
				get
				{
					return pageNo;
				}
				set	
				{
					pageNo = value;
				}
			}

			public int? PageSize
			{
				get
				{
					return pageSize;
				}
				set	
				{
					pageSize = value;
				}
			}

			public List<ListHotlineTransferRegisterFile_ValuesItem> Values
			{
				get
				{
					return values;
				}
				set	
				{
					values = value;
				}
			}

			public class ListHotlineTransferRegisterFile_ValuesItem
			{

				private string qualificationId;

				private string corpName;

				private string mngOpName;

				private string mngOpMail;

				private string mngOpMobile;

				private string mngOpIdentityCard;

				private string agree;

				private long? resUniqueCode;

				private string hotlineNumber;

				public string QualificationId
				{
					get
					{
						return qualificationId;
					}
					set	
					{
						qualificationId = value;
					}
				}

				public string CorpName
				{
					get
					{
						return corpName;
					}
					set	
					{
						corpName = value;
					}
				}

				public string MngOpName
				{
					get
					{
						return mngOpName;
					}
					set	
					{
						mngOpName = value;
					}
				}

				public string MngOpMail
				{
					get
					{
						return mngOpMail;
					}
					set	
					{
						mngOpMail = value;
					}
				}

				public string MngOpMobile
				{
					get
					{
						return mngOpMobile;
					}
					set	
					{
						mngOpMobile = value;
					}
				}

				public string MngOpIdentityCard
				{
					get
					{
						return mngOpIdentityCard;
					}
					set	
					{
						mngOpIdentityCard = value;
					}
				}

				public string Agree
				{
					get
					{
						return agree;
					}
					set	
					{
						agree = value;
					}
				}

				public long? ResUniqueCode
				{
					get
					{
						return resUniqueCode;
					}
					set	
					{
						resUniqueCode = value;
					}
				}

				public string HotlineNumber
				{
					get
					{
						return hotlineNumber;
					}
					set	
					{
						hotlineNumber = value;
					}
				}
			}
		}
	}
}
