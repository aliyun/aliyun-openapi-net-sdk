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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.polardbx.Model.V20200202
{
	public class DescribeColdDataBasicInfoResponse : AcsResponse
	{

		private string requestId;

		private DescribeColdDataBasicInfo_Data data;

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

		public DescribeColdDataBasicInfo_Data Data
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

		public class DescribeColdDataBasicInfo_Data
		{

			private bool? enableStatus;

			private string cloudProduct;

			private string volumeName;

			private double? backupSetSpaceSize;

			private int? backupSetCount;

			private double? currentSpaceSize;

			private string dataRedundancyType;

			private double? writeAccessNum;

			private long? readAccessNum;

			private string regionId;

			public bool? EnableStatus
			{
				get
				{
					return enableStatus;
				}
				set	
				{
					enableStatus = value;
				}
			}

			public string CloudProduct
			{
				get
				{
					return cloudProduct;
				}
				set	
				{
					cloudProduct = value;
				}
			}

			public string VolumeName
			{
				get
				{
					return volumeName;
				}
				set	
				{
					volumeName = value;
				}
			}

			public double? BackupSetSpaceSize
			{
				get
				{
					return backupSetSpaceSize;
				}
				set	
				{
					backupSetSpaceSize = value;
				}
			}

			public int? BackupSetCount
			{
				get
				{
					return backupSetCount;
				}
				set	
				{
					backupSetCount = value;
				}
			}

			public double? CurrentSpaceSize
			{
				get
				{
					return currentSpaceSize;
				}
				set	
				{
					currentSpaceSize = value;
				}
			}

			public string DataRedundancyType
			{
				get
				{
					return dataRedundancyType;
				}
				set	
				{
					dataRedundancyType = value;
				}
			}

			public double? WriteAccessNum
			{
				get
				{
					return writeAccessNum;
				}
				set	
				{
					writeAccessNum = value;
				}
			}

			public long? ReadAccessNum
			{
				get
				{
					return readAccessNum;
				}
				set	
				{
					readAccessNum = value;
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
