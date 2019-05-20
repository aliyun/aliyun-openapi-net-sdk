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

namespace Aliyun.Acs.Yundun_ds.Model.V20190103
{
	public class DescribeUserStatusResponse : AcsResponse
	{

		private string requestId;

		private DescribeUserStatus_UserStatus userStatus;

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

		public DescribeUserStatus_UserStatus UserStatus
		{
			get
			{
				return userStatus;
			}
			set	
			{
				userStatus = value;
			}
		}

		public class DescribeUserStatus_UserStatus
		{

			private bool? authed;

			private bool? buyed;

			private bool? ossBucketSet;

			private bool? odpsSet;

			private bool? rdsSet;

			private string accessKeyId;

			public bool? Authed
			{
				get
				{
					return authed;
				}
				set	
				{
					authed = value;
				}
			}

			public bool? Buyed
			{
				get
				{
					return buyed;
				}
				set	
				{
					buyed = value;
				}
			}

			public bool? OssBucketSet
			{
				get
				{
					return ossBucketSet;
				}
				set	
				{
					ossBucketSet = value;
				}
			}

			public bool? OdpsSet
			{
				get
				{
					return odpsSet;
				}
				set	
				{
					odpsSet = value;
				}
			}

			public bool? RdsSet
			{
				get
				{
					return rdsSet;
				}
				set	
				{
					rdsSet = value;
				}
			}

			public string AccessKeyId
			{
				get
				{
					return accessKeyId;
				}
				set	
				{
					accessKeyId = value;
				}
			}
		}
	}
}
