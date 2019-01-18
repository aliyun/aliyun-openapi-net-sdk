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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.aegis.Transform;
using Aliyun.Acs.aegis.Transform.V20161111;
using System.Collections.Generic;

namespace Aliyun.Acs.aegis.Model.V20161111
{
    public class DescribeVulListRequest : RpcAcsRequest<DescribeVulListResponse>
    {
        public DescribeVulListRequest()
            : base("aegis", "2016-11-11", "DescribeVulList", "vipaegis", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string product;

		private string statusList;

		private string level;

		private string resource;

		private string orderBy;

		private string dealed;

		private int? currentPage;

		private string type;

		private long? lastTsEnd;

		private string batchName;

		private long? patchId;

		private string aliasName;

		private string sourceIp;

		private string name;

		private int? pageSize;

		private string lang;

		private long? lastTsStart;

		private string necessity;

		private string uuids;

		private string direction;

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

		public string Product
		{
			get
			{
				return product;
			}
			set	
			{
				product = value;
				DictionaryUtil.Add(QueryParameters, "Product", value);
			}
		}

		public string StatusList
		{
			get
			{
				return statusList;
			}
			set	
			{
				statusList = value;
				DictionaryUtil.Add(QueryParameters, "StatusList", value);
			}
		}

		public string Level
		{
			get
			{
				return level;
			}
			set	
			{
				level = value;
				DictionaryUtil.Add(QueryParameters, "Level", value);
			}
		}

		public string Resource
		{
			get
			{
				return resource;
			}
			set	
			{
				resource = value;
				DictionaryUtil.Add(QueryParameters, "Resource", value);
			}
		}

		public string OrderBy
		{
			get
			{
				return orderBy;
			}
			set	
			{
				orderBy = value;
				DictionaryUtil.Add(QueryParameters, "OrderBy", value);
			}
		}

		public string Dealed
		{
			get
			{
				return dealed;
			}
			set	
			{
				dealed = value;
				DictionaryUtil.Add(QueryParameters, "Dealed", value);
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(QueryParameters, "CurrentPage", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public long? LastTsEnd
		{
			get
			{
				return lastTsEnd;
			}
			set	
			{
				lastTsEnd = value;
				DictionaryUtil.Add(QueryParameters, "LastTsEnd", value.ToString());
			}
		}

		public string BatchName
		{
			get
			{
				return batchName;
			}
			set	
			{
				batchName = value;
				DictionaryUtil.Add(QueryParameters, "BatchName", value);
			}
		}

		public long? PatchId
		{
			get
			{
				return patchId;
			}
			set	
			{
				patchId = value;
				DictionaryUtil.Add(QueryParameters, "PatchId", value.ToString());
			}
		}

		public string AliasName
		{
			get
			{
				return aliasName;
			}
			set	
			{
				aliasName = value;
				DictionaryUtil.Add(QueryParameters, "AliasName", value);
			}
		}

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public long? LastTsStart
		{
			get
			{
				return lastTsStart;
			}
			set	
			{
				lastTsStart = value;
				DictionaryUtil.Add(QueryParameters, "LastTsStart", value.ToString());
			}
		}

		public string Necessity
		{
			get
			{
				return necessity;
			}
			set	
			{
				necessity = value;
				DictionaryUtil.Add(QueryParameters, "Necessity", value);
			}
		}

		public string Uuids
		{
			get
			{
				return uuids;
			}
			set	
			{
				uuids = value;
				DictionaryUtil.Add(QueryParameters, "Uuids", value);
			}
		}

		public string Direction
		{
			get
			{
				return direction;
			}
			set	
			{
				direction = value;
				DictionaryUtil.Add(QueryParameters, "Direction", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeVulListResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeVulListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}