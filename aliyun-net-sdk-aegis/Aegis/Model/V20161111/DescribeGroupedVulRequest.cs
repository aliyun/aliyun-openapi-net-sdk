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
using Aliyun.Acs.aegis.Transform;
using Aliyun.Acs.aegis.Transform.V20161111;

namespace Aliyun.Acs.aegis.Model.V20161111
{
    public class DescribeGroupedVulRequest : RpcAcsRequest<DescribeGroupedVulResponse>
    {
        public DescribeGroupedVulRequest()
            : base("aegis", "2016-11-11", "DescribeGroupedVul", "vipaegis", "openAPI")
        {
        }

		private string statusList;

		private string level;

		private string orderBy;

		private string dealed;

		private int? currentPage;

		private string type;

		private long? lastTsEnd;

		private long? createTsStart;

		private string aliasName;

		private long? patchId;

		private string sourceIp;

		private string name;

		private int? pageSize;

		private string lang;

		private long? createTsEnd;

		private long? lastTsStart;

		private string necessity;

		private string uuids;

		private string direction;

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

		public long? CreateTsStart
		{
			get
			{
				return createTsStart;
			}
			set	
			{
				createTsStart = value;
				DictionaryUtil.Add(QueryParameters, "CreateTsStart", value.ToString());
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

		public long? CreateTsEnd
		{
			get
			{
				return createTsEnd;
			}
			set	
			{
				createTsEnd = value;
				DictionaryUtil.Add(QueryParameters, "CreateTsEnd", value.ToString());
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

        public override DescribeGroupedVulResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeGroupedVulResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
