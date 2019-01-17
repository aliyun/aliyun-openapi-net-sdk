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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
	public class DescribeAppSecurityResponse : AcsResponse
	{

		private string requestId;

		private string appKey;

		private string appSecret;

		private string createdTime;

		private string modifiedTime;

		private string appCode;

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

		public string AppKey
		{
			get
			{
				return appKey;
			}
			set	
			{
				appKey = value;
			}
		}

		public string AppSecret
		{
			get
			{
				return appSecret;
			}
			set	
			{
				appSecret = value;
			}
		}

		public string CreatedTime
		{
			get
			{
				return createdTime;
			}
			set	
			{
				createdTime = value;
			}
		}

		public string ModifiedTime
		{
			get
			{
				return modifiedTime;
			}
			set	
			{
				modifiedTime = value;
			}
		}

		public string AppCode
		{
			get
			{
				return appCode;
			}
			set	
			{
				appCode = value;
			}
		}
	}
}