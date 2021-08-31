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
	public class CreateGrayEnvironmentResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private string message;

		private CreateGrayEnvironment_Data data;

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

		public CreateGrayEnvironment_Data Data
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

		public class CreateGrayEnvironment_Data
		{

			private string accountId;

			private long? pointcutId;

			private string regionId;

			private string tenantId;

			private CreateGrayEnvironment_Metadata metadata;

			public string AccountId
			{
				get
				{
					return accountId;
				}
				set	
				{
					accountId = value;
				}
			}

			public long? PointcutId
			{
				get
				{
					return pointcutId;
				}
				set	
				{
					pointcutId = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			public CreateGrayEnvironment_Metadata Metadata
			{
				get
				{
					return metadata;
				}
				set	
				{
					metadata = value;
				}
			}

			public class CreateGrayEnvironment_Metadata
			{

				private string labels;

				private string name;

				private string _namespace;

				private string annotations;

				public string Labels
				{
					get
					{
						return labels;
					}
					set	
					{
						labels = value;
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

				public string _Namespace
				{
					get
					{
						return _namespace;
					}
					set	
					{
						_namespace = value;
					}
				}

				public string Annotations
				{
					get
					{
						return annotations;
					}
					set	
					{
						annotations = value;
					}
				}
			}
		}
	}
}
