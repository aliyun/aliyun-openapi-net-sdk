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
    public class DescribeWhiteListProcessRequest : RpcAcsRequest<DescribeWhiteListProcessResponse>
    {
        public DescribeWhiteListProcessRequest()
            : base("aegis", "2016-11-11", "DescribeWhiteListProcess", "vipaegis", "openAPI")
        {
        }

		private string sourceIp;

		private string processName;

		private int? pageSize;

		private int? processType;

		private int? orderBy;

		private long? strategyId;

		private int? currentPage;

		private string lang;

		private int? desc;

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

		public string ProcessName
		{
			get
			{
				return processName;
			}
			set	
			{
				processName = value;
				DictionaryUtil.Add(QueryParameters, "ProcessName", value);
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

		public int? ProcessType
		{
			get
			{
				return processType;
			}
			set	
			{
				processType = value;
				DictionaryUtil.Add(QueryParameters, "ProcessType", value.ToString());
			}
		}

		public int? OrderBy
		{
			get
			{
				return orderBy;
			}
			set	
			{
				orderBy = value;
				DictionaryUtil.Add(QueryParameters, "OrderBy", value.ToString());
			}
		}

		public long? StrategyId
		{
			get
			{
				return strategyId;
			}
			set	
			{
				strategyId = value;
				DictionaryUtil.Add(QueryParameters, "StrategyId", value.ToString());
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

		public int? Desc
		{
			get
			{
				return desc;
			}
			set	
			{
				desc = value;
				DictionaryUtil.Add(QueryParameters, "Desc", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeWhiteListProcessResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeWhiteListProcessResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
