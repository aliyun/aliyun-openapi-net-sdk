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
	public class GetSpringCloudTestMethodResponse : AcsResponse
	{

		private int? code;

		private string message;

		private bool? success;

		private GetSpringCloudTestMethod_Data data;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public GetSpringCloudTestMethod_Data Data
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

		public class GetSpringCloudTestMethod_Data
		{

			private string path;

			private string httpHeaders;

			private string _params;

			private List<string> requestMethods;

			private List<string> urls;

			public string Path
			{
				get
				{
					return path;
				}
				set	
				{
					path = value;
				}
			}

			public string HttpHeaders
			{
				get
				{
					return httpHeaders;
				}
				set	
				{
					httpHeaders = value;
				}
			}

			public string _Params
			{
				get
				{
					return _params;
				}
				set	
				{
					_params = value;
				}
			}

			public List<string> RequestMethods
			{
				get
				{
					return requestMethods;
				}
				set	
				{
					requestMethods = value;
				}
			}

			public List<string> Urls
			{
				get
				{
					return urls;
				}
				set	
				{
					urls = value;
				}
			}
		}
	}
}
