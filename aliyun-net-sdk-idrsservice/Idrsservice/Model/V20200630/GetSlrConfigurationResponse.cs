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

namespace Aliyun.Acs.idrsservice.Model.V20200630
{
	public class GetSlrConfigurationResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private GetSlrConfiguration_Data data;

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

		public GetSlrConfiguration_Data Data
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

		public class GetSlrConfiguration_Data
		{

			private bool? mqSubscribe;

			private string mqEndpoint;

			private string mqInstanceId;

			private string mqTopic;

			private string mqGroupId;

			private List<string> mqEventList;

			public bool? MqSubscribe
			{
				get
				{
					return mqSubscribe;
				}
				set	
				{
					mqSubscribe = value;
				}
			}

			public string MqEndpoint
			{
				get
				{
					return mqEndpoint;
				}
				set	
				{
					mqEndpoint = value;
				}
			}

			public string MqInstanceId
			{
				get
				{
					return mqInstanceId;
				}
				set	
				{
					mqInstanceId = value;
				}
			}

			public string MqTopic
			{
				get
				{
					return mqTopic;
				}
				set	
				{
					mqTopic = value;
				}
			}

			public string MqGroupId
			{
				get
				{
					return mqGroupId;
				}
				set	
				{
					mqGroupId = value;
				}
			}

			public List<string> MqEventList
			{
				get
				{
					return mqEventList;
				}
				set	
				{
					mqEventList = value;
				}
			}
		}
	}
}
