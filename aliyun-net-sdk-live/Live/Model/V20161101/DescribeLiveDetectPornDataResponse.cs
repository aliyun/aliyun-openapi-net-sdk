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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeLiveDetectPornDataResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveDetectPornData_DataModule> detectPornData;

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

		public List<DescribeLiveDetectPornData_DataModule> DetectPornData
		{
			get
			{
				return detectPornData;
			}
			set	
			{
				detectPornData = value;
			}
		}

		public class DescribeLiveDetectPornData_DataModule
		{

			private string timeStamp;

			private string app;

			private string domain;

			private string stream;

			private string fee;

			private string scene;

			private string region;

			private long? count;

			public string TimeStamp
			{
				get
				{
					return timeStamp;
				}
				set	
				{
					timeStamp = value;
				}
			}

			public string App
			{
				get
				{
					return app;
				}
				set	
				{
					app = value;
				}
			}

			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}

			public string Stream
			{
				get
				{
					return stream;
				}
				set	
				{
					stream = value;
				}
			}

			public string Fee
			{
				get
				{
					return fee;
				}
				set	
				{
					fee = value;
				}
			}

			public string Scene
			{
				get
				{
					return scene;
				}
				set	
				{
					scene = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public long? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}
		}
	}
}
