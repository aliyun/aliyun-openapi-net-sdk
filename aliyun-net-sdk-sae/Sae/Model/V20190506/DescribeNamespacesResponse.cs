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

namespace Aliyun.Acs.sae.Model.V20190506
{
	public class DescribeNamespacesResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private string traceId;

		private string errorCode;

		private string code;

		private bool? success;

		private DescribeNamespaces_Data data;

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

		public string TraceId
		{
			get
			{
				return traceId;
			}
			set	
			{
				traceId = value;
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

		public DescribeNamespaces_Data Data
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

		public class DescribeNamespaces_Data
		{

			private int? currentPage;

			private int? totalSize;

			private int? pageSize;

			private List<DescribeNamespaces__Namespace> namespaces;

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

			public int? TotalSize
			{
				get
				{
					return totalSize;
				}
				set	
				{
					totalSize = value;
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

			public List<DescribeNamespaces__Namespace> Namespaces
			{
				get
				{
					return namespaces;
				}
				set	
				{
					namespaces = value;
				}
			}

			public class DescribeNamespaces__Namespace
			{

				private string namespaceDescription;

				private string accessKey;

				private string secretKey;

				private string namespaceId;

				private string addressServerHost;

				private string namespaceName;

				private string tenantId;

				private string regionId;

				public string NamespaceDescription
				{
					get
					{
						return namespaceDescription;
					}
					set	
					{
						namespaceDescription = value;
					}
				}

				public string AccessKey
				{
					get
					{
						return accessKey;
					}
					set	
					{
						accessKey = value;
					}
				}

				public string SecretKey
				{
					get
					{
						return secretKey;
					}
					set	
					{
						secretKey = value;
					}
				}

				public string NamespaceId
				{
					get
					{
						return namespaceId;
					}
					set	
					{
						namespaceId = value;
					}
				}

				public string AddressServerHost
				{
					get
					{
						return addressServerHost;
					}
					set	
					{
						addressServerHost = value;
					}
				}

				public string NamespaceName
				{
					get
					{
						return namespaceName;
					}
					set	
					{
						namespaceName = value;
					}
				}

				public string TenantId
				{
					get
					{
						return tenantId;
					}
					set	
					{
						tenantId = value;
					}
				}

				public string RegionId
				{
					get
					{
						return regionId;
					}
					set	
					{
						regionId = value;
					}
				}
			}
		}
	}
}
