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
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class MetastoreCreateTableRequest : RpcAcsRequest<MetastoreCreateTableResponse>
    {
        public MetastoreCreateTableRequest()
            : base("Emr", "2016-04-08", "MetastoreCreateTable", "emr", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string fieldDelimiter;

		private List<Column> columns;

		private string createWith;

		private string accessKeyId;

		private List<Partition> partitions;

		private string dbName;

		private string regionId;

		private string createSql;

		private string comment;

		private string locationUri;

		private string tableName;

		private string databaseId;

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

		public string FieldDelimiter
		{
			get
			{
				return fieldDelimiter;
			}
			set	
			{
				fieldDelimiter = value;
				DictionaryUtil.Add(QueryParameters, "FieldDelimiter", value);
			}
		}

		public List<Column> Columns
		{
			get
			{
				return columns;
			}

			set
			{
				columns = value;
				for (int i = 0; i < columns.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Column." + (i + 1) + ".Name", columns[i].Name);
					DictionaryUtil.Add(QueryParameters,"Column." + (i + 1) + ".Comment", columns[i].Comment);
					DictionaryUtil.Add(QueryParameters,"Column." + (i + 1) + ".Type", columns[i].Type);
				}
			}
		}

		public string CreateWith
		{
			get
			{
				return createWith;
			}
			set	
			{
				createWith = value;
				DictionaryUtil.Add(QueryParameters, "CreateWith", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public List<Partition> Partitions
		{
			get
			{
				return partitions;
			}

			set
			{
				partitions = value;
				for (int i = 0; i < partitions.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Partition." + (i + 1) + ".Name", partitions[i].Name);
					DictionaryUtil.Add(QueryParameters,"Partition." + (i + 1) + ".Comment", partitions[i].Comment);
					DictionaryUtil.Add(QueryParameters,"Partition." + (i + 1) + ".Type", partitions[i].Type);
				}
			}
		}

		public string DbName
		{
			get
			{
				return dbName;
			}
			set	
			{
				dbName = value;
				DictionaryUtil.Add(QueryParameters, "DbName", value);
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
			}
		}

		public string CreateSql
		{
			get
			{
				return createSql;
			}
			set	
			{
				createSql = value;
				DictionaryUtil.Add(QueryParameters, "CreateSql", value);
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

		public string LocationUri
		{
			get
			{
				return locationUri;
			}
			set	
			{
				locationUri = value;
				DictionaryUtil.Add(QueryParameters, "LocationUri", value);
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

		public string DatabaseId
		{
			get
			{
				return databaseId;
			}
			set	
			{
				databaseId = value;
				DictionaryUtil.Add(QueryParameters, "DatabaseId", value);
			}
		}

		public class Column
		{

			private string name;

			private string comment;

			private string type;

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
		}

		public class Partition
		{

			private string name;

			private string comment;

			private string type;

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
		}

        public override MetastoreCreateTableResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return MetastoreCreateTableResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
