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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Smartag.Transform;
using Aliyun.Acs.Smartag.Transform.V20180313;
using System.Collections.Generic;

namespace Aliyun.Acs.Smartag.Model.V20180313
{
    public class CreateSAGLinkLevelHaRequest : RpcAcsRequest<CreateSAGLinkLevelHaResponse>
    {
        public CreateSAGLinkLevelHaRequest()
            : base("Smartag", "2018-03-13", "CreateSAGLinkLevelHa", "smartag", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string backupLinkId;

		private string resourceOwnerAccount;

		private string haType;

		private string ownerAccount;

		private string mainLinkRegionId;

		private string action;

		private string smartAGId;

		private long? ownerId;

		private string mainLinkId;

		private string backupLinkRegionId;

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

		public string BackupLinkId
		{
			get
			{
				return backupLinkId;
			}
			set	
			{
				backupLinkId = value;
				DictionaryUtil.Add(QueryParameters, "BackupLinkId", value);
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

		public string HaType
		{
			get
			{
				return haType;
			}
			set	
			{
				haType = value;
				DictionaryUtil.Add(QueryParameters, "HaType", value);
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

		public string MainLinkRegionId
		{
			get
			{
				return mainLinkRegionId;
			}
			set	
			{
				mainLinkRegionId = value;
				DictionaryUtil.Add(QueryParameters, "MainLinkRegionId", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string SmartAGId
		{
			get
			{
				return smartAGId;
			}
			set	
			{
				smartAGId = value;
				DictionaryUtil.Add(QueryParameters, "SmartAGId", value);
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

		public string MainLinkId
		{
			get
			{
				return mainLinkId;
			}
			set	
			{
				mainLinkId = value;
				DictionaryUtil.Add(QueryParameters, "MainLinkId", value);
			}
		}

		public string BackupLinkRegionId
		{
			get
			{
				return backupLinkRegionId;
			}
			set	
			{
				backupLinkRegionId = value;
				DictionaryUtil.Add(QueryParameters, "BackupLinkRegionId", value);
			}
		}

        public override CreateSAGLinkLevelHaResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateSAGLinkLevelHaResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}