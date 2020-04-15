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
using Aliyun.Acs.Trademark.Transform;
using Aliyun.Acs.Trademark.Transform.V20180724;

namespace Aliyun.Acs.Trademark.Model.V20180724
{
    public class QueryTrademarkMonitorResultsRequest : RpcAcsRequest<QueryTrademarkMonitorResultsResponse>
    {
        public QueryTrademarkMonitorResultsRequest()
            : base("Trademark", "2018-07-24", "QueryTrademarkMonitorResults", "trademark", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private int? actionType;

		private string tmName;

		private string classification;

		private int? pageNum;

		private string registrationNumber;

		private string applyYear;

		private int? pageSize;

		private int? procedureStatus;

		private long? ruleId;

		public int? ActionType
		{
			get
			{
				return actionType;
			}
			set	
			{
				actionType = value;
				DictionaryUtil.Add(QueryParameters, "ActionType", value.ToString());
			}
		}

		public string TmName
		{
			get
			{
				return tmName;
			}
			set	
			{
				tmName = value;
				DictionaryUtil.Add(QueryParameters, "TmName", value);
			}
		}

		public string Classification
		{
			get
			{
				return classification;
			}
			set	
			{
				classification = value;
				DictionaryUtil.Add(QueryParameters, "Classification", value);
			}
		}

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
			}
		}

		public string RegistrationNumber
		{
			get
			{
				return registrationNumber;
			}
			set	
			{
				registrationNumber = value;
				DictionaryUtil.Add(QueryParameters, "RegistrationNumber", value);
			}
		}

		public string ApplyYear
		{
			get
			{
				return applyYear;
			}
			set	
			{
				applyYear = value;
				DictionaryUtil.Add(QueryParameters, "ApplyYear", value);
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

		public int? ProcedureStatus
		{
			get
			{
				return procedureStatus;
			}
			set	
			{
				procedureStatus = value;
				DictionaryUtil.Add(QueryParameters, "ProcedureStatus", value.ToString());
			}
		}

		public long? RuleId
		{
			get
			{
				return ruleId;
			}
			set	
			{
				ruleId = value;
				DictionaryUtil.Add(QueryParameters, "RuleId", value.ToString());
			}
		}

        public override QueryTrademarkMonitorResultsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryTrademarkMonitorResultsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
