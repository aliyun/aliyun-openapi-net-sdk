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
using Aliyun.Acs.Dts.Transform;
using Aliyun.Acs.Dts.Transform.V20200101;

namespace Aliyun.Acs.Dts.Model.V20200101
{
    public class ConfigureMigrationJobRequest : RpcAcsRequest<ConfigureMigrationJobResponse>
    {
        public ConfigureMigrationJobRequest()
            : base("Dts", "2020-01-01", "ConfigureMigrationJob", "dts", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sourceEndpointInstanceID;

		private string checkpoint;

		private string sourceEndpointEngineName;

		private string sourceEndpointOracleSID;

		private string destinationEndpointInstanceID;

		private string sourceEndpointIP;

		private string destinationEndpointPassword;

		private string migrationObject;

		private bool? migrationModeDataIntialization;

		private string migrationJobId;

		private string sourceEndpointInstanceType;

		private string destinationEndpointEngineName;

		private string accountId;

		private bool? migrationModeStructureIntialization;

		private bool? migrationModeDataSynchronization;

		private string destinationEndpointRegion;

		private string sourceEndpointUserName;

		private string sourceEndpointDatabaseName;

		private string sourceEndpointPort;

		private string sourceEndpointOwnerID;

		private string destinationEndpointUserName;

		private string destinationEndpointOracleSID;

		private string destinationEndpointPort;

		private string sourceEndpointRegion;

		private string sourceEndpointRole;

		private string ownerId;

		private string destinationEndpointDataBaseName;

		private string sourceEndpointPassword;

		private string migrationReserved;

		private string destinationEndpointIP;

		private string migrationJobName;

		private string destinationEndpointInstanceType;

		public string SourceEndpointInstanceID
		{
			get
			{
				return sourceEndpointInstanceID;
			}
			set	
			{
				sourceEndpointInstanceID = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.InstanceID", value);
			}
		}

		public string Checkpoint
		{
			get
			{
				return checkpoint;
			}
			set	
			{
				checkpoint = value;
				DictionaryUtil.Add(QueryParameters, "Checkpoint", value);
			}
		}

		public string SourceEndpointEngineName
		{
			get
			{
				return sourceEndpointEngineName;
			}
			set	
			{
				sourceEndpointEngineName = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.EngineName", value);
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
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.OracleSID", value);
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
				DictionaryUtil.Add(QueryParameters, "DestinationEndpoint.InstanceID", value);
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
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.IP", value);
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
				DictionaryUtil.Add(QueryParameters, "DestinationEndpoint.Password", value);
			}
		}

		public string MigrationObject
		{
			get
			{
				return migrationObject;
			}
			set	
			{
				migrationObject = value;
				DictionaryUtil.Add(BodyParameters, "MigrationObject", value);
			}
		}

		public bool? MigrationModeDataIntialization
		{
			get
			{
				return migrationModeDataIntialization;
			}
			set	
			{
				migrationModeDataIntialization = value;
				DictionaryUtil.Add(QueryParameters, "MigrationMode.DataIntialization", value.ToString());
			}
		}

		public string MigrationJobId
		{
			get
			{
				return migrationJobId;
			}
			set	
			{
				migrationJobId = value;
				DictionaryUtil.Add(QueryParameters, "MigrationJobId", value);
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
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.InstanceType", value);
			}
		}

		public string DestinationEndpointEngineName
		{
			get
			{
				return destinationEndpointEngineName;
			}
			set	
			{
				destinationEndpointEngineName = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpoint.EngineName", value);
			}
		}

		public string AccountId
		{
			get
			{
				return accountId;
			}
			set	
			{
				accountId = value;
				DictionaryUtil.Add(QueryParameters, "AccountId", value);
			}
		}

		public bool? MigrationModeStructureIntialization
		{
			get
			{
				return migrationModeStructureIntialization;
			}
			set	
			{
				migrationModeStructureIntialization = value;
				DictionaryUtil.Add(QueryParameters, "MigrationMode.StructureIntialization", value.ToString());
			}
		}

		public bool? MigrationModeDataSynchronization
		{
			get
			{
				return migrationModeDataSynchronization;
			}
			set	
			{
				migrationModeDataSynchronization = value;
				DictionaryUtil.Add(QueryParameters, "MigrationMode.DataSynchronization", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "DestinationEndpoint.Region", value);
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
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.UserName", value);
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
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.DatabaseName", value);
			}
		}

		public string SourceEndpointPort
		{
			get
			{
				return sourceEndpointPort;
			}
			set	
			{
				sourceEndpointPort = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.Port", value);
			}
		}

		public string SourceEndpointOwnerID
		{
			get
			{
				return sourceEndpointOwnerID;
			}
			set	
			{
				sourceEndpointOwnerID = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.OwnerID", value);
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
				DictionaryUtil.Add(QueryParameters, "DestinationEndpoint.UserName", value);
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
				DictionaryUtil.Add(QueryParameters, "DestinationEndpoint.OracleSID", value);
			}
		}

		public string DestinationEndpointPort
		{
			get
			{
				return destinationEndpointPort;
			}
			set	
			{
				destinationEndpointPort = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpoint.Port", value);
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
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.Region", value);
			}
		}

		public string SourceEndpointRole
		{
			get
			{
				return sourceEndpointRole;
			}
			set	
			{
				sourceEndpointRole = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.Role", value);
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

		public string DestinationEndpointDataBaseName
		{
			get
			{
				return destinationEndpointDataBaseName;
			}
			set	
			{
				destinationEndpointDataBaseName = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpoint.DataBaseName", value);
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
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.Password", value);
			}
		}

		public string MigrationReserved
		{
			get
			{
				return migrationReserved;
			}
			set	
			{
				migrationReserved = value;
				DictionaryUtil.Add(QueryParameters, "MigrationReserved", value);
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
				DictionaryUtil.Add(QueryParameters, "DestinationEndpoint.IP", value);
			}
		}

		public string MigrationJobName
		{
			get
			{
				return migrationJobName;
			}
			set	
			{
				migrationJobName = value;
				DictionaryUtil.Add(QueryParameters, "MigrationJobName", value);
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
				DictionaryUtil.Add(QueryParameters, "DestinationEndpoint.InstanceType", value);
			}
		}

        public override ConfigureMigrationJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ConfigureMigrationJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
