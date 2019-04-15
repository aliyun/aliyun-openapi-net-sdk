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
    public class ExportWarningRequest : RpcAcsRequest<ExportWarningResponse>
    {
        public ExportWarningRequest()
            : base("aegis", "2016-11-11", "ExportWarning", "vipaegis", "openAPI")
        {
        }

		private string statusList;

		private string riskLevels;

		private string exportType;

		private string dealed;

		private string typeNames;

		private int? isSummaryExport;

		private string riskName;

		private string riskIds;

		private string sourceIp;

		private long? strategyId;

		private string lang;

		private string typeName;

		private string subTypeNames;

		private string uuids;

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
