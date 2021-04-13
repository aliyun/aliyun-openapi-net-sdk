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
    public class ConfigureDtsJobRequest : RpcAcsRequest<ConfigureDtsJobResponse>
    {
        public ConfigureDtsJobRequest()
            : base("Dts", "2020-01-01", "ConfigureDtsJob", "dts", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string checkpoint;

		private string sourceEndpointUserName;

		private string delayPhone;

		private string sourceEndpointIP;

		private string errorPhone;

		private string destinationEndpointUserName;

		private string dtsJobId;

		private string dbList;

		private string destinationEndpointOracleSID;

		private string destinationEndpointPort;

		private string sourceEndpointPassword;

		private string ownerId;

		private string jobType;

		private long? delayRuleTime;

		private string destinationEndpointIP;

		private string sourceEndpointInstanceType;

		private string dtsJobName;

		private string dtsInstanceId;

		private string synchronizationDirection;

		private string sourceEndpointRegion;

		private bool? delayNotice;

		private string destinationEndpointInstanceType;

		private bool? dataInitialization;

		private string sourceEndpointInstanceID;

		private bool? structureInitialization;

		private string sourceEndpointOwnerID;

		private string sourceEndpointDatabaseName;

		private string destinationEndpointRegion;

		private string reserve;

		private bool? dataSynchronization;

		private string destinationEndpointEngineName;

		private string destinationEndpointInstanceID;

		private string sourceEndpointPort;

		private string sourceEndpointOracleSID;

		private string destinationEndpointDataBaseName;

		private bool? errorNotice;

		private string sourceEndpointRole;

		private string destinationEndpointPassword;

		private string sourceEndpointEngineName;

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

		public string DelayPhone
		{
			get
			{
				return delayPhone;
			}
			set	
			{
				delayPhone = value;
				DictionaryUtil.Add(QueryParameters, "DelayPhone", value);
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

		public string ErrorPhone
		{
			get
			{
				return errorPhone;
			}
			set	
			{
				errorPhone = value;
				DictionaryUtil.Add(QueryParameters, "ErrorPhone", value);
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

		public string DtsJobId
		{
			get
			{
				return dtsJobId;
			}
			set	
			{
				dtsJobId = value;
				DictionaryUtil.Add(QueryParameters, "DtsJobId", value);
			}
		}

		public string DbList
		{
			get
			{
				return dbList;
			}
			set	
			{
				dbList = value;
				DictionaryUtil.Add(QueryParameters, "DbList", value);
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

		public string DestinationEndpointPort
		{
			get
			{
				return destinationEndpointPort;
			}
			set	
			{
				destinationEndpointPort = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpointPort", value);
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

		public string JobType
		{
			get
			{
				return jobType;
			}
			set	
			{
				jobType = value;
				DictionaryUtil.Add(QueryParameters, "JobType", value);
			}
		}

		public long? DelayRuleTime
		{
			get
			{
				return delayRuleTime;
			}
			set	
			{
				delayRuleTime = value;
				DictionaryUtil.Add(QueryParameters, "DelayRuleTime", value.ToString());
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

		public string DtsJobName
		{
			get
			{
				return dtsJobName;
			}
			set	
			{
				dtsJobName = value;
				DictionaryUtil.Add(QueryParameters, "DtsJobName", value);
			}
		}

		public string DtsInstanceId
		{
			get
			{
				return dtsInstanceId;
			}
			set	
			{
				dtsInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DtsInstanceId", value);
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

		public bool? DelayNotice
		{
			get
			{
				return delayNotice;
			}
			set	
			{
				delayNotice = value;
				DictionaryUtil.Add(QueryParameters, "DelayNotice", value.ToString());
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

		public string SourceEndpointOwnerID
		{
			get
			{
				return sourceEndpointOwnerID;
			}
			set	
			{
				sourceEndpointOwnerID = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointOwnerID", value);
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

		public string Reserve
		{
			get
			{
				return reserve;
			}
			set	
			{
				reserve = value;
				DictionaryUtil.Add(QueryParameters, "Reserve", value);
			}
		}

		public bool? DataSynchronization
		{
			get
			{
				return dataSynchronization;
			}
			set	
			{
				dataSynchronization = value;
				DictionaryUtil.Add(QueryParameters, "DataSynchronization", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "DestinationEndpointEngineName", value);
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

		public string SourceEndpointPort
		{
			get
			{
				return sourceEndpointPort;
			}
			set	
			{
				sourceEndpointPort = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointPort", value);
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

		public string DestinationEndpointDataBaseName
		{
			get
			{
				return destinationEndpointDataBaseName;
			}
			set	
			{
				destinationEndpointDataBaseName = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpointDataBaseName", value);
			}
		}

		public bool? ErrorNotice
		{
			get
			{
				return errorNotice;
			}
			set	
			{
				errorNotice = value;
				DictionaryUtil.Add(QueryParameters, "ErrorNotice", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "SourceEndpointRole", value);
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

		public string SourceEndpointEngineName
		{
			get
			{
				return sourceEndpointEngineName;
			}
			set	
			{
				sourceEndpointEngineName = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointEngineName", value);
			}
		}

        public override ConfigureDtsJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ConfigureDtsJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
