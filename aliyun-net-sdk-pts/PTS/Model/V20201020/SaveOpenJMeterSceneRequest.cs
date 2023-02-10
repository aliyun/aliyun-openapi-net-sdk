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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.PTS;
using Aliyun.Acs.PTS.Transform;
using Aliyun.Acs.PTS.Transform.V20201020;

namespace Aliyun.Acs.PTS.Model.V20201020
{
    public class SaveOpenJMeterSceneRequest : RpcAcsRequest<SaveOpenJMeterSceneResponse>
    {
        public SaveOpenJMeterSceneRequest()
            : base("PTS", "2020-10-20", "SaveOpenJMeterScene")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.PTS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.PTS.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private OpenJMeterScene openJMeterScene_;

		[JsonProperty(PropertyName = "OpenJMeterScene")]
		public OpenJMeterScene OpenJMeterScene_
		{
			get
			{
				return openJMeterScene_;
			}

			set
			{
				openJMeterScene_ = value;
				DictionaryUtil.Add(QueryParameters, "OpenJMeterScene", JsonConvert.SerializeObject(value));

			}
		}

		public class OpenJMeterScene
		{

			private int? startConcurrency;

			private string testFile;

			private string constantThroughputTimerType;

			private string sceneName;

			private string securityGroupId;

			private List<FileListItem> fileList = new List<FileListItem>(){ };

			private int? steps;

			private int? startRps;

			private int? concurrency;

			private int? duration;

			private int? agentCount;

			private string vSwitchId;

			private string mode;

			private bool? isVpcTest;

			private string environmentId;

			private string regionId;

			private string vpcId;

			private string sceneId;

			private string jmeterPluginLabel;

			private DnsCacheConfig dnsCacheConfig_;

			private List<JMeterPropertiesItem> jMeterProperties = new List<JMeterPropertiesItem>(){ };

			private string syncTimerType;

			private int? maxRps;

			private int? rampUp;

			[JsonProperty(PropertyName = "StartConcurrency")]
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

			[JsonProperty(PropertyName = "TestFile")]
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

			[JsonProperty(PropertyName = "ConstantThroughputTimerType")]
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

			[JsonProperty(PropertyName = "SceneName")]
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

			[JsonProperty(PropertyName = "SecurityGroupId")]
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

			[JsonProperty(PropertyName = "FileList")]
			public List<FileListItem> FileList
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

			[JsonProperty(PropertyName = "Steps")]
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

			[JsonProperty(PropertyName = "StartRps")]
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

			[JsonProperty(PropertyName = "Concurrency")]
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

			[JsonProperty(PropertyName = "Duration")]
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

			[JsonProperty(PropertyName = "AgentCount")]
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

			[JsonProperty(PropertyName = "VSwitchId")]
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

			[JsonProperty(PropertyName = "Mode")]
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

			[JsonProperty(PropertyName = "IsVpcTest")]
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

			[JsonProperty(PropertyName = "EnvironmentId")]
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

			[JsonProperty(PropertyName = "RegionId")]
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

			[JsonProperty(PropertyName = "VpcId")]
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

			[JsonProperty(PropertyName = "SceneId")]
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

			[JsonProperty(PropertyName = "JmeterPluginLabel")]
			public string JmeterPluginLabel
			{
				get
				{
					return jmeterPluginLabel;
				}
				set	
				{
					jmeterPluginLabel = value;
				}
			}

			[JsonProperty(PropertyName = "DnsCacheConfig")]
			public DnsCacheConfig DnsCacheConfig_
			{
				get
				{
					return dnsCacheConfig_;
				}
				set	
				{
					dnsCacheConfig_ = value;
				}
			}

			[JsonProperty(PropertyName = "JMeterProperties")]
			public List<JMeterPropertiesItem> JMeterProperties
			{
				get
				{
					return jMeterProperties;
				}
				set	
				{
					jMeterProperties = value;
				}
			}

			[JsonProperty(PropertyName = "SyncTimerType")]
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

			[JsonProperty(PropertyName = "MaxRps")]
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

			[JsonProperty(PropertyName = "RampUp")]
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

			public class FileListItem
			{

				private string fileName;

				private bool? splitCsv;

				private long? fileSize;

				private string fileOssAddress;

				private string md5;

				private long? fileId;

				private string tags;

				[JsonProperty(PropertyName = "FileName")]
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

				[JsonProperty(PropertyName = "SplitCsv")]
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

				[JsonProperty(PropertyName = "FileSize")]
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

				[JsonProperty(PropertyName = "FileOssAddress")]
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

				[JsonProperty(PropertyName = "Md5")]
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

				[JsonProperty(PropertyName = "FileId")]
				public long? FileId
				{
					get
					{
						return fileId;
					}
					set	
					{
						fileId = value;
					}
				}

				[JsonProperty(PropertyName = "Tags")]
				public string Tags
				{
					get
					{
						return tags;
					}
					set	
					{
						tags = value;
					}
				}
			}

			public class DnsCacheConfig
			{

				private bool? clearCacheEachIteration;

				private List<string> dnsServers = new List<string>(){ };

				private Dictionary<string, string> hostTable;

				[JsonProperty(PropertyName = "ClearCacheEachIteration")]
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

				[JsonProperty(PropertyName = "DnsServers")]
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

				[JsonProperty(PropertyName = "HostTable")]
				public Dictionary<string, string> HostTable
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
			}

			public class JMeterPropertiesItem
			{

				private string name;

				private string value_;

				[JsonProperty(PropertyName = "Name")]
				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				[JsonProperty(PropertyName = "Value")]
				public string Value_
				{
					get
					{
						return value_;
					}
					set	
					{
						value_ = value;
					}
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SaveOpenJMeterSceneResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveOpenJMeterSceneResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
