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

namespace Aliyun.Acs.PTS.Model.V20201020
{
	public class GetJMeterSceneRunningDataResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private string code;

		private bool? success;

		private int? httpStatusCode;

		private string documentUrl;

		private GetJMeterSceneRunningData_RunningData runningData;

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

		public string DocumentUrl
		{
			get
			{
				return documentUrl;
			}
			set	
			{
				documentUrl = value;
			}
		}

		public GetJMeterSceneRunningData_RunningData RunningData
		{
			get
			{
				return runningData;
			}
			set	
			{
				runningData = value;
			}
		}

		public class GetJMeterSceneRunningData_RunningData
		{

			private string sceneId;

			private string sceneName;

			private int? holdFor;

			private int? agentCount;

			private int? concurrency;

			private bool? hasReport;

			private bool? isDebugging;

			private string status;

			private long? vum;

			private long? startTimeTS;

			private string stageName;

			private string allSampleStat;

			private List<string> agentIdList;

			private List<Dictionary<string, string>> sampleStatList;

			public string SceneId
			{
				get
				{
					return sceneId;
				}
				set	
				{
					sceneId = value;
				}
			}

			public string SceneName
			{
				get
				{
					return sceneName;
				}
				set	
				{
					sceneName = value;
				}
			}

			public int? HoldFor
			{
				get
				{
					return holdFor;
				}
				set	
				{
					holdFor = value;
				}
			}

			public int? AgentCount
			{
				get
				{
					return agentCount;
				}
				set	
				{
					agentCount = value;
				}
			}

			public int? Concurrency
			{
				get
				{
					return concurrency;
				}
				set	
				{
					concurrency = value;
				}
			}

			public bool? HasReport
			{
				get
				{
					return hasReport;
				}
				set	
				{
					hasReport = value;
				}
			}

			public bool? IsDebugging
			{
				get
				{
					return isDebugging;
				}
				set	
				{
					isDebugging = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public long? Vum
			{
				get
				{
					return vum;
				}
				set	
				{
					vum = value;
				}
			}

			public long? StartTimeTS
			{
				get
				{
					return startTimeTS;
				}
				set	
				{
					startTimeTS = value;
				}
			}

			public string StageName
			{
				get
				{
					return stageName;
				}
				set	
				{
					stageName = value;
				}
			}

			public string AllSampleStat
			{
				get
				{
					return allSampleStat;
				}
				set	
				{
					allSampleStat = value;
				}
			}

			public List<string> AgentIdList
			{
				get
				{
					return agentIdList;
				}
				set	
				{
					agentIdList = value;
				}
			}

			public List<Dictionary<string, string>> SampleStatList
			{
				get
				{
					return sampleStatList;
				}
				set	
				{
					sampleStatList = value;
				}
			}
		}
	}
}
