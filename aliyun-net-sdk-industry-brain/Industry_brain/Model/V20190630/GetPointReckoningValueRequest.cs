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
using Aliyun.Acs.industry_brain;
using Aliyun.Acs.industry_brain.Transform;
using Aliyun.Acs.industry_brain.Transform.V20190630;

namespace Aliyun.Acs.industry_brain.Model.V20190630
{
    public class GetPointReckoningValueRequest : RpcAcsRequest<GetPointReckoningValueResponse>
    {
        public GetPointReckoningValueRequest()
            : base("industry-brain", "2019-06-30", "GetPointReckoningValue")
        {
			Method = MethodType.POST;
        }

		private string timeType;

		private string templateId;

		public string TimeType
		{
			get
			{
				return timeType;
			}
			set	
			{
				timeType = value;
				DictionaryUtil.Add(QueryParameters, "TimeType", value);
			}
		}

		public string TemplateId
		{
			get
			{
				return templateId;
			}
			set	
			{
				templateId = value;
				DictionaryUtil.Add(QueryParameters, "TemplateId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetPointReckoningValueResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetPointReckoningValueResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
