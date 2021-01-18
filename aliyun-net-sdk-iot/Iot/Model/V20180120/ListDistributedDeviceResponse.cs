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
	public class ListDistributedDeviceResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private ListDistributedDevice_Data data;

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

		public ListDistributedDevice_Data Data
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

		public class ListDistributedDevice_Data
		{

			private int? total;

			private List<ListDistributedDevice_Items> info;

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

			public List<ListDistributedDevice_Items> Info
			{
				get
				{
					return info;
				}
				set	
				{
					info = value;
				}
			}

			public class ListDistributedDevice_Items
			{

				private string sourceUid;

				private string targetUid;

				private string productKey;

				private string deviceName;

				private string sourceInstanceId;

				private string targetInstanceId;

				private long? gmtCreate;

				private string targetAliyunId;

				private string sourceRegion;

				private string targetRegion;

				private string sourceInstanceName;

				private string targetInstanceName;

				private long? gmtModified;

				public string SourceUid
				{
					get
					{
						return sourceUid;
					}
					set	
					{
						sourceUid = value;
					}
				}

				public string TargetUid
				{
					get
					{
						return targetUid;
					}
					set	
					{
						targetUid = value;
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

				public string DeviceName
				{
					get
					{
						return deviceName;
					}
					set	
					{
						deviceName = value;
					}
				}

				public string SourceInstanceId
				{
					get
					{
						return sourceInstanceId;
					}
					set	
					{
						sourceInstanceId = value;
					}
				}

				public string TargetInstanceId
				{
					get
					{
						return targetInstanceId;
					}
					set	
					{
						targetInstanceId = value;
					}
				}

				public long? GmtCreate
				{
					get
					{
						return gmtCreate;
					}
					set	
					{
						gmtCreate = value;
					}
				}

				public string TargetAliyunId
				{
					get
					{
						return targetAliyunId;
					}
					set	
					{
						targetAliyunId = value;
					}
				}

				public string SourceRegion
				{
					get
					{
						return sourceRegion;
					}
					set	
					{
						sourceRegion = value;
					}
				}

				public string TargetRegion
				{
					get
					{
						return targetRegion;
					}
					set	
					{
						targetRegion = value;
					}
				}

				public string SourceInstanceName
				{
					get
					{
						return sourceInstanceName;
					}
					set	
					{
						sourceInstanceName = value;
					}
				}

				public string TargetInstanceName
				{
					get
					{
						return targetInstanceName;
					}
					set	
					{
						targetInstanceName = value;
					}
				}

				public long? GmtModified
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
			}
		}
	}
}
