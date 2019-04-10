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

namespace Aliyun.Acs.Dm.Model.V20170622
{
	public class DescDomainResponse : AcsResponse
	{

		private string requestId;

		private string domainId;

		private string domainName;

		private string domainType;

		private string domainStatus;

		private string cnameRecord;

		private string cnameConfirmStatus;

		private string spfAuthStatus;

		private string mxAuthStatus;

		private string defaultDomain;

		private string createTime;

		private string cnameAuthStatus;

		private string icpStatus;

		private string spfRecord;

		private string mxRecord;

		private string tracefRecord;

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

		public string DomainType
		{
			get
			{
				return domainType;
			}
			set	
			{
				domainType = value;
			}
		}

		public string DomainStatus
		{
			get
			{
				return domainStatus;
			}
			set	
			{
				domainStatus = value;
			}
		}

		public string CnameRecord
		{
			get
			{
				return cnameRecord;
			}
			set	
			{
				cnameRecord = value;
			}
		}

		public string CnameConfirmStatus
		{
			get
			{
				return cnameConfirmStatus;
			}
			set	
			{
				cnameConfirmStatus = value;
			}
		}

		public string SpfAuthStatus
		{
			get
			{
				return spfAuthStatus;
			}
			set	
			{
				spfAuthStatus = value;
			}
		}

		public string MxAuthStatus
		{
			get
			{
				return mxAuthStatus;
			}
			set	
			{
				mxAuthStatus = value;
			}
		}

		public string DefaultDomain
		{
			get
			{
				return defaultDomain;
			}
			set	
			{
				defaultDomain = value;
			}
		}

		public string CreateTime
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

		public string CnameAuthStatus
		{
			get
			{
				return cnameAuthStatus;
			}
			set	
			{
				cnameAuthStatus = value;
			}
		}

		public string IcpStatus
		{
			get
			{
				return icpStatus;
			}
			set	
			{
				icpStatus = value;
			}
		}

		public string SpfRecord
		{
			get
			{
				return spfRecord;
			}
			set	
			{
				spfRecord = value;
			}
		}

		public string MxRecord
		{
			get
			{
				return mxRecord;
			}
			set	
			{
				mxRecord = value;
			}
		}

		public string TracefRecord
		{
			get
			{
				return tracefRecord;
			}
			set	
			{
				tracefRecord = value;
			}
		}
	}
}
