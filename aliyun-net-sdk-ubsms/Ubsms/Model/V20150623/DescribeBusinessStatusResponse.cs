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

namespace Aliyun.Acs.Ubsms.Model.V20150623
{
	public class DescribeBusinessStatusResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<DescribeBusinessStatus_UserBusinessStatus> userBusinessStatusList;

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

		public List<DescribeBusinessStatus_UserBusinessStatus> UserBusinessStatusList
		{
			get
			{
				return userBusinessStatusList;
			}
			set	
			{
				userBusinessStatusList = value;
			}
		}

		public class DescribeBusinessStatus_UserBusinessStatus
		{

			private string uid;

			private string serviceCode;

			private List<DescribeBusinessStatus_Status> statuses;

			public string Uid
			{
				get
				{
					return uid;
				}
				set	
				{
					uid = value;
				}
			}

			public string ServiceCode
			{
				get
				{
					return serviceCode;
				}
				set	
				{
					serviceCode = value;
				}
			}

			public List<DescribeBusinessStatus_Status> Statuses
			{
				get
				{
					return statuses;
				}
				set	
				{
					statuses = value;
				}
			}

			public class DescribeBusinessStatus_Status
			{

				private string statusKey;

				private string statusValue;

				public string StatusKey
				{
					get
					{
						return statusKey;
					}
					set	
					{
						statusKey = value;
					}
				}

				public string StatusValue
				{
					get
					{
						return statusValue;
					}
					set	
					{
						statusValue = value;
					}
				}
			}
		}
	}
}
