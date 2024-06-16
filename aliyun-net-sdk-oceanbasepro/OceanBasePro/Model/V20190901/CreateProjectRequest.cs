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
    public class CreateProjectRequest : RpcAcsRequest<CreateProjectResponse>
    {
        public CreateProjectRequest()
            : base("OceanBasePro", "2019-09-01", "CreateProject", "oceanbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sinkEndpointId;

		private bool? useOss;

		private string ossKey;

		private string sourceEndpointId;

		private string type;

		private FullTransferConfig fullTransferConfig_;

		private bool? enableStructTransfer;

		private TransferMapping transferMapping_;

		private string workerGradeId;

		private CommonTransferConfig commonTransferConfig_;

		private StructTransferConfig structTransferConfig_;

		private bool? enableIncrTransfer;

		private bool? enableFullTransfer;

		private bool? enableFullVerify;

		private string name;

		private List<string> labelIds = new List<string>(){ };

		private IncrTransferConfig incrTransferConfig_;

		private bool? enableReverseIncrTransfer;

		[JsonProperty(PropertyName = "SinkEndpointId")]
		public string SinkEndpointId
		{
			get
			{
				return sinkEndpointId;
			}
			set	
			{
				sinkEndpointId = value;
				DictionaryUtil.Add(BodyParameters, "SinkEndpointId", value);
			}
		}

		[JsonProperty(PropertyName = "UseOss")]
		public bool? UseOss
		{
			get
			{
				return useOss;
			}
			set	
			{
				useOss = value;
				DictionaryUtil.Add(BodyParameters, "UseOss", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "OssKey")]
		public string OssKey
		{
			get
			{
				return ossKey;
			}
			set	
			{
				ossKey = value;
				DictionaryUtil.Add(BodyParameters, "OssKey", value);
			}
		}

		[JsonProperty(PropertyName = "SourceEndpointId")]
		public string SourceEndpointId
		{
			get
			{
				return sourceEndpointId;
			}
			set	
			{
				sourceEndpointId = value;
				DictionaryUtil.Add(BodyParameters, "SourceEndpointId", value);
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
				DictionaryUtil.Add(BodyParameters, "Type", value);
			}
		}

		[JsonProperty(PropertyName = "FullTransferConfig")]
		public FullTransferConfig FullTransferConfig_
		{
			get
			{
				return fullTransferConfig_;
			}

			set
			{
				fullTransferConfig_ = value;
				DictionaryUtil.Add(BodyParameters, "FullTransferConfig", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "EnableStructTransfer")]
		public bool? EnableStructTransfer
		{
			get
			{
				return enableStructTransfer;
			}
			set	
			{
				enableStructTransfer = value;
				DictionaryUtil.Add(BodyParameters, "EnableStructTransfer", value.ToString());
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

		[JsonProperty(PropertyName = "CommonTransferConfig")]
		public CommonTransferConfig CommonTransferConfig_
		{
			get
			{
				return commonTransferConfig_;
			}

			set
			{
				commonTransferConfig_ = value;
				DictionaryUtil.Add(BodyParameters, "CommonTransferConfig", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "StructTransferConfig")]
		public StructTransferConfig StructTransferConfig_
		{
			get
			{
				return structTransferConfig_;
			}

			set
			{
				structTransferConfig_ = value;
				DictionaryUtil.Add(BodyParameters, "StructTransferConfig", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "EnableIncrTransfer")]
		public bool? EnableIncrTransfer
		{
			get
			{
				return enableIncrTransfer;
			}
			set	
			{
				enableIncrTransfer = value;
				DictionaryUtil.Add(BodyParameters, "EnableIncrTransfer", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "EnableFullTransfer")]
		public bool? EnableFullTransfer
		{
			get
			{
				return enableFullTransfer;
			}
			set	
			{
				enableFullTransfer = value;
				DictionaryUtil.Add(BodyParameters, "EnableFullTransfer", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "EnableFullVerify")]
		public bool? EnableFullVerify
		{
			get
			{
				return enableFullVerify;
			}
			set	
			{
				enableFullVerify = value;
				DictionaryUtil.Add(BodyParameters, "EnableFullVerify", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Name")]
		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(BodyParameters, "Name", value);
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

		[JsonProperty(PropertyName = "IncrTransferConfig")]
		public IncrTransferConfig IncrTransferConfig_
		{
			get
			{
				return incrTransferConfig_;
			}

			set
			{
				incrTransferConfig_ = value;
				DictionaryUtil.Add(BodyParameters, "IncrTransferConfig", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "EnableReverseIncrTransfer")]
		public bool? EnableReverseIncrTransfer
		{
			get
			{
				return enableReverseIncrTransfer;
			}
			set	
			{
				enableReverseIncrTransfer = value;
				DictionaryUtil.Add(BodyParameters, "EnableReverseIncrTransfer", value.ToString());
			}
		}

		public class FullTransferConfig
		{

			private bool? nonePkUkTruncateDstTable;

			private string fullVerifySpeedMode;

			private string fullTransferSpeedMode;

			private bool? allowDestTableNotEmpty;

			[JsonProperty(PropertyName = "NonePkUkTruncateDstTable")]
			public bool? NonePkUkTruncateDstTable
			{
				get
				{
					return nonePkUkTruncateDstTable;
				}
				set	
				{
					nonePkUkTruncateDstTable = value;
				}
			}

			[JsonProperty(PropertyName = "FullVerifySpeedMode")]
			public string FullVerifySpeedMode
			{
				get
				{
					return fullVerifySpeedMode;
				}
				set	
				{
					fullVerifySpeedMode = value;
				}
			}

			[JsonProperty(PropertyName = "FullTransferSpeedMode")]
			public string FullTransferSpeedMode
			{
				get
				{
					return fullTransferSpeedMode;
				}
				set	
				{
					fullTransferSpeedMode = value;
				}
			}

			[JsonProperty(PropertyName = "AllowDestTableNotEmpty")]
			public bool? AllowDestTableNotEmpty
			{
				get
				{
					return allowDestTableNotEmpty;
				}
				set	
				{
					allowDestTableNotEmpty = value;
				}
			}
		}

		public class TransferMapping
		{

			private string mode;

			private List<DatabasesItem> databases = new List<DatabasesItem>(){ };

			private List<string> tableAndViewBlackList = new List<string>(){ };

			private List<DatabasesBlackItem> databasesBlack = new List<DatabasesBlackItem>(){ };

			private List<string> tableAndViewWhiteList = new List<string>(){ };

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

			[JsonProperty(PropertyName = "TableAndViewBlackList")]
			public List<string> TableAndViewBlackList
			{
				get
				{
					return tableAndViewBlackList;
				}
				set	
				{
					tableAndViewBlackList = value;
				}
			}

			[JsonProperty(PropertyName = "DatabasesBlack")]
			public List<DatabasesBlackItem> DatabasesBlack
			{
				get
				{
					return databasesBlack;
				}
				set	
				{
					databasesBlack = value;
				}
			}

			[JsonProperty(PropertyName = "TableAndViewWhiteList")]
			public List<string> TableAndViewWhiteList
			{
				get
				{
					return tableAndViewWhiteList;
				}
				set	
				{
					tableAndViewWhiteList = value;
				}
			}

			public class DatabasesItem
			{

				private string mappedName;

				private List<SpecificViewsItem> specificViews = new List<SpecificViewsItem>(){ };

				private List<TablesItem> tables = new List<TablesItem>(){ };

				private string clusterName;

				private string name;

				private string tenantName;

				private string id;

				private List<SpecificTablesItem> specificTables = new List<SpecificTablesItem>(){ };

				private List<ViewsItem> views = new List<ViewsItem>(){ };

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

				[JsonProperty(PropertyName = "SpecificViews")]
				public List<SpecificViewsItem> SpecificViews
				{
					get
					{
						return specificViews;
					}
					set	
					{
						specificViews = value;
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

				[JsonProperty(PropertyName = "ClusterName")]
				public string ClusterName
				{
					get
					{
						return clusterName;
					}
					set	
					{
						clusterName = value;
					}
				}

				[JsonProperty(PropertyName = "Name")]
				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
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

				[JsonProperty(PropertyName = "Id")]
				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				[JsonProperty(PropertyName = "SpecificTables")]
				public List<SpecificTablesItem> SpecificTables
				{
					get
					{
						return specificTables;
					}
					set	
					{
						specificTables = value;
					}
				}

				[JsonProperty(PropertyName = "Views")]
				public List<ViewsItem> Views
				{
					get
					{
						return views;
					}
					set	
					{
						views = value;
					}
				}

				public class SpecificViewsItem
				{

					private string mappedName;

					private List<string> filterColumns = new List<string>(){ };

					private AdbTableSchema adbTableSchema_;

					private string name;

					private string whereClause;

					private string id;

					private List<string> shardColumns = new List<string>(){ };

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

					[JsonProperty(PropertyName = "Name")]
					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
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

					[JsonProperty(PropertyName = "Id")]
					public string Id
					{
						get
						{
							return id;
						}
						set	
						{
							id = value;
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

					public class AdbTableSchema
					{

						private List<string> primaryKeys = new List<string>(){ };

						private string partitionStatement;

						private string partitionLifeCycle;

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
						public string PartitionLifeCycle
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

				public class TablesItem
				{

					private string mappedName;

					private List<string> filterColumns = new List<string>(){ };

					private AdbTableSchema adbTableSchema_;

					private string name;

					private string whereClause;

					private string id;

					private List<string> shardColumns = new List<string>(){ };

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

					[JsonProperty(PropertyName = "Name")]
					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
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

					[JsonProperty(PropertyName = "Id")]
					public string Id
					{
						get
						{
							return id;
						}
						set	
						{
							id = value;
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

					public class AdbTableSchema
					{

						private List<string> primaryKeys = new List<string>(){ };

						private string partitionStatement;

						private string partitionLifeCycle;

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
						public string PartitionLifeCycle
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

				public class SpecificTablesItem
				{

					private string mappedName;

					private List<string> filterColumns = new List<string>(){ };

					private AdbTableSchema adbTableSchema_;

					private string name;

					private string whereClause;

					private string id;

					private List<string> shardColumns = new List<string>(){ };

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

					[JsonProperty(PropertyName = "Name")]
					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
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

					[JsonProperty(PropertyName = "Id")]
					public string Id
					{
						get
						{
							return id;
						}
						set	
						{
							id = value;
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

					public class AdbTableSchema
					{

						private List<string> primaryKeys = new List<string>(){ };

						private string partitionStatement;

						private string partitionLifeCycle;

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
						public string PartitionLifeCycle
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

				public class ViewsItem
				{

					private string mappedName;

					private List<string> filterColumns = new List<string>(){ };

					private AdbTableSchema adbTableSchema_;

					private string name;

					private string whereClause;

					private string id;

					private List<string> shardColumns = new List<string>(){ };

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

					[JsonProperty(PropertyName = "Name")]
					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
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

					[JsonProperty(PropertyName = "Id")]
					public string Id
					{
						get
						{
							return id;
						}
						set	
						{
							id = value;
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

					public class AdbTableSchema
					{

						private List<string> primaryKeys = new List<string>(){ };

						private string partitionStatement;

						private string partitionLifeCycle;

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
						public string PartitionLifeCycle
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

			public class DatabasesBlackItem
			{

				private string mappedName;

				private List<SpecificViewsItem> specificViews = new List<SpecificViewsItem>(){ };

				private List<TablesItem> tables = new List<TablesItem>(){ };

				private string clusterName;

				private string name;

				private string tenantName;

				private string id;

				private List<SpecificTablesItem> specificTables = new List<SpecificTablesItem>(){ };

				private List<ViewsItem> views = new List<ViewsItem>(){ };

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

				[JsonProperty(PropertyName = "SpecificViews")]
				public List<SpecificViewsItem> SpecificViews
				{
					get
					{
						return specificViews;
					}
					set	
					{
						specificViews = value;
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

				[JsonProperty(PropertyName = "ClusterName")]
				public string ClusterName
				{
					get
					{
						return clusterName;
					}
					set	
					{
						clusterName = value;
					}
				}

				[JsonProperty(PropertyName = "Name")]
				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
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

				[JsonProperty(PropertyName = "Id")]
				public string Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				[JsonProperty(PropertyName = "SpecificTables")]
				public List<SpecificTablesItem> SpecificTables
				{
					get
					{
						return specificTables;
					}
					set	
					{
						specificTables = value;
					}
				}

				[JsonProperty(PropertyName = "Views")]
				public List<ViewsItem> Views
				{
					get
					{
						return views;
					}
					set	
					{
						views = value;
					}
				}

				public class SpecificViewsItem
				{

					private string mappedName;

					private List<string> filterColumns = new List<string>(){ };

					private AdbTableSchema adbTableSchema_;

					private string name;

					private string whereClause;

					private string id;

					private List<string> shardColumns = new List<string>(){ };

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

					[JsonProperty(PropertyName = "Name")]
					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
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

					[JsonProperty(PropertyName = "Id")]
					public string Id
					{
						get
						{
							return id;
						}
						set	
						{
							id = value;
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

					public class AdbTableSchema
					{

						private List<string> primaryKeys = new List<string>(){ };

						private string partitionStatement;

						private string partitionLifeCycle;

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
						public string PartitionLifeCycle
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

				public class TablesItem
				{

					private string mappedName;

					private List<string> filterColumns = new List<string>(){ };

					private AdbTableSchema adbTableSchema_;

					private string name;

					private string whereClause;

					private string id;

					private List<string> shardColumns = new List<string>(){ };

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

					[JsonProperty(PropertyName = "Name")]
					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
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

					[JsonProperty(PropertyName = "Id")]
					public string Id
					{
						get
						{
							return id;
						}
						set	
						{
							id = value;
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

					public class AdbTableSchema
					{

						private List<string> primaryKeys = new List<string>(){ };

						private string partitionStatement;

						private string partitionLifeCycle;

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
						public string PartitionLifeCycle
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

				public class SpecificTablesItem
				{

					private string mappedName;

					private List<string> filterColumns = new List<string>(){ };

					private AdbTableSchema adbTableSchema_;

					private string name;

					private string whereClause;

					private string id;

					private List<string> shardColumns = new List<string>(){ };

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

					[JsonProperty(PropertyName = "Name")]
					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
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

					[JsonProperty(PropertyName = "Id")]
					public string Id
					{
						get
						{
							return id;
						}
						set	
						{
							id = value;
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

					public class AdbTableSchema
					{

						private List<string> primaryKeys = new List<string>(){ };

						private string partitionStatement;

						private string partitionLifeCycle;

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
						public string PartitionLifeCycle
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

				public class ViewsItem
				{

					private string mappedName;

					private List<string> filterColumns = new List<string>(){ };

					private AdbTableSchema adbTableSchema_;

					private string name;

					private string whereClause;

					private string id;

					private List<string> shardColumns = new List<string>(){ };

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

					[JsonProperty(PropertyName = "Name")]
					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
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

					[JsonProperty(PropertyName = "Id")]
					public string Id
					{
						get
						{
							return id;
						}
						set	
						{
							id = value;
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

					public class AdbTableSchema
					{

						private List<string> primaryKeys = new List<string>(){ };

						private string partitionStatement;

						private string partitionLifeCycle;

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
						public string PartitionLifeCycle
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

		public class CommonTransferConfig
		{

			private long? rocketMqSendMsgTimeout;

			private int? mqPartition;

			private string tableCategory;

			private bool? activeActive;

			private string datahubTopicType;

			private string rocketMqMsgTags;

			private bool? rocketMqEnableMsgTrace;

			private string dataWorksBusinessName;

			private string rocketMqProducerGroup;

			private string mqSerializerType;

			private string mqPartitionMode;

			[JsonProperty(PropertyName = "RocketMqSendMsgTimeout")]
			public long? RocketMqSendMsgTimeout
			{
				get
				{
					return rocketMqSendMsgTimeout;
				}
				set	
				{
					rocketMqSendMsgTimeout = value;
				}
			}

			[JsonProperty(PropertyName = "MqPartition")]
			public int? MqPartition
			{
				get
				{
					return mqPartition;
				}
				set	
				{
					mqPartition = value;
				}
			}

			[JsonProperty(PropertyName = "TableCategory")]
			public string TableCategory
			{
				get
				{
					return tableCategory;
				}
				set	
				{
					tableCategory = value;
				}
			}

			[JsonProperty(PropertyName = "ActiveActive")]
			public bool? ActiveActive
			{
				get
				{
					return activeActive;
				}
				set	
				{
					activeActive = value;
				}
			}

			[JsonProperty(PropertyName = "DatahubTopicType")]
			public string DatahubTopicType
			{
				get
				{
					return datahubTopicType;
				}
				set	
				{
					datahubTopicType = value;
				}
			}

			[JsonProperty(PropertyName = "RocketMqMsgTags")]
			public string RocketMqMsgTags
			{
				get
				{
					return rocketMqMsgTags;
				}
				set	
				{
					rocketMqMsgTags = value;
				}
			}

			[JsonProperty(PropertyName = "RocketMqEnableMsgTrace")]
			public bool? RocketMqEnableMsgTrace
			{
				get
				{
					return rocketMqEnableMsgTrace;
				}
				set	
				{
					rocketMqEnableMsgTrace = value;
				}
			}

			[JsonProperty(PropertyName = "DataWorksBusinessName")]
			public string DataWorksBusinessName
			{
				get
				{
					return dataWorksBusinessName;
				}
				set	
				{
					dataWorksBusinessName = value;
				}
			}

			[JsonProperty(PropertyName = "RocketMqProducerGroup")]
			public string RocketMqProducerGroup
			{
				get
				{
					return rocketMqProducerGroup;
				}
				set	
				{
					rocketMqProducerGroup = value;
				}
			}

			[JsonProperty(PropertyName = "MqSerializerType")]
			public string MqSerializerType
			{
				get
				{
					return mqSerializerType;
				}
				set	
				{
					mqSerializerType = value;
				}
			}

			[JsonProperty(PropertyName = "MqPartitionMode")]
			public string MqPartitionMode
			{
				get
				{
					return mqPartitionMode;
				}
				set	
				{
					mqPartitionMode = value;
				}
			}
		}

		public class StructTransferConfig
		{

			private string byteCharConvertStrategy;

			private bool? deferIndexCreation;

			[JsonProperty(PropertyName = "ByteCharConvertStrategy")]
			public string ByteCharConvertStrategy
			{
				get
				{
					return byteCharConvertStrategy;
				}
				set	
				{
					byteCharConvertStrategy = value;
				}
			}

			[JsonProperty(PropertyName = "DeferIndexCreation")]
			public bool? DeferIndexCreation
			{
				get
				{
					return deferIndexCreation;
				}
				set	
				{
					deferIndexCreation = value;
				}
			}
		}

		public class IncrTransferConfig
		{

			private bool? enableSequencingWithinTxn;

			private int? storeLogKeptHour;

			private string startTimestamp;

			private List<string> recordTypeWhiteList = new List<string>(){ };

			private int? incrSyncConcurrency;

			private bool? enableIncrSyncStatistics;

			[JsonProperty(PropertyName = "EnableSequencingWithinTxn")]
			public bool? EnableSequencingWithinTxn
			{
				get
				{
					return enableSequencingWithinTxn;
				}
				set	
				{
					enableSequencingWithinTxn = value;
				}
			}

			[JsonProperty(PropertyName = "StoreLogKeptHour")]
			public int? StoreLogKeptHour
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
			public string StartTimestamp
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

			[JsonProperty(PropertyName = "RecordTypeWhiteList")]
			public List<string> RecordTypeWhiteList
			{
				get
				{
					return recordTypeWhiteList;
				}
				set	
				{
					recordTypeWhiteList = value;
				}
			}

			[JsonProperty(PropertyName = "IncrSyncConcurrency")]
			public int? IncrSyncConcurrency
			{
				get
				{
					return incrSyncConcurrency;
				}
				set	
				{
					incrSyncConcurrency = value;
				}
			}

			[JsonProperty(PropertyName = "EnableIncrSyncStatistics")]
			public bool? EnableIncrSyncStatistics
			{
				get
				{
					return enableIncrSyncStatistics;
				}
				set	
				{
					enableIncrSyncStatistics = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateProjectResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateProjectResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
