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

namespace Aliyun.Acs.adb.Model.V20211201
{
	public class SetSparkAppLogRootPathResponse : AcsResponse
	{

		private string requestId;

		private SetSparkAppLogRootPath_Data data;

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

		public SetSparkAppLogRootPath_Data Data
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

		public class SetSparkAppLogRootPath_Data
		{

			private bool? isLogPathExists;

			private string recordedLogPath;

			private string modifiedUid;

			private string modifiedTimestamp;

			private string defaultLogPath;

			public bool? IsLogPathExists
			{
				get
				{
					return isLogPathExists;
				}
				set	
				{
					isLogPathExists = value;
				}
			}

			public string RecordedLogPath
			{
				get
				{
					return recordedLogPath;
				}
				set	
				{
					recordedLogPath = value;
				}
			}

			public string ModifiedUid
			{
				get
				{
					return modifiedUid;
				}
				set	
				{
					modifiedUid = value;
				}
			}

			public string ModifiedTimestamp
			{
				get
				{
					return modifiedTimestamp;
				}
				set	
				{
					modifiedTimestamp = value;
				}
			}

			public string DefaultLogPath
			{
				get
				{
					return defaultLogPath;
				}
				set	
				{
					defaultLogPath = value;
				}
			}
		}
	}
}
