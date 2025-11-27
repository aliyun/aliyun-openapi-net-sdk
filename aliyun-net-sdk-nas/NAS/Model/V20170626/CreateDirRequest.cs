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
    public class CreateDirRequest : RpcAcsRequest<CreateDirResponse>
    {
        public CreateDirRequest()
            : base("NAS", "2017-06-26", "CreateDir", "nas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.NAS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.NAS.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? recursion;

		private string fileSystemId;

		private int? ownerGroupId;

		private int? ownerUserId;

		private string permission;

		private string rootDirectory;

		public bool? Recursion
		{
			get
			{
				return recursion;
			}
			set	
			{
				recursion = value;
				DictionaryUtil.Add(QueryParameters, "Recursion", value.ToString());
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateDirResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDirResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
