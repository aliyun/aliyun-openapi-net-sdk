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
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class SwitchDBInstanceHaRequest : RpcAcsRequest<SwitchDBInstanceHaResponse>
    {
        public SwitchDBInstanceHaRequest()
            : base("Rds", "2014-08-15", "SwitchDBInstanceHA")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _dBInstanceId;

		private string _nodeId;

		private string _operation;

		private string _force;

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

		public string DBInstanceId
		{
			get
			{
				return _dBInstanceId;
			}
			set	
			{
				_dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
			}
		}

		public string NodeId
		{
			get
			{
				return _nodeId;
			}
			set	
			{
				_nodeId = value;
				DictionaryUtil.Add(QueryParameters, "NodeId", value);
			}
		}

		public string Operation
		{
			get
			{
				return _operation;
			}
			set	
			{
				_operation = value;
				DictionaryUtil.Add(QueryParameters, "Operation", value);
			}
		}

		public string Force
		{
			get
			{
				return _force;
			}
			set	
			{
				_force = value;
				DictionaryUtil.Add(QueryParameters, "Force", value);
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

        public override SwitchDBInstanceHaResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SwitchDBInstanceHaResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}