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
    public class DescribeSasLeftConditionRequest : RpcAcsRequest<DescribeSasLeftConditionResponse>
    {
        public DescribeSasLeftConditionRequest()
            : base("aegis", "2016-11-11", "DescribeSasLeftCondition", "vipaegis", "openAPI")
        {
        }

		private string sourceIp;

		private string conditionType;

		private string lang;

		private string filterConditions;

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

		public string ConditionType
		{
			get
			{
				return conditionType;
			}
			set	
			{
				conditionType = value;
				DictionaryUtil.Add(QueryParameters, "ConditionType", value);
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

		public string FilterConditions
		{
			get
			{
				return filterConditions;
			}
			set	
			{
				filterConditions = value;
				DictionaryUtil.Add(QueryParameters, "FilterConditions", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeSasLeftConditionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeSasLeftConditionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
