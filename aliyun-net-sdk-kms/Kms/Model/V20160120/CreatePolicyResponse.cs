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

namespace Aliyun.Acs.Kms.Model.V20160120
{
	public class CreatePolicyResponse : AcsResponse
	{

		private string requestId;

		private string arn;

		private string name;

		private string description;

		private string kmsInstance;

		private string permissions;

		private string resources;

		private string accessControlRules;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Arn")]
		public string Arn
		{
			get
			{
				return arn;
			}
			set	
			{
				arn = value;
			}
		}

		[JsonProperty(PropertyName = "Name")]
		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
			}
		}

		[JsonProperty(PropertyName = "Description")]
		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
			}
		}

		[JsonProperty(PropertyName = "KmsInstance")]
		public string KmsInstance
		{
			get
			{
				return kmsInstance;
			}
			set	
			{
				kmsInstance = value;
			}
		}

		[JsonProperty(PropertyName = "Permissions")]
		public string Permissions
		{
			get
			{
				return permissions;
			}
			set	
			{
				permissions = value;
			}
		}

		[JsonProperty(PropertyName = "Resources")]
		public string Resources
		{
			get
			{
				return resources;
			}
			set	
			{
				resources = value;
			}
		}

		[JsonProperty(PropertyName = "AccessControlRules")]
		public string AccessControlRules
		{
			get
			{
				return accessControlRules;
			}
			set	
			{
				accessControlRules = value;
			}
		}
	}
}
