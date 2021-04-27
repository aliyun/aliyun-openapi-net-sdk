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
using Aliyun.Acs.Sas.Transform;
using Aliyun.Acs.Sas.Transform.V20181203;

namespace Aliyun.Acs.Sas.Model.V20181203
{
    public class ModifyAntiBruteForceRuleRequest : RpcAcsRequest<ModifyAntiBruteForceRuleResponse>
    {
        public ModifyAntiBruteForceRuleRequest()
            : base("Sas", "2018-12-03", "ModifyAntiBruteForceRule", "sas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private int? forbiddenTime;

		private int? failCount;

		private string sourceIp;

		private List<string> uuidLists = new List<string>(){ };

		private long? id;

		private string name;

		private int? span;

		private bool? defaultRule;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public int? ForbiddenTime
		{
			get
			{
				return forbiddenTime;
			}
			set	
			{
				forbiddenTime = value;
				DictionaryUtil.Add(QueryParameters, "ForbiddenTime", value.ToString());
			}
		}

		public int? FailCount
		{
			get
			{
				return failCount;
			}
			set	
			{
				failCount = value;
				DictionaryUtil.Add(QueryParameters, "FailCount", value.ToString());
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

		public List<string> UuidLists
		{
			get
			{
				return uuidLists;
			}

			set
			{
				uuidLists = value;
				for (int i = 0; i < uuidLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"UuidList." + (i + 1) , uuidLists[i]);
				}
			}
		}

		public long? Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value.ToString());
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

		public int? Span
		{
			get
			{
				return span;
			}
			set	
			{
				span = value;
				DictionaryUtil.Add(QueryParameters, "Span", value.ToString());
			}
		}

		public bool? DefaultRule
		{
			get
			{
				return defaultRule;
			}
			set	
			{
				defaultRule = value;
				DictionaryUtil.Add(QueryParameters, "DefaultRule", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyAntiBruteForceRuleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyAntiBruteForceRuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
