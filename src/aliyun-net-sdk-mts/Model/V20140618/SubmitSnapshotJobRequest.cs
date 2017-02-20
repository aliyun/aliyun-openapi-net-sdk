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
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Mts.Transform.V20140618;

namespace Aliyun.Acs.Mts.Model.V20140618
{
    public class SubmitSnapshotJobRequest : RpcAcsRequest<SubmitSnapshotJobResponse>
    {
        public SubmitSnapshotJobRequest()
            : base("Mts", "2014-06-18", "SubmitSnapshotJob")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _input;

		private string _snapshotConfig;

		private string _userData;

		private string _pipelineId;

		private string _ownerAccount;

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return _resourceOwnerAccount;
			}
			set	
			{
				_resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return _resourceOwnerId;
			}
			set	
			{
				_resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string Input
		{
			get
			{
				return _input;
			}
			set	
			{
				_input = value;
				DictionaryUtil.Add(QueryParameters, "Input", value);
			}
		}

		public string SnapshotConfig
		{
			get
			{
				return _snapshotConfig;
			}
			set	
			{
				_snapshotConfig = value;
				DictionaryUtil.Add(QueryParameters, "SnapshotConfig", value);
			}
		}

		public string UserData
		{
			get
			{
				return _userData;
			}
			set	
			{
				_userData = value;
				DictionaryUtil.Add(QueryParameters, "UserData", value);
			}
		}

		public string PipelineId
		{
			get
			{
				return _pipelineId;
			}
			set	
			{
				_pipelineId = value;
				DictionaryUtil.Add(QueryParameters, "PipelineId", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return _ownerAccount;
			}
			set	
			{
				_ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

        public override SubmitSnapshotJobResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SubmitSnapshotJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}