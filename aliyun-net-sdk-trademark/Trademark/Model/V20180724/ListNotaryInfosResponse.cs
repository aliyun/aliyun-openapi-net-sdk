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

namespace Aliyun.Acs.Trademark.Model.V20180724
{
	public class ListNotaryInfosResponse : AcsResponse
	{

		private string requestId;

		private int? totalItemNum;

		private int? currentPageNum;

		private int? pageSize;

		private int? totalPageNum;

		private bool? prePage;

		private bool? nextPage;

		private bool? success;

		private string errorMsg;

		private string errorCode;

		private List<ListNotaryInfos_NotaryInfo> data;

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

		public int? TotalItemNum
		{
			get
			{
				return totalItemNum;
			}
			set	
			{
				totalItemNum = value;
			}
		}

		public int? CurrentPageNum
		{
			get
			{
				return currentPageNum;
			}
			set	
			{
				currentPageNum = value;
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

		public int? TotalPageNum
		{
			get
			{
				return totalPageNum;
			}
			set	
			{
				totalPageNum = value;
			}
		}

		public bool? PrePage
		{
			get
			{
				return prePage;
			}
			set	
			{
				prePage = value;
			}
		}

		public bool? NextPage
		{
			get
			{
				return nextPage;
			}
			set	
			{
				nextPage = value;
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

		public string ErrorMsg
		{
			get
			{
				return errorMsg;
			}
			set	
			{
				errorMsg = value;
			}
		}

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public List<ListNotaryInfos_NotaryInfo> Data
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

		public class ListNotaryInfos_NotaryInfo
		{

			private string bizOrderNo;

			private string token;

			private int? notaryStatus;

			private string tmRegisterNo;

			private string tmClassification;

			private long? gmtModified;

			private string notaryFailedReason;

			public string BizOrderNo
			{
				get
				{
					return bizOrderNo;
				}
				set	
				{
					bizOrderNo = value;
				}
			}

			public string Token
			{
				get
				{
					return token;
				}
				set	
				{
					token = value;
				}
			}

			public int? NotaryStatus
			{
				get
				{
					return notaryStatus;
				}
				set	
				{
					notaryStatus = value;
				}
			}

			public string TmRegisterNo
			{
				get
				{
					return tmRegisterNo;
				}
				set	
				{
					tmRegisterNo = value;
				}
			}

			public string TmClassification
			{
				get
				{
					return tmClassification;
				}
				set	
				{
					tmClassification = value;
				}
			}

			public long? GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string NotaryFailedReason
			{
				get
				{
					return notaryFailedReason;
				}
				set	
				{
					notaryFailedReason = value;
				}
			}
		}
	}
}
