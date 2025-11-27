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
using Aliyun.Acs.NAS.Transform;
using Aliyun.Acs.NAS.Transform.V20170626;

namespace Aliyun.Acs.NAS.Model.V20170626
{
    public class CreateAccessPointRequest : RpcAcsRequest<CreateAccessPointResponse>
    {
        public CreateAccessPointRequest()
            : base("NAS", "2017-06-26", "CreateAccessPoint", "nas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.NAS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.NAS.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string vswId;

		private string accessPointName;

		private int? posixGroupId;

		private string posixSecondaryGroupIds;

		private string fileSystemId;

		private int? ownerGroupId;

		private bool? enabledRam;

		private int? ownerUserId;

		private string permission;

		private string vpcId;

		private string rootDirectory;

		private string accessGroup;

		private int? posixUserId;

		public string VswId
		{
			get
			{
				return vswId;
			}
			set	
			{
				vswId = value;
				DictionaryUtil.Add(QueryParameters, "VswId", value);
			}
		}

		public string AccessPointName
		{
			get
			{
				return accessPointName;
			}
			set	
			{
				accessPointName = value;
				DictionaryUtil.Add(QueryParameters, "AccessPointName", value);
			}
		}

		public int? PosixGroupId
		{
			get
			{
				return posixGroupId;
			}
			set	
			{
				posixGroupId = value;
				DictionaryUtil.Add(QueryParameters, "PosixGroupId", value.ToString());
			}
		}

		public string PosixSecondaryGroupIds
		{
			get
			{
				return posixSecondaryGroupIds;
			}
			set	
			{
				posixSecondaryGroupIds = value;
				DictionaryUtil.Add(QueryParameters, "PosixSecondaryGroupIds", value);
			}
		}

		public string FileSystemId
		{
			get
			{
				return fileSystemId;
			}
			set	
			{
				fileSystemId = value;
				DictionaryUtil.Add(QueryParameters, "FileSystemId", value);
			}
		}

		public int? OwnerGroupId
		{
			get
			{
				return ownerGroupId;
			}
			set	
			{
				ownerGroupId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerGroupId", value.ToString());
			}
		}

		public bool? EnabledRam
		{
			get
			{
				return enabledRam;
			}
			set	
			{
				enabledRam = value;
				DictionaryUtil.Add(QueryParameters, "EnabledRam", value.ToString());
			}
		}

		public int? OwnerUserId
		{
			get
			{
				return ownerUserId;
			}
			set	
			{
				ownerUserId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerUserId", value.ToString());
			}
		}

		public string Permission
		{
			get
			{
				return permission;
			}
			set	
			{
				permission = value;
				DictionaryUtil.Add(QueryParameters, "Permission", value);
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
				DictionaryUtil.Add(QueryParameters, "VpcId", value);
			}
		}

		public string RootDirectory
		{
			get
			{
				return rootDirectory;
			}
			set	
			{
				rootDirectory = value;
				DictionaryUtil.Add(QueryParameters, "RootDirectory", value);
			}
		}

		public string AccessGroup
		{
			get
			{
				return accessGroup;
			}
			set	
			{
				accessGroup = value;
				DictionaryUtil.Add(QueryParameters, "AccessGroup", value);
			}
		}

		public int? PosixUserId
		{
			get
			{
				return posixUserId;
			}
			set	
			{
				posixUserId = value;
				DictionaryUtil.Add(QueryParameters, "PosixUserId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateAccessPointResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateAccessPointResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
