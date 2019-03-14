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
    public class MetastoreUpdateTableRequest : RpcAcsRequest<MetastoreUpdateTableResponse>
    {
        public MetastoreUpdateTableRequest()
            : base("Emr", "2016-04-08", "MetastoreUpdateTable", "emr", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string regionId;

		private List<AddColumn> addColumns;

		private List<AddPartition> addPartitions;

		private List<string> deleteColumnNames;

		private string tableId;

		private List<string> deletePartitionNames;

		private string accessKeyId;

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

		public List<AddColumn> AddColumns
		{
			get
			{
				return addColumns;
			}

			set
			{
				addColumns = value;
				for (int i = 0; i < addColumns.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"AddColumn." + (i + 1) + ".Name", addColumns[i].Name);
					DictionaryUtil.Add(QueryParameters,"AddColumn." + (i + 1) + ".Comment", addColumns[i].Comment);
					DictionaryUtil.Add(QueryParameters,"AddColumn." + (i + 1) + ".Type", addColumns[i].Type);
				}
			}
		}

		public List<AddPartition> AddPartitions
		{
			get
			{
				return addPartitions;
			}

			set
			{
				addPartitions = value;
				for (int i = 0; i < addPartitions.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"AddPartition." + (i + 1) + ".Name", addPartitions[i].Name);
					DictionaryUtil.Add(QueryParameters,"AddPartition." + (i + 1) + ".Comment", addPartitions[i].Comment);
					DictionaryUtil.Add(QueryParameters,"AddPartition." + (i + 1) + ".Type", addPartitions[i].Type);
				}
			}
		}

		public List<string> DeleteColumnNames
		{
			get
			{
				return deleteColumnNames;
			}

			set
			{
				deleteColumnNames = value;
				for (int i = 0; i < deleteColumnNames.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DeleteColumnName." + (i + 1) , deleteColumnNames[i]);
				}
			}
		}

		public string TableId
		{
			get
			{
				return tableId;
			}
			set	
			{
				tableId = value;
				DictionaryUtil.Add(QueryParameters, "TableId", value);
			}
		}

		public List<string> DeletePartitionNames
		{
			get
			{
				return deletePartitionNames;
			}

			set
			{
				deletePartitionNames = value;
				for (int i = 0; i < deletePartitionNames.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DeletePartitionName." + (i + 1) , deletePartitionNames[i]);
				}
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

		public class AddColumn
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

		public class AddPartition
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

        public override MetastoreUpdateTableResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return MetastoreUpdateTableResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
