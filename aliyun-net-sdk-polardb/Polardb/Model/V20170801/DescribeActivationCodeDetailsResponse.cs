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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeActivationCodeDetailsResponse : AcsResponse
	{

		private string activateAt;

		private string certContentB64;

		private string description;

		private string expireAt;

		private string gmtCreated;

		private string gmtModified;

		private int? id;

		private string macAddress;

		private string name;

		private string requestId;

		private string systemIdentifier;

		public string ActivateAt
		{
			get
			{
				return activateAt;
			}
			set	
			{
				activateAt = value;
			}
		}

		public string CertContentB64
		{
			get
			{
				return certContentB64;
			}
			set	
			{
				certContentB64 = value;
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

		public string ExpireAt
		{
			get
			{
				return expireAt;
			}
			set	
			{
				expireAt = value;
			}
		}

		public string GmtCreated
		{
			get
			{
				return gmtCreated;
			}
			set	
			{
				gmtCreated = value;
			}
		}

		public string GmtModified
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

		public int? Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
			}
		}

		public string MacAddress
		{
			get
			{
				return macAddress;
			}
			set	
			{
				macAddress = value;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
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

		public string SystemIdentifier
		{
			get
			{
				return systemIdentifier;
			}
			set	
			{
				systemIdentifier = value;
			}
		}
	}
}
