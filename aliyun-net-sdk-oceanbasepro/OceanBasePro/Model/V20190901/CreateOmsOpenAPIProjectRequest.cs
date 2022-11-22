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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.OceanBasePro.Transform;
using Aliyun.Acs.OceanBasePro.Transform.V20190901;

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
    public class CreateOmsOpenAPIProjectRequest : RpcAcsRequest<CreateOmsOpenAPIProjectResponse>
    {
        public CreateOmsOpenAPIProjectRequest()
            : base("OceanBasePro", "2019-09-01", "CreateOmsOpenAPIProject", "oceanbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private DestConfig destConfig_;

		private int? pageNumber;

		private int? pageSize;

		private TransferMapping transferMapping_;

		private TransferStepConfig transferStepConfig_;

		private string workerGradeId;

		private string projectName;

		private SourceConfig sourceConfig_;

		private string businessName;

		private List<string> labelIds = new List<string>(){ };

		[JsonProperty(PropertyName = "DestConfig")]
		public DestConfig DestConfig_
		{
			get
			{
				return destConfig_;
			}

			set
			{
				destConfig_ = value;
				DictionaryUtil.Add(BodyParameters, "DestConfig", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "PageNumber")]
		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "PageSize")]
		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "TransferMapping")]
		public TransferMapping TransferMapping_
		{
			get
			{
				return transferMapping_;
			}

			set
			{
				transferMapping_ = value;
				DictionaryUtil.Add(BodyParameters, "TransferMapping", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "TransferStepConfig")]
		public TransferStepConfig TransferStepConfig_
		{
			get
			{
				return transferStepConfig_;
			}

			set
			{
				transferStepConfig_ = value;
				DictionaryUtil.Add(BodyParameters, "TransferStepConfig", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "WorkerGradeId")]
		public string WorkerGradeId
		{
			get
			{
				return workerGradeId;
			}
			set	
			{
				workerGradeId = value;
				DictionaryUtil.Add(BodyParameters, "WorkerGradeId", value);
			}
		}

		[JsonProperty(PropertyName = "ProjectName")]
		public string ProjectName
		{
			get
			{
				return projectName;
			}
			set	
			{
				projectName = value;
				DictionaryUtil.Add(BodyParameters, "ProjectName", value);
			}
		}

		[JsonProperty(PropertyName = "SourceConfig")]
		public SourceConfig SourceConfig_
		{
			get
			{
				return sourceConfig_;
			}

			set
			{
				sourceConfig_ = value;
				DictionaryUtil.Add(BodyParameters, "SourceConfig", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "BusinessName")]
		public string BusinessName
		{
			get
			{
				return businessName;
			}
			set	
			{
				businessName = value;
				DictionaryUtil.Add(BodyParameters, "BusinessName", value);
			}
		}

		[JsonProperty(PropertyName = "LabelIds")]
		public List<string> LabelIds
		{
			get
			{
				return labelIds;
			}

			set
			{
				labelIds = value;
				if(labelIds != null)
				{
					for (int depth1 = 0; depth1 < labelIds.Count; depth1++)
					{
						DictionaryUtil.Add(BodyParameters,"LabelIds." + (depth1 + 1), labelIds[depth1]);
					}
				}
			}
		}

		public class DestConfig
		{

			private long? sendMsgTimeout;

			private long? sequenceStartTimestamp;

			private int? partition;

			private string serializerType;

			private string endpointType;

			private string endpointId;

			private bool? sequenceEnable;

			private string partitionMode;

			private bool? enableMsgTrace;

			private string topicType;

			private string msgTags;

			private string producerGroup;

			[JsonProperty(PropertyName = "SendMsgTimeout")]
			public long? SendMsgTimeout
			{
				get
				{
					return sendMsgTimeout;
				}
				set	
				{
					sendMsgTimeout = value;
				}
			}

			[JsonProperty(PropertyName = "SequenceStartTimestamp")]
			public long? SequenceStartTimestamp
			{
				get
				{
					return sequenceStartTimestamp;
				}
				set	
				{
					sequenceStartTimestamp = value;
				}
			}

			[JsonProperty(PropertyName = "Partition")]
			public int? Partition
			{
				get
				{
					return partition;
				}
				set	
				{
					partition = value;
				}
			}

			[JsonProperty(PropertyName = "SerializerType")]
			public string SerializerType
			{
				get
				{
					return serializerType;
				}
				set	
				{
					serializerType = value;
				}
			}

			[JsonProperty(PropertyName = "EndpointType")]
			public string EndpointType
			{
				get
				{
					return endpointType;
				}
				set	
				{
					endpointType = value;
				}
			}

			[JsonProperty(PropertyName = "EndpointId")]
			public string EndpointId
			{
				get
				{
					return endpointId;
				}
				set	
				{
					endpointId = value;
				}
			}

			[JsonProperty(PropertyName = "SequenceEnable")]
			public bool? SequenceEnable
			{
				get
				{
					return sequenceEnable;
				}
				set	
				{
					sequenceEnable = value;
				}
			}

			[JsonProperty(PropertyName = "PartitionMode")]
			public string PartitionMode
			{
				get
				{
					return partitionMode;
				}
				set	
				{
					partitionMode = value;
				}
			}

			[JsonProperty(PropertyName = "EnableMsgTrace")]
			public bool? EnableMsgTrace
			{
				get
				{
					return enableMsgTrace;
				}
				set	
				{
					enableMsgTrace = value;
				}
			}

			[JsonProperty(PropertyName = "TopicType")]
			public string TopicType
			{
				get
				{
					return topicType;
				}
				set	
				{
					topicType = value;
				}
			}

			[JsonProperty(PropertyName = "MsgTags")]
			public string MsgTags
			{
				get
				{
					return msgTags;
				}
				set	
				{
					msgTags = value;
				}
			}

			[JsonProperty(PropertyName = "ProducerGroup")]
			public string ProducerGroup
			{
				get
				{
					return producerGroup;
				}
				set	
				{
					producerGroup = value;
				}
			}
		}

		public class TransferMapping
		{

			private string mode;

			private List<DatabasesItem> databases = new List<DatabasesItem>(){ };

			[JsonProperty(PropertyName = "Mode")]
			public string Mode
			{
				get
				{
					return mode;
				}
				set	
				{
					mode = value;
				}
			}

			[JsonProperty(PropertyName = "Databases")]
			public List<DatabasesItem> Databases
			{
				get
				{
					return databases;
				}
				set	
				{
					databases = value;
				}
			}

			public class DatabasesItem
			{

				private string mappedName;

				private List<TablesItem> tables = new List<TablesItem>(){ };

				private string databaseName;

				private string tenantName;

				private string databaseId;

				private string type;

				[JsonProperty(PropertyName = "MappedName")]
				public string MappedName
				{
					get
					{
						return mappedName;
					}
					set	
					{
						mappedName = value;
					}
				}

				[JsonProperty(PropertyName = "Tables")]
				public List<TablesItem> Tables
				{
					get
					{
						return tables;
					}
					set	
					{
						tables = value;
					}
				}

				[JsonProperty(PropertyName = "DatabaseName")]
				public string DatabaseName
				{
					get
					{
						return databaseName;
					}
					set	
					{
						databaseName = value;
					}
				}

				[JsonProperty(PropertyName = "TenantName")]
				public string TenantName
				{
					get
					{
						return tenantName;
					}
					set	
					{
						tenantName = value;
					}
				}

				[JsonProperty(PropertyName = "DatabaseId")]
				public string DatabaseId
				{
					get
					{
						return databaseId;
					}
					set	
					{
						databaseId = value;
					}
				}

				[JsonProperty(PropertyName = "Type")]
				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public class TablesItem
				{

					private string mappedName;

					private List<string> filterColumns = new List<string>(){ };

					private AdbTableSchema adbTableSchema_;

					private string tableId;

					private string whereClause;

					private List<string> shardColumns = new List<string>(){ };

					private string tableName;

					private string type;

					[JsonProperty(PropertyName = "MappedName")]
					public string MappedName
					{
						get
						{
							return mappedName;
						}
						set	
						{
							mappedName = value;
						}
					}

					[JsonProperty(PropertyName = "FilterColumns")]
					public List<string> FilterColumns
					{
						get
						{
							return filterColumns;
						}
						set	
						{
							filterColumns = value;
						}
					}

					[JsonProperty(PropertyName = "AdbTableSchema")]
					public AdbTableSchema AdbTableSchema_
					{
						get
						{
							return adbTableSchema_;
						}
						set	
						{
							adbTableSchema_ = value;
						}
					}

					[JsonProperty(PropertyName = "TableId")]
					public string TableId
					{
						get
						{
							return tableId;
						}
						set	
						{
							tableId = value;
						}
					}

					[JsonProperty(PropertyName = "WhereClause")]
					public string WhereClause
					{
						get
						{
							return whereClause;
						}
						set	
						{
							whereClause = value;
						}
					}

					[JsonProperty(PropertyName = "ShardColumns")]
					public List<string> ShardColumns
					{
						get
						{
							return shardColumns;
						}
						set	
						{
							shardColumns = value;
						}
					}

					[JsonProperty(PropertyName = "TableName")]
					public string TableName
					{
						get
						{
							return tableName;
						}
						set	
						{
							tableName = value;
						}
					}

					[JsonProperty(PropertyName = "Type")]
					public string Type
					{
						get
						{
							return type;
						}
						set	
						{
							type = value;
						}
					}

					public class AdbTableSchema
					{

						private List<string> primaryKeys = new List<string>(){ };

						private string partitionStatement;

						private int? partitionLifeCycle;

						private List<string> distributedKeys = new List<string>(){ };

						[JsonProperty(PropertyName = "PrimaryKeys")]
						public List<string> PrimaryKeys
						{
							get
							{
								return primaryKeys;
							}
							set	
							{
								primaryKeys = value;
							}
						}

						[JsonProperty(PropertyName = "PartitionStatement")]
						public string PartitionStatement
						{
							get
							{
								return partitionStatement;
							}
							set	
							{
								partitionStatement = value;
							}
						}

						[JsonProperty(PropertyName = "PartitionLifeCycle")]
						public int? PartitionLifeCycle
						{
							get
							{
								return partitionLifeCycle;
							}
							set	
							{
								partitionLifeCycle = value;
							}
						}

						[JsonProperty(PropertyName = "DistributedKeys")]
						public List<string> DistributedKeys
						{
							get
							{
								return distributedKeys;
							}
							set	
							{
								distributedKeys = value;
							}
						}
					}
				}
			}
		}

		public class TransferStepConfig
		{

			private IncrSyncStepTransferConfig incrSyncStepTransferConfig_;

			private bool? enableFullSync;

			private bool? enableIncrSync;

			private bool? enableStructSync;

			[JsonProperty(PropertyName = "IncrSyncStepTransferConfig")]
			public IncrSyncStepTransferConfig IncrSyncStepTransferConfig_
			{
				get
				{
					return incrSyncStepTransferConfig_;
				}
				set	
				{
					incrSyncStepTransferConfig_ = value;
				}
			}

			[JsonProperty(PropertyName = "EnableFullSync")]
			public bool? EnableFullSync
			{
				get
				{
					return enableFullSync;
				}
				set	
				{
					enableFullSync = value;
				}
			}

			[JsonProperty(PropertyName = "EnableIncrSync")]
			public bool? EnableIncrSync
			{
				get
				{
					return enableIncrSync;
				}
				set	
				{
					enableIncrSync = value;
				}
			}

			[JsonProperty(PropertyName = "EnableStructSync")]
			public bool? EnableStructSync
			{
				get
				{
					return enableStructSync;
				}
				set	
				{
					enableStructSync = value;
				}
			}

			public class IncrSyncStepTransferConfig
			{

				private bool? storeTransactionEnabled;

				private List<string> recordTypeList = new List<string>(){ };

				private string transferStepType;

				private long? storeLogKeptHour;

				private long? startTimestamp;

				[JsonProperty(PropertyName = "StoreTransactionEnabled")]
				public bool? StoreTransactionEnabled
				{
					get
					{
						return storeTransactionEnabled;
					}
					set	
					{
						storeTransactionEnabled = value;
					}
				}

				[JsonProperty(PropertyName = "RecordTypeList")]
				public List<string> RecordTypeList
				{
					get
					{
						return recordTypeList;
					}
					set	
					{
						recordTypeList = value;
					}
				}

				[JsonProperty(PropertyName = "TransferStepType")]
				public string TransferStepType
				{
					get
					{
						return transferStepType;
					}
					set	
					{
						transferStepType = value;
					}
				}

				[JsonProperty(PropertyName = "StoreLogKeptHour")]
				public long? StoreLogKeptHour
				{
					get
					{
						return storeLogKeptHour;
					}
					set	
					{
						storeLogKeptHour = value;
					}
				}

				[JsonProperty(PropertyName = "StartTimestamp")]
				public long? StartTimestamp
				{
					get
					{
						return startTimestamp;
					}
					set	
					{
						startTimestamp = value;
					}
				}
			}
		}

		public class SourceConfig
		{

			private long? sendMsgTimeout;

			private long? sequenceStartTimestamp;

			private int? partition;

			private string serializerType;

			private string endpointType;

			private string endpointId;

			private bool? sequenceEnable;

			private string partitionMode;

			private bool? enableMsgTrace;

			private string topicType;

			private string msgTags;

			private string producerGroup;

			[JsonProperty(PropertyName = "SendMsgTimeout")]
			public long? SendMsgTimeout
			{
				get
				{
					return sendMsgTimeout;
				}
				set	
				{
					sendMsgTimeout = value;
				}
			}

			[JsonProperty(PropertyName = "SequenceStartTimestamp")]
			public long? SequenceStartTimestamp
			{
				get
				{
					return sequenceStartTimestamp;
				}
				set	
				{
					sequenceStartTimestamp = value;
				}
			}

			[JsonProperty(PropertyName = "Partition")]
			public int? Partition
			{
				get
				{
					return partition;
				}
				set	
				{
					partition = value;
				}
			}

			[JsonProperty(PropertyName = "SerializerType")]
			public string SerializerType
			{
				get
				{
					return serializerType;
				}
				set	
				{
					serializerType = value;
				}
			}

			[JsonProperty(PropertyName = "EndpointType")]
			public string EndpointType
			{
				get
				{
					return endpointType;
				}
				set	
				{
					endpointType = value;
				}
			}

			[JsonProperty(PropertyName = "EndpointId")]
			public string EndpointId
			{
				get
				{
					return endpointId;
				}
				set	
				{
					endpointId = value;
				}
			}

			[JsonProperty(PropertyName = "SequenceEnable")]
			public bool? SequenceEnable
			{
				get
				{
					return sequenceEnable;
				}
				set	
				{
					sequenceEnable = value;
				}
			}

			[JsonProperty(PropertyName = "PartitionMode")]
			public string PartitionMode
			{
				get
				{
					return partitionMode;
				}
				set	
				{
					partitionMode = value;
				}
			}

			[JsonProperty(PropertyName = "EnableMsgTrace")]
			public bool? EnableMsgTrace
			{
				get
				{
					return enableMsgTrace;
				}
				set	
				{
					enableMsgTrace = value;
				}
			}

			[JsonProperty(PropertyName = "TopicType")]
			public string TopicType
			{
				get
				{
					return topicType;
				}
				set	
				{
					topicType = value;
				}
			}

			[JsonProperty(PropertyName = "MsgTags")]
			public string MsgTags
			{
				get
				{
					return msgTags;
				}
				set	
				{
					msgTags = value;
				}
			}

			[JsonProperty(PropertyName = "ProducerGroup")]
			public string ProducerGroup
			{
				get
				{
					return producerGroup;
				}
				set	
				{
					producerGroup = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateOmsOpenAPIProjectResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateOmsOpenAPIProjectResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
