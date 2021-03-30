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
using Aliyun.Acs.dataworks_public;
using Aliyun.Acs.dataworks_public.Transform;
using Aliyun.Acs.dataworks_public.Transform.V20200518;

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
    public class UpdateTableRequest : RpcAcsRequest<UpdateTableResponse>
    {
        public UpdateTableRequest()
            : base("dataworks-public", "2020-05-18", "UpdateTable")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<Columns> columnss = new List<Columns>(){ };

		private int? lifeCycle;

		private List<Themes> themess = new List<Themes>(){ };

		private long? logicalLevelId;

		private string endpoint;

		private int? envType;

		private int? hasPart;

		private string tableName;

		private string appGuid;

		private long? projectId;

		private long? categoryId;

		private int? visibility;

		private long? physicsLevelId;

		private string ownerId;

		private int? isView;

		private string externalTableType;

		private string location;

		private string comment;

		private bool? createIfNotExists;

		public List<Columns> Columnss
		{
			get
			{
				return columnss;
			}

			set
			{
				columnss = value;
				for (int i = 0; i < columnss.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"Columns." + (i + 1) + ".SeqNumber", columnss[i].SeqNumber);
					DictionaryUtil.Add(BodyParameters,"Columns." + (i + 1) + ".IsPartitionCol", columnss[i].IsPartitionCol);
					DictionaryUtil.Add(BodyParameters,"Columns." + (i + 1) + ".ColumnNameCn", columnss[i].ColumnNameCn);
					DictionaryUtil.Add(BodyParameters,"Columns." + (i + 1) + ".Length", columnss[i].Length);
					DictionaryUtil.Add(BodyParameters,"Columns." + (i + 1) + ".Comment", columnss[i].Comment);
					DictionaryUtil.Add(BodyParameters,"Columns." + (i + 1) + ".ColumnName", columnss[i].ColumnName);
					DictionaryUtil.Add(BodyParameters,"Columns." + (i + 1) + ".ColumnType", columnss[i].ColumnType);
				}
			}
		}

		public int? LifeCycle
		{
			get
			{
				return lifeCycle;
			}
			set	
			{
				lifeCycle = value;
				DictionaryUtil.Add(QueryParameters, "LifeCycle", value.ToString());
			}
		}

		public List<Themes> Themess
		{
			get
			{
				return themess;
			}

			set
			{
				themess = value;
				for (int i = 0; i < themess.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"Themes." + (i + 1) + ".ThemeLevel", themess[i].ThemeLevel);
					DictionaryUtil.Add(BodyParameters,"Themes." + (i + 1) + ".ThemeId", themess[i].ThemeId);
				}
			}
		}

		public long? LogicalLevelId
		{
			get
			{
				return logicalLevelId;
			}
			set	
			{
				logicalLevelId = value;
				DictionaryUtil.Add(QueryParameters, "LogicalLevelId", value.ToString());
			}
		}

		public string Endpoint
		{
			get
			{
				return endpoint;
			}
			set	
			{
				endpoint = value;
				DictionaryUtil.Add(BodyParameters, "Endpoint", value);
			}
		}

		public int? EnvType
		{
			get
			{
				return envType;
			}
			set	
			{
				envType = value;
				DictionaryUtil.Add(BodyParameters, "EnvType", value.ToString());
			}
		}

		public int? HasPart
		{
			get
			{
				return hasPart;
			}
			set	
			{
				hasPart = value;
				DictionaryUtil.Add(QueryParameters, "HasPart", value.ToString());
			}
		}

		public string TableName
		{
			get
			{
				return tableName;
			}
			set	
			{
				tableName = value;
				DictionaryUtil.Add(QueryParameters, "TableName", value);
			}
		}

		public string AppGuid
		{
			get
			{
				return appGuid;
			}
			set	
			{
				appGuid = value;
				DictionaryUtil.Add(QueryParameters, "AppGuid", value);
			}
		}

		public long? ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(QueryParameters, "ProjectId", value.ToString());
			}
		}

		public long? CategoryId
		{
			get
			{
				return categoryId;
			}
			set	
			{
				categoryId = value;
				DictionaryUtil.Add(QueryParameters, "CategoryId", value.ToString());
			}
		}

		public int? Visibility
		{
			get
			{
				return visibility;
			}
			set	
			{
				visibility = value;
				DictionaryUtil.Add(QueryParameters, "Visibility", value.ToString());
			}
		}

		public long? PhysicsLevelId
		{
			get
			{
				return physicsLevelId;
			}
			set	
			{
				physicsLevelId = value;
				DictionaryUtil.Add(QueryParameters, "PhysicsLevelId", value.ToString());
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

		public int? IsView
		{
			get
			{
				return isView;
			}
			set	
			{
				isView = value;
				DictionaryUtil.Add(QueryParameters, "IsView", value.ToString());
			}
		}

		public string ExternalTableType
		{
			get
			{
				return externalTableType;
			}
			set	
			{
				externalTableType = value;
				DictionaryUtil.Add(QueryParameters, "ExternalTableType", value);
			}
		}

		public string Location
		{
			get
			{
				return location;
			}
			set	
			{
				location = value;
				DictionaryUtil.Add(QueryParameters, "Location", value);
			}
		}

		public string Comment
		{
			get
			{
				return comment;
			}
			set	
			{
				comment = value;
				DictionaryUtil.Add(QueryParameters, "Comment", value);
			}
		}

		public bool? CreateIfNotExists
		{
			get
			{
				return createIfNotExists;
			}
			set	
			{
				createIfNotExists = value;
				DictionaryUtil.Add(QueryParameters, "CreateIfNotExists", value.ToString());
			}
		}

		public class Columns
		{

			private int? seqNumber;

			private bool? isPartitionCol;

			private string columnNameCn;

			private int? length;

			private string comment;

			private string columnName;

			private string columnType;

			public int? SeqNumber
			{
				get
				{
					return seqNumber;
				}
				set	
				{
					seqNumber = value;
				}
			}

			public bool? IsPartitionCol
			{
				get
				{
					return isPartitionCol;
				}
				set	
				{
					isPartitionCol = value;
				}
			}

			public string ColumnNameCn
			{
				get
				{
					return columnNameCn;
				}
				set	
				{
					columnNameCn = value;
				}
			}

			public int? Length
			{
				get
				{
					return length;
				}
				set	
				{
					length = value;
				}
			}

			public string Comment
			{
				get
				{
					return comment;
				}
				set	
				{
					comment = value;
				}
			}

			public string ColumnName
			{
				get
				{
					return columnName;
				}
				set	
				{
					columnName = value;
				}
			}

			public string ColumnType
			{
				get
				{
					return columnType;
				}
				set	
				{
					columnType = value;
				}
			}
		}

		public class Themes
		{

			private int? themeLevel;

			private long? themeId;

			public int? ThemeLevel
			{
				get
				{
					return themeLevel;
				}
				set	
				{
					themeLevel = value;
				}
			}

			public long? ThemeId
			{
				get
				{
					return themeId;
				}
				set	
				{
					themeId = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateTableResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateTableResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
