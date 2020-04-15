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
	public class QueryIntentionDetailResponse : AcsResponse
	{

		private string requestId;

		private string userId;

		private string registerNumber;

		private string classification;

		private int? type;

		private string bizId;

		private string description;

		private int? status;

		private long? updateTime;

		private long? createTime;

		private string mobile;

		private string userName;

		private string relationBizId;

		private string partnerMobile;

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

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
			}
		}

		public string RegisterNumber
		{
			get
			{
				return registerNumber;
			}
			set	
			{
				registerNumber = value;
			}
		}

		public string Classification
		{
			get
			{
				return classification;
			}
			set	
			{
				classification = value;
			}
		}

		public int? Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
			}
		}

		public string BizId
		{
			get
			{
				return bizId;
			}
			set	
			{
				bizId = value;
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
			}
		}

		public int? Status
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

		public long? UpdateTime
		{
			get
			{
				return updateTime;
			}
			set	
			{
				updateTime = value;
			}
		}

		public long? CreateTime
		{
			get
			{
				return createTime;
			}
			set	
			{
				createTime = value;
			}
		}

		public string Mobile
		{
			get
			{
				return mobile;
			}
			set	
			{
				mobile = value;
			}
		}

		public string UserName
		{
			get
			{
				return userName;
			}
			set	
			{
				userName = value;
			}
		}

		public string RelationBizId
		{
			get
			{
				return relationBizId;
			}
			set	
			{
				relationBizId = value;
			}
		}

		public string PartnerMobile
		{
			get
			{
				return partnerMobile;
			}
			set	
			{
				partnerMobile = value;
			}
		}
	}
}
