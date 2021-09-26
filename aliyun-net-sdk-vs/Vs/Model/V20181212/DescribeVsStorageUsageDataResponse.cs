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

namespace Aliyun.Acs.vs.Model.V20181212
{
	public class DescribeVsStorageUsageDataResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeVsStorageUsageData_StorageUsageDataModule> storageUsage;

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

		public List<DescribeVsStorageUsageData_StorageUsageDataModule> StorageUsage
		{
			get
			{
				return storageUsage;
			}
			set	
			{
				storageUsage = value;
			}
		}

		public class DescribeVsStorageUsageData_StorageUsageDataModule
		{

			private string timeStamp;

			private string bucket;

			private int? storageDataValue;

			public string TimeStamp
			{
				get
				{
					return timeStamp;
				}
				set	
				{
					timeStamp = value;
				}
			}

			public string Bucket
			{
				get
				{
					return bucket;
				}
				set	
				{
					bucket = value;
				}
			}

			public int? StorageDataValue
			{
				get
				{
					return storageDataValue;
				}
				set	
				{
					storageDataValue = value;
				}
			}
		}
	}
}
