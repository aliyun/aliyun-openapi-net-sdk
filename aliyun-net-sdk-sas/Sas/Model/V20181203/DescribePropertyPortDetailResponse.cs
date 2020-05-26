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
	public class DescribePropertyPortDetailResponse : AcsResponse
	{

		private string requestId;

		private List<DescribePropertyPortDetail_PropertyPort> propertys;

		private DescribePropertyPortDetail_PageInfo pageInfo;

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

		public List<DescribePropertyPortDetail_PropertyPort> Propertys
		{
			get
			{
				return propertys;
			}
			set	
			{
				propertys = value;
			}
		}

		public DescribePropertyPortDetail_PageInfo PageInfo
		{
			get
			{
				return pageInfo;
			}
			set	
			{
				pageInfo = value;
			}
		}

		public class DescribePropertyPortDetail_PropertyPort
		{

			private string bindIp;

			private string port;

			private string instanceName;

			private string proto;

			private string ip;

			private string create;

			private long? createTimestamp;

			private string procName;

			private string uuid;

			private string instanceId;

			private string intranetIp;

			private string internetIp;

			public string BindIp
			{
				get
				{
					return bindIp;
				}
				set	
				{
					bindIp = value;
				}
			}

			public string Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
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

			public string Proto
			{
				get
				{
					return proto;
				}
				set	
				{
					proto = value;
				}
			}

			public string Ip
			{
				get
				{
					return ip;
				}
				set	
				{
					ip = value;
				}
			}

			public string Create
			{
				get
				{
					return create;
				}
				set	
				{
					create = value;
				}
			}

			public long? CreateTimestamp
			{
				get
				{
					return createTimestamp;
				}
				set	
				{
					createTimestamp = value;
				}
			}

			public string ProcName
			{
				get
				{
					return procName;
				}
				set	
				{
					procName = value;
				}
			}

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
		}

		public class DescribePropertyPortDetail_PageInfo
		{

			private int? count;

			private int? pageSize;

			private int? totalCount;

			private int? currentPage;

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
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
		}
	}
}
