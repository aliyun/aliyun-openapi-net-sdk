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
	public class CreateApplicationGroupResponse : AcsResponse
	{

		private string requestId;

		private CreateApplicationGroup_ApplicationGroup applicationGroup;

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

		public CreateApplicationGroup_ApplicationGroup ApplicationGroup
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

		public class CreateApplicationGroup_ApplicationGroup
		{

			private string cmsGroupId;

			private string deployRegionId;

			private string description;

			private string updateDate;

			private string importTagKey;

			private string applicationName;

			private string importTagValue;

			private string name;

			private string createDate;

			public string CmsGroupId
			{
				get
				{
					return cmsGroupId;
				}
				set	
				{
					cmsGroupId = value;
				}
			}

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

			public string UpdateDate
			{
				get
				{
					return updateDate;
				}
				set	
				{
					updateDate = value;
				}
			}

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

			public string CreateDate
			{
				get
				{
					return createDate;
				}
				set	
				{
					createDate = value;
				}
			}
		}
	}
}
