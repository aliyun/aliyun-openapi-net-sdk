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

namespace Aliyun.Acs.afs.Model.V20180112
{
	public class DescribePersonMachineListResponse : AcsResponse
	{

		private string requestId;

		private string bizCode;

		private DescribePersonMachineList_PersonMachineRes personMachineRes;

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

		public string BizCode
		{
			get
			{
				return bizCode;
			}
			set	
			{
				bizCode = value;
			}
		}

		public DescribePersonMachineList_PersonMachineRes PersonMachineRes
		{
			get
			{
				return personMachineRes;
			}
			set	
			{
				personMachineRes = value;
			}
		}

		public class DescribePersonMachineList_PersonMachineRes
		{

			private string hasConfiguration;

			private List<DescribePersonMachineList_PersonMachine> personMachines;

			public string HasConfiguration
			{
				get
				{
					return hasConfiguration;
				}
				set	
				{
					hasConfiguration = value;
				}
			}

			public List<DescribePersonMachineList_PersonMachine> PersonMachines
			{
				get
				{
					return personMachines;
				}
				set	
				{
					personMachines = value;
				}
			}

			public class DescribePersonMachineList_PersonMachine
			{

				private string configurationName;

				private string appkey;

				private string configurationMethod;

				private string applyType;

				private string scene;

				private string lastUpdate;

				private string extId;

				private string sceneOriginal;

				public string ConfigurationName
				{
					get
					{
						return configurationName;
					}
					set	
					{
						configurationName = value;
					}
				}

				public string Appkey
				{
					get
					{
						return appkey;
					}
					set	
					{
						appkey = value;
					}
				}

				public string ConfigurationMethod
				{
					get
					{
						return configurationMethod;
					}
					set	
					{
						configurationMethod = value;
					}
				}

				public string ApplyType
				{
					get
					{
						return applyType;
					}
					set	
					{
						applyType = value;
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

				public string LastUpdate
				{
					get
					{
						return lastUpdate;
					}
					set	
					{
						lastUpdate = value;
					}
				}

				public string ExtId
				{
					get
					{
						return extId;
					}
					set	
					{
						extId = value;
					}
				}

				public string SceneOriginal
				{
					get
					{
						return sceneOriginal;
					}
					set	
					{
						sceneOriginal = value;
					}
				}
			}
		}
	}
}
