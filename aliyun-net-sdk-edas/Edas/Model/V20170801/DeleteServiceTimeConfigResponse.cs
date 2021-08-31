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
	public class DeleteServiceTimeConfigResponse : AcsResponse
	{

		private int? code;

		private string message;

		private bool? success;

		private DeleteServiceTimeConfig_Data data;

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

		public DeleteServiceTimeConfig_Data Data
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

		public class DeleteServiceTimeConfig_Data
		{

			private string timeout;

			private string consumerAppName;

			private string consumerAppId;

			private string path;

			private long? id;

			public string Timeout
			{
				get
				{
					return timeout;
				}
				set	
				{
					timeout = value;
				}
			}

			public string ConsumerAppName
			{
				get
				{
					return consumerAppName;
				}
				set	
				{
					consumerAppName = value;
				}
			}

			public string ConsumerAppId
			{
				get
				{
					return consumerAppId;
				}
				set	
				{
					consumerAppId = value;
				}
			}

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
		}
	}
}
