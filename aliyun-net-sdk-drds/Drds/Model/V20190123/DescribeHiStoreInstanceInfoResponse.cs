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

namespace Aliyun.Acs.Drds.Model.V20190123
{
	public class DescribeHiStoreInstanceInfoResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private DescribeHiStoreInstanceInfo_HiStoreInstanceInfo hiStoreInstanceInfo;

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

		public DescribeHiStoreInstanceInfo_HiStoreInstanceInfo HiStoreInstanceInfo
		{
			get
			{
				return hiStoreInstanceInfo;
			}
			set	
			{
				hiStoreInstanceInfo = value;
			}
		}

		public class DescribeHiStoreInstanceInfo_HiStoreInstanceInfo
		{

			private string historeInstanceId;

			private long? gmtCreate;

			private string rpmVersion;

			private int? diskSize;

			private string machineSpec;

			public string HistoreInstanceId
			{
				get
				{
					return historeInstanceId;
				}
				set	
				{
					historeInstanceId = value;
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

			public string RpmVersion
			{
				get
				{
					return rpmVersion;
				}
				set	
				{
					rpmVersion = value;
				}
			}

			public int? DiskSize
			{
				get
				{
					return diskSize;
				}
				set	
				{
					diskSize = value;
				}
			}

			public string MachineSpec
			{
				get
				{
					return machineSpec;
				}
				set	
				{
					machineSpec = value;
				}
			}
		}
	}
}
