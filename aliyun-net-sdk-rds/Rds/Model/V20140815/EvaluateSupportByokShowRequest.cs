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
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class EvaluateSupportByokShowRequest : RpcAcsRequest<EvaluateSupportByokShowResponse>
    {
        public EvaluateSupportByokShowRequest()
            : base("Rds", "2014-08-15", "EvaluateSupportByokShow", "Rds", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string nodeType;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string engineVersion;

		private long? ownerId;

		private string securityToken;

		private string engine;

		private string targetRegionId;

		private string dbInstanceStorageType;

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

		public string NodeType
		{
			get
			{
				return nodeType;
			}
			set	
			{
				nodeType = value;
				DictionaryUtil.Add(QueryParameters, "NodeType", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public string EngineVersion
		{
			get
			{
				return engineVersion;
			}
			set	
			{
				engineVersion = value;
				DictionaryUtil.Add(QueryParameters, "EngineVersion", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string Engine
		{
			get
			{
				return engine;
			}
			set	
			{
				engine = value;
				DictionaryUtil.Add(QueryParameters, "Engine", value);
			}
		}

		public string TargetRegionId
		{
			get
			{
				return targetRegionId;
			}
			set	
			{
				targetRegionId = value;
				DictionaryUtil.Add(QueryParameters, "TargetRegionId", value);
			}
		}

		public string DbInstanceStorageType
		{
			get
			{
				return dbInstanceStorageType;
			}
			set	
			{
				dbInstanceStorageType = value;
				DictionaryUtil.Add(QueryParameters, "DbInstanceStorageType", value);
			}
		}

        public override EvaluateSupportByokShowResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return EvaluateSupportByokShowResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
