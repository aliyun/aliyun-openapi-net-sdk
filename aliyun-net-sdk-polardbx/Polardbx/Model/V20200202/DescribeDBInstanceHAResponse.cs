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
	public class DescribeDBInstanceHAResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private bool? success;

		private DescribeDBInstanceHA_Data data;

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

		public DescribeDBInstanceHA_Data Data
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

		public class DescribeDBInstanceHA_Data
		{

			private string topologyType;

			private string primaryRegionId;

			private string primaryAzoneId;

			private string secondaryRegionId;

			private string secondaryAzoneId;

			public string TopologyType
			{
				get
				{
					return topologyType;
				}
				set	
				{
					topologyType = value;
				}
			}

			public string PrimaryRegionId
			{
				get
				{
					return primaryRegionId;
				}
				set	
				{
					primaryRegionId = value;
				}
			}

			public string PrimaryAzoneId
			{
				get
				{
					return primaryAzoneId;
				}
				set	
				{
					primaryAzoneId = value;
				}
			}

			public string SecondaryRegionId
			{
				get
				{
					return secondaryRegionId;
				}
				set	
				{
					secondaryRegionId = value;
				}
			}

			public string SecondaryAzoneId
			{
				get
				{
					return secondaryAzoneId;
				}
				set	
				{
					secondaryAzoneId = value;
				}
			}
		}
	}
}
