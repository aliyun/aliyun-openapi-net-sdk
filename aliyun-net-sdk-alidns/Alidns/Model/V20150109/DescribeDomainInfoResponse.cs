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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class DescribeDomainInfoResponse : AcsResponse
	{

		private string domainId;

		private string domainName;

		private string punyCode;

		private bool? aliDomain;

		private string registrantEmail;

		private string groupId;

		private string groupName;

		private string instanceId;

		private string versionCode;

		private string versionName;

		private List<string> dnsServers;

		public string DomainId
		{
			get
			{
				return domainId;
			}
			set	
			{
				domainId = value;
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
			}
		}

		public string PunyCode
		{
			get
			{
				return punyCode;
			}
			set	
			{
				punyCode = value;
			}
		}

		public bool? AliDomain
		{
			get
			{
				return aliDomain;
			}
			set	
			{
				aliDomain = value;
			}
		}

		public string RegistrantEmail
		{
			get
			{
				return registrantEmail;
			}
			set	
			{
				registrantEmail = value;
			}
		}

		public string GroupId
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

		public string GroupName
		{
			get
			{
				return groupName;
			}
			set	
			{
				groupName = value;
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
			}
		}

		public string VersionCode
		{
			get
			{
				return versionCode;
			}
			set	
			{
				versionCode = value;
			}
		}

		public string VersionName
		{
			get
			{
				return versionName;
			}
			set	
			{
				versionName = value;
			}
		}

		public List<string> DnsServers
		{
			get
			{
				return dnsServers;
			}
			set	
			{
				dnsServers = value;
			}
		}
	}
}