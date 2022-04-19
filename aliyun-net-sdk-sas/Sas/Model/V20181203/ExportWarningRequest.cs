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
using Aliyun.Acs.Sas;
using Aliyun.Acs.Sas.Transform;
using Aliyun.Acs.Sas.Transform.V20181203;

namespace Aliyun.Acs.Sas.Model.V20181203
{
    public class ExportWarningRequest : RpcAcsRequest<ExportWarningResponse>
    {
        public ExportWarningRequest()
            : base("Sas", "2018-12-03", "ExportWarning")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? isCleartextPwd;

		private string statusList;

		private string riskLevels;

		private string riskName;

		private string sourceIp;

		private string lang;

		private string exportType;

		private string dealed;

		private string typeNames;

		private int? isSummaryExport;

		private string riskIds;

		private long? strategyId;

		private string typeName;

		private string subTypeNames;

		private string uuids;

		public int? IsCleartextPwd
		{
			get
			{
				return isCleartextPwd;
			}
			set	
			{
				isCleartextPwd = value;
				DictionaryUtil.Add(QueryParameters, "IsCleartextPwd", value.ToString());
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

		public string RiskLevels
		{
			get
			{
				return riskLevels;
			}
			set	
			{
				riskLevels = value;
				DictionaryUtil.Add(QueryParameters, "RiskLevels", value);
			}
		}

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

		public string ExportType
		{
			get
			{
				return exportType;
			}
			set	
			{
				exportType = value;
				DictionaryUtil.Add(QueryParameters, "ExportType", value);
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

		public string TypeNames
		{
			get
			{
				return typeNames;
			}
			set	
			{
				typeNames = value;
				DictionaryUtil.Add(QueryParameters, "TypeNames", value);
			}
		}

		public int? IsSummaryExport
		{
			get
			{
				return isSummaryExport;
			}
			set	
			{
				isSummaryExport = value;
				DictionaryUtil.Add(QueryParameters, "IsSummaryExport", value.ToString());
			}
		}

		public string RiskIds
		{
			get
			{
				return riskIds;
			}
			set	
			{
				riskIds = value;
				DictionaryUtil.Add(QueryParameters, "RiskIds", value);
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

		public string TypeName
		{
			get
			{
				return typeName;
			}
			set	
			{
				typeName = value;
				DictionaryUtil.Add(QueryParameters, "TypeName", value);
			}
		}

		public string SubTypeNames
		{
			get
			{
				return subTypeNames;
			}
			set	
			{
				subTypeNames = value;
				DictionaryUtil.Add(QueryParameters, "SubTypeNames", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ExportWarningResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ExportWarningResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
