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
using Aliyun.Acs.retailcloud.Transform;
using Aliyun.Acs.retailcloud.Transform.V20180313;

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
    public class CreatePersistentVolumeRequest : RpcAcsRequest<CreatePersistentVolumeResponse>
    {
        public CreatePersistentVolumeRequest()
            : base("retailcloud", "2018-03-13", "CreatePersistentVolume", "retailcloud", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string reclaimPolicy;

		private string nFSVersion;

		private string accessModes;

		private string name;

		private string mountTargetDomain;

		private string mountDir;

		private string clusterInstanceId;

		private string capacity;

		private string storageClass;

		public string ReclaimPolicy
		{
			get
			{
				return reclaimPolicy;
			}
			set	
			{
				reclaimPolicy = value;
				DictionaryUtil.Add(BodyParameters, "ReclaimPolicy", value);
			}
		}

		public string NFSVersion
		{
			get
			{
				return nFSVersion;
			}
			set	
			{
				nFSVersion = value;
				DictionaryUtil.Add(BodyParameters, "NFSVersion", value);
			}
		}

		public string AccessModes
		{
			get
			{
				return accessModes;
			}
			set	
			{
				accessModes = value;
				DictionaryUtil.Add(BodyParameters, "AccessModes", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(BodyParameters, "Name", value);
			}
		}

		public string MountTargetDomain
		{
			get
			{
				return mountTargetDomain;
			}
			set	
			{
				mountTargetDomain = value;
				DictionaryUtil.Add(BodyParameters, "MountTargetDomain", value);
			}
		}

		public string MountDir
		{
			get
			{
				return mountDir;
			}
			set	
			{
				mountDir = value;
				DictionaryUtil.Add(BodyParameters, "MountDir", value);
			}
		}

		public string ClusterInstanceId
		{
			get
			{
				return clusterInstanceId;
			}
			set	
			{
				clusterInstanceId = value;
				DictionaryUtil.Add(BodyParameters, "ClusterInstanceId", value);
			}
		}

		public string Capacity
		{
			get
			{
				return capacity;
			}
			set	
			{
				capacity = value;
				DictionaryUtil.Add(BodyParameters, "Capacity", value);
			}
		}

		public string StorageClass
		{
			get
			{
				return storageClass;
			}
			set	
			{
				storageClass = value;
				DictionaryUtil.Add(BodyParameters, "StorageClass", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreatePersistentVolumeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreatePersistentVolumeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
