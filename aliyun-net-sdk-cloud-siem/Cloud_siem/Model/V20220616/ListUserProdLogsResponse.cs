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
	public class ListUserProdLogsResponse : AcsResponse
	{

		private string requestId;

		private List<ListUserProdLogs_DataItem> data;

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

		public List<ListUserProdLogs_DataItem> Data
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

		public class ListUserProdLogs_DataItem
		{

			private string sourceLogCode;

			private string sourceLogInfo;

			private string displayLine;

			private string sourceProdCode;

			private int? isDeleted;

			private bool? imported;

			private bool? displayed;

			private long? mainUserId;

			private long? subUserId;

			private string subUserName;

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

			public string SourceLogInfo
			{
				get
				{
					return sourceLogInfo;
				}
				set	
				{
					sourceLogInfo = value;
				}
			}

			public string DisplayLine
			{
				get
				{
					return displayLine;
				}
				set	
				{
					displayLine = value;
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

			public int? IsDeleted
			{
				get
				{
					return isDeleted;
				}
				set	
				{
					isDeleted = value;
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
