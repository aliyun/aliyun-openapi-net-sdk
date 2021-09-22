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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class CreateApplicationTemplateResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private CreateApplicationTemplate_Data data;

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public CreateApplicationTemplate_Data Data
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

		public class CreateApplicationTemplate_Data
		{

			private string showName;

			private string description;

			private string name;

			private long? id;

			private string attributes;

			private CreateApplicationTemplate_SourceConfig sourceConfig;

			public string ShowName
			{
				get
				{
					return showName;
				}
				set	
				{
					showName = value;
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

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string Attributes
			{
				get
				{
					return attributes;
				}
				set	
				{
					attributes = value;
				}
			}

			public CreateApplicationTemplate_SourceConfig SourceConfig
			{
				get
				{
					return sourceConfig;
				}
				set	
				{
					sourceConfig = value;
				}
			}

			public class CreateApplicationTemplate_SourceConfig
			{

				private string sourceUrl;

				public string SourceUrl
				{
					get
					{
						return sourceUrl;
					}
					set	
					{
						sourceUrl = value;
					}
				}
			}
		}
	}
}
