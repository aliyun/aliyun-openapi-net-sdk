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
    public class DescribeTotalStatisticsRequest : RpcAcsRequest<DescribeTotalStatisticsResponse>
    {
        public DescribeTotalStatisticsRequest()
            : base("aegis", "2016-11-11", "DescribeTotalStatistics", "vipaegis", "openAPI")
        {
        }

		private string statusList;

		private string saleId;

		private int? ruleType;

		private long? groupId;

		private string endTime;

		private string remark;

		private string dealed;

		private int? currentPage;

		private string startTime;

		private string type;

		private string uuid;

		private string secureToken;

		private string sourceIp;

		private long? webGroupId;

		private int? pageSize;

		private string from;

		private int? action1;

		private string tag;

		private int? flow;

		private int? status;

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

		public string SaleId
		{
			get
			{
				return saleId;
			}
			set	
			{
				saleId = value;
				DictionaryUtil.Add(QueryParameters, "SaleId", value);
			}
		}

		public int? RuleType
		{
			get
			{
				return ruleType;
			}
			set	
			{
				ruleType = value;
				DictionaryUtil.Add(QueryParameters, "RuleType", value.ToString());
			}
		}

		public long? GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value.ToString());
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
				DictionaryUtil.Add(QueryParameters, "Remark", value);
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

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
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

		public string Uuid
		{
			get
			{
				return uuid;
			}
			set	
			{
				uuid = value;
				DictionaryUtil.Add(QueryParameters, "Uuid", value);
			}
		}

		public string SecureToken
		{
			get
			{
				return secureToken;
			}
			set	
			{
				secureToken = value;
				DictionaryUtil.Add(QueryParameters, "SecureToken", value);
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

		public long? WebGroupId
		{
			get
			{
				return webGroupId;
			}
			set	
			{
				webGroupId = value;
				DictionaryUtil.Add(QueryParameters, "WebGroupId", value.ToString());
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

		public string From
		{
			get
			{
				return from;
			}
			set	
			{
				from = value;
				DictionaryUtil.Add(QueryParameters, "From", value);
			}
		}

		public int? Action1
		{
			get
			{
				return action1;
			}
			set	
			{
				action1 = value;
				DictionaryUtil.Add(QueryParameters, "Action1", value.ToString());
			}
		}

		public string Tag
		{
			get
			{
				return tag;
			}
			set	
			{
				tag = value;
				DictionaryUtil.Add(QueryParameters, "Tag", value);
			}
		}

		public int? Flow
		{
			get
			{
				return flow;
			}
			set	
			{
				flow = value;
				DictionaryUtil.Add(QueryParameters, "Flow", value.ToString());
			}
		}

		public int? Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeTotalStatisticsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeTotalStatisticsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
