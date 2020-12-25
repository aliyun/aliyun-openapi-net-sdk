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
    public class DumpMetaDataSourceForOuterRequest : RpcAcsRequest<DumpMetaDataSourceForOuterResponse>
    {
        public DumpMetaDataSourceForOuterRequest()
            : base("Emr", "2016-04-08", "DumpMetaDataSourceForOuter", "emr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private bool? dumpAllDatabase;

		private int? dumpLimit;

		private string clusterId;

		private bool? dumpAllTable;

		private List<string> partitionValuess = new List<string>(){ };

		private string tableId;

		private string databaseId;

		private bool? dumpAllPartition;

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

		public bool? DumpAllDatabase
		{
			get
			{
				return dumpAllDatabase;
			}
			set	
			{
				dumpAllDatabase = value;
				DictionaryUtil.Add(QueryParameters, "DumpAllDatabase", value.ToString());
			}
		}

		public int? DumpLimit
		{
			get
			{
				return dumpLimit;
			}
			set	
			{
				dumpLimit = value;
				DictionaryUtil.Add(QueryParameters, "DumpLimit", value.ToString());
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public bool? DumpAllTable
		{
			get
			{
				return dumpAllTable;
			}
			set	
			{
				dumpAllTable = value;
				DictionaryUtil.Add(QueryParameters, "DumpAllTable", value.ToString());
			}
		}

		public List<string> PartitionValuess
		{
			get
			{
				return partitionValuess;
			}

			set
			{
				partitionValuess = value;
				for (int i = 0; i < partitionValuess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"PartitionValues." + (i + 1) , partitionValuess[i]);
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

		public bool? DumpAllPartition
		{
			get
			{
				return dumpAllPartition;
			}
			set	
			{
				dumpAllPartition = value;
				DictionaryUtil.Add(QueryParameters, "DumpAllPartition", value.ToString());
			}
		}

        public override DumpMetaDataSourceForOuterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DumpMetaDataSourceForOuterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
