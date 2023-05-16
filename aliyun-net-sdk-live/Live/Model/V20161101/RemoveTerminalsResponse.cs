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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class RemoveTerminalsResponse : AcsResponse
	{

		private string requestId;

		private List<RemoveTerminals_Terminal> terminals;

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

		[JsonProperty(PropertyName = "Terminals")]
		public List<RemoveTerminals_Terminal> Terminals
		{
			get
			{
				return terminals;
			}
			set	
			{
				terminals = value;
			}
		}

		public class RemoveTerminals_Terminal
		{

			private int? code;

			private string message;

			private string id;

			[JsonProperty(PropertyName = "Code")]
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

			[JsonProperty(PropertyName = "Message")]
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

			[JsonProperty(PropertyName = "Id")]
			public string Id
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
		}
	}
}
