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

namespace Aliyun.Acs.companyreg.Model.V20201022
{
	public class GetSsoUserInfoResponse : AcsResponse
	{

		private string opsAppKey;

		private string aliUserId;

		private long? ramUserId;

		private string aliUserAccount;

		private string ramUserAccount;

		private string ramUserName;

		private string requestId;

		private int? userType;

		public string OpsAppKey
		{
			get
			{
				return opsAppKey;
			}
			set	
			{
				opsAppKey = value;
			}
		}

		public string AliUserId
		{
			get
			{
				return aliUserId;
			}
			set	
			{
				aliUserId = value;
			}
		}

		public long? RamUserId
		{
			get
			{
				return ramUserId;
			}
			set	
			{
				ramUserId = value;
			}
		}

		public string AliUserAccount
		{
			get
			{
				return aliUserAccount;
			}
			set	
			{
				aliUserAccount = value;
			}
		}

		public string RamUserAccount
		{
			get
			{
				return ramUserAccount;
			}
			set	
			{
				ramUserAccount = value;
			}
		}

		public string RamUserName
		{
			get
			{
				return ramUserName;
			}
			set	
			{
				ramUserName = value;
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

		public int? UserType
		{
			get
			{
				return userType;
			}
			set	
			{
				userType = value;
			}
		}
	}
}
