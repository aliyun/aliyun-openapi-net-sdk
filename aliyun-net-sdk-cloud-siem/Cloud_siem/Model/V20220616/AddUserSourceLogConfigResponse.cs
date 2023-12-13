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

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
	public class AddUserSourceLogConfigResponse : AcsResponse
	{

		private string requestId;

		private AddUserSourceLogConfig_Data data;

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

		public AddUserSourceLogConfig_Data Data
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

		public class AddUserSourceLogConfig_Data
		{

			private string diplayLine;

			private string sourceProdCode;

			private string sourceLogCode;

			private bool? displayed;

			private bool? imported;

			private long? mainUserId;

			private long? subUserId;

			private string subUserName;

			public string DiplayLine
			{
				get
				{
					return diplayLine;
				}
				set	
				{
					diplayLine = value;
				}
			}

			public string SourceProdCode
			{
				get
				{
					return sourceProdCode;
				}
				set	
				{
					sourceProdCode = value;
				}
			}

			public string SourceLogCode
			{
				get
				{
					return sourceLogCode;
				}
				set	
				{
					sourceLogCode = value;
				}
			}

			public bool? Displayed
			{
				get
				{
					return displayed;
				}
				set	
				{
					displayed = value;
				}
			}

			public bool? Imported
			{
				get
				{
					return imported;
				}
				set	
				{
					imported = value;
				}
			}

			public long? MainUserId
			{
				get
				{
					return mainUserId;
				}
				set	
				{
					mainUserId = value;
				}
			}

			public long? SubUserId
			{
				get
				{
					return subUserId;
				}
				set	
				{
					subUserId = value;
				}
			}

			public string SubUserName
			{
				get
				{
					return subUserName;
				}
				set	
				{
					subUserName = value;
				}
			}
		}
	}
}
