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

namespace Aliyun.Acs.oos.Model.V20190601
{
	public class UpdateApplicationGroupResponse : AcsResponse
	{

		private string requestId;

		private UpdateApplicationGroup_ApplicationGroup applicationGroup;

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

		[JsonProperty(PropertyName = "ApplicationGroup")]
		public UpdateApplicationGroup_ApplicationGroup ApplicationGroup
		{
			get
			{
				return applicationGroup;
			}
			set	
			{
				applicationGroup = value;
			}
		}

		public class UpdateApplicationGroup_ApplicationGroup
		{

			private string deployRegionId;

			private string description;

			private string importTagKey;

			private string updatedDate;

			private string applicationName;

			private string createdDate;

			private string importTagValue;

			private string name;

			[JsonProperty(PropertyName = "DeployRegionId")]
			public string DeployRegionId
			{
				get
				{
					return deployRegionId;
				}
				set	
				{
					deployRegionId = value;
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

			[JsonProperty(PropertyName = "ImportTagKey")]
			public string ImportTagKey
			{
				get
				{
					return importTagKey;
				}
				set	
				{
					importTagKey = value;
				}
			}

			[JsonProperty(PropertyName = "UpdatedDate")]
			public string UpdatedDate
			{
				get
				{
					return updatedDate;
				}
				set	
				{
					updatedDate = value;
				}
			}

			[JsonProperty(PropertyName = "ApplicationName")]
			public string ApplicationName
			{
				get
				{
					return applicationName;
				}
				set	
				{
					applicationName = value;
				}
			}

			[JsonProperty(PropertyName = "CreatedDate")]
			public string CreatedDate
			{
				get
				{
					return createdDate;
				}
				set	
				{
					createdDate = value;
				}
			}

			[JsonProperty(PropertyName = "ImportTagValue")]
			public string ImportTagValue
			{
				get
				{
					return importTagValue;
				}
				set	
				{
					importTagValue = value;
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
		}
	}
}
