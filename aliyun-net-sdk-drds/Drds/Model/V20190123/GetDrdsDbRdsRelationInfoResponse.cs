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
	public class GetDrdsDbRdsRelationInfoResponse : AcsResponse
	{

		private bool? success;

		private string requestId;

		private List<GetDrdsDbRdsRelationInfo_DataItem> data;

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

		public List<GetDrdsDbRdsRelationInfo_DataItem> Data
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

		public class GetDrdsDbRdsRelationInfo_DataItem
		{

			private string rdsInstanceId;

			private string usedInstanceType;

			private string usedInstanceId;

			private List<string> readOnlyInstanceInfo;

			public string RdsInstanceId
			{
				get
				{
					return rdsInstanceId;
				}
				set	
				{
					rdsInstanceId = value;
				}
			}

			public string UsedInstanceType
			{
				get
				{
					return usedInstanceType;
				}
				set	
				{
					usedInstanceType = value;
				}
			}

			public string UsedInstanceId
			{
				get
				{
					return usedInstanceId;
				}
				set	
				{
					usedInstanceId = value;
				}
			}

			public List<string> ReadOnlyInstanceInfo
			{
				get
				{
					return readOnlyInstanceInfo;
				}
				set	
				{
					readOnlyInstanceInfo = value;
				}
			}
		}
	}
}
