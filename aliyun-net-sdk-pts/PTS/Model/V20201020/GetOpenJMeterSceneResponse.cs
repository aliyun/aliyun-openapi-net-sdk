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
	public class GetOpenJMeterSceneResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private int? httpStatusCode;

		private string code;

		private bool? success;

		private GetOpenJMeterScene_Scene scene;

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

		public GetOpenJMeterScene_Scene Scene
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

		public class GetOpenJMeterScene_Scene
		{

			private string sceneName;

			private string sceneId;

			private string environmentId;

			private string testFile;

			private bool? isVpcTest;

			private int? duration;

			private int? concurrency;

			private int? agentCount;

			private int? rampUp;

			private int? steps;

			private string regionId;

			private string vpcId;

			private string securityGroupId;

			private string vSwitchId;

			private string syncTimerType;

			private string constantThroughputTimerType;

			private string pool;

			private string mode;

			private int? startRps;

			private int? maxRps;

			private int? startConcurrency;

			private List<GetOpenJMeterScene_FileListItem> fileList;

			private GetOpenJMeterScene_BaseInfo baseInfo;

			private GetOpenJMeterScene_DnsCacheConfig dnsCacheConfig;

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

			public string EnvironmentId
			{
				get
				{
					return environmentId;
				}
				set	
				{
					environmentId = value;
				}
			}

			public string TestFile
			{
				get
				{
					return testFile;
				}
				set	
				{
					testFile = value;
				}
			}

			public bool? IsVpcTest
			{
				get
				{
					return isVpcTest;
				}
				set	
				{
					isVpcTest = value;
				}
			}

			public int? Duration
			{
				get
				{
					return duration;
				}
				set	
				{
					duration = value;
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

			public int? RampUp
			{
				get
				{
					return rampUp;
				}
				set	
				{
					rampUp = value;
				}
			}

			public int? Steps
			{
				get
				{
					return steps;
				}
				set	
				{
					steps = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string VpcId
			{
				get
				{
					return vpcId;
				}
				set	
				{
					vpcId = value;
				}
			}

			public string SecurityGroupId
			{
				get
				{
					return securityGroupId;
				}
				set	
				{
					securityGroupId = value;
				}
			}

			public string VSwitchId
			{
				get
				{
					return vSwitchId;
				}
				set	
				{
					vSwitchId = value;
				}
			}

			public string SyncTimerType
			{
				get
				{
					return syncTimerType;
				}
				set	
				{
					syncTimerType = value;
				}
			}

			public string ConstantThroughputTimerType
			{
				get
				{
					return constantThroughputTimerType;
				}
				set	
				{
					constantThroughputTimerType = value;
				}
			}

			public string Pool
			{
				get
				{
					return pool;
				}
				set	
				{
					pool = value;
				}
			}

			public string Mode
			{
				get
				{
					return mode;
				}
				set	
				{
					mode = value;
				}
			}

			public int? StartRps
			{
				get
				{
					return startRps;
				}
				set	
				{
					startRps = value;
				}
			}

			public int? MaxRps
			{
				get
				{
					return maxRps;
				}
				set	
				{
					maxRps = value;
				}
			}

			public int? StartConcurrency
			{
				get
				{
					return startConcurrency;
				}
				set	
				{
					startConcurrency = value;
				}
			}

			public List<GetOpenJMeterScene_FileListItem> FileList
			{
				get
				{
					return fileList;
				}
				set	
				{
					fileList = value;
				}
			}

			public GetOpenJMeterScene_BaseInfo BaseInfo
			{
				get
				{
					return baseInfo;
				}
				set	
				{
					baseInfo = value;
				}
			}

			public GetOpenJMeterScene_DnsCacheConfig DnsCacheConfig
			{
				get
				{
					return dnsCacheConfig;
				}
				set	
				{
					dnsCacheConfig = value;
				}
			}

			public class GetOpenJMeterScene_FileListItem
			{

				private long? id;

				private string fileName;

				private string fileOssAddress;

				private bool? splitCsv;

				private string md5;

				private long? fileSize;

				private string fileType;

				public long? Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public string FileName
				{
					get
					{
						return fileName;
					}
					set	
					{
						fileName = value;
					}
				}

				public string FileOssAddress
				{
					get
					{
						return fileOssAddress;
					}
					set	
					{
						fileOssAddress = value;
					}
				}

				public bool? SplitCsv
				{
					get
					{
						return splitCsv;
					}
					set	
					{
						splitCsv = value;
					}
				}

				public string Md5
				{
					get
					{
						return md5;
					}
					set	
					{
						md5 = value;
					}
				}

				public long? FileSize
				{
					get
					{
						return fileSize;
					}
					set	
					{
						fileSize = value;
					}
				}

				public string FileType
				{
					get
					{
						return fileType;
					}
					set	
					{
						fileType = value;
					}
				}
			}

			public class GetOpenJMeterScene_BaseInfo
			{

				private string remark;

				private string principal;

				private string resource;

				private string createName;

				private string modifyName;

				private string operateType;

				public string Remark
				{
					get
					{
						return remark;
					}
					set	
					{
						remark = value;
					}
				}

				public string Principal
				{
					get
					{
						return principal;
					}
					set	
					{
						principal = value;
					}
				}

				public string Resource
				{
					get
					{
						return resource;
					}
					set	
					{
						resource = value;
					}
				}

				public string CreateName
				{
					get
					{
						return createName;
					}
					set	
					{
						createName = value;
					}
				}

				public string ModifyName
				{
					get
					{
						return modifyName;
					}
					set	
					{
						modifyName = value;
					}
				}

				public string OperateType
				{
					get
					{
						return operateType;
					}
					set	
					{
						operateType = value;
					}
				}
			}

			public class GetOpenJMeterScene_DnsCacheConfig
			{

				private bool? clearCacheEachIteration;

				private string hostTable;

				private List<string> dnsServers;

				public bool? ClearCacheEachIteration
				{
					get
					{
						return clearCacheEachIteration;
					}
					set	
					{
						clearCacheEachIteration = value;
					}
				}

				public string HostTable
				{
					get
					{
						return hostTable;
					}
					set	
					{
						hostTable = value;
					}
				}

				public List<string> DnsServers
				{
					get
					{
						return dnsServers;
					}
					set	
					{
						dnsServers = value;
					}
				}
			}
		}
	}
}
