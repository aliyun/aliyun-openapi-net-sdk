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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class ListOTAJobByFirmwareResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private int? total;

		private int? pageSize;

		private int? pageCount;

		private int? currentPage;

		private List<ListOTAJobByFirmware_SimpleOTAJobInfo> data;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
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

		public int? PageCount
		{
			get
			{
				return pageCount;
			}
			set	
			{
				pageCount = value;
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

		public List<ListOTAJobByFirmware_SimpleOTAJobInfo> Data
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

		public class ListOTAJobByFirmware_SimpleOTAJobInfo
		{

			private string jobId;

			private string utcCreate;

			private string utcModified;

			private string productKey;

			private string firmwareId;

			private string utcStartTime;

			private string utcEndTime;

			private string jobStatus;

			private string jobType;

			private string targetSelection;

			private string selectionType;

			private List<ListOTAJobByFirmware_OtaTagDTO> tags;

			public string JobId
			{
				get
				{
					return jobId;
				}
				set	
				{
					jobId = value;
				}
			}

			public string UtcCreate
			{
				get
				{
					return utcCreate;
				}
				set	
				{
					utcCreate = value;
				}
			}

			public string UtcModified
			{
				get
				{
					return utcModified;
				}
				set	
				{
					utcModified = value;
				}
			}

			public string ProductKey
			{
				get
				{
					return productKey;
				}
				set	
				{
					productKey = value;
				}
			}

			public string FirmwareId
			{
				get
				{
					return firmwareId;
				}
				set	
				{
					firmwareId = value;
				}
			}

			public string UtcStartTime
			{
				get
				{
					return utcStartTime;
				}
				set	
				{
					utcStartTime = value;
				}
			}

			public string UtcEndTime
			{
				get
				{
					return utcEndTime;
				}
				set	
				{
					utcEndTime = value;
				}
			}

			public string JobStatus
			{
				get
				{
					return jobStatus;
				}
				set	
				{
					jobStatus = value;
				}
			}

			public string JobType
			{
				get
				{
					return jobType;
				}
				set	
				{
					jobType = value;
				}
			}

			public string TargetSelection
			{
				get
				{
					return targetSelection;
				}
				set	
				{
					targetSelection = value;
				}
			}

			public string SelectionType
			{
				get
				{
					return selectionType;
				}
				set	
				{
					selectionType = value;
				}
			}

			public List<ListOTAJobByFirmware_OtaTagDTO> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public class ListOTAJobByFirmware_OtaTagDTO
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}
