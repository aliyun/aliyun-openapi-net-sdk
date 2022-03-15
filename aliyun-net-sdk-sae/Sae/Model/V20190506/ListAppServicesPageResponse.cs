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
	public class ListAppServicesPageResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private string traceId;

		private string errorCode;

		private string code;

		private bool? success;

		private List<ListAppServicesPage_DataItem> data;

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

		public List<ListAppServicesPage_DataItem> Data
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

		public class ListAppServicesPage_DataItem
		{

			private string currentPage;

			private string totalSize;

			private string pageNumber;

			private string pageSize;

			private List<ListAppServicesPage_MscAgentServiceResponse> result;

			public string CurrentPage
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

			public string TotalSize
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

			public string PageNumber
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

			public string PageSize
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

			public List<ListAppServicesPage_MscAgentServiceResponse> Result
			{
				get
				{
					return result;
				}
				set	
				{
					result = value;
				}
			}

			public class ListAppServicesPage_MscAgentServiceResponse
			{

				private string edasAppName;

				private string version;

				private long? instanceNum;

				private string edasAppId;

				private string serviceName;

				private string group;

				public string EdasAppName
				{
					get
					{
						return edasAppName;
					}
					set	
					{
						edasAppName = value;
					}
				}

				public string Version
				{
					get
					{
						return version;
					}
					set	
					{
						version = value;
					}
				}

				public long? InstanceNum
				{
					get
					{
						return instanceNum;
					}
					set	
					{
						instanceNum = value;
					}
				}

				public string EdasAppId
				{
					get
					{
						return edasAppId;
					}
					set	
					{
						edasAppId = value;
					}
				}

				public string ServiceName
				{
					get
					{
						return serviceName;
					}
					set	
					{
						serviceName = value;
					}
				}

				public string Group
				{
					get
					{
						return group;
					}
					set	
					{
						group = value;
					}
				}
			}
		}
	}
}
