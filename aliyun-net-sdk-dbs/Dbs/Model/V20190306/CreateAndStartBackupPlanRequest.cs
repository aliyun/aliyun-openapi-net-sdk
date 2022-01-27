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
    public class CreateAndStartBackupPlanRequest : RpcAcsRequest<CreateAndStartBackupPlanResponse>
    {
        public CreateAndStartBackupPlanRequest()
            : base("Dbs", "2019-03-06", "CreateAndStartBackupPlan", "cbs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dbs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dbs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string databaseType;

		private long? backupGatewayId;

		private string sourceEndpointUserName;

		private string storageType;

		private string databaseRegion;

		private string backupStartTime;

		private string sourceEndpointIP;

		private string crossRoleName;

		private string backupStorageType;

		private int? duplicationArchivePeriod;

		private string period;

		private int? backupLogIntervalSeconds;

		private string fromApp;

		private string sourceEndpointPassword;

		private string ownerId;

		private string backupMethod;

		private int? backupRetentionPeriod;

		private string backupPeriod;

		private long? backupSpeedLimit;

		private string sourceEndpointInstanceType;

		private string backupPlanName;

		private string oSSBucketName;

		private string region;

		private string sourceEndpointRegion;

		private string sourceEndpointInstanceID;

		private string clientToken;

		private string backupPlanId;

		private string instanceClass;

		private string sourceEndpointDatabaseName;

		private int? duplicationInfrequentAccessPeriod;

		private string instanceType;

		private bool? enableBackupLog;

		private string crossAliyunId;

		private string backupObjects;

		private long? backupRateLimit;

		private int? usedTime;

		private int? sourceEndpointPort;

		private string storageRegion;

		private string sourceEndpointOracleSID;

		private string backupStrategyType;

		private string payType;

		public string DatabaseType
		{
			get
			{
				return databaseType;
			}
			set	
			{
				databaseType = value;
				DictionaryUtil.Add(QueryParameters, "DatabaseType", value);
			}
		}

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

		public string SourceEndpointUserName
		{
			get
			{
				return sourceEndpointUserName;
			}
			set	
			{
				sourceEndpointUserName = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointUserName", value);
			}
		}

		public string StorageType
		{
			get
			{
				return storageType;
			}
			set	
			{
				storageType = value;
				DictionaryUtil.Add(QueryParameters, "StorageType", value);
			}
		}

		public string DatabaseRegion
		{
			get
			{
				return databaseRegion;
			}
			set	
			{
				databaseRegion = value;
				DictionaryUtil.Add(QueryParameters, "DatabaseRegion", value);
			}
		}

		public string BackupStartTime
		{
			get
			{
				return backupStartTime;
			}
			set	
			{
				backupStartTime = value;
				DictionaryUtil.Add(QueryParameters, "BackupStartTime", value);
			}
		}

		public string SourceEndpointIP
		{
			get
			{
				return sourceEndpointIP;
			}
			set	
			{
				sourceEndpointIP = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointIP", value);
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

		public string BackupStorageType
		{
			get
			{
				return backupStorageType;
			}
			set	
			{
				backupStorageType = value;
				DictionaryUtil.Add(QueryParameters, "BackupStorageType", value);
			}
		}

		public int? DuplicationArchivePeriod
		{
			get
			{
				return duplicationArchivePeriod;
			}
			set	
			{
				duplicationArchivePeriod = value;
				DictionaryUtil.Add(QueryParameters, "DuplicationArchivePeriod", value.ToString());
			}
		}

		public string Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value);
			}
		}

		public int? BackupLogIntervalSeconds
		{
			get
			{
				return backupLogIntervalSeconds;
			}
			set	
			{
				backupLogIntervalSeconds = value;
				DictionaryUtil.Add(QueryParameters, "BackupLogIntervalSeconds", value.ToString());
			}
		}

		public string FromApp
		{
			get
			{
				return fromApp;
			}
			set	
			{
				fromApp = value;
				DictionaryUtil.Add(QueryParameters, "FromApp", value);
			}
		}

		public string SourceEndpointPassword
		{
			get
			{
				return sourceEndpointPassword;
			}
			set	
			{
				sourceEndpointPassword = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointPassword", value);
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

		public string BackupMethod
		{
			get
			{
				return backupMethod;
			}
			set	
			{
				backupMethod = value;
				DictionaryUtil.Add(QueryParameters, "BackupMethod", value);
			}
		}

		public int? BackupRetentionPeriod
		{
			get
			{
				return backupRetentionPeriod;
			}
			set	
			{
				backupRetentionPeriod = value;
				DictionaryUtil.Add(QueryParameters, "BackupRetentionPeriod", value.ToString());
			}
		}

		public string BackupPeriod
		{
			get
			{
				return backupPeriod;
			}
			set	
			{
				backupPeriod = value;
				DictionaryUtil.Add(QueryParameters, "BackupPeriod", value);
			}
		}

		public long? BackupSpeedLimit
		{
			get
			{
				return backupSpeedLimit;
			}
			set	
			{
				backupSpeedLimit = value;
				DictionaryUtil.Add(QueryParameters, "BackupSpeedLimit", value.ToString());
			}
		}

		public string SourceEndpointInstanceType
		{
			get
			{
				return sourceEndpointInstanceType;
			}
			set	
			{
				sourceEndpointInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointInstanceType", value);
			}
		}

		public string BackupPlanName
		{
			get
			{
				return backupPlanName;
			}
			set	
			{
				backupPlanName = value;
				DictionaryUtil.Add(QueryParameters, "BackupPlanName", value);
			}
		}

		public string OSSBucketName
		{
			get
			{
				return oSSBucketName;
			}
			set	
			{
				oSSBucketName = value;
				DictionaryUtil.Add(QueryParameters, "OSSBucketName", value);
			}
		}

		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(QueryParameters, "Region", value);
			}
		}

		public string SourceEndpointRegion
		{
			get
			{
				return sourceEndpointRegion;
			}
			set	
			{
				sourceEndpointRegion = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointRegion", value);
			}
		}

		public string SourceEndpointInstanceID
		{
			get
			{
				return sourceEndpointInstanceID;
			}
			set	
			{
				sourceEndpointInstanceID = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointInstanceID", value);
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

		public string InstanceClass
		{
			get
			{
				return instanceClass;
			}
			set	
			{
				instanceClass = value;
				DictionaryUtil.Add(QueryParameters, "InstanceClass", value);
			}
		}

		public string SourceEndpointDatabaseName
		{
			get
			{
				return sourceEndpointDatabaseName;
			}
			set	
			{
				sourceEndpointDatabaseName = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointDatabaseName", value);
			}
		}

		public int? DuplicationInfrequentAccessPeriod
		{
			get
			{
				return duplicationInfrequentAccessPeriod;
			}
			set	
			{
				duplicationInfrequentAccessPeriod = value;
				DictionaryUtil.Add(QueryParameters, "DuplicationInfrequentAccessPeriod", value.ToString());
			}
		}

		public string InstanceType
		{
			get
			{
				return instanceType;
			}
			set	
			{
				instanceType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		public bool? EnableBackupLog
		{
			get
			{
				return enableBackupLog;
			}
			set	
			{
				enableBackupLog = value;
				DictionaryUtil.Add(QueryParameters, "EnableBackupLog", value.ToString());
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

		public string BackupObjects
		{
			get
			{
				return backupObjects;
			}
			set	
			{
				backupObjects = value;
				DictionaryUtil.Add(QueryParameters, "BackupObjects", value);
			}
		}

		public long? BackupRateLimit
		{
			get
			{
				return backupRateLimit;
			}
			set	
			{
				backupRateLimit = value;
				DictionaryUtil.Add(QueryParameters, "BackupRateLimit", value.ToString());
			}
		}

		public int? UsedTime
		{
			get
			{
				return usedTime;
			}
			set	
			{
				usedTime = value;
				DictionaryUtil.Add(QueryParameters, "UsedTime", value.ToString());
			}
		}

		public int? SourceEndpointPort
		{
			get
			{
				return sourceEndpointPort;
			}
			set	
			{
				sourceEndpointPort = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointPort", value.ToString());
			}
		}

		public string StorageRegion
		{
			get
			{
				return storageRegion;
			}
			set	
			{
				storageRegion = value;
				DictionaryUtil.Add(QueryParameters, "StorageRegion", value);
			}
		}

		public string SourceEndpointOracleSID
		{
			get
			{
				return sourceEndpointOracleSID;
			}
			set	
			{
				sourceEndpointOracleSID = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointOracleSID", value);
			}
		}

		public string BackupStrategyType
		{
			get
			{
				return backupStrategyType;
			}
			set	
			{
				backupStrategyType = value;
				DictionaryUtil.Add(QueryParameters, "BackupStrategyType", value);
			}
		}

		public string PayType
		{
			get
			{
				return payType;
			}
			set	
			{
				payType = value;
				DictionaryUtil.Add(QueryParameters, "PayType", value);
			}
		}

        public override CreateAndStartBackupPlanResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateAndStartBackupPlanResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
