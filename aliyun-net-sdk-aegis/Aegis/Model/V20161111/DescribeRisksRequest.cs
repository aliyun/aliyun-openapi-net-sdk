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
    public class DescribeRisksRequest : RpcAcsRequest<DescribeRisksResponse>
    {
        public DescribeRisksRequest()
            : base("aegis", "2016-11-11", "DescribeRisks", "vipaegis", "openAPI")
        {
        }

		private string riskName;

		private string sourceIp;

		private int? limit;

		private string lang;

		private long? riskId;

		public string RiskName
		{
			get
			{
				return riskName;
			}
			set	
			{
				riskName = value;
				DictionaryUtil.Add(QueryParameters, "RiskName", value);
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

		public int? Limit
		{
			get
			{
				return limit;
			}
			set	
			{
				limit = value;
				DictionaryUtil.Add(QueryParameters, "Limit", value.ToString());
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

		public long? RiskId
		{
			get
			{
				return riskId;
			}
			set	
			{
				riskId = value;
				DictionaryUtil.Add(QueryParameters, "RiskId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeRisksResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeRisksResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
