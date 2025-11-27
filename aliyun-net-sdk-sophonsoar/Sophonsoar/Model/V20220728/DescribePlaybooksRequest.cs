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
using Aliyun.Acs.sophonsoar;
using Aliyun.Acs.sophonsoar.Transform;
using Aliyun.Acs.sophonsoar.Transform.V20220728;

namespace Aliyun.Acs.sophonsoar.Model.V20220728
{
    public class DescribePlaybooksRequest : RpcAcsRequest<DescribePlaybooksResponse>
    {
        public DescribePlaybooksRequest()
            : base("sophonsoar", "2022-07-28", "DescribePlaybooks")
        {
			Protocol = ProtocolType.HTTPS;
        }

		private long? endMillis;

		private long? pageNumber;

		private string playbookUuids;

		private int? pageSize;

		private string lang;

		private string order;

		private string paramTypes;

		private int? active;

		private string ownType;

		private int? sort;

		private long? startMillis;

		private string playbookUuid;

		private string name;

		public long? EndMillis
		{
			get
			{
				return endMillis;
			}
			set	
			{
				endMillis = value;
				DictionaryUtil.Add(QueryParameters, "EndMillis", value.ToString());
			}
		}

		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string PlaybookUuids
		{
			get
			{
				return playbookUuids;
			}
			set	
			{
				playbookUuids = value;
				DictionaryUtil.Add(QueryParameters, "PlaybookUuids", value);
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

		public string Order
		{
			get
			{
				return order;
			}
			set	
			{
				order = value;
				DictionaryUtil.Add(QueryParameters, "Order", value);
			}
		}

		public string ParamTypes
		{
			get
			{
				return paramTypes;
			}
			set	
			{
				paramTypes = value;
				DictionaryUtil.Add(QueryParameters, "ParamTypes", value);
			}
		}

		public int? Active
		{
			get
			{
				return active;
			}
			set	
			{
				active = value;
				DictionaryUtil.Add(QueryParameters, "Active", value.ToString());
			}
		}

		public string OwnType
		{
			get
			{
				return ownType;
			}
			set	
			{
				ownType = value;
				DictionaryUtil.Add(QueryParameters, "OwnType", value);
			}
		}

		public int? Sort
		{
			get
			{
				return sort;
			}
			set	
			{
				sort = value;
				DictionaryUtil.Add(QueryParameters, "Sort", value.ToString());
			}
		}

		public long? StartMillis
		{
			get
			{
				return startMillis;
			}
			set	
			{
				startMillis = value;
				DictionaryUtil.Add(QueryParameters, "StartMillis", value.ToString());
			}
		}

		public string PlaybookUuid
		{
			get
			{
				return playbookUuid;
			}
			set	
			{
				playbookUuid = value;
				DictionaryUtil.Add(QueryParameters, "PlaybookUuid", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribePlaybooksResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribePlaybooksResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
