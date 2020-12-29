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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.EHPC;
using Aliyun.Acs.EHPC.Transform;
using Aliyun.Acs.EHPC.Transform.V20180412;

namespace Aliyun.Acs.EHPC.Model.V20180412
{
    public class UpdateClusterVolumesRequest : RpcAcsRequest<UpdateClusterVolumesResponse>
    {
        public UpdateClusterVolumesRequest()
            : base("EHPC", "2018-04-12", "UpdateClusterVolumes")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.EHPC.Endpoint.endpointRegionalType, null);
            }
        }

		private List<AdditionalVolumes> additionalVolumess = new List<AdditionalVolumes>(){ };

		private string clusterId;

		public List<AdditionalVolumes> AdditionalVolumess
		{
			get
			{
				return additionalVolumess;
			}

			set
			{
				additionalVolumess = value;
				for (int i = 0; i < additionalVolumess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"AdditionalVolumes." + (i + 1) + ".VolumeType", additionalVolumess[i].VolumeType);
					DictionaryUtil.Add(QueryParameters,"AdditionalVolumes." + (i + 1) + ".VolumeProtocol", additionalVolumess[i].VolumeProtocol);
					DictionaryUtil.Add(QueryParameters,"AdditionalVolumes." + (i + 1) + ".LocalDirectory", additionalVolumess[i].LocalDirectory);
					DictionaryUtil.Add(QueryParameters,"AdditionalVolumes." + (i + 1) + ".RemoteDirectory", additionalVolumess[i].RemoteDirectory);
					for (int j = 0; j < additionalVolumess[i].Roless.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"AdditionalVolumes." + (i + 1) + ".Roles." +(j + 1), additionalVolumess[i].Roless[j]);
					}
					DictionaryUtil.Add(QueryParameters,"AdditionalVolumes." + (i + 1) + ".VolumeId", additionalVolumess[i].VolumeId);
					DictionaryUtil.Add(QueryParameters,"AdditionalVolumes." + (i + 1) + ".VolumeMountpoint", additionalVolumess[i].VolumeMountpoint);
					DictionaryUtil.Add(QueryParameters,"AdditionalVolumes." + (i + 1) + ".Location", additionalVolumess[i].Location);
					DictionaryUtil.Add(QueryParameters,"AdditionalVolumes." + (i + 1) + ".JobQueue", additionalVolumess[i].JobQueue);
				}
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public class AdditionalVolumes
		{

			private string volumeType;

			private string volumeProtocol;

			private string localDirectory;

			private string remoteDirectory;

			private List<Roles> roless = new List<Roles>(){ };

			private string volumeId;

			private string volumeMountpoint;

			private string location;

			private string jobQueue;

			public string VolumeType
			{
				get
				{
					return volumeType;
				}
				set	
				{
					volumeType = value;
				}
			}

			public string VolumeProtocol
			{
				get
				{
					return volumeProtocol;
				}
				set	
				{
					volumeProtocol = value;
				}
			}

			public string LocalDirectory
			{
				get
				{
					return localDirectory;
				}
				set	
				{
					localDirectory = value;
				}
			}

			public string RemoteDirectory
			{
				get
				{
					return remoteDirectory;
				}
				set	
				{
					remoteDirectory = value;
				}
			}

			public List<Roles> Roless
			{
				get
				{
					return roless;
				}
				set	
				{
					roless = value;
				}
			}

			public string VolumeId
			{
				get
				{
					return volumeId;
				}
				set	
				{
					volumeId = value;
				}
			}

			public string VolumeMountpoint
			{
				get
				{
					return volumeMountpoint;
				}
				set	
				{
					volumeMountpoint = value;
				}
			}

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
				}
			}

			public string JobQueue
			{
				get
				{
					return jobQueue;
				}
				set	
				{
					jobQueue = value;
				}
			}

			public class Roles
			{

				private string name;

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
			}
		}

        public override UpdateClusterVolumesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateClusterVolumesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
