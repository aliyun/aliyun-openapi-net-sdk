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
	public class GetSparkSQLEngineStateResponse : AcsResponse
	{

		private string requestId;

		private GetSparkSQLEngineState_Data data;

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

		public GetSparkSQLEngineState_Data Data
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

		public class GetSparkSQLEngineState_Data
		{

			private string appId;

			private string minExecutor;

			private string maxExecutor;

			private string jars;

			private string slotNum;

			private string config;

			private string state;

			private string submittedTimeInMillis;

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}

			public string MinExecutor
			{
				get
				{
					return minExecutor;
				}
				set	
				{
					minExecutor = value;
				}
			}

			public string MaxExecutor
			{
				get
				{
					return maxExecutor;
				}
				set	
				{
					maxExecutor = value;
				}
			}

			public string Jars
			{
				get
				{
					return jars;
				}
				set	
				{
					jars = value;
				}
			}

			public string SlotNum
			{
				get
				{
					return slotNum;
				}
				set	
				{
					slotNum = value;
				}
			}

			public string Config
			{
				get
				{
					return config;
				}
				set	
				{
					config = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public string SubmittedTimeInMillis
			{
				get
				{
					return submittedTimeInMillis;
				}
				set	
				{
					submittedTimeInMillis = value;
				}
			}
		}
	}
}
