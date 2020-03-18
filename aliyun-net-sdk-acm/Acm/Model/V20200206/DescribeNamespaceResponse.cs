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

namespace Aliyun.Acs.acm.Model.V20200206
{
	public class DescribeNamespaceResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private DescribeNamespace__Namespace _namespace;

		public string Code
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

		public DescribeNamespace__Namespace _Namespace
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

		public class DescribeNamespace__Namespace
		{

			private string accessKey;

			private string endpoint;

			private string name;

			private string regionId;

			private string secretKey;

			public string AccessKey
			{
				get
				{
					return accessKey;
				}
				set	
				{
					accessKey = value;
				}
			}

			public string Endpoint
			{
				get
				{
					return endpoint;
				}
				set	
				{
					endpoint = value;
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

			public string SecretKey
			{
				get
				{
					return secretKey;
				}
				set	
				{
					secretKey = value;
				}
			}
		}
	}
}
