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
    public class ConfigureSynchronizationJobRequest : RpcAcsRequest<ConfigureSynchronizationJobResponse>
    {
        public ConfigureSynchronizationJobRequest()
            : base("Dts", "2020-01-01", "ConfigureSynchronizationJob", "dts", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sourceEndpointInstanceId;

		private string checkpoint;

		private string destinationEndpointInstanceId;

		private string sourceEndpointIP;

		private string synchronizationObjects;

		private string destinationEndpointPassword;

		private bool? dataInitialization;

		private bool? structureInitialization;

		private bool? partitionKeyModifyTime_Minute;

		private bool? partitionKeyModifyTime_Day;

		private string sourceEndpointInstanceType;

		private string synchronizationJobId;

		private string synchronizationJobName;

		private string accountId;

		private string sourceEndpointUserName;

		private string sourceEndpointDatabaseName;

		private bool? partitionKeyModifyTime_Month;

		private string sourceEndpointPort;

		private string sourceEndpointOwnerID;

		private string destinationEndpointUserName;

		private string destinationEndpointPort;

		private bool? partitionKeyModifyTime_Year;

		private string sourceEndpointRole;

		private string ownerId;

		private bool? partitionKeyModifyTime_Hour;

		private string destinationEndpointDataBaseName;

		private string sourceEndpointPassword;

		private string migrationReserved;

		private string destinationEndpointIP;

		private string destinationEndpointInstanceType;

		private string synchronizationDirection;

		public string SourceEndpointInstanceId
		{
			get
			{
				return sourceEndpointInstanceId;
			}
			set	
			{
				sourceEndpointInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpoint.InstanceId", value);
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

		public string DestinationEndpointInstanceId
		{
			get
			{
				return destinationEndpointInstanceId;
			}
			set	
			{
				destinationEndpointInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpoint.InstanceId", value);
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

		public string SynchronizationObjects
		{
			get
			{
				return synchronizationObjects;
			}
			set	
			{
				synchronizationObjects = value;
				DictionaryUtil.Add(BodyParameters, "SynchronizationObjects", value);
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

		public bool? DataInitialization
		{
			get
			{
				return dataInitialization;
			}
			set	
			{
				dataInitialization = value;
				DictionaryUtil.Add(QueryParameters, "DataInitialization", value.ToString());
			}
		}

		public bool? StructureInitialization
		{
			get
			{
				return structureInitialization;
			}
			set	
			{
				structureInitialization = value;
				DictionaryUtil.Add(QueryParameters, "StructureInitialization", value.ToString());
			}
		}

		public bool? PartitionKeyModifyTime_Minute
		{
			get
			{
				return partitionKeyModifyTime_Minute;
			}
			set	
			{
				partitionKeyModifyTime_Minute = value;
				DictionaryUtil.Add(QueryParameters, "PartitionKey.ModifyTime_Minute", value.ToString());
			}
		}

		public bool? PartitionKeyModifyTime_Day
		{
			get
			{
				return partitionKeyModifyTime_Day;
			}
			set	
			{
				partitionKeyModifyTime_Day = value;
				DictionaryUtil.Add(QueryParameters, "PartitionKey.ModifyTime_Day", value.ToString());
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

		public string SynchronizationJobId
		{
			get
			{
				return synchronizationJobId;
			}
			set	
			{
				synchronizationJobId = value;
				DictionaryUtil.Add(QueryParameters, "SynchronizationJobId", value);
			}
		}

		public string SynchronizationJobName
		{
			get
			{
				return synchronizationJobName;
			}
			set	
			{
				synchronizationJobName = value;
				DictionaryUtil.Add(QueryParameters, "SynchronizationJobName", value);
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

		public bool? PartitionKeyModifyTime_Month
		{
			get
			{
				return partitionKeyModifyTime_Month;
			}
			set	
			{
				partitionKeyModifyTime_Month = value;
				DictionaryUtil.Add(QueryParameters, "PartitionKey.ModifyTime_Month", value.ToString());
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

		public bool? PartitionKeyModifyTime_Year
		{
			get
			{
				return partitionKeyModifyTime_Year;
			}
			set	
			{
				partitionKeyModifyTime_Year = value;
				DictionaryUtil.Add(QueryParameters, "PartitionKey.ModifyTime_Year", value.ToString());
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

		public bool? PartitionKeyModifyTime_Hour
		{
			get
			{
				return partitionKeyModifyTime_Hour;
			}
			set	
			{
				partitionKeyModifyTime_Hour = value;
				DictionaryUtil.Add(QueryParameters, "PartitionKey.ModifyTime_Hour", value.ToString());
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

		public string SynchronizationDirection
		{
			get
			{
				return synchronizationDirection;
			}
			set	
			{
				synchronizationDirection = value;
				DictionaryUtil.Add(QueryParameters, "SynchronizationDirection", value);
			}
		}

        public override ConfigureSynchronizationJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ConfigureSynchronizationJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
