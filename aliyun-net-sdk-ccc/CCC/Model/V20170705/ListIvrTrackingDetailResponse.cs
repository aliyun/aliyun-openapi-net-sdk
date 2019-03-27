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

namespace Aliyun.Acs.CCC.Model.V20170705
{
	public class ListIvrTrackingDetailResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private ListIvrTrackingDetail_IvrTrackingDetails ivrTrackingDetails;

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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public ListIvrTrackingDetail_IvrTrackingDetails IvrTrackingDetails
		{
			get
			{
				return ivrTrackingDetails;
			}
			set	
			{
				ivrTrackingDetails = value;
			}
		}

		public class ListIvrTrackingDetail_IvrTrackingDetails
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

			private List<ListIvrTrackingDetail_IvrTrackingDetail> list;

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

			public List<ListIvrTrackingDetail_IvrTrackingDetail> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class ListIvrTrackingDetail_IvrTrackingDetail
			{

				private string flowName;

				private string nodeName;

				private string nodeType;

				private string contactId;

				private string callingNumber;

				private string calledNumber;

				private long? startTime;

				private long? stopTime;

				private string status;

				private string inputData;

				private string outputData;

				private string description;

				private string deviceID;

				private string tenantId;

				public string FlowName
				{
					get
					{
						return flowName;
					}
					set	
					{
						flowName = value;
					}
				}

				public string NodeName
				{
					get
					{
						return nodeName;
					}
					set	
					{
						nodeName = value;
					}
				}

				public string NodeType
				{
					get
					{
						return nodeType;
					}
					set	
					{
						nodeType = value;
					}
				}

				public string ContactId
				{
					get
					{
						return contactId;
					}
					set	
					{
						contactId = value;
					}
				}

				public string CallingNumber
				{
					get
					{
						return callingNumber;
					}
					set	
					{
						callingNumber = value;
					}
				}

				public string CalledNumber
				{
					get
					{
						return calledNumber;
					}
					set	
					{
						calledNumber = value;
					}
				}

				public long? StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				public long? StopTime
				{
					get
					{
						return stopTime;
					}
					set	
					{
						stopTime = value;
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

				public string InputData
				{
					get
					{
						return inputData;
					}
					set	
					{
						inputData = value;
					}
				}

				public string OutputData
				{
					get
					{
						return outputData;
					}
					set	
					{
						outputData = value;
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

				public string DeviceID
				{
					get
					{
						return deviceID;
					}
					set	
					{
						deviceID = value;
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
			}
		}
	}
}
