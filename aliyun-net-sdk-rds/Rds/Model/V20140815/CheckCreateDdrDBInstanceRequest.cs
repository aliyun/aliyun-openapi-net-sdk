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
    public class CheckCreateDdrDBInstanceRequest : RpcAcsRequest<CheckCreateDdrDBInstanceResponse>
    {
        public CheckCreateDdrDBInstanceRequest()
            : base("Rds", "2014-08-15", "CheckCreateDdrDBInstance", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private int? dBInstanceStorage;

		private string sourceDBInstanceName;

		private string binlogRole;

		private string engineVersion;

		private string engine;

		private string restoreTime;

		private string resourceOwnerAccount;

		private string backupSetId;

		private long? ownerId;

		private string binlogPosition;

		private string dBInstanceClass;

		private string restoreType;

		private string binlogName;

		private string sourceRegion;

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

		public int? DBInstanceStorage
		{
			get
			{
				return dBInstanceStorage;
			}
			set	
			{
				dBInstanceStorage = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceStorage", value.ToString());
			}
		}

		public string SourceDBInstanceName
		{
			get
			{
				return sourceDBInstanceName;
			}
			set	
			{
				sourceDBInstanceName = value;
				DictionaryUtil.Add(QueryParameters, "SourceDBInstanceName", value);
			}
		}

		public string BinlogRole
		{
			get
			{
				return binlogRole;
			}
			set	
			{
				binlogRole = value;
				DictionaryUtil.Add(QueryParameters, "BinlogRole", value);
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

		public string RestoreTime
		{
			get
			{
				return restoreTime;
			}
			set	
			{
				restoreTime = value;
				DictionaryUtil.Add(QueryParameters, "RestoreTime", value);
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

		public string BackupSetId
		{
			get
			{
				return backupSetId;
			}
			set	
			{
				backupSetId = value;
				DictionaryUtil.Add(QueryParameters, "BackupSetId", value);
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

		public string BinlogPosition
		{
			get
			{
				return binlogPosition;
			}
			set	
			{
				binlogPosition = value;
				DictionaryUtil.Add(QueryParameters, "BinlogPosition", value);
			}
		}

		public string DBInstanceClass
		{
			get
			{
				return dBInstanceClass;
			}
			set	
			{
				dBInstanceClass = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceClass", value);
			}
		}

		public string RestoreType
		{
			get
			{
				return restoreType;
			}
			set	
			{
				restoreType = value;
				DictionaryUtil.Add(QueryParameters, "RestoreType", value);
			}
		}

		public string BinlogName
		{
			get
			{
				return binlogName;
			}
			set	
			{
				binlogName = value;
				DictionaryUtil.Add(QueryParameters, "BinlogName", value);
			}
		}

		public string SourceRegion
		{
			get
			{
				return sourceRegion;
			}
			set	
			{
				sourceRegion = value;
				DictionaryUtil.Add(QueryParameters, "SourceRegion", value);
			}
		}

        public override CheckCreateDdrDBInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CheckCreateDdrDBInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
