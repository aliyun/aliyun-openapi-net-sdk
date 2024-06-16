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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribePostgresExtensionsResponse : AcsResponse
	{

		private string requestId;

		private string overview;

		private List<DescribePostgresExtensions_Extension> uninstalledExtensions;

		private List<DescribePostgresExtensions_Extension> installedExtensions;

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

		[JsonProperty(PropertyName = "Overview")]
		public string Overview
		{
			get
			{
				return overview;
			}
			set	
			{
				overview = value;
			}
		}

		[JsonProperty(PropertyName = "UninstalledExtensions")]
		public List<DescribePostgresExtensions_Extension> UninstalledExtensions
		{
			get
			{
				return uninstalledExtensions;
			}
			set	
			{
				uninstalledExtensions = value;
			}
		}

		[JsonProperty(PropertyName = "InstalledExtensions")]
		public List<DescribePostgresExtensions_Extension> InstalledExtensions
		{
			get
			{
				return installedExtensions;
			}
			set	
			{
				installedExtensions = value;
			}
		}

		public class DescribePostgresExtensions_Extension
		{

			private string name;

			private string defaultVersion;

			private string installedVersion;

			private string comment;

			private string owner;

			private string priority;

			private string requires;

			private string category;

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

			[JsonProperty(PropertyName = "DefaultVersion")]
			public string DefaultVersion
			{
				get
				{
					return defaultVersion;
				}
				set	
				{
					defaultVersion = value;
				}
			}

			[JsonProperty(PropertyName = "InstalledVersion")]
			public string InstalledVersion
			{
				get
				{
					return installedVersion;
				}
				set	
				{
					installedVersion = value;
				}
			}

			[JsonProperty(PropertyName = "Comment")]
			public string Comment
			{
				get
				{
					return comment;
				}
				set	
				{
					comment = value;
				}
			}

			[JsonProperty(PropertyName = "Owner")]
			public string Owner
			{
				get
				{
					return owner;
				}
				set	
				{
					owner = value;
				}
			}

			[JsonProperty(PropertyName = "Priority")]
			public string Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}

			[JsonProperty(PropertyName = "Requires")]
			public string Requires
			{
				get
				{
					return requires;
				}
				set	
				{
					requires = value;
				}
			}

			[JsonProperty(PropertyName = "Category")]
			public string Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
				}
			}
		}
	}
}
