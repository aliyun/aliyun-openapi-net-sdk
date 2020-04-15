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
using Aliyun.Acs.Yundun_ds.Transform;
using Aliyun.Acs.Yundun_ds.Transform.V20190103;

namespace Aliyun.Acs.Yundun_ds.Model.V20190103
{
    public class CreateRuleRequest : RpcAcsRequest<CreateRuleResponse>
    {
        public CreateRuleRequest()
            : base("Yundun-ds", "2019-01-03", "CreateRule", "sddp", "openAPI")
        {
        }

		private long? riskLevelId;

		private string content;

		private string lang;

		private int? featureType;

		private long? customType;

		private string name;

		private int? category;

		public long? RiskLevelId
		{
			get
			{
				return riskLevelId;
			}
			set	
			{
				riskLevelId = value;
				DictionaryUtil.Add(QueryParameters, "RiskLevelId", value.ToString());
			}
		}

		public string Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
				DictionaryUtil.Add(QueryParameters, "Content", value);
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

		public int? FeatureType
		{
			get
			{
				return featureType;
			}
			set	
			{
				featureType = value;
				DictionaryUtil.Add(QueryParameters, "FeatureType", value.ToString());
			}
		}

		public long? CustomType
		{
			get
			{
				return customType;
			}
			set	
			{
				customType = value;
				DictionaryUtil.Add(QueryParameters, "CustomType", value.ToString());
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

		public int? Category
		{
			get
			{
				return category;
			}
			set	
			{
				category = value;
				DictionaryUtil.Add(QueryParameters, "Category", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateRuleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateRuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
