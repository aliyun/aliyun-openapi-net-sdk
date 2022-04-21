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

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
	public class GetInstanceConfigResponse : AcsResponse
	{

		private string requestId;

		private int? httpStatusCode;

		private string code;

		private string message;

		private bool? success;

		private GetInstanceConfig_Data data;

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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

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

		public GetInstanceConfig_Data Data
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

		public class GetInstanceConfig_Data
		{

			private GetInstanceConfig_InstanceConfig instanceConfig;

			public GetInstanceConfig_InstanceConfig InstanceConfig
			{
				get
				{
					return instanceConfig;
				}
				set	
				{
					instanceConfig = value;
				}
			}

			public class GetInstanceConfig_InstanceConfig
			{

				private bool? miniPlaybackSystemSwitch;

				private bool? newBargeInSystemSwitch;

				private bool? searchTaskFunctionSwitch;

				private long? esAllDataKeepDay;

				public bool? MiniPlaybackSystemSwitch
				{
					get
					{
						return miniPlaybackSystemSwitch;
					}
					set	
					{
						miniPlaybackSystemSwitch = value;
					}
				}

				public bool? NewBargeInSystemSwitch
				{
					get
					{
						return newBargeInSystemSwitch;
					}
					set	
					{
						newBargeInSystemSwitch = value;
					}
				}

				public bool? SearchTaskFunctionSwitch
				{
					get
					{
						return searchTaskFunctionSwitch;
					}
					set	
					{
						searchTaskFunctionSwitch = value;
					}
				}

				public long? EsAllDataKeepDay
				{
					get
					{
						return esAllDataKeepDay;
					}
					set	
					{
						esAllDataKeepDay = value;
					}
				}
			}
		}
	}
}
