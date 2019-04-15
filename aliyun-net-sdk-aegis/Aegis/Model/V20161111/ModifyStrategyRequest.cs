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
    public class ModifyStrategyRequest : RpcAcsRequest<ModifyStrategyResponse>
    {
        public ModifyStrategyRequest()
            : base("aegis", "2016-11-11", "ModifyStrategy", "vipaegis", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string riskSubTypeName;

		private string sourceIp;

		private string cycleStartTime;

		private string name;

		private string cycleDays;

		private string id;

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
