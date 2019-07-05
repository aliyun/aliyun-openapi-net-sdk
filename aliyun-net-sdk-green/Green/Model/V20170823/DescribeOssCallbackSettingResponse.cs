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

namespace Aliyun.Acs.Green.Model.V20170823
{
	public class DescribeOssCallbackSettingResponse : AcsResponse
	{

		private string requestId;

		private string callbackUrl;

		private bool? scanCallback;

		private bool? auditCallback;

		private string callbackSeed;

		private List<string> scanCallbackSuggestions;

		private List<string> serviceModules;

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

		public string CallbackUrl
		{
			get
			{
				return callbackUrl;
			}
			set	
			{
				callbackUrl = value;
			}
		}

		public bool? ScanCallback
		{
			get
			{
				return scanCallback;
			}
			set	
			{
				scanCallback = value;
			}
		}

		public bool? AuditCallback
		{
			get
			{
				return auditCallback;
			}
			set	
			{
				auditCallback = value;
			}
		}

		public string CallbackSeed
		{
			get
			{
				return callbackSeed;
			}
			set	
			{
				callbackSeed = value;
			}
		}

		public List<string> ScanCallbackSuggestions
		{
			get
			{
				return scanCallbackSuggestions;
			}
			set	
			{
				scanCallbackSuggestions = value;
			}
		}

		public List<string> ServiceModules
		{
			get
			{
				return serviceModules;
			}
			set	
			{
				serviceModules = value;
			}
		}
	}
}
