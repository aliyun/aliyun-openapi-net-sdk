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
using Aliyun.Acs.Sas.Transform;
using Aliyun.Acs.Sas.Transform.V20181203;

namespace Aliyun.Acs.Sas.Model.V20181203
{
    public class CreateRestoreJobRequest : RpcAcsRequest<CreateRestoreJobResponse>
    {
        public CreateRestoreJobRequest()
            : base("Sas", "2018-12-03", "CreateRestoreJob", "sas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string snapshotId;

		private string vaultId;

		private string uuid;

		private string snapshotHash;

		private string sourceIp;

		private string sourceType;

		private string snapshotVersion;

		private string includes;

		private string target;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string SnapshotId
		{
			get
			{
				return snapshotId;
			}
			set	
			{
				snapshotId = value;
				DictionaryUtil.Add(QueryParameters, "SnapshotId", value);
			}
		}

		public string VaultId
		{
			get
			{
				return vaultId;
			}
			set	
			{
				vaultId = value;
				DictionaryUtil.Add(QueryParameters, "VaultId", value);
			}
		}

		public string Uuid
		{
			get
			{
				return uuid;
			}
			set	
			{
				uuid = value;
				DictionaryUtil.Add(QueryParameters, "Uuid", value);
			}
		}

		public string SnapshotHash
		{
			get
			{
				return snapshotHash;
			}
			set	
			{
				snapshotHash = value;
				DictionaryUtil.Add(QueryParameters, "SnapshotHash", value);
			}
		}

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public string SourceType
		{
			get
			{
				return sourceType;
			}
			set	
			{
				sourceType = value;
				DictionaryUtil.Add(QueryParameters, "SourceType", value);
			}
		}

		public string SnapshotVersion
		{
			get
			{
				return snapshotVersion;
			}
			set	
			{
				snapshotVersion = value;
				DictionaryUtil.Add(QueryParameters, "SnapshotVersion", value);
			}
		}

		public string Includes
		{
			get
			{
				return includes;
			}
			set	
			{
				includes = value;
				DictionaryUtil.Add(QueryParameters, "Includes", value);
			}
		}

		public string Target
		{
			get
			{
				return target;
			}
			set	
			{
				target = value;
				DictionaryUtil.Add(QueryParameters, "Target", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateRestoreJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateRestoreJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
