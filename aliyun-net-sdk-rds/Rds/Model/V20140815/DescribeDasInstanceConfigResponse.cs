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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDasInstanceConfigResponse : AcsResponse
	{

		private string requestId;

		private string data;

		private int? storageUpperBound;

		private int? maxStorageUpperBound;

		private string dBInstanceId;

		private int? storageThreshold;

		private bool? storageAutoScale;

		private string dBType;

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

		public string Data
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

		public int? StorageUpperBound
		{
			get
			{
				return storageUpperBound;
			}
			set	
			{
				storageUpperBound = value;
			}
		}

		public int? MaxStorageUpperBound
		{
			get
			{
				return maxStorageUpperBound;
			}
			set	
			{
				maxStorageUpperBound = value;
			}
		}

		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
			}
		}

		public int? StorageThreshold
		{
			get
			{
				return storageThreshold;
			}
			set	
			{
				storageThreshold = value;
			}
		}

		public bool? StorageAutoScale
		{
			get
			{
				return storageAutoScale;
			}
			set	
			{
				storageAutoScale = value;
			}
		}

		public string DBType
		{
			get
			{
				return dBType;
			}
			set	
			{
				dBType = value;
			}
		}
	}
}
