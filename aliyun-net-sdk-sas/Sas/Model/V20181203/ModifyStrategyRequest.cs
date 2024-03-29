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
    public class ModifyStrategyRequest : RpcAcsRequest<ModifyStrategyResponse>
    {
        public ModifyStrategyRequest()
            : base("Sas", "2018-12-03", "ModifyStrategy")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string cycleDays;

		private string riskSubTypeName;

		private string sourceIp;

		private string id;

		private string riskCustomParams;

		private string customType;

		private string cycleStartTime;

		private string name;

		public string CycleDays
		{
			get
			{
				return cycleDays;
			}
			set	
			{
				cycleDays = value;
				DictionaryUtil.Add(QueryParameters, "CycleDays", value);
			}
		}

		public string RiskSubTypeName
		{
			get
			{
				return riskSubTypeName;
			}
			set	
			{
				riskSubTypeName = value;
				DictionaryUtil.Add(QueryParameters, "RiskSubTypeName", value);
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

		public string Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value);
			}
		}

		public string RiskCustomParams
		{
			get
			{
				return riskCustomParams;
			}
			set	
			{
				riskCustomParams = value;
				DictionaryUtil.Add(QueryParameters, "RiskCustomParams", value);
			}
		}

		public string CustomType
		{
			get
			{
				return customType;
			}
			set	
			{
				customType = value;
				DictionaryUtil.Add(QueryParameters, "CustomType", value);
			}
		}

		public string CycleStartTime
		{
			get
			{
				return cycleStartTime;
			}
			set	
			{
				cycleStartTime = value;
				DictionaryUtil.Add(QueryParameters, "CycleStartTime", value);
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

        public override ModifyStrategyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyStrategyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
