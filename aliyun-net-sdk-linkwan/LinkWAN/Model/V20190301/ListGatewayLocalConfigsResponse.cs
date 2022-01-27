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

namespace Aliyun.Acs.LinkWAN.Model.V20190301
{
	public class ListGatewayLocalConfigsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private List<ListGatewayLocalConfigs_D2dConfig> data;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public List<ListGatewayLocalConfigs_D2dConfig> Data
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

		public class ListGatewayLocalConfigs_D2dConfig
		{

			private string devType;

			private string eui;

			private string d2dAddr;

			private string d2dKey;

			private int? freq;

			private int? datr;

			private long? taskId;

			private long? createMillis;

			private long? modifiedMillis;

			public string DevType
			{
				get
				{
					return devType;
				}
				set	
				{
					devType = value;
				}
			}

			public string Eui
			{
				get
				{
					return eui;
				}
				set	
				{
					eui = value;
				}
			}

			public string D2dAddr
			{
				get
				{
					return d2dAddr;
				}
				set	
				{
					d2dAddr = value;
				}
			}

			public string D2dKey
			{
				get
				{
					return d2dKey;
				}
				set	
				{
					d2dKey = value;
				}
			}

			public int? Freq
			{
				get
				{
					return freq;
				}
				set	
				{
					freq = value;
				}
			}

			public int? Datr
			{
				get
				{
					return datr;
				}
				set	
				{
					datr = value;
				}
			}

			public long? TaskId
			{
				get
				{
					return taskId;
				}
				set	
				{
					taskId = value;
				}
			}

			public long? CreateMillis
			{
				get
				{
					return createMillis;
				}
				set	
				{
					createMillis = value;
				}
			}

			public long? ModifiedMillis
			{
				get
				{
					return modifiedMillis;
				}
				set	
				{
					modifiedMillis = value;
				}
			}
		}
	}
}
