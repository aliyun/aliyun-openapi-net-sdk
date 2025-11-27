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

namespace Aliyun.Acs.Drds.Model.V20190123
{
	public class DescribeInstanceSwitchAzoneResponse : AcsResponse
	{

		private bool? success;

		private string requestId;

		private DescribeInstanceSwitchAzone_Result result;

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

		public DescribeInstanceSwitchAzone_Result Result
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

		public class DescribeInstanceSwitchAzone_Result
		{

			private string originAzoneId;

			private bool? switchAble;

			private string regionId;

			private List<string> targetAzones;

			public string OriginAzoneId
			{
				get
				{
					return originAzoneId;
				}
				set	
				{
					originAzoneId = value;
				}
			}

			public bool? SwitchAble
			{
				get
				{
					return switchAble;
				}
				set	
				{
					switchAble = value;
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

			public List<string> TargetAzones
			{
				get
				{
					return targetAzones;
				}
				set	
				{
					targetAzones = value;
				}
			}
		}
	}
}
