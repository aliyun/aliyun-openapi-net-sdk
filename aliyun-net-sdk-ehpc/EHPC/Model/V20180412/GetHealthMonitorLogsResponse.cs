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

namespace Aliyun.Acs.EHPC.Model.V20180412
{
	public class GetHealthMonitorLogsResponse : AcsResponse
	{

		private string requestId;

		private List<GetHealthMonitorLogs_Logs> logInfo;

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

		public List<GetHealthMonitorLogs_Logs> LogInfo
		{
			get
			{
				return logInfo;
			}
			set	
			{
				logInfo = value;
			}
		}

		public class GetHealthMonitorLogs_Logs
		{

			private string healthId;

			private string hostName;

			private string instanceId;

			private string itemDescription;

			private string itemName;

			private string level;

			private string sceneDescription;

			private string sceneName;

			private int? time;

			private List<GetHealthMonitorLogs_CheckListItem> checkList;

			public string HealthId
			{
				get
				{
					return healthId;
				}
				set	
				{
					healthId = value;
				}
			}

			public string HostName
			{
				get
				{
					return hostName;
				}
				set	
				{
					hostName = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string ItemDescription
			{
				get
				{
					return itemDescription;
				}
				set	
				{
					itemDescription = value;
				}
			}

			public string ItemName
			{
				get
				{
					return itemName;
				}
				set	
				{
					itemName = value;
				}
			}

			public string Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}

			public string SceneDescription
			{
				get
				{
					return sceneDescription;
				}
				set	
				{
					sceneDescription = value;
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

			public int? Time
			{
				get
				{
					return time;
				}
				set	
				{
					time = value;
				}
			}

			public List<GetHealthMonitorLogs_CheckListItem> CheckList
			{
				get
				{
					return checkList;
				}
				set	
				{
					checkList = value;
				}
			}

			public class GetHealthMonitorLogs_CheckListItem
			{

				private string checkDescription;

				private string checkInfo;

				private string checkName;

				private string checkSolution;

				public string CheckDescription
				{
					get
					{
						return checkDescription;
					}
					set	
					{
						checkDescription = value;
					}
				}

				public string CheckInfo
				{
					get
					{
						return checkInfo;
					}
					set	
					{
						checkInfo = value;
					}
				}

				public string CheckName
				{
					get
					{
						return checkName;
					}
					set	
					{
						checkName = value;
					}
				}

				public string CheckSolution
				{
					get
					{
						return checkSolution;
					}
					set	
					{
						checkSolution = value;
					}
				}
			}
		}
	}
}
