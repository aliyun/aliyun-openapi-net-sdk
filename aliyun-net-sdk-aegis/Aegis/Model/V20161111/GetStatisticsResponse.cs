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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class GetStatisticsResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private bool? success;

		private string message;

		private GetStatistics_Data data;

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

		public GetStatistics_Data Data
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

		public class GetStatistics_Data
		{

			private int? account;

			private int? health;

			private int? patch;

			private int? trojan;

			public int? Account
			{
				get
				{
					return account;
				}
				set	
				{
					account = value;
				}
			}

			public int? Health
			{
				get
				{
					return health;
				}
				set	
				{
					health = value;
				}
			}

			public int? Patch
			{
				get
				{
					return patch;
				}
				set	
				{
					patch = value;
				}
			}

			public int? Trojan
			{
				get
				{
					return trojan;
				}
				set	
				{
					trojan = value;
				}
			}
		}
	}
}