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

namespace Aliyun.Acs.CSB.Model.V20171118
{
	public class FindInstanceNodeListResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private FindInstanceNodeList_Data data;

		public int? Code
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

		public FindInstanceNodeList_Data Data
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

		public class FindInstanceNodeList_Data
		{

			private int? currentPage;

			private int? pageNumber;

			private List<FindInstanceNodeList_InstanceNode> instanceNodeList;

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

			public int? PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
				}
			}

			public List<FindInstanceNodeList_InstanceNode> InstanceNodeList
			{
				get
				{
					return instanceNodeList;
				}
				set	
				{
					instanceNodeList = value;
				}
			}

			public class FindInstanceNodeList_InstanceNode
			{

				private long? id;

				private string instanceName;

				private bool? isImported;

				private string groupAddress;

				private string brokerAddress;

				private string edasTenantInfo;

				private string importedName;

				public long? Id
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

				public bool? IsImported
				{
					get
					{
						return isImported;
					}
					set	
					{
						isImported = value;
					}
				}

				public string GroupAddress
				{
					get
					{
						return groupAddress;
					}
					set	
					{
						groupAddress = value;
					}
				}

				public string BrokerAddress
				{
					get
					{
						return brokerAddress;
					}
					set	
					{
						brokerAddress = value;
					}
				}

				public string EdasTenantInfo
				{
					get
					{
						return edasTenantInfo;
					}
					set	
					{
						edasTenantInfo = value;
					}
				}

				public string ImportedName
				{
					get
					{
						return importedName;
					}
					set	
					{
						importedName = value;
					}
				}
			}
		}
	}
}
