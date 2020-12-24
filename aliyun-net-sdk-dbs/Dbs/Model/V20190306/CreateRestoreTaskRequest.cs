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
using Aliyun.Acs.Dbs.Transform;
using Aliyun.Acs.Dbs.Transform.V20190306;

namespace Aliyun.Acs.Dbs.Model.V20190306
{
    public class CreateRestoreTaskRequest : RpcAcsRequest<CreateRestoreTaskResponse>
    {
        public CreateRestoreTaskRequest()
            : base("Dbs", "2019-03-06", "CreateRestoreTask", "cbs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dbs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dbs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? backupGatewayId;

		private string destinationEndpointInstanceType;

		private string clientToken;

		private string backupPlanId;

		private string destinationEndpointRegion;

		private string crossRoleName;

		private string destinationEndpointUserName;

		private string restoreObjects;

		private string restoreTaskName;

		private string restoreHome;

		private string destinationEndpointOracleSID;

		private long? restoreTime;

		private string crossAliyunId;

		private string destinationEndpointInstanceID;

		private int? destinationEndpointPort;

		private string backupSetId;

		private string ownerId;

		private string restoreDir;

		private string destinationEndpointIP;

		private string destinationEndpointDatabaseName;

		private string duplicateConflict;

		private string destinationEndpointPassword;

		public long? BackupGatewayId
		{
			get
			{
				return backupGatewayId;
			}
			set	
			{
				backupGatewayId = value;
				DictionaryUtil.Add(QueryParameters, "BackupGatewayId", value.ToString());
			}
		}

		public string DestinationEndpointInstanceType
		{
			get
			{
				return destinationEndpointInstanceType;
			}
			set	
			{
				destinationEndpointInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpointInstanceType", value);
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string BackupPlanId
		{
			get
			{
				return backupPlanId;
			}
			set	
			{
				backupPlanId = value;
				DictionaryUtil.Add(QueryParameters, "BackupPlanId", value);
			}
		}

		public string DestinationEndpointRegion
		{
			get
			{
				return destinationEndpointRegion;
			}
			set	
			{
				destinationEndpointRegion = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpointRegion", value);
			}
		}

		public string CrossRoleName
		{
			get
			{
				return crossRoleName;
			}
			set	
			{
				crossRoleName = value;
				DictionaryUtil.Add(QueryParameters, "CrossRoleName", value);
			}
		}

		public string DestinationEndpointUserName
		{
			get
			{
				return destinationEndpointUserName;
			}
			set	
			{
				destinationEndpointUserName = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpointUserName", value);
			}
		}

		public string RestoreObjects
		{
			get
			{
				return restoreObjects;
			}
			set	
			{
				restoreObjects = value;
				DictionaryUtil.Add(QueryParameters, "RestoreObjects", value);
			}
		}

		public string RestoreTaskName
		{
			get
			{
				return restoreTaskName;
			}
			set	
			{
				restoreTaskName = value;
				DictionaryUtil.Add(QueryParameters, "RestoreTaskName", value);
			}
		}

		public string RestoreHome
		{
			get
			{
				return restoreHome;
			}
			set	
			{
				restoreHome = value;
				DictionaryUtil.Add(QueryParameters, "RestoreHome", value);
			}
		}

		public string DestinationEndpointOracleSID
		{
			get
			{
				return destinationEndpointOracleSID;
			}
			set	
			{
				destinationEndpointOracleSID = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpointOracleSID", value);
			}
		}

		public long? RestoreTime
		{
			get
			{
				return restoreTime;
			}
			set	
			{
				restoreTime = value;
				DictionaryUtil.Add(QueryParameters, "RestoreTime", value.ToString());
			}
		}

		public string CrossAliyunId
		{
			get
			{
				return crossAliyunId;
			}
			set	
			{
				crossAliyunId = value;
				DictionaryUtil.Add(QueryParameters, "CrossAliyunId", value);
			}
		}

		public string DestinationEndpointInstanceID
		{
			get
			{
				return destinationEndpointInstanceID;
			}
			set	
			{
				destinationEndpointInstanceID = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpointInstanceID", value);
			}
		}

		public int? DestinationEndpointPort
		{
			get
			{
				return destinationEndpointPort;
			}
			set	
			{
				destinationEndpointPort = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpointPort", value.ToString());
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

		public string OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value);
			}
		}

		public string RestoreDir
		{
			get
			{
				return restoreDir;
			}
			set	
			{
				restoreDir = value;
				DictionaryUtil.Add(QueryParameters, "RestoreDir", value);
			}
		}

		public string DestinationEndpointIP
		{
			get
			{
				return destinationEndpointIP;
			}
			set	
			{
				destinationEndpointIP = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpointIP", value);
			}
		}

		public string DestinationEndpointDatabaseName
		{
			get
			{
				return destinationEndpointDatabaseName;
			}
			set	
			{
				destinationEndpointDatabaseName = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpointDatabaseName", value);
			}
		}

		public string DuplicateConflict
		{
			get
			{
				return duplicateConflict;
			}
			set	
			{
				duplicateConflict = value;
				DictionaryUtil.Add(QueryParameters, "DuplicateConflict", value);
			}
		}

		public string DestinationEndpointPassword
		{
			get
			{
				return destinationEndpointPassword;
			}
			set	
			{
				destinationEndpointPassword = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpointPassword", value);
			}
		}

        public override CreateRestoreTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateRestoreTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
