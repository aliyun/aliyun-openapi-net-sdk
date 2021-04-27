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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeWebLockBindListResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribeWebLockBindList_Bind> bindList;

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

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<DescribeWebLockBindList_Bind> BindList
		{
			get
			{
				return bindList;
			}
			set	
			{
				bindList = value;
			}
		}

		public class DescribeWebLockBindList_Bind
		{

			private string uuid;

			private string instanceName;

			private string internetIp;

			private string intranetIp;

			private string os;

			private string dirCount;

			private string serviceStatus;

			private string serviceCode;

			private string serviceDetail;

			private string status;

			private int? percent;

			private string auditCount;

			private string blockCount;

			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public string InternetIp
			{
				get
				{
					return internetIp;
				}
				set	
				{
					internetIp = value;
				}
			}

			public string IntranetIp
			{
				get
				{
					return intranetIp;
				}
				set	
				{
					intranetIp = value;
				}
			}

			public string Os
			{
				get
				{
					return os;
				}
				set	
				{
					os = value;
				}
			}

			public string DirCount
			{
				get
				{
					return dirCount;
				}
				set	
				{
					dirCount = value;
				}
			}

			public string ServiceStatus
			{
				get
				{
					return serviceStatus;
				}
				set	
				{
					serviceStatus = value;
				}
			}

			public string ServiceCode
			{
				get
				{
					return serviceCode;
				}
				set	
				{
					serviceCode = value;
				}
			}

			public string ServiceDetail
			{
				get
				{
					return serviceDetail;
				}
				set	
				{
					serviceDetail = value;
				}
			}

			public string Status
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

			public int? Percent
			{
				get
				{
					return percent;
				}
				set	
				{
					percent = value;
				}
			}

			public string AuditCount
			{
				get
				{
					return auditCount;
				}
				set	
				{
					auditCount = value;
				}
			}

			public string BlockCount
			{
				get
				{
					return blockCount;
				}
				set	
				{
					blockCount = value;
				}
			}
		}
	}
}
